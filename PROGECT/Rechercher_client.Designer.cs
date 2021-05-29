
namespace PROGECT
{
    partial class Rechercher_client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_cin = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.check_cin = new System.Windows.Forms.CheckBox();
            this.check_nom = new System.Windows.Forms.CheckBox();
            this.check_tel = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.check_prenom = new System.Windows.Forms.CheckBox();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.check_credit = new System.Windows.Forms.CheckBox();
            this.text_credit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(309, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CIN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRENOM";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TEL";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CREDIT";
            this.Column5.Name = "Column5";
            // 
            // text_cin
            // 
            this.text_cin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cin.Location = new System.Drawing.Point(184, 16);
            this.text_cin.Name = "text_cin";
            this.text_cin.Size = new System.Drawing.Size(149, 26);
            this.text_cin.TabIndex = 4;
            // 
            // text_nom
            // 
            this.text_nom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nom.Location = new System.Drawing.Point(473, 12);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(170, 26);
            this.text_nom.TabIndex = 5;
            // 
            // text_tel
            // 
            this.text_tel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tel.Location = new System.Drawing.Point(184, 75);
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(149, 26);
            this.text_tel.TabIndex = 6;
            // 
            // check_cin
            // 
            this.check_cin.AutoSize = true;
            this.check_cin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_cin.ForeColor = System.Drawing.Color.White;
            this.check_cin.Location = new System.Drawing.Point(113, 19);
            this.check_cin.Name = "check_cin";
            this.check_cin.Size = new System.Drawing.Size(56, 23);
            this.check_cin.TabIndex = 7;
            this.check_cin.Text = "CIN";
            this.check_cin.UseVisualStyleBackColor = true;
            // 
            // check_nom
            // 
            this.check_nom.AutoSize = true;
            this.check_nom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_nom.ForeColor = System.Drawing.Color.White;
            this.check_nom.Location = new System.Drawing.Point(373, 18);
            this.check_nom.Name = "check_nom";
            this.check_nom.Size = new System.Drawing.Size(65, 23);
            this.check_nom.TabIndex = 8;
            this.check_nom.Text = "NOM";
            this.check_nom.UseVisualStyleBackColor = true;
            // 
            // check_tel
            // 
            this.check_tel.AutoSize = true;
            this.check_tel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_tel.ForeColor = System.Drawing.Color.White;
            this.check_tel.Location = new System.Drawing.Point(113, 78);
            this.check_tel.Name = "check_tel";
            this.check_tel.Size = new System.Drawing.Size(59, 23);
            this.check_tel.TabIndex = 9;
            this.check_tel.Text = "TEL";
            this.check_tel.UseVisualStyleBackColor = true;
            this.check_tel.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1001, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_prenom
            // 
            this.check_prenom.AutoSize = true;
            this.check_prenom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_prenom.ForeColor = System.Drawing.Color.White;
            this.check_prenom.Location = new System.Drawing.Point(655, 18);
            this.check_prenom.Name = "check_prenom";
            this.check_prenom.Size = new System.Drawing.Size(99, 23);
            this.check_prenom.TabIndex = 13;
            this.check_prenom.Text = "PRENOM";
            this.check_prenom.UseVisualStyleBackColor = true;
            // 
            // text_prenom
            // 
            this.text_prenom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_prenom.Location = new System.Drawing.Point(777, 14);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(172, 26);
            this.text_prenom.TabIndex = 14;
            // 
            // check_credit
            // 
            this.check_credit.AutoSize = true;
            this.check_credit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_credit.ForeColor = System.Drawing.Color.White;
            this.check_credit.Location = new System.Drawing.Point(373, 75);
            this.check_credit.Name = "check_credit";
            this.check_credit.Size = new System.Drawing.Size(89, 23);
            this.check_credit.TabIndex = 15;
            this.check_credit.Text = "CREDIT";
            this.check_credit.UseVisualStyleBackColor = true;
            // 
            // text_credit
            // 
            this.text_credit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_credit.Location = new System.Drawing.Point(473, 73);
            this.text_credit.Name = "text_credit";
            this.text_credit.Size = new System.Drawing.Size(170, 26);
            this.text_credit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Rechercher_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1136, 521);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_credit);
            this.Controls.Add(this.check_credit);
            this.Controls.Add(this.text_prenom);
            this.Controls.Add(this.check_prenom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_tel);
            this.Controls.Add(this.check_nom);
            this.Controls.Add(this.check_cin);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.text_cin);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Rechercher_client";
            this.Text = "Rechercher";
            this.Load += new System.EventHandler(this.Rechercher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_cin;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.CheckBox check_cin;
        private System.Windows.Forms.CheckBox check_nom;
        private System.Windows.Forms.CheckBox check_tel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox check_prenom;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.CheckBox check_credit;
        private System.Windows.Forms.TextBox text_credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
    }
}