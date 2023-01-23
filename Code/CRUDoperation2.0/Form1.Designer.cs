
namespace CRUDoperation2._0
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
            this.INSERT = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.MaskedTextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.GENDER = new System.Windows.Forms.TextBox();
            this.AGE = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.SELECTION = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // INSERT
            // 
            this.INSERT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.INSERT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.INSERT.Location = new System.Drawing.Point(129, 198);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(270, 87);
            this.INSERT.TabIndex = 0;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = false;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(120, 137);
            this.ID.Mask = "0000";
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(279, 38);
            this.ID.TabIndex = 1;
            this.ID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ID_MaskInputRejected);
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(490, 136);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(237, 38);
            this.NAME.TabIndex = 2;
            this.NAME.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // GENDER
            // 
            this.GENDER.Location = new System.Drawing.Point(835, 136);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(237, 38);
            this.GENDER.TabIndex = 3;
            this.GENDER.TextChanged += new System.EventHandler(this.GENDER_TextChanged);
            // 
            // AGE
            // 
            this.AGE.Location = new System.Drawing.Point(1183, 137);
            this.AGE.Mask = "00";
            this.AGE.Name = "AGE";
            this.AGE.Size = new System.Drawing.Size(279, 38);
            this.AGE.TabIndex = 4;
            this.AGE.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.AGE_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(484, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(829, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1177, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter age";
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Salmon;
            this.DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETE.Location = new System.Drawing.Point(490, 198);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(237, 87);
            this.DELETE.TabIndex = 9;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.DarkKhaki;
            this.UPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATE.Location = new System.Drawing.Point(836, 198);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(236, 87);
            this.UPDATE.TabIndex = 10;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // SELECTION
            // 
            this.SELECTION.BackColor = System.Drawing.Color.LightGreen;
            this.SELECTION.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SELECTION.Location = new System.Drawing.Point(1183, 198);
            this.SELECTION.Name = "SELECTION";
            this.SELECTION.Size = new System.Drawing.Size(279, 87);
            this.SELECTION.TabIndex = 11;
            this.SELECTION.Text = "SELECTION";
            this.SELECTION.UseVisualStyleBackColor = false;
            this.SELECTION.Click += new System.EventHandler(this.SELECTION_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1333, 352);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1665, 829);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SELECTION);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.GENDER);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.INSERT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD OPERATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.MaskedTextBox ID;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TextBox GENDER;
        private System.Windows.Forms.MaskedTextBox AGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button SELECTION;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

