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
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Response = new System.Windows.Forms.Label();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Response : ";
            // 
            // Label_Response
            // 
            this.Label_Response.AutoSize = true;
            this.Label_Response.Location = new System.Drawing.Point(425, 173);
            this.Label_Response.Name = "Label_Response";
            this.Label_Response.Size = new System.Drawing.Size(0, 16);
            this.Label_Response.TabIndex = 1;
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(116, 117);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(100, 22);
            this.textBox_Message.TabIndex = 2;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(116, 166);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status : ";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(296, 173);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 16);
            this.label_Status.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.Label_Response);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Response;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
    }
}

