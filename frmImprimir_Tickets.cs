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
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public partial class frmImprimir_Tickets : Form
	{
		// Token: 0x060009FD RID: 2557 RVA: 0x000AED48 File Offset: 0x000ACF48
		public frmImprimir_Tickets()
		{
			base.Load += this.frmImprimir_Tickets_Load;
			this.sess_ESC = "\u001b!";
			this.sess_EPSON_BOLD_ON = this.sess_ESC + "\u0010" + this.sess_ESC + " ";
			this.sess_EPSON_BOLD_OFF = this.sess_ESC + "\0" + this.sess_ESC + "\0";
			this.sess_STAR_BOLD_ON = this.sess_ESC + "\u000e" + this.sess_ESC + "\u000f";
			this.sess_STAR_BOLD_OFF = this.sess_ESC + "\u0004" + this.sess_ESC + "\u0005";
			this.CortePapel = "\u001dVB\0";
			this.DobleAlto = this.sess_ESC + "\u0010";
			this.DobleAlto_OFF = this.sess_ESC + "\0";
			this.DobleAncho_ON = this.sess_ESC + "!";
			this.DobleAncho_OFF = this.sess_ESC + "\0";
			this.eCentro = "\u001ba1";
			this.eCentro_OFF = this.sess_ESC + "\0";
			this.eRight = this.sess_ESC + "\u001b" + this.sess_ESC + "a2";
			this.sess_PRINT_BOLD_ON = this.sess_ESC + "\u0011";
			this.sess_PRINT_BOLD_OFF = this.sess_ESC + "\0";
			this.InitializeComponent();
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000B063D File Offset: 0x000AE83D
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000B0647 File Offset: 0x000AE847
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000B0650 File Offset: 0x000AE850
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x000B065A File Offset: 0x000AE85A
		internal virtual Label lblTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000B0663 File Offset: 0x000AE863
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x000B0670 File Offset: 0x000AE870
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000B06B3 File Offset: 0x000AE8B3
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000B06C0 File Offset: 0x000AE8C0
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000B0703 File Offset: 0x000AE903
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x000B070D File Offset: 0x000AE90D
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x000B0716 File Offset: 0x000AE916
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x000B0720 File Offset: 0x000AE920
		internal virtual ComboBox cmbxEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x000B0729 File Offset: 0x000AE929
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x000B0733 File Offset: 0x000AE933
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000B073C File Offset: 0x000AE93C
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x000B0748 File Offset: 0x000AE948
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000B078B File Offset: 0x000AE98B
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x000B0795 File Offset: 0x000AE995
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000B079E File Offset: 0x000AE99E
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000B07A8 File Offset: 0x000AE9A8
		internal virtual ComboBox cmbxSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000B07B1 File Offset: 0x000AE9B1
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x000B07BB File Offset: 0x000AE9BB
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000B07C4 File Offset: 0x000AE9C4
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x000B07D0 File Offset: 0x000AE9D0
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

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x000B0813 File Offset: 0x000AEA13
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x000B081D File Offset: 0x000AEA1D
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000B0826 File Offset: 0x000AEA26
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000B0830 File Offset: 0x000AEA30
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000B0839 File Offset: 0x000AEA39
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000B0843 File Offset: 0x000AEA43
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000B084C File Offset: 0x000AEA4C
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x000B0856 File Offset: 0x000AEA56
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000B085F File Offset: 0x000AEA5F
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000B0869 File Offset: 0x000AEA69
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000B0872 File Offset: 0x000AEA72
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000B087C File Offset: 0x000AEA7C
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000B0885 File Offset: 0x000AEA85
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000B0890 File Offset: 0x000AEA90
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000B08D3 File Offset: 0x000AEAD3
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x000B08E0 File Offset: 0x000AEAE0
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
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvNotas_CellContentClick);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick -= value2;
					dgvNotas.CellContentClick -= value3;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick += value2;
					dgvNotas.CellContentClick += value3;
				}
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000B093E File Offset: 0x000AEB3E
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000B0948 File Offset: 0x000AEB48
		internal virtual GroupBox GroupBox_Imprimir { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000B0951 File Offset: 0x000AEB51
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x000B095C File Offset: 0x000AEB5C
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000B099F File Offset: 0x000AEB9F
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x000B09AC File Offset: 0x000AEBAC
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

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000B09EF File Offset: 0x000AEBEF
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x000B09F9 File Offset: 0x000AEBF9
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x000B0A02 File Offset: 0x000AEC02
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x000B0A0C File Offset: 0x000AEC0C
		internal virtual Label lblimpresora { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000B0A15 File Offset: 0x000AEC15
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x000B0A1F File Offset: 0x000AEC1F
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000B0A28 File Offset: 0x000AEC28
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x000B0A32 File Offset: 0x000AEC32
		internal virtual TextBox txtTotalTickets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000B0A3B File Offset: 0x000AEC3B
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x000B0A48 File Offset: 0x000AEC48
		internal virtual CheckBox CheckBox3_Todos
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox3_Todos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox3_Todos_CheckedChanged);
				CheckBox checkBox3_Todos = this._CheckBox3_Todos;
				if (checkBox3_Todos != null)
				{
					checkBox3_Todos.CheckedChanged -= value2;
				}
				this._CheckBox3_Todos = value;
				checkBox3_Todos = this._CheckBox3_Todos;
				if (checkBox3_Todos != null)
				{
					checkBox3_Todos.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000B0A8C File Offset: 0x000AEC8C
		private void frmImprimir_Tickets_Load(object sender, EventArgs e)
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
			this.GroupBox_Imprimir.Enabled = false;
			this.cmbxSerie.Enabled = false;
			this.CheckBox3_Todos.Enabled = false;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "SELECT af from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				string text = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				bool flag2 = Operators.CompareString(text, "", false) == 0;
				if (flag2)
				{
					this.cmbAnio.Enabled = false;
					Interaction.MsgBox("Par utilizar esta funcion , dirigete a Configuracion > Empresa/Tickets > Edita y Activa los parametros!", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					this.lblimpresora.Text = text.ToString();
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000B0C54 File Offset: 0x000AEE54
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

		// Token: 0x06000A3A RID: 2618 RVA: 0x000B0D9C File Offset: 0x000AEF9C
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000B0DD0 File Offset: 0x000AEFD0
		private void iniciaGridFolio()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 13;
			this.dgvNotas.Columns[0].Name = "id_nota";
			this.dgvNotas.Columns[0].Visible = false;
			this.dgvNotas.Columns[0].ReadOnly = true;
			this.dgvNotas.Columns[0].Width = 60;
			this.dgvNotas.Columns[1].Name = "Serie";
			this.dgvNotas.Columns[1].Width = 60;
			this.dgvNotas.Columns[1].ReadOnly = true;
			this.dgvNotas.Columns[2].Name = "Folio";
			this.dgvNotas.Columns[2].Width = 60;
			this.dgvNotas.Columns[3].Name = "Mesa";
			this.dgvNotas.Columns[3].Width = 100;
			this.dgvNotas.Columns[3].ReadOnly = true;
			this.dgvNotas.Columns[4].Name = "Fecha";
			this.dgvNotas.Columns[4].Width = 170;
			this.dgvNotas.Columns[5].Name = "Facturado";
			this.dgvNotas.Columns[5].Width = 80;
			this.dgvNotas.Columns[6].Name = "Cancelado";
			this.dgvNotas.Columns[6].Width = 80;
			this.dgvNotas.Columns[7].Name = "Descuento";
			this.dgvNotas.Columns[7].Width = 80;
			this.dgvNotas.Columns[7].ReadOnly = true;
			this.dgvNotas.Columns[8].Name = "Total";
			this.dgvNotas.Columns[8].ReadOnly = false;
			this.dgvNotas.Columns[8].Width = 80;
			this.dgvNotas.Columns[9].Name = "Efectivo";
			this.dgvNotas.Columns[9].ReadOnly = false;
			this.dgvNotas.Columns[9].Width = 80;
			this.dgvNotas.Columns[10].Name = "Tarjeta";
			this.dgvNotas.Columns[10].Width = 80;
			this.dgvNotas.Columns[10].ReadOnly = false;
			this.dgvNotas.Columns[11].Name = "Vales";
			this.dgvNotas.Columns[11].Width = 80;
			this.dgvNotas.Columns[11].ReadOnly = false;
			this.dgvNotas.Columns[12].Name = "Credito";
			this.dgvNotas.Columns[12].Width = 80;
			this.dgvNotas.Columns[12].ReadOnly = false;
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Imprimir";
			this.dgvNotas.Columns.Add(dataGridViewCheckBoxColumn);
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000B11E8 File Offset: 0x000AF3E8
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			this.txtTotalTickets.Text = Conversions.ToString(0);
			this.CheckBox3_Todos.Checked = true;
			this.btnVistaPrevia.Text = "Espere...";
			this.RefrescaDatos();
			this.btnVistaPrevia.Text = "Vista Previa";
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000B1240 File Offset: 0x000AF440
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

		// Token: 0x06000A3E RID: 2622 RVA: 0x000B151C File Offset: 0x000AF71C
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
						this.GroupBox_Imprimir.Enabled = true;
						this.cmbxSerie.Enabled = true;
						this.CheckBox3_Todos.Enabled = true;
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

		// Token: 0x06000A3F RID: 2623 RVA: 0x000B17F0 File Offset: 0x000AF9F0
		public void RefrescaDatos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			DateTime dateTime = Convert.ToDateTime(this.dateFechaIni.Text);
			DateTime dateTime2 = Convert.ToDateTime(this.dateFechaFin.Text);
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			int num = 0;
			string text3 = this.cmbxSerie.Text;
			bool flag = Operators.CompareString(text3, "Todas", false) == 0;
			checked
			{
				bool flag4;
				if (flag)
				{
					string query = string.Concat(new string[]
					{
						"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,propinafoliomovtocaja,propina,seriefolio,mesa from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
						text,
						"' AND '",
						text2,
						"' AND \r\n                    cierre is not null and idempresa='",
						Tools.id_Empresa,
						"')\r\n                    and idempresa='",
						Tools.id_Empresa,
						"' order by numcheque asc"
					});
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					this.iniciaGridFolio();
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							string text4 = Conversions.ToString(sqlDataReader[0]);
							string text5 = Conversions.ToString(sqlDataReader[1]);
							string text6 = Conversions.ToString(sqlDataReader[2]);
							bool flag2 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
							string text7;
							if (flag2)
							{
								text7 = "Si";
							}
							else
							{
								text7 = "No";
							}
							bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
							string text8;
							if (flag3)
							{
								text8 = "Si";
							}
							else
							{
								text8 = "No";
							}
							string text9 = Conversions.ToString(sqlDataReader[5]);
							string text10 = Conversions.ToString(sqlDataReader[6]);
							string text11 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
							double num2 = Conversions.ToDouble(sqlDataReader[8]);
							double num3 = Conversions.ToDouble(sqlDataReader[9]);
							double num4 = Conversions.ToDouble(sqlDataReader[10]);
							double num5 = Conversions.ToDouble(sqlDataReader[11]);
							double num6 = Conversions.ToDouble(sqlDataReader[12]);
							string text12 = Conversions.ToString(sqlDataReader[13]);
							string text13 = Conversions.ToString(sqlDataReader[14]);
							double num7 = Conversions.ToDouble(sqlDataReader[15]);
							string text14 = Conversions.ToString(sqlDataReader[16]);
							string text15 = Conversions.ToString(sqlDataReader[17]);
							this.dgvNotas.Rows.Add(new object[]
							{
								text4,
								text14,
								text5,
								text15,
								text6,
								text8,
								text7,
								text11,
								num2,
								num3,
								num4,
								num5,
								num6,
								flag4
							});
							num++;
						}
					}
					else
					{
						bool flag5 = !sqlDataReader.HasRows;
						if (flag5)
						{
							Interaction.MsgBox("No hay registros para mostrar!", MsgBoxStyle.OkOnly, null);
						}
					}
				}
				bool flag6 = Operators.CompareString(text3, "Todas", false) != 0;
				if (flag6)
				{
					string query = string.Concat(new string[]
					{
						"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,propinafoliomovtocaja,propina,seriefolio,mesa from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
						text,
						"' AND '",
						text2,
						"' AND \r\n                    cierre is not null and idempresa='",
						Tools.id_Empresa,
						"')\r\n                    and idempresa='",
						Tools.id_Empresa,
						"'  and seriefolio = '",
						text3,
						"'order by numcheque asc"
					});
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					this.iniciaGridFolio();
					bool hasRows2 = sqlDataReader.HasRows;
					if (hasRows2)
					{
						while (sqlDataReader.Read())
						{
							string text4 = Conversions.ToString(sqlDataReader[0]);
							string text5 = Conversions.ToString(sqlDataReader[1]);
							string text6 = Conversions.ToString(sqlDataReader[2]);
							bool flag7 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
							string text7;
							if (flag7)
							{
								text7 = "Si";
							}
							else
							{
								text7 = "No";
							}
							bool flag8 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
							string text8;
							if (flag8)
							{
								text8 = "Si";
							}
							else
							{
								text8 = "No";
							}
							string text9 = Conversions.ToString(sqlDataReader[5]);
							string text10 = Conversions.ToString(sqlDataReader[6]);
							string text11 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
							double num2 = Conversions.ToDouble(sqlDataReader[8]);
							double num3 = Conversions.ToDouble(sqlDataReader[9]);
							double num4 = Conversions.ToDouble(sqlDataReader[10]);
							double num5 = Conversions.ToDouble(sqlDataReader[11]);
							double num6 = Conversions.ToDouble(sqlDataReader[12]);
							string text12 = Conversions.ToString(sqlDataReader[13]);
							string text13 = Conversions.ToString(sqlDataReader[14]);
							double num7 = Conversions.ToDouble(sqlDataReader[15]);
							string text14 = Conversions.ToString(sqlDataReader[16]);
							string text15 = Conversions.ToString(sqlDataReader[17]);
							this.dgvNotas.Rows.Add(new object[]
							{
								text4,
								text14,
								text5,
								text15,
								text6,
								text8,
								text7,
								text11,
								num2,
								num3,
								num4,
								num5,
								num6,
								flag4
							});
							num++;
						}
					}
					else
					{
						bool flag9 = !sqlDataReader.HasRows;
						if (flag9)
						{
							Interaction.MsgBox("No hay registros para mostrar!", MsgBoxStyle.OkOnly, null);
						}
					}
				}
				int num8 = 0;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["Imprimir"].Value = true;
						bool flag10 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Imprimir"].Value, true, false);
						if (flag10)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							num8++;
							this.txtTotalTickets.Text = Conversions.ToString(num8);
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
				this.dgvNotas.ClearSelection();
				this.ComboBox1.Enabled = false;
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000B1ED8 File Offset: 0x000B00D8
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
			MyProject.Forms.main.btnReImprimirTickets.BackColor = SystemColors.ActiveCaption;
			base.Hide();
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000036D5 File Offset: 0x000018D5
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000036D5 File Offset: 0x000018D5
		private void groupPeriodo_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000B1FF4 File Offset: 0x000B01F4
		public void PrintingOutTicketVenta()
		{
			PrintDialog printDialog = new PrintDialog();
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Imprimir"].Value, true, false);
					if (flag)
					{
						string text = Conversions.ToString(dataGridViewRow.Cells["id_nota"].Value);
						string text2 = "Select a , b , c, d, e, f , g , h, i, j ,\r\n                    k , l , m , n , o , p from BB WITH (NOLOCK)";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag2 = sqlDataReader.Read();
						if (flag2)
						{
							string text3 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							string text4 = Tools.Desencriptar(sqlDataReader[1].ToString().Trim());
							string text5 = Tools.Desencriptar(sqlDataReader[2].ToString().Trim());
							string text6 = Tools.Desencriptar(sqlDataReader[3].ToString().Trim());
							string text7 = Tools.Desencriptar(sqlDataReader[4].ToString().Trim());
							string text8 = Tools.Desencriptar(sqlDataReader[5].ToString().Trim());
							string text9 = Tools.Desencriptar(sqlDataReader[6].ToString().Trim());
							string text10 = Tools.Desencriptar(sqlDataReader[7].ToString().Trim());
							string text11 = Tools.Desencriptar(sqlDataReader[8].ToString().Trim());
							string text12 = Tools.Desencriptar(sqlDataReader[9].ToString().Trim());
							string text13 = Tools.Desencriptar(sqlDataReader[10].ToString().Trim());
							string text14 = Tools.Desencriptar(sqlDataReader[11].ToString().Trim());
							string text15 = Tools.Desencriptar(sqlDataReader[12].ToString().Trim());
							string text16 = this.eCentro + this.sess_PRINT_BOLD_ON;
							bool flag3 = Operators.CompareString(text3, "", false) == 0;
							if (!flag3)
							{
								text16 = text16 + text3.ToString() + "\r\n";
							}
							text16 += this.sess_PRINT_BOLD_OFF;
							bool flag4 = Operators.CompareString(text4, "", false) == 0;
							if (!flag4)
							{
								text16 = text16 + text4.ToString() + "\r\n";
							}
							bool flag5 = Operators.CompareString(text10, "", false) == 0;
							if (!flag5)
							{
								text16 = text16 + "RFC:" + text10.ToString() + "\r\n";
							}
							bool flag6 = Operators.CompareString(text5, "", false) == 0;
							if (!flag6)
							{
								text16 = text16 + text5.ToString() + "\r\n";
							}
							bool flag7 = Operators.CompareString(text7, "", false) == 0;
							if (!flag7)
							{
								text16 = text16 + text7.ToString() + " , ";
							}
							bool flag8 = Operators.CompareString(text8, "", false) == 0;
							if (!flag8)
							{
								text16 = text16 + text8.ToString() + " , ";
							}
							bool flag9 = Operators.CompareString(text9, "", false) == 0;
							if (flag9)
							{
								text16 += "\r\n";
							}
							else
							{
								text16 = text16 + text9.ToString() + "\r\n";
							}
							bool flag10 = Operators.CompareString(text6, "", false) == 0;
							if (!flag10)
							{
								text16 = text16 + "CP: " + text6.ToString() + "\r\n";
							}
							bool flag11 = Operators.CompareString(text12, "", false) == 0;
							if (!flag11)
							{
								text16 += this.sess_PRINT_BOLD_ON;
								text16 += "LUGAR DE EXPEDICION\r\n";
								text16 += this.sess_PRINT_BOLD_OFF;
							}
							bool flag12 = Operators.CompareString(text12, "", false) == 0;
							if (!flag12)
							{
								text16 = text16 + text12.ToString() + "\r\n";
							}
							bool flag13 = Operators.CompareString(text14, "", false) == 0;
							if (!flag13)
							{
								text16 = text16 + text14.ToString() + " , ";
							}
							bool flag14 = Operators.CompareString(text13, "", false) == 0;
							if (flag14)
							{
								text16 += "\r\n";
							}
							else
							{
								text16 = text16 + text13.ToString() + "\r\n";
							}
							bool flag15 = Operators.CompareString(text15, "", false) == 0;
							if (!flag15)
							{
								text16 = text16 + "CP: " + text15.ToString() + "\r\n";
							}
							bool flag16 = Operators.CompareString(text11, "", false) == 0;
							if (!flag16)
							{
								text16 = text16 + "TELEFONO:" + text11.ToString() + "\r\n";
							}
							text16 += "\u001b@";
							text16 += "================================================\r\n";
							text2 = "select mesa , idmesero , nopersonas , orden , numcheque , fecha , cierre , seriefolio  from  Cheques WITH (NOLOCK)  where folio ='" + text + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool flag17 = sqlDataReader.Read();
							if (flag17)
							{
								string text17 = Conversions.ToString(sqlDataReader[0]);
								string text18 = Conversions.ToString(sqlDataReader[1]);
								string text19 = Conversions.ToString(sqlDataReader[2]);
								string text20 = Conversions.ToString(sqlDataReader[3]);
								string text21 = Conversions.ToString(sqlDataReader[4]);
								string text22 = Conversions.ToString(sqlDataReader[5]);
								string text23 = Conversions.ToString(sqlDataReader[6]);
								string text24 = Conversions.ToString(sqlDataReader[7]);
								text16 = text16 + "MESA:" + text17.ToString() + "\r\n";
								text16 = text16 + "MESERO:" + text18.ToString() + "\r\n";
								text16 = string.Concat(new string[]
								{
									text16,
									"PERSONAS:",
									text19.ToString(),
									"    ORDEN:",
									text20.ToString(),
									"\r\n"
								});
								text16 = text16 + ("FOLIO:" + text24.ToString()) + text21.ToString() + "\r\n";
								text16 = text16 + "APERTURA:" + text22.ToString() + "\r\n";
								text16 = text16 + "CIERRE  :" + text23.ToString() + "\r\n";
								text16 += "================================================\r\n";
								text16 += "CANT. DESCRIPCION                     IMPORTE\r\n";
							}
							text2 = "SELECT ag from h";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
							bool flag18 = sqlDataReader.Read();
							if (flag18)
							{
								int num = Conversions.ToInteger(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
								bool flag19 = (double)num == Conversions.ToDouble("0");
								if (flag19)
								{
									text2 = "SELECT ah from H WITH (NOLOCK)";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
									bool flag20 = sqlDataReader.Read();
									if (flag20)
									{
										int num2 = Conversions.ToInteger(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
										bool flag21 = (double)num2 == Conversions.ToDouble("1");
										if (flag21)
										{
											text2 = "select cantidad , SUBSTRING(b.descripcion, 1, 30), a.precio ,a.modificador  from cheqdet A WITH (NOLOCK)\r\n                                    inner join productos B WITH (NOLOCK) on b.idproducto = a.idproducto \r\n                                    inner join productosdetalle C WITH (NOLOCK) on c.idproducto = a.idproducto\r\n\t\t\t\t\t\t\t\t\tInner Join grupos D WITH (NOLOCK) on d.idgrupo = b.idgrupo\r\n                                    where foliodet='" + text + "' order by a.movimiento asc";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
											bool hasRows = sqlDataReader.HasRows;
											if (hasRows)
											{
												while (sqlDataReader.Read())
												{
													string value = Conversions.ToString(sqlDataReader[3]);
													int num3 = Conversions.ToInteger(sqlDataReader[0]);
													bool flag22 = (double)num3 < Conversions.ToDouble("10");
													if (flag22)
													{
														bool flag23 = Conversions.ToBoolean(value);
														if (flag23)
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(29, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = string.Concat(new string[]
															{
																"      >",
																num3.ToString(),
																" ",
																text26,
																text27
															});
															text16 = text16 + str + "\r\n";
														}
														else
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(32, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = num3.ToString() + "     " + text26 + text27;
															text16 = text16 + str + "\r\n";
														}
													}
													bool flag24 = (double)num3 > Conversions.ToDouble("9") & (double)num3 < Conversions.ToDouble("100");
													if (flag24)
													{
														bool flag25 = Conversions.ToBoolean(value);
														if (flag25)
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(28, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = string.Concat(new string[]
															{
																"      >",
																num3.ToString(),
																" ",
																text26,
																text27
															});
															text16 = text16 + str + "\r\n";
														}
														else
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(32, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
															string str = num3.ToString() + "    " + text26 + text27;
															text16 = text16 + str + "\r\n";
														}
													}
													bool flag26 = (double)num3 > Conversions.ToDouble("99") & (double)num3 < Conversions.ToDouble("1000");
													if (flag26)
													{
														bool flag27 = Conversions.ToBoolean(value);
														if (flag27)
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(27, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = string.Concat(new string[]
															{
																"      >",
																num3.ToString(),
																" ",
																text26,
																text27
															});
															text16 = text16 + str + "\r\n";
														}
														else
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(32, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
															string str = num3.ToString() + "   " + text26 + text27;
															text16 = text16 + str + "\r\n";
														}
													}
												}
											}
										}
										bool flag28 = (double)num2 == Conversions.ToDouble("0");
										if (flag28)
										{
											text2 = "select cantidad , SUBSTRING(b.descripcion, 1, 30), a.precio ,a.modificador  from cheqdet A  WITH (NOLOCK)\r\n                                    inner join productos B WITH (NOLOCK) on b.idproducto = a.idproducto \r\n                                    inner join productosdetalle C WITH (NOLOCK) on c.idproducto = a.idproducto\r\n\t\t\t\t\t\t\t\t\tInner Join grupos D WITH (NOLOCK) on d.idgrupo = b.idgrupo\r\n                                    where foliodet='" + text + "' and a.modificador=0 order by a.movimiento asc";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
											bool hasRows2 = sqlDataReader.HasRows;
											if (hasRows2)
											{
												while (sqlDataReader.Read())
												{
													string value = Conversions.ToString(sqlDataReader[3]);
													int num3 = Conversions.ToInteger(sqlDataReader[0]);
													bool flag29 = (double)num3 < Conversions.ToDouble("10");
													if (flag29)
													{
														string text25 = Conversions.ToString(sqlDataReader[1]);
														string text26 = text25;
														text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
														text26 = text26.PadRight(32, ' ');
														double num4 = Conversions.ToDouble(sqlDataReader[2]);
														string text27 = "$" + ((double)num3 * num4).ToString("N2");
														string str = num3.ToString() + "     " + text26 + text27;
														text16 = text16 + str + "\r\n";
													}
													bool flag30 = (double)num3 > Conversions.ToDouble("9") & (double)num3 < Conversions.ToDouble("100");
													if (flag30)
													{
														string text25 = Conversions.ToString(sqlDataReader[1]);
														string text26 = text25;
														text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
														text26 = text26.PadRight(32, ' ');
														double num4 = Conversions.ToDouble(sqlDataReader[2]);
														string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
														string str = num3.ToString() + "    " + text26 + text27;
														text16 = text16 + str + "\r\n";
													}
													bool flag31 = (double)num3 > Conversions.ToDouble("99") & (double)num3 < Conversions.ToDouble("1000");
													if (flag31)
													{
														string text25 = Conversions.ToString(sqlDataReader[1]);
														string text26 = text25;
														text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
														text26 = text26.PadRight(32, ' ');
														double num4 = Conversions.ToDouble(sqlDataReader[2]);
														string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
														string str = num3.ToString() + "   " + text26 + text27;
														text16 = text16 + str + "\r\n";
													}
												}
											}
										}
									}
								}
								bool flag32 = (double)num == Conversions.ToDouble("1");
								if (flag32)
								{
									text2 = "SELECT ah from H WITH (NOLOCK)";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
									bool flag33 = sqlDataReader.Read();
									if (flag33)
									{
										int num2 = Conversions.ToInteger(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
										bool flag34 = (double)num2 == Conversions.ToDouble("1");
										if (flag34)
										{
											text2 = "select sum(cantidad) as Cantidad , b.descripcion , a.precio ,a.modificador  from cheqdet A WITH (NOLOCK)\r\n\t\t\t\t\t\t\t\t\tinner join  Productos B WITH (NOLOCK) on b.idproducto = a.idproducto \r\n\t\t\t\t\t\t\t\t\tInner join productosdetalle C WITH (NOLOCK) on c.idproducto = a.idproducto where foliodet='" + text + "' group by a.movimiento,cantidad,b.descripcion,a.precio,a.modificador order by a.movimiento asc";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
											bool hasRows3 = sqlDataReader.HasRows;
											if (hasRows3)
											{
												while (sqlDataReader.Read())
												{
													string value = Conversions.ToString(sqlDataReader[3]);
													int num3 = Conversions.ToInteger(sqlDataReader[0]);
													bool flag35 = (double)num3 < Conversions.ToDouble("10");
													if (flag35)
													{
														bool flag36 = Conversions.ToBoolean(value);
														if (flag36)
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(29, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = string.Concat(new string[]
															{
																"      >",
																num3.ToString(),
																" ",
																text26,
																text27
															});
															text16 = text16 + str + "\r\n";
														}
														else
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(32, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = num3.ToString() + "     " + text26 + text27;
															text16 = text16 + str + "\r\n";
														}
													}
													bool flag37 = (double)num3 > Conversions.ToDouble("9") & (double)num3 < Conversions.ToDouble("100");
													if (flag37)
													{
														bool flag38 = Conversions.ToBoolean(value);
														if (flag38)
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(28, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = string.Concat(new string[]
															{
																"      >",
																num3.ToString(),
																" ",
																text26,
																text27
															});
															text16 = text16 + str + "\r\n";
														}
														else
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(32, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
															string str = num3.ToString() + "    " + text26 + text27;
															text16 = text16 + str + "\r\n";
														}
													}
													bool flag39 = (double)num3 > Conversions.ToDouble("99") & (double)num3 < Conversions.ToDouble("1000");
													if (flag39)
													{
														bool flag40 = Conversions.ToBoolean(value);
														if (flag40)
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(27, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + ((double)num3 * num4).ToString("N2");
															string str = string.Concat(new string[]
															{
																"      >",
																num3.ToString(),
																" ",
																text26,
																text27
															});
															text16 = text16 + str + "\r\n";
														}
														else
														{
															string text25 = Conversions.ToString(sqlDataReader[1]);
															string text26 = text25;
															text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
															text26 = text26.PadRight(32, ' ');
															double num4 = Conversions.ToDouble(sqlDataReader[2]);
															string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
															string str = num3.ToString() + "   " + text26 + text27;
															text16 = text16 + str + "\r\n";
														}
													}
												}
											}
										}
										bool flag41 = (double)num2 == Conversions.ToDouble("0");
										if (flag41)
										{
											text2 = "select sum(cantidad) as Cantidad , b.descripcion , a.precio ,a.modificador  from cheqdet A WITH (NOLOCK)\r\n\t\t\t\t\t\t\t\t\tinner join  Productos B WITH (NOLOCK) on b.idproducto = a.idproducto \r\n\t\t\t\t\t\t\t\t\tInner join productosdetalle C WITH (NOLOCK) on c.idproducto = a.idproducto where foliodet='" + text + "' and  modificador='0'  group by a.cantidad,b.descripcion,a.precio,a.modificador order by cantidad desc";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
											bool hasRows4 = sqlDataReader.HasRows;
											if (hasRows4)
											{
												while (sqlDataReader.Read())
												{
													string value = Conversions.ToString(sqlDataReader[3]);
													int num3 = Conversions.ToInteger(sqlDataReader[0]);
													bool flag42 = (double)num3 < Conversions.ToDouble("10");
													if (flag42)
													{
														string text25 = Conversions.ToString(sqlDataReader[1]);
														string text26 = text25;
														text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
														text26 = text26.PadRight(32, ' ');
														double num4 = Conversions.ToDouble(sqlDataReader[2]);
														string text27 = "$" + ((double)num3 * num4).ToString("N2");
														string str = num3.ToString() + "     " + text26 + text27;
														text16 = text16 + str + "\r\n";
													}
													bool flag43 = (double)num3 > Conversions.ToDouble("9") & (double)num3 < Conversions.ToDouble("100");
													if (flag43)
													{
														string text25 = Conversions.ToString(sqlDataReader[1]);
														string text26 = text25;
														text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
														text26 = text26.PadRight(32, ' ');
														double num4 = Conversions.ToDouble(sqlDataReader[2]);
														string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
														string str = num3.ToString() + "    " + text26 + text27;
														text16 = text16 + str + "\r\n";
													}
													bool flag44 = (double)num3 > Conversions.ToDouble("99") & (double)num3 < Conversions.ToDouble("1000");
													if (flag44)
													{
														string text25 = Conversions.ToString(sqlDataReader[1]);
														string text26 = text25;
														text26 = Strings.Replace(text26, "\u001e", " ", 1, -1, CompareMethod.Binary);
														text26 = text26.PadRight(32, ' ');
														double num4 = Conversions.ToDouble(sqlDataReader[2]);
														string text27 = "$" + Conversions.ToDouble(((double)num3 * num4).ToString()).ToString("N2");
														string str = num3.ToString() + "   " + text26 + text27;
														text16 = text16 + str + "\r\n";
													}
												}
											}
										}
									}
								}
							}
							text2 = "Select ISNULL(Total,0) from cheques WITH (NOLOCK) where folio='" + text.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool flag45 = sqlDataReader.Read();
							if (flag45)
							{
								double num5 = Conversions.ToDouble(sqlDataReader[0].ToString());
								string text28 = num5.ToString("N2");
								string text29 = num5.ToString("N2");
								text16 += "                         =======================\r\n";
								text16 += this.DobleAlto;
								text16 = text16 + "                         TOTAL :    $" + num5.ToString("N2").PadRight(35, '\0') + "\r\n";
								text16 += this.DobleAlto_OFF;
								text16 += "                         =======================\r\n";
								text16 += this.DobleAlto_OFF;
								bool flag46 = Operators.CompareString(text29, "0.00", false) == 0;
								if (flag46)
								{
									text16 += "\r\n";
									text16 += this.eCentro;
									text16 += "SON:CERO PESOS CON 00/100 EN M.N.\r\n";
									text16 += "\u001b@";
									text16 += "\r\n";
								}
								bool flag47 = Operators.CompareString(text29, "0.00", false) != 0;
								if (flag47)
								{
									text16 += "\r\n";
									text16 += this.eCentro;
									text16 = text16 + "SON:" + aletras.Letras(text29.ToString()) + "\r\n";
									text16 += "\u001b@";
									text16 += "\r\n";
								}
							}
							text2 = "select ISNULL(subtotal,0), \r\n       ISNULL(totalimpuesto1,0)  from cheques  WITH (NOLOCK) where folio='" + text.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool flag48 = sqlDataReader.Read();
							if (flag48)
							{
								double num6 = Conversions.ToDouble(sqlDataReader[0]);
								double num7 = Conversions.ToDouble(sqlDataReader[1]);
								text16 += this.eCentro;
								text16 = string.Concat(new string[]
								{
									text16,
									"SUBTOTAL: $",
									num6.ToString("N2"),
									"  IVA: $",
									num7.ToString("N2"),
									"\r\n"
								});
								text16 += "\u001b@";
								text16 += "\r\n";
							}
							text2 = "select autofactura_enabled from configuracion_ws WITH (NOLOCK)";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool flag49 = sqlDataReader.Read();
							if (flag49)
							{
								string text30 = sqlDataReader[0].ToString();
								bool flag50 = Conversions.ToBoolean(sqlDataReader[0].ToString());
								if (flag50)
								{
									text2 = "select configuracion_vigencia , configuracion_url_personalizada   from configuracion_ws WITH (NOLOCK)";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
									bool flag51 = sqlDataReader.Read();
									if (flag51)
									{
										string text31 = sqlDataReader[0].ToString();
										string text32 = sqlDataReader[1].ToString();
										text2 = "select numcheque , codigo_unico_af from cheques WITH (NOLOCK) where folio = '" + text.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
										bool flag52 = sqlDataReader.Read();
										if (flag52)
										{
											string text33 = Conversions.ToString(sqlDataReader[0]);
											string text34 = Conversions.ToString(sqlDataReader[1]);
											text16 += "================================================\r\n";
											text16 += this.eCentro;
											text16 += "DATOS PARA GENERAR FACTURA\r\n";
											text16 += "\u001b@";
											text16 = text16 + "CODIGO:" + text34.ToString() + "\r\n";
											text16 = text16 + "FOLIO:" + text33.ToString() + "\r\n";
											text16 = text16 + "PAGINA:" + text32.ToString() + "\r\n";
											text16 = text16 + "DIAS DE VIGENCIA:" + text31.ToString() + "\r\n";
											text16 += "================================================\r\n";
											text16 += "\r\n";
										}
									}
								}
							}
							text2 = "select n , o , p  from bb WITH (NOLOCK)";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
							bool flag53 = sqlDataReader.Read();
							if (flag53)
							{
								string text35 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								string text36 = Tools.Desencriptar(sqlDataReader[1].ToString().Trim());
								string text37 = Tools.Desencriptar(sqlDataReader[2].ToString().Trim());
								text16 += this.eCentro;
								bool flag54 = Operators.CompareString(text35, "", false) == 0;
								if (!flag54)
								{
									text16 = text16 + text35.ToString() + "\r\n";
								}
								bool flag55 = Operators.CompareString(text36, "", false) == 0;
								if (!flag55)
								{
									text16 = text16 + text36.ToString() + "\r\n";
								}
								text16 += "\r\n";
								text16 = text16 + text37.ToString() + "\r\n";
								text16 += "\u001b@";
							}
							text16 += "\r\n";
							text16 += "\r\n";
							text2 = "SELECT ae FROM H WITH (NOLOCK)";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
							bool flag56 = sqlDataReader.Read();
							if (flag56)
							{
								string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								bool flag57 = Operators.CompareString(left, "1", false) == 0;
								if (flag57)
								{
									text2 = "select af from H WITH (NOLOCK)";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
									bool flag58 = sqlDataReader.Read();
									if (flag58)
									{
										string text38 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										this.lblimpresora.Text = text38;
										try
										{
											string text39 = text38;
											printDialog.PrinterSettings.PrinterName = text39.ToString();
											try
											{
												RawPrinterHelper.SendStringToPrinter(printDialog.PrinterSettings.PrinterName, text16 + this.CortePapel);
											}
											catch (Exception ex)
											{
												Interaction.MsgBox("Error de impresion", MsgBoxStyle.OkOnly, null);
											}
										}
										catch (Exception ex2)
										{
										}
									}
								}
							}
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
			Interaction.MsgBox("Los Tickets se enviaron a la impresora = " + this.lblimpresora.Text + "!", MsgBoxStyle.OkOnly, null);
			try
			{
				foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					dataGridViewRow2.Cells["Imprimir"].Value = false;
					bool flag59 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Imprimir"].Value, false, false);
					if (flag59)
					{
						dataGridViewRow2.DefaultCellStyle.BackColor = Color.White;
						dataGridViewRow2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
						this.txtTotalTickets.Text = "0";
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
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000B3E00 File Offset: 0x000B2000
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvNotas.Rows.Count == 0;
			if (flag)
			{
				Interaction.MsgBox("No hay Tickets para imprimir,intenta nuevamenete!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				object obj = "SE IMPRIMIRAN LOS FOLIOS SELECCIONADOS # " + this.txtTotalTickets.Text + ", Deseas continuar?";
				object value = 276;
				object obj2 = "ATENCIÓN!!!";
				object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
				bool flag2 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
				if (flag2)
				{
					this.PrintingOutTicketVenta();
				}
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000B3EA0 File Offset: 0x000B20A0
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 13;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Imprimir"].Value, true, false);
				if (flag2)
				{
					this.dgvNotas.Rows[rowIndex].Cells["Imprimir"].Value = false;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					this.txtTotalTickets.Text = Conversions.ToString(Conversions.ToDouble(this.txtTotalTickets.Text) - 1.0);
				}
				else
				{
					this.dgvNotas.Rows[rowIndex].Cells["Imprimir"].Value = true;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
					this.txtTotalTickets.Text = Conversions.ToString(Conversions.ToDouble(this.txtTotalTickets.Text) + 1.0);
				}
			}
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000B4068 File Offset: 0x000B2268
		private void CheckBox3_Todos_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			bool @checked = this.CheckBox3_Todos.Checked;
			checked
			{
				if (@checked)
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							dataGridViewRow.Cells["Imprimir"].Value = true;
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							num++;
							this.txtTotalTickets.Text = num.ToString();
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
				bool flag = !this.CheckBox3_Todos.Checked;
				if (flag)
				{
					try
					{
						foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
						{
							DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
							dataGridViewRow2.Cells["Imprimir"].Value = false;
							dataGridViewRow2.DefaultCellStyle.BackColor = Color.White;
							dataGridViewRow2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
							this.txtTotalTickets.Text = "0";
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
				}
			}
		}

		// Token: 0x040004AF RID: 1199
		public string sess_ESC;

		// Token: 0x040004B0 RID: 1200
		public string sess_EPSON_BOLD_ON;

		// Token: 0x040004B1 RID: 1201
		public string sess_EPSON_BOLD_OFF;

		// Token: 0x040004B2 RID: 1202
		public string sess_STAR_BOLD_ON;

		// Token: 0x040004B3 RID: 1203
		public string sess_STAR_BOLD_OFF;

		// Token: 0x040004B4 RID: 1204
		public string CortePapel;

		// Token: 0x040004B5 RID: 1205
		public string DobleAlto;

		// Token: 0x040004B6 RID: 1206
		public string DobleAlto_OFF;

		// Token: 0x040004B7 RID: 1207
		public string DobleAncho_ON;

		// Token: 0x040004B8 RID: 1208
		public string DobleAncho_OFF;

		// Token: 0x040004B9 RID: 1209
		public string eCentro;

		// Token: 0x040004BA RID: 1210
		public string eCentro_OFF;

		// Token: 0x040004BB RID: 1211
		public string eRight;

		// Token: 0x040004BC RID: 1212
		public const string eLeft = "\u001b@";

		// Token: 0x040004BD RID: 1213
		public string sess_PRINT_BOLD_ON;

		// Token: 0x040004BE RID: 1214
		public string sess_PRINT_BOLD_OFF;
	}
}
