namespace Purchase_of_manga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAutor = new TextBox();
            label3 = new Label();
            txtVolume = new TextBox();
            label4 = new Label();
            btnPurchase = new Button();
            lblTotal = new Label();
            label5 = new Label();
            txtQuantity = new TextBox();
            lblAutor = new Label();
            txtGenre = new TextBox();
            btnClear = new Button();
            comboBoxEditorial = new ComboBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.ControlLightLight;
            txtTitle.Font = new Font("MS Reference Sans Serif", 11.25F);
            txtTitle.Location = new Point(253, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(182, 26);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 30);
            label1.Name = "label1";
            label1.Size = new Size(132, 24);
            label1.TabIndex = 1;
            label1.Text = "Manga title: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 3;
            label2.Text = "Autor: ";
            // 
            // txtAutor
            // 
            txtAutor.BackColor = SystemColors.ControlLightLight;
            txtAutor.Font = new Font("MS Reference Sans Serif", 11.25F);
            txtAutor.Location = new Point(253, 100);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(182, 26);
            txtAutor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 243);
            label3.Name = "label3";
            label3.Size = new Size(91, 24);
            label3.TabIndex = 5;
            label3.Text = "Volume:";
            // 
            // txtVolume
            // 
            txtVolume.BackColor = SystemColors.ControlLightLight;
            txtVolume.Font = new Font("MS Reference Sans Serif", 11.25F);
            txtVolume.Location = new Point(253, 244);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(182, 26);
            txtVolume.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(136, 311);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 7;
            label4.Text = "Editorial:";
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = SystemColors.ActiveCaptionText;
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = SystemColors.ButtonFace;
            btnPurchase.Location = new Point(100, 434);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(114, 54);
            btnPurchase.TabIndex = 8;
            btnPurchase.Text = "Calculate purchase";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(257, 449);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 24);
            lblTotal.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 381);
            label5.Name = "label5";
            label5.Size = new Size(207, 24);
            label5.TabIndex = 12;
            label5.Text = "Number of volumes:";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.ControlLightLight;
            txtQuantity.Font = new Font("MS Reference Sans Serif", 11.25F);
            txtQuantity.Location = new Point(253, 381);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(182, 26);
            txtQuantity.TabIndex = 11;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.BackColor = Color.Transparent;
            lblAutor.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(159, 171);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(76, 24);
            lblAutor.TabIndex = 14;
            lblAutor.Text = "Genre:";
            // 
            // txtGenre
            // 
            txtGenre.BackColor = SystemColors.ControlLightLight;
            txtGenre.Font = new Font("MS Reference Sans Serif", 11.25F);
            txtGenre.Location = new Point(253, 173);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(182, 26);
            txtGenre.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(431, 444);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 35);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // comboBoxEditorial
            // 
            comboBoxEditorial.BackColor = SystemColors.ControlLightLight;
            comboBoxEditorial.Font = new Font("MS Reference Sans Serif", 11.25F);
            comboBoxEditorial.FormattingEnabled = true;
            comboBoxEditorial.Items.AddRange(new object[] { "Panini", "Norma", "Ivrea" });
            comboBoxEditorial.Location = new Point(253, 312);
            comboBoxEditorial.Name = "comboBoxEditorial";
            comboBoxEditorial.Size = new Size(182, 27);
            comboBoxEditorial.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(760, 513);
            Controls.Add(comboBoxEditorial);
            Controls.Add(btnClear);
            Controls.Add(lblAutor);
            Controls.Add(txtGenre);
            Controls.Add(label5);
            Controls.Add(txtQuantity);
            Controls.Add(lblTotal);
            Controls.Add(btnPurchase);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtVolume);
            Controls.Add(label2);
            Controls.Add(txtAutor);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private TextBox txtAutor;
        private Label label3;
        private TextBox txtVolume;
        private Label label4;
        private Button btnPurchase;
        private Label lblTotal;
        private Label label5;
        private TextBox txtQuantity;
        private Label lblAutor;
        private TextBox txtGenre;
        private Button btnClear;
        private ComboBox comboBoxEditorial;
    }
}
