namespace KeyHard
{
	partial class telahome
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telahome));
			this.pima = new System.Windows.Forms.Panel();
			this.ptxt = new System.Windows.Forms.Panel();
			this.l3 = new System.Windows.Forms.Label();
			this.prop = new System.Windows.Forms.Label();
			this.ptxt.SuspendLayout();
			this.SuspendLayout();
			// 
			// pima
			// 
			this.pima.BackColor = System.Drawing.Color.Transparent;
			this.pima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pima.BackgroundImage")));
			this.pima.Location = new System.Drawing.Point(270, 35);
			this.pima.Name = "pima";
			this.pima.Size = new System.Drawing.Size(210, 139);
			this.pima.TabIndex = 1;
			// 
			// ptxt
			// 
			this.ptxt.Controls.Add(this.l3);
			this.ptxt.Location = new System.Drawing.Point(81, 195);
			this.ptxt.Name = "ptxt";
			this.ptxt.Size = new System.Drawing.Size(596, 100);
			this.ptxt.TabIndex = 2;
			// 
			// l3
			// 
			this.l3.AutoSize = true;
			this.l3.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l3.Location = new System.Drawing.Point(0, 0);
			this.l3.Name = "l3";
			this.l3.Size = new System.Drawing.Size(597, 75);
			this.l3.TabIndex = 0;
			this.l3.Text = "O KeyHard é um programa capaz de gerar chaves\r\n   aleatoriamente possibilita a es" +
    "colha de\r\n       diferentes niveis de dificuldade.";
			// 
			// prop
			// 
			this.prop.AutoSize = true;
			this.prop.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prop.Location = new System.Drawing.Point(89, 324);
			this.prop.Name = "prop";
			this.prop.Size = new System.Drawing.Size(579, 33);
			this.prop.TabIndex = 3;
			this.prop.Text = "Teste e descubra a segurança do KeyHard.";
			// 
			// telahome
			// 
			this.Controls.Add(this.prop);
			this.Controls.Add(this.ptxt);
			this.Controls.Add(this.pima);
			this.Name = "telahome";
			this.Size = new System.Drawing.Size(750, 420);
			this.ptxt.ResumeLayout(false);
			this.ptxt.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		//private System.Windows.Forms.Panel panel1;
		//private System.Windows.Forms.Label label1;
		//private System.Windows.Forms.Label label2;
		//private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pima;
		private System.Windows.Forms.Panel ptxt;
		private System.Windows.Forms.Label l3;
		private System.Windows.Forms.Label prop;
	}
}
