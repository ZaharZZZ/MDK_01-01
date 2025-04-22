namespace LR3
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
            this.ListB_group = new System.Windows.Forms.Label();
            this.listBox_groups = new System.Windows.Forms.ListBox();
            this.button_AddToZakaz = new System.Windows.Forms.Button();
            this.SelectionPanel_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListB_group
            // 
            this.ListB_group.AutoSize = true;
            this.ListB_group.Location = new System.Drawing.Point(6, 23);
            this.ListB_group.Name = "ListB_group";
            this.ListB_group.Size = new System.Drawing.Size(75, 13);
            this.ListB_group.TabIndex = 2;
            this.ListB_group.Text = "Список групп";
            // 
            // listBox_groups
            // 
            this.listBox_groups.FormattingEnabled = true;
            this.listBox_groups.Location = new System.Drawing.Point(6, 39);
            this.listBox_groups.Name = "listBox_groups";
            this.listBox_groups.Size = new System.Drawing.Size(120, 95);
            this.listBox_groups.TabIndex = 3;
            this.listBox_groups.SelectedIndexChanged += new System.EventHandler(this.listBox_groups_SelectedIndexChanged);
            // 
            // button_AddToZakaz
            // 
            this.button_AddToZakaz.Location = new System.Drawing.Point(6, 238);
            this.button_AddToZakaz.Name = "button_AddToZakaz";
            this.button_AddToZakaz.Size = new System.Drawing.Size(120, 38);
            this.button_AddToZakaz.TabIndex = 4;
            this.button_AddToZakaz.Text = "Добавить в заказ";
            this.button_AddToZakaz.UseVisualStyleBackColor = true;
            this.button_AddToZakaz.Click += new System.EventHandler(this.button_AddToZakaz_Click);
            // 
            // SelectionPanel_flowLayoutPanel
            // 
            this.SelectionPanel_flowLayoutPanel.Location = new System.Drawing.Point(158, 39);
            this.SelectionPanel_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SelectionPanel_flowLayoutPanel.Name = "SelectionPanel_flowLayoutPanel";
            this.SelectionPanel_flowLayoutPanel.Size = new System.Drawing.Size(172, 94);
            this.SelectionPanel_flowLayoutPanel.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Location = new System.Drawing.Point(468, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(262, 334);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_groups);
            this.groupBox1.Controls.Add(this.ListB_group);
            this.groupBox1.Controls.Add(this.button_AddToZakaz);
            this.groupBox1.Controls.Add(this.SelectionPanel_flowLayoutPanel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 282);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оформление заказа";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainForm";
            this.Text = "Ресторан Х";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ListB_group;
        private System.Windows.Forms.ListBox listBox_groups;
        private System.Windows.Forms.Button button_AddToZakaz;
        private System.Windows.Forms.FlowLayoutPanel SelectionPanel_flowLayoutPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

