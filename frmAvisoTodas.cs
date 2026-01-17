using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional
{
	// Token: 0x02000004 RID: 4
	[DesignerGenerated]
	public partial class frmAvisoTodas : Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000036D8 File Offset: 0x000018D8
		public frmAvisoTodas()
		{
			base.Load += this.frmAvisoTodas_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003DF2 File Offset: 0x00001FF2
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003DFC File Offset: 0x00001FFC
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003E05 File Offset: 0x00002005
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003E0F File Offset: 0x0000200F
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003E18 File Offset: 0x00002018
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003E22 File Offset: 0x00002022
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003E2B File Offset: 0x0000202B
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003E35 File Offset: 0x00002035
		internal virtual DataGridView DataGridFoliosRenumerar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003E3E File Offset: 0x0000203E
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00003E48 File Offset: 0x00002048
		internal virtual Button btnAplicar
		{
			[CompilerGenerated]
			get
			{
				return this._btnAplicar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAplicar_Click);
				Button btnAplicar = this._btnAplicar;
				if (btnAplicar != null)
				{
					btnAplicar.Click -= value2;
				}
				this._btnAplicar = value;
				btnAplicar = this._btnAplicar;
				if (btnAplicar != null)
				{
					btnAplicar.Click += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003E8B File Offset: 0x0000208B
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003E95 File Offset: 0x00002095
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000026 RID: 38 RVA: 0x00003E9E File Offset: 0x0000209E
		private void frmAvisoTodas_Load(object sender, EventArgs e)
		{
			this.ObtenerFOlios();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003EA8 File Offset: 0x000020A8
		private void iniciaGriSeriesFolios()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.DataGridFoliosRenumerar.Rows.Clear();
			this.DataGridFoliosRenumerar.ColumnCount = 2;
			this.DataGridFoliosRenumerar.Columns[0].Name = "Serie";
			this.DataGridFoliosRenumerar.Columns[0].Visible = true;
			this.DataGridFoliosRenumerar.Columns[0].ReadOnly = true;
			this.DataGridFoliosRenumerar.Columns[0].Width = 60;
			this.DataGridFoliosRenumerar.Columns[1].Name = "Folio";
			this.DataGridFoliosRenumerar.Columns[1].Width = 118;
			this.DataGridFoliosRenumerar.Columns[1].ReadOnly = false;
			this.DataGridFoliosRenumerar.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003FB0 File Offset: 0x000021B0
		public void ObtenerFOlios()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "SELECT a , b FROM L";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.iniciaGriSeriesFolios();
				while (sqlDataReader.Read())
				{
					string text = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					string text2 = Tools.Desencriptar(sqlDataReader[1].ToString().Trim());
					this.DataGridFoliosRenumerar.Rows.Add(new object[]
					{
						text,
						text2
					});
				}
			}
			sqlDataReader.Close();
			this.DataGridFoliosRenumerar.ClearSelection();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004060 File Offset: 0x00002260
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "DELETE FROM L";
			sqlQuery_Conn.execQuery_conn(query_conn);
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridFoliosRenumerar.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string texto = Conversions.ToString(dataGridViewRow.Cells["Serie"].Value);
					string texto2 = Conversions.ToString(dataGridViewRow.Cells["Folio"].Value);
					query_conn = string.Concat(new string[]
					{
						"INSERT INTO L VALUES ('",
						Tools.Encriptar(texto),
						"','",
						Tools.Encriptar(texto2),
						"')"
					});
					sqlQuery_Conn.execQuery_conn(query_conn);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			base.Close();
		}
	}
}
