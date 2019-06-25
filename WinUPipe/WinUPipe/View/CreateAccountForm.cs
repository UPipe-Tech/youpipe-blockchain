using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTech.Controller;

namespace UTech.View
{
    public partial class CreateAccountForm : Form
    {
        private const string PW_TIPS = "Password need set 8~20 charaters.";
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPw_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(string.IsNullOrEmpty(textBox.Text) 
                || textBox.Text.Length <8 || textBox.Text.Length >20
                )
            {
                this.labelTips.Text = I18N.GetString(PW_TIPS);
            }
            else
            {
                this.labelTips.Text = "";
            }
        }
    }
}
