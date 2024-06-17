namespace ToDoListProject
{
    partial class Form3
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
            lbDescription = new MaterialSkin.Controls.MaterialLabel();
            lbCategory = new MaterialSkin.Controls.MaterialLabel();
            lbStartDate = new MaterialSkin.Controls.MaterialLabel();
            lbEndData = new MaterialSkin.Controls.MaterialLabel();
            btnAddTaskOk = new MaterialSkin.Controls.MaterialButton();
            btnAddTaskCancel = new MaterialSkin.Controls.MaterialButton();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            slStatus = new MaterialSkin.Controls.MaterialSlider();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Depth = 0;
            lbDescription.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbDescription.Location = new Point(60, 94);
            lbDescription.MouseState = MaterialSkin.MouseState.HOVER;
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(81, 19);
            lbDescription.TabIndex = 0;
            lbDescription.Text = "Description";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Depth = 0;
            lbCategory.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbCategory.Location = new Point(62, 152);
            lbCategory.MouseState = MaterialSkin.MouseState.HOVER;
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(64, 19);
            lbCategory.TabIndex = 1;
            lbCategory.Text = "Category";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Depth = 0;
            lbStartDate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbStartDate.Location = new Point(60, 206);
            lbStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(73, 19);
            lbStartDate.TabIndex = 2;
            lbStartDate.Text = "Start Data";
            // 
            // lbEndData
            // 
            lbEndData.AutoSize = true;
            lbEndData.Depth = 0;
            lbEndData.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbEndData.Location = new Point(60, 252);
            lbEndData.MouseState = MaterialSkin.MouseState.HOVER;
            lbEndData.Name = "lbEndData";
            lbEndData.Size = new Size(66, 19);
            lbEndData.TabIndex = 3;
            lbEndData.Text = "End Data";
            // 
            // btnAddTaskOk
            // 
            btnAddTaskOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddTaskOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddTaskOk.Depth = 0;
            btnAddTaskOk.DialogResult = DialogResult.OK;
            btnAddTaskOk.HighEmphasis = true;
            btnAddTaskOk.Icon = null;
            btnAddTaskOk.Location = new Point(106, 405);
            btnAddTaskOk.Margin = new Padding(4, 6, 4, 6);
            btnAddTaskOk.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddTaskOk.Name = "btnAddTaskOk";
            btnAddTaskOk.NoAccentTextColor = Color.Empty;
            btnAddTaskOk.Size = new Size(64, 36);
            btnAddTaskOk.TabIndex = 5;
            btnAddTaskOk.Text = "OK";
            btnAddTaskOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddTaskOk.UseAccentColor = false;
            btnAddTaskOk.UseVisualStyleBackColor = true;
            btnAddTaskOk.Click += btnAddTaskOk_Click;
            // 
            // btnAddTaskCancel
            // 
            btnAddTaskCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddTaskCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddTaskCancel.Depth = 0;
            btnAddTaskCancel.DialogResult = DialogResult.Cancel;
            btnAddTaskCancel.HighEmphasis = true;
            btnAddTaskCancel.Icon = null;
            btnAddTaskCancel.Location = new Point(361, 405);
            btnAddTaskCancel.Margin = new Padding(4, 6, 4, 6);
            btnAddTaskCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddTaskCancel.Name = "btnAddTaskCancel";
            btnAddTaskCancel.NoAccentTextColor = Color.Empty;
            btnAddTaskCancel.Size = new Size(77, 36);
            btnAddTaskCancel.TabIndex = 6;
            btnAddTaskCancel.Text = "CANCEL";
            btnAddTaskCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddTaskCancel.UseAccentColor = false;
            btnAddTaskCancel.UseVisualStyleBackColor = true;
            btnAddTaskCancel.Click += btnAddTaskCancel_Click;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(182, 81);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(533, 50);
            materialTextBox1.TabIndex = 7;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 198);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(182, 244);
            dateTimePicker2.MinDate = new DateTime(2024, 5, 26, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 10;
            // 
            // slStatus
            // 
            slStatus.Depth = 0;
            slStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            slStatus.Location = new Point(75, 295);
            slStatus.MouseState = MaterialSkin.MouseState.HOVER;
            slStatus.Name = "slStatus";
            slStatus.RangeMax = 1;
            slStatus.Size = new Size(312, 40);
            slStatus.TabIndex = 11;
            slStatus.Text = "Status";
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(182, 142);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(533, 50);
            materialTextBox2.TabIndex = 12;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTextBox2);
            Controls.Add(slStatus);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(materialTextBox1);
            Controls.Add(btnAddTaskCancel);
            Controls.Add(btnAddTaskOk);
            Controls.Add(lbEndData);
            Controls.Add(lbStartDate);
            Controls.Add(lbCategory);
            Controls.Add(lbDescription);
            Name = "Form3";
            Text = "Add task";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbDescription;
        private MaterialSkin.Controls.MaterialLabel lbCategory;
        private MaterialSkin.Controls.MaterialLabel lbStartDate;
        private MaterialSkin.Controls.MaterialLabel lbEndData;
        private MaterialSkin.Controls.MaterialButton btnAddTaskOk;
        private MaterialSkin.Controls.MaterialButton btnAddTaskCancel;
        public MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        public DateTimePicker dateTimePicker1;
        public DateTimePicker dateTimePicker2;
        public MaterialSkin.Controls.MaterialSlider slStatus;
        public MaterialSkin.Controls.MaterialTextBox materialTextBox2;
    }
}