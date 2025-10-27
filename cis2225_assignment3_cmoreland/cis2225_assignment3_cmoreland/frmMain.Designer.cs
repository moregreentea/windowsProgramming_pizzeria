namespace cis2225_assignment3_cmoreland
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.grpSauce = new System.Windows.Forms.GroupBox();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoSpicy = new System.Windows.Forms.RadioButton();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstOrderSummary = new System.Windows.Forms.ListBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpSauce.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.pbMainLogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(249, 69);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(37, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "lblTitle";
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.BackgroundImage = global::cis2225_assignment3_cmoreland.Properties.Resources.pizzaBackground;
            this.pbMainLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMainLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainLogo.Location = new System.Drawing.Point(3, 3);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(542, 418);
            this.pbMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainLogo.TabIndex = 0;
            this.pbMainLogo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpSize);
            this.tabPage2.Controls.Add(this.clbToppings);
            this.tabPage2.Controls.Add(this.grpSauce);
            this.tabPage2.Controls.Add(this.btnAddToOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pizza";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdoLarge);
            this.grpSize.Controls.Add(this.rdoSmall);
            this.grpSize.Controls.Add(this.rdoMedium);
            this.grpSize.Location = new System.Drawing.Point(173, 42);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(200, 84);
            this.grpSize.TabIndex = 3;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "grpSize";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(6, 61);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(67, 17);
            this.rdoLarge.TabIndex = 6;
            this.rdoLarge.Text = "rdoLarge";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(6, 19);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(65, 17);
            this.rdoSmall.TabIndex = 4;
            this.rdoSmall.Text = "rdoSmall";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Checked = true;
            this.rdoMedium.Location = new System.Drawing.Point(6, 41);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(77, 17);
            this.rdoMedium.TabIndex = 5;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "rdoMedium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // clbToppings
            // 
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Location = new System.Drawing.Point(173, 201);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(200, 124);
            this.clbToppings.TabIndex = 2;
            // 
            // grpSauce
            // 
            this.grpSauce.Controls.Add(this.rdoRegular);
            this.grpSauce.Controls.Add(this.rdoSpicy);
            this.grpSauce.Location = new System.Drawing.Point(173, 132);
            this.grpSauce.Name = "grpSauce";
            this.grpSauce.Size = new System.Drawing.Size(200, 63);
            this.grpSauce.TabIndex = 1;
            this.grpSauce.TabStop = false;
            this.grpSauce.Text = "grpSauce";
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Checked = true;
            this.rdoRegular.Location = new System.Drawing.Point(6, 19);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(77, 17);
            this.rdoRegular.TabIndex = 2;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "rdoRegular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoSpicy
            // 
            this.rdoSpicy.AutoSize = true;
            this.rdoSpicy.Location = new System.Drawing.Point(6, 42);
            this.rdoSpicy.Name = "rdoSpicy";
            this.rdoSpicy.Size = new System.Drawing.Size(66, 17);
            this.rdoSpicy.TabIndex = 3;
            this.rdoSpicy.Text = "rdoSpicy";
            this.rdoSpicy.UseVisualStyleBackColor = true;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(234, 331);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddToOrder.TabIndex = 0;
            this.btnAddToOrder.Text = "btnAddToOrder";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalCost);
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.lstOrderSummary);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(548, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Summary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(231, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstOrderSummary
            // 
            this.lstOrderSummary.FormattingEnabled = true;
            this.lstOrderSummary.Location = new System.Drawing.Point(29, 82);
            this.lstOrderSummary.Name = "lstOrderSummary";
            this.lstOrderSummary.Size = new System.Drawing.Size(493, 147);
            this.lstOrderSummary.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(228, 248);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Pizza Ordering Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpSauce.ResumeLayout(false);
            this.grpSauce.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pbMainLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.GroupBox grpSauce;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.RadioButton rdoSpicy;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOrderSummary;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

