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
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class frmEditarTurnos : Form
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x0002C37D File Offset: 0x0002A57D
		public frmEditarTurnos()
		{
			base.Load += this.frmEditarTurnos_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0002D823 File Offset: 0x0002BA23
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0002D830 File Offset: 0x0002BA30
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0002D873 File Offset: 0x0002BA73
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0002D880 File Offset: 0x0002BA80
		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return this._Panel1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel1_Paint);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0002D8C3 File Offset: 0x0002BAC3
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0002D8D0 File Offset: 0x0002BAD0
		internal virtual GroupBox groupPeriodo
		{
			[CompilerGenerated]
			get
			{
				return this._groupPeriodo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.groupPeriodo_Enter);
				GroupBox groupPeriodo = this._groupPeriodo;
				if (groupPeriodo != null)
				{
					groupPeriodo.Enter -= value2;
				}
				this._groupPeriodo = value;
				groupPeriodo = this._groupPeriodo;
				if (groupPeriodo != null)
				{
					groupPeriodo.Enter += value2;
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0002D913 File Offset: 0x0002BB13
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0002D91D File Offset: 0x0002BB1D
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0002D926 File Offset: 0x0002BB26
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0002D930 File Offset: 0x0002BB30
		internal virtual ComboBox ComboBox1
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				ComboBox comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				this._ComboBox1 = value;
				comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0002D973 File Offset: 0x0002BB73
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0002D97D File Offset: 0x0002BB7D
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0002D986 File Offset: 0x0002BB86
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0002D990 File Offset: 0x0002BB90
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0002D9D3 File Offset: 0x0002BBD3
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0002D9DD File Offset: 0x0002BBDD
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0002D9E6 File Offset: 0x0002BBE6
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0002D9F9 File Offset: 0x0002BBF9
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0002DA03 File Offset: 0x0002BC03
		internal virtual ComboBox cmbxSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0002DA0C File Offset: 0x0002BC0C
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0002DA16 File Offset: 0x0002BC16
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0002DA1F File Offset: 0x0002BC1F
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0002DA29 File Offset: 0x0002BC29
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0002DA32 File Offset: 0x0002BC32
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0002DA3C File Offset: 0x0002BC3C
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0002DA45 File Offset: 0x0002BC45
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0002DA4F File Offset: 0x0002BC4F
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0002DA58 File Offset: 0x0002BC58
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0002DA62 File Offset: 0x0002BC62
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0002DA6B File Offset: 0x0002BC6B
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0002DA75 File Offset: 0x0002BC75
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0002DA7E File Offset: 0x0002BC7E
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0002DA88 File Offset: 0x0002BC88
		internal virtual Button btnVistaPrevia
		{
			[CompilerGenerated]
			get
			{
				return this._btnVistaPrevia;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnVistaPrevia_Click);
				Button btnVistaPrevia = this._btnVistaPrevia;
				if (btnVistaPrevia != null)
				{
					btnVistaPrevia.Click -= value2;
				}
				this._btnVistaPrevia = value;
				btnVistaPrevia = this._btnVistaPrevia;
				if (btnVistaPrevia != null)
				{
					btnVistaPrevia.Click += value2;
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0002DACB File Offset: 0x0002BCCB
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0002DAD8 File Offset: 0x0002BCD8
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
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvNotas_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvNotas_CellClick);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellContentClick -= value2;
					dgvNotas.CellClick -= value3;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellContentClick += value2;
					dgvNotas.CellClick += value3;
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0002DB36 File Offset: 0x0002BD36
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0002DB40 File Offset: 0x0002BD40
		internal virtual ComboBox cmbxEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0002DB49 File Offset: 0x0002BD49
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0002DB53 File Offset: 0x0002BD53
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0002DB68 File Offset: 0x0002BD68
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

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0002DBAB File Offset: 0x0002BDAB
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0002DBB5 File Offset: 0x0002BDB5
		internal virtual Label lblTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0002DBBE File Offset: 0x0002BDBE
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0002DBC8 File Offset: 0x0002BDC8
		internal virtual GroupBox GroupBoxReprocesar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0002DBD1 File Offset: 0x0002BDD1
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0002DBDC File Offset: 0x0002BDDC
		internal virtual CheckBox CheckBoxSinPropina
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxSinPropina;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxSinPropina_CheckedChanged);
				CheckBox checkBoxSinPropina = this._CheckBoxSinPropina;
				if (checkBoxSinPropina != null)
				{
					checkBoxSinPropina.CheckedChanged -= value2;
				}
				this._CheckBoxSinPropina = value;
				checkBoxSinPropina = this._CheckBoxSinPropina;
				if (checkBoxSinPropina != null)
				{
					checkBoxSinPropina.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0002DC1F File Offset: 0x0002BE1F
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		internal virtual CheckBox CheckBoxPropina
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxPropina;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxPropina_CheckedChanged);
				CheckBox checkBoxPropina = this._CheckBoxPropina;
				if (checkBoxPropina != null)
				{
					checkBoxPropina.CheckedChanged -= value2;
				}
				this._CheckBoxPropina = value;
				checkBoxPropina = this._CheckBoxPropina;
				if (checkBoxPropina != null)
				{
					checkBoxPropina.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0002DC70 File Offset: 0x0002BE70
		private void frmEditarTurnos_Load(object sender, EventArgs e)
		{
			this.iniciaGridFolio();
			this.llenaCombos();
			this.dateHoraFin.Format = DateTimePickerFormat.Custom;
			this.dateHoraFin.CustomFormat = "hh:mm:ss tt";
			this.dateHoraIni.Format = DateTimePickerFormat.Custom;
			this.dateHoraIni.CustomFormat = "hh:mm:ss tt";
			this.dateFechaIni.Format = DateTimePickerFormat.Custom;
			this.dateFechaIni.CustomFormat = "dd/MM/yyyy";
			this.dateFechaFin.Format = DateTimePickerFormat.Custom;
			this.dateFechaFin.CustomFormat = "dd/MM/yyyy";
			this.dateFechaIni.Value = this.dateFechaIni.MinDate;
			this.dateFechaFin.Value = this.dateFechaFin.MinDate;
			this.btnVistaPrevia.Text = "Vista Previa";
			this.cmbAnio.Enabled = true;
			this.ComboBox1.Enabled = false;
			this.dateFechaFin.Enabled = false;
			this.dateFechaIni.Enabled = false;
			this.btnVistaPrevia.Enabled = false;
			this.GroupBoxReprocesar.Enabled = false;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0002DD94 File Offset: 0x0002BF94
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.main.btnEliminarProductos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnEliminacionMasiva.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificar1Ticket.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificarTurnos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnReportes.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnPanico.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnBitacora.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnConfiguracion.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnRespaldar.BackColor = SystemColors.ActiveCaption;
			base.Close();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0002DE94 File Offset: 0x0002C094
		private void llenaCombos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.cmbxEmpresa.Items.Clear();
			this.cmbxSerie.Items.Clear();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("select distinct(idempresa) from empresas");
			while (sqlDataReader.Read())
			{
				this.cmbxEmpresa.Items.Add(sqlDataReader[0].ToString());
			}
			sqlDataReader = (SqlDataReader)sqlQuery.execReader("select distinct(serie) from folios");
			this.cmbxSerie.Items.Add("Todas");
			while (sqlDataReader.Read())
			{
				this.cmbxSerie.Items.Add(sqlDataReader[0].ToString());
			}
			sqlDataReader.Close();
			this.cmbxSerie.SelectedIndex = 0;
			this.cmbxEmpresa.SelectedIndex = 0;
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn("select distinct (b) from G");
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					this.cmbAnio.Items.Add(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0002DFDC File Offset: 0x0002C1DC
		private void iniciaGridFolio()
		{
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 8;
			this.dgvNotas.Columns[0].Name = "# Turno";
			this.dgvNotas.Columns[0].Visible = true;
			this.dgvNotas.Columns[0].ReadOnly = true;
			this.dgvNotas.Columns[0].Width = 60;
			this.dgvNotas.Columns[1].Name = "Apertura";
			this.dgvNotas.Columns[1].Width = 140;
			this.dgvNotas.Columns[1].ReadOnly = true;
			this.dgvNotas.Columns[2].Name = "Cierre";
			this.dgvNotas.Columns[2].Width = 140;
			this.dgvNotas.Columns[2].ReadOnly = true;
			this.dgvNotas.Columns[3].Name = "Cajero";
			this.dgvNotas.Columns[3].Width = 140;
			this.dgvNotas.Columns[3].ReadOnly = true;
			this.dgvNotas.Columns[4].Name = "Efectivo";
			this.dgvNotas.Columns[4].ReadOnly = false;
			this.dgvNotas.Columns[4].Width = 80;
			this.dgvNotas.Columns[5].Name = "Tarjeta";
			this.dgvNotas.Columns[5].Width = 80;
			this.dgvNotas.Columns[5].ReadOnly = false;
			this.dgvNotas.Columns[6].Name = "Vales";
			this.dgvNotas.Columns[6].Width = 80;
			this.dgvNotas.Columns[6].ReadOnly = false;
			this.dgvNotas.Columns[7].Name = "Credito";
			this.dgvNotas.Columns[7].Width = 80;
			this.dgvNotas.Columns[7].ReadOnly = false;
			dataGridViewButtonColumn.Width = 60;
			dataGridViewButtonColumn.Name = "Modificar";
			this.dgvNotas.Columns.Add(dataGridViewButtonColumn);
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0002E2CC File Offset: 0x0002C4CC
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0002E300 File Offset: 0x0002C500
		public void refrescaDatos()
		{
			frmWaitMsg frmWaitMsg = new frmWaitMsg();
			SqlQuery sqlQuery = new SqlQuery();
			this.dateHoraFin.Format = DateTimePickerFormat.Custom;
			this.dateHoraFin.CustomFormat = "hh:mm:ss tt";
			this.dateHoraIni.Format = DateTimePickerFormat.Custom;
			this.dateHoraIni.CustomFormat = "hh:mm:ss tt";
			this.dateFechaIni.Format = DateTimePickerFormat.Custom;
			this.dateFechaIni.CustomFormat = "dd/MM/yyyy";
			this.dateFechaFin.Format = DateTimePickerFormat.Custom;
			this.dateFechaFin.CustomFormat = "dd/MM/yyyy";
			DateTime dateTime = Convert.ToDateTime(this.dateFechaIni.Text);
			DateTime dateTime2 = Convert.ToDateTime(this.dateFechaFin.Text);
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			string query = string.Concat(new string[]
			{
				"select idturno , apertura , cierre , cajero , efectivo , tarjeta , vales , credito from turnos where apertura\r\n                    BETWEEN '",
				text,
				"' AND '",
				text2,
				"' AND  cierre is not null  "
			});
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			this.iniciaGridFolio();
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					string text4 = Conversions.ToString(sqlDataReader[1]);
					string text5 = Conversions.ToString(sqlDataReader[2]);
					string text6 = Conversions.ToString(sqlDataReader[3]);
					bool flag = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], 0, false);
					double num;
					if (flag)
					{
						num = 0.0;
					}
					else
					{
						num = Conversions.ToDouble(sqlDataReader[4]);
					}
					bool flag2 = Operators.ConditionalCompareObjectEqual(sqlDataReader[5], 0, false);
					double num2;
					if (flag2)
					{
						num2 = 0.0;
					}
					else
					{
						num2 = Conversions.ToDouble(sqlDataReader[5]);
					}
					bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[6], 0, false);
					double num3;
					if (flag3)
					{
						num3 = 0.0;
					}
					else
					{
						num3 = Conversions.ToDouble(sqlDataReader[6]);
					}
					bool flag4 = Operators.ConditionalCompareObjectEqual(sqlDataReader[7], 0, false);
					double num4;
					if (flag4)
					{
						num4 = 0.0;
					}
					else
					{
						num4 = Conversions.ToDouble(sqlDataReader[7]);
					}
					this.dgvNotas.Rows.Add(new object[]
					{
						text3,
						text4,
						text5,
						text6,
						num.ToString("N2"),
						num2.ToString("N2"),
						num3.ToString("N2"),
						num4.ToString("N2")
					});
				}
			}
			sqlDataReader.Close();
			this.ComboBox1.Enabled = false;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0002E60F File Offset: 0x0002C80F
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			this.btnVistaPrevia.Text = "Espere...";
			this.refrescaDatos();
			this.btnVistaPrevia.Text = "Vista Previa";
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0002E63C File Offset: 0x0002C83C
		private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.ComboBox1.Items.Clear();
			string text = "Enero";
			text = Tools.Encriptar(text.ToString().Trim());
			string text2 = "Febrero";
			text2 = Tools.Encriptar(text2.ToString().Trim());
			string text3 = "Marzo";
			text3 = Tools.Encriptar(text3.ToString().Trim());
			string text4 = "Abril";
			text4 = Tools.Encriptar(text4.ToString().Trim());
			string text5 = "Mayo";
			text5 = Tools.Encriptar(text5.ToString().Trim());
			string text6 = "Junio";
			text6 = Tools.Encriptar(text6.ToString().Trim());
			string text7 = "Julio";
			text7 = Tools.Encriptar(text7.ToString().Trim());
			string text8 = "Agosto";
			text8 = Tools.Encriptar(text8.ToString().Trim());
			string text9 = "Septiembre";
			text9 = Tools.Encriptar(text9.ToString().Trim());
			string text10 = "Octubre";
			text10 = Tools.Encriptar(text10.ToString().Trim());
			string text11 = "Noviembre";
			text11 = Tools.Encriptar(text11.ToString().Trim());
			string text12 = "Diciembre";
			text12 = Tools.Encriptar(text12.ToString().Trim());
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(string.Concat(new string[]
			{
				"select distinct(c), CASE WHEN c = '",
				text.ToString(),
				"' THEN 1 WHEN c = '",
				text2.ToString(),
				"' THEN 2 WHEN c = '",
				text3.ToString(),
				"' THEN 3\tWHEN c = '",
				text4.ToString(),
				"' THEN 4\tWHEN c = '",
				text5.ToString(),
				"' THEN 5\tWHEN c = '",
				text6.ToString(),
				"' THEN 6\tWHEN c = '",
				text7.ToString().Trim(),
				"' THEN 7\tWHEN c = '",
				text8.ToString(),
				"' THEN 8\tWHEN c = '",
				text9.ToString(),
				"' THEN 9\tWHEN c = '",
				text10.ToString(),
				"' THEN 10\tWHEN c = '",
				text11.ToString(),
				"' THEN 11\tWHEN c = '",
				text12.ToString(),
				"' THEN 12 END AS monthNum from G where b = '",
				Tools.Encriptar(this.cmbAnio.Text.Trim()),
				"' order by monthNum"
			}));
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					this.ComboBox1.Items.Add(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
				}
				this.ComboBox1.Enabled = true;
			}
			sqlDataReader.Close();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0002E918 File Offset: 0x0002CB18
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(string.Concat(new string[]
			{
				"select a,b,c from G where c='",
				Tools.Encriptar(this.ComboBox1.Text.Trim()),
				"' and b ='",
				Tools.Encriptar(this.cmbAnio.Text.Trim()),
				"'"
			}));
			bool hasRows = sqlDataReader.HasRows;
			checked
			{
				if (hasRows)
				{
					sqlDataReader.Read();
					Tools.licencia = Conversions.ToString(sqlDataReader[0]);
					bool flag = !Tools.ValidaLicencia();
					if (flag)
					{
						sqlDataReader.Close();
					}
					else
					{
						sqlDataReader.Close();
						this.dateFechaFin.Enabled = true;
						this.dateFechaIni.Enabled = true;
						this.btnVistaPrevia.Enabled = true;
						this.GroupBoxReprocesar.Enabled = true;
						this.dateFechaIni.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaFin.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaIni.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						this.dateFechaFin.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						bool flag2 = Operators.CompareString(Tools.Gm(this.ComboBox1.Text), "12", false) == 0;
						if (flag2)
						{
							this.dateFechaIni.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 1);
							this.dateFechaFin.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 1);
						}
						else
						{
							this.dateFechaIni.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 1);
							this.dateFechaFin.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 1);
						}
					}
				}
				else
				{
					sqlDataReader.Close();
				}
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 8;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Modificar"].Value, false, false);
				if (flag2)
				{
					this.dgvNotas.Rows[rowIndex].Cells["Modificar"].Value = "";
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					object obj = "SE MODIFICARA EL TURNO SELECCIONADO, Deseas continuar?";
					object value = 276;
					object obj2 = "ATENCIÓN!!!";
					object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
					bool flag3 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
					if (flag3)
					{
						string text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["# Turno"].Value);
						double num = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value);
						double num2 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value);
						double num3 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value);
						double num4 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Credito"].Value);
						SqlQuery sqlQuery = new SqlQuery();
						string query = string.Concat(new string[]
						{
							"Update turnos set efectivo = '",
							num.ToString(),
							"' ,Tarjeta = '",
							num2.ToString(),
							"' , Vales = '",
							num3.ToString(),
							"' , credito = '",
							num4.ToString(),
							"' where idturno = ",
							text,
							"  "
						});
						sqlQuery.execQuery(query);
						this.refrescaDatos();
						this.dgvNotas.ClearSelection();
						Interaction.MsgBox("Turno editado correctamente!", MsgBoxStyle.OkOnly, null);
						this.dgvNotas.ClearSelection();
					}
					else
					{
						this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
						this.dgvNotas.ClearSelection();
					}
				}
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000036D5 File Offset: 0x000018D5
		private void groupPeriodo_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0002EE9C File Offset: 0x0002D09C
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.cmbxEmpresa.Text;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string text2 = Conversions.ToString(dataGridViewRow.Cells["# Turno"].Value);
					bool @checked = this.CheckBoxPropina.Checked;
					if (@checked)
					{
						string query = "Select ISNULL(sum(importe),0) from movtoscaja Where idturno = '" + text2 + "' And  pagodepropina = 1";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
						sqlDataReader.Read();
						double num = Conversions.ToDouble(sqlDataReader[0]);
						sqlDataReader.Close();
						query = string.Concat(new string[]
						{
							"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
							text,
							"' and  idturno = '",
							text2,
							"'"
						});
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
						while (sqlDataReader.Read())
						{
							double num2 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader[0], num));
							double value = Conversions.ToDouble(sqlDataReader[1]);
							double num3 = Conversions.ToDouble(sqlDataReader[2]);
							double num4 = Conversions.ToDouble(sqlDataReader[3]);
							double num5 = num2;
							this.lblTarjeta.Text = Conversions.ToString(value);
							query = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num5.ToString(),
								"',tarjeta='",
								value.ToString(),
								"',vales='",
								num3.ToString(),
								"', credito='",
								num4.ToString(),
								"' Where idturno = '",
								text2,
								"'"
							});
							sqlQuery.execQuery(query);
						}
					}
					bool checked2 = this.CheckBoxSinPropina.Checked;
					if (checked2)
					{
						string query = string.Concat(new string[]
						{
							"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
							text,
							"' and  idturno = '",
							text2,
							"'"
						});
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
						while (sqlDataReader.Read())
						{
							double num2 = Conversions.ToDouble(sqlDataReader[0]);
							double value = Conversions.ToDouble(sqlDataReader[1]);
							double num3 = Conversions.ToDouble(sqlDataReader[2]);
							double num4 = Conversions.ToDouble(sqlDataReader[3]);
							double num5 = num2;
							this.lblTarjeta.Text = Conversions.ToString(value);
							query = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num5.ToString(),
								"',tarjeta='",
								value.ToString(),
								"',vales='",
								num3.ToString(),
								"', credito='",
								num4.ToString(),
								"' Where idturno = '",
								text2,
								"'"
							});
							sqlQuery.execQuery(query);
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
			this.refrescaDatos();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0002F1E4 File Offset: 0x0002D3E4
		private void CheckBoxPropina_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBoxPropina.Checked;
			if (@checked)
			{
				this.CheckBoxSinPropina.Checked = false;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0002F210 File Offset: 0x0002D410
		private void CheckBoxSinPropina_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBoxSinPropina.Checked;
			if (@checked)
			{
				this.CheckBoxPropina.Checked = false;
			}
		}
	}
}
