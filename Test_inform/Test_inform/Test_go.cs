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
    public partial class Test_go : Form
    {
        Test_informationEntities entities = new Test_informationEntities();

        int number_question = 1;
        const int count_question = 10;

        int right_answer = 0;

        Button[] btn_questions = new Button[count_question];

        public Test_go()
        {
            InitializeComponent();

            lbl_number_question.Text = "Вопрос " + number_question;

            btn_questions[0] = btn_question_1;
            btn_questions[1] = btn_question_2;
            btn_questions[2] = btn_question_3;
            btn_questions[3] = btn_question_4;
            btn_questions[4] = btn_question_5;
            btn_questions[5] = btn_question_6;
            btn_questions[6] = btn_question_7;
            btn_questions[7] = btn_question_8;
            btn_questions[8] = btn_question_9;
            btn_questions[9] = btn_question_10;
        }

        private void Get_question(int number_question)
        {
            var question_text = entities.questions.Where(
                quest => quest.id_question == number_question).FirstOrDefault();
            txtBox_question_text.Text = question_text.question_text;

            var first_answer_text = entities.first_answers.Where(
                ans => ans.id_first_answer == number_question).FirstOrDefault();
            radioBtn_first.Text = first_answer_text.first_answer_text;

            var second_answer_text = entities.second_answers.Where(
                ans => ans.id_second_answer == number_question).FirstOrDefault();
            radioBtn_second.Text = second_answer_text.second_answer_text;

            var third_answer_text = entities.third_answers.Where(
                ans => ans.id_third_answer == number_question).FirstOrDefault();
            radioBtn_third.Text = third_answer_text.third_answer_text;
        }

        private void Check_answer(int number_question)
        {
            var right_answer_text = entities.questions.Where(
                quest => quest.id_question == number_question).FirstOrDefault();

            if (radioBtn_first.Checked)
            {
                if (radioBtn_first.Text == right_answer_text.right_answer)
                {
                    right_answer++;
                    radioBtn_first.ForeColor = Color.Green;
                }
                else radioBtn_first.ForeColor = Color.Red;
            }

            if (radioBtn_second.Checked)
            {
                if (radioBtn_second.Text == right_answer_text.right_answer)
                {
                    right_answer++;
                    radioBtn_second.ForeColor = Color.Green;
                }
                else radioBtn_second.ForeColor = Color.Red;
            }

            if (radioBtn_third.Checked)
            {
                if (radioBtn_third.Text == right_answer_text.right_answer)
                {
                    right_answer++;
                    radioBtn_third.ForeColor = Color.Green;
                }
                else radioBtn_third.ForeColor = Color.Red;
            }
        }

        private void Reset_radioBtn()
        {
            radioBtn_first.Checked = false;
            radioBtn_second.Checked = false;
            radioBtn_third.Checked = false;

            radioBtn_first.ForeColor = Color.Gray;
            radioBtn_second.ForeColor = Color.Gray;
            radioBtn_third.ForeColor = Color.Gray;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Check_answer(number_question);

            if (number_question >= count_question)
            {
                btn_save.Enabled = false;
                btn_end.Enabled = true;
                number_question = 1;
            }
            else
            {
                btn_questions[number_question].Enabled = true;
                btn_questions[number_question - 1].Enabled = false;

                number_question++;
            }
        }

        private void btn_question_Click(object sender, EventArgs e)
        {
            lbl_number_question.Text = "Вопрос " + number_question;

            Get_question(number_question);
            Reset_radioBtn();
        }

        private void btn_end_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.right_answer_count = right_answer;
            Properties.Settings.Default.Save();

            results add_new = new results();
            add_new.student_id = Properties.Settings.Default.student_id;
            add_new.student_result = Properties.Settings.Default.right_answer_count;

            entities.results.Add(add_new);
            entities.SaveChanges();

            this.Hide();
            Personal_result personal_Result = new Personal_result();
            personal_Result.Show();
        }
    }
}
