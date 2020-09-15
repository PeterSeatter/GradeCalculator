namespace GradeCalculation
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
            this.StudentGrade = new System.Windows.Forms.TextBox();
            this.StudentGradeLabel = new System.Windows.Forms.Label();
            this.PaperPrecentageLabel = new System.Windows.Forms.Label();
            this.PaperPrecentage = new System.Windows.Forms.TextBox();
            this.OverallGradeLabel = new System.Windows.Forms.Label();
            this.OverallGrade = new System.Windows.Forms.TextBox();
            this.GradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentGrade
            // 
            this.StudentGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGrade.Location = new System.Drawing.Point(63, 99);
            this.StudentGrade.MaxLength = 5;
            this.StudentGrade.Name = "StudentGrade";
            this.StudentGrade.Size = new System.Drawing.Size(93, 38);
            this.StudentGrade.TabIndex = 0;
            this.StudentGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StudentGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentGrade_KeyPress);
            // 
            // StudentGradeLabel
            // 
            this.StudentGradeLabel.AutoSize = true;
            this.StudentGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGradeLabel.Location = new System.Drawing.Point(26, 65);
            this.StudentGradeLabel.Name = "StudentGradeLabel";
            this.StudentGradeLabel.Size = new System.Drawing.Size(190, 31);
            this.StudentGradeLabel.TabIndex = 1;
            this.StudentGradeLabel.Text = "Student Grade";
            // 
            // PaperPrecentageLabel
            // 
            this.PaperPrecentageLabel.AutoSize = true;
            this.PaperPrecentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperPrecentageLabel.Location = new System.Drawing.Point(252, 65);
            this.PaperPrecentageLabel.Name = "PaperPrecentageLabel";
            this.PaperPrecentageLabel.Size = new System.Drawing.Size(232, 31);
            this.PaperPrecentageLabel.TabIndex = 2;
            this.PaperPrecentageLabel.Text = "Paper Precentage";
            // 
            // PaperPrecentage
            // 
            this.PaperPrecentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperPrecentage.Location = new System.Drawing.Point(322, 99);
            this.PaperPrecentage.MaxLength = 3;
            this.PaperPrecentage.Name = "PaperPrecentage";
            this.PaperPrecentage.Size = new System.Drawing.Size(70, 38);
            this.PaperPrecentage.TabIndex = 3;
            this.PaperPrecentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaperPrecentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaperPrecentage_KeyPress);
            // 
            // OverallGradeLabel
            // 
            this.OverallGradeLabel.AutoSize = true;
            this.OverallGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverallGradeLabel.Location = new System.Drawing.Point(543, 65);
            this.OverallGradeLabel.Name = "OverallGradeLabel";
            this.OverallGradeLabel.Size = new System.Drawing.Size(182, 31);
            this.OverallGradeLabel.TabIndex = 4;
            this.OverallGradeLabel.Text = "Overall Grade";
            // 
            // OverallGrade
            // 
            this.OverallGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverallGrade.Location = new System.Drawing.Point(572, 99);
            this.OverallGrade.MaxLength = 3;
            this.OverallGrade.Name = "OverallGrade";
            this.OverallGrade.ReadOnly = true;
            this.OverallGrade.Size = new System.Drawing.Size(101, 38);
            this.OverallGrade.TabIndex = 5;
            this.OverallGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GradeButton
            // 
            this.GradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeButton.Location = new System.Drawing.Point(238, 196);
            this.GradeButton.Name = "GradeButton";
            this.GradeButton.Size = new System.Drawing.Size(224, 70);
            this.GradeButton.TabIndex = 6;
            this.GradeButton.Text = "Grades";
            this.GradeButton.UseVisualStyleBackColor = true;
            this.GradeButton.Click += new System.EventHandler(this.GradeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 483);
            this.Controls.Add(this.GradeButton);
            this.Controls.Add(this.OverallGrade);
            this.Controls.Add(this.OverallGradeLabel);
            this.Controls.Add(this.PaperPrecentage);
            this.Controls.Add(this.PaperPrecentageLabel);
            this.Controls.Add(this.StudentGradeLabel);
            this.Controls.Add(this.StudentGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentGrade;
        private System.Windows.Forms.Label StudentGradeLabel;
        private System.Windows.Forms.Label PaperPrecentageLabel;
        private System.Windows.Forms.TextBox PaperPrecentage;
        private System.Windows.Forms.Label OverallGradeLabel;
        private System.Windows.Forms.TextBox OverallGrade;
        private System.Windows.Forms.Button GradeButton;
    }
}

