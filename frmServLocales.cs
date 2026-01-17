using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional
{
	// Token: 0x02000027 RID: 39
	[DesignerGenerated]
	public partial class frmServLocales : Form
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x00114E29 File Offset: 0x00113029
		public frmServLocales()
		{
			base.Load += this.frmServLocales_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0011511A File Offset: 0x0011331A
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x00115124 File Offset: 0x00113324
		internal virtual DataGridView dgvServidores
		{
			[CompilerGenerated]
			get
			{
				return this._dgvServidores;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvServidores_CellContentClick);
				DataGridViewCellMouseEventHandler value3 = new DataGridViewCellMouseEventHandler(this.dgvServidores_CellMouseDoubleClick);
				DataGridView dgvServidores = this._dgvServidores;
				if (dgvServidores != null)
				{
					dgvServidores.CellContentClick -= value2;
					dgvServidores.CellMouseDoubleClick -= value3;
				}
				this._dgvServidores = value;
				dgvServidores = this._dgvServidores;
				if (dgvServidores != null)
				{
					dgvServidores.CellContentClick += value2;
					dgvServidores.CellMouseDoubleClick += value3;
				}
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00115182 File Offset: 0x00113382
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x0011518C File Offset: 0x0011338C
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060011E7 RID: 4583 RVA: 0x000036D5 File Offset: 0x000018D5
		private void frmServLocales_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00115198 File Offset: 0x00113398
		public object inicializa(string[] strServName, string[] strInstanceName)
		{
			this.dgvServidores.ColumnCount = 1;
			this.dgvServidores.Columns[0].Name = "Servidor";
			this.dgvServidores.Columns[0].Width = 200;
			checked
			{
				int num = strServName.Count<string>() - 2;
				for (int i = 0; i <= num; i++)
				{
					this.dgvServidores.Rows.Add(new object[]
					{
						strServName[i]
					});
				}
				base.ShowDialog();
				return this.strServNameAux;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvServidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00115230 File Offset: 0x00113430
		private void dgvServidores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.ColumnIndex >= 0;
			if (flag)
			{
				int rowIndex = e.RowIndex;
				this.strServNameAux = this.dgvServidores.Rows[Conversions.ToInteger(rowIndex.ToString())].Cells[0].Value.ToString();
				base.Close();
			}
		}

		// Token: 0x040007EF RID: 2031
		private string strServNameAux;
	}
}
