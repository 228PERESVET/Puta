namespace PERESVET228
{
    partial class FormMain
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
            this.pb_main = new System.Windows.Forms.PictureBox();
            this.lb_sizeImg = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.tb_ipport = new System.Windows.Forms.TextBox();
            this.lb_ipport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_main
            // 
            this.pb_main.Location = new System.Drawing.Point(12, 12);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(615, 379);
            this.pb_main.TabIndex = 0;
            this.pb_main.TabStop = false;
            // 
            // lb_sizeImg
            // 
            this.lb_sizeImg.AutoSize = true;
            this.lb_sizeImg.Location = new System.Drawing.Point(12, 397);
            this.lb_sizeImg.Name = "lb_sizeImg";
            this.lb_sizeImg.Size = new System.Drawing.Size(30, 17);
            this.lb_sizeImg.TabIndex = 1;
            this.lb_sizeImg.Text = "0x0";
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(552, 460);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 28);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // tb_ipport
            // 
            this.tb_ipport.Location = new System.Drawing.Point(361, 463);
            this.tb_ipport.Name = "tb_ipport";
            this.tb_ipport.Size = new System.Drawing.Size(148, 22);
            this.tb_ipport.TabIndex = 3;
            this.tb_ipport.Text = "127.0.0.1:8228";
            // 
            // lb_ipport
            // 
            this.lb_ipport.AutoSize = true;
            this.lb_ipport.Location = new System.Drawing.Point(292, 466);
            this.lb_ipport.Name = "lb_ipport";
            this.lb_ipport.Size = new System.Drawing.Size(63, 17);
            this.lb_ipport.TabIndex = 4;
            this.lb_ipport.Text = "IP:PORT";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 500);
            this.Controls.Add(this.lb_ipport);
            this.Controls.Add(this.tb_ipport);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.lb_sizeImg);
            this.Controls.Add(this.pb_main);
            this.Name = "FormMain";
            this.Text = "PERESVET228";
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_main;
        private System.Windows.Forms.Label lb_sizeImg;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.TextBox tb_ipport;
        private System.Windows.Forms.Label lb_ipport;
    }
}

