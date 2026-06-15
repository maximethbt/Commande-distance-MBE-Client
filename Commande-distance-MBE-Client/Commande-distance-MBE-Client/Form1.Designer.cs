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
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.pictureBox_Screenshot = new System.Windows.Forms.PictureBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.comboBox_Ecrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DossierReception = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screenshot)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status : ";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(119, 9);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 16);
            this.label_Status.TabIndex = 5;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(38, 58);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 22);
            this.textBox_IP.TabIndex = 6;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(38, 123);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 22);
            this.textBox_Port.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(51, 173);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 10;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // pictureBox_Screenshot
            // 
            this.pictureBox_Screenshot.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Screenshot.Name = "pictureBox_Screenshot";
            this.pictureBox_Screenshot.Size = new System.Drawing.Size(903, 425);
            this.pictureBox_Screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Screenshot.TabIndex = 11;
            this.pictureBox_Screenshot.TabStop = false;
            this.pictureBox_Screenshot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Screenshot_MouseDown);
            this.pictureBox_Screenshot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Screenshot_MouseMove);
            this.pictureBox_Screenshot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Screenshot_MouseUp);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.button_DossierReception);
            this.splitContainerMain.Panel1.Controls.Add(this.comboBox_Ecrans);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            this.splitContainerMain.Panel1.Controls.Add(this.textBox_IP);
            this.splitContainerMain.Panel1.Controls.Add(this.button_Connect);
            this.splitContainerMain.Panel1.Controls.Add(this.label2);
            this.splitContainerMain.Panel1.Controls.Add(this.label4);
            this.splitContainerMain.Panel1.Controls.Add(this.label_Status);
            this.splitContainerMain.Panel1.Controls.Add(this.label3);
            this.splitContainerMain.Panel1.Controls.Add(this.textBox_Port);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pictureBox_Screenshot);
            this.splitContainerMain.Panel2.SizeChanged += new System.EventHandler(this.splitContainerMain_Panel2_SizeChanged);
            this.splitContainerMain.Size = new System.Drawing.Size(1139, 450);
            this.splitContainerMain.SplitterDistance = 208;
            this.splitContainerMain.TabIndex = 12;
            // 
            // comboBox_Ecrans
            // 
            this.comboBox_Ecrans.FormattingEnabled = true;
            this.comboBox_Ecrans.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_Ecrans.Location = new System.Drawing.Point(38, 242);
            this.comboBox_Ecrans.Name = "comboBox_Ecrans";
            this.comboBox_Ecrans.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Ecrans.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ecran";
            // 
            // button_DossierReception
            // 
            this.button_DossierReception.Location = new System.Drawing.Point(41, 354);
            this.button_DossierReception.Name = "button_DossierReception";
            this.button_DossierReception.Size = new System.Drawing.Size(107, 42);
            this.button_DossierReception.TabIndex = 13;
            this.button_DossierReception.Text = "Select receiving file";
            this.button_DossierReception.UseVisualStyleBackColor = true;
            this.button_DossierReception.Click += new System.EventHandler(this.button_DossierReception_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.Label_Response);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screenshot)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Response;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.PictureBox pictureBox_Screenshot;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ComboBox comboBox_Ecrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DossierReception;
    }
}

