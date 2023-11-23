namespace KurtAdamIstilasiOdev
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnChoose = new Button();
			txtNickName = new TextBox();
			cmbRace = new ComboBox();
			cmbClass = new ComboBox();
			btnAttack = new Button();
			label4 = new Label();
			label5 = new Label();
			cmbEnemyClass = new ComboBox();
			cmbEnemyRace = new ComboBox();
			txtEnemyName = new TextBox();
			btnEnemyChoose = new Button();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			lblHealth = new Label();
			lblEnemyHealth = new Label();
			pictureBox4 = new PictureBox();
			pictureBox7 = new PictureBox();
			btnReset = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(70, 75);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(56, 28);
			label1.TabIndex = 0;
			label1.Text = "İsim:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(83, 117);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(43, 28);
			label2.TabIndex = 1;
			label2.Text = "Irk:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(65, 151);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(61, 28);
			label3.TabIndex = 2;
			label3.Text = "Sınıf:";
			// 
			// btnChoose
			// 
			btnChoose.BackColor = Color.White;
			btnChoose.Location = new Point(134, 193);
			btnChoose.Name = "btnChoose";
			btnChoose.Size = new Size(121, 38);
			btnChoose.TabIndex = 3;
			btnChoose.Text = "Seç";
			btnChoose.UseVisualStyleBackColor = false;
			btnChoose.Click += btnChoose_Click;
			// 
			// txtNickName
			// 
			txtNickName.Location = new Point(134, 69);
			txtNickName.Name = "txtNickName";
			txtNickName.Size = new Size(121, 34);
			txtNickName.TabIndex = 4;
			// 
			// cmbRace
			// 
			cmbRace.FormattingEnabled = true;
			cmbRace.Items.AddRange(new object[] { "İnsan", "Hayvan", "Yaratık" });
			cmbRace.Location = new Point(134, 109);
			cmbRace.Name = "cmbRace";
			cmbRace.Size = new Size(121, 36);
			cmbRace.TabIndex = 5;
			// 
			// cmbClass
			// 
			cmbClass.FormattingEnabled = true;
			cmbClass.Items.AddRange(new object[] { "Gladyatör", "Mızrakçı", "Şaman", "Suikastçı" });
			cmbClass.Location = new Point(134, 151);
			cmbClass.Name = "cmbClass";
			cmbClass.Size = new Size(121, 36);
			cmbClass.TabIndex = 6;
			// 
			// btnAttack
			// 
			btnAttack.Location = new Point(434, 301);
			btnAttack.Name = "btnAttack";
			btnAttack.Size = new Size(284, 38);
			btnAttack.TabIndex = 7;
			btnAttack.Text = "Saldır";
			btnAttack.UseVisualStyleBackColor = true;
			btnAttack.Click += btnAttack_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(140, 38);
			label4.Margin = new Padding(5, 0, 5, 0);
			label4.Name = "label4";
			label4.Size = new Size(115, 28);
			label4.TabIndex = 8;
			label4.Text = "KARAKTER";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(630, 38);
			label5.Margin = new Padding(5, 0, 5, 0);
			label5.Name = "label5";
			label5.Size = new Size(210, 28);
			label5.TabIndex = 17;
			label5.Text = "DÜŞMAN KARAKTER";
			// 
			// cmbEnemyClass
			// 
			cmbEnemyClass.FormattingEnabled = true;
			cmbEnemyClass.Items.AddRange(new object[] { "Simitçi", "A (+)", "Ufo" });
			cmbEnemyClass.Location = new Point(694, 151);
			cmbEnemyClass.Name = "cmbEnemyClass";
			cmbEnemyClass.Size = new Size(121, 36);
			cmbEnemyClass.TabIndex = 16;
			// 
			// cmbEnemyRace
			// 
			cmbEnemyRace.FormattingEnabled = true;
			cmbEnemyRace.Items.AddRange(new object[] { "Vampir", "Uzaylı", "Jamiryo" });
			cmbEnemyRace.Location = new Point(694, 109);
			cmbEnemyRace.Name = "cmbEnemyRace";
			cmbEnemyRace.Size = new Size(121, 36);
			cmbEnemyRace.TabIndex = 15;
			// 
			// txtEnemyName
			// 
			txtEnemyName.Location = new Point(694, 69);
			txtEnemyName.Name = "txtEnemyName";
			txtEnemyName.Size = new Size(121, 34);
			txtEnemyName.TabIndex = 14;
			// 
			// btnEnemyChoose
			// 
			btnEnemyChoose.BackColor = Color.White;
			btnEnemyChoose.Location = new Point(694, 193);
			btnEnemyChoose.Name = "btnEnemyChoose";
			btnEnemyChoose.Size = new Size(121, 38);
			btnEnemyChoose.TabIndex = 13;
			btnEnemyChoose.Text = "Seç";
			btnEnemyChoose.UseVisualStyleBackColor = false;
			btnEnemyChoose.Click += btnEnemyChoose_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(625, 151);
			label6.Margin = new Padding(5, 0, 5, 0);
			label6.Name = "label6";
			label6.Size = new Size(61, 28);
			label6.TabIndex = 12;
			label6.Text = "Sınıf:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(643, 117);
			label7.Margin = new Padding(5, 0, 5, 0);
			label7.Name = "label7";
			label7.Size = new Size(43, 28);
			label7.TabIndex = 11;
			label7.Text = "Irk:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(630, 75);
			label8.Margin = new Padding(5, 0, 5, 0);
			label8.Name = "label8";
			label8.Size = new Size(56, 28);
			label8.TabIndex = 10;
			label8.Text = "İsim:";
			// 
			// lblHealth
			// 
			lblHealth.BackColor = Color.LimeGreen;
			lblHealth.Location = new Point(284, 38);
			lblHealth.Name = "lblHealth";
			lblHealth.Size = new Size(202, 28);
			lblHealth.TabIndex = 19;
			// 
			// lblEnemyHealth
			// 
			lblEnemyHealth.BackColor = Color.LimeGreen;
			lblEnemyHealth.Location = new Point(844, 38);
			lblEnemyHealth.Name = "lblEnemyHealth";
			lblEnemyHealth.Size = new Size(202, 28);
			lblEnemyHealth.TabIndex = 20;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(844, 69);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(301, 162);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 22;
			pictureBox4.TabStop = false;
			// 
			// pictureBox7
			// 
			pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.Location = new Point(284, 69);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new Size(301, 162);
			pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox7.TabIndex = 25;
			pictureBox7.TabStop = false;
			// 
			// btnReset
			// 
			btnReset.Location = new Point(517, 345);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(121, 38);
			btnReset.TabIndex = 26;
			btnReset.Text = "Sıfırla";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += btnReset_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(12F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1212, 467);
			Controls.Add(btnReset);
			Controls.Add(pictureBox7);
			Controls.Add(pictureBox4);
			Controls.Add(lblEnemyHealth);
			Controls.Add(lblHealth);
			Controls.Add(label5);
			Controls.Add(cmbEnemyClass);
			Controls.Add(cmbEnemyRace);
			Controls.Add(txtEnemyName);
			Controls.Add(btnEnemyChoose);
			Controls.Add(label6);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(label4);
			Controls.Add(btnAttack);
			Controls.Add(cmbClass);
			Controls.Add(cmbRace);
			Controls.Add(txtNickName);
			Controls.Add(btnChoose);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			Margin = new Padding(5, 6, 5, 6);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnChoose;
		private TextBox txtNickName;
		private ComboBox cmbRace;
		private ComboBox cmbClass;
		private Button btnAttack;
		private Label label4;
		private Label label5;
		private ComboBox cmbEnemyClass;
		private ComboBox cmbEnemyRace;
		private TextBox txtEnemyName;
		private Button btnEnemyChoose;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label lblHealth;
		private Label lblEnemyHealth;
		private PictureBox pictureBox4;
		private PictureBox pictureBox7;
		private Button btnReset;
	}
}