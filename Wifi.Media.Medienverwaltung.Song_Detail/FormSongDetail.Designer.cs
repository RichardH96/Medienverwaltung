namespace Wifi.Media.Medienverwaltung.Song_Detail
{
    partial class FormSongDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSongDetail));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTracknr = new System.Windows.Forms.TextBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSongsleft = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(250, 179);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 28);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(47, 179);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 28);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Song Tracknr.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Song Language:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Song Duration:";
            // 
            // textBoxTracknr
            // 
            this.textBoxTracknr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTracknr.Location = new System.Drawing.Point(174, 144);
            this.textBoxTracknr.Name = "textBoxTracknr";
            this.textBoxTracknr.Size = new System.Drawing.Size(173, 20);
            this.textBoxTracknr.TabIndex = 11;
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxLanguage.Location = new System.Drawing.Point(174, 118);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(173, 20);
            this.textBoxLanguage.TabIndex = 10;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.BackColor = System.Drawing.Color.Silver;
            this.textBoxDuration.Location = new System.Drawing.Point(174, 92);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.ReadOnly = true;
            this.textBoxDuration.Size = new System.Drawing.Size(173, 20);
            this.textBoxDuration.TabIndex = 14;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 222);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSongsleft
            // 
            this.labelSongsleft.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSongsleft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSongsleft.Location = new System.Drawing.Point(12, 9);
            this.labelSongsleft.Name = "labelSongsleft";
            this.labelSongsleft.Size = new System.Drawing.Size(354, 23);
            this.labelSongsleft.TabIndex = 16;
            this.labelSongsleft.Text = "x";
            this.labelSongsleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.BackColor = System.Drawing.Color.Silver;
            this.textBoxAlbumName.Location = new System.Drawing.Point(174, 40);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.ReadOnly = true;
            this.textBoxAlbumName.Size = new System.Drawing.Size(173, 20);
            this.textBoxAlbumName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Album Name:";
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.BackColor = System.Drawing.Color.Silver;
            this.textBoxSongName.Location = new System.Drawing.Point(174, 66);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.ReadOnly = true;
            this.textBoxSongName.Size = new System.Drawing.Size(173, 20);
            this.textBoxSongName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Song Name:";
            // 
            // FormSongDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(378, 232);
            this.Controls.Add(this.labelSongsleft);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTracknr);
            this.Controls.Add(this.textBoxLanguage);
            this.Controls.Add(this.textBoxSongName);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.textBoxDuration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSongDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medienverwaltung - Edit Songs";
            this.Load += new System.EventHandler(this.FormSongDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTracknr;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.TextBox textBoxDuration;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSongsleft;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSongName;
        private System.Windows.Forms.Label label5;
    }
}

