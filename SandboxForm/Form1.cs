using SandboxForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            pb_HJ.Image = Resources.HowardJones;
            SoundPlayer audio = new SoundPlayer(SandboxForm.Properties.Resources.Conditioning);
            audio.Play();
            MessageBox.Show("Welcome to conditioning", "GREETING", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetTextBoxData_Click(object sender, EventArgs e)
        {
            string firstName;
            string lastName;
            string nameCaptionText;
            int age;
            int answer = 0;

            nameCaptionText = "Person Data ";
            firstName = txbx_FirstName.Text;
            lastName = txbx_LastName.Text;
            if (!string.IsNullOrEmpty(txbxAge.Text))
            {
                age = int.Parse(txbxAge.Text);
            }
            else
            {
                age = 0;
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || age <= 0)
            {
                MessageBox.Show("Missing or Incorrect Data!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(firstName + " " + lastName + Environment.NewLine + "Age: " + age,
                    nameCaptionText, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            for (int i = 0; i <= 100; i++)
            {
                answer += i;
            }
            MessageBox.Show("nTh triangular number: " + answer);
        }
    }
}
