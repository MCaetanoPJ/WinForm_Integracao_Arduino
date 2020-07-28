# Comunica-o-Arduino-Uno
Sistema para enviar comandos ao Arduíno Uno com o objetivo de acender uma Lâmpada

Sistema desenvolvido para controlar o acionamento de lâmpadas através de comandos enviados atráves do computador para o arduíno Uno
Observação no projeto C#, em sua interface apenas a porta 02 foi utilizada, as demais não possuem funcionalidade
Dentro da pasta "Arduino-Uno" contém o arquivo "Codigo_Arduino" necessário para receber comandos específicos e ativar a porta correspondente para acender a lâmpada
Abaixo estão de forma simples a funcionalidade de cada método contido no código C#

# atualizaListaCOMs
Responsável por listar as portas COMs do computador e exibir todas em forma de lista selecionável
# TimerCOMTick
Responsável por atualizar o método "atualizaListaCOMs"
# serialPort1_DataReceived
Responsável por ler as informações recebidas pela porta COM
# trataDadoRecebido
Responsável por exibir a informação lida pelo método "serialPort1_DataReceived"
# Check_porta02CheckedChanged
Responsável por controlar oque deve ser feito quando o usuário interagir com o checkbox "Check_porta02", possui a função para enviar através da porta COM dois valores "1" e "0"
# Form1_FormClosed
Responsável por fechar a conexão com a porta COM utilizada caso ela esteja aberta
# Botao_conectarClick
Responsável por abrir a conexão usando a porta COM selecionada na lista do método "atualizaListaCOMs"
