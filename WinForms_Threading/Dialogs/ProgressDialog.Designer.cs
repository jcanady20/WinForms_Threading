namespace WinForms_Threading.Dialogs
{
	partial class ProgressDialog
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
			this.tskbr_Progress = new System.Windows.Forms.ProgressBar();
			this.btn_CancelTask = new System.Windows.Forms.Button();
			this.lbl_taskStepName = new System.Windows.Forms.Label();
			this.loadingCircle1 = new WinForms_Threading.Controls.LoadingCircle();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.btn_CancelTask);
			this.panel1.Controls.Add(this.tskbr_Progress);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 84);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(414, 50);
			this.panel1.TabIndex = 5;
			// 
			// tskbr_Progress
			// 
			this.tskbr_Progress.Location = new System.Drawing.Point(23, 15);
			this.tskbr_Progress.Name = "tskbr_Progress";
			this.tskbr_Progress.Size = new System.Drawing.Size(249, 23);
			this.tskbr_Progress.TabIndex = 4;
			// 
			// btn_CancelTask
			// 
			this.btn_CancelTask.Location = new System.Drawing.Point(327, 15);
			this.btn_CancelTask.Name = "btn_CancelTask";
			this.btn_CancelTask.Size = new System.Drawing.Size(75, 23);
			this.btn_CancelTask.TabIndex = 5;
			this.btn_CancelTask.Text = "Cancel";
			this.btn_CancelTask.UseVisualStyleBackColor = true;
			this.btn_CancelTask.Click += new System.EventHandler(this.btn_CancelTask_Click);
			// 
			// lbl_taskStepName
			// 
			this.lbl_taskStepName.AutoSize = true;
			this.lbl_taskStepName.Location = new System.Drawing.Point(23, 65);
			this.lbl_taskStepName.Name = "lbl_taskStepName";
			this.lbl_taskStepName.Size = new System.Drawing.Size(54, 13);
			this.lbl_taskStepName.TabIndex = 6;
			this.lbl_taskStepName.Text = "Task Step";
			// 
			// loadingCircle1
			// 
			this.loadingCircle1.Active = true;
			this.loadingCircle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loadingCircle1.Color = System.Drawing.Color.DarkGray;
			this.loadingCircle1.InnerCircleRadius = 5;
			this.loadingCircle1.Location = new System.Drawing.Point(338, 12);
			this.loadingCircle1.Name = "loadingCircle1";
			this.loadingCircle1.NumberSpoke = 12;
			this.loadingCircle1.OuterCircleRadius = 11;
			this.loadingCircle1.RotationSpeed = 100D;
			this.loadingCircle1.Size = new System.Drawing.Size(64, 44);
			this.loadingCircle1.SpokeThickness = 2;
			this.loadingCircle1.StylePreset = WinForms_Threading.Controls.LoadingCircle.StylePresets.MacOSX;
			this.loadingCircle1.TabIndex = 7;
			this.loadingCircle1.Text = "loadingCircle1";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(26, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 43);
			this.label1.TabIndex = 8;
			this.label1.Text = "Progress Dialog";
			// 
			// ProgressDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 134);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loadingCircle1);
			this.Controls.Add(this.lbl_taskStepName);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(430, 150);
			this.MinimumSize = new System.Drawing.Size(430, 150);
			this.Name = "ProgressDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_CancelTask;
		internal System.Windows.Forms.ProgressBar tskbr_Progress;
		private System.Windows.Forms.Label lbl_taskStepName;
		private Controls.LoadingCircle loadingCircle1;
		private System.Windows.Forms.Label label1;
	}
}