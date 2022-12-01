namespace Winforms_TheInterface
{
    partial class Form3
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
            this.rectanglecheckBox = new System.Windows.Forms.CheckBox();
            this.circlecheckBox = new System.Windows.Forms.CheckBox();
            this.trianglecheckBox = new System.Windows.Forms.CheckBox();
            this.mooncheckBox = new System.Windows.Forms.CheckBox();
            this.ellipsecheckBox = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.showResultsBtn = new System.Windows.Forms.Button();
            this.resultLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rectanglecheckBox
            // 
            this.rectanglecheckBox.AutoSize = true;
            this.rectanglecheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.rectanglecheckBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rectanglecheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rectanglecheckBox.Location = new System.Drawing.Point(15, 35);
            this.rectanglecheckBox.Name = "rectanglecheckBox";
            this.rectanglecheckBox.Size = new System.Drawing.Size(108, 30);
            this.rectanglecheckBox.TabIndex = 0;
            this.rectanglecheckBox.Text = "Rectangle";
            this.rectanglecheckBox.UseVisualStyleBackColor = false;
            // 
            // circlecheckBox
            // 
            this.circlecheckBox.AutoSize = true;
            this.circlecheckBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circlecheckBox.Location = new System.Drawing.Point(15, 65);
            this.circlecheckBox.Name = "circlecheckBox";
            this.circlecheckBox.Size = new System.Drawing.Size(76, 30);
            this.circlecheckBox.TabIndex = 1;
            this.circlecheckBox.Text = "Circle";
            this.circlecheckBox.UseVisualStyleBackColor = true;
            // 
            // trianglecheckBox
            // 
            this.trianglecheckBox.AutoSize = true;
            this.trianglecheckBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trianglecheckBox.Location = new System.Drawing.Point(15, 125);
            this.trianglecheckBox.Name = "trianglecheckBox";
            this.trianglecheckBox.Size = new System.Drawing.Size(96, 30);
            this.trianglecheckBox.TabIndex = 2;
            this.trianglecheckBox.Text = "Triangle";
            this.trianglecheckBox.UseVisualStyleBackColor = true;
            // 
            // mooncheckBox
            // 
            this.mooncheckBox.AutoSize = true;
            this.mooncheckBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mooncheckBox.Location = new System.Drawing.Point(15, 155);
            this.mooncheckBox.Name = "mooncheckBox";
            this.mooncheckBox.Size = new System.Drawing.Size(74, 30);
            this.mooncheckBox.TabIndex = 3;
            this.mooncheckBox.Text = "Moon";
            this.mooncheckBox.UseVisualStyleBackColor = true;
            // 
            // ellipsecheckBox
            // 
            this.ellipsecheckBox.AutoSize = true;
            this.ellipsecheckBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ellipsecheckBox.Location = new System.Drawing.Point(15, 95);
            this.ellipsecheckBox.Name = "ellipsecheckBox";
            this.ellipsecheckBox.Size = new System.Drawing.Size(80, 30);
            this.ellipsecheckBox.TabIndex = 4;
            this.ellipsecheckBox.Text = "Ellipse";
            this.ellipsecheckBox.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(105, 249);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 58);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add Shape";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showResultsBtn
            // 
            this.showResultsBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showResultsBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showResultsBtn.Location = new System.Drawing.Point(76, 336);
            this.showResultsBtn.Name = "showResultsBtn";
            this.showResultsBtn.Size = new System.Drawing.Size(163, 29);
            this.showResultsBtn.TabIndex = 6;
            this.showResultsBtn.Text = "Show Results";
            this.showResultsBtn.UseVisualStyleBackColor = false;
            this.showResultsBtn.Click += new System.EventHandler(this.showResultsBtn_Click);
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultLable.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLable.Location = new System.Drawing.Point(690, 338);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(57, 26);
            this.resultLable.TabIndex = 7;
            this.resultLable.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rectanglecheckBox);
            this.groupBox1.Controls.Add(this.circlecheckBox);
            this.groupBox1.Controls.Add(this.trianglecheckBox);
            this.groupBox1.Controls.Add(this.mooncheckBox);
            this.groupBox1.Controls.Add(this.ellipsecheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(79, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 194);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(245, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "The sum of all the vertices of the chosen shapes is:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.showResultsBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox rectanglecheckBox;
        private CheckBox circlecheckBox;
        private CheckBox trianglecheckBox;
        private CheckBox mooncheckBox;
        private CheckBox ellipsecheckBox;
        private Button addBtn;
        private Button showResultsBtn;
        private Label resultLable;
        private GroupBox groupBox1;
        private Label label2;
    }
}