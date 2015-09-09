namespace WinForms_Threading.Controls
{
	partial class WorkSplash
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
			this.loadingCircle1 = new WinForms_Threading.Controls.LoadingCircle();
			this.SuspendLayout();
			// 
			// loadingCircle1
			// 
			this.loadingCircle1.Active = true;
			this.loadingCircle1.Color = System.Drawing.Color.DarkGray;
			this.loadingCircle1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadingCircle1.InnerCircleRadius = 5;
			this.loadingCircle1.Location = new System.Drawing.Point(0, 0);
			this.loadingCircle1.Name = "loadingCircle1";
			this.loadingCircle1.NumberSpoke = 12;
			this.loadingCircle1.OuterCircleRadius = 14;
			this.loadingCircle1.RotationSpeed = 100D;
			this.loadingCircle1.Size = new System.Drawing.Size(400, 250);
			this.loadingCircle1.SpokeThickness = 2;
			this.loadingCircle1.StylePreset = WinForms_Threading.Controls.LoadingCircle.StylePresets.MacOSX;
			this.loadingCircle1.TabIndex = 0;
			this.loadingCircle1.Text = "loadingCircle1";
			// 
			// WorkSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.loadingCircle1);
			this.Name = "WorkSplash";
			this.Size = new System.Drawing.Size(400, 250);
			this.ResumeLayout(false);

		}

		#endregion

		private LoadingCircle loadingCircle1;
	}
}
