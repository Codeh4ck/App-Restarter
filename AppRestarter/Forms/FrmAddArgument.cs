using System;
using System.Windows.Forms;
using AppRestarter.Models;

namespace AppRestarter.Forms
{
    public partial class FrmAddArgument : Form
    {
        public FrmAddArgument()
        {
            InitializeComponent();
        }

        public static CmdArgument GetArgument(Form parent = null)
        {
            using FrmAddArgument frmAddArgument = new();
            if (frmAddArgument.ShowDialog(parent) != DialogResult.OK) return null;

            return new()
            {
                Id = Guid.NewGuid(),
                Argument = frmAddArgument.txtArgument.Text,
                Value = frmAddArgument.txtValue.Text
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtArgument.Text))
            {
                MessageBox.Show("Argument must not be empty.", "Invalid argument!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return false;
            }

            if (string.IsNullOrEmpty(txtValue.Text))
            {
                DialogResult shouldHaveEmptyValue = 
                    MessageBox.Show("You have entered an empty value for your argument, is this correct?", "Empty value!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation);

                return shouldHaveEmptyValue == DialogResult.Yes;
            }

            return true;
        }
    }
}
