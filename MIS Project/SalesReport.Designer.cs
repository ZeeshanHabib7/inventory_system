namespace MIS_Project
{
    partial class SalesReport
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISDataSet4 = new MIS_Project.MISDataSet4();
            this.updated = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.sales_PersTableAdapter = new MIS_Project.MISDataSet4TableAdapters.Sales_PersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sPNameDataGridViewTextBoxColumn,
            this.sPqtyDataGridViewTextBoxColumn,
            this.sPareaDataGridViewTextBoxColumn,
            this.sPDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesPersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPNameDataGridViewTextBoxColumn
            // 
            this.sPNameDataGridViewTextBoxColumn.DataPropertyName = "SP_Name";
            this.sPNameDataGridViewTextBoxColumn.HeaderText = "SP_Name";
            this.sPNameDataGridViewTextBoxColumn.Name = "sPNameDataGridViewTextBoxColumn";
            // 
            // sPqtyDataGridViewTextBoxColumn
            // 
            this.sPqtyDataGridViewTextBoxColumn.DataPropertyName = "SP_qty";
            this.sPqtyDataGridViewTextBoxColumn.HeaderText = "SP_qty";
            this.sPqtyDataGridViewTextBoxColumn.Name = "sPqtyDataGridViewTextBoxColumn";
            // 
            // sPareaDataGridViewTextBoxColumn
            // 
            this.sPareaDataGridViewTextBoxColumn.DataPropertyName = "SP_area";
            this.sPareaDataGridViewTextBoxColumn.HeaderText = "SP_area";
            this.sPareaDataGridViewTextBoxColumn.Name = "sPareaDataGridViewTextBoxColumn";
            // 
            // sPDateDataGridViewTextBoxColumn
            // 
            this.sPDateDataGridViewTextBoxColumn.DataPropertyName = "SP_Date";
            this.sPDateDataGridViewTextBoxColumn.HeaderText = "SP_Date";
            this.sPDateDataGridViewTextBoxColumn.Name = "sPDateDataGridViewTextBoxColumn";
            // 
            // salesPersBindingSource
            // 
            this.salesPersBindingSource.DataMember = "Sales_Pers";
            this.salesPersBindingSource.DataSource = this.mISDataSet4;
            // 
            // mISDataSet4
            // 
            this.mISDataSet4.DataSetName = "MISDataSet4";
            this.mISDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updated
            // 
            this.updated.Location = new System.Drawing.Point(409, 295);
            this.updated.Name = "updated";
            this.updated.Size = new System.Drawing.Size(233, 34);
            this.updated.TabIndex = 1;
            this.updated.Text = "Updated";
            this.updated.UseVisualStyleBackColor = true;
            this.updated.Click += new System.EventHandler(this.updated_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(648, 295);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(220, 34);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // sales_PersTableAdapter
            // 
            this.sales_PersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.updated);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updated;
        private System.Windows.Forms.Button Load;
        private MISDataSet4 mISDataSet4;
        private System.Windows.Forms.BindingSource salesPersBindingSource;
        private MISDataSet4TableAdapters.Sales_PersTableAdapter sales_PersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}