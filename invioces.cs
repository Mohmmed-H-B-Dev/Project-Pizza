using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Pizza
{
    public partial class invioces : Form
    {
        public invioces()
        {
            InitializeComponent();
        }
     public   void AddToListVeiw(invioces frm)
        {
            this.lbNameItem=frm.lbNameItem;
            this.lbNumberCasher=frm.lbNumberCasher;
            this.lbPriceItem=frm.lbPriceItem;
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {

           

        }

        private void tpInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
