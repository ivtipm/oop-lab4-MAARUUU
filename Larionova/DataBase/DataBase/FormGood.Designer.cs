namespace DataBase
{
    partial class FormGood
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGood));
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxOpen = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBoxForSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.comboBoxChoiceSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panelSearchRecord = new System.Windows.Forms.Panel();
            this.pictureBoxPin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelSearchRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSort)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullname,
            this.name,
            this.year,
            this.height,
            this.weight});
            this.dataGridViewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dataGridViewTable.Location = new System.Drawing.Point(342, 154);
            this.dataGridViewTable.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.Size = new System.Drawing.Size(753, 293);
            this.dataGridViewTable.TabIndex = 1;
            // 
            // fullname
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.fullname.DefaultCellStyle = dataGridViewCellStyle2;
            this.fullname.HeaderText = "Фамилия ";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fullname.Width = 135;
            // 
            // name
            // 
            this.name.HeaderText = "Имя ";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.name.Width = 125;
            // 
            // year
            // 
            this.year.HeaderText = "Год рождения";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.year.Width = 125;
            // 
            // height
            // 
            this.height.HeaderText = "Рост";
            this.height.MinimumWidth = 6;
            this.height.Name = "height";
            this.height.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.height.Width = 55;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.weight.HeaderText = "Вес";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.weight.Width = 50;
            // 
            // pictureBoxOpen
            // 
            this.pictureBoxOpen.ErrorImage = null;
            this.pictureBoxOpen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpen.Image")));
            this.pictureBoxOpen.InitialImage = null;
            this.pictureBoxOpen.Location = new System.Drawing.Point(14, 43);
            this.pictureBoxOpen.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxOpen.Name = "pictureBoxOpen";
            this.pictureBoxOpen.Size = new System.Drawing.Size(60, 53);
            this.pictureBoxOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpen.TabIndex = 2;
            this.pictureBoxOpen.TabStop = false;
            this.pictureBoxOpen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.ErrorImage = null;
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.InitialImage = null;
            this.pictureBoxSave.Location = new System.Drawing.Point(98, 42);
            this.pictureBoxSave.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(60, 53);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSave.TabIndex = 3;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.ErrorImage = null;
            this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
            this.pictureBoxAdd.InitialImage = null;
            this.pictureBoxAdd.Location = new System.Drawing.Point(262, 43);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(60, 53);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 4;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.ErrorImage = null;
            this.pictureBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete.Image")));
            this.pictureBoxDelete.InitialImage = null;
            this.pictureBoxDelete.Location = new System.Drawing.Point(182, 42);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(60, 53);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDelete.TabIndex = 5;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxForSearch
            // 
            this.textBoxForSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForSearch.Location = new System.Drawing.Point(10, 57);
            this.textBoxForSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxForSearch.Name = "textBoxForSearch";
            this.textBoxForSearch.Size = new System.Drawing.Size(185, 26);
            this.textBoxForSearch.TabIndex = 14;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Silver;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.Location = new System.Drawing.Point(55, 5);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(175, 45);
            this.btnSort.TabIndex = 24;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // comboBoxChoiceSort
            // 
            this.comboBoxChoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceSort.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoiceSort.FormattingEnabled = true;
            this.comboBoxChoiceSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxChoiceSort.Location = new System.Drawing.Point(238, 15);
            this.comboBoxChoiceSort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChoiceSort.Name = "comboBoxChoiceSort";
            this.comboBoxChoiceSort.Size = new System.Drawing.Size(165, 28);
            this.comboBoxChoiceSort.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Поиск по фамилии/имени";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(222, 51);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArtist.ForeColor = System.Drawing.Color.Black;
            this.labelArtist.Location = new System.Drawing.Point(49, 135);
            this.labelArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(95, 24);
            this.labelArtist.TabIndex = 28;
            this.labelArtist.Text = "Модель:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullName.Location = new System.Drawing.Point(31, 163);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(145, 26);
            this.textBoxFullName.TabIndex = 29;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(36, 211);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(157, 24);
            this.labelYear.TabIndex = 30;
            this.labelYear.Text = "Год рождения:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(207, 209);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(91, 26);
            this.textBoxYear.TabIndex = 31;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(207, 257);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(91, 26);
            this.textBoxHeight.TabIndex = 33;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.ForeColor = System.Drawing.Color.Black;
            this.labelHeight.Location = new System.Drawing.Point(123, 259);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(62, 24);
            this.labelHeight.TabIndex = 32;
            this.labelHeight.Text = "Рост:";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeight.Location = new System.Drawing.Point(207, 299);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(91, 26);
            this.textBoxWeight.TabIndex = 35;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.ForeColor = System.Drawing.Color.Black;
            this.labelWeight.Location = new System.Drawing.Point(132, 301);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(53, 24);
            this.labelWeight.TabIndex = 34;
            this.labelWeight.Text = "Вес:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(190, 161);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(116, 26);
            this.textBoxName.TabIndex = 36;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Silver;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Location = new System.Drawing.Point(31, 362);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(127, 46);
            this.btnAddUser.TabIndex = 37;
            this.btnAddUser.Text = "Добавить ";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.BackColor = System.Drawing.Color.Silver;
            this.btnDelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelUser.FlatAppearance.BorderSize = 0;
            this.btnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelUser.ForeColor = System.Drawing.Color.Black;
            this.btnDelUser.Location = new System.Drawing.Point(182, 362);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(124, 46);
            this.btnDelUser.TabIndex = 38;
            this.btnDelUser.Text = "Удалить ";
            this.btnDelUser.UseVisualStyleBackColor = false;
            this.btnDelUser.Click += new System.EventHandler(this.btnClearRow_Click);
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoSave.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAutoSave.Location = new System.Drawing.Point(968, 441);
            this.labelAutoSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(140, 22);
            this.labelAutoSave.TabIndex = 39;
            this.labelAutoSave.Text = "Автосохранение...";
            this.labelAutoSave.Visible = false;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSave.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSave.Location = new System.Drawing.Point(1001, 463);
            this.labelSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(107, 22);
            this.labelSave.TabIndex = 40;
            this.labelSave.Text = "Сохранение...";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.ErrorImage = null;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.InitialImage = null;
            this.pictureBoxSearch.Location = new System.Drawing.Point(342, 43);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(60, 53);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 41;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panelSearchRecord
            // 
            this.panelSearchRecord.Controls.Add(this.btnSearch);
            this.panelSearchRecord.Controls.Add(this.label1);
            this.panelSearchRecord.Controls.Add(this.textBoxForSearch);
            this.panelSearchRecord.Location = new System.Drawing.Point(0, 135);
            this.panelSearchRecord.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearchRecord.Name = "panelSearchRecord";
            this.panelSearchRecord.Size = new System.Drawing.Size(339, 117);
            this.panelSearchRecord.TabIndex = 42;
            // 
            // pictureBoxPin
            // 
            this.pictureBoxPin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPin.Image")));
            this.pictureBoxPin.Location = new System.Drawing.Point(40, 227);
            this.pictureBoxPin.Name = "pictureBoxPin";
            this.pictureBoxPin.Size = new System.Drawing.Size(278, 235);
            this.pictureBoxPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPin.TabIndex = 43;
            this.pictureBoxPin.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.comboBoxChoiceSort);
            this.panel1.Location = new System.Drawing.Point(692, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 74);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(478, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(763, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(951, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxSort
            // 
            this.pictureBoxSort.ErrorImage = null;
            this.pictureBoxSort.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSort.Image")));
            this.pictureBoxSort.InitialImage = null;
            this.pictureBoxSort.Location = new System.Drawing.Point(425, 42);
            this.pictureBoxSort.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSort.Name = "pictureBoxSort";
            this.pictureBoxSort.Size = new System.Drawing.Size(60, 53);
            this.pictureBoxSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSort.TabIndex = 49;
            this.pictureBoxSort.TabStop = false;
            this.pictureBoxSort.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1108, 485);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxSort);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.pictureBoxOpen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelSearchRecord);
            this.Controls.Add(this.pictureBoxPin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1126, 532);
            this.MinimumSize = new System.Drawing.Size(1126, 532);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelSearchRecord.ResumeLayout(false);
            this.panelSearchRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.PictureBox pictureBoxOpen;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxForSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox comboBoxChoiceSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.Label labelAutoSave;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panelSearchRecord;
        private System.Windows.Forms.PictureBox pictureBoxPin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBoxSort;
    }
}

