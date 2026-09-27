using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumberTools;

namespace demoapp
{
    public partial class Form1 : Form
    {
        private readonly NumberCounter counter = new NumberCounter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (this.lblNumber != null)
            {
                this.lblNumber.Text = counter.Value.ToString();
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            int step = 1;
            if (nudStep != null) step = (int)nudStep.Value;
            counter.Increment(step);
            UpdateDisplay();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            int step = 1;
            if (nudStep != null) step = (int)nudStep.Value;
            counter.Decrement(step);
            UpdateDisplay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter.Reset();
            UpdateDisplay();
        }
    }
}
