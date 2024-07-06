using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_inform
{
    public partial class Registration : Form
    {
        Test_informationEntities entities = new Test_informationEntities();

        bool valid_student_group = false;
        bool valid_student_name = false;
        bool valid_student_surname = false;

        int add_student_id = 0;

        public Registration()
        {
            InitializeComponent();

            add_student_id = Properties.Settings.Default.student_id;
        }

        private void Student_name_regex()
        {
            //ограничение вводимых символов 
            string pattern = @"[а-яА-Я]";

            if (Regex.IsMatch(txtBox_student_name.Text, pattern))
            {
                valid_student_name = true;
                lbl_invalid_name_second.Visible = false;
            }
            else
            {
                valid_student_name = false;
                lbl_invalid_name_second.Visible = true;
            }
        }

        private void Student_surname_regex()
        {
            //ограничение вводимых символов 
            string pattern = @"[а-яА-Я]";

            if (Regex.IsMatch(txtBox_student_surname.Text, pattern))
            {
                valid_student_surname = true;
                lbl_invalid_surname_second.Visible = false;
            }
            else
            {
                valid_student_surname = false;
                lbl_invalid_surname_second.Visible = true;
            }
        }

        private void Student_group_regex()
        {
            //ограничение вводимых символов (маска ввода - ИР-21-4)
            string pattern = @"[А-Я]{2}[-][1-5]{2}[-][1-8]{1}";

            if (Regex.IsMatch(txtBox_student_group.Text, pattern))
            {
                valid_student_group = true;
                lbl_invalid_student_group.Visible = false;
            }
            else
            {
                valid_student_group = false;
                lbl_invalid_student_group.Visible = true;
            }
        }

        private void Add_new_student()
        {
            add_student_id++;
            Properties.Settings.Default.student_id = add_student_id;
            Properties.Settings.Default.Save();

            students add_new = new students();
            add_new.student_name = txtBox_student_name.Text;
            add_new.student_surname = txtBox_student_surname.Text;
            add_new.student_group = txtBox_student_group.Text;

            entities.students.Add(add_new);
            entities.SaveChanges();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (txtBox_student_name.Text == "") lbl_invalid_student_name.Visible = true;
            else
            {
                lbl_invalid_student_name.Visible = false;
                Student_name_regex();
            }

            if (txtBox_student_surname.Text == "") lbl_invalid_student_surname.Visible = true;
            else
            {
                lbl_invalid_student_surname.Visible = false;
                Student_surname_regex();
            }

            if (txtBox_student_group.Text == "") lbl_invalid_student_group_first.Visible = true;
            else
            {
                lbl_invalid_student_group_first.Visible = false;
                Student_group_regex();
            }

            if (valid_student_group && valid_student_surname && valid_student_name)
            {
                Add_new_student();

                this.Hide();
                Test_go test_Go = new Test_go();
                test_Go.Show();
            }
        }
    }
}
