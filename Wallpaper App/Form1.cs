using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpaper_App
{
    public partial class frmWallpaperApp : Form
    {   
        public frmWallpaperApp()
        {
            InitializeComponent();

            cmbHeight.TextChanged += Combo_TextChanged;
            cmbLength.TextChanged += Combo_TextChanged;
            cmbWidth.TextChanged += Combo_TextChanged;
            cmbRollCoverage.TextChanged += Combo_TextChanged;

        }

        private void Combo_TextChanged(object sender, EventArgs e)
        {
            txtSingleRoll.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int iSingleRoll = Init();
            txtSingleRoll.Text = iSingleRoll.ToString();
            
        }

        private int Init()
        {
            double dLength = Double.Parse(cmbLength.Text);
            double dWidth = Double.Parse(cmbWidth.Text);
            double dHeight = Double.Parse(cmbHeight.Text);

            double dRollCoverage = Double.Parse(cmbRollCoverage.Text);

            double dHeightLength = 2 * (dHeight * dLength);
            double dHeightWidth = 2 * (dHeight * dWidth);

            double dSingleRoll = (dHeightLength / dRollCoverage) + (dHeightWidth / dRollCoverage);

            int iSingleRoll = int.Parse(Math.Round(dSingleRoll).ToString());

            return iSingleRoll;
        }
    }
}
