using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormPassword : Form
    {
        public string EnteredPassword { get; private set; }
        public FormPassword()
        {
            InitializeComponent();
        }

        private void buttonConfirmare_Click(object sender, EventArgs e)
        {
            EnteredPassword = textBoxParola.Text;
            DialogResult = DialogResult.OK;
        }

        private void buttonRenuntare_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
