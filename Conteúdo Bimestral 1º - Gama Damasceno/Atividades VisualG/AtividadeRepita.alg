algoritmo "Atividade de looping 2; comando Repita"
// Fun��o :  Repetir o valor de um n�mero a partir do comando "Repita"
// Autor : Matheus Damasceno e Matheus Gama
// Data : 30/03/2023
// Se��o de Declara��es 
var
  i:inteiro
  ntabu, rtabu:real
inicio
      i:=0
      escreva("Qual n�mero voc� deseja?: ")
      leia(ntabu)
      repita
            rtabu:=ntabu * i
            i:=i+1
      escreva(rtabu)
      ate (i > 10)
fimalgoritmo
