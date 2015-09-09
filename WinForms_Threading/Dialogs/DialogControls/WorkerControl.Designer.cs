namespace WinForms_Threading.Dialogs.DialogControls
{
	partial class WorkerControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.pb_progress = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Background Worker";
			// 
			// pb_progress
			// 
			this.pb_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_progress.Location = new System.Drawing.Point(3, 35);
			this.pb_progress.Name = "pb_progress";
			this.pb_progress.Size = new System.Drawing.Size(339, 23);
			this.pb_progress.TabIndex = 1;
			// 
			// BackGrounWorker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pb_progress);
			this.Controls.Add(this.label1);
			this.Name = "BackGrounWorker";
			this.Size = new System.Drawing.Size(345, 91);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar pb_progress;
	}
}
