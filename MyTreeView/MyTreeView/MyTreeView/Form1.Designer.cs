namespace MyTreeView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeViewCar = new System.Windows.Forms.TreeView();
            this.Table = new System.Windows.Forms.DataGridView();
            this.NameCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engine_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewCar
            // 
            this.TreeViewCar.Location = new System.Drawing.Point(12, 12);
            this.TreeViewCar.Name = "TreeViewCar";
            this.TreeViewCar.Size = new System.Drawing.Size(377, 400);
            this.TreeViewCar.TabIndex = 0;
            this.TreeViewCar.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewCar_NodeMouseDoubleClick);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCar,
            this.release_date,
            this.engine_capacity});
            this.Table.Location = new System.Drawing.Point(408, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(364, 249);
            this.Table.TabIndex = 1;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // NameCar
            // 
            this.NameCar.HeaderText = "Название";
            this.NameCar.Name = "NameCar";
            // 
            // release_date
            // 
            this.release_date.HeaderText = "Дата_выпуска";
            this.release_date.Name = "release_date";
            // 
            // engine_capacity
            // 
            this.engine_capacity.HeaderText = "Объём_двигатля";
            this.engine_capacity.Name = "engine_capacity";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.TreeViewCar);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewCar;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn release_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn engine_capacity;
    }
}

