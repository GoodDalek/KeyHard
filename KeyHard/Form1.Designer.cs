namespace KeyHard
{
	partial class Form1
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

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.telaajustes1 = new KeyHard.telaajustes();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BtnInfo = new System.Windows.Forms.Button();
			this.BtnHelp = new System.Windows.Forms.Button();
			this.BtnConfig = new System.Windows.Forms.Button();
			this.BtnHome = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.telaajustes2 = new KeyHard.telaajustes();
			this.telahome1 = new KeyHard.telahome();
			this.telaajuda1 = new KeyHard.telaajuda();
			this.telainfo1 = new KeyHard.telainfo();
			this.BtnMINI = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.panel1.Controls.Add(this.telaajustes1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.BtnInfo);
			this.panel1.Controls.Add(this.BtnHelp);
			this.panel1.Controls.Add(this.BtnConfig);
			this.panel1.Controls.Add(this.BtnHome);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 530);
			this.panel1.TabIndex = 0;
			// 
			// telaajustes1
			// 
			this.telaajustes1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.telaajustes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
			this.telaajustes1.Location = new System.Drawing.Point(150, 110);
			this.telaajustes1.Name = "telaajustes1";
			this.telaajustes1.Size = new System.Drawing.Size(750, 420);
			this.telaajustes1.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel3.Location = new System.Drawing.Point(35, 30);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(82, 60);
			this.panel3.TabIndex = 3;
			// 
			// BtnInfo
			// 
			this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnInfo.FlatAppearance.BorderSize = 0;
			this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnInfo.ForeColor = System.Drawing.Color.Transparent;
			this.BtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfo.Image")));
			this.BtnInfo.Location = new System.Drawing.Point(3, 492);
			this.BtnInfo.Name = "BtnInfo";
			this.BtnInfo.Size = new System.Drawing.Size(35, 35);
			this.BtnInfo.TabIndex = 6;
			this.BtnInfo.UseVisualStyleBackColor = true;
			this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
			// 
			// BtnHelp
			// 
			this.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnHelp.FlatAppearance.BorderSize = 0;
			this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHelp.ForeColor = System.Drawing.Color.White;
			this.BtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelp.Image")));
			this.BtnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnHelp.Location = new System.Drawing.Point(12, 235);
			this.BtnHelp.Name = "BtnHelp";
			this.BtnHelp.Size = new System.Drawing.Size(138, 50);
			this.BtnHelp.TabIndex = 6;
			this.BtnHelp.Text = "     Ajuda";
			this.BtnHelp.UseVisualStyleBackColor = true;
			this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
			// 
			// BtnConfig
			// 
			this.BtnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnConfig.FlatAppearance.BorderSize = 0;
			this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnConfig.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConfig.ForeColor = System.Drawing.Color.White;
			this.BtnConfig.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfig.Image")));
			this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnConfig.Location = new System.Drawing.Point(12, 172);
			this.BtnConfig.Name = "BtnConfig";
			this.BtnConfig.Size = new System.Drawing.Size(138, 50);
			this.BtnConfig.TabIndex = 5;
			this.BtnConfig.Text = "       Gerar";
			this.BtnConfig.UseVisualStyleBackColor = true;
			this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
			// 
			// BtnHome
			// 
			this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnHome.FlatAppearance.BorderSize = 0;
			this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHome.ForeColor = System.Drawing.Color.White;
			this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
			this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnHome.Location = new System.Drawing.Point(12, 109);
			this.BtnHome.Name = "BtnHome";
			this.BtnHome.Size = new System.Drawing.Size(138, 50);
			this.BtnHome.TabIndex = 3;
			this.BtnHome.Text = "     Home";
			this.BtnHome.UseVisualStyleBackColor = true;
			this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(150, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(750, 10);
			this.panel2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(859, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(29, 29);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Monospac821 BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(156, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 45);
			this.label1.TabIndex = 3;
			this.label1.Text = "KeyHard";
			this.label1.UseMnemonic = false;
			// 
			// telaajustes2
			// 
			this.telaajustes2.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.telaajustes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
			this.telaajustes2.Location = new System.Drawing.Point(150, 107);
			this.telaajustes2.Name = "telaajustes2";
			this.telaajustes2.Size = new System.Drawing.Size(750, 420);
			this.telaajustes2.TabIndex = 5;
			// 
			// telahome1
			// 
			this.telahome1.Location = new System.Drawing.Point(150, 109);
			this.telahome1.Name = "telahome1";
			this.telahome1.Size = new System.Drawing.Size(750, 420);
			this.telahome1.TabIndex = 4;
			// 
			// telaajuda1
			// 
			this.telaajuda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
			this.telaajuda1.Location = new System.Drawing.Point(150, 109);
			this.telaajuda1.Name = "telaajuda1";
			this.telaajuda1.Size = new System.Drawing.Size(750, 420);
			this.telaajuda1.TabIndex = 6;
			// 
			// telainfo1
			// 
			this.telainfo1.BackColor = System.Drawing.Color.White;
			this.telainfo1.Location = new System.Drawing.Point(150, 110);
			this.telainfo1.Name = "telainfo1";
			this.telainfo1.Size = new System.Drawing.Size(750, 420);
			this.telainfo1.TabIndex = 7;
			// 
			// BtnMINI
			// 
			this.BtnMINI.BackColor = System.Drawing.Color.Transparent;
			this.BtnMINI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMINI.BackgroundImage")));
			this.BtnMINI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnMINI.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnMINI.FlatAppearance.BorderSize = 0;
			this.BtnMINI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMINI.ForeColor = System.Drawing.Color.Transparent;
			this.BtnMINI.Location = new System.Drawing.Point(824, 16);
			this.BtnMINI.Name = "BtnMINI";
			this.BtnMINI.Size = new System.Drawing.Size(29, 29);
			this.BtnMINI.TabIndex = 8;
			this.BtnMINI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.BtnMINI.UseVisualStyleBackColor = false;
			this.BtnMINI.Click += new System.EventHandler(this.BtnMINI_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 530);
			this.Controls.Add(this.BtnMINI);
			this.Controls.Add(this.telainfo1);
			this.Controls.Add(this.telaajuda1);
			this.Controls.Add(this.telaajustes2);
			this.Controls.Add(this.telahome1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button BtnHelp;
		private System.Windows.Forms.Button BtnConfig;
		private System.Windows.Forms.Button BtnHome;
		private System.Windows.Forms.Button BtnInfo;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private telahome telahome1;
		private telaajustes telaajustes1;
		private telaajustes telaajustes2;
		private telaajuda telaajuda1;
		private telainfo telainfo1;
		private System.Windows.Forms.Button BtnMINI;
	}
}

