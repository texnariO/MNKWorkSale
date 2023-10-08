namespace MNKWorkSale.Fragments
{
    partial class FavoriteUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateFileForOptima = new System.Windows.Forms.Button();
            this.btnCreateFileSpecyfikacja = new System.Windows.Forms.Button();
            this.btnCutFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFileForOptima
            // 
            this.btnCreateFileForOptima.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateFileForOptima.Location = new System.Drawing.Point(23, 36);
            this.btnCreateFileForOptima.Name = "btnCreateFileForOptima";
            this.btnCreateFileForOptima.Size = new System.Drawing.Size(283, 54);
            this.btnCreateFileForOptima.TabIndex = 1;
            this.btnCreateFileForOptima.Text = "Файл Оптіма";
            this.btnCreateFileForOptima.UseVisualStyleBackColor = true;
            this.btnCreateFileForOptima.Click += new System.EventHandler(this.btnCreateFileForOptima_Click);
            // 
            // btnCreateFileSpecyfikacja
            // 
            this.btnCreateFileSpecyfikacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateFileSpecyfikacja.Location = new System.Drawing.Point(363, 36);
            this.btnCreateFileSpecyfikacja.Name = "btnCreateFileSpecyfikacja";
            this.btnCreateFileSpecyfikacja.Size = new System.Drawing.Size(283, 54);
            this.btnCreateFileSpecyfikacja.TabIndex = 2;
            this.btnCreateFileSpecyfikacja.Text = "Специфікація";
            this.btnCreateFileSpecyfikacja.UseVisualStyleBackColor = true;
            this.btnCreateFileSpecyfikacja.Click += new System.EventHandler(this.btnCreateFileSpecyfikacja_Click);
            // 
            // btnCutFile
            // 
            this.btnCutFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCutFile.Location = new System.Drawing.Point(194, 118);
            this.btnCutFile.Name = "btnCutFile";
            this.btnCutFile.Size = new System.Drawing.Size(283, 54);
            this.btnCutFile.TabIndex = 3;
            this.btnCutFile.Text = "Розрізати Файл";
            this.btnCutFile.UseVisualStyleBackColor = true;
            this.btnCutFile.Click += new System.EventHandler(this.btnCutFile_Click);
            // 
            // FavoriteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCutFile);
            this.Controls.Add(this.btnCreateFileSpecyfikacja);
            this.Controls.Add(this.btnCreateFileForOptima);
            this.Name = "FavoriteUserControl";
            this.Size = new System.Drawing.Size(673, 377);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFileForOptima;
        private System.Windows.Forms.Button btnCreateFileSpecyfikacja;
        private System.Windows.Forms.Button btnCutFile;
    }
}
