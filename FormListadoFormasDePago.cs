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

namespace ModuloAdicional
{
	// Token: 0x02000007 RID: 7
	[DesignerGenerated]
	public partial class FormListadoFormasDePago : Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000490C File Offset: 0x00002B0C
		public FormListadoFormasDePago()
		{
			base.Load += this.FormListadoFormasDePago_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00005C8B File Offset: 0x00003E8B
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00005C95 File Offset: 0x00003E95
		internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00005C9E File Offset: 0x00003E9E
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00005CA8 File Offset: 0x00003EA8
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005CB1 File Offset: 0x00003EB1
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00005CBC File Offset: 0x00003EBC
		internal virtual PictureBox PictureBox3
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox3_Click);
				PictureBox pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox3 = value;
				pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00005CFF File Offset: 0x00003EFF
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00005D0C File Offset: 0x00003F0C
		internal virtual DataGridView DgvFormasPago
		{
			[CompilerGenerated]
			get
			{
				return this._DgvFormasPago;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DgvFormasPago_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DgvFormasPago_CellValueChanged);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.DgvFormasPago_CellLeave);
				CancelEventHandler value5 = new CancelEventHandler(this.DgvFormasPago_Validating);
				DataGridViewCellValidatingEventHandler value6 = new DataGridViewCellValidatingEventHandler(this.DgvFormasPago_CellValidating);
				DataGridViewCellEventHandler value7 = new DataGridViewCellEventHandler(this.DgvFormasPago_CellEndEdit);
				DataGridView dgvFormasPago = this._DgvFormasPago;
				if (dgvFormasPago != null)
				{
					dgvFormasPago.CellContentClick -= value2;
					dgvFormasPago.CellValueChanged -= value3;
					dgvFormasPago.CellLeave -= value4;
					dgvFormasPago.Validating -= value5;
					dgvFormasPago.CellValidating -= value6;
					dgvFormasPago.CellEndEdit -= value7;
				}
				this._DgvFormasPago = value;
				dgvFormasPago = this._DgvFormasPago;
				if (dgvFormasPago != null)
				{
					dgvFormasPago.CellContentClick += value2;
					dgvFormasPago.CellValueChanged += value3;
					dgvFormasPago.CellLeave += value4;
					dgvFormasPago.Validating += value5;
					dgvFormasPago.CellValidating += value6;
					dgvFormasPago.CellEndEdit += value7;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00005DEC File Offset: 0x00003FEC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00005DF6 File Offset: 0x00003FF6
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005DFF File Offset: 0x00003FFF
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005E09 File Offset: 0x00004009
		internal virtual TextBox txtCambio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00005E12 File Offset: 0x00004012
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005E1C File Offset: 0x0000401C
		internal virtual TextBox txtTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00005E25 File Offset: 0x00004025
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005E2F File Offset: 0x0000402F
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005E38 File Offset: 0x00004038
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005E42 File Offset: 0x00004042
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00005E4B File Offset: 0x0000404B
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005E55 File Offset: 0x00004055
		internal virtual TextBox txtPropia { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005E5E File Offset: 0x0000405E
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00005E68 File Offset: 0x00004068
		internal virtual TextBox txtConsumo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00005E71 File Offset: 0x00004071
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00005E7B File Offset: 0x0000407B
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005E84 File Offset: 0x00004084
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00005E8E File Offset: 0x0000408E
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005E97 File Offset: 0x00004097
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00005EA1 File Offset: 0x000040A1
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005EAA File Offset: 0x000040AA
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00005EB4 File Offset: 0x000040B4
		internal virtual TextBox txtSaldoFinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005EBD File Offset: 0x000040BD
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00005EC7 File Offset: 0x000040C7
		internal virtual TextBox txtSaldoPendiente { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00005ED0 File Offset: 0x000040D0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00005EDA File Offset: 0x000040DA
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00005EE3 File Offset: 0x000040E3
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00005EF0 File Offset: 0x000040F0
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00005F33 File Offset: 0x00004133
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00005F40 File Offset: 0x00004140
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00005F83 File Offset: 0x00004183
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00005F8D File Offset: 0x0000418D
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00005F96 File Offset: 0x00004196
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00005FA0 File Offset: 0x000041A0
		internal virtual Label lblFoliodelticket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00005FA9 File Offset: 0x000041A9
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00005FB3 File Offset: 0x000041B3
		internal virtual Label lblnumcheque { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00005FBC File Offset: 0x000041BC
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00005FC6 File Offset: 0x000041C6
		internal virtual Label lblserie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000062 RID: 98 RVA: 0x00005FD0 File Offset: 0x000041D0
		private void iniciaGridFiormasPago()
		{
			this.DgvFormasPago.Rows.Clear();
			this.DgvFormasPago.ColumnCount = 7;
			this.DgvFormasPago.Columns[0].Name = "Clave";
			this.DgvFormasPago.Columns[0].Width = 65;
			this.DgvFormasPago.Columns[0].ReadOnly = true;
			this.DgvFormasPago.Columns[1].Name = "Descripcion";
			this.DgvFormasPago.Columns[1].Width = 300;
			this.DgvFormasPago.Columns[1].ReadOnly = true;
			this.DgvFormasPago.Columns[2].Name = "Importe";
			this.DgvFormasPago.Columns[2].Width = 130;
			this.DgvFormasPago.Columns[3].Name = "Propina";
			this.DgvFormasPago.Columns[3].Width = 130;
			this.DgvFormasPago.Columns[4].Name = "Importe Total";
			this.DgvFormasPago.Columns[4].Width = 130;
			this.DgvFormasPago.Columns[4].ReadOnly = true;
			this.DgvFormasPago.Columns[5].Name = "Tipo";
			this.DgvFormasPago.Columns[5].Width = 100;
			this.DgvFormasPago.Columns[5].Visible = false;
			this.DgvFormasPago.Columns[6].Name = "Tipo de Cambio";
			this.DgvFormasPago.Columns[6].Width = 100;
			this.DgvFormasPago.Columns[6].Visible = false;
			this.DoubleBufferedASD(this.DgvFormasPago, true);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006204 File Offset: 0x00004404
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006238 File Offset: 0x00004438
		public void MostrarFormasDePago()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select idformadepago ,descripcion , tipo , tipodecambio from formasdepago where visible = '1'";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.iniciaGridFiormasPago();
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					int num = Conversions.ToInteger(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					this.DgvFormasPago.Rows.Add(new object[]
					{
						text,
						text2,
						"0.00",
						"0.00",
						"0.00",
						num,
						num2.ToString("N2")
					});
				}
			}
			sqlDataReader.Close();
			this.DgvFormasPago.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000633C File Offset: 0x0000453C
		private void FormListadoFormasDePago_Load(object sender, EventArgs e)
		{
			this.txtConsumo.Text = Tools.Consumo.ToString("N2");
			this.txtTotal.Text = Tools.Consumo.ToString("N2");
			this.txtCambio.Text = "0.00";
			this.txtPropia.Text = "0.00";
			this.txtSaldoFinal.Text = "0.00";
			this.txtSaldoPendiente.Text = Tools.Consumo.ToString("N2");
			this.MostrarFormasDePago();
			this.lblFoliodelticket.Text = Tools.FolioRedBull;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000063E6 File Offset: 0x000045E6
		private void Button1_Click(object sender, EventArgs e)
		{
			Tools.ActualizaFormaPagoCuentas = 0;
			base.Close();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000036D5 File Offset: 0x000018D5
		private void DgvFormasPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000063F8 File Offset: 0x000045F8
		private void DgvFormasPago_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				bool flag = this.DgvFormasPago[2, e.RowIndex].Value != null;
				if (flag)
				{
					num = Conversions.ToDouble(this.DgvFormasPago[2, e.RowIndex].Value);
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("El valor IMPORTE tiene que ser numerico!", MsgBoxStyle.OkOnly, null);
				return;
			}
			try
			{
				bool flag2 = this.DgvFormasPago[3, e.RowIndex].Value != null;
				if (flag2)
				{
					num2 = Conversions.ToDouble(this.DgvFormasPago[3, e.RowIndex].Value);
				}
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox("El valor PROPINA tiene que ser numerico!!", MsgBoxStyle.OkOnly, null);
				return;
			}
			double a = num + num2;
			double num3 = Conversions.ToDouble(Math.Round(a).ToString("N2"));
			this.DgvFormasPago[4, e.RowIndex].Value = num3.ToString("N2");
			try
			{
				foreach (object obj in ((IEnumerable)this.DgvFormasPago.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					double num4 = Conversions.ToDouble(Operators.AddObject(num4, dataGridViewRow.Cells["Propina"].Value));
					double num5 = Conversions.ToDouble(Operators.AddObject(num5, dataGridViewRow.Cells["Importe"].Value));
					this.txtPropia.Text = num4.ToString("N2");
					this.txtSaldoFinal.Text = num5.ToString("N2");
					double num6 = Conversions.ToDouble(this.txtConsumo.Text);
					double num7 = Conversions.ToDouble((num6 - num5).ToString("N2"));
					this.txtSaldoPendiente.Text = num7.ToString("N2");
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

		// Token: 0x06000069 RID: 105 RVA: 0x000066AC File Offset: 0x000048AC
		private void DgvFormasPago_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = this.DgvFormasPago[2, e.RowIndex].Value != null;
				if (flag)
				{
					double num = Conversions.ToDouble(this.DgvFormasPago[2, e.RowIndex].Value);
					this.DgvFormasPago[2, e.RowIndex].Value = num.ToString("N2");
				}
				else
				{
					this.DgvFormasPago[2, e.RowIndex].Value = "0.00";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006760 File Offset: 0x00004960
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.lblFoliodelticket.Text;
			string text2 = Conversions.ToString(0);
			string text3 = Conversions.ToString(0);
			double num = Conversions.ToDouble(this.txtPropia.Text);
			double num2 = Conversions.ToDouble(this.txtSaldoPendiente.Text);
			double num3 = Conversions.ToDouble(this.txtSaldoFinal.Text);
			double num4 = Conversions.ToDouble(this.txtTotal.Text);
			Tools.ActualizaFormaPagoCuentas = 0;
			bool flag = num3 <= 0.0 & num4 != 0.0;
			if (flag)
			{
				Interaction.MsgBox("Captura los IMPORTES de la Cuenta en el listado de Formas de Pago!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = num2 < 0.0;
				if (flag2)
				{
					Interaction.MsgBox("El SALDO debe ser igual a 0!", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					bool flag3 = num4 != num3;
					if (flag3)
					{
						Interaction.MsgBox("La suma de los  IMPORTES de las formas de Pago debe ser igual al TOTAL de la cuenta!", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						bool flag4 = num4 == num3;
						if (flag4)
						{
							string query = "DELETE FROM ChequesPagos where folio = '" + text + "'";
							sqlQuery.execQuery(query);
							query = "DELETE FROM Cheqdet where foliodet = '" + text + "'";
							sqlQuery.execQuery(query);
							query = string.Concat(new string[]
							{
								"UPDATE CHEQUES SET Descuento ='",
								Tools.DescuentoMia_Renta.ToString("N2"),
								"' where folio = '",
								text,
								"'"
							});
							sqlQuery.execQuery(query);
							query = "SELECT propinafoliomovtocaja FROM cheques WHERE folio='" + text + "'";
							SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
							bool flag5 = sqlDataReader.Read();
							if (flag5)
							{
								string text4 = Conversions.ToString(sqlDataReader[0]);
								bool flag6 = Conversions.ToDouble(text4) != 0.0;
								if (flag6)
								{
									query = string.Concat(new string[]
									{
										"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
										Tools.NumchequeDelticketLG.ToString(),
										"' and  seriefolio = '",
										Tools.SerieDelTicketLG,
										"') where folio=  '",
										text4,
										"'"
									});
									sqlQuery.execQuery(query);
									query = string.Concat(new string[]
									{
										"update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='",
										Tools.NumchequeDelticketLG.ToString(),
										"' and  seriefolio = '",
										Tools.SerieDelTicketLG,
										"'"
									});
									sqlQuery.execQuery(query);
								}
							}
							sqlDataReader.Close();
							query = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00'  where folio= '" + text + "'";
							sqlQuery.execQuery(query);
							try
							{
								foreach (object obj in ((IEnumerable)this.DgvFormasPago.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									bool flag7 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["Importe"].Value, 0.0, false);
									if (flag7)
									{
										string text5 = Conversions.ToString(dataGridViewRow.Cells["Clave"].Value);
										double num5 = Conversions.ToDouble(dataGridViewRow.Cells["Importe"].Value);
										double num6 = Conversions.ToDouble(dataGridViewRow.Cells["Propina"].Value);
										query = "SELECT TipodeCambio from formasdepago WHERE idformadepago='" + text5 + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
										bool flag8 = sqlDataReader.Read();
										double num7;
										if (flag8)
										{
											num7 = Conversions.ToDouble(sqlDataReader[0]);
										}
										sqlDataReader.Close();
										query = "SELECT idturno from cheques WHERE folio='" + text + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
										bool flag9 = sqlDataReader.Read();
										if (flag9)
										{
											text3 = Conversions.ToString(sqlDataReader[0]);
										}
										sqlDataReader.Close();
										query = string.Concat(new string[]
										{
											"INSERT INTO ChequesPagos (folio,idformadepago,importe,propina,tipodecambio,idturno_cierre,procesado,sistema_envio)\r\n                            VALUES\r\n                            ('",
											text.ToString(),
											"','",
											text5.ToString(),
											"','",
											num5.ToString("N2"),
											"','",
											num6.ToString("N2"),
											"','",
											num7.ToString("N2"),
											"','",
											text3,
											"','1','1')"
										});
										sqlQuery.execQuery(query);
										query = string.Concat(new string[]
										{
											"Update cheques set Propina= propina + '",
											num6.ToString("N2"),
											"' WHERE folio= '",
											text,
											"'"
										});
										sqlQuery.execQuery(query);
										query = "SELECT tipo FROM FormasdePago Where idformadepago='" + text5 + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
										bool flag10 = sqlDataReader.Read();
										if (flag10)
										{
											int num8 = Conversions.ToInteger(sqlDataReader[0]);
											bool flag11 = num8 == 1;
											if (flag11)
											{
												query = string.Concat(new string[]
												{
													"Update cheques set efectivo='",
													num5.ToString("N2"),
													"' WHERE folio= '",
													text,
													"'"
												});
												sqlQuery.execQuery(query);
											}
											bool flag12 = num8 == 2;
											if (flag12)
											{
												query = string.Concat(new string[]
												{
													"Update cheques set tarjeta='",
													num5.ToString("N2"),
													"' WHERE folio= '",
													text,
													"'"
												});
												sqlQuery.execQuery(query);
											}
											bool flag13 = num8 == 3;
											if (flag13)
											{
												query = string.Concat(new string[]
												{
													"Update cheques set vales='",
													num5.ToString("N2"),
													"' WHERE folio= '",
													text,
													"'"
												});
												sqlQuery.execQuery(query);
											}
											bool flag14 = num8 == 4;
											if (flag14)
											{
												query = string.Concat(new string[]
												{
													"Update cheques set Otros='",
													num5.ToString("N2"),
													"' WHERE folio= '",
													text,
													"'"
												});
												sqlQuery.execQuery(query);
											}
										}
										sqlDataReader.Close();
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
							Tools.ActualizaFormaPagoCuentas = 1;
							base.Close();
						}
						else
						{
							bool flag15 = num3 <= 0.0 & num4 == 0.0;
							if (flag15)
							{
								string query = "DELETE FROM ChequesPagos where folio = '" + text + "'";
								sqlQuery.execQuery(query);
								query = "DELETE FROM Cheqdet where foliodet = '" + text + "'";
								sqlQuery.execQuery(query);
								query = string.Concat(new string[]
								{
									"UPDATE CHEQUES SET Descuento ='",
									Tools.DescuentoMia_Renta.ToString("N2"),
									"' where folio = '",
									text,
									"'"
								});
								sqlQuery.execQuery(query);
								query = "SELECT propinafoliomovtocaja FROM cheques WHERE folio='" + text + "'";
								SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
								bool flag16 = sqlDataReader.Read();
								if (flag16)
								{
									string text4 = Conversions.ToString(sqlDataReader[0]);
									bool flag17 = Conversions.ToDouble(text4) != 0.0;
									if (flag17)
									{
										query = string.Concat(new string[]
										{
											"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
											Tools.NumchequeDelticketLG.ToString(),
											"' and  seriefolio = '",
											Tools.SerieDelTicketLG,
											"') where folio=  '",
											text4,
											"'"
										});
										sqlQuery.execQuery(query);
										query = string.Concat(new string[]
										{
											"update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='",
											Tools.NumchequeDelticketLG.ToString(),
											"' and  seriefolio = '",
											Tools.SerieDelTicketLG,
											"'"
										});
										sqlQuery.execQuery(query);
									}
								}
								sqlDataReader.Close();
								query = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00'  where folio= '" + text + "'";
								sqlQuery.execQuery(query);
								try
								{
									foreach (object obj2 in ((IEnumerable)this.DgvFormasPago.Rows))
									{
										DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
										bool flag18 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow2.Cells["Importe"].Value, 0.0, false);
										if (flag18)
										{
											string text5 = Conversions.ToString(dataGridViewRow2.Cells["Clave"].Value);
											double num5 = Conversions.ToDouble(dataGridViewRow2.Cells["Importe"].Value);
											double num6 = Conversions.ToDouble(dataGridViewRow2.Cells["Propina"].Value);
											query = "SELECT TipodeCambio from formasdepago WHERE idformadepago='" + text5 + "'";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
											bool flag19 = sqlDataReader.Read();
											double num7;
											if (flag19)
											{
												num7 = Conversions.ToDouble(sqlDataReader[0]);
											}
											sqlDataReader.Close();
											query = "SELECT idturno from cheques WHERE folio='" + text + "'";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
											bool flag20 = sqlDataReader.Read();
											if (flag20)
											{
												text3 = Conversions.ToString(sqlDataReader[0]);
											}
											sqlDataReader.Close();
											query = string.Concat(new string[]
											{
												"INSERT INTO ChequesPagos (folio,idformadepago,importe,propina,tipodecambio,idturno_cierre,procesado,sistema_envio)\r\n                            VALUES\r\n                            ('",
												text.ToString(),
												"','",
												text5.ToString(),
												"','",
												num5.ToString("N2"),
												"','",
												num6.ToString("N2"),
												"','",
												num7.ToString("N2"),
												"','",
												text3,
												"','1','1')"
											});
											sqlQuery.execQuery(query);
											query = string.Concat(new string[]
											{
												"Update cheques set Propina= propina + '",
												num6.ToString("N2"),
												"' WHERE folio= '",
												text,
												"'"
											});
											sqlQuery.execQuery(query);
											query = "SELECT tipo FROM FormasdePago Where idformadepago='" + text5 + "'";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
											bool flag21 = sqlDataReader.Read();
											if (flag21)
											{
												int num8 = Conversions.ToInteger(sqlDataReader[0]);
												bool flag22 = num8 == 1;
												if (flag22)
												{
													query = string.Concat(new string[]
													{
														"Update cheques set efectivo='",
														num5.ToString("N2"),
														"' WHERE folio= '",
														text,
														"'"
													});
													sqlQuery.execQuery(query);
												}
												bool flag23 = num8 == 2;
												if (flag23)
												{
													query = string.Concat(new string[]
													{
														"Update cheques set tarjeta='",
														num5.ToString("N2"),
														"' WHERE folio= '",
														text,
														"'"
													});
													sqlQuery.execQuery(query);
												}
												bool flag24 = num8 == 3;
												if (flag24)
												{
													query = string.Concat(new string[]
													{
														"Update cheques set vales='",
														num5.ToString("N2"),
														"' WHERE folio= '",
														text,
														"'"
													});
													sqlQuery.execQuery(query);
												}
												bool flag25 = num8 == 4;
												if (flag25)
												{
													query = string.Concat(new string[]
													{
														"Update cheques set Otros='",
														num5.ToString("N2"),
														"' WHERE folio= '",
														text,
														"'"
													});
													sqlQuery.execQuery(query);
												}
											}
											sqlDataReader.Close();
										}
									}
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
								Tools.ActualizaFormaPagoCuentas = 1;
								base.Close();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000063E6 File Offset: 0x000045E6
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			Tools.ActualizaFormaPagoCuentas = 0;
			base.Close();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000036D5 File Offset: 0x000018D5
		private void DgvFormasPago_Validating(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000733C File Offset: 0x0000553C
		private void DgvFormasPago_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = Operators.CompareString(this.DgvFormasPago.Columns[e.ColumnIndex].Name, "Importe", false) == 0;
			if (flag)
			{
				bool flag2 = string.IsNullOrEmpty(e.FormattedValue.ToString());
				if (flag2)
				{
					Interaction.MsgBox("El importe no puede quedar vacio!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag3 = Operators.CompareString(this.DgvFormasPago.Columns[e.ColumnIndex].Name, "Propina", false) == 0;
			if (flag3)
			{
				bool flag4 = string.IsNullOrEmpty(e.FormattedValue.ToString());
				if (flag4)
				{
					Interaction.MsgBox("La Propina no puede quedar vacia!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag5 = e.ColumnIndex == 2;
			if (flag5)
			{
				bool flag6 = !Versioned.IsNumeric(e.FormattedValue.ToString());
				if (flag6)
				{
					MessageBox.Show("Valor invalido columna : Importe - Ingresa un valor numerico!");
					this.DgvFormasPago.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag7 = e.ColumnIndex == 2;
			if (flag7)
			{
				bool flag8 = Operators.ConditionalCompareObjectLess(e.FormattedValue, 0, false);
				if (flag8)
				{
					Interaction.MsgBox("Valor invalido columna : Importe - Ingresa un valor igual o  mayor a 0!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
			}
			bool flag9 = e.ColumnIndex == 3;
			if (flag9)
			{
				bool flag10 = !Versioned.IsNumeric(e.FormattedValue.ToString());
				if (flag10)
				{
					MessageBox.Show("Valor invalido columna : Propina - Ingresa un valor numerico!");
					this.DgvFormasPago.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag11 = e.ColumnIndex == 3;
			if (flag11)
			{
				bool flag12 = Operators.ConditionalCompareObjectLess(e.FormattedValue, 0, false);
				if (flag12)
				{
					Interaction.MsgBox("Valor invalido columna : Propina - Ingresa un valor igual o  mayor a 0!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
				}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007598 File Offset: 0x00005798
		private void DgvFormasPago_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				bool flag = this.DgvFormasPago[2, e.RowIndex].Value != null;
				if (flag)
				{
					num = Conversions.ToDouble(this.DgvFormasPago[2, e.RowIndex].Value);
				}
			}
			catch (Exception ex)
			{
				return;
			}
			try
			{
				bool flag2 = this.DgvFormasPago[3, e.RowIndex].Value != null;
				if (flag2)
				{
					num2 = Conversions.ToDouble(this.DgvFormasPago[3, e.RowIndex].Value);
				}
			}
			catch (Exception ex2)
			{
				return;
			}
			double a = num + num2;
			double num3 = Conversions.ToDouble(Math.Round(a).ToString("N2"));
			this.DgvFormasPago[4, e.RowIndex].Value = num3.ToString("N2");
			try
			{
				foreach (object obj in ((IEnumerable)this.DgvFormasPago.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					double num4 = Conversions.ToDouble(Operators.AddObject(num4, dataGridViewRow.Cells["Propina"].Value));
					double num5 = Conversions.ToDouble(Operators.AddObject(num5, dataGridViewRow.Cells["Importe"].Value));
					this.txtPropia.Text = num4.ToString("N2");
					this.txtSaldoFinal.Text = num5.ToString("N2");
					double num6 = Conversions.ToDouble(this.txtConsumo.Text);
					double num7 = Conversions.ToDouble((num6 - num5).ToString("N2"));
					this.txtSaldoPendiente.Text = num7.ToString("N2");
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
	}
}
