namespace DBConnectivity
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMediaFiles = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnImages = new System.Windows.Forms.Button();
            this.btnShowFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMediaFiles
            // 
            this.btnMediaFiles.Location = new System.Drawing.Point(22, 12);
            this.btnMediaFiles.Name = "btnMediaFiles";
            this.btnMediaFiles.Size = new System.Drawing.Size(105, 28);
            this.btnMediaFiles.TabIndex = 2;
            this.btnMediaFiles.Text = "Show all Media";
            this.btnMediaFiles.UseVisualStyleBackColor = true;
            this.btnMediaFiles.Click += new System.EventHandler(this.btnMediaFiles_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(153, 17);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(75, 23);
            this.btnMusic.TabIndex = 3;
            this.btnMusic.Text = "Show Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnImages
            // 
            this.btnImages.AutoSize = true;
            this.btnImages.Location = new System.Drawing.Point(254, 17);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(81, 23);
            this.btnImages.TabIndex = 4;
            this.btnImages.Text = "Show Images";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // btnShowFiles
            // 
            this.btnShowFiles.AutoSize = true;
            this.btnShowFiles.Location = new System.Drawing.Point(352, 17);
            this.btnShowFiles.Name = "btnShowFiles";
            this.btnShowFiles.Size = new System.Drawing.Size(101, 23);
            this.btnShowFiles.TabIndex = 5;
            this.btnShowFiles.Text = "Show Files";
            this.btnShowFiles.UseVisualStyleBackColor = true;
            this.btnShowFiles.Click += new System.EventHandler(this.btnShowFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowFiles);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnMediaFiles);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMediaFiles;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Button btnShowFiles;
    }
}

