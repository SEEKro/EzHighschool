namespace AplicatieScoala
{
    partial class EleviInfoForm
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
            this.check_all = new System.Windows.Forms.CheckBox();
            this.radio_note = new System.Windows.Forms.RadioButton();
            this.radio_absente = new System.Windows.Forms.RadioButton();
            this.box_materii = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // check_all
            // 
            this.check_all.AutoSize = true;
            this.check_all.Location = new System.Drawing.Point(209, 387);
            this.check_all.Margin = new System.Windows.Forms.Padding(4);
            this.check_all.Name = "check_all";
            this.check_all.Size = new System.Drawing.Size(89, 21);
            this.check_all.TabIndex = 16;
            this.check_all.Text = "chack_all";
            this.check_all.UseVisualStyleBackColor = true;
            this.check_all.CheckedChanged += new System.EventHandler(this.check_all_CheckedChanged);
            // 
            // radio_note
            // 
            this.radio_note.AutoSize = true;
            this.radio_note.Location = new System.Drawing.Point(601, 26);
            this.radio_note.Margin = new System.Windows.Forms.Padding(4);
            this.radio_note.Name = "radio_note";
            this.radio_note.Size = new System.Drawing.Size(97, 21);
            this.radio_note.TabIndex = 15;
            this.radio_note.TabStop = true;
            this.radio_note.Text = "radio_note";
            this.radio_note.UseVisualStyleBackColor = true;
            this.radio_note.CheckedChanged += new System.EventHandler(this.radio_note_CheckedChanged_1);
            // 
            // radio_absente
            // 
            this.radio_absente.AutoSize = true;
            this.radio_absente.Location = new System.Drawing.Point(470, 26);
            this.radio_absente.Margin = new System.Windows.Forms.Padding(4);
            this.radio_absente.Name = "radio_absente";
            this.radio_absente.Size = new System.Drawing.Size(120, 21);
            this.radio_absente.TabIndex = 14;
            this.radio_absente.TabStop = true;
            this.radio_absente.Text = "radio_absente";
            this.radio_absente.UseVisualStyleBackColor = true;
            this.radio_absente.CheckedChanged += new System.EventHandler(this.radio_absente_CheckedChanged);
            // 
            // box_materii
            // 
            this.box_materii.FormattingEnabled = true;
            this.box_materii.ItemHeight = 16;
            this.box_materii.Location = new System.Drawing.Point(209, 54);
            this.box_materii.Margin = new System.Windows.Forms.Padding(4);
            this.box_materii.Name = "box_materii";
            this.box_materii.Size = new System.Drawing.Size(223, 324);
            this.box_materii.TabIndex = 13;
            this.box_materii.SelectedIndexChanged += new System.EventHandler(this.box_materii_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 666);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EleviInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 747);
            this.Controls.Add(this.check_all);
            this.Controls.Add(this.radio_note);
            this.Controls.Add(this.radio_absente);
            this.Controls.Add(this.box_materii);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EleviInfoForm";
            this.Text = "EleviInfoForm";
            this.Load += new System.EventHandler(this.EleviInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_all;
        private System.Windows.Forms.RadioButton radio_note;
        private System.Windows.Forms.RadioButton radio_absente;
        private System.Windows.Forms.ListBox box_materii;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}