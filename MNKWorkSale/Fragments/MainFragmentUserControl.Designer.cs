namespace MNKWorkSale.Fragments
{
    partial class MainFragmentUserControl
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
            this.buttonFirstClient = new System.Windows.Forms.Button();
            this.buttonSecondClient = new System.Windows.Forms.Button();
            this.panelMainFragment = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonFirstClient
            // 
            this.buttonFirstClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirstClient.Location = new System.Drawing.Point(33, 37);
            this.buttonFirstClient.Name = "buttonFirstClient";
            this.buttonFirstClient.Size = new System.Drawing.Size(187, 121);
            this.buttonFirstClient.TabIndex = 0;
            this.buttonFirstClient.Text = "EMEX";
            this.buttonFirstClient.UseVisualStyleBackColor = true;
            this.buttonFirstClient.Click += new System.EventHandler(this.buttonFirstClient_Click);
            // 
            // buttonSecondClient
            // 
            this.buttonSecondClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSecondClient.Location = new System.Drawing.Point(454, 37);
            this.buttonSecondClient.Name = "buttonSecondClient";
            this.buttonSecondClient.Size = new System.Drawing.Size(187, 121);
            this.buttonSecondClient.TabIndex = 1;
            this.buttonSecondClient.Text = "Favorite";
            this.buttonSecondClient.UseVisualStyleBackColor = true;
            this.buttonSecondClient.Click += new System.EventHandler(this.buttonSecondClient_Click);
            // 
            // panelMainFragment
            // 
            this.panelMainFragment.Location = new System.Drawing.Point(0, 164);
            this.panelMainFragment.Name = "panelMainFragment";
            this.panelMainFragment.Size = new System.Drawing.Size(673, 377);
            this.panelMainFragment.TabIndex = 2;
            // 
            // MainFragmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainFragment);
            this.Controls.Add(this.buttonSecondClient);
            this.Controls.Add(this.buttonFirstClient);
            this.Name = "MainFragmentUserControl";
            this.Size = new System.Drawing.Size(673, 541);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFirstClient;
        private System.Windows.Forms.Button buttonSecondClient;
        private System.Windows.Forms.Panel panelMainFragment;
    }
}
