using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional
{
	// Token: 0x02000003 RID: 3
	[DesignerGenerated]
	public partial class frmAvisoDistintoTodas : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002E78 File Offset: 0x00001078
		public frmAvisoDistintoTodas()
		{
			base.Load += this.frmAvisoDistintoTodas_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000348D File Offset: 0x0000168D
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00003497 File Offset: 0x00001697
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000034A0 File Offset: 0x000016A0
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000034AA File Offset: 0x000016AA
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000034B3 File Offset: 0x000016B3
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000034BD File Offset: 0x000016BD
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000034C6 File Offset: 0x000016C6
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000034D0 File Offset: 0x000016D0
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00003513 File Offset: 0x00001713
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00003520 File Offset: 0x00001720
		internal virtual TextBox txtSerie
		{
			[CompilerGenerated]
			get
			{
				return this._txtSerie;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtSerie_TextChanged);
				TextBox txtSerie = this._txtSerie;
				if (txtSerie != null)
				{
					txtSerie.TextChanged -= value2;
				}
				this._txtSerie = value;
				txtSerie = this._txtSerie;
				if (txtSerie != null)
				{
					txtSerie.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00003563 File Offset: 0x00001763
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000356D File Offset: 0x0000176D
		internal virtual TextBox txtFolio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00003576 File Offset: 0x00001776
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00003580 File Offset: 0x00001780
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000013 RID: 19 RVA: 0x0000358C File Offset: 0x0000178C
		public void ObtenerFOlios()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "SELECT f , al FROM H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Tools.Desencriptar(sqlDataReader[1].ToString().Trim());
					string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					this.txtSerie.Text = text;
					this.txtFolio.Text = text2;
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003621 File Offset: 0x00001821
		private void frmAvisoDistintoTodas_Load(object sender, EventArgs e)
		{
			this.ObtenerFOlios();
			this.Label2.Focus();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003638 File Offset: 0x00001838
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = this.txtSerie.Text;
			string text2 = this.txtFolio.Text;
			string query_conn = string.Concat(new string[]
			{
				"Update H set f = '",
				Tools.Encriptar(text2.ToString().Trim()),
				"' , al='",
				Tools.Encriptar(text.ToString().Trim()),
				"'"
			});
			sqlQuery_Conn.execQuery_conn(query_conn);
			this.txtFolio.Clear();
			this.txtFolio.Clear();
			base.Close();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtSerie_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
