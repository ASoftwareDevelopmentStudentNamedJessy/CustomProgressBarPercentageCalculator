using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6._3._3._2
{
    public partial class OpdrachtZesDrieDrieDrie : Form
    {
        private int _score = 0;
        public OpdrachtZesDrieDrieDrie()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            try
            {
                int bezet = int.Parse(txtAantalKamersBezet.Text);
                int totaal = int.Parse(txtTotaalKamers.Text);
                _score = (bezet * 100 / totaal);
                pbProgress.Value = _score;
            }
            catch (System.DivideByZeroException boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
            catch (System.IndexOutOfRangeException boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
            catch (System.ArgumentException boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }
    }
}
