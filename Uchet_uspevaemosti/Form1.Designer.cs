namespace Uchet_uspevaemosti
{
    partial class Attestachia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attestachia));
            this.dataGridViewAttest = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.УчителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddAtt = new System.Windows.Forms.Button();
            this.buttonEditAtt = new System.Windows.Forms.Button();
            this.buttonDelAtt = new System.Windows.Forms.Button();
            this.uсhet_uspevaemostiDataSet = new Uchet_uspevaemosti.Uсhet_uspevaemostiDataSet();
            this.attestachiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attestachiaTableAdapter = new Uchet_uspevaemosti.Uсhet_uspevaemostiDataSetTableAdapters.AttestachiaTableAdapter();
            this.textBoxDelAtt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttest)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uсhet_uspevaemostiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attestachiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAttest
            // 
            this.dataGridViewAttest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttest.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewAttest.Name = "dataGridViewAttest";
            this.dataGridViewAttest.Size = new System.Drawing.Size(431, 185);
            this.dataGridViewAttest.TabIndex = 0;
            this.dataGridViewAttest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAttest_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.УчителяToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // УчителяToolStripMenuItem
            // 
            this.УчителяToolStripMenuItem.Name = "УчителяToolStripMenuItem";
            this.УчителяToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.УчителяToolStripMenuItem.Text = "Учителя";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // buttonAddAtt
            // 
            this.buttonAddAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAtt.Location = new System.Drawing.Point(449, 84);
            this.buttonAddAtt.Name = "buttonAddAtt";
            this.buttonAddAtt.Size = new System.Drawing.Size(98, 31);
            this.buttonAddAtt.TabIndex = 2;
            this.buttonAddAtt.Text = "Добавить";
            this.buttonAddAtt.UseVisualStyleBackColor = true;
            // 
            // buttonEditAtt
            // 
            this.buttonEditAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditAtt.Location = new System.Drawing.Point(449, 121);
            this.buttonEditAtt.Name = "buttonEditAtt";
            this.buttonEditAtt.Size = new System.Drawing.Size(98, 29);
            this.buttonEditAtt.TabIndex = 3;
            this.buttonEditAtt.Text = "Изменить";
            this.buttonEditAtt.UseVisualStyleBackColor = true;
            // 
            // buttonDelAtt
            // 
            this.buttonDelAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelAtt.Location = new System.Drawing.Point(449, 156);
            this.buttonDelAtt.Name = "buttonDelAtt";
            this.buttonDelAtt.Size = new System.Drawing.Size(98, 29);
            this.buttonDelAtt.TabIndex = 4;
            this.buttonDelAtt.Text = "Удалить";
            this.buttonDelAtt.UseVisualStyleBackColor = true;
            this.buttonDelAtt.Click += new System.EventHandler(this.buttonDelAtt_Click);
            // 
            // uсhet_uspevaemostiDataSet
            // 
            this.uсhet_uspevaemostiDataSet.DataSetName = "Uсhet_uspevaemostiDataSet";
            this.uсhet_uspevaemostiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attestachiaBindingSource
            // 
            this.attestachiaBindingSource.DataMember = "Attestachia";
            this.attestachiaBindingSource.DataSource = this.uсhet_uspevaemostiDataSet;
            // 
            // attestachiaTableAdapter
            // 
            this.attestachiaTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxDelAtt
            // 
            this.textBoxDelAtt.Location = new System.Drawing.Point(641, 102);
            this.textBoxDelAtt.Name = "textBoxDelAtt";
            this.textBoxDelAtt.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelAtt.TabIndex = 5;
            // 
            // Attestachia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 241);
            this.Controls.Add(this.textBoxDelAtt);
            this.Controls.Add(this.buttonDelAtt);
            this.Controls.Add(this.buttonEditAtt);
            this.Controls.Add(this.buttonAddAtt);
            this.Controls.Add(this.dataGridViewAttest);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Attestachia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аттестация";
            this.Load += new System.EventHandler(this.Attestachia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttest)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uсhet_uspevaemostiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attestachiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem УчителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddAtt;
        private System.Windows.Forms.Button buttonEditAtt;
        private System.Windows.Forms.Button buttonDelAtt;
        private Uсhet_uspevaemostiDataSet uсhet_uspevaemostiDataSet;
        private System.Windows.Forms.BindingSource attestachiaBindingSource;
        private Uсhet_uspevaemostiDataSetTableAdapters.AttestachiaTableAdapter attestachiaTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewAttest;
        private System.Windows.Forms.TextBox textBoxDelAtt;
    }
}

