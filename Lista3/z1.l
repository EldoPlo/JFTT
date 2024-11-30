%{
    #include "z1.tab.h"
%}

COMMENT 	^#.*(\\\n)*.*\n

%%
{COMMENT}   	;
[0-9]+ 	{ yylval.num = atoi(yytext); return NUM; }
"+"		return ADD;
"-"		return SUB;
"*"		return MUL;
"/"		return DIV;
"^"		return POW;
\n      return EOF;
.       return *yytext;
%%

int yywrap()
{
    return 1;
}