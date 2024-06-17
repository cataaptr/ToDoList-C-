namespace ToDoListProject
{
    partial class Form2
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
            lbN = new MaterialSkin.Controls.MaterialLabel();
            lbE = new MaterialSkin.Controls.MaterialLabel();
            lbP = new MaterialSkin.Controls.MaterialLabel();
            tbN = new MaterialSkin.Controls.MaterialTextBox();
            tbE = new MaterialSkin.Controls.MaterialTextBox();
            tbP = new MaterialSkin.Controls.MaterialTextBox();
            btnCancel1 = new MaterialSkin.Controls.MaterialButton();
            btOk1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Depth = 0;
            lbN.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbN.Location = new Point(81, 148);
            lbN.MouseState = MaterialSkin.MouseState.HOVER;
            lbN.Name = "lbN";
            lbN.Size = new Size(43, 19);
            lbN.TabIndex = 0;
            lbN.Text = "Name";
            // 
            // lbE
            // 
            lbE.AutoSize = true;
            lbE.Depth = 0;
            lbE.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbE.Location = new Point(81, 218);
            lbE.MouseState = MaterialSkin.MouseState.HOVER;
            lbE.Name = "lbE";
            lbE.Size = new Size(41, 19);
            lbE.TabIndex = 1;
            lbE.Text = "Email";
            // 
            // lbP
            // 
            lbP.AutoSize = true;
            lbP.Depth = 0;
            lbP.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbP.Location = new Point(81, 301);
            lbP.MouseState = MaterialSkin.MouseState.HOVER;
            lbP.Name = "lbP";
            lbP.Size = new Size(46, 19);
            lbP.TabIndex = 2;
            lbP.Text = "Phone";
            // 
            // tbN
            // 
            tbN.AnimateReadOnly = false;
            tbN.BorderStyle = BorderStyle.None;
            tbN.Depth = 0;
            tbN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbN.LeadingIcon = null;
            tbN.Location = new Point(216, 130);
            tbN.MaxLength = 50;
            tbN.MouseState = MaterialSkin.MouseState.OUT;
            tbN.Multiline = false;
            tbN.Name = "tbN";
            tbN.Size = new Size(342, 50);
            tbN.TabIndex = 3;
            tbN.Text = "";
            tbN.TrailingIcon = null;
            // 
            // tbE
            // 
            tbE.AnimateReadOnly = false;
            tbE.BorderStyle = BorderStyle.None;
            tbE.Depth = 0;
            tbE.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbE.LeadingIcon = null;
            tbE.Location = new Point(216, 205);
            tbE.MaxLength = 50;
            tbE.MouseState = MaterialSkin.MouseState.OUT;
            tbE.Multiline = false;
            tbE.Name = "tbE";
            tbE.Size = new Size(342, 50);
            tbE.TabIndex = 4;
            tbE.Text = "";
            tbE.TrailingIcon = null;
            // 
            // tbP
            // 
            tbP.AnimateReadOnly = false;
            tbP.BorderStyle = BorderStyle.None;
            tbP.Depth = 0;
            tbP.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbP.LeadingIcon = null;
            tbP.Location = new Point(216, 288);
            tbP.MaxLength = 50;
            tbP.MouseState = MaterialSkin.MouseState.OUT;
            tbP.Multiline = false;
            tbP.Name = "tbP";
            tbP.Size = new Size(342, 50);
            tbP.TabIndex = 5;
            tbP.Text = "";
            tbP.TrailingIcon = null;
            // 
            // btnCancel1
            // 
            btnCancel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel1.Depth = 0;
            btnCancel1.DialogResult = DialogResult.Cancel;
            btnCancel1.HighEmphasis = true;
            btnCancel1.Icon = null;
            btnCancel1.Location = new Point(443, 380);
            btnCancel1.Margin = new Padding(4, 6, 4, 6);
            btnCancel1.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel1.Name = "btnCancel1";
            btnCancel1.NoAccentTextColor = Color.Empty;
            btnCancel1.Size = new Size(77, 36);
            btnCancel1.TabIndex = 6;
            btnCancel1.Text = "CANCEL";
            btnCancel1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel1.UseAccentColor = false;
            btnCancel1.UseVisualStyleBackColor = true;
            // 
            // btOk1
            // 
            btOk1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btOk1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btOk1.Depth = 0;
            btOk1.DialogResult = DialogResult.OK;
            btOk1.HighEmphasis = true;
            btOk1.Icon = null;
            btOk1.Location = new Point(166, 380);
            btOk1.Margin = new Padding(4, 6, 4, 6);
            btOk1.MouseState = MaterialSkin.MouseState.HOVER;
            btOk1.Name = "btOk1";
            btOk1.NoAccentTextColor = Color.Empty;
            btOk1.Size = new Size(64, 36);
            btOk1.TabIndex = 7;
            btOk1.Text = "OK";
            btOk1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btOk1.UseAccentColor = false;
            btOk1.UseVisualStyleBackColor = true;
            btOk1.Click += btOk1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btOk1);
            Controls.Add(btnCancel1);
            Controls.Add(tbP);
            Controls.Add(tbE);
            Controls.Add(tbN);
            Controls.Add(lbP);
            Controls.Add(lbE);
            Controls.Add(lbN);
            Name = "Form2";
            Text = "Update Data User";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbN;
        private MaterialSkin.Controls.MaterialLabel lbE;
        private MaterialSkin.Controls.MaterialLabel lbP;
        private MaterialSkin.Controls.MaterialButton btnCancel1;
        private MaterialSkin.Controls.MaterialButton btOk1;
        public MaterialSkin.Controls.MaterialTextBox tbN;
        public MaterialSkin.Controls.MaterialTextBox tbE;
        public MaterialSkin.Controls.MaterialTextBox tbP;
    }
}