using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowers
{
    public partial class FormFlowerMaker : Form
    {
        private DateTime startDateTime = DateTime.Now;

        bool showToolBar = true;
        bool showStatusBar = true;

        public FormFlowerMaker()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bicycle flower = GetBicycle();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Bicycle Files|*.cxml",
                Title = "Save a Bicycle to file"
            };
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                flower.Save(saveFileDialog1.FileName);
                timerBuildingTime.Enabled = false;

                MessageBox.Show("Ваш " + flower.Name + " букет сохранён!");
            }
        }

        private Bicycle GetBicycle()
        {
            Bicycle flower = new Bicycle
            {
                Name = textBoxFlowerName.Text,
                Competition = checkBoxHoliday.Checked,
                Custom = checkBoxKraft.Checked,
                Gears = checkBoxSetka.Checked,
                PedalMounts = checkBoxPleonka.Checked,
                Lights = checkBoxFetr.Checked,
                DiskBrakes = checkBoxOrganza.Checked,
                NumberOfBycicles = (short)numericUpDownQuantity.Value,
                Price = numericUpDownPrice.Value
            };

            foreach (object flow in listBoxFlowers.Items)
            {
                flower.Bycicles1.Add((string)flow);
            }

            foreach (object flow in checkedListBoxStyle.CheckedItems)
            {
                flower.FrameStyle.Add((string)flow);
            }

            foreach (ListViewItem listViewItem in listViewFlowers.Items)
            {
                if (listViewItem.Checked)
                    flower.Frame.Add(listViewItem.Text);
            }

            if (radioButtonDeniRojdenia.Checked)
            {
                flower.RideType = RideType.Mountain;
            }
            else if (radioButtonKreshenie.Checked)
            {
                flower.RideType = RideType.Urban;
            }
            else if (radioButtonSvadiba.Checked)
            {
                flower.RideType = RideType.Track;
            }
            else if (radioButtonVenceanie.Checked)
            {
                flower.RideType = RideType.Pleasure;
            }

            if (radioButtonSmall.Checked)
            {
                flower.CatName = Category.Small;
            }
            else if (radioButtonMedium.Checked)
            {
                flower.CatName = Category.Medium;
            }
            else
            {
                flower.CatName = Category.Big;
            }

            return flower;
        }

        private void SetBicycle(Bicycle flower)
        {
            textBoxFlowerName.Text = flower.Name;
            foreach (ListViewItem listViewItem in listViewFlowers.Items)
            {
                if (flower.Frame.Contains(listViewItem.Text))
                {
                    listViewItem.Checked = true;
                }
            }

            foreach (string flow in flower.Bycicles1)
            {
                listBoxFlowers.Items.Add(flow);
            }

            for (int i = 0; i < checkedListBoxStyle.Items.Count; i++)
            {
                checkedListBoxStyle.SetItemChecked(i, flower.FrameStyle.Contains(checkedListBoxStyle.Items[i]));
            }

            switch (flower.RideType)
            {
                case RideType.Mountain:
                    radioButtonVenceanie.Checked = true;
                    break;
                case RideType.Urban:
                    radioButtonKreshenie.Checked = true;
                    break;
                case RideType.Track:
                    radioButtonSvadiba.Checked = true;
                    break;
                case RideType.Pleasure:
                    radioButtonDeniRojdenia.Checked = true;
                    break;
            }

            switch (flower.CatName)
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

            numericUpDownQuantity.Value = flower.NumberOfBycicles;
            numericUpDownPrice.Value = flower.Price;
            checkBoxKraft.Checked = flower.Custom;
            checkBoxSetka.Checked = flower.DiskBrakes;
            checkBoxPleonka.Checked = flower.Gears;
            checkBoxFetr.Checked = flower.PedalMounts;
            checkBoxOrganza.Checked = flower.Lights;
            checkBoxHoliday.Checked = flower.DiskBrakes;

            groupBoxHolidays.Enabled = checkBoxHoliday.Checked;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Flower files (*.cxml)|*.cxml",
                Title = "Открыть a Flower file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bicycle flower = Bicycle.Load(openFileDialog1.FileName);
                SetBicycle(flower);
                MessageBox.Show("Ваш " + flower.Name + " Bicycle был успешно загружен");
            }
        }

        private void buttonAddFlower_Click(object sender, EventArgs e)
        {
            object flow = comboBoxFlowers.SelectedItem;
            if (flow != null)
            {
                listBoxFlowers.Items.Add(comboBoxFlowers.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please choose a flow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBoxFlowers.SelectedIndex != -1)
            {
                listBoxFlowers.Items.RemoveAt(listBoxFlowers.SelectedIndex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxHolidays.Enabled = checkBoxHoliday.Checked;
        }


        private void FormFlowerMaker_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonLoad_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сохранить Bicycle?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                buttonSave_Click(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
     
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сохранить Bicycle?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                buttonSave_Click(sender, e);
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                Environment.Exit(0);
            }
           // Environment.Exit(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            buttonSave_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buttonLoad_Click(sender, e);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            DialogResult dialogResult = MessageBox.Show("Сохранить Bicycle?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                buttonSave_Click(sender, e);
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                Environment.Exit(0);
            }

           // if (menuItem.Name == "Exit")

           // {
              //  Application.Exit();
           // }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V.02\nCadomtev Alexei\n16.12.22", "Application Version 2.12");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
