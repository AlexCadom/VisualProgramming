namespace Bicycles
{
    partial class FormBicycleMaker
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alan Bike",
            "4 шт",
            "белый"}, 0, System.Drawing.Color.Black, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alchemy Bikes",
            "6 шт",
            "желтый"}, 0);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alex Singer",
            "2 шт",
            "зеленный"}, 0);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "All-City",
            "3 шт",
            "белый"}, 0);
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.checkBoxLights = new System.Windows.Forms.CheckBox();
            this.checkBoxCustom = new System.Windows.Forms.CheckBox();
            this.checkBoxGears = new System.Windows.Forms.CheckBox();
            this.checkBoxPedalMounts = new System.Windows.Forms.CheckBox();
            this.checkBoxDiskBrakes = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listViewBicycles = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxCompetition = new System.Windows.Forms.GroupBox();
            this.radioButtonTrack = new System.Windows.Forms.RadioButton();
            this.radioButtonPleasure = new System.Windows.Forms.RadioButton();
            this.radioButtonUrban = new System.Windows.Forms.RadioButton();
            this.radioButtonMountain = new System.Windows.Forms.RadioButton();
            this.checkBoxCompetition = new System.Windows.Forms.CheckBox();
            this.timerBuildingTime = new System.Windows.Forms.Timer(this.components);
            this.labelElapsed = new System.Windows.Forms.Label();
            this.checkedListBoxStyle = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonBig = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.textBoxBicycleName = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.trackBarItems = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBicycle = new System.Windows.Forms.Button();
            this.comboBoxBicycles = new System.Windows.Forms.ComboBox();
            this.listBoxBicycles = new System.Windows.Forms.ListBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.m_ToolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.m_ToolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxCompetition.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.checkBoxLights);
            this.groupBoxMaterial.Controls.Add(this.checkBoxCustom);
            this.groupBoxMaterial.Controls.Add(this.checkBoxGears);
            this.groupBoxMaterial.Controls.Add(this.checkBoxPedalMounts);
            this.groupBoxMaterial.Controls.Add(this.checkBoxDiskBrakes);
            this.groupBoxMaterial.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxMaterial.ForeColor = System.Drawing.Color.Black;
            this.groupBoxMaterial.Location = new System.Drawing.Point(307, 62);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(179, 146);
            this.groupBoxMaterial.TabIndex = 2;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Доп опции";
            // 
            // checkBoxLights
            // 
            this.checkBoxLights.AutoSize = true;
            this.checkBoxLights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxLights.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxLights.ForeColor = System.Drawing.Color.Black;
            this.checkBoxLights.Location = new System.Drawing.Point(9, 66);
            this.checkBoxLights.Name = "checkBoxLights";
            this.checkBoxLights.Size = new System.Drawing.Size(69, 21);
            this.checkBoxLights.TabIndex = 10;
            this.checkBoxLights.Text = "Фары";
            this.checkBoxLights.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustom
            // 
            this.checkBoxCustom.AutoSize = true;
            this.checkBoxCustom.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxCustom.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxCustom.ForeColor = System.Drawing.Color.Black;
            this.checkBoxCustom.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxCustom.Location = new System.Drawing.Point(9, 20);
            this.checkBoxCustom.Name = "checkBoxCustom";
            this.checkBoxCustom.Size = new System.Drawing.Size(111, 21);
            this.checkBoxCustom.TabIndex = 2;
            this.checkBoxCustom.Text = "Кастомный";
            this.checkBoxCustom.UseVisualStyleBackColor = true;
            // 
            // checkBoxGears
            // 
            this.checkBoxGears.AutoSize = true;
            this.checkBoxGears.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxGears.ForeColor = System.Drawing.Color.Black;
            this.checkBoxGears.Location = new System.Drawing.Point(9, 43);
            this.checkBoxGears.Name = "checkBoxGears";
            this.checkBoxGears.Size = new System.Drawing.Size(99, 21);
            this.checkBoxGears.TabIndex = 9;
            this.checkBoxGears.Text = "Передачи";
            this.checkBoxGears.UseVisualStyleBackColor = true;
            // 
            // checkBoxPedalMounts
            // 
            this.checkBoxPedalMounts.AutoSize = true;
            this.checkBoxPedalMounts.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxPedalMounts.ForeColor = System.Drawing.Color.Black;
            this.checkBoxPedalMounts.Location = new System.Drawing.Point(9, 89);
            this.checkBoxPedalMounts.Name = "checkBoxPedalMounts";
            this.checkBoxPedalMounts.Size = new System.Drawing.Size(174, 21);
            this.checkBoxPedalMounts.TabIndex = 12;
            this.checkBoxPedalMounts.Text = "Крепления педалей";
            this.checkBoxPedalMounts.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiskBrakes
            // 
            this.checkBoxDiskBrakes.AutoSize = true;
            this.checkBoxDiskBrakes.CausesValidation = false;
            this.checkBoxDiskBrakes.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxDiskBrakes.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDiskBrakes.Location = new System.Drawing.Point(9, 112);
            this.checkBoxDiskBrakes.Name = "checkBoxDiskBrakes";
            this.checkBoxDiskBrakes.Size = new System.Drawing.Size(167, 21);
            this.checkBoxDiskBrakes.TabIndex = 11;
            this.checkBoxDiskBrakes.Text = "Дисковые Тормоза";
            this.checkBoxDiskBrakes.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(612, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listViewBicycles
            // 
            this.listViewBicycles.BackColor = System.Drawing.SystemColors.Window;
            this.listViewBicycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewBicycles.CheckBoxes = true;
            this.listViewBicycles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Amount,
            this.Colour});
            this.listViewBicycles.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.listViewBicycles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewBicycles.FullRowSelect = true;
            this.listViewBicycles.HideSelection = false;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            this.listViewBicycles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listViewBicycles.Location = new System.Drawing.Point(12, 62);
            this.listViewBicycles.Margin = new System.Windows.Forms.Padding(5);
            this.listViewBicycles.Name = "listViewBicycles";
            this.listViewBicycles.Size = new System.Drawing.Size(287, 130);
            this.listViewBicycles.TabIndex = 12;
            this.listViewBicycles.UseCompatibleStateImageBehavior = false;
            this.listViewBicycles.View = System.Windows.Forms.View.Details;
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
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(523, 395);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(83, 23);
            this.buttonLoad.TabIndex = 17;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxCompetition
            // 
            this.groupBoxCompetition.Controls.Add(this.radioButtonTrack);
            this.groupBoxCompetition.Controls.Add(this.radioButtonPleasure);
            this.groupBoxCompetition.Controls.Add(this.radioButtonUrban);
            this.groupBoxCompetition.Controls.Add(this.radioButtonMountain);
            this.groupBoxCompetition.Enabled = false;
            this.groupBoxCompetition.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxCompetition.Location = new System.Drawing.Point(495, 87);
            this.groupBoxCompetition.Name = "groupBoxCompetition";
            this.groupBoxCompetition.Size = new System.Drawing.Size(204, 121);
            this.groupBoxCompetition.TabIndex = 22;
            this.groupBoxCompetition.TabStop = false;
            this.groupBoxCompetition.Text = "Выберите праздник";
            // 
            // radioButtonTrack
            // 
            this.radioButtonTrack.AutoSize = true;
            this.radioButtonTrack.Location = new System.Drawing.Point(12, 90);
            this.radioButtonTrack.Name = "radioButtonTrack";
            this.radioButtonTrack.Size = new System.Drawing.Size(100, 21);
            this.radioButtonTrack.TabIndex = 11;
            this.radioButtonTrack.Text = "Трековый";
            this.radioButtonTrack.UseVisualStyleBackColor = true;
            // 
            // radioButtonPleasure
            // 
            this.radioButtonPleasure.AutoSize = true;
            this.radioButtonPleasure.Location = new System.Drawing.Point(12, 68);
            this.radioButtonPleasure.Name = "radioButtonPleasure";
            this.radioButtonPleasure.Size = new System.Drawing.Size(127, 21);
            this.radioButtonPleasure.TabIndex = 10;
            this.radioButtonPleasure.Text = "Прогулочный";
            this.radioButtonPleasure.UseVisualStyleBackColor = true;
            // 
            // radioButtonUrban
            // 
            this.radioButtonUrban.AutoSize = true;
            this.radioButtonUrban.Location = new System.Drawing.Point(12, 43);
            this.radioButtonUrban.Name = "radioButtonUrban";
            this.radioButtonUrban.Size = new System.Drawing.Size(107, 21);
            this.radioButtonUrban.TabIndex = 10;
            this.radioButtonUrban.Text = "Городской";
            this.radioButtonUrban.UseVisualStyleBackColor = true;
            // 
            // radioButtonMountain
            // 
            this.radioButtonMountain.AutoSize = true;
            this.radioButtonMountain.Checked = true;
            this.radioButtonMountain.Location = new System.Drawing.Point(12, 21);
            this.radioButtonMountain.Name = "radioButtonMountain";
            this.radioButtonMountain.Size = new System.Drawing.Size(84, 21);
            this.radioButtonMountain.TabIndex = 8;
            this.radioButtonMountain.TabStop = true;
            this.radioButtonMountain.Text = "Горный";
            this.radioButtonMountain.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompetition
            // 
            this.checkBoxCompetition.AutoSize = true;
            this.checkBoxCompetition.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompetition.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBoxCompetition.Location = new System.Drawing.Point(492, 62);
            this.checkBoxCompetition.Name = "checkBoxCompetition";
            this.checkBoxCompetition.Size = new System.Drawing.Size(328, 21);
            this.checkBoxCompetition.TabIndex = 23;
            this.checkBoxCompetition.Text = "Выбираете велосипед на соревнование?";
            this.m_ToolTip.SetToolTip(this.checkBoxCompetition, "При нажатии на кнопку будет доспупен выбор типов ");
            this.checkBoxCompetition.UseVisualStyleBackColor = true;
            this.checkBoxCompetition.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timerBuildingTime
            // 
            this.timerBuildingTime.Enabled = true;
            this.timerBuildingTime.Interval = 1000;
            this.timerBuildingTime.Tick += new System.EventHandler(this.timerBuildingTime_Tick);
            // 
            // labelElapsed
            // 
            this.labelElapsed.AutoSize = true;
            this.labelElapsed.Location = new System.Drawing.Point(138, 395);
            this.labelElapsed.Name = "labelElapsed";
            this.labelElapsed.Size = new System.Drawing.Size(99, 17);
            this.labelElapsed.TabIndex = 25;
            this.labelElapsed.Text = "Time elapsed";
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
            this.checkedListBoxStyle.Location = new System.Drawing.Point(80, 202);
            this.checkedListBoxStyle.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBoxStyle.Name = "checkedListBoxStyle";
            this.checkedListBoxStyle.Size = new System.Drawing.Size(139, 61);
            this.checkedListBoxStyle.TabIndex = 26;
            this.m_ToolTip2.SetToolTip(this.checkedListBoxStyle, "Выберите стиль рамы");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Название:";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
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
            // textBoxBicycleName
            // 
            this.textBoxBicycleName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBicycleName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxBicycleName.Location = new System.Drawing.Point(94, 12);
            this.textBoxBicycleName.Name = "textBoxBicycleName";
            this.textBoxBicycleName.Size = new System.Drawing.Size(187, 24);
            this.textBoxBicycleName.TabIndex = 29;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.BackColor = System.Drawing.Color.White;
            this.numericUpDownQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownQuantity.Location = new System.Drawing.Point(497, 14);
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
            this.numericUpDownQuantity.Size = new System.Drawing.Size(66, 24);
            this.numericUpDownQuantity.TabIndex = 32;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // trackBarItems
            // 
            this.trackBarItems.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarItems.CausesValidation = false;
            this.trackBarItems.Location = new System.Drawing.Point(568, 14);
            this.trackBarItems.Minimum = 1;
            this.trackBarItems.Name = "trackBarItems";
            this.trackBarItems.Size = new System.Drawing.Size(117, 56);
            this.trackBarItems.TabIndex = 33;
            this.trackBarItems.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(307, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Сколько велосипедов вы хотите?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAddBicycle);
            this.panel1.Controls.Add(this.comboBoxBicycles);
            this.panel1.Controls.Add(this.listBoxBicycles);
            this.panel1.Location = new System.Drawing.Point(307, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 161);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Добавте дополнительные велосипеды в корзину:";
            // 
            // buttonAddBicycle
            // 
            this.buttonAddBicycle.Location = new System.Drawing.Point(351, 131);
            this.buttonAddBicycle.Name = "buttonAddBicycle";
            this.buttonAddBicycle.Size = new System.Drawing.Size(37, 22);
            this.buttonAddBicycle.TabIndex = 23;
            this.buttonAddBicycle.Text = "+";
            this.m_ToolTip3.SetToolTip(this.buttonAddBicycle, "При нажатии на кнопку вы добавите велосипед в список");
            this.buttonAddBicycle.UseVisualStyleBackColor = true;
            this.buttonAddBicycle.Click += new System.EventHandler(this.buttonAddBicycle_Click);
            // 
            // comboBoxBicycles
            // 
            this.comboBoxBicycles.FormattingEnabled = true;
            this.comboBoxBicycles.Items.AddRange(new object[] {
            "Giant",
            "Author",
            "BMX",
            "Shimano",
            "Fox",
            "Trek",
            "Diamondback"});
            this.comboBoxBicycles.Location = new System.Drawing.Point(3, 132);
            this.comboBoxBicycles.Name = "comboBoxBicycles";
            this.comboBoxBicycles.Size = new System.Drawing.Size(342, 25);
            this.comboBoxBicycles.TabIndex = 22;
            this.comboBoxBicycles.Text = "Веберите велосипед...";
            // 
            // listBoxBicycles
            // 
            this.listBoxBicycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxBicycles.FormattingEnabled = true;
            this.listBoxBicycles.ItemHeight = 17;
            this.listBoxBicycles.Location = new System.Drawing.Point(3, 20);
            this.listBoxBicycles.Name = "listBoxBicycles";
            this.listBoxBicycles.Size = new System.Drawing.Size(385, 104);
            this.listBoxBicycles.TabIndex = 21;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(58, 393);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(65, 24);
            this.numericUpDownPrice.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Цена:";
            // 
            // m_ToolTip
            // 
            this.m_ToolTip.AutomaticDelay = 300;
            this.m_ToolTip.ShowAlways = true;
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
            // FormBicycleMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewBicycles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxBicycleName);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.trackBarItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxStyle);
            this.Controls.Add(this.labelElapsed);
            this.Controls.Add(this.checkBoxCompetition);
            this.Controls.Add(this.groupBoxCompetition);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxMaterial);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormBicycleMaker";
            this.Text = " Bycicle Maker";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.FormBicycleMaker_Load);
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxCompetition.ResumeLayout(false);
            this.groupBoxCompetition.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxCustom;
        private System.Windows.Forms.ListView listViewBicycles;
        private System.Windows.Forms.CheckBox checkBoxGears;
        private System.Windows.Forms.CheckBox checkBoxDiskBrakes;
        private System.Windows.Forms.CheckBox checkBoxLights;
        private System.Windows.Forms.CheckBox checkBoxPedalMounts;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Colour;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxCompetition;
        private System.Windows.Forms.RadioButton radioButtonPleasure;
        private System.Windows.Forms.RadioButton radioButtonUrban;
        private System.Windows.Forms.RadioButton radioButtonMountain;
        private System.Windows.Forms.RadioButton radioButtonTrack;
        private System.Windows.Forms.CheckBox checkBoxCompetition;
        private System.Windows.Forms.Timer timerBuildingTime;
        private System.Windows.Forms.Label labelElapsed;
        private System.Windows.Forms.CheckedListBox checkedListBoxStyle;
       // private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonBig;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.TextBox textBoxBicycleName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TrackBar trackBarItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddBicycle;
        private System.Windows.Forms.ComboBox comboBoxBicycles;
        private System.Windows.Forms.ListBox listBoxBicycles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip m_ToolTip;
        private System.Windows.Forms.ToolTip m_ToolTip2;
        private System.Windows.Forms.ToolTip m_ToolTip3;

    }
}

