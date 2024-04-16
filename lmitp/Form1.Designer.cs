namespace lmitp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelside = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btndashbaord = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnreports = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelside.Controls.Add(this.btnreports);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.btnemp);
            this.panelside.Controls.Add(this.btndashbaord);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 43);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 407);
            this.panelside.TabIndex = 0;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 43);
            this.panelheader.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(767, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 30);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 43);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(600, 407);
            this.mainpanel.TabIndex = 2;
            // 
            // btndashbaord
            // 
            this.btndashbaord.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btndashbaord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndashbaord.FlatAppearance.BorderSize = 0;
            this.btndashbaord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashbaord.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbaord.ForeColor = System.Drawing.Color.White;
            this.btndashbaord.Image = ((System.Drawing.Image)(resources.GetObject("btndashbaord.Image")));
            this.btndashbaord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashbaord.Location = new System.Drawing.Point(6, 183);
            this.btndashbaord.Name = "btndashbaord";
            this.btndashbaord.Size = new System.Drawing.Size(188, 52);
            this.btndashbaord.TabIndex = 0;
            this.btndashbaord.Text = "BEGINNER LEVEL";
            this.btndashbaord.UseVisualStyleBackColor = false;
            this.btndashbaord.Click += new System.EventHandler(this.btndashbaord_Click);
            // 
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.ForeColor = System.Drawing.Color.White;
            this.btnemp.Image = ((System.Drawing.Image)(resources.GetObject("btnemp.Image")));
            this.btnemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemp.Location = new System.Drawing.Point(6, 241);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(188, 55);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "INTERMIDIATE LEVEL";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreports.FlatAppearance.BorderSize = 0;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreports.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.ForeColor = System.Drawing.Color.White;
            this.btnreports.Image = global::lmitp.Properties.Resources.report_card_24px;
            this.btnreports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.Location = new System.Drawing.Point(6, 302);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(188, 53);
            this.btnreports.TabIndex = 2;
            this.btnreports.Text = "PROGRAMMER LEVEL";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btndashbaord;
    }
}

