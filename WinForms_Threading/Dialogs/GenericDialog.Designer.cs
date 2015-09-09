namespace WinForms_Threading.Dialogs
{
	partial class GenericDialog
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
			this.btn_performTask = new System.Windows.Forms.Button();
			this.btn_accept = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.pnl_controlContainer = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.btn_performTask);
			this.panel1.Controls.Add(this.btn_accept);
			this.panel1.Controls.Add(this.btn_cancel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 291);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(457, 50);
			this.panel1.TabIndex = 0;
			// 
			// btn_performTask
			// 
			this.btn_performTask.Location = new System.Drawing.Point(12, 15);
			this.btn_performTask.Name = "btn_performTask";
			this.btn_performTask.Size = new System.Drawing.Size(169, 23);
			this.btn_performTask.TabIndex = 2;
			this.btn_performTask.Text = "Really long Button Text";
			this.btn_performTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_performTask.UseVisualStyleBackColor = true;
			this.btn_performTask.Click += new System.EventHandler(this.btn_performTask_Click);
			// 
			// btn_accept
			// 
			this.btn_accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_accept.Location = new System.Drawing.Point(291, 15);
			this.btn_accept.Name = "btn_accept";
			this.btn_accept.Size = new System.Drawing.Size(75, 23);
			this.btn_accept.TabIndex = 1;
			this.btn_accept.Text = "Accept";
			this.btn_accept.UseVisualStyleBackColor = true;
			this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_cancel.Location = new System.Drawing.Point(372, 15);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 0;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// pnl_controlContainer
			// 
			this.pnl_controlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_controlContainer.Location = new System.Drawing.Point(0, 0);
			this.pnl_controlContainer.Name = "pnl_controlContainer";
			this.pnl_controlContainer.Size = new System.Drawing.Size(457, 291);
			this.pnl_controlContainer.TabIndex = 1;
			// 
			// GenericDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 341);
			this.Controls.Add(this.pnl_controlContainer);
			this.Controls.Add(this.panel1);
			this.Name = "GenericDialog";
			this.Text = "GenericDialog";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_accept;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_performTask;
		private System.Windows.Forms.Panel pnl_controlContainer;
	}
}