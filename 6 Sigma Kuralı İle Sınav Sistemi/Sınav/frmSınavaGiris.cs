using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sınav
{
    public partial class frmSınavaGiris : Form
    {
        public frmSınavaGiris()
        {
            InitializeComponent();
        }
        
        
        soru s = new soru();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.soruvesecenekatama();
            label10.Text = s.Govde;
            radioButton1.Text = s.dogruCevap;
            radioButton2.Text = s.yanliscevap1;
            radioButton3.Text = s.yanliscevap2;
            radioButton4.Text = s.yanliscevap3;
            radioButton5.Text = s.yanliscevap4;
            
            if(radioButton1.Checked && radioButton1.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

            s.soruvesecenekatama();
            label11.Text = s.Govde;
            radioButton10.Text = s.dogruCevap;
            radioButton9.Text = s.yanliscevap1;
            radioButton8.Text = s.yanliscevap2;
            radioButton7.Text = s.yanliscevap3;
            radioButton6.Text = s.yanliscevap4;

            if (radioButton10.Checked && radioButton10.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

            s.soruvesecenekatama();
            label13.Text = s.Govde;
            radioButton15.Text = s.dogruCevap;
            radioButton14.Text = s.yanliscevap1;
            radioButton13.Text = s.yanliscevap2;
            radioButton12.Text = s.yanliscevap3;
            radioButton11.Text = s.yanliscevap4;

            if (radioButton15.Checked && radioButton15.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

            s.soruvesecenekatama();
            label15.Text = s.Govde;
            radioButton20.Text = s.dogruCevap;
            radioButton19.Text = s.yanliscevap1;
            radioButton18.Text = s.yanliscevap2;
            radioButton17.Text = s.yanliscevap3;
            radioButton16.Text = s.yanliscevap4;

            if (radioButton1.Checked && radioButton1.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

            s.soruvesecenekatama();
            label17.Text = s.Govde;
            radioButton25.Text = s.dogruCevap;
            radioButton24.Text = s.yanliscevap1;
            radioButton23.Text = s.yanliscevap2;
            radioButton22.Text = s.yanliscevap3;
            radioButton21.Text = s.yanliscevap4;

            if (radioButton1.Checked && radioButton1.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

            s.soruvesecenekatama();
            label19.Text = s.Govde;
            radioButton30.Text = s.dogruCevap;
            radioButton29.Text = s.yanliscevap1;
            radioButton28.Text = s.yanliscevap2;
            radioButton27.Text = s.yanliscevap3;
            radioButton26.Text = s.yanliscevap4;

            if (radioButton1.Checked && radioButton1.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

            s.soruvesecenekatama();
            label21.Text = s.Govde;
            radioButton35.Text = s.dogruCevap;
            radioButton34.Text = s.yanliscevap1;
            radioButton33.Text = s.yanliscevap2;
            radioButton32.Text = s.yanliscevap3;
            radioButton31.Text = s.yanliscevap4;

            if (radioButton35.Checked && radioButton35.Text == s.dogruCevap)
            {
                radioButton35.Checked = true;
            }

            s.soruvesecenekatama();
            label23.Text = s.Govde;
            radioButton40.Text = s.dogruCevap;
            radioButton39.Text = s.yanliscevap1;
            radioButton38.Text = s.yanliscevap2;
            radioButton37.Text = s.yanliscevap3;
            radioButton36.Text = s.yanliscevap4;

            if (radioButton35.Checked && radioButton40.Text == s.dogruCevap)
            {
                radioButton35.Checked = true;
            }

            s.soruvesecenekatama();
            label25.Text = s.Govde;
            radioButton45.Text = s.dogruCevap;
            radioButton44.Text = s.yanliscevap1;
            radioButton43.Text = s.yanliscevap2;
            radioButton42.Text = s.yanliscevap3;
            radioButton41.Text = s.yanliscevap4;

            if (radioButton1.Checked && radioButton45.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

            s.soruvesecenekatama();
            label27.Text = s.Govde;
            radioButton50.Text = s.dogruCevap;
            radioButton49.Text = s.yanliscevap1;
            radioButton48.Text = s.yanliscevap2;
            radioButton47.Text = s.yanliscevap3;
            radioButton46.Text = s.yanliscevap4;

            if (radioButton1.Checked && radioButton50.Text == s.dogruCevap)
            {
                radioButton1.Checked = true;
            }

        }
    }
}
