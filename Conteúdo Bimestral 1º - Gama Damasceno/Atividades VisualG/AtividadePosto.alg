algoritmo "Primeiro exerc�cio de DS"
// Fun��o : Calcular pre�os de combust�veis diversos
// Autor : Matheus Damasceno e Matheus Gama
// Data : 30/03/2023
// Se��o de Declara��es 
var
   quantlitro, vpago:real
   tipo:caracter
inicio
      escreva("Informe a quantidade de litros desejada: ")
      leia(quantlitro)
      escreva("Informe o tipo de combust�vel:(A para �lcool e G para Gasolina): ")
      leia(tipo)
      se (tipo = "A") entao
         se (quantlitro <= 20) entao
            vpago:=(quantlitro * 4.30 - (quantlitro * 4.30 * 3/100))
            escreva("Valor � pagar: ", vpago)
         senao
              vpago:=(quantlitro * 4.30 - (quantlitro * 4.30 * 5/100))
              escreva("Valor � pagar: ", vpago)
         fimse
      senao
         se(tipo = "G") entao
              se(quantlitro <= 20) entao
                   vpago:=(quantlitro * 5.50 - (quantlitro * 5.50 * 4/100))
                   escreva("Valor a pagar: ", vpago)
              senao
                   vpago:=(quantlitro * 5.50 - (quantlitro * 5.50 * 6/100))
                   escreva("Valor a pagar: ", vpago)
              fimse
         fimse
      fimse
fimalgoritmo
