using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200001E RID: 30
	[DesignerGenerated]
	public partial class frmProductos : Form
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x000D0CC0 File Offset: 0x000CEEC0
		public frmProductos()
		{
			base.Load += this.frmProductos_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000D12DD File Offset: 0x000CF4DD
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x000D12E7 File Offset: 0x000CF4E7
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x000D12F0 File Offset: 0x000CF4F0
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x000D12FA File Offset: 0x000CF4FA
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x000D1303 File Offset: 0x000CF503
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x000D1310 File Offset: 0x000CF510
		internal virtual DataGridView dgvProductos
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProductos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvProductos_CellClick);
				DataGridView dgvProductos = this._dgvProductos;
				if (dgvProductos != null)
				{
					dgvProductos.CellContentClick -= value2;
					dgvProductos.CellClick -= value3;
				}
				this._dgvProductos = value;
				dgvProductos = this._dgvProductos;
				if (dgvProductos != null)
				{
					dgvProductos.CellContentClick += value2;
					dgvProductos.CellClick += value3;
				}
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x000D136E File Offset: 0x000CF56E
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x000D1378 File Offset: 0x000CF578
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x000D13BB File Offset: 0x000CF5BB
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x000D13C8 File Offset: 0x000CF5C8
		internal virtual PictureBox PictureBox2
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox2_Click);
				PictureBox pictureBox = this._PictureBox2;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox2 = value;
				pictureBox = this._PictureBox2;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x000D140B File Offset: 0x000CF60B
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x000D1418 File Offset: 0x000CF618
		internal virtual TextBox txtBuscarProducto
		{
			[CompilerGenerated]
			get
			{
				return this._txtBuscarProducto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtBuscarProducto_TextChanged);
				EventHandler value3 = new EventHandler(this.txtBuscarProducto_Click);
				TextBox txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged -= value2;
					txtBuscarProducto.Click -= value3;
				}
				this._txtBuscarProducto = value;
				txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged += value2;
					txtBuscarProducto.Click += value3;
				}
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x000D1478 File Offset: 0x000CF678
		private void frmProductos_Load(object sender, EventArgs e)
		{
			this.txtBuscarProducto.Text = "Buscar Producto...";
			this.iniciaGridFolio();
			this.MostarReporte_Sin_Fitro();
			this.PictureBox2.Visible = false;
			MyProject.Forms.main.PanelConfiguracion.Enabled = false;
			this.PictureBox1.Visible = false;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000D14D8 File Offset: 0x000CF6D8
		private void iniciaGridFolio()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgvProductos.Rows.Clear();
			this.dgvProductos.ColumnCount = 6;
			this.dgvProductos.Columns[0].Name = "id_Producto";
			this.dgvProductos.Columns[0].Visible = false;
			this.dgvProductos.Columns[1].Name = "DESCRIPCION";
			this.dgvProductos.Columns[1].Width = 265;
			this.dgvProductos.Columns[2].Name = "PRECIO";
			this.dgvProductos.Columns[2].Width = 80;
			this.dgvProductos.Columns[3].Name = "PRECIO SIN IMPUESTOS";
			this.dgvProductos.Columns[3].Width = 80;
			this.dgvProductos.Columns[3].Visible = true;
			this.dgvProductos.Columns[4].Name = "id_grupo";
			this.dgvProductos.Columns[4].Width = 70;
			this.dgvProductos.Columns[4].Visible = false;
			this.dgvProductos.Columns[5].Name = "id_clasificacion";
			this.dgvProductos.Columns[5].Width = 70;
			this.dgvProductos.Columns[5].Visible = false;
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Agregar";
			this.dgvProductos.Columns.Add(dataGridViewCheckBoxColumn);
			this.DoubleBufferedASD(this.dgvProductos, true);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000D16C8 File Offset: 0x000CF8C8
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000D16FC File Offset: 0x000CF8FC
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "Select a from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				base.Close();
				MyProject.Forms.main.PanelConfiguracion.Enabled = true;
				MyProject.Forms.main.btnTablas.BackColor = SystemColors.InactiveCaption;
			}
			else
			{
				bool flag = !sqlDataReader.HasRows;
				if (flag)
				{
					Interaction.MsgBox("No puedes salir de esta pantalla sin guardar un producto!", MsgBoxStyle.OkOnly, null);
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000D178C File Offset: 0x000CF98C
		public void MostarReporte()
		{
			SqlQuery sqlQuery = new SqlQuery();
			try
			{
				string query = "select a.idproducto , a.descripcion  , b.precio , b.preciosinimpuestos , g.idgrupo , z.clasificacionventa\r\n                    from productos A \r\n                    INNER JOIN productosdetalle B on b.idproducto = a.idproducto\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = a.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n\t\t\t\t\tWHERE a.Descripcion Like '%" + this.txtBuscarProducto.Text + "%'\r\n\t\t\t\t\torder by descripcion asc";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				this.iniciaGridFolio();
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						string text = Conversions.ToString(sqlDataReader[0]);
						string text2 = Conversions.ToString(sqlDataReader[1]);
						double num = Conversions.ToDouble(sqlDataReader[2]);
						double num2 = Conversions.ToDouble(sqlDataReader[3]);
						string text3 = Conversions.ToString(sqlDataReader[4]);
						string text4 = Conversions.ToString(sqlDataReader[5]);
						this.dgvProductos.Rows.Add(new object[]
						{
							text,
							text2,
							"$ " + num.ToString("N2"),
							"$ " + num2.ToString("N2"),
							text3,
							text4
						});
					}
				}
				sqlDataReader.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000D18DC File Offset: 0x000CFADC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvProductos.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells[3].Value = true;
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
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000D1954 File Offset: 0x000CFB54
		private void btnDesmarcar_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvProductos.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells[3].Value = false;
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
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000D19CC File Offset: 0x000CFBCC
		private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 6;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgvProductos.Rows[rowIndex].Cells["Agregar"].Value, false, false);
				if (flag2)
				{
					this.dgvProductos.Rows[rowIndex].Cells["Agregar"].Value = true;
					this.dgvProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					this.dgvProductos.Enabled = true;
					this.PictureBox2.Visible = true;
					this.PictureBox1.Visible = false;
					MyProject.Forms.main.PanelConfiguracion.Enabled = false;
				}
				else
				{
					this.dgvProductos.Rows[rowIndex].Cells["Agregar"].Value = false;
					this.dgvProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					this.dgvProductos.Enabled = true;
					this.PictureBox2.Visible = false;
					this.PictureBox1.Visible = true;
					MyProject.Forms.main.PanelConfiguracion.Enabled = true;
				}
			}
			this.dgvProductos.ClearSelection();
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000D1B60 File Offset: 0x000CFD60
		private void PictureBox2_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvProductos.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Agregar"].Value, true, false);
					if (flag)
					{
						string text = Conversions.ToString(dataGridViewRow.Cells["id_producto"].Value);
						string text2 = Conversions.ToString(dataGridViewRow.Cells["DESCRIPCION"].Value);
						double num = Conversions.ToDouble(dataGridViewRow.Cells["PRECIO"].Value);
						double num2 = Conversions.ToDouble(dataGridViewRow.Cells["PRECIO SIN IMPUESTOS"].Value);
						string text3 = Conversions.ToString(dataGridViewRow.Cells["id_clasificacion"].Value);
						try
						{
							string query_conn = string.Concat(new string[]
							{
								"Update H set a='",
								Tools.Encriptar(text.ToString().Trim()),
								"' , b='",
								Tools.Encriptar(text2.ToString().Trim()),
								"' , c='",
								Tools.Encriptar(num.ToString("N2").Trim()),
								"',d='",
								Tools.Encriptar(num2.ToString("N2").Trim()),
								"' , e='",
								Tools.Encriptar(text3.ToString().Trim()),
								"'"
							});
							sqlQuery_Conn.execQuery_conn(query_conn);
						}
						catch (Exception ex)
						{
						}
					}
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
			Interaction.MsgBox("Producto guardado exitosamente!", MsgBoxStyle.OkOnly, null);
			base.Close();
			MyProject.Forms.main.PanelConfiguracion.Enabled = true;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000D1DAC File Offset: 0x000CFFAC
		private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
		{
			this.MostarReporte();
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtBuscarProducto_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000D1DB8 File Offset: 0x000CFFB8
		public void MostarReporte_Sin_Fitro()
		{
			SqlQuery sqlQuery = new SqlQuery();
			try
			{
				string query = "select a.idproducto , a.descripcion  , b.precio , b.preciosinimpuestos , g.idgrupo , z.clasificacionventa\r\n                    from productos A \r\n                    INNER JOIN productosdetalle B on b.idproducto = a.idproducto\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = a.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n\t\t\t\t\t\r\n\t\t\t\t\torder by descripcion asc";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				this.iniciaGridFolio();
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						string text = Conversions.ToString(sqlDataReader[0]);
						string text2 = Conversions.ToString(sqlDataReader[1]);
						double num = Conversions.ToDouble(sqlDataReader[2]);
						double num2 = Conversions.ToDouble(sqlDataReader[3]);
						string text3 = Conversions.ToString(sqlDataReader[4]);
						string text4 = Conversions.ToString(sqlDataReader[5]);
						this.dgvProductos.Rows.Add(new object[]
						{
							text,
							text2,
							"$ " + num.ToString("N2"),
							"$ " + num2.ToString("N2"),
							text3,
							text4
						});
					}
				}
				sqlDataReader.Close();
			}
			catch (Exception ex)
			{
			}
		}
	}
}
