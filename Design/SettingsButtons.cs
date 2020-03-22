﻿using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GOLSource
{
    public partial class Form1 : Form
    {
        // Tick speed of play button.
        private void buttonSpeed_Click(object sender, EventArgs e)
        {
            InputForm dlg = new InputForm();
            dlg.value = 100;
            dlg.label1.Text = "Input Tick Speed";
            dlg.label1.Location = new Point(dlg.Width / 2 - dlg.label1.Width / 2, 9);

            if (DialogResult.OK == dlg.ShowDialog())
            {
                GameSpeed = dlg.value;
                toolStripStatusLabelTickRate.Text = $"Tick Speed (ms) = {GameSpeed}";
                //TickLabel.Invalidate();
            }
        }

        // Change size of grid.
        private void buttonWorldSize_Click(object sender, EventArgs e)
        {
            InputForm_Double dlg = new InputForm_Double();
            dlg.value1 = 25;
            dlg.value2 = 25;
            dlg.label1.Text = "Input Universe Dimensions";
            dlg.label1.Location = new Point(dlg.Width / 2 - dlg.label1.Width / 2, 9);

            dlg.label2.Text = "Width";
            dlg.label3.Text = "Height";

            dlg.textBox1.Text = Program.universe.GetLength(0).ToString();
            dlg.textBox2.Text = Program.universe.GetLength(1).ToString();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                Debug.WriteLine($"{dlg.value1}, {dlg.value2}");
                Program.ReSizeUniverse(dlg.value1, dlg.value2);

                UpdatePanels();
                graphicsPanel1.Invalidate();
            }
        }

        public void UpdateLoop()
        {
            graphicsPanel1.Invalidate();
        }

        private void buttonLineToggle_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdjacentToggle_Click(object sender, EventArgs e)
        {

        }

        private void buttonHud_Click(object sender, EventArgs e)
        {

        }

        private void buttonCellCol_Click(object sender, EventArgs e)
        {

        }

        private void buttonLineCol_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
