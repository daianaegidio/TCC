namespace DeteccaoMovimento
{
    partial class Camera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cameraConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dispositivos = new System.Windows.Forms.GroupBox();
            this.nomeDispositivo = new System.Windows.Forms.Label();
            this.gerenciarCamera = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cameraConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.dispositivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraConfig
            // 
            this.cameraConfig.Controls.Add(this.tabPage1);
            this.cameraConfig.Controls.Add(this.tabPage2);
            this.cameraConfig.Location = new System.Drawing.Point(-1, 0);
            this.cameraConfig.Name = "cameraConfig";
            this.cameraConfig.SelectedIndex = 0;
            this.cameraConfig.Size = new System.Drawing.Size(480, 303);
            this.cameraConfig.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dispositivos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dispositivos
            // 
            this.dispositivos.Controls.Add(this.gerenciarCamera);
            this.dispositivos.Controls.Add(this.nomeDispositivo);
            this.dispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispositivos.Location = new System.Drawing.Point(21, 19);
            this.dispositivos.Name = "dispositivos";
            this.dispositivos.Size = new System.Drawing.Size(428, 127);
            this.dispositivos.TabIndex = 0;
            this.dispositivos.TabStop = false;
            this.dispositivos.Text = "Dispositivos";
            // 
            // nomeDispositivo
            // 
            this.nomeDispositivo.AutoSize = true;
            this.nomeDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDispositivo.Location = new System.Drawing.Point(31, 55);
            this.nomeDispositivo.Name = "nomeDispositivo";
            this.nomeDispositivo.Size = new System.Drawing.Size(48, 16);
            this.nomeDispositivo.TabIndex = 0;
            this.nomeDispositivo.Text = "Nome:";
            // 
            // gerenciarCamera
            // 
            this.gerenciarCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gerenciarCamera.FormattingEnabled = true;
            this.gerenciarCamera.Location = new System.Drawing.Point(105, 45);
            this.gerenciarCamera.Name = "gerenciarCamera";
            this.gerenciarCamera.Size = new System.Drawing.Size(294, 26);
            this.gerenciarCamera.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(367, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 348);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cameraConfig);
            this.Name = "Camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câmera";
            this.Load += new System.EventHandler(this.Camera_Load);
            this.cameraConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.dispositivos.ResumeLayout(false);
            this.dispositivos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl cameraConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox dispositivos;
        private System.Windows.Forms.ComboBox gerenciarCamera;
        private System.Windows.Forms.Label nomeDispositivo;
        private System.Windows.Forms.Button btnOK;
    }
}