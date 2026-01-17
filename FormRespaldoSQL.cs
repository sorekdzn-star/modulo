using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class FormRespaldoSQL : Form
	{
		// Token: 0x06000131 RID: 305 RVA: 0x000110F4 File Offset: 0x0000F2F4
		public FormRespaldoSQL()
		{
			base.Load += this.FormRespaldoSQL_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00012743 File Offset: 0x00010943
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00012750 File Offset: 0x00010950
		internal virtual SaveFileDialog SaveFileDialog1
		{
			[CompilerGenerated]
			get
			{
				return this._SaveFileDialog1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.SaveFileDialog1_FileOk);
				SaveFileDialog saveFileDialog = this._SaveFileDialog1;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk -= value2;
				}
				this._SaveFileDialog1 = value;
				saveFileDialog = this._SaveFileDialog1;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk += value2;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00012793 File Offset: 0x00010993
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0001279D File Offset: 0x0001099D
		internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000127A6 File Offset: 0x000109A6
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000127B0 File Offset: 0x000109B0
		internal virtual Button btnBackup
		{
			[CompilerGenerated]
			get
			{
				return this._btnBackup;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnBackup_Click);
				Button btnBackup = this._btnBackup;
				if (btnBackup != null)
				{
					btnBackup.Click -= value2;
				}
				this._btnBackup = value;
				btnBackup = this._btnBackup;
				if (btnBackup != null)
				{
					btnBackup.Click += value2;
				}
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000127F3 File Offset: 0x000109F3
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00012800 File Offset: 0x00010A00
		internal virtual Button btnConectar
		{
			[CompilerGenerated]
			get
			{
				return this._btnConectar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnConectar_Click);
				Button btnConectar = this._btnConectar;
				if (btnConectar != null)
				{
					btnConectar.Click -= value2;
				}
				this._btnConectar = value;
				btnConectar = this._btnConectar;
				if (btnConectar != null)
				{
					btnConectar.Click += value2;
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00012843 File Offset: 0x00010A43
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00012850 File Offset: 0x00010A50
		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label5_Click);
				Label label = this._Label5;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00012893 File Offset: 0x00010A93
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000128A0 File Offset: 0x00010AA0
		internal virtual ComboBox cboBaseDatos
		{
			[CompilerGenerated]
			get
			{
				return this._cboBaseDatos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cboBaseDatos_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.cboBaseDatos_SelectedValueChanged);
				EventHandler value4 = new EventHandler(this.cboBaseDatos_SelectionChangeCommitted);
				ComboBox cboBaseDatos = this._cboBaseDatos;
				if (cboBaseDatos != null)
				{
					cboBaseDatos.SelectedIndexChanged -= value2;
					cboBaseDatos.SelectedValueChanged -= value3;
					cboBaseDatos.SelectionChangeCommitted -= value4;
				}
				this._cboBaseDatos = value;
				cboBaseDatos = this._cboBaseDatos;
				if (cboBaseDatos != null)
				{
					cboBaseDatos.SelectedIndexChanged += value2;
					cboBaseDatos.SelectedValueChanged += value3;
					cboBaseDatos.SelectionChangeCommitted += value4;
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00012919 File Offset: 0x00010B19
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00012923 File Offset: 0x00010B23
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0001292C File Offset: 0x00010B2C
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00012936 File Offset: 0x00010B36
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0001293F File Offset: 0x00010B3F
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0001294C File Offset: 0x00010B4C
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0001298F File Offset: 0x00010B8F
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00012999 File Offset: 0x00010B99
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000129A2 File Offset: 0x00010BA2
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000129AC File Offset: 0x00010BAC
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000129B5 File Offset: 0x00010BB5
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000129BF File Offset: 0x00010BBF
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000129C8 File Offset: 0x00010BC8
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000129D4 File Offset: 0x00010BD4
		internal virtual ComboBox CboEstaciones
		{
			[CompilerGenerated]
			get
			{
				return this._CboEstaciones;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.CboEstaciones_SelectionChangeCommitted);
				ComboBox cboEstaciones = this._CboEstaciones;
				if (cboEstaciones != null)
				{
					cboEstaciones.SelectedIndexChanged -= value2;
					cboEstaciones.SelectionChangeCommitted -= value3;
				}
				this._CboEstaciones = value;
				cboEstaciones = this._CboEstaciones;
				if (cboEstaciones != null)
				{
					cboEstaciones.SelectedIndexChanged += value2;
					cboEstaciones.SelectionChangeCommitted += value3;
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00012A32 File Offset: 0x00010C32
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00012A3C File Offset: 0x00010C3C
		internal virtual Button btnBuscar
		{
			[CompilerGenerated]
			get
			{
				return this._btnBuscar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button btnBuscar = this._btnBuscar;
				if (btnBuscar != null)
				{
					btnBuscar.Click -= value2;
				}
				this._btnBuscar = value;
				btnBuscar = this._btnBuscar;
				if (btnBuscar != null)
				{
					btnBuscar.Click += value2;
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00012A7F File Offset: 0x00010C7F
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00012A8C File Offset: 0x00010C8C
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00012ACF File Offset: 0x00010CCF
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00012ADC File Offset: 0x00010CDC
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00012B1F File Offset: 0x00010D1F
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00012B29 File Offset: 0x00010D29
		internal virtual Panel PanelInformacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00012B32 File Offset: 0x00010D32
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00012B3C File Offset: 0x00010D3C
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00012B45 File Offset: 0x00010D45
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00012B4F File Offset: 0x00010D4F
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00012B58 File Offset: 0x00010D58
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00012B62 File Offset: 0x00010D62
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00012B6B File Offset: 0x00010D6B
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00012B78 File Offset: 0x00010D78
		internal virtual PictureBox PictureBox4
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox4_Click);
				PictureBox pictureBox = this._PictureBox4;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox4 = value;
				pictureBox = this._PictureBox4;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00012BBB File Offset: 0x00010DBB
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00012BC5 File Offset: 0x00010DC5
		internal virtual CheckBox CheckBoxEstacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00012BCE File Offset: 0x00010DCE
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00012BD8 File Offset: 0x00010DD8
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00012BE1 File Offset: 0x00010DE1
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00012BEC File Offset: 0x00010DEC
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
				EventHandler value3 = new EventHandler(this.CheckBox1_Click);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
					checkBox.Click -= value3;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
					checkBox.Click += value3;
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00012C4A File Offset: 0x00010E4A
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00012C54 File Offset: 0x00010E54
		internal virtual CheckBox CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox2_CheckedChanged);
				EventHandler value3 = new EventHandler(this.CheckBox2_Click);
				CheckBox checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
					checkBox.Click -= value3;
				}
				this._CheckBox2 = value;
				checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
					checkBox.Click += value3;
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00012CB2 File Offset: 0x00010EB2
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00012CBC File Offset: 0x00010EBC
		internal virtual Button btnRecuperar
		{
			[CompilerGenerated]
			get
			{
				return this._btnRecuperar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRecuperar_Click);
				Button btnRecuperar = this._btnRecuperar;
				if (btnRecuperar != null)
				{
					btnRecuperar.Click -= value2;
				}
				this._btnRecuperar = value;
				btnRecuperar = this._btnRecuperar;
				if (btnRecuperar != null)
				{
					btnRecuperar.Click += value2;
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00012CFF File Offset: 0x00010EFF
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00012D09 File Offset: 0x00010F09
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00012D12 File Offset: 0x00010F12
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00012D1C File Offset: 0x00010F1C
		internal virtual Label lblBuscarruta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00012D25 File Offset: 0x00010F25
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00012D2F File Offset: 0x00010F2F
		internal virtual Label lblnombredbo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00012D38 File Offset: 0x00010F38
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00012D42 File Offset: 0x00010F42
		internal virtual TextBox txtRutadboRestaurat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00012D4B File Offset: 0x00010F4B
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00012D55 File Offset: 0x00010F55
		internal virtual TextBox txtDboRestaurar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00012D5E File Offset: 0x00010F5E
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00012D68 File Offset: 0x00010F68
		internal virtual SaveFileDialog SaveFileDialog2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00012D71 File Offset: 0x00010F71
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00012D7B File Offset: 0x00010F7B
		internal virtual OpenFileDialog OpenFileDialog2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00012D84 File Offset: 0x00010F84
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00012D90 File Offset: 0x00010F90
		internal virtual PictureBox btnBuscarRuta
		{
			[CompilerGenerated]
			get
			{
				return this._btnBuscarRuta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox5_Click);
				PictureBox btnBuscarRuta = this._btnBuscarRuta;
				if (btnBuscarRuta != null)
				{
					btnBuscarRuta.Click -= value2;
				}
				this._btnBuscarRuta = value;
				btnBuscarRuta = this._btnBuscarRuta;
				if (btnBuscarRuta != null)
				{
					btnBuscarRuta.Click += value2;
				}
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00012DD4 File Offset: 0x00010FD4
		private void btnConectar_Click(object sender, EventArgs e)
		{
			this.cboBaseDatos.Items.Clear();
			this.btnConectar.Enabled = false;
			SqlQuery sqlQuery = new SqlQuery();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("SELECT name from sys.databases");
			while (sqlDataReader.Read())
			{
				this.cboBaseDatos.Items.Add(sqlDataReader[0].ToString());
			}
			sqlDataReader.Close();
			this.cboBaseDatos.SelectedIndex = 0;
			this.cboBaseDatos.Enabled = true;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00012E64 File Offset: 0x00011064
		private void btnBackup_Click(object sender, EventArgs e)
		{
			this.btnBackup.Enabled = false;
			SqlQuery sqlQuery = new SqlQuery();
			bool flag = !this.CheckBoxEstacion.Checked;
			if (flag)
			{
				bool flag2 = !Directory.Exists("C:\\RespaldoSoftRestaurant");
				if (flag2)
				{
					Directory.CreateDirectory("C:\\RespaldoSoftRestaurant");
				}
				string text = string.Concat(new string[]
				{
					DateTime.Today.Day.ToString(),
					"-",
					DateTime.Today.Month.ToString(),
					"-",
					DateTime.Today.Year.ToString(),
					"-",
					DateTime.Now.Hour.ToString(),
					"-",
					DateTime.Now.Minute.ToString(),
					"-",
					DateTime.Now.Second.ToString(),
					"-CopiaSoftRestaurant.bak"
				});
				string cmdText = string.Concat(new string[]
				{
					"BACKUP DATABASE [",
					this.cboBaseDatos.Text,
					"] TO  DISK = 'C:\\RespaldoSoftRestaurant\\",
					text,
					"' WITH NOFORMAT, NOINIT,  NAME = N'SoftRestaurant8Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
				});
				SqlConnection sqlConnection = new SqlConnection(string.Concat(new string[]
				{
					"Server = ",
					this.CboEstaciones.Text,
					"\\",
					MyProject.Forms.main.lblInstancia.Text,
					";User Id=",
					MyProject.Forms.main.lblUsuariosql.Text,
					";Password=",
					MyProject.Forms.main.lblpasswordsql.Text,
					";Connect Timeout=10;"
				}));
				SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
				try
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("No existe conexion con el servidor", MsgBoxStyle.OkOnly, null);
				}
				Interaction.MsgBox(("La Copia de Seguridad se hizo correctamente!\r\nBase de datos respaldada : " + this.cboBaseDatos.Text) ?? "", MsgBoxStyle.OkOnly, null);
				sqlConnection.Close();
				this.CboEstaciones.Enabled = false;
				this.btnBuscar.Enabled = false;
				this.btnConectar.Enabled = false;
				this.cboBaseDatos.Enabled = false;
				this.btnBackup.Visible = false;
				this.CheckBox1.Checked = false;
				this.CboEstaciones.Items.Clear();
				this.cboBaseDatos.Items.Clear();
			}
			bool @checked = this.CheckBoxEstacion.Checked;
			if (@checked)
			{
				string text2 = string.Concat(new string[]
				{
					DateTime.Today.Day.ToString(),
					"-",
					DateTime.Today.Month.ToString(),
					"-",
					DateTime.Today.Year.ToString(),
					"-",
					DateTime.Now.Hour.ToString(),
					"-",
					DateTime.Now.Minute.ToString(),
					"-",
					DateTime.Now.Second.ToString(),
					"-CopiaSoftRestaurant.bak"
				});
				string cmdText = string.Concat(new string[]
				{
					"BACKUP DATABASE [",
					this.cboBaseDatos.Text,
					"] TO  DISK = '\\\\",
					this.CboEstaciones.Text,
					"\\RespaldoSoftRestaurant\\",
					text2,
					"' WITH NOFORMAT, NOINIT,  NAME = N'SoftRestaurantFull Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
				});
				SqlConnection sqlConnection2 = new SqlConnection(string.Concat(new string[]
				{
					"Server = ",
					this.CboEstaciones.Text,
					"\\",
					MyProject.Forms.main.lblInstancia.Text,
					";User Id=",
					MyProject.Forms.main.lblUsuariosql.Text,
					" ;Password=",
					MyProject.Forms.main.lblpasswordsql.Text,
					";Connect Timeout=10;"
				}));
				SqlCommand sqlCommand2 = new SqlCommand(cmdText, sqlConnection2);
				try
				{
					sqlConnection2.Open();
					sqlCommand2.ExecuteNonQuery();
				}
				catch (Exception ex2)
				{
					Interaction.MsgBox("No existe conexion con el servidor", MsgBoxStyle.OkOnly, null);
				}
				Interaction.MsgBox(("La Copia de Seguridad se hizo correctamente!\r\nBase de datos respaldada : " + this.cboBaseDatos.Text) ?? "", MsgBoxStyle.OkOnly, null);
				sqlConnection2.Close();
				base.Close();
				MyProject.Forms.main.PanelContenedorForms.Visible = true;
				MyProject.Forms.main.btnEliminarProductos.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.btnEliminacionMasiva.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.BtnModificar1Ticket.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.BtnModificarTurnos.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.BtnReportes.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.btnPanico.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.BtnBitacora.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.btnConfiguracion.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.BtnRespaldar.BackColor = SystemColors.ActiveCaption;
				MyProject.Forms.main.PanelContenedorForms.Visible = true;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000036D5 File Offset: 0x000018D5
		private void btnRestaurar_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000036D5 File Offset: 0x000018D5
		private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000134A8 File Offset: 0x000116A8
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
			MyProject.Forms.main.PanelContenedorForms.Visible = true;
			MyProject.Forms.main.btnEliminarProductos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnEliminacionMasiva.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificar1Ticket.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificarTurnos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnReportes.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnPanico.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnBitacora.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnConfiguracion.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnRespaldar.BackColor = SystemColors.ActiveCaption;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000135BD File Offset: 0x000117BD
		private void cboBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnBackup.Enabled = true;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000036D5 File Offset: 0x000018D5
		private void cboBaseDatos_SelectedValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000135CD File Offset: 0x000117CD
		private void cboBaseDatos_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.cboBaseDatos.Enabled = false;
			this.txtDboRestaurar.Text = this.cboBaseDatos.Text;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000135F4 File Offset: 0x000117F4
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnConectar.Enabled = true;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00013604 File Offset: 0x00011804
		private void Button1_Click(object sender, EventArgs e)
		{
			this.CboEstaciones.Items.Clear();
			this.btnBuscar.Enabled = false;
			SqlQuery sqlQuery = new SqlQuery();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("SELECT idestacion from estaciones");
			while (sqlDataReader.Read())
			{
				this.CboEstaciones.Items.Add(sqlDataReader[0].ToString());
			}
			sqlDataReader.Close();
			this.CboEstaciones.SelectedIndex = 0;
			this.CboEstaciones.Enabled = true;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00013692 File Offset: 0x00011892
		private void CboEstaciones_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.CboEstaciones.Enabled = false;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000136A2 File Offset: 0x000118A2
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.PanelInformacion.Visible = true;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000136B4 File Offset: 0x000118B4
		private void FormRespaldoSQL_Load(object sender, EventArgs e)
		{
			this.PanelInformacion.Visible = false;
			this.btnBackup.Visible = false;
			this.btnRecuperar.Visible = false;
			this.btnBuscarRuta.Visible = false;
			this.txtDboRestaurar.Visible = false;
			this.txtRutadboRestaurat.Visible = false;
			this.lblBuscarruta.Visible = false;
			this.lblnombredbo.Visible = false;
			this.CboEstaciones.Enabled = false;
			this.btnBuscar.Enabled = false;
			this.btnConectar.Enabled = false;
			this.cboBaseDatos.Enabled = false;
			this.btnBackup.Enabled = false;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001376B File Offset: 0x0001196B
		private void PictureBox4_Click(object sender, EventArgs e)
		{
			this.PanelInformacion.Visible = false;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001377C File Offset: 0x0001197C
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				this.btnBackup.Visible = true;
			}
			else
			{
				bool flag = !this.CheckBox1.Checked;
				if (flag)
				{
					this.btnBackup.Visible = false;
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000137CC File Offset: 0x000119CC
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox2.Checked;
			if (@checked)
			{
				this.btnRecuperar.Visible = true;
				this.btnBuscarRuta.Visible = true;
				this.txtDboRestaurar.Visible = true;
				this.txtRutadboRestaurat.Visible = true;
				this.lblBuscarruta.Visible = true;
				this.lblnombredbo.Visible = true;
				this.btnBuscar.Enabled = true;
			}
			else
			{
				bool flag = !this.CheckBox2.Checked;
				if (flag)
				{
					this.btnRecuperar.Visible = false;
					this.btnBuscarRuta.Visible = false;
					this.txtDboRestaurar.Visible = false;
					this.txtRutadboRestaurat.Visible = false;
					this.lblBuscarruta.Visible = false;
					this.lblnombredbo.Visible = false;
					this.btnBuscar.Enabled = false;
				}
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000138B8 File Offset: 0x00011AB8
		private void CheckBox1_Click(object sender, EventArgs e)
		{
			this.CheckBox2.Checked = false;
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				this.btnBuscar.Enabled = true;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000138F1 File Offset: 0x00011AF1
		private void CheckBox2_Click(object sender, EventArgs e)
		{
			this.CheckBox1.Checked = false;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00013904 File Offset: 0x00011B04
		private void btnRecuperar_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(string.Concat(new string[]
			{
				"Server = ",
				this.CboEstaciones.Text,
				"\\",
				MyProject.Forms.main.lblInstancia.Text,
				";User Id=",
				MyProject.Forms.main.lblUsuariosql.Text,
				";Password=",
				MyProject.Forms.main.lblpasswordsql.Text,
				";Connect Timeout=10;"
			}));
			try
			{
				sqlConnection.Open();
				string cmdText = string.Concat(new string[]
				{
					"ALTER DATABASE [",
					this.cboBaseDatos.Text,
					"] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;USE Master;RESTORE DATABASE [",
					this.cboBaseDatos.Text,
					"] FROM DISK = '",
					this.txtRutadboRestaurat.Text,
					"' WITH REPLACE;"
				});
				SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
				sqlCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlConnection.Close();
				sqlConnection.Dispose();
			}
			Interaction.MsgBox(("Base de datos restaurada correctamente,\r\nNombre de base de datos : " + this.txtDboRestaurar.Text) ?? "", MsgBoxStyle.OkOnly, null);
			base.Close();
			MyProject.Forms.main.btnEliminarProductos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnEliminacionMasiva.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificar1Ticket.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificarTurnos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnReportes.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnPanico.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnBitacora.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnConfiguracion.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnRespaldar.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.PanelContenedorForms.Visible = true;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00013B88 File Offset: 0x00011D88
		private void PictureBox5_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Respaldo SQL|*.bak",
				FileName = ""
			})
			{
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtRutadboRestaurat.Text = openFileDialog.FileName;
				}
			}
		}
	}
}
