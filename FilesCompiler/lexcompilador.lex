letra [abcdefghijklmnopqrstuvwxyz]
mayuscula [ABCDEFGHIJKLMNOPQRSTUVWXYZ]
digito [0123456789]
comillas ["]
mas [+]
menos [-]
por [*]
div [/]
opand [&&]
opor [||]
parizq [(]
parder [)]
com [,]
pyc [;]
punto [.]
combl [{]
finbl [}]
simbolos [!#$%&<>_=:,?'+-/*().{}]
%%
id {mayuscula}({letra}|{digito})*# ;
adicion {mas}# ;
resta {menos}# ;
producto {por}# ;
division  {div}# ;
potencia {por}{por}# ;
and {opand}# ;
or {opor}# ;
menorque <# ;
mayorque ># ;
igualque ==# ;
menorigual <=# ;
mayorigual >=# ;
diferente !=# ;
verdadero true# ;
falso false# ;
entero int# ;
real float# ;
logico bool# ;
caracter char# ;
cadena text# ;
programa main# ;
inibloque {combl}# ;
finbloque {finbl}# ;
asignacion =# ;
si if# ;
mientras while# ;
bucle loop# ;
para for# ;
incremento {mas}{mas}# ;
leer getElement# ;
escribir document# ;
continuar continue# ;
coma {com}# ;
pizq {parizq}# ;
pder {parder}# ;
pycoma {pyc}# ;
hacer do# ;
dospuntos :# ;
declarar var# ;
romper break# ;
literalcadena {comillas}({letra}|{digito}|{simbolos}|{mayuscula})+{comillas}# ;
literalentero ({digito})+# ;
literalreal {menos}({digito})+.({digito})+#|({digito})*.({digito})+# ;
literalchar '({letra}|{digito}|{simbolos}|{mayuscula})'# ;
comentario \{por}({letra}|{digito}|{simbolos}|{mayuscula})+{por}\# ;
%%