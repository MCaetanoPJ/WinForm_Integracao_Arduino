/*
 * Created by SharpDevelop.
 * User: Omnia
 * Date: 06/05/2020
 * Time: 13:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Comunicacao_C__Arduino
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Botao_conectar;
		private System.Windows.Forms.ComboBox comboBox_portaCom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox Check_porta13;
		private System.Windows.Forms.CheckBox Check_porta12;
		private System.Windows.Forms.CheckBox Check_porta11;
		private System.Windows.Forms.CheckBox Check_porta10;
		private System.Windows.Forms.CheckBox Check_porta09;
		private System.Windows.Forms.CheckBox Check_porta08;
		private System.Windows.Forms.CheckBox Check_porta07;
		private System.Windows.Forms.CheckBox Check_porta06;
		private System.Windows.Forms.CheckBox Check_porta05;
		private System.Windows.Forms.CheckBox Check_porta04;
		private System.Windows.Forms.CheckBox Check_porta03;
		private System.Windows.Forms.CheckBox Check_porta02;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Timer timerCOM;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Botao_conectar = new System.Windows.Forms.Button();
			this.comboBox_portaCom = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Check_porta13 = new System.Windows.Forms.CheckBox();
			this.Check_porta12 = new System.Windows.Forms.CheckBox();
			this.Check_porta11 = new System.Windows.Forms.CheckBox();
			this.Check_porta10 = new System.Windows.Forms.CheckBox();
			this.Check_porta09 = new System.Windows.Forms.CheckBox();
			this.Check_porta08 = new System.Windows.Forms.CheckBox();
			this.Check_porta07 = new System.Windows.Forms.CheckBox();
			this.Check_porta06 = new System.Windows.Forms.CheckBox();
			this.Check_porta05 = new System.Windows.Forms.CheckBox();
			this.Check_porta04 = new System.Windows.Forms.CheckBox();
			this.Check_porta03 = new System.Windows.Forms.CheckBox();
			this.Check_porta02 = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timerCOM = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// Botao_conectar
			// 
			this.Botao_conectar.Location = new System.Drawing.Point(12, 24);
			this.Botao_conectar.Name = "Botao_conectar";
			this.Botao_conectar.Size = new System.Drawing.Size(83, 24);
			this.Botao_conectar.TabIndex = 0;
			this.Botao_conectar.Text = "Conectar";
			this.Botao_conectar.UseVisualStyleBackColor = true;
			this.Botao_conectar.Click += new System.EventHandler(this.Botao_conectarClick);
			// 
			// comboBox_portaCom
			// 
			this.comboBox_portaCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_portaCom.FormattingEnabled = true;
			this.comboBox_portaCom.Location = new System.Drawing.Point(116, 27);
			this.comboBox_portaCom.Name = "comboBox_portaCom";
			this.comboBox_portaCom.Size = new System.Drawing.Size(161, 21);
			this.comboBox_portaCom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Portas Digitais disponíveis no Arduino UNO R3";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.Botao_conectar);
			this.panel1.Controls.Add(this.comboBox_portaCom);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(334, 69);
			this.panel1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(116, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 14);
			this.label3.TabIndex = 8;
			this.label3.Text = "Selecione a Porta COM do Arduino";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.Check_porta13);
			this.panel2.Controls.Add(this.Check_porta12);
			this.panel2.Controls.Add(this.Check_porta11);
			this.panel2.Controls.Add(this.Check_porta10);
			this.panel2.Controls.Add(this.Check_porta09);
			this.panel2.Controls.Add(this.Check_porta08);
			this.panel2.Controls.Add(this.Check_porta07);
			this.panel2.Controls.Add(this.Check_porta06);
			this.panel2.Controls.Add(this.Check_porta05);
			this.panel2.Controls.Add(this.Check_porta04);
			this.panel2.Controls.Add(this.Check_porta03);
			this.panel2.Controls.Add(this.Check_porta02);
			this.panel2.Controls.Add(this.groupBox3);
			this.panel2.Location = new System.Drawing.Point(12, 120);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(334, 371);
			this.panel2.TabIndex = 3;
			// 
			// Check_porta13
			// 
			this.Check_porta13.Location = new System.Drawing.Point(12, 342);
			this.Check_porta13.Name = "Check_porta13";
			this.Check_porta13.Size = new System.Drawing.Size(297, 24);
			this.Check_porta13.TabIndex = 20;
			this.Check_porta13.Text = "Porta 13";
			this.Check_porta13.UseVisualStyleBackColor = true;
			// 
			// Check_porta12
			// 
			this.Check_porta12.Location = new System.Drawing.Point(12, 313);
			this.Check_porta12.Name = "Check_porta12";
			this.Check_porta12.Size = new System.Drawing.Size(297, 24);
			this.Check_porta12.TabIndex = 19;
			this.Check_porta12.Text = "Porta 12";
			this.Check_porta12.UseVisualStyleBackColor = true;
			// 
			// Check_porta11
			// 
			this.Check_porta11.Location = new System.Drawing.Point(12, 283);
			this.Check_porta11.Name = "Check_porta11";
			this.Check_porta11.Size = new System.Drawing.Size(297, 24);
			this.Check_porta11.TabIndex = 18;
			this.Check_porta11.Text = "Porta 11";
			this.Check_porta11.UseVisualStyleBackColor = true;
			// 
			// Check_porta10
			// 
			this.Check_porta10.Location = new System.Drawing.Point(12, 253);
			this.Check_porta10.Name = "Check_porta10";
			this.Check_porta10.Size = new System.Drawing.Size(297, 24);
			this.Check_porta10.TabIndex = 17;
			this.Check_porta10.Text = "Porta 10";
			this.Check_porta10.UseVisualStyleBackColor = true;
			// 
			// Check_porta09
			// 
			this.Check_porta09.Location = new System.Drawing.Point(12, 223);
			this.Check_porta09.Name = "Check_porta09";
			this.Check_porta09.Size = new System.Drawing.Size(297, 24);
			this.Check_porta09.TabIndex = 16;
			this.Check_porta09.Text = "Porta 09";
			this.Check_porta09.UseVisualStyleBackColor = true;
			// 
			// Check_porta08
			// 
			this.Check_porta08.Location = new System.Drawing.Point(12, 193);
			this.Check_porta08.Name = "Check_porta08";
			this.Check_porta08.Size = new System.Drawing.Size(297, 24);
			this.Check_porta08.TabIndex = 15;
			this.Check_porta08.Text = "Porta 08";
			this.Check_porta08.UseVisualStyleBackColor = true;
			// 
			// Check_porta07
			// 
			this.Check_porta07.Location = new System.Drawing.Point(14, 163);
			this.Check_porta07.Name = "Check_porta07";
			this.Check_porta07.Size = new System.Drawing.Size(291, 24);
			this.Check_porta07.TabIndex = 14;
			this.Check_porta07.Text = "Porta 07";
			this.Check_porta07.UseVisualStyleBackColor = true;
			// 
			// Check_porta06
			// 
			this.Check_porta06.Location = new System.Drawing.Point(14, 133);
			this.Check_porta06.Name = "Check_porta06";
			this.Check_porta06.Size = new System.Drawing.Size(291, 24);
			this.Check_porta06.TabIndex = 13;
			this.Check_porta06.Text = "Porta 06";
			this.Check_porta06.UseVisualStyleBackColor = true;
			// 
			// Check_porta05
			// 
			this.Check_porta05.Location = new System.Drawing.Point(14, 103);
			this.Check_porta05.Name = "Check_porta05";
			this.Check_porta05.Size = new System.Drawing.Size(291, 24);
			this.Check_porta05.TabIndex = 12;
			this.Check_porta05.Text = "Porta 05";
			this.Check_porta05.UseVisualStyleBackColor = true;
			// 
			// Check_porta04
			// 
			this.Check_porta04.Location = new System.Drawing.Point(14, 73);
			this.Check_porta04.Name = "Check_porta04";
			this.Check_porta04.Size = new System.Drawing.Size(291, 24);
			this.Check_porta04.TabIndex = 11;
			this.Check_porta04.Text = "Porta 04";
			this.Check_porta04.UseVisualStyleBackColor = true;
			// 
			// Check_porta03
			// 
			this.Check_porta03.Location = new System.Drawing.Point(14, 43);
			this.Check_porta03.Name = "Check_porta03";
			this.Check_porta03.Size = new System.Drawing.Size(291, 24);
			this.Check_porta03.TabIndex = 10;
			this.Check_porta03.Text = "Porta 03";
			this.Check_porta03.UseVisualStyleBackColor = true;
			// 
			// Check_porta02
			// 
			this.Check_porta02.Location = new System.Drawing.Point(14, 13);
			this.Check_porta02.Name = "Check_porta02";
			this.Check_porta02.Size = new System.Drawing.Size(291, 24);
			this.Check_porta02.TabIndex = 9;
			this.Check_porta02.Text = "Porta 02";
			this.Check_porta02.UseVisualStyleBackColor = true;
			this.Check_porta02.CheckedChanged += new System.EventHandler(this.Check_porta02CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(585, 111);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(352, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(323, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Resposta Arduino UNO R3";
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Location = new System.Drawing.Point(352, 120);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(323, 371);
			this.panel4.TabIndex = 9;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 15);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(296, 338);
			this.textBox1.TabIndex = 0;
			// 
			// timerCOM
			// 
			this.timerCOM.Tick += new System.EventHandler(this.TimerCOMTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 503);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Comunicacao_C#_Arduino";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
