algoritmo "Atividade de looping 2; comando Repita"
// Função :  Repetir o valor de um número a partir do comando "Repita"
// Autor : Matheus Damasceno e Matheus Gama
// Data : 30/03/2023
// Seção de Declarações 
var
  i:inteiro
  ntabu, rtabu:real
inicio
      i:=0
      escreva("Qual número você deseja?: ")
      leia(ntabu)
      repita
            rtabu:=ntabu * i
            i:=i+1
      escreva(rtabu)
      ate (i > 10)
fimalgoritmo
