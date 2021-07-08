
namespace TitleOperationsLog
{
	partial class LogEntryDetails
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
			this.cbox_Client = new Telerik.WinControls.UI.RadDropDownList();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.txtOrderNo = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.cbox_Client)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// cbox_Client
			// 
			this.cbox_Client.Location = new System.Drawing.Point(299, 115);
			this.cbox_Client.Name = "cbox_Client";
			this.cbox_Client.Size = new System.Drawing.Size(125, 20);
			this.cbox_Client.TabIndex = 0;
			this.cbox_Client.Text = "choose";
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(299, 91);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(37, 18);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Client:";
			// 
			// txtOrderNo
			// 
			this.txtOrderNo.Location = new System.Drawing.Point(117, 114);
			this.txtOrderNo.Name = "txtOrderNo";
			this.txtOrderNo.Size = new System.Drawing.Size(118, 20);
			this.txtOrderNo.TabIndex = 2;
			// 
			// radLabel2
			// 
			this.radLabel2.Location = new System.Drawing.Point(117, 90);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(56, 18);
			this.radLabel2.TabIndex = 3;
			this.radLabel2.Text = "Order No:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(299, 358);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 24);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// LogEntryDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 450);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.radLabel2);
			this.Controls.Add(this.txtOrderNo);
			this.Controls.Add(this.radLabel1);
			this.Controls.Add(this.cbox_Client);
			this.Name = "LogEntryDetails";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "LogEntryDetails";
			this.Load += new System.EventHandler(this.LogEntryDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.cbox_Client)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadDropDownList cbox_Client;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadTextBox txtOrderNo;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadButton btnSave;
	}
}