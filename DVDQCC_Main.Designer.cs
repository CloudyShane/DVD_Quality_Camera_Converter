namespace DVDQCC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sdr7_go = new System.Windows.Forms.Button();
            this.button_sdr7_output_folder = new System.Windows.Forms.Button();
            this.button_sdr7_source_file = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sdr7_output_folder = new System.Windows.Forms.TextBox();
            this.sdr7_source_file = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_sdr7_batch_go = new System.Windows.Forms.Button();
            this.button_sdr7_batch_output_folder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_sdr7_batch_source_file = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sdr7_batch_output_folder = new System.Windows.Forms.TextBox();
            this.sdr7_batch_source_file = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aspectSelector43 = new System.Windows.Forms.RadioButton();
            this.aspectSelector169 = new System.Windows.Forms.RadioButton();
            this.button_set_dgindex_folder = new System.Windows.Forms.Button();
            this.button_set_ffmpeg_folder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_save_settings = new System.Windows.Forms.Button();
            this.dgindex_loc_textbox = new System.Windows.Forms.TextBox();
            this.ffmpeg_loc_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(960, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automated Conversion Tool from MOD (mpeg2) into MP4 (h264)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 37);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sdr7_go);
            this.groupBox1.Controls.Add(this.button_sdr7_output_folder);
            this.groupBox1.Controls.Add(this.button_sdr7_source_file);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sdr7_output_folder);
            this.groupBox1.Controls.Add(this.sdr7_source_file);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(18, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single-File Conversion";
            // 
            // button_sdr7_go
            // 
            this.button_sdr7_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sdr7_go.Location = new System.Drawing.Point(6, 92);
            this.button_sdr7_go.Name = "button_sdr7_go";
            this.button_sdr7_go.Size = new System.Drawing.Size(458, 39);
            this.button_sdr7_go.TabIndex = 6;
            this.button_sdr7_go.Text = "Begin Deinterlace";
            this.button_sdr7_go.UseVisualStyleBackColor = true;
            this.button_sdr7_go.Click += new System.EventHandler(this.button_launch_singlefile_conversion);
            // 
            // button_sdr7_output_folder
            // 
            this.button_sdr7_output_folder.Location = new System.Drawing.Point(361, 58);
            this.button_sdr7_output_folder.Name = "button_sdr7_output_folder";
            this.button_sdr7_output_folder.Size = new System.Drawing.Size(103, 29);
            this.button_sdr7_output_folder.TabIndex = 6;
            this.button_sdr7_output_folder.Text = "Select";
            this.button_sdr7_output_folder.UseVisualStyleBackColor = true;
            this.button_sdr7_output_folder.Click += new System.EventHandler(this.button_singlefile_select_output_folder);
            // 
            // button_sdr7_source_file
            // 
            this.button_sdr7_source_file.Location = new System.Drawing.Point(361, 23);
            this.button_sdr7_source_file.Name = "button_sdr7_source_file";
            this.button_sdr7_source_file.Size = new System.Drawing.Size(103, 29);
            this.button_sdr7_source_file.TabIndex = 6;
            this.button_sdr7_source_file.Text = "Select";
            this.button_sdr7_source_file.UseVisualStyleBackColor = true;
            this.button_sdr7_source_file.Click += new System.EventHandler(this.button_singlefile_select_source_file);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Output file folder";
            // 
            // sdr7_output_folder
            // 
            this.sdr7_output_folder.Location = new System.Drawing.Point(177, 57);
            this.sdr7_output_folder.Name = "sdr7_output_folder";
            this.sdr7_output_folder.Size = new System.Drawing.Size(178, 29);
            this.sdr7_output_folder.TabIndex = 5;
            // 
            // sdr7_source_file
            // 
            this.sdr7_source_file.Location = new System.Drawing.Point(177, 22);
            this.sdr7_source_file.Name = "sdr7_source_file";
            this.sdr7_source_file.Size = new System.Drawing.Size(178, 29);
            this.sdr7_source_file.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Source file (.MOD)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_sdr7_batch_go);
            this.groupBox2.Controls.Add(this.button_sdr7_batch_output_folder);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button_sdr7_batch_source_file);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.sdr7_batch_output_folder);
            this.groupBox2.Controls.Add(this.sdr7_batch_source_file);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(496, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Batch Conversion";
            // 
            // button_sdr7_batch_go
            // 
            this.button_sdr7_batch_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sdr7_batch_go.Location = new System.Drawing.Point(6, 92);
            this.button_sdr7_batch_go.Name = "button_sdr7_batch_go";
            this.button_sdr7_batch_go.Size = new System.Drawing.Size(464, 39);
            this.button_sdr7_batch_go.TabIndex = 6;
            this.button_sdr7_batch_go.Text = "Begin Batch Deinterlace";
            this.button_sdr7_batch_go.UseVisualStyleBackColor = true;
            this.button_sdr7_batch_go.Click += new System.EventHandler(this.button_launch_batch_conversion);
            // 
            // button_sdr7_batch_output_folder
            // 
            this.button_sdr7_batch_output_folder.Location = new System.Drawing.Point(367, 61);
            this.button_sdr7_batch_output_folder.Name = "button_sdr7_batch_output_folder";
            this.button_sdr7_batch_output_folder.Size = new System.Drawing.Size(103, 29);
            this.button_sdr7_batch_output_folder.TabIndex = 6;
            this.button_sdr7_batch_output_folder.Text = "Select";
            this.button_sdr7_batch_output_folder.UseVisualStyleBackColor = true;
            this.button_sdr7_batch_output_folder.Click += new System.EventHandler(this.button_batch_select_output_folder);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Output files folder";
            // 
            // button_sdr7_batch_source_file
            // 
            this.button_sdr7_batch_source_file.Location = new System.Drawing.Point(367, 25);
            this.button_sdr7_batch_source_file.Name = "button_sdr7_batch_source_file";
            this.button_sdr7_batch_source_file.Size = new System.Drawing.Size(103, 29);
            this.button_sdr7_batch_source_file.TabIndex = 6;
            this.button_sdr7_batch_source_file.Text = "Select";
            this.button_sdr7_batch_source_file.UseVisualStyleBackColor = true;
            this.button_sdr7_batch_source_file.Click += new System.EventHandler(this.button_batch_select_input_folder);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Source files folder";
            // 
            // sdr7_batch_output_folder
            // 
            this.sdr7_batch_output_folder.Location = new System.Drawing.Point(177, 60);
            this.sdr7_batch_output_folder.Name = "sdr7_batch_output_folder";
            this.sdr7_batch_output_folder.Size = new System.Drawing.Size(184, 29);
            this.sdr7_batch_output_folder.TabIndex = 5;
            // 
            // sdr7_batch_source_file
            // 
            this.sdr7_batch_source_file.Location = new System.Drawing.Point(177, 25);
            this.sdr7_batch_source_file.Name = "sdr7_batch_source_file";
            this.sdr7_batch_source_file.Size = new System.Drawing.Size(184, 29);
            this.sdr7_batch_source_file.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "FFMPEG Location";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aspectSelector43);
            this.groupBox3.Controls.Add(this.aspectSelector169);
            this.groupBox3.Controls.Add(this.button_set_dgindex_folder);
            this.groupBox3.Controls.Add(this.button_set_ffmpeg_folder);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button_save_settings);
            this.groupBox3.Controls.Add(this.dgindex_loc_textbox);
            this.groupBox3.Controls.Add(this.ffmpeg_loc_textbox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(18, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(954, 129);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // aspectSelector43
            // 
            this.aspectSelector43.AutoSize = true;
            this.aspectSelector43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aspectSelector43.Location = new System.Drawing.Point(182, 94);
            this.aspectSelector43.Name = "aspectSelector43";
            this.aspectSelector43.Size = new System.Drawing.Size(53, 28);
            this.aspectSelector43.TabIndex = 7;
            this.aspectSelector43.Text = "4:3";
            this.aspectSelector43.UseVisualStyleBackColor = true;
            // 
            // aspectSelector169
            // 
            this.aspectSelector169.AutoSize = true;
            this.aspectSelector169.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aspectSelector169.Location = new System.Drawing.Point(241, 94);
            this.aspectSelector169.Name = "aspectSelector169";
            this.aspectSelector169.Size = new System.Drawing.Size(63, 28);
            this.aspectSelector169.TabIndex = 8;
            this.aspectSelector169.Text = "16:9";
            this.aspectSelector169.UseVisualStyleBackColor = true;
            // 
            // button_set_dgindex_folder
            // 
            this.button_set_dgindex_folder.Location = new System.Drawing.Point(726, 57);
            this.button_set_dgindex_folder.Name = "button_set_dgindex_folder";
            this.button_set_dgindex_folder.Size = new System.Drawing.Size(103, 29);
            this.button_set_dgindex_folder.TabIndex = 6;
            this.button_set_dgindex_folder.Text = "Select";
            this.button_set_dgindex_folder.UseVisualStyleBackColor = true;
            this.button_set_dgindex_folder.Click += new System.EventHandler(this.button_set_dgindex_directory);
            // 
            // button_set_ffmpeg_folder
            // 
            this.button_set_ffmpeg_folder.Location = new System.Drawing.Point(726, 22);
            this.button_set_ffmpeg_folder.Name = "button_set_ffmpeg_folder";
            this.button_set_ffmpeg_folder.Size = new System.Drawing.Size(103, 29);
            this.button_set_ffmpeg_folder.TabIndex = 6;
            this.button_set_ffmpeg_folder.Text = "Select";
            this.button_set_ffmpeg_folder.UseVisualStyleBackColor = true;
            this.button_set_ffmpeg_folder.Click += new System.EventHandler(this.button_set_ffmpeg_directory);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Video Aspect Ratio";
            // 
            // button_save_settings
            // 
            this.button_save_settings.Location = new System.Drawing.Point(835, 22);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(113, 64);
            this.button_save_settings.TabIndex = 6;
            this.button_save_settings.Text = "Save";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_app_settings);
            // 
            // dgindex_loc_textbox
            // 
            this.dgindex_loc_textbox.Location = new System.Drawing.Point(177, 57);
            this.dgindex_loc_textbox.Name = "dgindex_loc_textbox";
            this.dgindex_loc_textbox.Size = new System.Drawing.Size(543, 29);
            this.dgindex_loc_textbox.TabIndex = 5;
            // 
            // ffmpeg_loc_textbox
            // 
            this.ffmpeg_loc_textbox.Location = new System.Drawing.Point(177, 22);
            this.ffmpeg_loc_textbox.Name = "ffmpeg_loc_textbox";
            this.ffmpeg_loc_textbox.Size = new System.Drawing.Size(543, 29);
            this.ffmpeg_loc_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "DGIndex Location";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 346);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DVD Quality Camera Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_save_settings;
        private System.Windows.Forms.TextBox ffmpeg_loc_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_sdr7_go;
        private System.Windows.Forms.TextBox sdr7_output_folder;
        private System.Windows.Forms.TextBox sdr7_source_file;
        private System.Windows.Forms.Button button_sdr7_batch_go;
        private System.Windows.Forms.TextBox dgindex_loc_textbox;
        private System.Windows.Forms.Button button_set_ffmpeg_folder;
        private System.Windows.Forms.Button button_set_dgindex_folder;
        private System.Windows.Forms.Button button_sdr7_output_folder;
        private System.Windows.Forms.Button button_sdr7_source_file;
        private System.Windows.Forms.Button button_sdr7_batch_output_folder;
        private System.Windows.Forms.Button button_sdr7_batch_source_file;
        private System.Windows.Forms.TextBox sdr7_batch_output_folder;
        private System.Windows.Forms.TextBox sdr7_batch_source_file;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton aspectSelector43;
        private System.Windows.Forms.RadioButton aspectSelector169;
    }
}

