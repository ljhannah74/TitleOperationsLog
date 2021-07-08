
namespace TitleOperationsLog
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
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.btnNewEntry = new Telerik.WinControls.UI.RadButton();
			this.grdLogEntries = new Telerik.WinControls.UI.RadGridView();
			((System.ComponentModel.ISupportInitialize)(this.btnNewEntry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdLogEntries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdLogEntries.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNewEntry
			// 
			this.btnNewEntry.Location = new System.Drawing.Point(315, 373);
			this.btnNewEntry.Name = "btnNewEntry";
			this.btnNewEntry.Size = new System.Drawing.Size(110, 24);
			this.btnNewEntry.TabIndex = 1;
			this.btnNewEntry.Text = "New Entry";
			this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
			// 
			// grdLogEntries
			// 
			this.grdLogEntries.Location = new System.Drawing.Point(13, 13);
			// 
			// 
			// 
			this.grdLogEntries.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.grdLogEntries.Name = "grdLogEntries";
			this.grdLogEntries.Size = new System.Drawing.Size(475, 322);
			this.grdLogEntries.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 450);
			this.Controls.Add(this.grdLogEntries);
			this.Controls.Add(this.btnNewEntry);
			this.Name = "MainForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnNewEntry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdLogEntries.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdLogEntries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Telerik.WinControls.UI.RadButton btnNewEntry;
		private Telerik.WinControls.UI.RadGridView grdLogEntries;
	}
}