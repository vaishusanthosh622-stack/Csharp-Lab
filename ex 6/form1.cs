using System;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public class Form1 : Form
    {
        TextBox txtName;
        RadioButton rdoMale;
        RadioButton rdoFemale;
        ComboBox cmbCourse;
        CheckBox chkSports;
        CheckBox chkMusic;
        Button btnSubmit;
        Button btnClear;

        public Form1()
        {
            Text = "Student Details";
            Width = 500;
            Height = 450;

            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.Left = 30;
            lblName.Top = 30;
            lblName.Width = 100;

            txtName = new TextBox();
            txtName.Left = 140;
            txtName.Top = 30;
            txtName.Width = 250;

            Label lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Left = 30;
            lblGender.Top = 80;
            lblGender.Width = 100;

            rdoMale = new RadioButton();
            rdoMale.Text = "Male";
            rdoMale.Left = 140;
            rdoMale.Top = 80;

            rdoFemale = new RadioButton();
            rdoFemale.Text = "Female";
            rdoFemale.Left = 220;
            rdoFemale.Top = 80;

            Label lblCourse = new Label();
            lblCourse.Text = "Course:";
            lblCourse.Left = 30;
            lblCourse.Top = 130;
            lblCourse.Width = 100;

            cmbCourse = new ComboBox();
            cmbCourse.Left = 140;
            cmbCourse.Top = 130;
            cmbCourse.Width = 250;

            cmbCourse.Items.Add("BCA");
            cmbCourse.Items.Add("B.Sc Computer Science");
            cmbCourse.Items.Add("B.Tech IT");
            cmbCourse.Items.Add("B.E CSE");

            Label lblHobbies = new Label();
            lblHobbies.Text = "Hobbies:";
            lblHobbies.Left = 30;
            lblHobbies.Top = 180;
            lblHobbies.Width = 100;

            chkSports = new CheckBox();
            chkSports.Text = "Sports";
            chkSports.Left = 140;
            chkSports.Top = 180;

            chkMusic = new CheckBox();
            chkMusic.Text = "Music";
            chkMusic.Left = 220;
            chkMusic.Top = 180;

            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Left = 140;
            btnSubmit.Top = 240;
            btnSubmit.Click += btnSubmit_Click;

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Left = 240;
            btnClear.Top = 240;
            btnClear.Click += btnClear_Click;

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblGender);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(lblCourse);
            Controls.Add(cmbCourse);
            Controls.Add(lblHobbies);
            Controls.Add(chkSports);
            Controls.Add(chkMusic);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = "";

            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else if (rdoFemale.Checked)
            {
                gender = "Female";
            }

            string course = cmbCourse.Text;
            string hobbies = "";

            if (chkSports.Checked)
            {
                hobbies += "Sports ";
            }

            if (chkMusic.Checked)
            {
                hobbies += "Music ";
            }

            MessageBox.Show(
                "Name : " + name +
                "\nGender : " + gender +
                "\nCourse : " + course +
                "\nHobbies : " + hobbies,
                "Student Details");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkSports.Checked = false;
            chkMusic.Checked = false;
            cmbCourse.SelectedIndex = -1;
        }
    }
}