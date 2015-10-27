namespace film
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cdDataSet = new film.cdDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new film.cdDataSetTableAdapters.filmTableAdapter();
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncmuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fidDataGridViewTextBoxColumn,
            this.fAdiDataGridViewTextBoxColumn,
            this.fTnoDataGridViewTextBoxColumn,
            this.oduncmuDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.filmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cdDataSet
            // 
            this.cdDataSet.DataSetName = "cdDataSet";
            this.cdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "film";
            this.filmBindingSource.DataSource = this.cdDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "Fid";
            this.fidDataGridViewTextBoxColumn.HeaderText = "Fid";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            // 
            // fAdiDataGridViewTextBoxColumn
            // 
            this.fAdiDataGridViewTextBoxColumn.DataPropertyName = "FAdi";
            this.fAdiDataGridViewTextBoxColumn.HeaderText = "FAdi";
            this.fAdiDataGridViewTextBoxColumn.Name = "fAdiDataGridViewTextBoxColumn";
            // 
            // fTnoDataGridViewTextBoxColumn
            // 
            this.fTnoDataGridViewTextBoxColumn.DataPropertyName = "FTno";
            this.fTnoDataGridViewTextBoxColumn.HeaderText = "FTno";
            this.fTnoDataGridViewTextBoxColumn.Name = "fTnoDataGridViewTextBoxColumn";
            // 
            // oduncmuDataGridViewCheckBoxColumn
            // 
            this.oduncmuDataGridViewCheckBoxColumn.DataPropertyName = "Oduncmu";
            this.oduncmuDataGridViewCheckBoxColumn.HeaderText = "Oduncmu";
            this.oduncmuDataGridViewCheckBoxColumn.Name = "oduncmuDataGridViewCheckBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 226);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private cdDataSet cdDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private cdDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oduncmuDataGridViewCheckBoxColumn;
    }
}