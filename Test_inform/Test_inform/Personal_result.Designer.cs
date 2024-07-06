namespace Test_inform
{
    partial class Personal_result
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
            this.lbl_mark = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_count_result = new System.Windows.Forms.Label();
            this.lbl_personal_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mark
            // 
            this.lbl_mark.AutoSize = true;
            this.lbl_mark.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mark.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_mark.Location = new System.Drawing.Point(145, 242);
            this.lbl_mark.Name = "lbl_mark";
            this.lbl_mark.Size = new System.Drawing.Size(234, 42);
            this.lbl_mark.TabIndex = 42;
            this.lbl_mark.Text = "Оценка - 2";
            this.lbl_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.Location = new System.Drawing.Point(440, 340);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 69);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "ОК";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_count_result
            // 
            this.lbl_count_result.AutoSize = true;
            this.lbl_count_result.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_count_result.ForeColor = System.Drawing.Color.Orange;
            this.lbl_count_result.Location = new System.Drawing.Point(194, 132);
            this.lbl_count_result.Name = "lbl_count_result";
            this.lbl_count_result.Size = new System.Drawing.Size(117, 42);
            this.lbl_count_result.TabIndex = 40;
            this.lbl_count_result.Text = "0/10";
            this.lbl_count_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_personal_result
            // 
            this.lbl_personal_result.AutoSize = true;
            this.lbl_personal_result.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_personal_result.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_personal_result.Location = new System.Drawing.Point(136, 48);
            this.lbl_personal_result.Name = "lbl_personal_result";
            this.lbl_personal_result.Size = new System.Drawing.Size(243, 32);
            this.lbl_personal_result.TabIndex = 39;
            this.lbl_personal_result.Text = "Ваш результат";
            this.lbl_personal_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Personal_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 419);
            this.Controls.Add(this.lbl_mark);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_count_result);
            this.Controls.Add(this.lbl_personal_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 462);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(551, 462);
            this.Name = "Personal_result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест по информатике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mark;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_count_result;
        private System.Windows.Forms.Label lbl_personal_result;
    }
}