namespace Winforms_TheInterface
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.loadTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(112, 237);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 52);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Add To File";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameTextBox.Location = new System.Drawing.Point(112, 92);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 27);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "Enter Name";
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // dayTextBox
            // 
            this.dayTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dayTextBox.Location = new System.Drawing.Point(112, 131);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(125, 27);
            this.dayTextBox.TabIndex = 2;
            this.dayTextBox.Text = "Enter Day";
            this.dayTextBox.Click += new System.EventHandler(this.dayTextBox_Click);
            this.dayTextBox.Leave += new System.EventHandler(this.dayTextBox_Leave);
            // 
            // ageTextBox
            // 
            this.ageTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ageTextBox.Location = new System.Drawing.Point(112, 176);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(125, 27);
            this.ageTextBox.TabIndex = 3;
            this.ageTextBox.Text = "Enter Age";
            this.ageTextBox.Click += new System.EventHandler(this.ageTextBox_Click);
            this.ageTextBox.Leave += new System.EventHandler(this.ageTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loadBtn.Location = new System.Drawing.Point(461, 237);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(120, 52);
            this.loadBtn.TabIndex = 7;
            this.loadBtn.Text = "Load From File";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadTextBox
            // 
            this.loadTextBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loadTextBox.Location = new System.Drawing.Point(300, 92);
            this.loadTextBox.Multiline = true;
            this.loadTextBox.Name = "loadTextBox";
            this.loadTextBox.Size = new System.Drawing.Size(430, 124);
            this.loadTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadTextBox);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveBtn;
        private TextBox nameTextBox;
        private TextBox dayTextBox;
        private TextBox ageTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button loadBtn;
        private TextBox loadTextBox;
    }
}