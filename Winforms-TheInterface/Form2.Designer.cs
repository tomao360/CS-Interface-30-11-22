namespace Winforms_TheInterface
{
    partial class Form2
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
            this.getItemBtn = new System.Windows.Forms.Button();
            this.colaBtn = new System.Windows.Forms.Button();
            this.kinlyBtn = new System.Windows.Forms.Button();
            this.printListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getItemBtn
            // 
            this.getItemBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.getItemBtn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getItemBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.getItemBtn.Location = new System.Drawing.Point(657, 58);
            this.getItemBtn.Name = "getItemBtn";
            this.getItemBtn.Size = new System.Drawing.Size(107, 53);
            this.getItemBtn.TabIndex = 0;
            this.getItemBtn.Text = "Get Item-Cola";
            this.getItemBtn.UseVisualStyleBackColor = false;
            this.getItemBtn.Click += new System.EventHandler(this.getItemBtn_Click);
            // 
            // colaBtn
            // 
            this.colaBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colaBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.colaBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.colaBtn.Location = new System.Drawing.Point(77, 82);
            this.colaBtn.Name = "colaBtn";
            this.colaBtn.Size = new System.Drawing.Size(94, 29);
            this.colaBtn.TabIndex = 1;
            this.colaBtn.Text = "Cola";
            this.colaBtn.UseVisualStyleBackColor = false;
            this.colaBtn.Click += new System.EventHandler(this.colaBtn_Click);
            // 
            // kinlyBtn
            // 
            this.kinlyBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kinlyBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kinlyBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.kinlyBtn.Location = new System.Drawing.Point(243, 82);
            this.kinlyBtn.Name = "kinlyBtn";
            this.kinlyBtn.Size = new System.Drawing.Size(94, 29);
            this.kinlyBtn.TabIndex = 2;
            this.kinlyBtn.Text = "Kinly";
            this.kinlyBtn.UseVisualStyleBackColor = false;
            this.kinlyBtn.Click += new System.EventHandler(this.kinlyBtn_Click);
            // 
            // printListBtn
            // 
            this.printListBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printListBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printListBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.printListBtn.Location = new System.Drawing.Point(161, 156);
            this.printListBtn.Name = "printListBtn";
            this.printListBtn.Size = new System.Drawing.Size(94, 54);
            this.printListBtn.TabIndex = 3;
            this.printListBtn.Text = "Print List";
            this.printListBtn.UseVisualStyleBackColor = false;
            this.printListBtn.Click += new System.EventHandler(this.printListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(243, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Kinly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Print the items list";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printListBtn);
            this.Controls.Add(this.kinlyBtn);
            this.Controls.Add(this.colaBtn);
            this.Controls.Add(this.getItemBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button getItemBtn;
        private Button colaBtn;
        private Button kinlyBtn;
        private Button printListBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}