namespace WinForms_Threading
{
	partial class MainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_progressTask = new System.Windows.Forms.Button();
			this.btn_backgroundWorker = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.btn_Close);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 131);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(404, 50);
			this.panel1.TabIndex = 0;
			// 
			// btn_Close
			// 
			this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Close.Location = new System.Drawing.Point(317, 15);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 23);
			this.btn_Close.TabIndex = 0;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_progressTask
			// 
			this.btn_progressTask.Location = new System.Drawing.Point(12, 29);
			this.btn_progressTask.Name = "btn_progressTask";
			this.btn_progressTask.Size = new System.Drawing.Size(126, 23);
			this.btn_progressTask.TabIndex = 1;
			this.btn_progressTask.Text = "Progress Task";
			this.btn_progressTask.UseVisualStyleBackColor = true;
			this.btn_progressTask.Click += new System.EventHandler(this.btn_progressTask_Click);
			// 
			// btn_backgroundWorker
			// 
			this.btn_backgroundWorker.Location = new System.Drawing.Point(12, 58);
			this.btn_backgroundWorker.Name = "btn_backgroundWorker";
			this.btn_backgroundWorker.Size = new System.Drawing.Size(126, 23);
			this.btn_backgroundWorker.TabIndex = 2;
			this.btn_backgroundWorker.Text = "Back Ground Worker";
			this.btn_backgroundWorker.UseVisualStyleBackColor = true;
			this.btn_backgroundWorker.Click += new System.EventHandler(this.btn_backgroundWorker_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 181);
			this.Controls.Add(this.btn_backgroundWorker);
			this.Controls.Add(this.btn_progressTask);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "WinForms Threading Sample";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_progressTask;
		private System.Windows.Forms.Button btn_backgroundWorker;
	}
}

