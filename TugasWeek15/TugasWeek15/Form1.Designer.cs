
namespace TugasWeek15
{
    partial class FormUtama
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
            this.labelNmItem = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.groupBoxJenis = new System.Windows.Forms.GroupBox();
            this.radioButtonMinum = new System.Windows.Forms.RadioButton();
            this.radioButtonMakan = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.listBoxKiri = new System.Windows.Forms.ListBox();
            this.listBoxKanan = new System.Windows.Forms.ListBox();
            this.buttonMasukin = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxMinum = new System.Windows.Forms.CheckBox();
            this.checkBoxMakan = new System.Windows.Forms.CheckBox();
            this.groupBoxJenis.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNmItem
            // 
            this.labelNmItem.AutoSize = true;
            this.labelNmItem.Location = new System.Drawing.Point(22, 23);
            this.labelNmItem.Name = "labelNmItem";
            this.labelNmItem.Size = new System.Drawing.Size(58, 13);
            this.labelNmItem.TabIndex = 0;
            this.labelNmItem.Text = "Nama Item";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(109, 20);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(22, 59);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(46, 13);
            this.labelKategori.TabIndex = 2;
            this.labelKategori.Text = "Kategori";
            // 
            // groupBoxJenis
            // 
            this.groupBoxJenis.Controls.Add(this.radioButtonMinum);
            this.groupBoxJenis.Controls.Add(this.radioButtonMakan);
            this.groupBoxJenis.Location = new System.Drawing.Point(109, 46);
            this.groupBoxJenis.Name = "groupBoxJenis";
            this.groupBoxJenis.Size = new System.Drawing.Size(188, 42);
            this.groupBoxJenis.TabIndex = 3;
            this.groupBoxJenis.TabStop = false;
            // 
            // radioButtonMinum
            // 
            this.radioButtonMinum.AutoSize = true;
            this.radioButtonMinum.Location = new System.Drawing.Point(99, 14);
            this.radioButtonMinum.Name = "radioButtonMinum";
            this.radioButtonMinum.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinum.TabIndex = 1;
            this.radioButtonMinum.TabStop = true;
            this.radioButtonMinum.Text = "Minuman";
            this.radioButtonMinum.UseVisualStyleBackColor = true;
            // 
            // radioButtonMakan
            // 
            this.radioButtonMakan.AutoSize = true;
            this.radioButtonMakan.Location = new System.Drawing.Point(7, 15);
            this.radioButtonMakan.Name = "radioButtonMakan";
            this.radioButtonMakan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakan.TabIndex = 0;
            this.radioButtonMakan.TabStop = true;
            this.radioButtonMakan.Text = "Makanan";
            this.radioButtonMakan.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(109, 94);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // listBoxKiri
            // 
            this.listBoxKiri.DisplayMember = "Makan";
            this.listBoxKiri.FormattingEnabled = true;
            this.listBoxKiri.Location = new System.Drawing.Point(25, 140);
            this.listBoxKiri.Name = "listBoxKiri";
            this.listBoxKiri.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxKiri.Size = new System.Drawing.Size(129, 225);
            this.listBoxKiri.TabIndex = 5;
            // 
            // listBoxKanan
            // 
            this.listBoxKanan.FormattingEnabled = true;
            this.listBoxKanan.Location = new System.Drawing.Point(311, 140);
            this.listBoxKanan.Name = "listBoxKanan";
            this.listBoxKanan.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxKanan.Size = new System.Drawing.Size(129, 225);
            this.listBoxKanan.TabIndex = 6;
            // 
            // buttonMasukin
            // 
            this.buttonMasukin.Location = new System.Drawing.Point(198, 140);
            this.buttonMasukin.Name = "buttonMasukin";
            this.buttonMasukin.Size = new System.Drawing.Size(75, 23);
            this.buttonMasukin.TabIndex = 7;
            this.buttonMasukin.Text = ">";
            this.buttonMasukin.UseVisualStyleBackColor = true;
            this.buttonMasukin.Click += new System.EventHandler(this.buttonMasukin_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(198, 169);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 8;
            this.buttonHapus.Text = "X";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.checkBoxMinum);
            this.groupBoxFilter.Controls.Add(this.checkBoxMakan);
            this.groupBoxFilter.Location = new System.Drawing.Point(179, 214);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(112, 99);
            this.groupBoxFilter.TabIndex = 4;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // checkBoxMinum
            // 
            this.checkBoxMinum.AutoSize = true;
            this.checkBoxMinum.Location = new System.Drawing.Point(6, 55);
            this.checkBoxMinum.Name = "checkBoxMinum";
            this.checkBoxMinum.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMinum.TabIndex = 1;
            this.checkBoxMinum.Text = "Minuman";
            this.checkBoxMinum.UseVisualStyleBackColor = true;
            this.checkBoxMinum.CheckedChanged += new System.EventHandler(this.checkBoxMinum_CheckedChanged);
            // 
            // checkBoxMakan
            // 
            this.checkBoxMakan.AutoSize = true;
            this.checkBoxMakan.Location = new System.Drawing.Point(6, 25);
            this.checkBoxMakan.Name = "checkBoxMakan";
            this.checkBoxMakan.Size = new System.Drawing.Size(71, 17);
            this.checkBoxMakan.TabIndex = 0;
            this.checkBoxMakan.Text = "Makanan";
            this.checkBoxMakan.UseVisualStyleBackColor = true;
            this.checkBoxMakan.CheckedChanged += new System.EventHandler(this.checkBoxMakan_CheckedChanged);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.listBoxKanan);
            this.Controls.Add(this.buttonMasukin);
            this.Controls.Add(this.listBoxKiri);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.groupBoxJenis);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelNmItem);
            this.Name = "FormUtama";
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.groupBoxJenis.ResumeLayout(false);
            this.groupBoxJenis.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNmItem;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.GroupBox groupBoxJenis;
        private System.Windows.Forms.RadioButton radioButtonMinum;
        private System.Windows.Forms.RadioButton radioButtonMakan;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ListBox listBoxKiri;
        private System.Windows.Forms.ListBox listBoxKanan;
        private System.Windows.Forms.Button buttonMasukin;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxMinum;
        private System.Windows.Forms.CheckBox checkBoxMakan;
    }
}

