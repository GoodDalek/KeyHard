using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyHard
{
	public partial class telaajustes : UserControl
	{
		public telaajustes()
		{
			InitializeComponent();
		}
		
		string CVar;
		string MVar;
		string pwd;
		int NumComp;
		string chars;





		//Checando os radiobuttons e atribuindo variveis a eles.
		private void RbtFacil_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtFacil.Checked)
			{
				NumComp = 4; //atribui o valor a variavel de dificuldade
			}
		}

		private void RbtNormal_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtNormal.Checked)
			{
				NumComp = 8;  //atribui o valor a variavel de dificuldade
			}
		}

		private void RbtMedia_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtMedia.Checked)
			{
				NumComp = 12; //atribui o valor a variavel de dificuldade
			}
		}

		private void RbtDificil_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtDificil.Checked)
			{
				NumComp = 16;//atribui o valor a variavel de dificuldade
			}
		}

		private void RbtBrutal_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtBrutal.Checked)
			{
				NumComp = 20; //atribui o valor a variavel de dificuldade
			}
		}





		//Checando os RadioButtons de componentes e atribuindo valores a eles
		private void Rbttodos_CheckedChanged(object sender, EventArgs e)
		{
			if (Rbttodos.Checked)
			{
				CVar = "TD".ToString();   //atribui o valor a variavel de compoentes
				RbtMin.Visible = true;
				RbtMas.Visible = true;
				RbtMM.Visible = true;
			}
			else
			{
				RbtMin.Visible = false;
				RbtMas.Visible = false;
				RbtMM.Visible = false;
			}
		}

		private void RbtSimb_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtSimb.Checked)
			{
				CVar = "SB".ToString(); //atribui o valor a variavel de compoentes
			}
		}

		private void RbtNum_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtNum.Checked)
			{
				CVar = "NB".ToString(); //atribui o valor a variavel de compoentes

			}

		}

		private void RbtAlfa_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtAlfa.Checked)
			{
				CVar = "AF".ToString();     // atribui o valor a variavel de compoentes
				RbtMin.Visible = true;
				RbtMas.Visible = true;
				RbtMM.Visible = true;

			}
			else
			{
				RbtMin.Visible = false;
				RbtMas.Visible = false;
				RbtMM.Visible = false;
			}

		}

		private void RbtAN_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtAN.Checked)
			{
				CVar = "AN"; // Atribui o valor a variavel de componentes
				RbtMin.Visible = true;
				RbtMas.Visible = true;
				RbtMM.Visible = true;
			}
			else
			{
				RbtMin.Visible = false;
				RbtMas.Visible = false;
				RbtMM.Visible = false;
			}

		}





		//Checando os RadioButtons de Regras
		private void RbtMM_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtMM.Checked)
			{
				MVar = "MM";
			}

		}

		private void RbtMin_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtMin.Checked)
			{
				MVar = "MN";
			}
		}

		private void RbtMas_CheckedChanged(object sender, EventArgs e)
		{
			if (RbtMas.Checked)
			{
				MVar = "MC";
			}
		}





		//Configurando o botao pronto e gerando a chave.
		private void BtnPronto_Click(object sender, EventArgs e)
		{
			txtChave.Visible = true; // Torna o txtbox visivel
			LbChave.Visible = true;  // Torna a label do txtbox visivel

			//Configurnado as opçoes.

			//Opçao Todos.
			if(CVar == "TD")
			{
				if (MVar == "MN")
				{
					//Opção minúsculo 
					chars = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%&*/+-<>?";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());

				}

				if (MVar == "MC")
				{
					//Opção maiúsculo 
					chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*/+-<>?";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());
				}

				if (MVar == "MM")
				{
					//Opção minúsculo e maiúsculo 
					chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*/+-<>?";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());
				}
			}



			//Opçao Simbolos
			if(CVar == "SB")
			{
				chars = "!@#$%&*/+-<>?";
				Random random = new Random();
				pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());

			}



			//Opçao Numeros
			if (CVar == "NB")
			{
				chars = "1234567890";
				Random random = new Random();
				pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());
			}



			//Opçao alfabetico
			if (CVar == "AF")
			{
				if (MVar == "MN")
				{
					//Opção minúsculo 
					chars = "abcdefghijklmnopqrstuvwxyz";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());

				}

				if (MVar == "MC")
				{
					//Opção maiúsculo 
					chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());
				}

				if (MVar == "MM")
				{
					//Opção minúsculo e maiúsculo 
					chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());
				}
			}




			//Opçao alfanumerico
			if (CVar == "AN")
			{
				 
				if (MVar == "MN")
				{
					//Opção minúsculo 
					chars = "abcdefghijklmnopqrstuvwxyz1234567890";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());

				}

				if (MVar == "MC")
				{
					//Opção maiúsculo 
					chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());
				}

				if (MVar == "MM")
				{
					//Opção minúsculo e maiúsculo 
					chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
					Random random = new Random();
					pwd = new string(Enumerable.Repeat(chars, NumComp).Select(s => s[random.Next(s.Length)]).ToArray());
				}
			}



			txtChave.Text = pwd;   //Muda o conteudo do txtbox pelo valor contido na variavel pwd

		}

		
	}
}
