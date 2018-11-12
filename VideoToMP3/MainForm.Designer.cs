namespace VideoToMP3
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_inputPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_outputPath = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.chb_rename = new System.Windows.Forms.CheckBox();
            this.lab_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_inputPath
            // 
            this.tb_inputPath.AllowDrop = true;
            this.tb_inputPath.Location = new System.Drawing.Point(94, 47);
            this.tb_inputPath.Name = "tb_inputPath";
            this.tb_inputPath.Size = new System.Drawing.Size(371, 21);
            this.tb_inputPath.TabIndex = 0;
            this.tb_inputPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_inputPath_DragDrop);
            this.tb_inputPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_inputPath_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出路径";
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.AllowDrop = true;
            this.tb_outputPath.Location = new System.Drawing.Point(94, 106);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.Size = new System.Drawing.Size(371, 21);
            this.tb_outputPath.TabIndex = 2;
            this.tb_outputPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_inputPath_DragDrop);
            this.tb_outputPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_inputPath_DragEnter);
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(217, 161);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "提取MP3";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // chb_rename
            // 
            this.chb_rename.AutoSize = true;
            this.chb_rename.Location = new System.Drawing.Point(94, 81);
            this.chb_rename.Name = "chb_rename";
            this.chb_rename.Size = new System.Drawing.Size(96, 16);
            this.chb_rename.TabIndex = 5;
            this.chb_rename.Text = "批量随机改名";
            this.chb_rename.UseVisualStyleBackColor = true;
            // 
            // lab_state
            // 
            this.lab_state.AutoSize = true;
            this.lab_state.ForeColor = System.Drawing.Color.Red;
            this.lab_state.Location = new System.Drawing.Point(343, 166);
            this.lab_state.Name = "lab_state";
            this.lab_state.Size = new System.Drawing.Size(0, 12);
            this.lab_state.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 212);
            this.Controls.Add(this.lab_state);
            this.Controls.Add(this.chb_rename);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_outputPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_inputPath);
            this.Name = "mainForm";
            this.Text = "VideoToMP3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_inputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_outputPath;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.CheckBox chb_rename;
        private System.Windows.Forms.Label lab_state;
    }
}

