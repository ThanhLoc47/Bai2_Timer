namespace Bai2_Timer
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
            this.components = new System.ComponentModel.Container();
            this.lblShutdown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShutdown = new System.Windows.Forms.TextBox();
            this.cbbTask = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShutdown
            // 
            this.lblShutdown.AutoSize = true;
            this.lblShutdown.Location = new System.Drawing.Point(28, 49);
            this.lblShutdown.Name = "lblShutdown";
            this.lblShutdown.Size = new System.Drawing.Size(109, 13);
            this.lblShutdown.TabIndex = 0;
            this.lblShutdown.Text = "Shutdown in(Second)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Task";
            // 
            // txtShutdown
            // 
            this.txtShutdown.Location = new System.Drawing.Point(143, 46);
            this.txtShutdown.Name = "txtShutdown";
            this.txtShutdown.Size = new System.Drawing.Size(100, 20);
            this.txtShutdown.TabIndex = 2;
            // 
            // cbbTask
            // 
            this.cbbTask.BackColor = System.Drawing.SystemColors.Window;
            this.cbbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTask.FormattingEnabled = true;
            this.cbbTask.Items.AddRange(new object[] {
            "Shutdown",
            "Reset",
            "Logoff"});
            this.cbbTask.Location = new System.Drawing.Point(143, 78);
            this.cbbTask.Name = "cbbTask";
            this.cbbTask.Size = new System.Drawing.Size(100, 21);
            this.cbbTask.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 153);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(146, 153);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbbTask);
            this.Controls.Add(this.txtShutdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShutdown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShutdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShutdown;
        private System.Windows.Forms.ComboBox cbbTask;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

