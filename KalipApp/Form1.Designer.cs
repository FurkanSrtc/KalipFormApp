namespace KalipApp
{
    partial class Form1
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
            this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ambiance_CheckBox1 = new Ambiance.Ambiance_CheckBox();
            this.ambiance_ControlBox1 = new Ambiance.Ambiance_ControlBox();
            this.ambiance_Button_21 = new Ambiance.Ambiance_Button_2();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.txtPass = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.txt_username = new Ambiance.Ambiance_TextBox();
            this.ambiance_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.pictureBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_CheckBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_ControlBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Button_21);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label2);
            this.ambiance_ThemeContainer1.Controls.Add(this.txtPass);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label3);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label1);
            this.ambiance_ThemeContainer1.Controls.Add(this.txt_username);
            this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
            this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambiance_ThemeContainer1.RoundCorners = true;
            this.ambiance_ThemeContainer1.Sizable = true;
            this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(1478, 846);
            this.ambiance_ThemeContainer1.SmartBounds = true;
            this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.ambiance_ThemeContainer1.TabIndex = 0;
            this.ambiance_ThemeContainer1.Text = "Kalıp Yönetim";
            this.ambiance_ThemeContainer1.Click += new System.EventHandler(this.ambiance_ThemeContainer1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KalipApp.Resource1.taslama;
            this.pictureBox1.Location = new System.Drawing.Point(14, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 775);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ambiance_CheckBox1
            // 
            this.ambiance_CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_CheckBox1.Checked = false;
            this.ambiance_CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_CheckBox1.Location = new System.Drawing.Point(1062, 434);
            this.ambiance_CheckBox1.Name = "ambiance_CheckBox1";
            this.ambiance_CheckBox1.Size = new System.Drawing.Size(171, 15);
            this.ambiance_CheckBox1.TabIndex = 8;
            this.ambiance_CheckBox1.Text = "Beni Hatırla";
            this.ambiance_CheckBox1.CheckedChanged += new Ambiance.Ambiance_CheckBox.CheckedChangedEventHandler(this.ambiance_CheckBox1_CheckedChanged);
            // 
            // ambiance_ControlBox1
            // 
            this.ambiance_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_ControlBox1.EnableMaximize = true;
            this.ambiance_ControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambiance_ControlBox1.Location = new System.Drawing.Point(5, 13);
            this.ambiance_ControlBox1.Name = "ambiance_ControlBox1";
            this.ambiance_ControlBox1.Size = new System.Drawing.Size(64, 22);
            this.ambiance_ControlBox1.TabIndex = 7;
            this.ambiance_ControlBox1.Text = "ambiance_ControlBox1";
            // 
            // ambiance_Button_21
            // 
            this.ambiance_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_Button_21.Image = null;
            this.ambiance_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_21.Location = new System.Drawing.Point(1064, 512);
            this.ambiance_Button_21.Name = "ambiance_Button_21";
            this.ambiance_Button_21.Size = new System.Drawing.Size(253, 39);
            this.ambiance_Button_21.TabIndex = 6;
            this.ambiance_Button_21.Text = "Giriş Yap";
            this.ambiance_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_21.Click += new System.EventHandler(this.ambiance_Button_21_Click);
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(960, 375);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(98, 32);
            this.ambiance_Label2.TabIndex = 3;
            this.ambiance_Label2.Text = "Parola";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(1064, 374);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = false;
            this.txtPass.Size = new System.Drawing.Size(253, 41);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(898, 126);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(394, 48);
            this.ambiance_Label3.TabIndex = 1;
            this.ambiance_Label3.Text = "YÖNETİCİ PANELİ";
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(884, 299);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(173, 32);
            this.ambiance_Label1.TabIndex = 1;
            this.ambiance_Label1.Text = "Kullanıcı Adı";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.ForeColor = System.Drawing.Color.DimGray;
            this.txt_username.Location = new System.Drawing.Point(1064, 299);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = false;
            this.txt_username.Size = new System.Drawing.Size(253, 41);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 846);
            this.Controls.Add(this.ambiance_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Kalıp Yönetim";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambiance_ThemeContainer1.ResumeLayout(false);
            this.ambiance_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_TextBox txt_username;
        private Ambiance.Ambiance_Button_2 ambiance_Button_21;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_TextBox txtPass;
        private Ambiance.Ambiance_CheckBox ambiance_CheckBox1;
        private Ambiance.Ambiance_ControlBox ambiance_ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Ambiance.Ambiance_Label ambiance_Label3;
    }
}

