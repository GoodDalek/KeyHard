namespace KeyHard
{
	partial class telaajustes
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
			this.label1 = new System.Windows.Forms.Label();
			this.RbtFacil = new System.Windows.Forms.RadioButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.RbtSimb = new System.Windows.Forms.RadioButton();
			this.Rbttodos = new System.Windows.Forms.RadioButton();
			this.RbtAN = new System.Windows.Forms.RadioButton();
			this.RbtAlfa = new System.Windows.Forms.RadioButton();
			this.RbtNum = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.RbtBrutal = new System.Windows.Forms.RadioButton();
			this.RbtDificil = new System.Windows.Forms.RadioButton();
			this.RbtMedia = new System.Windows.Forms.RadioButton();
			this.RbtNormal = new System.Windows.Forms.RadioButton();
			this.BtnPronto = new System.Windows.Forms.Button();
			this.LbChave = new System.Windows.Forms.Label();
			this.txtChave = new System.Windows.Forms.TextBox();
			this.RbtMin = new System.Windows.Forms.RadioButton();
			this.RbtMas = new System.Windows.Forms.RadioButton();
			this.RbtMM = new System.Windows.Forms.RadioButton();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dificuldade";
			// 
			// RbtFacil
			// 
			this.RbtFacil.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtFacil.AutoSize = true;
			this.RbtFacil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtFacil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtFacil.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtFacil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtFacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtFacil.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtFacil.ForeColor = System.Drawing.Color.White;
			this.RbtFacil.Location = new System.Drawing.Point(189, 11);
			this.RbtFacil.Name = "RbtFacil";
			this.RbtFacil.Size = new System.Drawing.Size(60, 28);
			this.RbtFacil.TabIndex = 3;
			this.RbtFacil.TabStop = true;
			this.RbtFacil.Text = "Fácil";
			this.RbtFacil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtFacil.UseVisualStyleBackColor = false;
			this.RbtFacil.CheckedChanged += new System.EventHandler(this.RbtFacil_CheckedChanged);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.RbtMM);
			this.panel3.Controls.Add(this.RbtMas);
			this.panel3.Controls.Add(this.RbtMin);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(395, 148);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(320, 240);
			this.panel3.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(14, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Regras";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.RbtSimb);
			this.panel1.Controls.Add(this.Rbttodos);
			this.panel1.Controls.Add(this.RbtAN);
			this.panel1.Controls.Add(this.RbtAlfa);
			this.panel1.Controls.Add(this.RbtNum);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(35, 148);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(320, 240);
			this.panel1.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(248, 192);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.TabIndex = 13;
			this.label9.Text = "Forte";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(240, 158);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "Normal";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(202, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Muito Fraco ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(202, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Muito Fraco ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(202, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Muito Forte ";
			// 
			// RbtSimb
			// 
			this.RbtSimb.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtSimb.AutoSize = true;
			this.RbtSimb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtSimb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtSimb.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtSimb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtSimb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtSimb.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtSimb.ForeColor = System.Drawing.Color.White;
			this.RbtSimb.Location = new System.Drawing.Point(16, 84);
			this.RbtSimb.Name = "RbtSimb";
			this.RbtSimb.Size = new System.Drawing.Size(84, 28);
			this.RbtSimb.TabIndex = 8;
			this.RbtSimb.TabStop = true;
			this.RbtSimb.Text = "Símbolos";
			this.RbtSimb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtSimb.UseVisualStyleBackColor = false;
			this.RbtSimb.CheckedChanged += new System.EventHandler(this.RbtSimb_CheckedChanged);
			// 
			// Rbttodos
			// 
			this.Rbttodos.Appearance = System.Windows.Forms.Appearance.Button;
			this.Rbttodos.AutoSize = true;
			this.Rbttodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.Rbttodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Rbttodos.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Rbttodos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Rbttodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Rbttodos.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rbttodos.ForeColor = System.Drawing.Color.White;
			this.Rbttodos.Location = new System.Drawing.Point(16, 50);
			this.Rbttodos.Name = "Rbttodos";
			this.Rbttodos.Size = new System.Drawing.Size(60, 28);
			this.Rbttodos.TabIndex = 7;
			this.Rbttodos.TabStop = true;
			this.Rbttodos.Text = "Todos";
			this.Rbttodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Rbttodos.UseVisualStyleBackColor = false;
			this.Rbttodos.CheckedChanged += new System.EventHandler(this.Rbttodos_CheckedChanged);
			// 
			// RbtAN
			// 
			this.RbtAN.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtAN.AutoSize = true;
			this.RbtAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtAN.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtAN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtAN.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtAN.ForeColor = System.Drawing.Color.White;
			this.RbtAN.Location = new System.Drawing.Point(16, 186);
			this.RbtAN.Name = "RbtAN";
			this.RbtAN.Size = new System.Drawing.Size(124, 28);
			this.RbtAN.TabIndex = 6;
			this.RbtAN.TabStop = true;
			this.RbtAN.Text = "Alfanuméricos";
			this.RbtAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtAN.UseVisualStyleBackColor = false;
			this.RbtAN.CheckedChanged += new System.EventHandler(this.RbtAN_CheckedChanged);
			// 
			// RbtAlfa
			// 
			this.RbtAlfa.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtAlfa.AutoSize = true;
			this.RbtAlfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtAlfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtAlfa.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtAlfa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtAlfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtAlfa.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtAlfa.ForeColor = System.Drawing.Color.White;
			this.RbtAlfa.Location = new System.Drawing.Point(16, 152);
			this.RbtAlfa.Name = "RbtAlfa";
			this.RbtAlfa.Size = new System.Drawing.Size(108, 28);
			this.RbtAlfa.TabIndex = 5;
			this.RbtAlfa.TabStop = true;
			this.RbtAlfa.Text = "Alfabéticos";
			this.RbtAlfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtAlfa.UseVisualStyleBackColor = false;
			this.RbtAlfa.CheckedChanged += new System.EventHandler(this.RbtAlfa_CheckedChanged);
			// 
			// RbtNum
			// 
			this.RbtNum.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtNum.AutoSize = true;
			this.RbtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtNum.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtNum.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtNum.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtNum.ForeColor = System.Drawing.Color.White;
			this.RbtNum.Location = new System.Drawing.Point(16, 118);
			this.RbtNum.Name = "RbtNum";
			this.RbtNum.Size = new System.Drawing.Size(92, 28);
			this.RbtNum.TabIndex = 4;
			this.RbtNum.TabStop = true;
			this.RbtNum.Text = "Numéricos";
			this.RbtNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtNum.UseVisualStyleBackColor = false;
			this.RbtNum.CheckedChanged += new System.EventHandler(this.RbtNum_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(12, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 24);
			this.label5.TabIndex = 2;
			this.label5.Text = "Componentes";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.RbtBrutal);
			this.panel2.Controls.Add(this.RbtDificil);
			this.panel2.Controls.Add(this.RbtMedia);
			this.panel2.Controls.Add(this.RbtNormal);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.RbtFacil);
			this.panel2.Location = new System.Drawing.Point(35, 72);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(680, 50);
			this.panel2.TabIndex = 13;
			// 
			// RbtBrutal
			// 
			this.RbtBrutal.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtBrutal.AutoSize = true;
			this.RbtBrutal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtBrutal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtBrutal.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtBrutal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtBrutal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtBrutal.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtBrutal.ForeColor = System.Drawing.Color.White;
			this.RbtBrutal.Location = new System.Drawing.Point(581, 11);
			this.RbtBrutal.Name = "RbtBrutal";
			this.RbtBrutal.Size = new System.Drawing.Size(68, 28);
			this.RbtBrutal.TabIndex = 7;
			this.RbtBrutal.TabStop = true;
			this.RbtBrutal.Text = "Brutal";
			this.RbtBrutal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtBrutal.UseVisualStyleBackColor = false;
			this.RbtBrutal.CheckedChanged += new System.EventHandler(this.RbtBrutal_CheckedChanged);
			// 
			// RbtDificil
			// 
			this.RbtDificil.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtDificil.AutoSize = true;
			this.RbtDificil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtDificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtDificil.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtDificil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtDificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtDificil.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtDificil.ForeColor = System.Drawing.Color.White;
			this.RbtDificil.Location = new System.Drawing.Point(473, 11);
			this.RbtDificil.Name = "RbtDificil";
			this.RbtDificil.Size = new System.Drawing.Size(76, 28);
			this.RbtDificil.TabIndex = 6;
			this.RbtDificil.TabStop = true;
			this.RbtDificil.Text = "Difícil";
			this.RbtDificil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtDificil.UseVisualStyleBackColor = false;
			this.RbtDificil.CheckedChanged += new System.EventHandler(this.RbtDificil_CheckedChanged);
			// 
			// RbtMedia
			// 
			this.RbtMedia.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtMedia.AutoSize = true;
			this.RbtMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtMedia.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMedia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtMedia.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtMedia.ForeColor = System.Drawing.Color.White;
			this.RbtMedia.Location = new System.Drawing.Point(381, 11);
			this.RbtMedia.Name = "RbtMedia";
			this.RbtMedia.Size = new System.Drawing.Size(60, 28);
			this.RbtMedia.TabIndex = 5;
			this.RbtMedia.TabStop = true;
			this.RbtMedia.Text = "Média";
			this.RbtMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMedia.UseVisualStyleBackColor = false;
			this.RbtMedia.CheckedChanged += new System.EventHandler(this.RbtMedia_CheckedChanged);
			// 
			// RbtNormal
			// 
			this.RbtNormal.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtNormal.AutoSize = true;
			this.RbtNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtNormal.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtNormal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtNormal.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtNormal.ForeColor = System.Drawing.Color.White;
			this.RbtNormal.Location = new System.Drawing.Point(281, 11);
			this.RbtNormal.Name = "RbtNormal";
			this.RbtNormal.Size = new System.Drawing.Size(68, 28);
			this.RbtNormal.TabIndex = 4;
			this.RbtNormal.TabStop = true;
			this.RbtNormal.Text = "Normal";
			this.RbtNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtNormal.UseVisualStyleBackColor = false;
			this.RbtNormal.CheckedChanged += new System.EventHandler(this.RbtNormal_CheckedChanged);
			// 
			// BtnPronto
			// 
			this.BtnPronto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.BtnPronto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnPronto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnPronto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPronto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPronto.ForeColor = System.Drawing.Color.White;
			this.BtnPronto.Location = new System.Drawing.Point(577, 18);
			this.BtnPronto.Name = "BtnPronto";
			this.BtnPronto.Size = new System.Drawing.Size(107, 36);
			this.BtnPronto.TabIndex = 14;
			this.BtnPronto.Text = "Pronto";
			this.BtnPronto.UseVisualStyleBackColor = false;
			this.BtnPronto.Click += new System.EventHandler(this.BtnPronto_Click);
			// 
			// LbChave
			// 
			this.LbChave.AutoSize = true;
			this.LbChave.BackColor = System.Drawing.Color.Transparent;
			this.LbChave.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbChave.Location = new System.Drawing.Point(37, 20);
			this.LbChave.Name = "LbChave";
			this.LbChave.Size = new System.Drawing.Size(106, 33);
			this.LbChave.TabIndex = 16;
			this.LbChave.Text = "Chave";
			this.LbChave.Visible = false;
			// 
			// txtChave
			// 
			this.txtChave.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtChave.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChave.ForeColor = System.Drawing.Color.Red;
			this.txtChave.Location = new System.Drawing.Point(154, 18);
			this.txtChave.Name = "txtChave";
			this.txtChave.ReadOnly = true;
			this.txtChave.Size = new System.Drawing.Size(417, 36);
			this.txtChave.TabIndex = 17;
			this.txtChave.Text = "XXXXXXXXXXXXXXXXXXXX";
			this.txtChave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtChave.Visible = false;
			// 
			// RbtMin
			// 
			this.RbtMin.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtMin.AutoSize = true;
			this.RbtMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtMin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtMin.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtMin.ForeColor = System.Drawing.Color.White;
			this.RbtMin.Location = new System.Drawing.Point(32, 90);
			this.RbtMin.Name = "RbtMin";
			this.RbtMin.Size = new System.Drawing.Size(100, 28);
			this.RbtMin.TabIndex = 8;
			this.RbtMin.TabStop = true;
			this.RbtMin.Text = "Minúsculas";
			this.RbtMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMin.UseVisualStyleBackColor = false;
			this.RbtMin.Visible = false;
			this.RbtMin.CheckedChanged += new System.EventHandler(this.RbtMin_CheckedChanged);
			// 
			// RbtMas
			// 
			this.RbtMas.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtMas.AutoSize = true;
			this.RbtMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtMas.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtMas.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtMas.ForeColor = System.Drawing.Color.White;
			this.RbtMas.Location = new System.Drawing.Point(189, 90);
			this.RbtMas.Name = "RbtMas";
			this.RbtMas.Size = new System.Drawing.Size(100, 28);
			this.RbtMas.TabIndex = 9;
			this.RbtMas.TabStop = true;
			this.RbtMas.Text = "Maiúsculas";
			this.RbtMas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMas.UseVisualStyleBackColor = false;
			this.RbtMas.Visible = false;
			this.RbtMas.CheckedChanged += new System.EventHandler(this.RbtMas_CheckedChanged);
			// 
			// RbtMM
			// 
			this.RbtMM.Appearance = System.Windows.Forms.Appearance.Button;
			this.RbtMM.AutoSize = true;
			this.RbtMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.RbtMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RbtMM.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RbtMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RbtMM.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RbtMM.ForeColor = System.Drawing.Color.White;
			this.RbtMM.Location = new System.Drawing.Point(58, 158);
			this.RbtMM.Name = "RbtMM";
			this.RbtMM.Size = new System.Drawing.Size(204, 28);
			this.RbtMM.TabIndex = 10;
			this.RbtMM.TabStop = true;
			this.RbtMM.Text = "Maiúsculas e Minúsculas";
			this.RbtMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RbtMM.UseVisualStyleBackColor = false;
			this.RbtMM.Visible = false;
			this.RbtMM.CheckedChanged += new System.EventHandler(this.RbtMM_CheckedChanged);
			// 
			// telaajustes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
			this.Controls.Add(this.txtChave);
			this.Controls.Add(this.LbChave);
			this.Controls.Add(this.BtnPronto);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "telaajustes";
			this.Size = new System.Drawing.Size(750, 420);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton RbtFacil;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton RbtDificil;
		private System.Windows.Forms.RadioButton RbtMedia;
		private System.Windows.Forms.RadioButton RbtNormal;
		private System.Windows.Forms.RadioButton RbtAN;
		private System.Windows.Forms.RadioButton RbtAlfa;
		private System.Windows.Forms.RadioButton RbtNum;
		private System.Windows.Forms.RadioButton RbtBrutal;
		private System.Windows.Forms.RadioButton RbtSimb;
		private System.Windows.Forms.RadioButton Rbttodos;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BtnPronto;
		private System.Windows.Forms.Label LbChave;
		public System.Windows.Forms.TextBox txtChave;
		private System.Windows.Forms.RadioButton RbtMin;
		private System.Windows.Forms.RadioButton RbtMM;
		private System.Windows.Forms.RadioButton RbtMas;
	}
}
