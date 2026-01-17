using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional
{
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public partial class frmEliminarProdFormasdePago : Form
	{
		// Token: 0x060005EB RID: 1515 RVA: 0x000541A4 File Offset: 0x000523A4
		public frmEliminarProdFormasdePago()
		{
			base.Load += this.frmEliminarProdFormasdePago_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00054654 File Offset: 0x00052854
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0005465E File Offset: 0x0005285E
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00054667 File Offset: 0x00052867
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00054671 File Offset: 0x00052871
		internal virtual PictureBox btnEliminarProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0005467A File Offset: 0x0005287A
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00054684 File Offset: 0x00052884
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0005468D File Offset: 0x0005288D
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00054698 File Offset: 0x00052898
		internal virtual DataGridView dgvNotas
		{
			[CompilerGenerated]
			get
			{
				return this._dgvNotas;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvNotas_CellClick);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick -= value2;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick += value2;
				}
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000546DC File Offset: 0x000528DC
		public void MosstrarFormasdePago()
		{
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 7;
			this.dgvNotas.Columns[0].Name = "id_nota";
			this.dgvNotas.Columns[0].Visible = false;
			this.dgvNotas.Columns[1].Name = "ID";
			this.dgvNotas.Columns[1].Width = 50;
			this.dgvNotas.Columns[2].Name = "Descripcion";
			this.dgvNotas.Columns[2].Width = 200;
			this.dgvNotas.Columns[3].Name = "Importe";
			this.dgvNotas.Columns[3].Width = 70;
			this.dgvNotas.Columns[3].Visible = true;
			this.dgvNotas.Columns[4].Name = "Propina";
			this.dgvNotas.Columns[4].Width = 70;
			this.dgvNotas.Columns[5].Name = "idTipo";
			this.dgvNotas.Columns[5].Width = 70;
			this.dgvNotas.Columns[5].Visible = false;
			this.dgvNotas.Columns[6].Name = "Tipo";
			this.dgvNotas.Columns[6].Width = 135;
			dataGridViewButtonColumn.Width = 60;
			dataGridViewButtonColumn.Name = "Aplicar";
			this.dgvNotas.Columns.Add(dataGridViewButtonColumn);
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000548EC File Offset: 0x00052AEC
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0005491E File Offset: 0x00052B1E
		private void frmEliminarProdFormasdePago_Load(object sender, EventArgs e)
		{
			this.MosstrarFormasdePago();
			this.DEtalleFormaDePago();
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00054930 File Offset: 0x00052B30
		public void DEtalleFormaDePago()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "Select folio , a.idformadepago ,b.descripcion, importe , propina , b.tipo from Chequespagos A \r\n                    INNER JOIN formasdepago B on b.idformadepago = a.idformadepago\r\n                    where folio='" + Tools.FoliodetFormaPago + "'";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.MosstrarFormasdePago();
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					string text3 = Conversions.ToString(sqlDataReader[2]);
					double num = Conversions.ToDouble(sqlDataReader[3]);
					double num2 = Conversions.ToDouble(sqlDataReader[4]);
					int num3 = Conversions.ToInteger(sqlDataReader[5]);
					bool flag = num3 == 1;
					if (flag)
					{
						this.DescripTipo = "EFECTIVO";
					}
					bool flag2 = num3 == 2;
					if (flag2)
					{
						this.DescripTipo = "TARJETA";
					}
					bool flag3 = num3 == 3;
					if (flag3)
					{
						this.DescripTipo = "VALES";
					}
					bool flag4 = num3 == 4;
					if (flag4)
					{
						this.DescripTipo = "CREDITO";
					}
					this.dgvNotas.Rows.Add(new object[]
					{
						text,
						text2,
						text3,
						num,
						num2,
						num3,
						this.DescripTipo
					});
				}
			}
			sqlDataReader.Close();
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00054AA8 File Offset: 0x00052CA8
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 7;
			if (flag)
			{
				Tools.idtipo = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["idTipo"].Value);
				Tools.idFormadePago1Tomas = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["ID"].Value);
				base.Close();
			}
		}

		// Token: 0x040002B8 RID: 696
		private string DescripTipo;
	}
}
