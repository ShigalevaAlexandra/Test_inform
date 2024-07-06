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
    public partial class Personal_result : Form
    {
        int student_mark = 0;
        public Personal_result()
        {
            InitializeComponent();

            lbl_count_result.Text = Convert.ToString(Properties.Settings.Default.right_answer_count) + "/10";

            if (Properties.Settings.Default.right_answer_count <= 10 && Properties.Settings.Default.right_answer_count >= 9)
            {
                lbl_count_result.ForeColor = Color.Green;
                student_mark = 5;
                lbl_mark.Text = "Оценка - " + student_mark;
            }

            if (Properties.Settings.Default.right_answer_count <= 8 && Properties.Settings.Default.right_answer_count >= 7)
            {
                lbl_count_result.ForeColor = Color.DarkKhaki;
                student_mark = 4;
                lbl_mark.Text = "Оценка - " + student_mark;
            }

            if (Properties.Settings.Default.right_answer_count <= 6 && Properties.Settings.Default.right_answer_count >= 5)
            {
                lbl_count_result.ForeColor = Color.Orange;
                student_mark = 3;
                lbl_mark.Text = "Оценка - " + student_mark;
            }

            if (Properties.Settings.Default.right_answer_count < 5)
            {
                lbl_count_result.ForeColor = Color.Red;
                student_mark = 2;
                lbl_mark.Text = "Оценка - " + student_mark;
            }
        }

        private void Add_result()
        {
            results add_new = new results();
            add_new.student_id = Properties.Settings.Default.student_id;
            add_new.student_result = student_mark;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Add_result();

            Properties.Settings.Default.right_answer_count = 0;
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
