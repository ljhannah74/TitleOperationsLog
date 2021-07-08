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

namespace TitleOperationsLog
{
	public partial class LogEntryDetails : RadForm
	{
		LogModel db;
		public LogEntryDetails()
		{
			InitializeComponent();
		}

		private void LogEntryDetails_Load(object sender, EventArgs e)
		{
			db = new LogModel();
			List<Client> clientList = db.Clients.ToList();
			cbox_Client.ValueMember = "ClientId";
			cbox_Client.DisplayMember = "ClientCode";
			cbox_Client.DataSource = clientList;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			LogEntry entry = new LogEntry();

			entry.Client = (Client)cbox_Client.SelectedItem.DataBoundItem;
			entry.OrderNo = txtOrderNo.Text;
			entry.TimeStamp = System.DateTime.Now;
			db.LogEntries.Add(entry);
			db.SaveChanges();
			this.Close();
		}
	}
}
