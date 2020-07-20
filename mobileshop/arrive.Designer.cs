namespace mobileshop
{
    partial class arrive
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istorageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estorageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realcameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frontcamearaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingertouchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newarrivalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileshopDataSet6 = new mobileshop.mobileshopDataSet6();
            this.new_arrivalTableAdapter = new mobileshop.mobileshopDataSet6TableAdapters.new_arrivalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newarrivalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(574, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Arrival";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.ramDataGridViewTextBoxColumn,
            this.istorageDataGridViewTextBoxColumn,
            this.estorageDataGridViewTextBoxColumn,
            this.displayDataGridViewTextBoxColumn,
            this.realcameraDataGridViewTextBoxColumn,
            this.frontcamearaDataGridViewTextBoxColumn,
            this.fingertouchDataGridViewTextBoxColumn,
            this.simDataGridViewTextBoxColumn,
            this.networkDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newarrivalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 237);
            this.dataGridView1.TabIndex = 1;
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
            // istorageDataGridViewTextBoxColumn
            // 
            this.istorageDataGridViewTextBoxColumn.DataPropertyName = "istorage";
            this.istorageDataGridViewTextBoxColumn.HeaderText = "istorage";
            this.istorageDataGridViewTextBoxColumn.Name = "istorageDataGridViewTextBoxColumn";
            // 
            // estorageDataGridViewTextBoxColumn
            // 
            this.estorageDataGridViewTextBoxColumn.DataPropertyName = "estorage";
            this.estorageDataGridViewTextBoxColumn.HeaderText = "estorage";
            this.estorageDataGridViewTextBoxColumn.Name = "estorageDataGridViewTextBoxColumn";
            // 
            // displayDataGridViewTextBoxColumn
            // 
            this.displayDataGridViewTextBoxColumn.DataPropertyName = "display";
            this.displayDataGridViewTextBoxColumn.HeaderText = "display";
            this.displayDataGridViewTextBoxColumn.Name = "displayDataGridViewTextBoxColumn";
            // 
            // realcameraDataGridViewTextBoxColumn
            // 
            this.realcameraDataGridViewTextBoxColumn.DataPropertyName = "real_camera";
            this.realcameraDataGridViewTextBoxColumn.HeaderText = "real_camera";
            this.realcameraDataGridViewTextBoxColumn.Name = "realcameraDataGridViewTextBoxColumn";
            // 
            // frontcamearaDataGridViewTextBoxColumn
            // 
            this.frontcamearaDataGridViewTextBoxColumn.DataPropertyName = "front_cameara";
            this.frontcamearaDataGridViewTextBoxColumn.HeaderText = "front_cameara";
            this.frontcamearaDataGridViewTextBoxColumn.Name = "frontcamearaDataGridViewTextBoxColumn";
            // 
            // fingertouchDataGridViewTextBoxColumn
            // 
            this.fingertouchDataGridViewTextBoxColumn.DataPropertyName = "finger_touch";
            this.fingertouchDataGridViewTextBoxColumn.HeaderText = "finger_touch";
            this.fingertouchDataGridViewTextBoxColumn.Name = "fingertouchDataGridViewTextBoxColumn";
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
            // newarrivalBindingSource
            // 
            this.newarrivalBindingSource.DataMember = "new_arrival";
            this.newarrivalBindingSource.DataSource = this.mobileshopDataSet6;
            // 
            // mobileshopDataSet6
            // 
            this.mobileshopDataSet6.DataSetName = "mobileshopDataSet6";
            this.mobileshopDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // new_arrivalTableAdapter
            // 
            this.new_arrivalTableAdapter.ClearBeforeFill = true;
            // 
            // arrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1581, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "arrive";
            this.Text = "arrive";
            this.Load += new System.EventHandler(this.arrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newarrivalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileshopDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mobileshopDataSet6 mobileshopDataSet6;
        private System.Windows.Forms.BindingSource newarrivalBindingSource;
        private mobileshopDataSet6TableAdapters.new_arrivalTableAdapter new_arrivalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istorageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estorageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realcameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frontcamearaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingertouchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}