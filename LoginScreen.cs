using Pizza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pizza
{
    public partial class LoginScreen : Form
    {
       public bool IsTrue=true;
       public  LoginScreen()
        {
            InitializeComponent();
        }


         ~LoginScreen()
        {
           
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text!=tbUserName.Tag.ToString()||tbPassword.Text!=tbPassword.Tag.ToString())
            {
                lbShowMessageErorr.Text="كلمة المرور او اسم المستخدم غير صحيح";
            }
            else
            {
                IsTrue=false;   
                this.Close();

            }
        }

      
    }
}
