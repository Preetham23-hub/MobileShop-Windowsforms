namespace mobileshop
{
    partial class available
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
            this.phoneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istrogeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estrogeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rearcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frontcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mobileshopDataSet9 = new mobileshop.mobileshopDataSet9();
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileshopDataSet1 = new mobileshop.mobileshopDataSet1();
            this.phonesTableAdapter = new mobileshop.mobileshopDataSet1TableAdapters.PhonesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phonesTableAdapter1 = new mobileshop.mobileshopDataSet9TableAdapters.PhonesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneidDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.ramDataGridViewTextBoxColumn,
            this.istrogeDataGridViewTextBoxColumn,
            this.estrogeDataGridViewTextBoxColumn,
            this.displayDataGridViewTextBoxColumn,
            this.rearcDataGridViewTextBoxColumn,
            this.frontcDataGridViewTextBoxColumn,
            this.fingerDataGridViewTextBoxColumn,
            this.simDataGridViewTextBoxColumn,
            this.networkDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phonesBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1528, 604);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // phoneidDataGridViewTextBoxColumn
            // 
            this.phoneidDataGridViewTextBoxColumn.DataPropertyName = "phone_id";
            this.phoneidDataGridViewTextBoxColumn.HeaderText = "phone_id";
            this.phoneidDataGridViewTextBoxColumn.Name = "phoneidDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // ramDataGridViewTextBoxColumn
            // 
            this.ramDataGridViewTextBoxColumn.DataPropertyName = "ram";
            this.ramDataGridViewTextBoxColumn.HeaderText = "ram";
            this.ramDataGridViewTextBoxColumn.Name = "ramDataGridViewTextBoxColumn";
            // 
            // istrogeDataGridViewTextBoxColumn
            // 
            this.istrogeDataGridViewTextBoxColumn.DataPropertyName = "istroge";
            this.istrogeDataGridViewTextBoxColumn.HeaderText = "istroge";
            this.istrogeDataGridViewTextBoxColumn.Name = "istrogeDataGridViewTextBoxColumn";
            // 
            // estrogeDataGridViewTextBoxColumn
            // 
            this.estrogeDataGridViewTextBoxColumn.DataPropertyName = "estroge";
            this.estrogeDataGridViewTextBoxColumn.HeaderText = "estroge";
            this.estrogeDataGridViewTextBoxColumn.Name = "estrogeDataGridViewTextBoxColumn";
            // 
            // displayDataGridViewTextBoxColumn
            // 
            this.displayDataGridViewTextBoxColumn.DataPropertyName = "display";
            this.displayDataGridViewTextBoxColumn.HeaderText = "display";
            this.displayDataGridViewTextBoxColumn.Name = "displayDataGridViewTextBoxColumn";
            // 
            // rearcDataGridViewTextBoxColumn
            // 
            this.rearcDataGridViewTextBoxColumn.DataPropertyName = "rearc";
            this.rearcDataGridViewTextBoxColumn.HeaderText = "rearc";
            this.rearcDataGridViewTextBoxColumn.Name = "rearcDataGridViewTextBoxColumn";
            // 
            // frontcDataGridViewTextBoxColumn
            // 
            this.frontcDataGridViewTextBoxColumn.DataPropertyName = "frontc";
            this.frontcDataGridViewTextBoxColumn.HeaderText = "frontc";
            this.frontcDataGridViewTextBoxColumn.Name = "frontcDataGridViewTextBoxColumn";
            // 
            // fingerDataGridViewTextBoxColumn
            // 
            this.fingerDataGridViewTextBoxColumn.DataPropertyName = "finger";
            this.fingerDataGridViewTextBoxColumn.HeaderText = "finger";
            this.fingerDataGridViewTextBoxColumn.Name = "fingerDataGridViewTextBoxColumn";
            // 
            // simDataGridViewTextBoxColumn
            // 
            this.simDataGridViewTextBoxColumn.DataPropertyName = "sim";
            this.simDataGridViewTextBoxColumn.HeaderText = "sim";
            this.simDataGridViewTextBoxColumn.Name = "simDataGridViewTextBoxColumn";
            // 
            // networkDataGridViewTextBoxColumn
            // 
            this.networkDataGridViewTextBoxColumn.DataPropertyName = "network";
            this.networkDataGridViewTextBoxColumn.HeaderText = "network";
            this.networkDataGridViewTextBoxColumn.Name = "networkDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // phonesBindingSource1
            // 
            this.phonesBindingSource1.DataMember = "Phones";
            this.phonesBindingSource1.DataSource = this.mobileshopDataSet9;
            // 
            // mobileshopDataSet9
            // 
            this.mobileshopDataSet9.DataSetName = "mobileshopDataSet9";
            this.mobileshopDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            this.phonesBindingSource.DataSource = this.mobileshopDataSet1;
            // 
            // mobileshopDataSet1
            // 
            this.mobileshopDataSet1.DataSetName = "mobileshopDataSet1";
            this.mobileshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonesTableAdapter
            // 
            this.phonesTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // phonesTableAdapter1
            // 
            this.phonesTableAdapter1.ClearBeforeFill = true;
            // 
            // available
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1603, 717);
            this.Controls.Add(this.dataGridView1);
            this.Name = "available";
            this.Text = "available";
            this.Load += new System.EventHandler(this.available_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private mobileshopDataSet1 mobileshopDataSet1;
        private System.Windows.Forms.BindingSource phonesBindingSource;
        private mobileshopDataSet1TableAdapters.PhonesTableAdapter phonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istrogeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estrogeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rearcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frontcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private mobileshopDataSet9 mobileshopDataSet9;
        private System.Windows.Forms.BindingSource phonesBindingSource1;
        private mobileshopDataSet9TableAdapters.PhonesTableAdapter phonesTableAdapter1;
    }
}