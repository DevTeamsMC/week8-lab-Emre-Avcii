namespace _152120231042_152120221098_Grup_14_OOP_2_Exp6b
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
            this.buttonBasla = new System.Windows.Forms.Button();
            this.labelHangman = new System.Windows.Forms.Label();
            this.buttonAyarlar = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBasla
            // 
            this.buttonBasla.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(316, 208);
            this.buttonBasla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(231, 55);
            this.buttonBasla.TabIndex = 0;
            this.buttonBasla.Text = "Start";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // labelHangman
            // 
            this.labelHangman.AutoSize = true;
            this.labelHangman.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHangman.Location = new System.Drawing.Point(249, 73);
            this.labelHangman.Name = "labelHangman";
            this.labelHangman.Size = new System.Drawing.Size(359, 84);
            this.labelHangman.TabIndex = 1;
            this.labelHangman.Text = "HANGMAN";
            // 
            // buttonAyarlar
            // 
            this.buttonAyarlar.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAyarlar.Location = new System.Drawing.Point(316, 289);
            this.buttonAyarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAyarlar.Name = "buttonAyarlar";
            this.buttonAyarlar.Size = new System.Drawing.Size(231, 55);
            this.buttonAyarlar.TabIndex = 2;
            this.buttonAyarlar.Text = "Settings";
            this.buttonAyarlar.UseVisualStyleBackColor = true;
            this.buttonAyarlar.Click += new System.EventHandler(this.buttonAyarlar_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Location = new System.Drawing.Point(316, 367);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(231, 55);
            this.buttonCikis.TabIndex = 3;
            this.buttonCikis.Text = "Quit";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(596, 210);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(287, 53);
            this.comboBoxSubject.TabIndex = 4;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelSubject.Location = new System.Drawing.Point(668, 149);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(144, 45);
            this.labelSubject.TabIndex = 5;
            this.labelSubject.Text = "Subject";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonAyarlar);
            this.Controls.Add(this.labelHangman);
            this.Controls.Add(this.buttonBasla);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "152120231042 152120221098 Grup 14 OOP_2_Week8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Label labelHangman;
        private System.Windows.Forms.Button buttonAyarlar;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelSubject;
    }
}

