namespace home_work
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.testpattern = new System.Windows.Forms.RichTextBox();
			this.traindata = new System.Windows.Forms.Button();
			this.trainfilename = new System.Windows.Forms.TextBox();
			this.recallpattern = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.testdata = new System.Windows.Forms.Button();
			this.testfilename = new System.Windows.Forms.TextBox();
			this.training = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.testpattern_comboBox = new System.Windows.Forms.ComboBox();
			this.recall_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// testpattern
			// 
			this.testpattern.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.testpattern.Location = new System.Drawing.Point(282, 34);
			this.testpattern.Name = "testpattern";
			this.testpattern.ReadOnly = true;
			this.testpattern.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.testpattern.Size = new System.Drawing.Size(233, 367);
			this.testpattern.TabIndex = 2;
			this.testpattern.Text = "";
			this.testpattern.WordWrap = false;
			// 
			// traindata
			// 
			this.traindata.Location = new System.Drawing.Point(12, 32);
			this.traindata.Name = "traindata";
			this.traindata.Size = new System.Drawing.Size(89, 23);
			this.traindata.TabIndex = 3;
			this.traindata.Text = "選擇訓練資料";
			this.traindata.UseVisualStyleBackColor = true;
			this.traindata.Click += new System.EventHandler(this.traindata_Click);
			// 
			// trainfilename
			// 
			this.trainfilename.Location = new System.Drawing.Point(107, 32);
			this.trainfilename.Name = "trainfilename";
			this.trainfilename.ReadOnly = true;
			this.trainfilename.Size = new System.Drawing.Size(151, 22);
			this.trainfilename.TabIndex = 17;
			// 
			// recallpattern
			// 
			this.recallpattern.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recallpattern.Location = new System.Drawing.Point(529, 32);
			this.recallpattern.Name = "recallpattern";
			this.recallpattern.ReadOnly = true;
			this.recallpattern.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.recallpattern.Size = new System.Drawing.Size(232, 367);
			this.recallpattern.TabIndex = 18;
			this.recallpattern.Text = "";
			this.recallpattern.WordWrap = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(280, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 21;
			this.label1.Text = "測試資料";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(527, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 22;
			this.label2.Text = "回想結果";
			// 
			// testdata
			// 
			this.testdata.Location = new System.Drawing.Point(12, 72);
			this.testdata.Name = "testdata";
			this.testdata.Size = new System.Drawing.Size(89, 23);
			this.testdata.TabIndex = 23;
			this.testdata.Text = "選擇測試資料";
			this.testdata.UseVisualStyleBackColor = true;
			this.testdata.Click += new System.EventHandler(this.testdata_Click);
			// 
			// testfilename
			// 
			this.testfilename.Location = new System.Drawing.Point(107, 72);
			this.testfilename.Name = "testfilename";
			this.testfilename.ReadOnly = true;
			this.testfilename.Size = new System.Drawing.Size(151, 22);
			this.testfilename.TabIndex = 24;
			// 
			// training
			// 
			this.training.Location = new System.Drawing.Point(12, 112);
			this.training.Name = "training";
			this.training.Size = new System.Drawing.Size(89, 23);
			this.training.TabIndex = 25;
			this.training.Text = "開始訓練";
			this.training.UseVisualStyleBackColor = true;
			this.training.Click += new System.EventHandler(this.training_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 12);
			this.label3.TabIndex = 27;
			this.label3.Text = "選擇測試圖樣";
			// 
			// testpattern_comboBox
			// 
			this.testpattern_comboBox.FormattingEnabled = true;
			this.testpattern_comboBox.Location = new System.Drawing.Point(108, 144);
			this.testpattern_comboBox.Name = "testpattern_comboBox";
			this.testpattern_comboBox.Size = new System.Drawing.Size(150, 20);
			this.testpattern_comboBox.TabIndex = 28;
			this.testpattern_comboBox.SelectedIndexChanged += new System.EventHandler(this.testpattern_comboBox_SelectedIndexChanged);
			// 
			// recall_button
			// 
			this.recall_button.Location = new System.Drawing.Point(12, 176);
			this.recall_button.Name = "recall_button";
			this.recall_button.Size = new System.Drawing.Size(89, 23);
			this.recall_button.TabIndex = 29;
			this.recall_button.Text = "開始回想";
			this.recall_button.UseVisualStyleBackColor = true;
			this.recall_button.Click += new System.EventHandler(this.recall_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 422);
			this.Controls.Add(this.recall_button);
			this.Controls.Add(this.testpattern_comboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.training);
			this.Controls.Add(this.testfilename);
			this.Controls.Add(this.testdata);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.recallpattern);
			this.Controls.Add(this.trainfilename);
			this.Controls.Add(this.traindata);
			this.Controls.Add(this.testpattern);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox testpattern;
		private System.Windows.Forms.Button traindata;
		private System.Windows.Forms.TextBox trainfilename;
		private System.Windows.Forms.RichTextBox recallpattern;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button testdata;
		private System.Windows.Forms.TextBox testfilename;
		private System.Windows.Forms.Button training;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox testpattern_comboBox;
		private System.Windows.Forms.Button recall_button;


	}
}

