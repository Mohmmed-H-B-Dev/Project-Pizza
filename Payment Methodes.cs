using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pizza
{
    public partial class Payment_Methodes : Form
    {
        public Payment_Methodes()
        {
            InitializeComponent();
        }
        double PriceTemp = 0.0;
        bool Copy = false;
        bool Past = false;
        bool Cut = false;
      
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
               
                e.Handled=true;
               
            }

          


            // lbISNOtEqual.Text=(price -CheckContentPayMethods()).ToString();


        }
        public string NItem="Null";
        public double price=0;
        public bool IsLettersEnglish(char ch1)
        {

            return ((ch1=='a')||(ch1=='b')||(ch1=='c')||(ch1=='d')||(ch1=='e')||(ch1=='f')||
                (ch1=='g')||(ch1=='h')||(ch1=='i')||(ch1=='j')||
                (ch1=='k')||(ch1=='l')||(ch1=='m')||(ch1=='n')||(ch1=='o')||
                (ch1=='p')||(ch1=='q')||(ch1=='r')||(ch1=='s')||(ch1=='t')||
                (ch1=='u')||(ch1=='v')||(ch1=='x')||(ch1=='y')||(ch1=='z'));
        }

        public bool Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(string Text)
        {
            for(int i = 0; i<Text.Length; i++)
            {
                if (!IsLettersEnglish(char.ToLower(Text[i])))
                    return false;
            }

            return true; 
        }
        public double CheckContentPayMethods()
        {
            PriceTemp=0;
           
            
            if (txbMade.Text != ""&& !Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(txbMade.Text))
            {
                PriceTemp =PriceTemp +  double.Parse(txbMade.Text);
            }

            if (txbvisa.Text != ""&& !Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(txbvisa.Text))
            {
                PriceTemp =PriceTemp + double.Parse(txbvisa.Text);
            }

            if (txbMasterCared.Text != ""&& !Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(txbMasterCared.Text))
            {
                PriceTemp = PriceTemp + double.Parse(txbMasterCared.Text);
            }

            if (txbOurClinet.Text != "" && !Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(txbOurClinet.Text))
            {
                PriceTemp = PriceTemp + double.Parse(txbOurClinet.Text);
            }

            if (txbOurGefites.Text != "" && !Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(txbOurGefites.Text))
            {
                PriceTemp = PriceTemp + double.Parse(txbOurGefites.Text);
            }

            if (txbPointsRajehy.Text != ""&& !Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(txbPointsRajehy.Text))
            {
                PriceTemp = PriceTemp + double.Parse(txbPointsRajehy.Text);
            }

            if (txbCash.Text != ""&& !Solve_A_Problem_Enter_Text_After_Pasting_InPrice_Box(txbCash.Text))
            {
                PriceTemp = PriceTemp + double.Parse(txbCash.Text);
            }

            return PriceTemp;
        }
        private void AddInvoice()
        {
            invioces frm = new invioces();

            frm.lbPriceItem.Text=price.ToString(); ;

            frm.lbNameItem.Text=NItem;
            frm.lbNumberCasher.Text=1.ToString();

            frm.AddToListVeiw(frm);
        }

        private void txbMade_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(sender, e);
        }

      

        public void RefreshTxtb()
        {
            txbvisa.Refresh();
            txbCash.Refresh();
            txbMade.Refresh();
            txbOurClinet.Refresh();
            txbOurGefites.Refresh();
            txbPointsRajehy.Refresh();
            txbMasterCared.Refresh();
        }

        public void EcecuteFUN()
        {
           

            if (price ==CheckContentPayMethods())
            {
                MessageBox.Show(price.ToString(), NItem);
                AddInvoice();
                NItem="Null";

                price=  0;
                this.Close();

            }
            else
            {
                lbISNOtEqual.Text=(price -CheckContentPayMethods() ).ToString();
            }
           
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            EcecuteFUN();
        }

    
       

        private void KeyUp(object sender, KeyEventArgs e)
        {
            lbISNOtEqual.Text=(price -CheckContentPayMethods()).ToString();
            if (lbISNOtEqual.Text!="0")
            {
                btnOk.Enabled=false;
            }
            else
                btnOk.Enabled=true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CutORCupyToolStripMenuItem_Click(bool istrue=false)
        {
            
            if (txbCash.Text!="")
            {
               
            }

            if (txbMade.Text!="")
            {
                Clipboard.SetText(txbMade.Text);
                if(istrue)
                    SendKeys.Send("{DELETE}");
            }
            
            if (txbMasterCared.Text!="")
            {
                Clipboard.SetText(txbMasterCared.Text);
                if (istrue)
                    SendKeys.Send("{DELETE}");
            }

            if (txbvisa.Text!="")
            {
                Clipboard.SetText(txbvisa.Text);
                if (istrue)
                    SendKeys.Send("{DELETE}");
            }

        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy=false;
            Cut = true;
            Past =false;

            Select_TextBox_For_CopyOr_CutOr_Past();
        }

        private void Select_TextBox_For_CopyOr_CutOr_Past()
        {
            if (txbMade.Tag== "txbMade")
                Check_IS_Cut_Copy_Past(txbMade);
            if (txbvisa.Tag=="txbvisa")
                Check_IS_Cut_Copy_Past(txbvisa);
            if (txbMasterCared.Tag=="txbMasterCared")
                Check_IS_Cut_Copy_Past(txbMasterCared);
            if (txbOurClinet.Tag=="txbOurClinet")
                Check_IS_Cut_Copy_Past(txbOurClinet);

            if (txbPointsRajehy.Tag=="txbPointsRajehy")
                Check_IS_Cut_Copy_Past(txbPointsRajehy);
            if (txbOurGefites.Tag=="txbOurGefites")
                Check_IS_Cut_Copy_Past(txbOurGefites);
            if (txbCash.Tag=="txbCash")
                Check_IS_Cut_Copy_Past(txbCash);
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy=true;
            Cut = false;

            Past =false;

            Select_TextBox_For_CopyOr_CutOr_Past();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy=false;
            Cut = false;

            Past =true;
            Select_TextBox_For_CopyOr_CutOr_Past();
        }

        void Check_IS_Cut_Copy_Past(TextBox txb1)
        {
            
                if (Copy)
                {
                if (txb1.SelectedText==""||txb1.SelectedText==null)
                    return;
                if (txb1.Text!=""&&(txb1.SelectedText!=""||txb1.SelectedText!=null))

                    Clipboard.SetText(txb1.SelectedText);
    
                }
                else if (Cut)
                {
                if (txb1.SelectedText==""||txb1.SelectedText==null)
                    return;
                if (txb1.Text!=""&&(txb1.SelectedText!=""||txb1.SelectedText!=null))
                    

                    Clipboard.SetText(txb1.SelectedText);
                      SendKeys.Send("{DELETE}");
               
             
                }
                else if (Past)
                {
                    txb1.Text = Clipboard.GetText();
                }

            
        }

     
        

        
        enum enClearTextBoxOptional{ txbMade , txbvisa,txbMasterCared, txbOurClinet, txbPointsRajehy , txbOurGefites , txbCash };
        private void ResetAllTag(enClearTextBoxOptional en1)
        {
            if(enClearTextBoxOptional.txbMade!=en1)
                txbMade.Tag="";
            if (enClearTextBoxOptional .txbOurClinet!=en1)
                txbOurClinet.Tag=""; 

            if (enClearTextBoxOptional.txbMasterCared!=en1)
                txbMasterCared.Tag="";
            if (enClearTextBoxOptional.txbvisa!=en1)
                txbvisa.Tag="";
            if (enClearTextBoxOptional.txbPointsRajehy!=en1)
                txbPointsRajehy.Tag="";
            if (enClearTextBoxOptional.txbOurGefites!=en1)
                txbOurGefites.Tag="";
            if (enClearTextBoxOptional.txbCash!=en1)
                txbCash.Tag="";

        }
        private void txbMade_TextChanged(object sender, EventArgs e)
        {
            txbMade.Tag="txbMade";
            ResetAllTag(enClearTextBoxOptional.txbMade);
        }

        private void txbvisa_TextChanged(object sender, EventArgs e)
        {
            txbvisa.Tag="txbvisa";
            ResetAllTag(enClearTextBoxOptional.txbvisa);
        }

        private void txbMasterCared_TextChanged(object sender, EventArgs e)
        {
            txbMasterCared.Tag="txbMasterCared";
            ResetAllTag(enClearTextBoxOptional.txbMasterCared);
        }

        private void txbOurClinet_TextChanged(object sender, EventArgs e)
        {
            txbOurClinet.Tag="txbOurClinet";
            ResetAllTag(enClearTextBoxOptional.txbOurClinet);
        }

        private void txbPointsRajehy_TextChanged(object sender, EventArgs e)
        {
            txbPointsRajehy.Tag="txbPointsRajehy";
            ResetAllTag(enClearTextBoxOptional.txbPointsRajehy);
        }

        private void txbOurGefites_TextChanged(object sender, EventArgs e)
        {
            txbOurGefites.Tag="txbOurGefites";
            ResetAllTag(enClearTextBoxOptional.txbOurGefites);
        }

        private void txbCash_TextChanged(object sender, EventArgs e)
        {
            txbCash.Tag="txbCash";
            ResetAllTag(enClearTextBoxOptional.txbCash);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txbMasterCared_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
