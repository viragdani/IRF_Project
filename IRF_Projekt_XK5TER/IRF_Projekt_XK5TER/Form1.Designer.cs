namespace IRF_Projekt_XK5TER
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btnDistribution = new System.Windows.Forms.Button();
            this.btnCorrelation = new System.Windows.Forms.Button();
            this.btnUnknown = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.btnCalculator);
            this.panelSideMenu.Controls.Add(this.panelDropDown);
            this.panelSideMenu.Controls.Add(this.btnStatistics);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 522);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Location = new System.Drawing.Point(0, 100);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(200, 50);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Statisztika";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.DimGray;
            this.panelDropDown.Controls.Add(this.btnUnknown);
            this.panelDropDown.Controls.Add(this.btnCorrelation);
            this.panelDropDown.Controls.Add(this.btnDistribution);
            this.panelDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropDown.Location = new System.Drawing.Point(0, 150);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(200, 135);
            this.panelDropDown.TabIndex = 2;
            this.panelDropDown.Visible = false;
            // 
            // btnDistribution
            // 
            this.btnDistribution.BackColor = System.Drawing.Color.Silver;
            this.btnDistribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDistribution.FlatAppearance.BorderSize = 0;
            this.btnDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribution.Location = new System.Drawing.Point(0, 0);
            this.btnDistribution.Name = "btnDistribution";
            this.btnDistribution.Size = new System.Drawing.Size(200, 45);
            this.btnDistribution.TabIndex = 0;
            this.btnDistribution.Text = "Megoszlás";
            this.btnDistribution.UseVisualStyleBackColor = false;
            this.btnDistribution.Click += new System.EventHandler(this.btnDistribution_Click);
            // 
            // btnCorrelation
            // 
            this.btnCorrelation.BackColor = System.Drawing.Color.Silver;
            this.btnCorrelation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCorrelation.FlatAppearance.BorderSize = 0;
            this.btnCorrelation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrelation.Location = new System.Drawing.Point(0, 45);
            this.btnCorrelation.Name = "btnCorrelation";
            this.btnCorrelation.Size = new System.Drawing.Size(200, 45);
            this.btnCorrelation.TabIndex = 1;
            this.btnCorrelation.Text = "Korreláció";
            this.btnCorrelation.UseVisualStyleBackColor = false;
            this.btnCorrelation.Click += new System.EventHandler(this.btnCorrelation_Click);
            // 
            // btnUnknown
            // 
            this.btnUnknown.BackColor = System.Drawing.Color.Silver;
            this.btnUnknown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnknown.FlatAppearance.BorderSize = 0;
            this.btnUnknown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnknown.Location = new System.Drawing.Point(0, 90);
            this.btnUnknown.Name = "btnUnknown";
            this.btnUnknown.Size = new System.Drawing.Size(200, 45);
            this.btnUnknown.TabIndex = 2;
            this.btnUnknown.Text = "Unknown";
            this.btnUnknown.UseVisualStyleBackColor = false;
            this.btnUnknown.Click += new System.EventHandler(this.btnUnknown_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Location = new System.Drawing.Point(0, 285);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(200, 50);
            this.btnCalculator.TabIndex = 3;
            this.btnCalculator.Text = "Értékkalkulátor";
            this.btnCalculator.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(0, 335);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(200, 50);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Segítség";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 522);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btnUnknown;
        private System.Windows.Forms.Button btnCorrelation;
        private System.Windows.Forms.Button btnDistribution;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCalculator;
    }
}

