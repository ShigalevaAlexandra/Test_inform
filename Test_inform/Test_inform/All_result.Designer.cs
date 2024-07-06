namespace Test_inform
{
    partial class All_result
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
            this.components = new System.ComponentModel.Container();
            this.lbl_all_result = new System.Windows.Forms.Label();
            this.dataGV_all_result = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.test_informationDataSet = new Test_inform.Test_informationDataSet();
            this.allresultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_resultTableAdapter = new Test_inform.Test_informationDataSetTableAdapters.all_resultTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_all_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_informationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allresultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_all_result
            // 
            this.lbl_all_result.AutoSize = true;
            this.lbl_all_result.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_all_result.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_all_result.Location = new System.Drawing.Point(83, 46);
            this.lbl_all_result.Name = "lbl_all_result";
            this.lbl_all_result.Size = new System.Drawing.Size(308, 32);
            this.lbl_all_result.TabIndex = 40;
            this.lbl_all_result.Text = "Общие результаты";
            this.lbl_all_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGV_all_result
            // 
            this.dataGV_all_result.AutoGenerateColumns = false;
            this.dataGV_all_result.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGV_all_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_all_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGV_all_result.DataSource = this.allresultBindingSource;
            this.dataGV_all_result.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGV_all_result.Location = new System.Drawing.Point(22, 119);
            this.dataGV_all_result.Name = "dataGV_all_result";
            this.dataGV_all_result.Size = new System.Drawing.Size(439, 326);
            this.dataGV_all_result.TabIndex = 41;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.Location = new System.Drawing.Point(381, 470);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 69);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "ОК";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // test_informationDataSet
            // 
            this.test_informationDataSet.DataSetName = "Test_informationDataSet";
            this.test_informationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allresultBindingSource
            // 
            this.allresultBindingSource.DataMember = "all_result";
            this.allresultBindingSource.DataSource = this.test_informationDataSet;
            // 
            // all_resultTableAdapter
            // 
            this.all_resultTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name_";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname_";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "group_";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Учебная группа";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result_";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Результат по тестированию";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // All_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 551);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGV_all_result);
            this.Controls.Add(this.lbl_all_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 594);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(499, 594);
            this.Name = "All_result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест по информатике";
            this.Load += new System.EventHandler(this.All_result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_all_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_informationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allresultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_all_result;
        private System.Windows.Forms.DataGridView dataGV_all_result;
        private System.Windows.Forms.Button btn_save;
        private Test_informationDataSet test_informationDataSet;
        private System.Windows.Forms.BindingSource allresultBindingSource;
        private Test_informationDataSetTableAdapters.all_resultTableAdapter all_resultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}