using Bicycles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycles
{
    public partial class FormBicycleMaker : Form
    {
        private DateTime startDateTime = DateTime.Now;

        public FormBicycleMaker()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = GetFlower();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Bicycle Files|*.cxml",
                Title = "Save a Bicycle to file"
            };
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                bicycle.Save(saveFileDialog1.FileName);
                timerBuildingTime.Enabled = false;

                MessageBox.Show("Ваша " + bicycle.Name + " корзина сохранёна! Сбор информации занял" + labelElapsed.Text + " времени.");
            }
        }

        private Bicycle GetFlower()
        {
            Bicycle bicycle = new Bicycle
            {
                Name = textBoxBicycleName.Text,
                Competition = checkBoxCompetition.Checked,
                Custom = checkBoxCustom.Checked,
                Gears = checkBoxGears.Checked,
                PedalMounts = checkBoxPedalMounts.Checked,
                Lights = checkBoxLights.Checked,
                DiskBrakes = checkBoxDiskBrakes.Checked,
                NumberOfBicycles = (short)numericUpDownQuantity.Value,
                Price = numericUpDownPrice.Value
            };

            foreach (object flow in listBoxBicycles.Items)
            {
                bicycle.Bicycles1.Add((string)flow);
            }

            foreach (object flow in checkedListBoxStyle.CheckedItems)
            {
                bicycle.FrameStyle.Add((string)flow);
            }

            foreach (ListViewItem listViewItem in listViewBicycles.Items)
            {
                if (listViewItem.Checked)
                    bicycle.Frame.Add(listViewItem.Text);
            }

            if (radioButtonTrack.Checked)
            {
                bicycle.RideType = RideType.Track;
            }
            else if (radioButtonMountain.Checked)
            {
                bicycle.RideType = RideType.Mountain;
            }
            else if (radioButtonPleasure.Checked)
            {
                bicycle.RideType = RideType.Pleasure;
            }
            else if (radioButtonUrban.Checked)
            {
                bicycle.RideType = RideType.Urban;
            }

            if (radioButtonSmall.Checked)
            {
                bicycle.CatName = Category.Small;
            }
            else if (radioButtonMedium.Checked)
            {
                bicycle.CatName = Category.Medium;
            }
            else
            {
                bicycle.CatName = Category.Big;
            }

            return bicycle;
        }

        private void SetBicycle(Bicycle bicycle)
        {
            textBoxBicycleName.Text = bicycle.Name;
            foreach (ListViewItem listViewItem in listViewBicycles.Items)
            {
                if (bicycle.Frame.Contains(listViewItem.Text))
                {
                    listViewItem.Checked = true;
                }
            }

            foreach (string flow in bicycle.Bicycles1)
            {
                listBoxBicycles.Items.Add(flow);
            }

            for (int i = 0; i < checkedListBoxStyle.Items.Count; i++)
            {
                checkedListBoxStyle.SetItemChecked(i, bicycle.FrameStyle.Contains(checkedListBoxStyle.Items[i]));
            }

            switch (bicycle.RideType)
            {
                case RideType.Urban:
                    radioButtonUrban.Checked = true;
                    break;
                case RideType.Mountain:
                    radioButtonMountain.Checked = true;
                    break;
                case RideType.Pleasure:
                    radioButtonPleasure.Checked = true;
                    break;
                case RideType.Track:
                    radioButtonTrack.Checked = true;
                    break;
            }

            switch (bicycle.CatName)
            {
                case Category.Small:
                    radioButtonSmall.Checked = true;
                    break;
                case Category.Medium:
                    radioButtonMedium.Checked = true;
                    break;
                case Category.Big:
                    radioButtonBig.Checked = true;
                    break;
            }

            numericUpDownQuantity.Value = bicycle.NumberOfBicycles;
            numericUpDownPrice.Value = bicycle.Price;
            checkBoxCustom.Checked = bicycle.Custom;
            checkBoxGears.Checked = bicycle.Gears;
            checkBoxPedalMounts.Checked = bicycle.PedalMounts;
            checkBoxLights.Checked = bicycle.Lights;
            checkBoxDiskBrakes.Checked = bicycle.DiskBrakes;
            checkBoxCompetition.Checked = bicycle.Competition;

            groupBoxCompetition.Enabled = checkBoxCompetition.Checked;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Bicycle files (*.cxml)|*.cxml",
                Title = "Открыть a Bicycle file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bicycle bicycle = Bicycle.Load(openFileDialog1.FileName);
                SetBicycle(bicycle);
                MessageBox.Show("Ваш " + bicycle.Name + " велосипед был успешно загружен");
            }
        }

        private void buttonAddBicycle_Click(object sender, EventArgs e)
        {
            object flow = comboBoxBicycles.SelectedItem;
            if (flow != null)
            {
                listBoxBicycles.Items.Add(comboBoxBicycles.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please choose a flow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBoxBicycles.SelectedIndex != -1)
            {
                listBoxBicycles.Items.RemoveAt(listBoxBicycles.SelectedIndex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCompetition.Enabled = checkBoxCompetition.Checked;
        }

        private void trackBarItems_Scroll(object sender, EventArgs e)
        {
            numericUpDownQuantity.Value = trackBarItems.Value;
        }

        private void timerBuildingTime_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - startDateTime;
            labelElapsed.Text = TimeSpan.FromSeconds(timeSpan.TotalSeconds).ToString();
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            trackBarItems.Value = (int)numericUpDownQuantity.Value;
        }

        private void FormBicycleMaker_Load(object sender, EventArgs e)
        {

        }
    }
}
