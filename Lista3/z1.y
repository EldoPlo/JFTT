%{
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#define BASE 1234577

int mul(int x, int y, int n);
int mod(int x, int n);
int modDiv(int x, int y);
int gcdExtended(int x, int y, int *i, int *j);
int modPow(int x, int y);
int yyerror(char *msg);
int yylex();

%}

%union {
    int num;
}

%token <num> NUM
%left ADD SUB
%left MUL DIV
%right POW
%precedence NEG

%type <num> powexpr expr line

%%

line:
    expr { printf("\n= %d\n", mod($1, BASE)); }
    | { printf("\n"); }
    ;

expr:
    expr ADD expr { printf("+ "); $$ = mod($1 + $3, BASE); }
    | expr SUB expr { printf("- "); $$ = mod($1 - $3, BASE); }
    | expr MUL expr { printf("* "); $$ = mul($1, $3, BASE); }
    | expr DIV expr { printf("/ "); $$ = modDiv(mod($1, BASE), mod($3, BASE)); }
    | expr POW powexpr { printf("^ "); $$ = modPow(mod($1, BASE), mod($3, BASE)); }
    | SUB expr %prec NEG { $$ = mod(-$2, BASE); }
    | NUM { printf("%d ", mod($1, BASE)); $$ = mod($1, BASE); }
    | '(' expr ')' { $$ = $2; }
    ;

powexpr:
    powexpr ADD powexpr { printf("+ "); $$ = mod($1 + $3, BASE-1); }
    | powexpr SUB powexpr { printf("- "); $$ = mod($1 - $3, BASE-1); }
    | powexpr MUL powexpr { printf("* "); $$ = mul($1, $3,BASE -1); }
    | powexpr DIV powexpr { printf("/ "); $$ = modDiv(mod($1, BASE-1), mod($3, BASE-1)); }
    | SUB powexpr %prec NEG { $$ = mod(-$2, BASE-1); }
    | NUM { printf("%d ", mod($1, BASE-1)); $$ = mod($1, BASE-1); }
    | '(' powexpr ')' { $$ = $2; }
    ;

%%

int mul(int x, int y, int n) {
    int result = 0;
    for (int i = 0; i < x; i++)
    {
        result = (result + (y % n)) % n; 
    }
    return result;
}

int mod(int x, int n)
{
    while (x < 0) {
        x += n;
    }
    return x % n;
}


int modPow(int base, int exp) {
    printf("%d ^ %d = ", base, exp);
    int result = 1;
    for (int i = 0; i < exp; i++)
        result = (result * base) % BASE;
    return result;
}

int gcdExtended(int x, int y, int *i, int *j) {
    if (x == 0) {
        *i = 0;
        *j = 1;
        return y;
    }

    int i1, j1;
    int gcd = gcdExtended(y % x, x, &i1, &j1);

    *i = j1 - (y / x) * i1;
    *j = i1;

    return gcd;
}

int inverse(int a)
{
    int x, y;
    int res = gcdExtended(a, BASE, &x, &y);
    printf("%d * %d + %d * %d = %d\n", a, x, BASE, y, res);
    if (res != 1)
        return -1;
    return mod(x, BASE);
}


int modDiv(int x, int y) {
    return mul(x, inverse(y));
}

int yyerror(char *msg) {
    printf("Error: %s\n", msg);
    return 0;
}

int main(void) {
    while (1) {
        yyparse();
    }
}
