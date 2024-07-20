using System;
using System.Drawing;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class frmMainPage : Form
    {
        private DateTimePicker dtpBirthdate;
        private DateTimePicker dtpDeathdate;
        private OpenFileDialog openFileDialog;

        private string username;

        private Label lblUsername;

        public frmMainPage(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
            InitializeDateTimePickers();
            InitializeOpenFileDialog();
            HideEditFields();
        }

        private void DisplayUsername()
        {
            lblUsername = new Label
            {
                Text = $"User: {username}",
                Location = new Point(10, 10),
                AutoSize = true,
                BackColor = Color.Gainsboro,
                Font = new Font(FontFamily.GenericSansSerif, 8f, FontStyle.Regular)
            };
            this.Controls.Add(lblUsername);
            panelTop.Controls.Add(lblUsername);
        }

        private void Tombstone_Click(object sender, EventArgs e)
        {
            PictureBox clickedTombstone = sender as PictureBox;
            if (clickedTombstone != null)
            {
                DisplayEditFields(clickedTombstone);
            }
        }

        private void DisplayEditFields(PictureBox tombstone)
        {
            if (tombstone.Tag != null)
            {
                var data = (Tuple<string, DateTime?, DateTime?, string, Image>)tombstone.Tag;
                txtName.Text = data.Item1;
                txtBirthdate.Text = data.Item2.HasValue ? data.Item2.Value.ToShortDateString() : "Geburtsdatum";
                txtDeathdate.Text = data.Item3.HasValue ? data.Item3.Value.ToShortDateString() : "Sterbedatum";
                txtInformation.Text = data.Item4 ?? "Ergänze eine lustige Anekdote, eine kleine Geschichte oder andere Informationen";
                picDeceased.Image = data.Item5;
            }
            else
            {
                SetPlaceholderText(txtName, "Vorname Nachname");
                SetPlaceholderText(txtBirthdate, "Geburtsdatum");
                SetPlaceholderText(txtDeathdate, "Sterbedatum");
                SetPlaceholderText(txtInformation, "Ergänze eine lustige Anekdote, eine kleine Geschichte oder andere Informationen");
                picDeceased.Image = null;
            }

            txtName.Visible = true;
            txtBirthdate.Visible = true;
            txtDeathdate.Visible = true;
            txtInformation.Visible = true;
            btnUpload.Visible = true;
            picDeceased.Visible = true;
            btnSave.Visible = true;
        }

        private void HideEditFields()
        {
            txtName.Visible = false;
            txtBirthdate.Visible = false;
            txtDeathdate.Visible = false;
            txtInformation.Visible = false;
            btnUpload.Visible = false;
            picDeceased.Visible = false;
            btnSave.Visible = false;
        }

        private void panelRight_Click(object sender, EventArgs e)
        {
            HideEditFields();
        }

        private void InitializeDateTimePickers()
        {
            dtpBirthdate = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Visible = false
            };
            dtpDeathdate = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Visible = false
            };

            dtpBirthdate.ValueChanged += new EventHandler(dtpBirthdate_ValueChanged);
            dtpDeathdate.ValueChanged += new EventHandler(dtpDeathdate_ValueChanged);

            panelLeft.Controls.Add(dtpBirthdate);
            panelLeft.Controls.Add(dtpDeathdate);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            PictureBox selectedTombstone = null;
            if (Tombstone1.BorderStyle == BorderStyle.FixedSingle) selectedTombstone = Tombstone1;
            if (Tombstone2.BorderStyle == BorderStyle.FixedSingle) selectedTombstone = Tombstone2;
            if (Tombstone3.BorderStyle == BorderStyle.FixedSingle) selectedTombstone = Tombstone3;
            if (Tombstone4.BorderStyle == BorderStyle.FixedSingle) selectedTombstone = Tombstone4;

            if (selectedTombstone != null)
            {
                var data = new Tuple<string, DateTime?, DateTime?, string, Image>(
                    txtName.Text,
                    DateTime.TryParse(txtBirthdate.Text, out DateTime birthDate) ? (DateTime?)birthDate : null,
                    DateTime.TryParse(txtDeathdate.Text, out DateTime deathDate) ? (DateTime?)deathDate : null,
                    txtInformation.Text,
                    picDeceased.Image
                );

                selectedTombstone.Tag = data;
                HideEditFields();
            }
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
                txtName.ForeColor = Color.Black;
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

        private void txtBirthdate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthdate.Text))
            {
                SetPlaceholderText(txtBirthdate, "Geburtsdatum");
            }
        }

        private void txtDeathdate_Enter(object sender, EventArgs e)
        {
            ShowDateTimePicker(dtpDeathdate, txtDeathdate);
        }

        private void txtDeathdate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeathdate.Text))
            {
                SetPlaceholderText(txtDeathdate, "Sterbedatum");
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



