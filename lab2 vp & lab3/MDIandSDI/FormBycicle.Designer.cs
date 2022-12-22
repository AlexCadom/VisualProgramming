using System;
using System.Windows.Forms;

namespace Flowers
{
    partial class FormFlowerMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alan Bike",
            "4 шт",
            "белый"}, 0, System.Drawing.Color.Black, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alchemy Bikes",
            "6 шт",
            "желтый"}, 0);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alex Singer",
            "2 шт",
            "зеленный"}, 0);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "All-City",
            "3 шт",
            "белый"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlowerMaker));
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.checkBoxPleonka = new System.Windows.Forms.CheckBox();
            this.checkBoxKraft = new System.Windows.Forms.CheckBox();
            this.checkBoxSetka = new System.Windows.Forms.CheckBox();
            this.checkBoxFetr = new System.Windows.Forms.CheckBox();
            this.checkBoxOrganza = new System.Windows.Forms.CheckBox();
            this.listViewFlowers = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxHolidays = new System.Windows.Forms.GroupBox();
            this.radioButtonDeniRojdenia = new System.Windows.Forms.RadioButton();
            this.radioButtonSvadiba = new System.Windows.Forms.RadioButton();
            this.radioButtonVenceanie = new System.Windows.Forms.RadioButton();
            this.radioButtonKreshenie = new System.Windows.Forms.RadioButton();
            this.checkBoxHoliday = new System.Windows.Forms.CheckBox();
            this.timerBuildingTime = new System.Windows.Forms.Timer(this.components);
            this.checkedListBoxStyle = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonBig = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.textBoxFlowerName = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddFlower = new System.Windows.Forms.Button();
            this.comboBoxFlowers = new System.Windows.Forms.ComboBox();
            this.listBoxFlowers = new System.Windows.Forms.ListBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.m_MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.m_MenuEdit = new System.Windows.Forms.MenuItem();
            this.m_MenuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.m_ToolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.m_ToolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxHolidays.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.checkBoxPleonka);
            this.groupBoxMaterial.Controls.Add(this.checkBoxKraft);
            this.groupBoxMaterial.Controls.Add(this.checkBoxSetka);
            this.groupBoxMaterial.Controls.Add(this.checkBoxFetr);
            this.groupBoxMaterial.Controls.Add(this.checkBoxOrganza);
            this.groupBoxMaterial.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxMaterial.ForeColor = System.Drawing.Color.Black;
            this.groupBoxMaterial.Location = new System.Drawing.Point(308, 54);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(179, 146);
            this.groupBoxMaterial.TabIndex = 2;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Материалы";
            // 
            // checkBoxPleonka
            // 
            this.checkBoxPleonka.AutoSize = true;
            this.checkBoxPleonka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxPleonka.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxPleonka.ForeColor = System.Drawing.Color.Black;
            this.checkBoxPleonka.Location = new System.Drawing.Point(9, 66);
            this.checkBoxPleonka.Name = "checkBoxPleonka";
            this.checkBoxPleonka.Size = new System.Drawing.Size(100, 24);
            this.checkBoxPleonka.TabIndex = 10;
            this.checkBoxPleonka.Text = "Custom";
            this.checkBoxPleonka.UseVisualStyleBackColor = true;
            // 
            // checkBoxKraft
            // 
            this.checkBoxKraft.AutoSize = true;
            this.checkBoxKraft.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxKraft.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxKraft.ForeColor = System.Drawing.Color.Black;
            this.checkBoxKraft.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxKraft.Location = new System.Drawing.Point(9, 20);
            this.checkBoxKraft.Name = "checkBoxKraft";
            this.checkBoxKraft.Size = new System.Drawing.Size(195, 24);
            this.checkBoxKraft.TabIndex = 2;
            this.checkBoxKraft.Text = "Gears";
            this.checkBoxKraft.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetka
            // 
            this.checkBoxSetka.AutoSize = true;
            this.checkBoxSetka.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxSetka.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSetka.Location = new System.Drawing.Point(9, 43);
            this.checkBoxSetka.Name = "checkBoxSetka";
            this.checkBoxSetka.Size = new System.Drawing.Size(85, 24);
            this.checkBoxSetka.TabIndex = 9;
            this.checkBoxSetka.Text = "Pedal Mounts";
            this.checkBoxSetka.UseVisualStyleBackColor = true;
            // 
            // checkBoxFetr
            // 
            this.checkBoxFetr.AutoSize = true;
            this.checkBoxFetr.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxFetr.ForeColor = System.Drawing.Color.Black;
            this.checkBoxFetr.Location = new System.Drawing.Point(9, 89);
            this.checkBoxFetr.Name = "checkBoxFetr";
            this.checkBoxFetr.Size = new System.Drawing.Size(78, 24);
            this.checkBoxFetr.TabIndex = 12;
            this.checkBoxFetr.Text = "Фетр";
            this.checkBoxFetr.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrganza
            // 
            this.checkBoxOrganza.AutoSize = true;
            this.checkBoxOrganza.CausesValidation = false;
            this.checkBoxOrganza.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxOrganza.ForeColor = System.Drawing.Color.Black;
            this.checkBoxOrganza.Location = new System.Drawing.Point(9, 112);
            this.checkBoxOrganza.Name = "checkBoxOrganza";
            this.checkBoxOrganza.Size = new System.Drawing.Size(106, 24);
            this.checkBoxOrganza.TabIndex = 11;
            this.checkBoxOrganza.Text = "Lights";
            this.checkBoxOrganza.UseVisualStyleBackColor = true;
            // 
            // listViewFlowers
            // 
            this.listViewFlowers.BackColor = System.Drawing.SystemColors.Window;
            this.listViewFlowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewFlowers.CheckBoxes = true;
            this.listViewFlowers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Amount,
            this.Colour});
            this.listViewFlowers.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.listViewFlowers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewFlowers.FullRowSelect = true;
            this.listViewFlowers.HideSelection = false;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            this.listViewFlowers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.listViewFlowers.Location = new System.Drawing.Point(13, 113);
            this.listViewFlowers.Margin = new System.Windows.Forms.Padding(5);
            this.listViewFlowers.Name = "listViewFlowers";
            this.listViewFlowers.Size = new System.Drawing.Size(287, 130);
            this.listViewFlowers.TabIndex = 12;
            this.listViewFlowers.UseCompatibleStateImageBehavior = false;
            this.listViewFlowers.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Название";
            this.Type.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "Количество";
            this.Amount.Width = 80;
            // 
            // Colour
            // 
            this.Colour.Text = "Цвет";
            this.Colour.Width = 107;
            // 
            // groupBoxHolidays
            // 
            this.groupBoxHolidays.Controls.Add(this.radioButtonDeniRojdenia);
            this.groupBoxHolidays.Controls.Add(this.radioButtonSvadiba);
            this.groupBoxHolidays.Controls.Add(this.radioButtonVenceanie);
            this.groupBoxHolidays.Controls.Add(this.radioButtonKreshenie);
            this.groupBoxHolidays.Enabled = false;
            this.groupBoxHolidays.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxHolidays.Location = new System.Drawing.Point(495, 79);
            this.groupBoxHolidays.Name = "groupBoxHolidays";
            this.groupBoxHolidays.Size = new System.Drawing.Size(204, 121);
            this.groupBoxHolidays.TabIndex = 22;
            this.groupBoxHolidays.TabStop = false;
            this.groupBoxHolidays.Text = "Выберите соревнование";
            // 
            // radioButtonDeniRojdenia
            // 
            this.radioButtonDeniRojdenia.AutoSize = true;
            this.radioButtonDeniRojdenia.Location = new System.Drawing.Point(12, 90);
            this.radioButtonDeniRojdenia.Name = "radioButtonDeniRojdenia";
            this.radioButtonDeniRojdenia.Size = new System.Drawing.Size(171, 24);
            this.radioButtonDeniRojdenia.TabIndex = 11;
            this.radioButtonDeniRojdenia.Text = "Mountain";
            this.radioButtonDeniRojdenia.UseVisualStyleBackColor = true;
            // 
            // radioButtonSvadiba
            // 
            this.radioButtonSvadiba.AutoSize = true;
            this.radioButtonSvadiba.Location = new System.Drawing.Point(12, 68);
            this.radioButtonSvadiba.Name = "radioButtonSvadiba";
            this.radioButtonSvadiba.Size = new System.Drawing.Size(107, 24);
            this.radioButtonSvadiba.TabIndex = 10;
            this.radioButtonSvadiba.Text = "Urban";
            this.radioButtonSvadiba.UseVisualStyleBackColor = true;
            // 
            // radioButtonVenceanie
            // 
            this.radioButtonVenceanie.AutoSize = true;
            this.radioButtonVenceanie.Location = new System.Drawing.Point(12, 43);
            this.radioButtonVenceanie.Name = "radioButtonVenceanie";
            this.radioButtonVenceanie.Size = new System.Drawing.Size(119, 24);
            this.radioButtonVenceanie.TabIndex = 10;
            this.radioButtonVenceanie.Text = "Track";
            this.radioButtonVenceanie.UseVisualStyleBackColor = true;
            // 
            // radioButtonKreshenie
            // 
            this.radioButtonKreshenie.AutoSize = true;
            this.radioButtonKreshenie.Checked = true;
            this.radioButtonKreshenie.Location = new System.Drawing.Point(12, 21);
            this.radioButtonKreshenie.Name = "radioButtonKreshenie";
            this.radioButtonKreshenie.Size = new System.Drawing.Size(124, 24);
            this.radioButtonKreshenie.TabIndex = 8;
            this.radioButtonKreshenie.TabStop = true;
            this.radioButtonKreshenie.Text = "Pleasure";
            this.radioButtonKreshenie.UseVisualStyleBackColor = true;
            // 
            // checkBoxHoliday
            // 
            this.checkBoxHoliday.AutoSize = true;
            this.checkBoxHoliday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHoliday.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxHoliday.Location = new System.Drawing.Point(492, 54);
            this.checkBoxHoliday.Name = "checkBoxHoliday";
            this.checkBoxHoliday.Size = new System.Drawing.Size(316, 24);
            this.checkBoxHoliday.TabIndex = 23;
            this.checkBoxHoliday.Text = "Выбираете велосипед на соревнование?";
            this.m_ToolTip.SetToolTip(this.checkBoxHoliday, "При нажатии на кнопку будет доспупен выбор соревнований ");
            this.checkBoxHoliday.UseVisualStyleBackColor = true;
            this.checkBoxHoliday.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBoxStyle
            // 
            this.checkedListBoxStyle.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxStyle.FormattingEnabled = true;
            this.checkedListBoxStyle.Items.AddRange(new object[] {
            "Нежный",
            "Разноцветный",
            "Белый",
            "Яркий"});
            this.checkedListBoxStyle.Location = new System.Drawing.Point(81, 245);
            this.checkedListBoxStyle.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBoxStyle.Name = "checkedListBoxStyle";
            this.checkedListBoxStyle.Size = new System.Drawing.Size(140, 79);
            this.checkedListBoxStyle.TabIndex = 26;
            this.m_ToolTip2.SetToolTip(this.checkedListBoxStyle, "Выберите стиль рамы");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Название:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.radioButtonBig);
            this.groupBox2.Controls.Add(this.radioButtonMedium);
            this.groupBox2.Controls.Add(this.radioButtonSmall);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(13, 319);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(287, 97);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите ценовую категорию";
            // 
            // radioButtonBig
            // 
            this.radioButtonBig.Checked = true;
            this.radioButtonBig.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonBig.Location = new System.Drawing.Point(9, 67);
            this.radioButtonBig.Name = "radioButtonBig";
            this.radioButtonBig.Size = new System.Drawing.Size(100, 17);
            this.radioButtonBig.TabIndex = 10;
            this.radioButtonBig.TabStop = true;
            this.radioButtonBig.Text = "Дорогой";
            this.radioButtonBig.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonMedium.Location = new System.Drawing.Point(9, 44);
            this.radioButtonMedium.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(100, 17);
            this.radioButtonMedium.TabIndex = 10;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Средний";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonSmall.Location = new System.Drawing.Point(9, 22);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(100, 17);
            this.radioButtonSmall.TabIndex = 10;
            this.radioButtonSmall.Text = "Дешевый";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // textBoxFlowerName
            // 
            this.textBoxFlowerName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFlowerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFlowerName.Location = new System.Drawing.Point(104, 63);
            this.textBoxFlowerName.Name = "textBoxFlowerName";
            this.textBoxFlowerName.Size = new System.Drawing.Size(187, 28);
            this.textBoxFlowerName.TabIndex = 29;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.BackColor = System.Drawing.Color.White;
            this.numericUpDownQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownQuantity.Location = new System.Drawing.Point(210, 86);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(66, 28);
            this.numericUpDownQuantity.TabIndex = 32;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Сколько велосипедов вы хотите?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAddFlower);
            this.panel1.Controls.Add(this.comboBoxFlowers);
            this.panel1.Controls.Add(this.listBoxFlowers);
            this.panel1.Location = new System.Drawing.Point(307, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 161);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Добавьте дополнительные велосипеды в корзину:";
            // 
            // buttonAddFlower
            // 
            this.buttonAddFlower.Location = new System.Drawing.Point(351, 131);
            this.buttonAddFlower.Name = "buttonAddFlower";
            this.buttonAddFlower.Size = new System.Drawing.Size(37, 22);
            this.buttonAddFlower.TabIndex = 23;
            this.buttonAddFlower.Text = "+";
            this.m_ToolTip3.SetToolTip(this.buttonAddFlower, "При нажатии на кнопку вы добавите велосипед в список");
            this.buttonAddFlower.UseVisualStyleBackColor = true;
            this.buttonAddFlower.Click += new System.EventHandler(this.buttonAddFlower_Click);
            // 
            // comboBoxFlowers
            // 
            this.comboBoxFlowers.FormattingEnabled = true;
            this.comboBoxFlowers.Items.AddRange(new object[] {
            "Giant",
            "Author",
            "BMX",
            "Shimano",
            "Fox",
            "Trek",
            "Diamondback"});
            this.comboBoxFlowers.Location = new System.Drawing.Point(3, 132);
            this.comboBoxFlowers.Name = "comboBoxFlowers";
            this.comboBoxFlowers.Size = new System.Drawing.Size(342, 28);
            this.comboBoxFlowers.TabIndex = 22;
            this.comboBoxFlowers.Text = "Веберите цветок...";
            // 
            // listBoxFlowers
            // 
            this.listBoxFlowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFlowers.FormattingEnabled = true;
            this.listBoxFlowers.ItemHeight = 20;
            this.listBoxFlowers.Location = new System.Drawing.Point(3, 20);
            this.listBoxFlowers.Name = "listBoxFlowers";
            this.listBoxFlowers.Size = new System.Drawing.Size(385, 62);
            this.listBoxFlowers.TabIndex = 21;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(59, 436);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(65, 28);
            this.numericUpDownPrice.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Цена:";
            // 
            // m_ToolTip
            // 
            this.m_ToolTip.AutomaticDelay = 300;
            this.m_ToolTip.ShowAlways = true;
            // 
            // m_MainMenu
            // 
            this.m_MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_MenuEdit,
            this.m_MenuDelete,
            this.menuItem1,
            this.menuItem2});
            // 
            // m_MenuEdit
            // 
            this.m_MenuEdit.Index = 0;
            this.m_MenuEdit.Text = "&File";
            // 
            // m_MenuDelete
            // 
            this.m_MenuDelete.Index = 1;
            this.m_MenuDelete.Text = "&File";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "Edit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "Delete";
            // 
            // m_ToolTip2
            // 
            this.m_ToolTip2.AutomaticDelay = 300;
            this.m_ToolTip2.ShowAlways = true;
            // 
            // m_ToolTip3
            // 
            this.m_ToolTip3.AutomaticDelay = 300;
            this.m_ToolTip3.ShowAlways = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 33);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flowerToolStripMenuItem
            // 
            this.flowerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.flowerToolStripMenuItem.Name = "flowerToolStripMenuItem";
            this.flowerToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.flowerToolStripMenuItem.Text = "Bycicle";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 33);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FormFlowerMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 473);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewFlowers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxFlowerName);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxStyle);
            this.Controls.Add(this.checkBoxHoliday);
            this.Controls.Add(this.groupBoxHolidays);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFlowerMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Bycicle Maker";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.FormFlowerMaker_Load);
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxHolidays.ResumeLayout(false);
            this.groupBoxHolidays.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            //context menu

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            exitMenuItem.Name = "Exit";
            exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);

            ToolStripMenuItem loadMenuItem = new ToolStripMenuItem("Load");
            loadMenuItem.Name = "Exit";
            loadMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);

            ToolStripMenuItem saveMenuItem = new ToolStripMenuItem("Save");
            saveMenuItem.Name = "Exit";
            saveMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            contextMenu.Items.Add(exitMenuItem);
            contextMenu.Items.Add(saveMenuItem);
            contextMenu.Items.Add(loadMenuItem);


            this.ContextMenuStrip = contextMenu;


        }

        #endregion
        private MainMenu m_MainMenu;
        private MenuItem m_MenuDelete;
        private MenuItem m_MenuEdit;


        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.CheckBox checkBoxKraft;
        private System.Windows.Forms.ListView listViewFlowers;
        private System.Windows.Forms.CheckBox checkBoxFetr;
        private System.Windows.Forms.CheckBox checkBoxOrganza;
        private System.Windows.Forms.CheckBox checkBoxPleonka;
        private System.Windows.Forms.CheckBox checkBoxSetka;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Colour;
        private System.Windows.Forms.GroupBox groupBoxHolidays;
        private System.Windows.Forms.RadioButton radioButtonSvadiba;
        private System.Windows.Forms.RadioButton radioButtonVenceanie;
        private System.Windows.Forms.RadioButton radioButtonKreshenie;
        private System.Windows.Forms.RadioButton radioButtonDeniRojdenia;
        private System.Windows.Forms.CheckBox checkBoxHoliday;
        private System.Windows.Forms.Timer timerBuildingTime;
        private System.Windows.Forms.CheckedListBox checkedListBoxStyle;
       // private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonBig;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.TextBox textBoxFlowerName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddFlower;
        private System.Windows.Forms.ComboBox comboBoxFlowers;
        private System.Windows.Forms.ListBox listBoxFlowers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip m_ToolTip;
        private System.Windows.Forms.ToolTip m_ToolTip2;
        private System.Windows.Forms.ToolTip m_ToolTip3;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem flowerToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;


    }
}

