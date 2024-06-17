namespace ToDoListProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage4 = new TabPage();
            materialFloatingActionButton19 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton18 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton17 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton16 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton15 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton14 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton13 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton12 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton11 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton10 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton8 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton7 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton9 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton6 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton5 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton4 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            btUpdateDataUser = new MaterialSkin.Controls.MaterialButton();
            tbPhone = new MaterialSkin.Controls.MaterialTextBox();
            tbEmail = new MaterialSkin.Controls.MaterialTextBox();
            tbName = new MaterialSkin.Controls.MaterialTextBox();
            lbPhone = new MaterialSkin.Controls.MaterialLabel();
            lbEmail = new MaterialSkin.Controls.MaterialLabel();
            lbName = new MaterialSkin.Controls.MaterialLabel();
            lbUser = new MaterialSkin.Controls.MaterialLabel();
            All = new TabPage();
            list1 = new MaterialSkin.Controls.MaterialListView();
            c1 = new ColumnHeader();
            c5 = new ColumnHeader();
            c2 = new ColumnHeader();
            c3 = new ColumnHeader();
            c4 = new ColumnHeader();
            cbCategory2 = new MaterialSkin.Controls.MaterialComboBox();
            ButtonAddQ = new MaterialSkin.Controls.MaterialButton();
            ButtonAddTask = new MaterialSkin.Controls.MaterialButton();
            materialSlider5 = new MaterialSkin.Controls.MaterialSlider();
            materialSlider4 = new MaterialSkin.Controls.MaterialSlider();
            materialSlider3 = new MaterialSkin.Controls.MaterialSlider();
            materialSlider2 = new MaterialSkin.Controls.MaterialSlider();
            materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            monthCalendar1 = new MonthCalendar();
            Pending = new TabPage();
            list2 = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            Complete = new TabPage();
            list3 = new MaterialSkin.Controls.MaterialListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            Charts = new TabPage();
            btnOpen = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            ButtonDocument = new MaterialSkin.Controls.MaterialButton();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Category = new TabPage();
            btnCategory = new MaterialSkin.Controls.MaterialButton();
            listBox1 = new MaterialSkin.Controls.MaterialListBox();
            lbCat3 = new MaterialSkin.Controls.MaterialLabel();
            tbCat2 = new MaterialSkin.Controls.MaterialTextBox();
            lbCat2 = new MaterialSkin.Controls.MaterialLabel();
            Settings = new TabPage();
            LabelLanguage = new MaterialSkin.Controls.MaterialLabel();
            LabelTheme = new MaterialSkin.Controls.MaterialLabel();
            ComboBoxLanguage = new MaterialSkin.Controls.MaterialComboBox();
            ComboBoxTheme = new MaterialSkin.Controls.MaterialComboBox();
            SwitchMode = new MaterialSkin.Controls.MaterialSwitch();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            All.SuspendLayout();
            Pending.SuspendLayout();
            Complete.SuspendLayout();
            Charts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            Category.SuspendLayout();
            Settings.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(All);
            materialTabControl1.Controls.Add(Pending);
            materialTabControl1.Controls.Add(Complete);
            materialTabControl1.Controls.Add(Charts);
            materialTabControl1.Controls.Add(Category);
            materialTabControl1.Controls.Add(Settings);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1395, 740);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(materialFloatingActionButton19);
            tabPage4.Controls.Add(materialFloatingActionButton18);
            tabPage4.Controls.Add(materialFloatingActionButton17);
            tabPage4.Controls.Add(materialFloatingActionButton16);
            tabPage4.Controls.Add(materialFloatingActionButton15);
            tabPage4.Controls.Add(materialFloatingActionButton14);
            tabPage4.Controls.Add(materialFloatingActionButton13);
            tabPage4.Controls.Add(materialFloatingActionButton12);
            tabPage4.Controls.Add(materialFloatingActionButton11);
            tabPage4.Controls.Add(materialFloatingActionButton10);
            tabPage4.Controls.Add(materialFloatingActionButton8);
            tabPage4.Controls.Add(materialFloatingActionButton7);
            tabPage4.Controls.Add(materialFloatingActionButton9);
            tabPage4.Controls.Add(materialFloatingActionButton6);
            tabPage4.Controls.Add(materialFloatingActionButton5);
            tabPage4.Controls.Add(materialFloatingActionButton4);
            tabPage4.Controls.Add(materialFloatingActionButton3);
            tabPage4.Controls.Add(materialFloatingActionButton2);
            tabPage4.Controls.Add(materialFloatingActionButton1);
            tabPage4.Controls.Add(btUpdateDataUser);
            tabPage4.Controls.Add(tbPhone);
            tabPage4.Controls.Add(tbEmail);
            tabPage4.Controls.Add(tbName);
            tabPage4.Controls.Add(lbPhone);
            tabPage4.Controls.Add(lbEmail);
            tabPage4.Controls.Add(lbName);
            tabPage4.Controls.Add(lbUser);
            tabPage4.ImageKey = "icons8-user-32.png";
            tabPage4.Location = new Point(4, 31);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1387, 705);
            tabPage4.TabIndex = 8;
            tabPage4.Text = "Profile";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton19
            // 
            materialFloatingActionButton19.Depth = 0;
            materialFloatingActionButton19.Icon = null;
            materialFloatingActionButton19.Location = new Point(972, 463);
            materialFloatingActionButton19.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton19.Name = "materialFloatingActionButton19";
            materialFloatingActionButton19.Size = new Size(70, 70);
            materialFloatingActionButton19.TabIndex = 28;
            materialFloatingActionButton19.Text = "materialFloatingActionButton19";
            materialFloatingActionButton19.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton18
            // 
            materialFloatingActionButton18.Depth = 0;
            materialFloatingActionButton18.Icon = null;
            materialFloatingActionButton18.Location = new Point(1017, 479);
            materialFloatingActionButton18.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton18.Name = "materialFloatingActionButton18";
            materialFloatingActionButton18.Size = new Size(70, 70);
            materialFloatingActionButton18.TabIndex = 27;
            materialFloatingActionButton18.Text = "materialFloatingActionButton18";
            materialFloatingActionButton18.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton17
            // 
            materialFloatingActionButton17.Depth = 0;
            materialFloatingActionButton17.Icon = null;
            materialFloatingActionButton17.Location = new Point(967, 493);
            materialFloatingActionButton17.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton17.Name = "materialFloatingActionButton17";
            materialFloatingActionButton17.Size = new Size(70, 70);
            materialFloatingActionButton17.TabIndex = 26;
            materialFloatingActionButton17.Text = "materialFloatingActionButton17";
            materialFloatingActionButton17.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton16
            // 
            materialFloatingActionButton16.Depth = 0;
            materialFloatingActionButton16.Icon = null;
            materialFloatingActionButton16.Location = new Point(941, 463);
            materialFloatingActionButton16.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton16.Name = "materialFloatingActionButton16";
            materialFloatingActionButton16.Size = new Size(70, 70);
            materialFloatingActionButton16.TabIndex = 25;
            materialFloatingActionButton16.Text = "materialFloatingActionButton16";
            materialFloatingActionButton16.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton15
            // 
            materialFloatingActionButton15.Depth = 0;
            materialFloatingActionButton15.Icon = null;
            materialFloatingActionButton15.Location = new Point(1001, 439);
            materialFloatingActionButton15.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton15.Name = "materialFloatingActionButton15";
            materialFloatingActionButton15.Size = new Size(70, 70);
            materialFloatingActionButton15.TabIndex = 24;
            materialFloatingActionButton15.Text = "materialFloatingActionButton15";
            materialFloatingActionButton15.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton14
            // 
            materialFloatingActionButton14.Depth = 0;
            materialFloatingActionButton14.Icon = null;
            materialFloatingActionButton14.Location = new Point(967, 428);
            materialFloatingActionButton14.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton14.Name = "materialFloatingActionButton14";
            materialFloatingActionButton14.Size = new Size(70, 70);
            materialFloatingActionButton14.TabIndex = 23;
            materialFloatingActionButton14.Text = "materialFloatingActionButton14";
            materialFloatingActionButton14.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton13
            // 
            materialFloatingActionButton13.Depth = 0;
            materialFloatingActionButton13.Icon = null;
            materialFloatingActionButton13.Location = new Point(1209, 238);
            materialFloatingActionButton13.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton13.Name = "materialFloatingActionButton13";
            materialFloatingActionButton13.Size = new Size(70, 70);
            materialFloatingActionButton13.TabIndex = 22;
            materialFloatingActionButton13.Text = "materialFloatingActionButton13";
            materialFloatingActionButton13.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton12
            // 
            materialFloatingActionButton12.Depth = 0;
            materialFloatingActionButton12.Icon = null;
            materialFloatingActionButton12.Location = new Point(1197, 267);
            materialFloatingActionButton12.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton12.Name = "materialFloatingActionButton12";
            materialFloatingActionButton12.Size = new Size(70, 70);
            materialFloatingActionButton12.TabIndex = 21;
            materialFloatingActionButton12.Text = "materialFloatingActionButton12";
            materialFloatingActionButton12.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton11
            // 
            materialFloatingActionButton11.Depth = 0;
            materialFloatingActionButton11.Icon = null;
            materialFloatingActionButton11.Location = new Point(1163, 238);
            materialFloatingActionButton11.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton11.Name = "materialFloatingActionButton11";
            materialFloatingActionButton11.Size = new Size(70, 70);
            materialFloatingActionButton11.TabIndex = 20;
            materialFloatingActionButton11.Text = "materialFloatingActionButton11";
            materialFloatingActionButton11.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton10
            // 
            materialFloatingActionButton10.Depth = 0;
            materialFloatingActionButton10.Icon = null;
            materialFloatingActionButton10.Location = new Point(1239, 261);
            materialFloatingActionButton10.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton10.Name = "materialFloatingActionButton10";
            materialFloatingActionButton10.Size = new Size(70, 70);
            materialFloatingActionButton10.TabIndex = 19;
            materialFloatingActionButton10.Text = "materialFloatingActionButton10";
            materialFloatingActionButton10.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton8
            // 
            materialFloatingActionButton8.Depth = 0;
            materialFloatingActionButton8.Icon = null;
            materialFloatingActionButton8.Location = new Point(1239, 224);
            materialFloatingActionButton8.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton8.Name = "materialFloatingActionButton8";
            materialFloatingActionButton8.Size = new Size(70, 70);
            materialFloatingActionButton8.TabIndex = 18;
            materialFloatingActionButton8.Text = "materialFloatingActionButton8";
            materialFloatingActionButton8.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton7
            // 
            materialFloatingActionButton7.Depth = 0;
            materialFloatingActionButton7.Icon = null;
            materialFloatingActionButton7.Location = new Point(1197, 211);
            materialFloatingActionButton7.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton7.Name = "materialFloatingActionButton7";
            materialFloatingActionButton7.Size = new Size(70, 70);
            materialFloatingActionButton7.TabIndex = 17;
            materialFloatingActionButton7.Text = "materialFloatingActionButton7";
            materialFloatingActionButton7.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton9
            // 
            materialFloatingActionButton9.Depth = 0;
            materialFloatingActionButton9.Icon = null;
            materialFloatingActionButton9.Location = new Point(1017, 105);
            materialFloatingActionButton9.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton9.Name = "materialFloatingActionButton9";
            materialFloatingActionButton9.Size = new Size(70, 70);
            materialFloatingActionButton9.TabIndex = 16;
            materialFloatingActionButton9.Text = "materialFloatingActionButton9";
            materialFloatingActionButton9.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton6
            // 
            materialFloatingActionButton6.Depth = 0;
            materialFloatingActionButton6.Icon = null;
            materialFloatingActionButton6.Location = new Point(1001, 63);
            materialFloatingActionButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton6.Name = "materialFloatingActionButton6";
            materialFloatingActionButton6.Size = new Size(70, 70);
            materialFloatingActionButton6.TabIndex = 13;
            materialFloatingActionButton6.Text = "materialFloatingActionButton6";
            materialFloatingActionButton6.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton5
            // 
            materialFloatingActionButton5.Depth = 0;
            materialFloatingActionButton5.Icon = null;
            materialFloatingActionButton5.Location = new Point(1062, 117);
            materialFloatingActionButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton5.Name = "materialFloatingActionButton5";
            materialFloatingActionButton5.Size = new Size(70, 70);
            materialFloatingActionButton5.TabIndex = 12;
            materialFloatingActionButton5.Text = "materialFloatingActionButton5";
            materialFloatingActionButton5.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton4
            // 
            materialFloatingActionButton4.Depth = 0;
            materialFloatingActionButton4.Icon = null;
            materialFloatingActionButton4.Location = new Point(986, 139);
            materialFloatingActionButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton4.Name = "materialFloatingActionButton4";
            materialFloatingActionButton4.Size = new Size(70, 70);
            materialFloatingActionButton4.TabIndex = 11;
            materialFloatingActionButton4.Text = "materialFloatingActionButton4";
            materialFloatingActionButton4.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton3
            // 
            materialFloatingActionButton3.Depth = 0;
            materialFloatingActionButton3.Icon = null;
            materialFloatingActionButton3.Location = new Point(1027, 148);
            materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            materialFloatingActionButton3.Size = new Size(70, 70);
            materialFloatingActionButton3.TabIndex = 10;
            materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = null;
            materialFloatingActionButton2.Location = new Point(972, 105);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(70, 70);
            materialFloatingActionButton2.TabIndex = 9;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = null;
            materialFloatingActionButton1.Location = new Point(1048, 73);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(59, 60);
            materialFloatingActionButton1.TabIndex = 8;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // btUpdateDataUser
            // 
            btUpdateDataUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btUpdateDataUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btUpdateDataUser.Depth = 0;
            btUpdateDataUser.HighEmphasis = true;
            btUpdateDataUser.Icon = null;
            btUpdateDataUser.Location = new Point(494, 410);
            btUpdateDataUser.Margin = new Padding(4, 6, 4, 6);
            btUpdateDataUser.MouseState = MaterialSkin.MouseState.HOVER;
            btUpdateDataUser.Name = "btUpdateDataUser";
            btUpdateDataUser.NoAccentTextColor = Color.Empty;
            btUpdateDataUser.Size = new Size(77, 36);
            btUpdateDataUser.TabIndex = 7;
            btUpdateDataUser.Text = "UPDATE ";
            btUpdateDataUser.TextAlign = ContentAlignment.TopLeft;
            btUpdateDataUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btUpdateDataUser.UseAccentColor = false;
            btUpdateDataUser.UseVisualStyleBackColor = true;
            btUpdateDataUser.Click += materialButton1_Click_1;
            // 
            // tbPhone
            // 
            tbPhone.AnimateReadOnly = false;
            tbPhone.BorderStyle = BorderStyle.None;
            tbPhone.Depth = 0;
            tbPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPhone.LeadingIcon = null;
            tbPhone.Location = new Point(347, 287);
            tbPhone.MaxLength = 50;
            tbPhone.MouseState = MaterialSkin.MouseState.OUT;
            tbPhone.Multiline = false;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(412, 50);
            tbPhone.TabIndex = 6;
            tbPhone.Text = "";
            tbPhone.TrailingIcon = null;
            // 
            // tbEmail
            // 
            tbEmail.AnimateReadOnly = false;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Depth = 0;
            tbEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmail.LeadingIcon = null;
            tbEmail.Location = new Point(347, 195);
            tbEmail.MaxLength = 50;
            tbEmail.MouseState = MaterialSkin.MouseState.OUT;
            tbEmail.Multiline = false;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(412, 50);
            tbEmail.TabIndex = 5;
            tbEmail.Text = "";
            tbEmail.TrailingIcon = null;
            // 
            // tbName
            // 
            tbName.AnimateReadOnly = false;
            tbName.BorderStyle = BorderStyle.None;
            tbName.Depth = 0;
            tbName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbName.LeadingIcon = null;
            tbName.Location = new Point(347, 117);
            tbName.MaxLength = 50;
            tbName.MouseState = MaterialSkin.MouseState.OUT;
            tbName.Multiline = false;
            tbName.Name = "tbName";
            tbName.Size = new Size(412, 50);
            tbName.TabIndex = 4;
            tbName.Text = "";
            tbName.TrailingIcon = null;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Depth = 0;
            lbPhone.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbPhone.Location = new Point(176, 289);
            lbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(46, 19);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Phone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Depth = 0;
            lbEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbEmail.Location = new Point(176, 211);
            lbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 19);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Depth = 0;
            lbName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbName.Location = new Point(176, 133);
            lbName.MouseState = MaterialSkin.MouseState.HOVER;
            lbName.Name = "lbName";
            lbName.Size = new Size(43, 19);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Depth = 0;
            lbUser.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbUser.Location = new Point(470, 56);
            lbUser.MouseState = MaterialSkin.MouseState.HOVER;
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(70, 19);
            lbUser.TabIndex = 0;
            lbUser.Text = "Data User";
            // 
            // All
            // 
            All.Controls.Add(list1);
            All.Controls.Add(cbCategory2);
            All.Controls.Add(ButtonAddQ);
            All.Controls.Add(ButtonAddTask);
            All.Controls.Add(materialSlider5);
            All.Controls.Add(materialSlider4);
            All.Controls.Add(materialSlider3);
            All.Controls.Add(materialSlider2);
            All.Controls.Add(materialSlider1);
            All.Controls.Add(materialDrawer1);
            All.Controls.Add(monthCalendar1);
            All.ImageKey = "icons8-calendar-32.png";
            All.Location = new Point(4, 31);
            All.Name = "All";
            All.Size = new Size(1387, 705);
            All.TabIndex = 2;
            All.Text = "All";
            All.UseVisualStyleBackColor = true;
            // 
            // list1
            // 
            list1.AutoSizeTable = false;
            list1.BackColor = Color.FromArgb(255, 255, 255);
            list1.BorderStyle = BorderStyle.None;
            list1.Columns.AddRange(new ColumnHeader[] { c1, c5, c2, c3, c4 });
            list1.Depth = 0;
            list1.FullRowSelect = true;
            list1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            list1.Location = new Point(304, 3);
            list1.MinimumSize = new Size(200, 100);
            list1.MouseLocation = new Point(-1, -1);
            list1.MouseState = MaterialSkin.MouseState.OUT;
            list1.Name = "list1";
            list1.OwnerDraw = true;
            list1.Size = new Size(1080, 703);
            list1.TabIndex = 11;
            list1.UseCompatibleStateImageBehavior = false;
            list1.View = View.Details;
            list1.SelectedIndexChanged += list1_SelectedIndexChanged;
            // 
            // c1
            // 
            c1.Text = "Description";
            c1.Width = 300;
            // 
            // c5
            // 
            c5.DisplayIndex = 4;
            c5.Text = "Category";
            c5.Width = 300;
            // 
            // c2
            // 
            c2.DisplayIndex = 1;
            c2.Text = "Start Data";
            c2.TextAlign = HorizontalAlignment.Center;
            c2.Width = 200;
            // 
            // c3
            // 
            c3.DisplayIndex = 2;
            c3.Text = "End Data";
            c3.Width = 200;
            // 
            // c4
            // 
            c4.DisplayIndex = 3;
            c4.Text = "Status";
            c4.Width = 120;
            // 
            // cbCategory2
            // 
            cbCategory2.AutoResize = false;
            cbCategory2.BackColor = Color.FromArgb(255, 255, 255);
            cbCategory2.Depth = 0;
            cbCategory2.DrawMode = DrawMode.OwnerDrawVariable;
            cbCategory2.DropDownHeight = 174;
            cbCategory2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory2.DropDownWidth = 121;
            cbCategory2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCategory2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCategory2.FormattingEnabled = true;
            cbCategory2.IntegralHeight = false;
            cbCategory2.ItemHeight = 43;
            cbCategory2.Location = new Point(141, 233);
            cbCategory2.MaxDropDownItems = 4;
            cbCategory2.MouseState = MaterialSkin.MouseState.OUT;
            cbCategory2.Name = "cbCategory2";
            cbCategory2.Size = new Size(151, 49);
            cbCategory2.StartIndex = 0;
            cbCategory2.TabIndex = 10;
            cbCategory2.SelectedIndexChanged += cbCategory2_SelectedIndexChanged;
            // 
            // ButtonAddQ
            // 
            ButtonAddQ.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAddQ.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonAddQ.Depth = 0;
            ButtonAddQ.HighEmphasis = true;
            ButtonAddQ.Icon = null;
            ButtonAddQ.Location = new Point(102, 653);
            ButtonAddQ.Margin = new Padding(4, 6, 4, 6);
            ButtonAddQ.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonAddQ.Name = "ButtonAddQ";
            ButtonAddQ.NoAccentTextColor = Color.Empty;
            ButtonAddQ.Size = new Size(64, 36);
            ButtonAddQ.TabIndex = 8;
            ButtonAddQ.Text = "ADD ";
            ButtonAddQ.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonAddQ.UseAccentColor = false;
            ButtonAddQ.UseVisualStyleBackColor = true;
            ButtonAddQ.Click += materialButton2_Click;
            // 
            // ButtonAddTask
            // 
            ButtonAddTask.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAddTask.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonAddTask.Depth = 0;
            ButtonAddTask.HighEmphasis = true;
            ButtonAddTask.Icon = null;
            ButtonAddTask.Location = new Point(27, 236);
            ButtonAddTask.Margin = new Padding(4, 6, 4, 6);
            ButtonAddTask.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonAddTask.Name = "ButtonAddTask";
            ButtonAddTask.NoAccentTextColor = Color.Empty;
            ButtonAddTask.Size = new Size(91, 36);
            ButtonAddTask.TabIndex = 1;
            ButtonAddTask.Text = "Add task";
            ButtonAddTask.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonAddTask.UseAccentColor = false;
            ButtonAddTask.UseVisualStyleBackColor = true;
            ButtonAddTask.Click += materialButton1_Click;
            // 
            // materialSlider5
            // 
            materialSlider5.Depth = 0;
            materialSlider5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider5.Location = new Point(16, 575);
            materialSlider5.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider5.Name = "materialSlider5";
            materialSlider5.Size = new Size(276, 40);
            materialSlider5.TabIndex = 7;
            materialSlider5.Text = "Level of satisfaction:";
            materialSlider5.Click += materialSlider5_Click;
            // 
            // materialSlider4
            // 
            materialSlider4.Depth = 0;
            materialSlider4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider4.Location = new Point(16, 520);
            materialSlider4.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider4.Name = "materialSlider4";
            materialSlider4.Size = new Size(278, 40);
            materialSlider4.TabIndex = 6;
            materialSlider4.Text = "Stress Level:";
            // 
            // materialSlider3
            // 
            materialSlider3.Depth = 0;
            materialSlider3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider3.Location = new Point(16, 463);
            materialSlider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider3.Name = "materialSlider3";
            materialSlider3.Size = new Size(278, 40);
            materialSlider3.TabIndex = 5;
            materialSlider3.Text = "Hours allocated today:";
            // 
            // materialSlider2
            // 
            materialSlider2.Depth = 0;
            materialSlider2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider2.Location = new Point(16, 398);
            materialSlider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider2.Name = "materialSlider2";
            materialSlider2.Size = new Size(278, 40);
            materialSlider2.TabIndex = 4;
            materialSlider2.Text = "Tasks completed today:";
            materialSlider2.Click += materialSlider2_Click;
            // 
            // materialSlider1
            // 
            materialSlider1.Depth = 0;
            materialSlider1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider1.Location = new Point(16, 339);
            materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider1.Name = "materialSlider1";
            materialSlider1.Size = new Size(278, 40);
            materialSlider1.TabIndex = 3;
            materialSlider1.Text = "How did you feel today?";
            materialSlider1.Click += materialSlider1_Click;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-312, 158);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(312, 150);
            materialDrawer1.TabIndex = 1;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Black;
            monthCalendar1.Location = new Point(9, 14);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = Color.Red;
            monthCalendar1.TrailingForeColor = Color.Transparent;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Pending
            // 
            Pending.Controls.Add(list2);
            Pending.ImageKey = "icons8-pending-32.png";
            Pending.Location = new Point(4, 31);
            Pending.Name = "Pending";
            Pending.Size = new Size(1387, 705);
            Pending.TabIndex = 3;
            Pending.Text = "Pending";
            Pending.UseVisualStyleBackColor = true;
            // 
            // list2
            // 
            list2.AutoSizeTable = false;
            list2.BackColor = Color.FromArgb(255, 255, 255);
            list2.BorderStyle = BorderStyle.None;
            list2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            list2.Depth = 0;
            list2.Dock = DockStyle.Fill;
            list2.FullRowSelect = true;
            list2.Location = new Point(0, 0);
            list2.MinimumSize = new Size(200, 100);
            list2.MouseLocation = new Point(-1, -1);
            list2.MouseState = MaterialSkin.MouseState.OUT;
            list2.Name = "list2";
            list2.OwnerDraw = true;
            list2.Size = new Size(1387, 705);
            list2.TabIndex = 0;
            list2.UseCompatibleStateImageBehavior = false;
            list2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Description";
            columnHeader1.Width = 500;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Category";
            columnHeader6.Width = 300;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Start Data";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "End Data";
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Status";
            columnHeader9.Width = 200;
            // 
            // Complete
            // 
            Complete.Controls.Add(list3);
            Complete.ImageKey = "icons8-complete-32.png";
            Complete.Location = new Point(4, 31);
            Complete.Name = "Complete";
            Complete.Size = new Size(1387, 705);
            Complete.TabIndex = 4;
            Complete.Text = "Complete";
            Complete.UseVisualStyleBackColor = true;
            // 
            // list3
            // 
            list3.AutoSizeTable = false;
            list3.BackColor = Color.FromArgb(255, 255, 255);
            list3.BorderStyle = BorderStyle.None;
            list3.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader10 });
            list3.Depth = 0;
            list3.Dock = DockStyle.Fill;
            list3.FullRowSelect = true;
            list3.Location = new Point(0, 0);
            list3.MinimumSize = new Size(200, 100);
            list3.MouseLocation = new Point(-1, -1);
            list3.MouseState = MaterialSkin.MouseState.OUT;
            list3.Name = "list3";
            list3.OwnerDraw = true;
            list3.Size = new Size(1387, 705);
            list3.TabIndex = 2;
            list3.UseCompatibleStateImageBehavior = false;
            list3.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Description";
            columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Category";
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Start Data";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "End Data";
            columnHeader5.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Status";
            columnHeader10.Width = 200;
            // 
            // Charts
            // 
            Charts.Controls.Add(btnOpen);
            Charts.Controls.Add(btnSave);
            Charts.Controls.Add(ButtonDocument);
            Charts.Controls.Add(chart1);
            Charts.ImageKey = "icons8-analytics-32.png";
            Charts.Location = new Point(4, 31);
            Charts.Name = "Charts";
            Charts.Size = new Size(1387, 705);
            Charts.TabIndex = 5;
            Charts.Text = "Charts";
            Charts.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOpen.Depth = 0;
            btnOpen.HighEmphasis = true;
            btnOpen.Icon = null;
            btnOpen.Location = new Point(1040, 327);
            btnOpen.Margin = new Padding(4, 6, 4, 6);
            btnOpen.MouseState = MaterialSkin.MouseState.HOVER;
            btnOpen.Name = "btnOpen";
            btnOpen.NoAccentTextColor = Color.Empty;
            btnOpen.Size = new Size(92, 36);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "OPEN FILE";
            btnOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOpen.UseAccentColor = false;
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(1042, 252);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(90, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE FILE";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ButtonDocument
            // 
            ButtonDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonDocument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonDocument.Depth = 0;
            ButtonDocument.HighEmphasis = true;
            ButtonDocument.Icon = null;
            ButtonDocument.Location = new Point(1008, 181);
            ButtonDocument.Margin = new Padding(4, 6, 4, 6);
            ButtonDocument.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonDocument.Name = "ButtonDocument";
            ButtonDocument.NoAccentTextColor = Color.Empty;
            ButtonDocument.Size = new Size(179, 36);
            ButtonDocument.TabIndex = 1;
            ButtonDocument.Text = "Generate Document";
            ButtonDocument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonDocument.UseAccentColor = false;
            ButtonDocument.UseVisualStyleBackColor = true;
            ButtonDocument.Click += ButtonDocument_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(35, 48);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Size = new Size(727, 375);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // Category
            // 
            Category.Controls.Add(btnCategory);
            Category.Controls.Add(listBox1);
            Category.Controls.Add(lbCat3);
            Category.Controls.Add(tbCat2);
            Category.Controls.Add(lbCat2);
            Category.ImageKey = "menu.png";
            Category.Location = new Point(4, 31);
            Category.Name = "Category";
            Category.Padding = new Padding(3);
            Category.Size = new Size(1387, 705);
            Category.TabIndex = 7;
            Category.Text = "Manage Category";
            Category.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCategory.Depth = 0;
            btnCategory.HighEmphasis = true;
            btnCategory.Icon = null;
            btnCategory.Location = new Point(246, 314);
            btnCategory.Margin = new Padding(4, 6, 4, 6);
            btnCategory.MouseState = MaterialSkin.MouseState.HOVER;
            btnCategory.Name = "btnCategory";
            btnCategory.NoAccentTextColor = Color.Empty;
            btnCategory.Size = new Size(64, 36);
            btnCategory.TabIndex = 5;
            btnCategory.Text = "OK";
            btnCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCategory.UseAccentColor = false;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderColor = Color.LightGray;
            listBox1.Depth = 0;
            listBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBox1.Location = new Point(734, 111);
            listBox1.MouseState = MaterialSkin.MouseState.HOVER;
            listBox1.Name = "listBox1";
            listBox1.SelectedIndex = -1;
            listBox1.SelectedItem = null;
            listBox1.Size = new Size(539, 296);
            listBox1.TabIndex = 4;
            // 
            // lbCat3
            // 
            lbCat3.AutoSize = true;
            lbCat3.Depth = 0;
            lbCat3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbCat3.Location = new Point(734, 56);
            lbCat3.MouseState = MaterialSkin.MouseState.HOVER;
            lbCat3.Name = "lbCat3";
            lbCat3.Size = new Size(134, 19);
            lbCat3.TabIndex = 3;
            lbCat3.Text = "Existing categories";
            // 
            // tbCat2
            // 
            tbCat2.AnimateReadOnly = false;
            tbCat2.BorderStyle = BorderStyle.None;
            tbCat2.Depth = 0;
            tbCat2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCat2.LeadingIcon = null;
            tbCat2.Location = new Point(73, 111);
            tbCat2.MaxLength = 50;
            tbCat2.MouseState = MaterialSkin.MouseState.OUT;
            tbCat2.Multiline = false;
            tbCat2.Name = "tbCat2";
            tbCat2.Size = new Size(576, 50);
            tbCat2.TabIndex = 2;
            tbCat2.Text = "";
            tbCat2.TrailingIcon = null;
            // 
            // lbCat2
            // 
            lbCat2.AutoSize = true;
            lbCat2.Depth = 0;
            lbCat2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbCat2.Location = new Point(73, 56);
            lbCat2.MouseState = MaterialSkin.MouseState.HOVER;
            lbCat2.Name = "lbCat2";
            lbCat2.Size = new Size(225, 19);
            lbCat2.TabIndex = 1;
            lbCat2.Text = "Do you want to add a category?";
            // 
            // Settings
            // 
            Settings.Controls.Add(LabelLanguage);
            Settings.Controls.Add(LabelTheme);
            Settings.Controls.Add(ComboBoxLanguage);
            Settings.Controls.Add(ComboBoxTheme);
            Settings.Controls.Add(SwitchMode);
            Settings.ImageKey = "icons8-settings-32.png";
            Settings.Location = new Point(4, 31);
            Settings.Name = "Settings";
            Settings.Size = new Size(1387, 705);
            Settings.TabIndex = 6;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            // 
            // LabelLanguage
            // 
            LabelLanguage.AutoSize = true;
            LabelLanguage.Depth = 0;
            LabelLanguage.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelLanguage.Location = new Point(80, 278);
            LabelLanguage.MouseState = MaterialSkin.MouseState.HOVER;
            LabelLanguage.Name = "LabelLanguage";
            LabelLanguage.Size = new Size(76, 19);
            LabelLanguage.TabIndex = 5;
            LabelLanguage.Text = "Language:";
            // 
            // LabelTheme
            // 
            LabelTheme.AutoSize = true;
            LabelTheme.Depth = 0;
            LabelTheme.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelTheme.Location = new Point(80, 191);
            LabelTheme.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTheme.Name = "LabelTheme";
            LabelTheme.Size = new Size(54, 19);
            LabelTheme.TabIndex = 4;
            LabelTheme.Text = "Theme:";
            // 
            // ComboBoxLanguage
            // 
            ComboBoxLanguage.AutoResize = false;
            ComboBoxLanguage.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxLanguage.Depth = 0;
            ComboBoxLanguage.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxLanguage.DropDownHeight = 174;
            ComboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLanguage.DropDownWidth = 121;
            ComboBoxLanguage.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxLanguage.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxLanguage.FormattingEnabled = true;
            ComboBoxLanguage.IntegralHeight = false;
            ComboBoxLanguage.ItemHeight = 43;
            ComboBoxLanguage.Location = new Point(218, 265);
            ComboBoxLanguage.MaxDropDownItems = 4;
            ComboBoxLanguage.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxLanguage.Name = "ComboBoxLanguage";
            ComboBoxLanguage.Size = new Size(151, 49);
            ComboBoxLanguage.StartIndex = 0;
            ComboBoxLanguage.TabIndex = 3;
            // 
            // ComboBoxTheme
            // 
            ComboBoxTheme.AutoResize = false;
            ComboBoxTheme.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxTheme.Depth = 0;
            ComboBoxTheme.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxTheme.DropDownHeight = 174;
            ComboBoxTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTheme.DropDownWidth = 121;
            ComboBoxTheme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxTheme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxTheme.FormattingEnabled = true;
            ComboBoxTheme.IntegralHeight = false;
            ComboBoxTheme.ItemHeight = 43;
            ComboBoxTheme.Location = new Point(218, 171);
            ComboBoxTheme.MaxDropDownItems = 4;
            ComboBoxTheme.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxTheme.Name = "ComboBoxTheme";
            ComboBoxTheme.Size = new Size(371, 49);
            ComboBoxTheme.StartIndex = 0;
            ComboBoxTheme.TabIndex = 2;
            ComboBoxTheme.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // SwitchMode
            // 
            SwitchMode.AutoSize = true;
            SwitchMode.Depth = 0;
            SwitchMode.Location = new Point(80, 72);
            SwitchMode.Margin = new Padding(0);
            SwitchMode.MouseLocation = new Point(-1, -1);
            SwitchMode.MouseState = MaterialSkin.MouseState.HOVER;
            SwitchMode.Name = "SwitchMode";
            SwitchMode.Ripple = true;
            SwitchMode.Size = new Size(135, 37);
            SwitchMode.TabIndex = 0;
            SwitchMode.Text = "Dark Mode";
            SwitchMode.UseVisualStyleBackColor = true;
            SwitchMode.CheckedChanged += materialSwitch1_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-menu-32.png");
            imageList1.Images.SetKeyName(1, "icons8-user-32.png");
            imageList1.Images.SetKeyName(2, "icons8-calendar-32.png");
            imageList1.Images.SetKeyName(3, "icons8-pending-32.png");
            imageList1.Images.SetKeyName(4, "icons8-complete-32.png");
            imageList1.Images.SetKeyName(5, "icons8-analytics-32.png");
            imageList1.Images.SetKeyName(6, "icons8-goal-24.png");
            imageList1.Images.SetKeyName(7, "icons8-settings-32.png");
            imageList1.Images.SetKeyName(8, "menu.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 807);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "Form1";
            Text = "To do";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            All.ResumeLayout(false);
            All.PerformLayout();
            Pending.ResumeLayout(false);
            Complete.ResumeLayout(false);
            Charts.ResumeLayout(false);
            Charts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            Category.ResumeLayout(false);
            Category.PerformLayout();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private ImageList imageList1;
        private TabPage All;
        private TabPage Pending;
        private TabPage Complete;
        private TabPage Charts;
        private TabPage Settings;
        private MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialSlider materialSlider2;
        private MaterialSkin.Controls.MaterialSlider materialSlider3;
        private MaterialSkin.Controls.MaterialSlider materialSlider4;
        private MaterialSkin.Controls.MaterialSlider materialSlider5;
        private MaterialSkin.Controls.MaterialSwitch SwitchMode;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxTheme;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxLanguage;
        private MaterialSkin.Controls.MaterialLabel LabelLanguage;
        private MaterialSkin.Controls.MaterialLabel LabelTheme;
        private MaterialSkin.Controls.MaterialButton ButtonAddTask;
        private MaterialSkin.Controls.MaterialButton ButtonAddQ;
        private TabPage Category;
        private TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialButton ButtonDocument;
        private MaterialSkin.Controls.MaterialLabel lbUser;
        private MaterialSkin.Controls.MaterialTextBox tbPhone;
        private MaterialSkin.Controls.MaterialTextBox tbEmail;
        private MaterialSkin.Controls.MaterialTextBox tbName;
        private MaterialSkin.Controls.MaterialLabel lbPhone;
        private MaterialSkin.Controls.MaterialLabel lbEmail;
        private MaterialSkin.Controls.MaterialLabel lbName;
        private MaterialSkin.Controls.MaterialButton btUpdateDataUser;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton6;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton5;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton4;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton9;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton19;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton18;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton17;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton16;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton15;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton14;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton13;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton12;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton11;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton10;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton8;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton7;
        private MaterialSkin.Controls.MaterialComboBox cbCategory2;
        private MaterialSkin.Controls.MaterialListView list1;
        private ColumnHeader c1;
        private ColumnHeader c2;
        private ColumnHeader c3;
        private ColumnHeader c4;
        private MaterialSkin.Controls.MaterialLabel lbCat3;
        private MaterialSkin.Controls.MaterialTextBox tbCat2;
        private MaterialSkin.Controls.MaterialLabel lbCat2;
        private ColumnHeader c5;
        private MaterialSkin.Controls.MaterialListView list2;
        private ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialListView list3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader10;
        private MaterialSkin.Controls.MaterialListBox listBox1;
        private MaterialSkin.Controls.MaterialButton btnCategory;
        private MaterialSkin.Controls.MaterialButton btnOpen;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}
