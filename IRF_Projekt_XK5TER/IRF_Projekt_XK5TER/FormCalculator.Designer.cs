namespace IRF_Projekt_XK5TER
{
    partial class FormCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelEngV = new System.Windows.Forms.Label();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.comboBoxEngV = new System.Windows.Forms.ComboBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValueUSD = new System.Windows.Forms.Label();
            this.labelValueFT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérjük, adja meg az autó adatait!";
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(33, 60);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(40, 13);
            this.labelMake.TabIndex = 1;
            this.labelMake.Text = "Márka:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(33, 88);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(41, 13);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Modell:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(33, 118);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(43, 13);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Évjárat:";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(33, 145);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(66, 13);
            this.labelFuel.TabIndex = 4;
            this.labelFuel.Text = "Üzemanyag:";
            // 
            // labelEngV
            // 
            this.labelEngV.AutoSize = true;
            this.labelEngV.Location = new System.Drawing.Point(33, 174);
            this.labelEngV.Name = "labelEngV";
            this.labelEngV.Size = new System.Drawing.Size(82, 13);
            this.labelEngV.TabIndex = 5;
            this.labelEngV.Text = "Motor térfogata:";
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Location = new System.Drawing.Point(121, 58);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMake.TabIndex = 6;
            this.comboBoxMake.SelectedIndexChanged += new System.EventHandler(this.comboBoxMake_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(121, 85);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModel.TabIndex = 7;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(121, 115);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 8;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(121, 142);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFuel.TabIndex = 9;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuel_SelectedIndexChanged);
            // 
            // comboBoxEngV
            // 
            this.comboBoxEngV.FormattingEnabled = true;
            this.comboBoxEngV.Location = new System.Drawing.Point(121, 169);
            this.comboBoxEngV.Name = "comboBoxEngV";
            this.comboBoxEngV.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEngV.TabIndex = 10;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(121, 217);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 11;
            this.buttonCalc.Text = "Számítás";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(277, 280);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(33, 13);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = "Label";
            this.labelCount.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasonló autók száma az adatbázisban:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Becsült érték:";
            this.label3.Visible = false;
            // 
            // labelValueUSD
            // 
            this.labelValueUSD.AutoSize = true;
            this.labelValueUSD.Location = new System.Drawing.Point(277, 315);
            this.labelValueUSD.Name = "labelValueUSD";
            this.labelValueUSD.Size = new System.Drawing.Size(33, 13);
            this.labelValueUSD.TabIndex = 15;
            this.labelValueUSD.Text = "Label";
            this.labelValueUSD.Visible = false;
            // 
            // labelValueFT
            // 
            this.labelValueFT.AutoSize = true;
            this.labelValueFT.Location = new System.Drawing.Point(277, 339);
            this.labelValueFT.Name = "labelValueFT";
            this.labelValueFT.Size = new System.Drawing.Size(33, 13);
            this.labelValueFT.TabIndex = 16;
            this.labelValueFT.Text = "Label";
            this.labelValueFT.Visible = false;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValueFT);
            this.Controls.Add(this.labelValueUSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.comboBoxEngV);
            this.Controls.Add(this.comboBoxFuel);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxMake);
            this.Controls.Add(this.labelEngV);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.label1);
            this.Name = "FormCalculator";
            this.Text = "FormCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelEngV;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.ComboBox comboBoxEngV;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValueUSD;
        private System.Windows.Forms.Label labelValueFT;
    }
}