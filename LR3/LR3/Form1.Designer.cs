namespace LR3
{
    partial class Form1
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
            this.comboBoxMenuGroups = new System.Windows.Forms.ComboBox();
            this.checkedListBoxMenuItems = new System.Windows.Forms.CheckedListBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxMenuGroups
            // 
            this.comboBoxMenuGroups.FormattingEnabled = true;
            this.comboBoxMenuGroups.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMenuGroups.Name = "comboBoxMenuGroups";
            this.comboBoxMenuGroups.Size = new System.Drawing.Size(136, 21);
            this.comboBoxMenuGroups.TabIndex = 0;
            this.comboBoxMenuGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenuGroups_SelectedIndexChanged);
            // 
            // checkedListBoxMenuItems
            // 
            this.checkedListBoxMenuItems.FormattingEnabled = true;
            this.checkedListBoxMenuItems.Location = new System.Drawing.Point(12, 39);
            this.checkedListBoxMenuItems.Name = "checkedListBoxMenuItems";
            this.checkedListBoxMenuItems.Size = new System.Drawing.Size(253, 139);
            this.checkedListBoxMenuItems.TabIndex = 1;
            this.checkedListBoxMenuItems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxMenuItems_ItemCheck);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(12, 184);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(326, 23);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "button1";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(566, 12);
            this.textBoxOrder.Multiline = true;
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.ReadOnly = true;
            this.textBoxOrder.Size = new System.Drawing.Size(222, 426);
            this.textBoxOrder.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.checkedListBoxMenuItems);
            this.Controls.Add(this.comboBoxMenuGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMenuGroups;
        private System.Windows.Forms.CheckedListBox checkedListBoxMenuItems;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxOrder;
    }
}

