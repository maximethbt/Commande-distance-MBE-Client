namespace Commande_distance_MBE_Client
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Response = new System.Windows.Forms.Label();
            this.button_Screenshot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.pictureBox_Screenshot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Response
            // 
            this.Label_Response.AutoSize = true;
            this.Label_Response.Location = new System.Drawing.Point(425, 173);
            this.Label_Response.Name = "Label_Response";
            this.Label_Response.Size = new System.Drawing.Size(0, 16);
            this.Label_Response.TabIndex = 1;
            // 
            // button_Screenshot
            // 
            this.button_Screenshot.Location = new System.Drawing.Point(12, 415);
            this.button_Screenshot.Name = "button_Screenshot";
            this.button_Screenshot.Size = new System.Drawing.Size(113, 23);
            this.button_Screenshot.TabIndex = 3;
            this.button_Screenshot.Text = "Screenshot";
            this.button_Screenshot.UseVisualStyleBackColor = true;
            this.button_Screenshot.Click += new System.EventHandler(this.button_Screenshot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status : ";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(22, 142);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 16);
            this.label_Status.TabIndex = 5;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(12, 238);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 22);
            this.textBox_IP.TabIndex = 6;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(12, 303);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 22);
            this.textBox_Port.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(25, 353);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 10;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // pictureBox_Screenshot
            // 
            this.pictureBox_Screenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Screenshot.Location = new System.Drawing.Point(120, 2);
            this.pictureBox_Screenshot.Name = "pictureBox_Screenshot";
            this.pictureBox_Screenshot.Size = new System.Drawing.Size(682, 449);
            this.pictureBox_Screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Screenshot.TabIndex = 11;
            this.pictureBox_Screenshot.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_Screenshot);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Screenshot);
            this.Controls.Add(this.Label_Response);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Response;
        private System.Windows.Forms.Button button_Screenshot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.PictureBox pictureBox_Screenshot;
    }
}

