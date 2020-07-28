/*
 * Created by SharpDevelop.
 * User: Omnia
 * Date: 06/05/2020
 * Time: 13:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;  // necessário para ter acesso as portas

namespace Comunicacao_C__Arduino
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string RxString;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			timerCOM.Enabled = true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		//Monitorar Portas COM usada pelo Arduino
		private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou
 
            i = 0;
            quantDiferente = false;
 
            //se a quantidade de portas mudou
            if (comboBox_portaCom.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox_portaCom.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }
 
            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }
 
            //limpa comboBox
            comboBox_portaCom.Items.Clear();
 
            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox_portaCom.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox_portaCom.SelectedIndex = 0;
        }
		private void TimerCOMTick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
		
		//Conectar ao Arduino
		private void Botao_conectarClick(object sender, EventArgs e)
		{
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox_portaCom.Items[comboBox_portaCom.SelectedIndex].ToString();
                    serialPort1.Open();
 
                }
                catch
                {
                    return;
 
                }
                if (serialPort1.IsOpen)
                {
                    Botao_conectar.Text = "Desconectar";
                    comboBox_portaCom.Enabled = false;
 
                }
            }
            else
            {
 
                try
                {
                    serialPort1.Close();
                    comboBox_portaCom.Enabled = true;
                    Botao_conectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
 
            }
		}
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(serialPort1.IsOpen == true)  // se porta aberta 
             serialPort1.Close();            //fecha a porta
        }
		
		//Resposta Arduino
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
			RxString = serialPort1.ReadExisting(); //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }
		private void trataDadoRecebido(object sender, EventArgs e)
        {
			MessageBox.Show(RxString+" informaçaõ recebida");
            textBox1.Text = RxString+"\n";
        }
		
		//Comandos para Enviar ao Arduino
		private void Check_porta02CheckedChanged(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen == true){
				if(Check_porta02.Checked == true){
					serialPort1.Write("1");
					textBox1.Text = "\n Ativar Porta Digital 02 \n";
				}
				else{
					serialPort1.Write("0");
					textBox1.Text = "\n Desativar Porta Digital 02\n";
				}
			}
			else{
				MessageBox.Show("Nenhum Arduino Conectado");
			}
		}
	}
}
