namespace MyCalculator
{
    partial class ScientificBoard
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
            this.buttonX2 = new System.Windows.Forms.Button();
            this.buttonSq = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonOpenSkob = new System.Windows.Forms.Button();
            this.buttonCloseSkob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonX2
            // 
            this.buttonX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonX2.FlatAppearance.BorderSize = 0;
            this.buttonX2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonX2.ForeColor = System.Drawing.Color.White;
            this.buttonX2.Location = new System.Drawing.Point(365, 1);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(85, 75);
            this.buttonX2.TabIndex = 15;
            this.buttonX2.Text = "x²";
            this.buttonX2.UseVisualStyleBackColor = false;
            this.buttonX2.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSq
            // 
            this.buttonSq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSq.FlatAppearance.BorderSize = 0;
            this.buttonSq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonSq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSq.ForeColor = System.Drawing.Color.White;
            this.buttonSq.Location = new System.Drawing.Point(274, 1);
            this.buttonSq.Name = "buttonSq";
            this.buttonSq.Size = new System.Drawing.Size(85, 75);
            this.buttonSq.TabIndex = 14;
            this.buttonSq.Text = "√";
            this.buttonSq.UseVisualStyleBackColor = false;
            this.buttonSq.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPercent.FlatAppearance.BorderSize = 0;
            this.buttonPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPercent.ForeColor = System.Drawing.Color.White;
            this.buttonPercent.Location = new System.Drawing.Point(183, 1);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(85, 75);
            this.buttonPercent.TabIndex = 13;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonOpenSkob
            // 
            this.buttonOpenSkob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpenSkob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOpenSkob.FlatAppearance.BorderSize = 0;
            this.buttonOpenSkob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonOpenSkob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSkob.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSkob.ForeColor = System.Drawing.Color.White;
            this.buttonOpenSkob.Location = new System.Drawing.Point(1, 1);
            this.buttonOpenSkob.Name = "buttonOpenSkob";
            this.buttonOpenSkob.Size = new System.Drawing.Size(85, 75);
            this.buttonOpenSkob.TabIndex = 12;
            this.buttonOpenSkob.Text = "(";
            this.buttonOpenSkob.UseVisualStyleBackColor = false;
            this.buttonOpenSkob.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonCloseSkob
            // 
            this.buttonCloseSkob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCloseSkob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCloseSkob.FlatAppearance.BorderSize = 0;
            this.buttonCloseSkob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonCloseSkob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseSkob.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseSkob.ForeColor = System.Drawing.Color.White;
            this.buttonCloseSkob.Location = new System.Drawing.Point(92, 1);
            this.buttonCloseSkob.Name = "buttonCloseSkob";
            this.buttonCloseSkob.Size = new System.Drawing.Size(85, 75);
            this.buttonCloseSkob.TabIndex = 11;
            this.buttonCloseSkob.Text = ")";
            this.buttonCloseSkob.UseVisualStyleBackColor = false;
            this.buttonCloseSkob.Click += new System.EventHandler(this.button_Click);
            // 
            // ScientificBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonSq);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonOpenSkob);
            this.Controls.Add(this.buttonCloseSkob);
            this.Name = "ScientificBoard";
            this.Size = new System.Drawing.Size(452, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonX2;
        private System.Windows.Forms.Button buttonSq;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonOpenSkob;
        private System.Windows.Forms.Button buttonCloseSkob;
    }
}
