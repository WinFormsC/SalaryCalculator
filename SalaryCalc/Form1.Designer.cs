
namespace SalaryCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addSalary = new System.Windows.Forms.Button();
            this.editSalary = new System.Windows.Forms.Button();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.listSalaries = new System.Windows.Forms.ListBox();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSalary
            // 
            this.addSalary.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSalary.Location = new System.Drawing.Point(18, 248);
            this.addSalary.Name = "addSalary";
            this.addSalary.Size = new System.Drawing.Size(254, 25);
            this.addSalary.TabIndex = 0;
            this.addSalary.Text = "Добавить";
            this.addSalary.UseVisualStyleBackColor = true;
            this.addSalary.Click += new System.EventHandler(this.addSalary_Click);
            // 
            // editSalary
            // 
            this.editSalary.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSalary.Location = new System.Drawing.Point(158, 208);
            this.editSalary.Name = "editSalary";
            this.editSalary.Size = new System.Drawing.Size(114, 25);
            this.editSalary.TabIndex = 1;
            this.editSalary.Text = "Редактировать";
            this.editSalary.UseVisualStyleBackColor = true;
            this.editSalary.Click += new System.EventHandler(this.editSalary_Click);
            // 
            // picture2
            // 
            this.picture2.Image = global::SalaryCalc.Properties.Resources.money2;
            this.picture2.Location = new System.Drawing.Point(12, 275);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(260, 267);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 3;
            this.picture2.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.Image = global::SalaryCalc.Properties.Resources.money;
            this.picture1.Location = new System.Drawing.Point(278, 2);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(254, 190);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 2;
            this.picture1.TabStop = false;
            // 
            // listSalaries
            // 
            this.listSalaries.FormattingEnabled = true;
            this.listSalaries.Location = new System.Drawing.Point(18, 71);
            this.listSalaries.Name = "listSalaries";
            this.listSalaries.Size = new System.Drawing.Size(254, 121);
            this.listSalaries.TabIndex = 4;
            // 
            // salaryText
            // 
            this.salaryText.Location = new System.Drawing.Point(90, 45);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(182, 20);
            this.salaryText.TabIndex = 5;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(90, 16);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(182, 20);
            this.surnameText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Зарплата:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(18, 208);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 25);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удалить";
            this.delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.listResult);
            this.groupBox.Location = new System.Drawing.Point(278, 284);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(254, 241);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Итог:";
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAll.Location = new System.Drawing.Point(278, 210);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(254, 23);
            this.clearAll.TabIndex = 11;
            this.clearAll.Text = "Очистить все";
            this.clearAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(278, 248);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(254, 25);
            this.save.TabIndex = 12;
            this.save.Text = "Сохранить в result.txt";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(6, 19);
            this.listResult.Name = "listResult";
            this.listResult.ScrollAlwaysVisible = true;
            this.listResult.Size = new System.Drawing.Size(242, 212);
            this.listResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 530);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.listSalaries);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.editSalary);
            this.Controls.Add(this.addSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсчет зарплаты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSalary;
        private System.Windows.Forms.Button editSalary;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.ListBox listSalaries;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listResult;
    }
}

