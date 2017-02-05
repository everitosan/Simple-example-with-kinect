namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Status = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionText = new System.Windows.Forms.Label();
            this.TriggerBtn = new System.Windows.Forms.Button();
            this.streamBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.streamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(38, 52);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(79, 25);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status:";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(137, 52);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(19, 25);
            this.statusText.TabIndex = 1;
            this.statusText.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection Id: ";
            // 
            // connectionText
            // 
            this.connectionText.AutoSize = true;
            this.connectionText.Location = new System.Drawing.Point(217, 103);
            this.connectionText.Name = "connectionText";
            this.connectionText.Size = new System.Drawing.Size(19, 25);
            this.connectionText.TabIndex = 3;
            this.connectionText.Text = "-";
            // 
            // TriggerBtn
            // 
            this.TriggerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TriggerBtn.Location = new System.Drawing.Point(32, 257);
            this.TriggerBtn.Name = "TriggerBtn";
            this.TriggerBtn.Size = new System.Drawing.Size(144, 41);
            this.TriggerBtn.TabIndex = 4;
            this.TriggerBtn.Text = "Stream";
            this.TriggerBtn.UseVisualStyleBackColor = true;
            this.TriggerBtn.Click += new System.EventHandler(this.TriggerBtn_Click);
            // 
            // streamBox
            // 
            this.streamBox.Location = new System.Drawing.Point(32, 328);
            this.streamBox.Name = "streamBox";
            this.streamBox.Size = new System.Drawing.Size(1500, 626);
            this.streamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.streamBox.TabIndex = 5;
            this.streamBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Posición:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(153, 162);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(19, 25);
            this.position.TabIndex = 7;
            this.position.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 998);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.streamBox);
            this.Controls.Add(this.TriggerBtn);
            this.Controls.Add(this.connectionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.Status);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.streamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label connectionText;
        private System.Windows.Forms.Button TriggerBtn;
        private System.Windows.Forms.PictureBox streamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label position;
    }
}

