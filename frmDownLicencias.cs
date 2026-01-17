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
using MySql.Data.MySqlClient;

namespace ModuloAdicional
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class frmDownLicencias : Form
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0001ED88 File Offset: 0x0001CF88
		public frmDownLicencias()
		{
			base.Load += this.frmDownLicencias_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001F4CC File Offset: 0x0001D6CC
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0001F4D6 File Offset: 0x0001D6D6
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0001F4DF File Offset: 0x0001D6DF
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0001F4E9 File Offset: 0x0001D6E9
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001F4F2 File Offset: 0x0001D6F2
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0001F4FC File Offset: 0x0001D6FC
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0001F505 File Offset: 0x0001D705
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0001F50F File Offset: 0x0001D70F
		internal virtual DataGridView dgvNotas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001F518 File Offset: 0x0001D718
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0001F522 File Offset: 0x0001D722
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001F52B File Offset: 0x0001D72B
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0001F538 File Offset: 0x0001D738
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001F57B File Offset: 0x0001D77B
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0001F588 File Offset: 0x0001D788
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001F5CB File Offset: 0x0001D7CB
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0001F5D5 File Offset: 0x0001D7D5
		internal virtual Timer Timer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0001F5DE File Offset: 0x0001D7DE
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
		internal virtual Label lblfechahoy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000316 RID: 790 RVA: 0x0001F5F4 File Offset: 0x0001D7F4
		private void frmDownLicencias_Load(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.lblfechahoy.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
			this.iniciaGridLicencias();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "Select ai from h";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				this.Codigo_Empresa = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
			}
			try
			{
				this.strMySqlConnection = "Server=www.gordolobosoft.com;Database=comicx7_Licencias;User Id=comicx7_ReporteHunterBi;Password=i?$bvJFNDbDo;SslMode=none;";
				this.MySqlConRemoto = new MySqlConnection(this.strMySqlConnection);
				this.MySqlCmdRemoto = this.MySqlConRemoto.CreateCommand();
				this.MySqlConRemoto.Open();
				this.MySqlCmdRemoto.CommandText = "select * from Licencias";
				this.MySqlDRremoto = this.MySqlCmdRemoto.ExecuteReader();
				this.MySqlDRremoto.Read();
				this.MySqlDRremoto.Close();
				this.MySqlCmdRemoto.CommandText = "select idEmpresa , a, b, c, Status  from Licencias where idEmpresa='" + this.Codigo_Empresa + "'";
				this.MySqlDRremoto = this.MySqlCmdRemoto.ExecuteReader();
				bool hasRows = this.MySqlDRremoto.HasRows;
				if (hasRows)
				{
					while (this.MySqlDRremoto.Read())
					{
						string text = this.MySqlDRremoto[0].ToString();
						string text2 = this.MySqlDRremoto[1].ToString();
						string text3 = this.MySqlDRremoto[2].ToString();
						string text4 = this.MySqlDRremoto[3].ToString();
						string text5 = this.MySqlDRremoto[4].ToString();
						bool flag2 = Operators.CompareString(text5, "3", false) == 0;
						if (flag2)
						{
							text5 = "PENDIENTE";
						}
						bool flag3 = Operators.CompareString(text5, "0", false) == 0;
						if (flag3)
						{
							text5 = "CANCELADO";
						}
						this.dgvNotas.Rows.Add(new object[]
						{
							text,
							text3,
							text4,
							text5,
							text2
						});
					}
				}
				this.MySqlDRremoto.Close();
				this.dgvNotas.ClearSelection();
				this.Button1.PerformClick();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("No existe conexion con el Servidor Web , revisa tu conexion a internet!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0001F86C File Offset: 0x0001DA6C
		private void iniciaGridLicencias()
		{
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 5;
			this.dgvNotas.Columns[0].Name = "Empresa";
			this.dgvNotas.Columns[0].Visible = true;
			this.dgvNotas.Columns[0].Width = 80;
			this.dgvNotas.Columns[1].Name = "Año";
			this.dgvNotas.Columns[1].Width = 70;
			this.dgvNotas.Columns[2].Name = "Mes";
			this.dgvNotas.Columns[2].Width = 70;
			this.dgvNotas.Columns[3].Name = "Estado";
			this.dgvNotas.Columns[3].Width = 80;
			this.dgvNotas.Columns[4].Name = "Licencia";
			this.dgvNotas.Columns[4].Width = 306;
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0001F9CC File Offset: 0x0001DBCC
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0001FA00 File Offset: 0x0001DC00
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			try
			{
				this.strMySqlConnection = "Server=www.gordolobosoft.com;Database=comicx7_Licencias;User Id=comicx7_ReporteHunterBi;Password=i?$bvJFNDbDo;SslMode=none;";
				this.MySqlConRemoto = new MySqlConnection(this.strMySqlConnection);
				this.MySqlCmdRemoto = this.MySqlConRemoto.CreateCommand();
				this.MySqlConRemoto.Open();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("No existe conexion con el Servidor Web , revisa tu conexion a internet!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Estado"].Value, "PENDIENTE", false);
					if (flag)
					{
						string text = Conversions.ToString(dataGridViewRow.Cells["Licencia"].Value);
						string text2 = Conversions.ToString(dataGridViewRow.Cells["Año"].Value);
						string text3 = Conversions.ToString(dataGridViewRow.Cells["Mes"].Value);
						string query_conn = "select * from G where a = '" + text.ToString() + "'";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
						bool hasRows = sqlDataReader.HasRows;
						if (hasRows)
						{
							query_conn = string.Concat(new string[]
							{
								"UPDATE G SET a = '",
								text.ToString(),
								"' WHERE b='",
								text2.ToString(),
								"' and c = '",
								text3.ToString(),
								"'"
							});
							sqlQuery_Conn.execQuery_conn(query_conn);
							try
							{
								this.MySqlCmdRemoto.CommandText = string.Concat(new string[]
								{
									"UPDATE Licencias Set Status=1 , Fecha_Descarga='",
									this.lblfechahoy.Text,
									"' WHERE  idEmpresa ='",
									this.Codigo_Empresa.ToString(),
									"' AND a='",
									text.ToString(),
									"' AND b='",
									text2.ToString(),
									"' and c = '",
									text3.ToString(),
									"' "
								});
								this.MySqlCmdRemoto.ExecuteNonQuery();
							}
							catch (Exception ex2)
							{
								Interaction.MsgBox("No existe conexion con el Servidor Web , revisa tu conexion a internet!", MsgBoxStyle.OkOnly, null);
							}
						}
						else
						{
							query_conn = string.Concat(new string[]
							{
								"INSERT INTO G (a,b,c) values ('",
								text.ToString(),
								"' , '",
								text2.ToString(),
								"' , '",
								text3.ToString(),
								"')"
							});
							sqlQuery_Conn.execQuery_conn(query_conn);
							try
							{
								this.MySqlCmdRemoto.CommandText = string.Concat(new string[]
								{
									"UPDATE Licencias Set Status=1 , Fecha_Descarga='",
									this.lblfechahoy.Text,
									"' WHERE  idEmpresa ='",
									this.Codigo_Empresa.ToString(),
									"' AND a='",
									text.ToString(),
									"' AND b='",
									text2.ToString(),
									"' and c = '",
									text3.ToString(),
									"' "
								});
								this.MySqlCmdRemoto.ExecuteNonQuery();
							}
							catch (Exception ex3)
							{
								Interaction.MsgBox("No existe conexion con el Servidor Web , revisa tu conexion a internet!", MsgBoxStyle.OkOnly, null);
							}
						}
						sqlDataReader.Close();
					}
					bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Estado"].Value, "CANCELADO", false);
					if (flag2)
					{
						string text = Conversions.ToString(dataGridViewRow.Cells["Licencia"].Value);
						string text2 = Conversions.ToString(dataGridViewRow.Cells["Año"].Value);
						string text3 = Conversions.ToString(dataGridViewRow.Cells["Mes"].Value);
						string query_conn = string.Concat(new string[]
						{
							"DELETE FROM G where a = '",
							text.ToString(),
							"' and b='",
							text2.ToString(),
							"' and c='",
							text3.ToString(),
							"'"
						});
						sqlQuery_Conn.execQuery_conn(query_conn);
						try
						{
							this.MySqlCmdRemoto.CommandText = string.Concat(new string[]
							{
								"UPDATE Licencias Set Status=4 , Fecha_Cancela='",
								this.lblfechahoy.Text,
								"' WHERE  idEmpresa ='",
								this.Codigo_Empresa.ToString(),
								"' AND a='",
								text.ToString(),
								"' AND b='",
								text2.ToString(),
								"' and c = '",
								text3.ToString(),
								"' "
							});
							this.MySqlCmdRemoto.ExecuteNonQuery();
						}
						catch (Exception ex4)
						{
							Interaction.MsgBox("No existe conexion con el Servidor Web , revisa tu conexion a internet!", MsgBoxStyle.OkOnly, null);
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
			Interaction.MsgBox("Licencias descargadas correctamente!", MsgBoxStyle.OkOnly, null);
			base.Close();
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0001D5AF File Offset: 0x0001B7AF
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400015F RID: 351
		private string Codigo_Empresa;

		// Token: 0x04000160 RID: 352
		private int iNumEmp;

		// Token: 0x04000161 RID: 353
		private string strVersionDB;

		// Token: 0x04000162 RID: 354
		private string strMySqlConnection;

		// Token: 0x04000163 RID: 355
		private string strSqlConnection;

		// Token: 0x04000164 RID: 356
		private string strServerName;

		// Token: 0x04000165 RID: 357
		private MySqlConnection MySqlConRemoto;

		// Token: 0x04000166 RID: 358
		private MySqlCommand MySqlCmdRemoto;

		// Token: 0x04000167 RID: 359
		private MySqlDataReader MySqlDRremoto;

		// Token: 0x04000168 RID: 360
		private SqlConnection SqlConLocal;

		// Token: 0x04000169 RID: 361
		private SqlCommand SqlCmdLocal;

		// Token: 0x0400016A RID: 362
		private SqlDataReader SqlDRlocal;
	}
}
