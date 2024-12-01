grammar z1;

// Lexer rules
COMMENT: '#' .*? '\n' -> skip;
NUM: [0-9]+;
ADD: '+';
SUB: '-';
MUL: '*';
DIV: '/';
POW: '^';
LPAREN: '(';
RPAREN: ')';

WS: [ \t\r\n]+ -> skip;

// Parser rules
start
    :start line
    | EOF?;
    
line
    : ENDLINE #Nothing
    | powexpr expr ENDLINE #Print
    ;

expr
    : expr ADD expr      # Add
    | expr SUB expr      # Subtract
    | expr MUL expr      # Multiply
    | expr DIV expr      # Divide
    | expr POW powexpr   # Power
    | SUB expr           # Negate
    | NUM                # Number
    | LPAREN expr RPAREN # Parentheses
    ;

powexpr
    : powexpr ADD powexpr      # AddPow
    | powexpr SUB powexpr      # SubPow
    | powexpr MUL powexpr      # MulPow
    | powexpr DIV powexpr      # DivPow
    | SUB powexpr              # NegPow
    | NUM                      # NumPow
    | LPAREN powexpr RPAREN    # ParenthesesPow
    ;
