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
using UTech.Properties;

namespace UTech.View
{
    public partial class CreateAccountForm : Form
    {
        private const string PW_TIPS = "Password need set 8~20 charaters.";

        private MainServiceController controller;
        public CreateAccountForm(MainServiceController controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.UpdateI18n();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateI18n()
        {
            this.Icon = Icon.FromHandle(Resources.uPipe.GetHicon());
            this.Text = I18N.GetString("Create Account");
            this.btnCreate.Enabled = false;
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

        private void textBoxRePw_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxPw.Text.Equals(this.textBoxRePw.Text))
            {
                this.btnCreate.Enabled = true;
                this.labelTips.Text = "";
            }
            else
            {
                this.btnCreate.Enabled = false;
                this.labelTips.Text = I18N.GetString("Two passwords are inconsistent");
            }
        }
    }
}
