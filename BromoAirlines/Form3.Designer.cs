namespace BromoAirlines
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterBandaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materMaskapaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenerbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMaskapaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenebanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 73);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BromoAirlines.Properties.Resources.menu_alt_72;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(1, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 381);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterBandaraToolStripMenuItem,
            this.masterMaskapaiToolStripMenuItem,
            this.masterJadwalPenebanganToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem1,
            this.ubahStatusPenerbanganToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(181, 381);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterBandaraToolStripMenuItem
            // 
            this.masterBandaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materMaskapaiToolStripMenuItem,
            this.masterJadwalPenerbaToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem,
            this.ubahStatusPenerbanganToolStripMenuItem});
            this.masterBandaraToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.map_unselected_722;
            this.masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            this.masterBandaraToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.masterBandaraToolStripMenuItem.Text = "Master Bandara";
            this.masterBandaraToolStripMenuItem.Click += new System.EventHandler(this.masterBandaraToolStripMenuItem_Click_2);
            // 
            // materMaskapaiToolStripMenuItem
            // 
            this.materMaskapaiToolStripMenuItem.Name = "materMaskapaiToolStripMenuItem";
            this.materMaskapaiToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.materMaskapaiToolStripMenuItem.Text = "Mater Maskapai";
            // 
            // masterJadwalPenerbaToolStripMenuItem
            // 
            this.masterJadwalPenerbaToolStripMenuItem.Name = "masterJadwalPenerbaToolStripMenuItem";
            this.masterJadwalPenerbaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.masterJadwalPenerbaToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            // 
            // masterKodePromoToolStripMenuItem
            // 
            this.masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            this.masterKodePromoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            this.ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            this.ubahStatusPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            // 
            // masterMaskapaiToolStripMenuItem
            // 
            this.masterMaskapaiToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.pesawat;
            this.masterMaskapaiToolStripMenuItem.Name = "masterMaskapaiToolStripMenuItem";
            this.masterMaskapaiToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.masterMaskapaiToolStripMenuItem.Text = "Master Maskapai";
            // 
            // masterJadwalPenebanganToolStripMenuItem
            // 
            this.masterJadwalPenebanganToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.calendar_;
            this.masterJadwalPenebanganToolStripMenuItem.Name = "masterJadwalPenebanganToolStripMenuItem";
            this.masterJadwalPenebanganToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.masterJadwalPenebanganToolStripMenuItem.Text = "Master Jadwal Penebangan";
            // 
            // masterKodePromoToolStripMenuItem1
            // 
            this.masterKodePromoToolStripMenuItem1.Image = global::BromoAirlines.Properties.Resources.purchase_tag_alt_unselected_721;
            this.masterKodePromoToolStripMenuItem1.Name = "masterKodePromoToolStripMenuItem1";
            this.masterKodePromoToolStripMenuItem1.Size = new System.Drawing.Size(174, 20);
            this.masterKodePromoToolStripMenuItem1.Text = "Master Kode Promo";
            // 
            // ubahStatusPenerbanganToolStripMenuItem1
            // 
            this.ubahStatusPenerbanganToolStripMenuItem1.Image = global::BromoAirlines.Properties.Resources.notepad_unselected_721;
            this.ubahStatusPenerbanganToolStripMenuItem1.Name = "ubahStatusPenerbanganToolStripMenuItem1";
            this.ubahStatusPenerbanganToolStripMenuItem1.Size = new System.Drawing.Size(174, 20);
            this.ubahStatusPenerbanganToolStripMenuItem1.Text = "Ubah Status Penerbangan";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterBandaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materMaskapaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenerbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMaskapaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenebanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem1;
    }
}