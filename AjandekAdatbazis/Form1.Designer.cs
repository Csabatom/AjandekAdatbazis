
namespace AjandekAdatbazis
{
    partial class AjandekListaForm
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
            this.ajandekListBox = new System.Windows.Forms.ListBox();
            this.TxtBox_AjandekNev = new System.Windows.Forms.TextBox();
            this.TxtBox_AjandekUzlet = new System.Windows.Forms.TextBox();
            this.Btn_AjandekHozzaadas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_AjandekID = new System.Windows.Forms.Label();
            this.LBL_AjandekNev = new System.Windows.Forms.Label();
            this.LBL_AjandekUzlet = new System.Windows.Forms.Label();
            this.Btn_AjandekTorlese = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajandekListBox
            // 
            this.ajandekListBox.FormattingEnabled = true;
            this.ajandekListBox.ItemHeight = 16;
            this.ajandekListBox.Location = new System.Drawing.Point(12, 12);
            this.ajandekListBox.Name = "ajandekListBox";
            this.ajandekListBox.Size = new System.Drawing.Size(200, 420);
            this.ajandekListBox.TabIndex = 0;
            this.ajandekListBox.SelectedIndexChanged += new System.EventHandler(this.ajandekListBox_SelectedIndexChanged);
            // 
            // TxtBox_AjandekNev
            // 
            this.TxtBox_AjandekNev.ForeColor = System.Drawing.Color.Gray;
            this.TxtBox_AjandekNev.Location = new System.Drawing.Point(18, 34);
            this.TxtBox_AjandekNev.Name = "TxtBox_AjandekNev";
            this.TxtBox_AjandekNev.Size = new System.Drawing.Size(162, 22);
            this.TxtBox_AjandekNev.TabIndex = 3;
            this.TxtBox_AjandekNev.Text = "Ajándék neve";
            this.TxtBox_AjandekNev.Enter += new System.EventHandler(this.TxtBox_AjandekNev_FocusEnter);
            this.TxtBox_AjandekNev.Leave += new System.EventHandler(this.TxtBox_AjandekNev_FocusLeave);
            // 
            // TxtBox_AjandekUzlet
            // 
            this.TxtBox_AjandekUzlet.ForeColor = System.Drawing.Color.Gray;
            this.TxtBox_AjandekUzlet.Location = new System.Drawing.Point(18, 62);
            this.TxtBox_AjandekUzlet.Name = "TxtBox_AjandekUzlet";
            this.TxtBox_AjandekUzlet.Size = new System.Drawing.Size(162, 22);
            this.TxtBox_AjandekUzlet.TabIndex = 4;
            this.TxtBox_AjandekUzlet.Text = "Üzlet neve";
            this.TxtBox_AjandekUzlet.Enter += new System.EventHandler(this.TxtBox_AjandekUzlet_FocusEnter);
            this.TxtBox_AjandekUzlet.Leave += new System.EventHandler(this.TxtBox_AjandekUzlet_FocusLeave);
            // 
            // Btn_AjandekHozzaadas
            // 
            this.Btn_AjandekHozzaadas.Location = new System.Drawing.Point(18, 95);
            this.Btn_AjandekHozzaadas.Name = "Btn_AjandekHozzaadas";
            this.Btn_AjandekHozzaadas.Size = new System.Drawing.Size(162, 36);
            this.Btn_AjandekHozzaadas.TabIndex = 5;
            this.Btn_AjandekHozzaadas.Text = "Ajándék hozzáadása";
            this.Btn_AjandekHozzaadas.UseVisualStyleBackColor = true;
            this.Btn_AjandekHozzaadas.Click += new System.EventHandler(this.Btn_AjandekHozzaadas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBox_AjandekNev);
            this.groupBox1.Controls.Add(this.Btn_AjandekHozzaadas);
            this.groupBox1.Controls.Add(this.TxtBox_AjandekUzlet);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új ajándék";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_AjandekTorlese);
            this.groupBox2.Controls.Add(this.LBL_AjandekUzlet);
            this.groupBox2.Controls.Add(this.LBL_AjandekNev);
            this.groupBox2.Controls.Add(this.LBL_AjandekID);
            this.groupBox2.Location = new System.Drawing.Point(218, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 266);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajándék tulajdonságai";
            // 
            // LBL_AjandekID
            // 
            this.LBL_AjandekID.AutoSize = true;
            this.LBL_AjandekID.Location = new System.Drawing.Point(6, 32);
            this.LBL_AjandekID.Name = "LBL_AjandekID";
            this.LBL_AjandekID.Size = new System.Drawing.Size(29, 17);
            this.LBL_AjandekID.TabIndex = 0;
            this.LBL_AjandekID.Text = "ID: ";
            // 
            // LBL_AjandekNev
            // 
            this.LBL_AjandekNev.AutoSize = true;
            this.LBL_AjandekNev.Location = new System.Drawing.Point(6, 49);
            this.LBL_AjandekNev.Name = "LBL_AjandekNev";
            this.LBL_AjandekNev.Size = new System.Drawing.Size(41, 17);
            this.LBL_AjandekNev.TabIndex = 1;
            this.LBL_AjandekNev.Text = "Név: ";
            // 
            // LBL_AjandekUzlet
            // 
            this.LBL_AjandekUzlet.AutoSize = true;
            this.LBL_AjandekUzlet.Location = new System.Drawing.Point(6, 66);
            this.LBL_AjandekUzlet.Name = "LBL_AjandekUzlet";
            this.LBL_AjandekUzlet.Size = new System.Drawing.Size(83, 17);
            this.LBL_AjandekUzlet.TabIndex = 2;
            this.LBL_AjandekUzlet.Text = "Üzlet neve: ";
            // 
            // Btn_AjandekTorlese
            // 
            this.Btn_AjandekTorlese.Enabled = false;
            this.Btn_AjandekTorlese.Location = new System.Drawing.Point(402, 13);
            this.Btn_AjandekTorlese.Name = "Btn_AjandekTorlese";
            this.Btn_AjandekTorlese.Size = new System.Drawing.Size(162, 36);
            this.Btn_AjandekTorlese.TabIndex = 6;
            this.Btn_AjandekTorlese.Text = "Ajándék törlése";
            this.Btn_AjandekTorlese.UseVisualStyleBackColor = true;
            this.Btn_AjandekTorlese.Click += new System.EventHandler(this.Btn_AjandekTorlese_Click);
            // 
            // AjandekListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ajandekListBox);
            this.Name = "AjandekListaForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ajandekListBox;
        private System.Windows.Forms.TextBox TxtBox_AjandekNev;
        private System.Windows.Forms.TextBox TxtBox_AjandekUzlet;
        private System.Windows.Forms.Button Btn_AjandekHozzaadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_AjandekUzlet;
        private System.Windows.Forms.Label LBL_AjandekNev;
        private System.Windows.Forms.Label LBL_AjandekID;
        private System.Windows.Forms.Button Btn_AjandekTorlese;
    }
}

