algoritmo "Primeiro exercício de DS"
// Função : Calcular preços de combustíveis diversos
// Autor : Matheus Damasceno e Matheus Gama
// Data : 30/03/2023
// Seção de Declarações 
var
   quantlitro, vpago:real
   tipo:caracter
inicio
      escreva("Informe a quantidade de litros desejada: ")
      leia(quantlitro)
      escreva("Informe o tipo de combustível: A para Álcool e G para Gasolina")
      leia(tipo)
      se (tipo = "A") entao
         se (quantlitro <= 20) entao
            vpago:=(quantlitro * 4,30 - (quantlitro * 4,30 * 3/100))
            escreva("Valor à pagar: ", vpago)
         senao
              vpago:=(quantlitro * 4,30 - (quantlitro * 4,30 * 5/100))
              escreva("Valor à pagar: ", vpago)
         fimse
      senao
         se(tipo = "G") entao
              se(quantlitro <= 20) entao
                   vpago:=(quantlitro * 5,50 - (quantlitro * 5,50 * 4/100))
fimalgoritmo
