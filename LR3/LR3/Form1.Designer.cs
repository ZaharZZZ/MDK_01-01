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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMenuGroups
            // 
            this.comboBoxMenuGroups.FormattingEnabled = true;
            this.comboBoxMenuGroups.Location = new System.Drawing.Point(9, 32);
            this.comboBoxMenuGroups.Name = "comboBoxMenuGroups";
            this.comboBoxMenuGroups.Size = new System.Drawing.Size(136, 21);
            this.comboBoxMenuGroups.TabIndex = 0;
            this.comboBoxMenuGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenuGroups_SelectedIndexChanged);
            // 
            // checkedListBoxMenuItems
            // 
            this.checkedListBoxMenuItems.FormattingEnabled = true;
            this.checkedListBoxMenuItems.Location = new System.Drawing.Point(9, 84);
            this.checkedListBoxMenuItems.Name = "checkedListBoxMenuItems";
            this.checkedListBoxMenuItems.Size = new System.Drawing.Size(253, 139);
            this.checkedListBoxMenuItems.TabIndex = 1;
            this.checkedListBoxMenuItems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxMenuItems_ItemCheck);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(9, 229);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(124, 50);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrder.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrder.Location = new System.Drawing.Point(422, 0);
            this.textBoxOrder.Multiline = true;
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.ReadOnly = true;
            this.textBoxOrder.Size = new System.Drawing.Size(378, 450);
            this.textBoxOrder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбор позиции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Блюдо";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonOrder);
            this.groupBox1.Controls.Add(this.comboBoxMenuGroups);
            this.groupBox1.Controls.Add(this.checkedListBoxMenuItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 450);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxOrder);
            this.Name = "Form1";
            this.Text = "Ресторан Х";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMenuGroups;
        private System.Windows.Forms.CheckedListBox checkedListBoxMenuItems;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

