clean:
	rm -f z1.tab.c z1.tab.h lex.yy.c z1

z1: clean	
	bison -d z1.y
	flex z1.l
	gcc z1.tab.c lex.yy.c -o z1 -lfl -lm
	