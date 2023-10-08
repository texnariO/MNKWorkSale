namespace MNKWorkSale.Fragments.EMEX
{
    partial class FragmentFileOptimaClientEMEX
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPositions = new System.Windows.Forms.Label();
            this.labelCounts = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxWritePrice = new System.Windows.Forms.TextBox();
            this.textBoxWriteCounts = new System.Windows.Forms.TextBox();
            this.textBoxWritePositions = new System.Windows.Forms.TextBox();
            this.btnChooseFileForWork = new System.Windows.Forms.Button();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(186, 34);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Файл для Оптіми";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(61, 68);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(186, 34);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Ціна:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPositions
            // 
            this.labelPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPositions.Location = new System.Drawing.Point(61, 118);
            this.labelPositions.Name = "labelPositions";
            this.labelPositions.Size = new System.Drawing.Size(186, 34);
            this.labelPositions.TabIndex = 2;
            this.labelPositions.Text = "Позиції:";
            this.labelPositions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCounts
            // 
            this.labelCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounts.Location = new System.Drawing.Point(61, 165);
            this.labelCounts.Name = "labelCounts";
            this.labelCounts.Size = new System.Drawing.Size(186, 34);
            this.labelCounts.TabIndex = 3;
            this.labelCounts.Text = "Штуки:";
            this.labelCounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(2, 283);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(668, 65);
            this.labelError.TabIndex = 4;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWritePrice
            // 
            this.textBoxWritePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWritePrice.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxWritePrice.Location = new System.Drawing.Point(291, 68);
            this.textBoxWritePrice.Multiline = true;
            this.textBoxWritePrice.Name = "textBoxWritePrice";
            this.textBoxWritePrice.Size = new System.Drawing.Size(132, 34);
            this.textBoxWritePrice.TabIndex = 5;
            // 
            // textBoxWriteCounts
            // 
            this.textBoxWriteCounts.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxWriteCounts.Location = new System.Drawing.Point(291, 165);
            this.textBoxWriteCounts.Multiline = true;
            this.textBoxWriteCounts.Name = "textBoxWriteCounts";
            this.textBoxWriteCounts.Size = new System.Drawing.Size(132, 34);
            this.textBoxWriteCounts.TabIndex = 6;
            // 
            // textBoxWritePositions
            // 
            this.textBoxWritePositions.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxWritePositions.Location = new System.Drawing.Point(291, 118);
            this.textBoxWritePositions.Multiline = true;
            this.textBoxWritePositions.Name = "textBoxWritePositions";
            this.textBoxWritePositions.Size = new System.Drawing.Size(132, 34);
            this.textBoxWritePositions.TabIndex = 7;
            // 
            // btnChooseFileForWork
            // 
            this.btnChooseFileForWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFileForWork.Location = new System.Drawing.Point(265, 216);
            this.btnChooseFileForWork.Name = "btnChooseFileForWork";
            this.btnChooseFileForWork.Size = new System.Drawing.Size(186, 34);
            this.btnChooseFileForWork.TabIndex = 8;
            this.btnChooseFileForWork.Text = "Файл";
            this.btnChooseFileForWork.UseVisualStyleBackColor = true;
            this.btnChooseFileForWork.Click += new System.EventHandler(this.btnChooseFileForWork_Click);
            // 
            // btnStartWork
            // 
            this.btnStartWork.Location = new System.Drawing.Point(558, 252);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(97, 28);
            this.btnStartWork.TabIndex = 9;
            this.btnStartWork.Text = "Почати роботу";
            this.btnStartWork.UseVisualStyleBackColor = true;
            this.btnStartWork.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // FragmentFileOptimaClientEMEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStartWork);
            this.Controls.Add(this.btnChooseFileForWork);
            this.Controls.Add(this.textBoxWritePositions);
            this.Controls.Add(this.textBoxWriteCounts);
            this.Controls.Add(this.textBoxWritePrice);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelCounts);
            this.Controls.Add(this.labelPositions);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "FragmentFileOptimaClientEMEX";
            this.Size = new System.Drawing.Size(673, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPositions;
        private System.Windows.Forms.Label labelCounts;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxWritePrice;
        private System.Windows.Forms.TextBox textBoxWriteCounts;
        private System.Windows.Forms.TextBox textBoxWritePositions;
        private System.Windows.Forms.Button btnChooseFileForWork;
        private System.Windows.Forms.Button btnStartWork;
    }
}
