namespace CarsDatabase
{
    partial class FrmSearch
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
            this.gpoBox = new System.Windows.Forms.GroupBox();
            this.txtValueBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbboxOperator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbboxField = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(716, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gpoBox
            // 
            this.gpoBox.Controls.Add(this.txtValueBox);
            this.gpoBox.Controls.Add(this.label3);
            this.gpoBox.Controls.Add(this.cbboxOperator);
            this.gpoBox.Controls.Add(this.label2);
            this.gpoBox.Controls.Add(this.label1);
            this.gpoBox.Controls.Add(this.cbboxField);
            this.gpoBox.Location = new System.Drawing.Point(28, 26);
            this.gpoBox.Name = "gpoBox";
            this.gpoBox.Size = new System.Drawing.Size(531, 138);
            this.gpoBox.TabIndex = 1;
            this.gpoBox.TabStop = false;
            // 
            // txtValueBox
            // 
            this.txtValueBox.Location = new System.Drawing.Point(372, 58);
            this.txtValueBox.Name = "txtValueBox";
            this.txtValueBox.Size = new System.Drawing.Size(100, 20);
            this.txtValueBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value";
            // 
            // cbboxOperator
            // 
            this.cbboxOperator.FormattingEnabled = true;
            this.cbboxOperator.Location = new System.Drawing.Point(203, 58);
            this.cbboxOperator.Name = "cbboxOperator";
            this.cbboxOperator.Size = new System.Drawing.Size(121, 21);
            this.cbboxOperator.TabIndex = 3;
            this.cbboxOperator.SelectedIndexChanged += new System.EventHandler(this.cbboxOperator_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field";
            // 
            // cbboxField
            // 
            this.cbboxField.FormattingEnabled = true;
            this.cbboxField.Location = new System.Drawing.Point(38, 58);
            this.cbboxField.Name = "cbboxField";
            this.cbboxField.Size = new System.Drawing.Size(121, 21);
            this.cbboxField.TabIndex = 0;
            this.cbboxField.SelectedIndexChanged += new System.EventHandler(this.cbboxField_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(608, 49);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(136, 56);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(608, 110);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 54);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gpoBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task A Search Joshua Wyngaard 25/09/2020";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpoBox.ResumeLayout(false);
            this.gpoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbboxField;
        private System.Windows.Forms.ComboBox cbboxOperator;
        private System.Windows.Forms.TextBox txtValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
    }
}