using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Data.Entity;

namespace TitleOperationsLog
{
	public partial class MainForm : RadForm
	{
		LogModel db;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			db = new LogModel();
			db.LogEntries.Load();
			grdLogEntries.DataSource = db.LogEntries.Local.ToBindingList();
		}

		private void btnNewEntry_Click(object sender, EventArgs e)
		{
			LogEntryDetails entryDetails = new LogEntryDetails();

			entryDetails.ShowDialog();
		}
	}
}
