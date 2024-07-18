using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class frmMainPage : Form
    {
        private DateTimePicker dtpBirthdate;
        private DateTimePicker dtpDeathdate;
        private OpenFileDialog openFileDialog;

        public frmMainPage()
        {
            InitializeComponent();
        }
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            SetPlaceholderText(txtName, "Vorname Nachname");
            SetPlaceholderText(txtBirthdate, "Geburtsdatum");
            SetPlaceholderText(txtDeathdate, "Sterbedatum");
            SetPlaceholderText(txtInformation, "Ergänze eine lustige Anekdote, eine kleine Geschichte oder andere Informationen");

            InitializeDateTimePickers();

            InitializeOpenFileDialog();
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Vorname Nachname")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.White;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                SetPlaceholderText(txtName, "Vorname Nachname");
            }
        }
        private void txtBirthdate_Enter(object sender, EventArgs e)
        {
            ShowDateTimePicker(dtpBirthdate, txtBirthdate);
        }

        private void txtDeathdate_Enter(object sender, EventArgs e)
        {
            ShowDateTimePicker(dtpDeathdate, txtDeathdate);
        }

        private void InitializeDateTimePickers()
        {
            dtpBirthdate = new DateTimePicker();
            dtpDeathdate = new DateTimePicker();

            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpDeathdate.Format = DateTimePickerFormat.Short;

            dtpBirthdate.Visible = false;
            dtpDeathdate.Visible = false;

            dtpBirthdate.ValueChanged += new EventHandler(dtpBirthdate_ValueChanged);
            dtpDeathdate.ValueChanged += new EventHandler(dtpDeathdate_ValueChanged);

            this.Controls.Add(dtpBirthdate);
            this.Controls.Add(dtpDeathdate);
        }

        private void ShowDateTimePicker(DateTimePicker dtp, TextBox txt)
        {
            dtp.Location = txt.Location;
            dtp.Size = txt.Size;
            dtp.Visible = true;
            dtp.BringToFront();
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            txtBirthdate.Text = dtpBirthdate.Value.ToShortDateString();
            txtBirthdate.ForeColor = Color.Black;
            dtpBirthdate.Visible = false;
        }

        private void dtpDeathdate_ValueChanged(object sender, EventArgs e)
        {
            txtDeathdate.Text = dtpDeathdate.Value.ToShortDateString();
            txtDeathdate.ForeColor = Color.Black;
            dtpDeathdate.Visible = false;
        }

        private void txtBirthdate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthdate.Text))
            {
                SetPlaceholderText(txtBirthdate, "Geburtsdatum");
            }
        }

        private void txtDeathdate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeathdate.Text))
            {
                SetPlaceholderText(txtDeathdate, "Sterbedatum");
            }
        }
        private void InitializeOpenFileDialog()
        {
            openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Wählen Sie ein Bild aus."
            };
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picDeceased.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void txtInformation_Enter(object sender, EventArgs e)
        {
            if (txtInformation.Text == "Ergänze eine lustige Anekdote, eine kleine Geschichte oder andere Informationen")
            {
                txtInformation.Text = "";
                txtInformation.ForeColor = Color.Black;
            }
        }

        private void txtInformation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInformation.Text))
            {
                SetPlaceholderText(txtInformation, "Ergänze eine lustige Anekdote, eine kleine Geschichte oder andere Informationen");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
