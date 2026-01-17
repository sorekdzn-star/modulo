using System;
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
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class frmLicencias : Form
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x000B6089 File Offset: 0x000B4289
		public frmLicencias()
		{
			base.Load += this.frmLicencias_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x000B69A1 File Offset: 0x000B4BA1
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x000B69AC File Offset: 0x000B4BAC
		internal virtual ComboBox cmbAnio
		{
			[CompilerGenerated]
			get
			{
				return this._cmbAnio;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmbAnio_SelectedIndexChanged);
				ComboBox cmbAnio = this._cmbAnio;
				if (cmbAnio != null)
				{
					cmbAnio.SelectedIndexChanged -= value2;
				}
				this._cmbAnio = value;
				cmbAnio = this._cmbAnio;
				if (cmbAnio != null)
				{
					cmbAnio.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000B69EF File Offset: 0x000B4BEF
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x000B69F9 File Offset: 0x000B4BF9
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000B6A02 File Offset: 0x000B4C02
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x000B6A0C File Offset: 0x000B4C0C
		internal virtual DataGridView dgvLicencias { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000B6A15 File Offset: 0x000B4C15
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x000B6A20 File Offset: 0x000B4C20
		internal virtual Button btnAgregar
		{
			[CompilerGenerated]
			get
			{
				return this._btnAgregar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAgregar_Click);
				Button btnAgregar = this._btnAgregar;
				if (btnAgregar != null)
				{
					btnAgregar.Click -= value2;
				}
				this._btnAgregar = value;
				btnAgregar = this._btnAgregar;
				if (btnAgregar != null)
				{
					btnAgregar.Click += value2;
				}
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x000B6A63 File Offset: 0x000B4C63
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x000B6A6D File Offset: 0x000B4C6D
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000B6A76 File Offset: 0x000B4C76
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x000B6A80 File Offset: 0x000B4C80
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x000B6A89 File Offset: 0x000B4C89
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x000B6A94 File Offset: 0x000B4C94
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x000B6AD7 File Offset: 0x000B4CD7
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x000B6AE4 File Offset: 0x000B4CE4
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

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000B6B27 File Offset: 0x000B4D27
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x000B6B31 File Offset: 0x000B4D31
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000B6B3A File Offset: 0x000B4D3A
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x000B6B44 File Offset: 0x000B4D44
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000B6B4D File Offset: 0x000B4D4D
		private void frmLicencias_Load(object sender, EventArgs e)
		{
			this.llenaCombos();
			this.iniciaGrid();
			this.refrescaDatos();
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000B6B68 File Offset: 0x000B4D68
		private void iniciaGrid()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgvLicencias.Rows.Clear();
			this.dgvLicencias.ColumnCount = 2;
			this.dgvLicencias.Columns[0].Name = "Mes";
			this.dgvLicencias.Columns[0].Width = 70;
			this.dgvLicencias.Columns[1].Name = "Licencia";
			this.dgvLicencias.Columns[1].Width = 800;
			this.DoubleBufferedASD(this.dgvLicencias, true);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000B6C18 File Offset: 0x000B4E18
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000B6C4C File Offset: 0x000B4E4C
		private void llenaCombos()
		{
			this.cmbAnio.Items.Clear();
			this.cmbAnio.Items.Add("2017");
			this.cmbAnio.Items.Add("2020");
			this.cmbAnio.Items.Add("2021");
			this.cmbAnio.Items.Add("2022");
			this.cmbAnio.Items.Add("2023");
			this.cmbAnio.Items.Add("2024");
			this.cmbAnio.Items.Add("2025");
			this.cmbAnio.Items.Add("2026");
			this.cmbAnio.Items.Add("2027");
			this.cmbAnio.Text = Conversions.ToString(DateAndTime.Today.Date.Year);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000B6D57 File Offset: 0x000B4F57
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmLicencia.ShowDialog();
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000B6D6C File Offset: 0x000B4F6C
		public void refrescaDatos()
		{
			this.iniciaGrid();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn("select * from G where b = '" + Tools.Encriptar(this.cmbAnio.Text.Trim()) + "'");
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Enero"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Febrero"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Marzo"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Abril"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Mayo"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Junio"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Julio"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Agosto"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Septiembre"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Octubre"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Noviembre"
			});
			this.dgvLicencias.Rows.Add(new object[]
			{
				"Diciembre"
			});
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					try
					{
						Tools.licenciaDec = Tools.Decrypt(Conversions.ToString(sqlDataReader[0]), Tools.strCte + Tools.strServ);
					}
					catch (Exception ex)
					{
					}
					string text = Conversions.ToString(sqlDataReader[2]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					bool flag = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Enero", false) == 0;
					if (flag)
					{
						this.dgvLicencias.Rows[0].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag2 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Febrero", false) == 0;
					if (flag2)
					{
						this.dgvLicencias.Rows[1].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag3 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Marzo", false) == 0;
					if (flag3)
					{
						this.dgvLicencias.Rows[2].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag4 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Abril", false) == 0;
					if (flag4)
					{
						this.dgvLicencias.Rows[3].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag5 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Mayo", false) == 0;
					if (flag5)
					{
						this.dgvLicencias.Rows[4].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag6 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Junio", false) == 0;
					if (flag6)
					{
						this.dgvLicencias.Rows[5].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag7 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Julio", false) == 0;
					if (flag7)
					{
						this.dgvLicencias.Rows[6].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag8 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Agosto", false) == 0;
					if (flag8)
					{
						this.dgvLicencias.Rows[7].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag9 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Septiembre", false) == 0;
					if (flag9)
					{
						this.dgvLicencias.Rows[8].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag10 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Octubre", false) == 0;
					if (flag10)
					{
						this.dgvLicencias.Rows[9].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag11 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Noviembre", false) == 0;
					if (flag11)
					{
						this.dgvLicencias.Rows[10].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
					bool flag12 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()), "Diciembre", false) == 0;
					if (flag12)
					{
						this.dgvLicencias.Rows[11].Cells[1].Value = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
					}
				}
			}
			sqlDataReader.Close();
			this.dgvLicencias.ClearSelection();
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000B73EC File Offset: 0x000B55EC
		private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.refrescaDatos();
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000B73F6 File Offset: 0x000B55F6
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
			MyProject.Forms.main.BtnLicencia.BackColor = SystemColors.InactiveCaption;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000B741A File Offset: 0x000B561A
		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmDownLicencias.Show();
		}
	}
}
