namespace TicketReservation_System
{
    partial class ManagerYearSale
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
            this.Spanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spanel
            // 
            this.Spanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Spanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Spanel.Location = new System.Drawing.Point(718, 0);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(178, 546);
            this.Spanel.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::TicketReservation_System.Properties.Resources.redgradient;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(896, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(31, 546);
            this.panel4.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.BackgroundImage = global::TicketReservation_System.Properties.Resources.redgradient;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(6, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 493);
            this.button2.TabIndex = 0;
            this.button2.Text = "HIDE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManagerYearSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 546);
            this.Controls.Add(this.Spanel);
            this.Controls.Add(this.panel4);
            this.Name = "ManagerYearSale";
            this.Text = "ManagerYearSale";
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}