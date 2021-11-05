
namespace cafeteriaMS
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.groupHome = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupNav = new System.Windows.Forms.GroupBox();
            this.linkLblHome = new System.Windows.Forms.LinkLabel();
            this.linkLblOrder = new System.Windows.Forms.LinkLabel();
            this.linkLblMenu = new System.Windows.Forms.LinkLabel();
            this.linkLblAccount = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupNav.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupHome
            // 
            this.groupHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupHome.Controls.Add(this.groupNav);
            this.groupHome.Controls.Add(this.groupBox1);
            this.groupHome.Location = new System.Drawing.Point(51, 12);
            this.groupHome.Name = "groupHome";
            this.groupHome.Size = new System.Drawing.Size(941, 526);
            this.groupHome.TabIndex = 0;
            this.groupHome.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(29, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(121, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to\r\nManoCafe!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(443, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupNav
            // 
            this.groupNav.Controls.Add(this.linkLblAccount);
            this.groupNav.Controls.Add(this.linkLblMenu);
            this.groupNav.Controls.Add(this.linkLblOrder);
            this.groupNav.Controls.Add(this.pictureLogo);
            this.groupNav.Controls.Add(this.linkLblHome);
            this.groupNav.Location = new System.Drawing.Point(29, 12);
            this.groupNav.Name = "groupNav";
            this.groupNav.Size = new System.Drawing.Size(887, 90);
            this.groupNav.TabIndex = 2;
            this.groupNav.TabStop = false;
            // 
            // linkLblHome
            // 
            this.linkLblHome.AutoSize = true;
            this.linkLblHome.BackColor = System.Drawing.Color.White;
            this.linkLblHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblHome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLblHome.Location = new System.Drawing.Point(466, 37);
            this.linkLblHome.Name = "linkLblHome";
            this.linkLblHome.Size = new System.Drawing.Size(68, 26);
            this.linkLblHome.TabIndex = 0;
            this.linkLblHome.TabStop = true;
            this.linkLblHome.Text = "Home";
            this.linkLblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHome_LinkClicked);
            // 
            // linkLblOrder
            // 
            this.linkLblOrder.AutoSize = true;
            this.linkLblOrder.BackColor = System.Drawing.Color.White;
            this.linkLblOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblOrder.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLblOrder.Location = new System.Drawing.Point(572, 37);
            this.linkLblOrder.Name = "linkLblOrder";
            this.linkLblOrder.Size = new System.Drawing.Size(66, 26);
            this.linkLblOrder.TabIndex = 2;
            this.linkLblOrder.TabStop = true;
            this.linkLblOrder.Text = "Order";
            this.linkLblOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblOrder_LinkClicked);
            // 
            // linkLblMenu
            // 
            this.linkLblMenu.AutoSize = true;
            this.linkLblMenu.BackColor = System.Drawing.Color.White;
            this.linkLblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblMenu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLblMenu.Location = new System.Drawing.Point(670, 37);
            this.linkLblMenu.Name = "linkLblMenu";
            this.linkLblMenu.Size = new System.Drawing.Size(65, 26);
            this.linkLblMenu.TabIndex = 3;
            this.linkLblMenu.TabStop = true;
            this.linkLblMenu.Text = "Menu";
            this.linkLblMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblMenu_LinkClicked);
            // 
            // linkLblAccount
            // 
            this.linkLblAccount.AutoSize = true;
            this.linkLblAccount.BackColor = System.Drawing.Color.MistyRose;
            this.linkLblAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblAccount.LinkColor = System.Drawing.Color.Blue;
            this.linkLblAccount.Location = new System.Drawing.Point(770, 37);
            this.linkLblAccount.Name = "linkLblAccount";
            this.linkLblAccount.Size = new System.Drawing.Size(89, 26);
            this.linkLblAccount.TabIndex = 4;
            this.linkLblAccount.TabStop = true;
            this.linkLblAccount.Text = "Account";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::cafeteriaMS.Properties.Resources.logo;
            this.pictureLogo.InitialImage = null;
            this.pictureLogo.Location = new System.Drawing.Point(6, 11);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(119, 71);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 540);
            this.Controls.Add(this.groupHome);
            this.Name = "formHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupHome.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupNav.ResumeLayout(false);
            this.groupNav.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupNav;
        private System.Windows.Forms.LinkLabel linkLblAccount;
        private System.Windows.Forms.LinkLabel linkLblMenu;
        private System.Windows.Forms.LinkLabel linkLblOrder;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.LinkLabel linkLblHome;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}