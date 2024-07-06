namespace Test_inform
{
    partial class Test_start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_test_info = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_test_title = new System.Windows.Forms.Label();
            this.btn_all_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_test_info
            // 
            this.txtBox_test_info.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_test_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_test_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBox_test_info.Enabled = false;
            this.txtBox_test_info.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_test_info.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_test_info.Location = new System.Drawing.Point(14, 394);
            this.txtBox_test_info.Multiline = true;
            this.txtBox_test_info.Name = "txtBox_test_info";
            this.txtBox_test_info.ReadOnly = true;
            this.txtBox_test_info.Size = new System.Drawing.Size(873, 49);
            this.txtBox_test_info.TabIndex = 13;
            this.txtBox_test_info.Text = "*данный тест состоит из 10 вопросов, каждый из которых имеет только один парвильн" +
    "ый ответ!";
            this.txtBox_test_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_start.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_start.Location = new System.Drawing.Point(315, 147);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(263, 69);
            this.btn_start.TabIndex = 12;
            this.btn_start.Text = "Приступить к тесту";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // lbl_test_title
            // 
            this.lbl_test_title.AutoSize = true;
            this.lbl_test_title.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_test_title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_test_title.Location = new System.Drawing.Point(14, 35);
            this.lbl_test_title.MinimumSize = new System.Drawing.Size(880, 40);
            this.lbl_test_title.Name = "lbl_test_title";
            this.lbl_test_title.Size = new System.Drawing.Size(880, 40);
            this.lbl_test_title.TabIndex = 11;
            this.lbl_test_title.Text = "Тест по информатике";
            this.lbl_test_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_all_result
            // 
            this.btn_all_result.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_all_result.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_all_result.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_all_result.Location = new System.Drawing.Point(315, 246);
            this.btn_all_result.Name = "btn_all_result";
            this.btn_all_result.Size = new System.Drawing.Size(263, 69);
            this.btn_all_result.TabIndex = 14;
            this.btn_all_result.Text = "Общие результаты";
            this.btn_all_result.UseVisualStyleBackColor = false;
            this.btn_all_result.Click += new System.EventHandler(this.btn_all_result_Click);
            // 
            // Test_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 475);
            this.Controls.Add(this.btn_all_result);
            this.Controls.Add(this.txtBox_test_info);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_test_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(924, 518);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(924, 518);
            this.Name = "Test_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест по информатике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_test_info;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_test_title;
        private System.Windows.Forms.Button btn_all_result;
    }
}

