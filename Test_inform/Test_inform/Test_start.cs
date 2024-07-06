using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_inform
{
    public partial class Test_start : Form
    {
        public Test_start()
        {
            InitializeComponent();

            txtBox_test_info.Text = "**данный тест состоит из 10 вопросов. каждый из которых имеет ровно один правильный ответ";
            txtBox_test_info.ForeColor = Color.DodgerBlue;
        }

        private void btn_start_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void btn_all_result_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_result all_Result = new All_result();
            all_Result.Show();
        }
    }
}