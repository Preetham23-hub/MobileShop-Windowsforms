namespace mobileshop
{
    partial class search
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.mobileshopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileshopDataSet = new mobileshop.mobileshopDataSet();
            this.phonesTableAdapter = new mobileshop.mobileshopDataSetTableAdapters.PhonesTableAdapter();
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(519, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Phone Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(696, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "Search Phone ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(739, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(174, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 424);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.phonesBindingSource1.DataSource = this.mobileshopDataSetBindingSource;
            // 
            // mobileshopDataSetBindingSource
            // 
            this.mobileshopDataSetBindingSource.DataSource = this.mobileshopDataSet;
            this.mobileshopDataSetBindingSource.Position = 0;
            // 
            // mobileshopDataSet
            // 
            this.mobileshopDataSet.DataSetName = "mobileshopDataSet";
            this.mobileshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonesTableAdapter
            // 
            this.phonesTableAdapter.ClearBeforeFill = true;
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1840, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource phonesBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mobileshopDataSetBindingSource;
        private mobileshopDataSet mobileshopDataSet;
        private System.Windows.Forms.BindingSource phonesBindingSource1;
        private mobileshopDataSetTableAdapters.PhonesTableAdapter phonesTableAdapter;
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
    }
}