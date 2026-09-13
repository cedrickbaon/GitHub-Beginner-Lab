namespace StudentProfile
{
    partial class StudentProfile
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
            lblStudProf = new Label();
            btnShow = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblStudProf
            // 
            lblStudProf.AutoSize = true;
            lblStudProf.Location = new Point(186, 109);
            lblStudProf.Name = "lblStudProf";
            lblStudProf.Size = new Size(146, 15);
            lblStudProf.TabIndex = 0;
            lblStudProf.Text = "Student Name/Student ID:";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(316, 177);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 1;
            btnShow.Text = "Search";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnShow);
            Controls.Add(lblStudProf);
            Name = "StudentProfile";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudProf;
        private Button btnShow;
        private TextBox textBox1;
    }
}
