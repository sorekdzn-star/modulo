using System;
using System.Collections;
using System.Collections.Generic;
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
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class FormModificarTicket : Form
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00007830 File Offset: 0x00005A30
		public FormModificarTicket()
		{
			base.Load += this.FormModificarTicket_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000B748 File Offset: 0x00009948
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000B752 File Offset: 0x00009952
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000B75B File Offset: 0x0000995B
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000B765 File Offset: 0x00009965
		internal virtual Label lblFechaInicio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000B76E File Offset: 0x0000996E
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000B778 File Offset: 0x00009978
		internal virtual Label lblFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000B781 File Offset: 0x00009981
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000B78B File Offset: 0x0000998B
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000B794 File Offset: 0x00009994
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000B79E File Offset: 0x0000999E
		internal virtual GroupBox groupPeriodo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000B7A7 File Offset: 0x000099A7
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000B7B1 File Offset: 0x000099B1
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000B7BA File Offset: 0x000099BA
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000B7C4 File Offset: 0x000099C4
		internal virtual PictureBox BtnHorario { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000B7CD File Offset: 0x000099CD
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000B7D7 File Offset: 0x000099D7
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000B7E0 File Offset: 0x000099E0
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000B7EC File Offset: 0x000099EC
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000B82F File Offset: 0x00009A2F
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000B839 File Offset: 0x00009A39
		internal virtual Label lblfechahoy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000B842 File Offset: 0x00009A42
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000B84C File Offset: 0x00009A4C
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000B855 File Offset: 0x00009A55
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000B860 File Offset: 0x00009A60
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000B8A3 File Offset: 0x00009AA3
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000B8AD File Offset: 0x00009AAD
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000B8B6 File Offset: 0x00009AB6
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000B8C9 File Offset: 0x00009AC9
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000B8D3 File Offset: 0x00009AD3
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000B8DC File Offset: 0x00009ADC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000B8E6 File Offset: 0x00009AE6
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000B8EF File Offset: 0x00009AEF
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000B8F9 File Offset: 0x00009AF9
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000B902 File Offset: 0x00009B02
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000B90C File Offset: 0x00009B0C
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000B915 File Offset: 0x00009B15
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000B91F File Offset: 0x00009B1F
		internal virtual GroupBox groupParametros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000B928 File Offset: 0x00009B28
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000B932 File Offset: 0x00009B32
		internal virtual ComboBox cmbxEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000B93B File Offset: 0x00009B3B
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000B945 File Offset: 0x00009B45
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000B94E File Offset: 0x00009B4E
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000B958 File Offset: 0x00009B58
		internal virtual ComboBox cmbxTipo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000B961 File Offset: 0x00009B61
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000B96B File Offset: 0x00009B6B
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000B974 File Offset: 0x00009B74
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000B980 File Offset: 0x00009B80
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000B9C3 File Offset: 0x00009BC3
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000B9CD File Offset: 0x00009BCD
		internal virtual CheckBox chkReemplazar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000B9D6 File Offset: 0x00009BD6
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000B9E9 File Offset: 0x00009BE9
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000B9F3 File Offset: 0x00009BF3
		internal virtual Panel Panel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000B9FC File Offset: 0x00009BFC
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000BA06 File Offset: 0x00009C06
		internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000BA0F File Offset: 0x00009C0F
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000BA19 File Offset: 0x00009C19
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000BA22 File Offset: 0x00009C22
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000BA2C File Offset: 0x00009C2C
		internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000BA35 File Offset: 0x00009C35
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000BA3F File Offset: 0x00009C3F
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000BA48 File Offset: 0x00009C48
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000BA52 File Offset: 0x00009C52
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000BA5B File Offset: 0x00009C5B
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000BA65 File Offset: 0x00009C65
		internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000BA6E File Offset: 0x00009C6E
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000BA78 File Offset: 0x00009C78
		internal virtual Panel Panel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000BA81 File Offset: 0x00009C81
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000BA8C File Offset: 0x00009C8C
		internal virtual DataGridView DgvTicketsPeriodo
		{
			[CompilerGenerated]
			get
			{
				return this._DgvTicketsPeriodo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DgvTicketsPeriodo_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DgvTicketsPeriodo_CellDoubleClick);
				DataGridView dgvTicketsPeriodo = this._DgvTicketsPeriodo;
				if (dgvTicketsPeriodo != null)
				{
					dgvTicketsPeriodo.CellContentClick -= value2;
					dgvTicketsPeriodo.CellDoubleClick -= value3;
				}
				this._DgvTicketsPeriodo = value;
				dgvTicketsPeriodo = this._DgvTicketsPeriodo;
				if (dgvTicketsPeriodo != null)
				{
					dgvTicketsPeriodo.CellContentClick += value2;
					dgvTicketsPeriodo.CellDoubleClick += value3;
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000BAEA File Offset: 0x00009CEA
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000BAFD File Offset: 0x00009CFD
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000BB07 File Offset: 0x00009D07
		internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000BB10 File Offset: 0x00009D10
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000BB1A File Offset: 0x00009D1A
		internal virtual Panel Panel_MovtosTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000BB23 File Offset: 0x00009D23
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000BB30 File Offset: 0x00009D30
		internal virtual Button btnAddMovto
		{
			[CompilerGenerated]
			get
			{
				return this._btnAddMovto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAddMovto_Click);
				Button btnAddMovto = this._btnAddMovto;
				if (btnAddMovto != null)
				{
					btnAddMovto.Click -= value2;
				}
				this._btnAddMovto = value;
				btnAddMovto = this._btnAddMovto;
				if (btnAddMovto != null)
				{
					btnAddMovto.Click += value2;
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000BB73 File Offset: 0x00009D73
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000BB80 File Offset: 0x00009D80
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000BBC3 File Offset: 0x00009DC3
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000BBD0 File Offset: 0x00009DD0
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000BC13 File Offset: 0x00009E13
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000BC1D File Offset: 0x00009E1D
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000BC26 File Offset: 0x00009E26
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000BC30 File Offset: 0x00009E30
		internal virtual TextBox txtTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000BC39 File Offset: 0x00009E39
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000BC43 File Offset: 0x00009E43
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000BC4C File Offset: 0x00009E4C
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000BC56 File Offset: 0x00009E56
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000BC5F File Offset: 0x00009E5F
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000BC69 File Offset: 0x00009E69
		internal virtual TextBox txtSubtotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000BC72 File Offset: 0x00009E72
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000BC7C File Offset: 0x00009E7C
		internal virtual TextBox txtDescuento
		{
			[CompilerGenerated]
			get
			{
				return this._txtDescuento;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtDescuento_TextChanged);
				TextBox txtDescuento = this._txtDescuento;
				if (txtDescuento != null)
				{
					txtDescuento.TextChanged -= value2;
				}
				this._txtDescuento = value;
				txtDescuento = this._txtDescuento;
				if (txtDescuento != null)
				{
					txtDescuento.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000BCBF File Offset: 0x00009EBF
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000BCC9 File Offset: 0x00009EC9
		internal virtual TextBox txtPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000BCD2 File Offset: 0x00009ED2
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000BCDC File Offset: 0x00009EDC
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000BCE5 File Offset: 0x00009EE5
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000BCEF File Offset: 0x00009EEF
		internal virtual Label lblPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000BCF8 File Offset: 0x00009EF8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000BD02 File Offset: 0x00009F02
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000BD0B File Offset: 0x00009F0B
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000BD15 File Offset: 0x00009F15
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000BD1E File Offset: 0x00009F1E
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000BD28 File Offset: 0x00009F28
		public virtual TextBox txtBuscarFolio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000BD31 File Offset: 0x00009F31
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000BD3B File Offset: 0x00009F3B
		internal virtual TextBox txtSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000BD44 File Offset: 0x00009F44
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000BD4E File Offset: 0x00009F4E
		internal virtual Label lblSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000BD57 File Offset: 0x00009F57
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000BD61 File Offset: 0x00009F61
		internal virtual CheckBox CheckBox_Facturado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000BD6A File Offset: 0x00009F6A
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000BD74 File Offset: 0x00009F74
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000BDB7 File Offset: 0x00009FB7
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000BDC4 File Offset: 0x00009FC4
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
				DataGridViewCellFormattingEventHandler value2 = new DataGridViewCellFormattingEventHandler(this.dgvNotas_CellFormatting);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvNotas_CellClick);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.dgvNotas_CellContentClick_1);
				DataGridViewCellValidatingEventHandler value5 = new DataGridViewCellValidatingEventHandler(this.dgvNotas_CellValidating);
				DataGridViewCellMouseEventHandler value6 = new DataGridViewCellMouseEventHandler(this.dgvNotas_CellMouseMove);
				DataGridViewCellEventHandler value7 = new DataGridViewCellEventHandler(this.dgvNotas_CellMouseLeave);
				DataGridViewCellMouseEventHandler value8 = new DataGridViewCellMouseEventHandler(this.dgvNotas_CellMouseClick);
				DataGridViewCellEventHandler value9 = new DataGridViewCellEventHandler(this.dgvNotas_CellEndEdit);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellFormatting -= value2;
					dgvNotas.CellClick -= value3;
					dgvNotas.CellContentClick -= value4;
					dgvNotas.CellValidating -= value5;
					dgvNotas.CellMouseMove -= value6;
					dgvNotas.CellMouseLeave -= value7;
					dgvNotas.CellMouseClick -= value8;
					dgvNotas.CellEndEdit -= value9;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellFormatting += value2;
					dgvNotas.CellClick += value3;
					dgvNotas.CellContentClick += value4;
					dgvNotas.CellValidating += value5;
					dgvNotas.CellMouseMove += value6;
					dgvNotas.CellMouseLeave += value7;
					dgvNotas.CellMouseClick += value8;
					dgvNotas.CellEndEdit += value9;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000BEEE File Offset: 0x0000A0EE
		internal virtual Panel PanelBuscarProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000BEF7 File Offset: 0x0000A0F7
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000BF01 File Offset: 0x0000A101
		internal virtual Panel Panel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000BF0A File Offset: 0x0000A10A
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000BF14 File Offset: 0x0000A114
		internal virtual DataGridView dgwProductos
		{
			[CompilerGenerated]
			get
			{
				return this._dgwProductos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgwProductos_CellDoubleClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgwProductos_CellContentClick);
				DataGridView dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellDoubleClick -= value2;
					dgwProductos.CellContentClick -= value3;
				}
				this._dgwProductos = value;
				dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellDoubleClick += value2;
					dgwProductos.CellContentClick += value3;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000BF72 File Offset: 0x0000A172
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000BF7C File Offset: 0x0000A17C
		internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000BF85 File Offset: 0x0000A185
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000BF8F File Offset: 0x0000A18F
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000BF98 File Offset: 0x0000A198
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
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
				EventHandler value2 = new EventHandler(this.txtBuscarProducto_TextChanged_1);
				TextBox txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged -= value2;
				}
				this._txtBuscarProducto = value;
				txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000BFE7 File Offset: 0x0000A1E7
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000C037 File Offset: 0x0000A237
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000C041 File Offset: 0x0000A241
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000C04A File Offset: 0x0000A24A
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000C054 File Offset: 0x0000A254
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000C05D File Offset: 0x0000A25D
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000C067 File Offset: 0x0000A267
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000C070 File Offset: 0x0000A270
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000C07C File Offset: 0x0000A27C
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
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DgvFormasPago_CellClick);
				DataGridView dgvFormasPago = this._DgvFormasPago;
				if (dgvFormasPago != null)
				{
					dgvFormasPago.CellClick -= value2;
				}
				this._DgvFormasPago = value;
				dgvFormasPago = this._DgvFormasPago;
				if (dgvFormasPago != null)
				{
					dgvFormasPago.CellClick += value2;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000C0BF File Offset: 0x0000A2BF
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000C0C9 File Offset: 0x0000A2C9
		internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000C0D2 File Offset: 0x0000A2D2
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000C0E5 File Offset: 0x0000A2E5
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000C0EF File Offset: 0x0000A2EF
		internal virtual Label lblNumeroFilaFormaPago { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000C102 File Offset: 0x0000A302
		internal virtual Label lblhoradelticket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000C10B File Offset: 0x0000A30B
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000C115 File Offset: 0x0000A315
		internal virtual Label lblestacionName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000C11E File Offset: 0x0000A31E
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000C128 File Offset: 0x0000A328
		internal virtual Label lblidmesero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000C131 File Offset: 0x0000A331
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000C13B File Offset: 0x0000A33B
		internal virtual Label lblidturno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000C144 File Offset: 0x0000A344
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000C14E File Offset: 0x0000A34E
		internal virtual Label lblFacturado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600010C RID: 268 RVA: 0x0000C158 File Offset: 0x0000A358
		private void FormModificarTicket_Load(object sender, EventArgs e)
		{
			this.llenaCombos();
			this.habilitaControles(false);
			this.iniciaGridFolio();
			this.iniciaGridFiormasPago();
			this.PanelBuscarProducto.Visible = false;
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
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000C238 File Offset: 0x0000A438
		private void llenaCombos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.cmbxEmpresa.Items.Clear();
			this.cmbxTipo.Items.Clear();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("select distinct(idempresa) from empresas");
			while (sqlDataReader.Read())
			{
				this.cmbxEmpresa.Items.Add(sqlDataReader[0].ToString());
			}
			this.cmbxTipo.Items.Add("Modificar 1 Ticket");
			sqlDataReader.Close();
			this.cmbxTipo.SelectedIndex = 0;
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

		// Token: 0x0600010E RID: 270 RVA: 0x0000C344 File Offset: 0x0000A544
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000C378 File Offset: 0x0000A578
		private void habilitaControles(bool boolDeasbilita)
		{
			if (boolDeasbilita)
			{
				this.btnVistaPrevia.Text = "Vista Previa";
				this.groupParametros.Enabled = true;
				this.groupPeriodo.Enabled = true;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
				this.dateFechaIni.Enabled = true;
				this.dateFechaFin.Enabled = true;
				this.btnVistaPrevia.Enabled = true;
				this.BtnHorario.Visible = true;
				this.Label27.Visible = true;
				this.BtnHorario.Enabled = true;
				this.Panel_MovtosTicket.Enabled = true;
				this.dgvNotas.Enabled = true;
			}
			else
			{
				this.btnVistaPrevia.Text = "Espere...";
				this.Panel_MovtosTicket.Enabled = false;
				this.groupParametros.Enabled = false;
				this.ComboBox1.Enabled = false;
				this.dateFechaFin.Enabled = false;
				this.dateFechaIni.Enabled = false;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
				this.btnVistaPrevia.Enabled = false;
				this.BtnHorario.Visible = false;
				this.Label27.Visible = false;
				this.BtnHorario.Enabled = false;
				this.dgvNotas.Enabled = false;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
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
						this.habilitaControles(false);
						sqlDataReader.Close();
					}
					else
					{
						sqlDataReader.Close();
						this.habilitaControles(true);
						this.dateFechaIni.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaFin.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaIni.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						this.dateFechaFin.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						bool flag2 = Operators.CompareString(Tools.Gm(this.ComboBox1.Text), "12", false) == 0;
						if (flag2)
						{
							this.dateFechaIni.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 1);
							this.dateFechaFin.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 6);
						}
						else
						{
							this.dateFechaIni.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 1);
							this.dateFechaFin.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 6);
						}
						this.dateFechaIni.Value = this.dateFechaIni.MinDate;
						this.dateFechaFin.Value = this.dateFechaFin.MinDate;
					}
				}
				else
				{
					this.habilitaControles(false);
					sqlDataReader.Close();
				}
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000C7BC File Offset: 0x0000A9BC
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

		// Token: 0x06000112 RID: 274 RVA: 0x0000CA98 File Offset: 0x0000AC98
		private void iniciaGridVerTickets()
		{
			this.DgvTicketsPeriodo.Rows.Clear();
			this.DgvTicketsPeriodo.ColumnCount = 11;
			this.DgvTicketsPeriodo.Columns[0].Name = "id_Folio";
			this.DgvTicketsPeriodo.Columns[0].Visible = false;
			this.DgvTicketsPeriodo.Columns[0].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[1].Name = "Serie";
			this.DgvTicketsPeriodo.Columns[1].Width = 37;
			this.DgvTicketsPeriodo.Columns[1].ReadOnly = false;
			this.DgvTicketsPeriodo.Columns[2].Name = "Folio";
			this.DgvTicketsPeriodo.Columns[2].Width = 50;
			this.DgvTicketsPeriodo.Columns[2].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[3].Name = "Descuento %";
			this.DgvTicketsPeriodo.Columns[3].Width = 40;
			this.DgvTicketsPeriodo.Columns[3].Visible = false;
			this.DgvTicketsPeriodo.Columns[3].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[4].Name = "Facturado";
			this.DgvTicketsPeriodo.Columns[4].Width = 60;
			this.DgvTicketsPeriodo.Columns[4].Visible = true;
			this.DgvTicketsPeriodo.Columns[4].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[5].Name = "Total";
			this.DgvTicketsPeriodo.Columns[5].Width = 60;
			this.DgvTicketsPeriodo.Columns[5].Visible = true;
			this.DgvTicketsPeriodo.Columns[5].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[6].Name = "Efectivo";
			this.DgvTicketsPeriodo.Columns[6].Width = 60;
			this.DgvTicketsPeriodo.Columns[6].Visible = true;
			this.DgvTicketsPeriodo.Columns[6].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[7].Name = "Tarjeta";
			this.DgvTicketsPeriodo.Columns[7].Width = 60;
			this.DgvTicketsPeriodo.Columns[7].Visible = true;
			this.DgvTicketsPeriodo.Columns[7].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[8].Name = "Vales";
			this.DgvTicketsPeriodo.Columns[8].Width = 60;
			this.DgvTicketsPeriodo.Columns[8].Visible = true;
			this.DgvTicketsPeriodo.Columns[8].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[9].Name = "Otros";
			this.DgvTicketsPeriodo.Columns[9].Visible = true;
			this.DgvTicketsPeriodo.Columns[9].Width = 60;
			this.DgvTicketsPeriodo.Columns[9].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[10].Name = "Propina";
			this.DgvTicketsPeriodo.Columns[10].Visible = true;
			this.DgvTicketsPeriodo.Columns[10].Width = 60;
			this.DgvTicketsPeriodo.Columns[10].Visible = false;
			this.DoubleBufferedASD(this.DgvTicketsPeriodo, true);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		public void MostrarTickets()
		{
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			SqlQuery sqlQuery = new SqlQuery();
			string query = string.Concat(new string[]
			{
				" SELECT folio,Seriefolio,Numcheque,Facturado,descuento,Total,Efectivo,Tarjeta,Vales,Otros,propina from cheques\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
				text,
				"' AND '",
				text2,
				"' AND \r\n                    cierre is not null and idempresa='",
				Tools.id_Empresa,
				"')\r\n                    and idempresa='",
				Tools.id_Empresa,
				"' order by folio"
			});
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			this.iniciaGridVerTickets();
			this.DoubleBufferedASD(this.DgvTicketsPeriodo, true);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.ComboBox1.Enabled = false;
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					string text4 = Conversions.ToString(sqlDataReader[1]);
					string text5 = Conversions.ToString(sqlDataReader[2]);
					bool flag = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
					string text6;
					if (flag)
					{
						text6 = "Si";
					}
					else
					{
						text6 = "No";
					}
					double num = Conversions.ToDouble(sqlDataReader[4]);
					double a = Conversions.ToDouble(sqlDataReader[5]);
					double a2 = Conversions.ToDouble(sqlDataReader[6]);
					double a3 = Conversions.ToDouble(sqlDataReader[7]);
					double a4 = Conversions.ToDouble(sqlDataReader[8]);
					double a5 = Conversions.ToDouble(sqlDataReader[9]);
					double num2 = Conversions.ToDouble(sqlDataReader[10]);
					this.DgvTicketsPeriodo.Rows.Add(new object[]
					{
						text3,
						text4,
						text5,
						num,
						text6,
						Math.Round(a).ToString("N2"),
						Math.Round(a2).ToString("N2"),
						Math.Round(a3).ToString("N2"),
						Math.Round(a4).ToString("N2"),
						Math.Round(a5).ToString("N2"),
						num2.ToString("N2")
					});
				}
				sqlDataReader.Close();
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.DgvTicketsPeriodo.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag2 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(dataGridViewRow.Cells["Efectivo"].Value, 0, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Facturado"].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)));
					if (flag2)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Green;
						dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold);
						dataGridViewRow.DefaultCellStyle.ForeColor = Color.White;
					}
					bool flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(dataGridViewRow.Cells["Efectivo"].Value, 0, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Facturado"].Value, "No", false)), Operators.CompareObjectGreater(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)));
					if (flag3)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Black;
						dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold);
						dataGridViewRow.DefaultCellStyle.ForeColor = Color.White;
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
			this.DgvTicketsPeriodo.ClearSelection();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000D418 File Offset: 0x0000B618
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			this.MostrarTickets();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000D424 File Offset: 0x0000B624
		private void iniciaGridFolio()
		{
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 11;
			this.dgvNotas.Columns[0].Name = "id_nota";
			this.dgvNotas.Columns[0].Visible = false;
			this.dgvNotas.Columns[1].Name = "Mov.";
			this.dgvNotas.Columns[1].Width = 60;
			this.dgvNotas.Columns[1].ReadOnly = true;
			this.dgvNotas.Columns[2].Name = "Cantidad";
			this.dgvNotas.Columns[2].Width = 100;
			this.dgvNotas.Columns[2].ReadOnly = false;
			this.dgvNotas.Columns[3].Name = "Clave";
			this.dgvNotas.Columns[3].Width = 60;
			this.dgvNotas.Columns[3].Visible = false;
			this.dgvNotas.Columns[4].Name = "Descripcion";
			this.dgvNotas.Columns[4].Width = 200;
			this.dgvNotas.Columns[4].ReadOnly = true;
			this.dgvNotas.Columns[5].Name = "Desc. %";
			this.dgvNotas.Columns[5].Width = 70;
			this.dgvNotas.Columns[5].ReadOnly = false;
			this.dgvNotas.Columns[6].Name = "Impuesto";
			this.dgvNotas.Columns[6].Width = 80;
			this.dgvNotas.Columns[6].ReadOnly = true;
			this.dgvNotas.Columns[7].Name = "Precio";
			this.dgvNotas.Columns[7].Width = 80;
			this.dgvNotas.Columns[7].ReadOnly = false;
			this.dgvNotas.Columns[8].Name = "Importe";
			this.dgvNotas.Columns[8].Width = 80;
			this.dgvNotas.Columns[8].ReadOnly = true;
			this.dgvNotas.Columns[9].Name = "PrecioSinImpuestos";
			this.dgvNotas.Columns[9].Width = 80;
			this.dgvNotas.Columns[9].ReadOnly = true;
			this.dgvNotas.Columns[9].Visible = true;
			this.dgvNotas.Columns[10].Name = "Importe Sin Impuestos";
			this.dgvNotas.Columns[10].Width = 80;
			this.dgvNotas.Columns[10].ReadOnly = true;
			this.dgvNotas.Columns[10].Visible = true;
			dataGridViewButtonColumn.Width = 60;
			dataGridViewButtonColumn.Name = "Eliminar";
			this.dgvNotas.Columns.Add(dataGridViewButtonColumn);
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000036D5 File Offset: 0x000018D5
		private void DgvTicketsPeriodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000D800 File Offset: 0x0000BA00
		private void DgvTicketsPeriodo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			try
			{
				this.txtSerie.Text = Conversions.ToString(this.DgvTicketsPeriodo.Rows[rowIndex].Cells["Serie"].Value);
				this.txtBuscarFolio.Text = Conversions.ToString(this.DgvTicketsPeriodo.Rows[rowIndex].Cells["Folio"].Value);
				string left = Conversions.ToString(this.DgvTicketsPeriodo.Rows[rowIndex].Cells["Facturado"].Value);
				bool flag = Operators.CompareString(left, "Si", false) == 0;
				if (flag)
				{
					this.CheckBox_Facturado.Checked = true;
					this.lblFacturado.Text = "TICKET FACTURADO";
					this.lblFacturado.ForeColor = Color.Red;
				}
				bool flag2 = Operators.CompareString(left, "No", false) == 0;
				if (flag2)
				{
					this.CheckBox_Facturado.Checked = false;
					this.lblFacturado.Text = "TICKET SIN FACTURAR";
					this.lblFacturado.ForeColor = Color.Green;
				}
			}
			catch (Exception ex)
			{
			}
			this.MostrarReporteDetalleTickets();
			this.MostrarFormasDePago();
			bool @checked = this.CheckBox_Facturado.Checked;
			if (@checked)
			{
				this.dgvNotas.Enabled = false;
			}
			bool flag3 = !this.CheckBox_Facturado.Checked;
			if (flag3)
			{
				this.dgvNotas.Enabled = true;
			}
			this.DgvTicketsPeriodo.ClearSelection();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000D9C4 File Offset: 0x0000BBC4
		public void MostrarReporteDetalleTickets()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = string.Concat(new string[]
			{
				"select folio from cheques where seriefolio='",
				this.txtSerie.Text,
				"' and numcheque='",
				this.txtBuscarFolio.Text,
				"'"
			});
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					this.Foliodet = text;
					Tools.FolioRedBull = text;
				}
				sqlDataReader.Close();
				query = "select foliodet , movimiento , cantidad , a.idproducto , b.descripcion , a.descuento ,a.impuesto1 , a.precio  , a.preciosinimpuestos from cheqdet A \r\n                            INNER JOIN Productos B on b.idproducto = a.idproducto Where a.foliodet='" + this.Foliodet + "' order by a.movimiento asc";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool hasRows2 = sqlDataReader.HasRows;
				if (hasRows2)
				{
					this.iniciaGridFolio();
					while (sqlDataReader.Read())
					{
						string text2 = Conversions.ToString(sqlDataReader[0]);
						int num = Conversions.ToInteger(sqlDataReader[1]);
						int num2 = Conversions.ToInteger(sqlDataReader[2]);
						string text3 = Conversions.ToString(sqlDataReader[3]);
						string text4 = Conversions.ToString(sqlDataReader[4]);
						double num3 = Conversions.ToDouble(sqlDataReader[5]);
						double num4 = Conversions.ToDouble(sqlDataReader[6]);
						double num5 = Conversions.ToDouble(sqlDataReader[7]);
						double num6 = Conversions.ToDouble(sqlDataReader[8]);
						double a = (double)num2 * num5 - (double)num2 * num5 / 100.0 * num3;
						double num7 = (double)num2 * num6 - (double)num2 * num6 / 100.0 * num3;
						this.dgvNotas.Rows.Add(new object[]
						{
							text2,
							num,
							num2,
							text3,
							text4,
							num3.ToString("N2"),
							num4.ToString("N2"),
							Math.Round(num5).ToString("N2"),
							Math.Round(a).ToString("N2"),
							num6.ToString("N2"),
							num7.ToString("N2")
						});
					}
				}
				else
				{
					this.iniciaGridFolio();
				}
				sqlDataReader.Close();
				query = "SELECT SUM(PROPINA) FROM Cheques WHERE Folio='" + this.Foliodet + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool hasRows3 = sqlDataReader.HasRows;
				if (hasRows3)
				{
					while (sqlDataReader.Read())
					{
						double num8 = Conversions.ToDouble(sqlDataReader[0]);
						this.txtPropina.Text = num8.ToString("N2");
					}
				}
				sqlDataReader.Close();
				query = "SELECT ISNULL(Descuento,0) FROM Cheques WHERE Folio='" + this.Foliodet + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool hasRows4 = sqlDataReader.HasRows;
				double num9;
				if (hasRows4)
				{
					while (sqlDataReader.Read())
					{
						num9 = Conversions.ToDouble(sqlDataReader[0]);
						this.txtDescuento.Text = num9.ToString("N2");
					}
				}
				sqlDataReader.Close();
				query = "SELECT Top 1 hora FROM Cheqdet WHERE foliodet='" + this.Foliodet + "' ORDER BY hora desc ";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool hasRows5 = sqlDataReader.HasRows;
				if (hasRows5)
				{
					while (sqlDataReader.Read())
					{
						bool flag = sqlDataReader[0] == DBNull.Value;
						DateTime value;
						if (flag)
						{
							query = "SELECT Fecha FROM Cheques WHERE folio='" + this.Foliodet + "'";
							bool hasRows6 = sqlDataReader.HasRows;
							if (hasRows6)
							{
								while (sqlDataReader.Read())
								{
									value = Conversions.ToDate(sqlDataReader[0]);
									this.lblhoradelticket.Text = Conversions.ToString(value);
								}
							}
						}
						bool flag2 = sqlDataReader[0] != DBNull.Value;
						if (flag2)
						{
							value = Conversions.ToDate(sqlDataReader[0]);
							this.lblhoradelticket.Text = Conversions.ToString(value);
						}
						value = Conversions.ToDate(sqlDataReader[0]);
						this.lblhoradelticket.Text = Conversions.ToString(value);
					}
				}
				else
				{
					query = "SELECT Fecha FROM Cheques WHERE folio='" + this.Foliodet + "'";
					bool hasRows7 = sqlDataReader.HasRows;
					if (hasRows7)
					{
						while (sqlDataReader.Read())
						{
							DateTime value = Conversions.ToDate(sqlDataReader[0]);
							this.lblhoradelticket.Text = Conversions.ToString(value);
						}
					}
				}
				sqlDataReader.Close();
				query = "SELECT Top 1 idestacion FROM Cheqdet WHERE foliodet='" + this.Foliodet + "' ORDER BY hora desc ";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag3 = sqlDataReader.Read();
				if (flag3)
				{
					string text5 = Conversions.ToString(sqlDataReader[0]);
					this.lblestacionName.Text = text5.ToString();
				}
				sqlDataReader.Close();
				query = "SELECT Top 1 idmeseroproducto FROM Cheqdet WHERE foliodet='" + this.Foliodet + "' ORDER BY hora desc ";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag4 = sqlDataReader.Read();
				if (flag4)
				{
					bool flag5 = sqlDataReader[0] == DBNull.Value;
					if (flag5)
					{
						this.lblidmesero.Text = "NULL";
					}
					bool flag6 = sqlDataReader[0] != DBNull.Value;
					if (flag6)
					{
						string text6 = Conversions.ToString(sqlDataReader[0]);
						this.lblidmesero.Text = text6.ToString();
					}
				}
				sqlDataReader.Close();
				query = "SELECT idturno FROM Cheques WHERE folio='" + this.Foliodet + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag7 = sqlDataReader.Read();
				if (flag7)
				{
					bool flag8 = sqlDataReader[0] == DBNull.Value;
					if (flag8)
					{
						this.lblidturno.Text = "NULL";
					}
					bool flag9 = sqlDataReader[0] != DBNull.Value;
					if (flag9)
					{
						string text7 = Conversions.ToString(sqlDataReader[0]);
						this.lblidturno.Text = text7.ToString();
					}
				}
				sqlDataReader.Close();
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						double num10 = Conversions.ToDouble(Operators.AddObject(num10, dataGridViewRow.Cells["Importe"].Value));
						string text8 = Conversions.ToString(dataGridViewRow.Cells["Impuesto"].Value);
						double num11 = Conversions.ToDouble(Operators.AddObject(num11, dataGridViewRow.Cells["Importe Sin Impuestos"].Value));
						double a2 = num10 - num10 / 100.0 * num9;
						double num12 = num11 - num11 / 100.0 * num9;
						this.txtTotal.Text = Math.Round(a2).ToString("N2");
						this.txtSubtotal.Text = num12.ToString("N2");
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
				this.dgvNotas.ClearSelection();
			}
			else
			{
				Interaction.MsgBox("El Folio no existe, intenta de nuevo!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000E15C File Offset: 0x0000C35C
		private void Button4_Click(object sender, EventArgs e)
		{
			this.MostrarReporteDetalleTickets();
			this.MostrarFormasDePago();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000E170 File Offset: 0x0000C370
		private void dgvNotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			bool flag = e.ColumnIndex == 2;
			if (flag)
			{
				e.CellStyle.BackColor = SystemColors.Info;
			}
			bool flag2 = e.ColumnIndex == 5;
			if (flag2)
			{
				e.CellStyle.BackColor = SystemColors.Info;
			}
			bool flag3 = e.ColumnIndex == 7;
			if (flag3)
			{
				e.CellStyle.BackColor = SystemColors.Info;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = Conversions.ToDouble(this.txtDescuento.Text);
			int num4 = 1;
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 11;
			if (flag)
			{
				int index = this.dgvNotas.CurrentRow.Index;
				this.dgvNotas.Rows.Remove(this.dgvNotas.Rows[index]);
			}
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["Mov."].Value = num4;
						num4++;
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
			try
			{
				foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					num = Conversions.ToDouble(Operators.AddObject(num, dataGridViewRow2.Cells["Importe"].Value));
					double num5 = Conversions.ToDouble(dataGridViewRow2.Cells["Impuesto"].Value);
					num2 = Conversions.ToDouble(Operators.AddObject(num2, dataGridViewRow2.Cells["Importe Sin Impuestos"].Value));
					double a = num - num / 100.0 * num3;
					double num6 = num2 - num2 / 100.0 * num3;
					this.txtTotal.Text = Math.Round(a).ToString("N2");
					this.txtSubtotal.Text = num6.ToString("N2");
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
			bool flag2 = this.dgvNotas.Rows.Count == 0;
			if (flag2)
			{
				this.txtTotal.Text = "0.00";
				this.txtSubtotal.Text = "0.00";
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000E45C File Offset: 0x0000C65C
		private void btnAddMovto_Click(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = true;
			this.MostrarProductosAsignar();
			this.txtBuscarProducto.Text = "";
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000E484 File Offset: 0x0000C684
		public void MostrarProductosAsignar()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select a.idproducto , a.descripcion , b.preciosinimpuestos , b.impuesto1 , b.precio from productos A \r\n                    Inner Join productosdetalle B on b.idproducto = a.idproducto order by a.descripcion asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.iniciaGridProductos();
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					double a = Conversions.ToDouble(sqlDataReader[4]);
					this.dgwProductos.Rows.Add(new object[]
					{
						text,
						text2,
						num.ToString("N2"),
						num2.ToString("N2"),
						Math.Round(a).ToString("N2")
					});
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000E57C File Offset: 0x0000C77C
		private void iniciaGridProductos()
		{
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			this.dgwProductos.Rows.Clear();
			this.dgwProductos.ColumnCount = 5;
			this.dgwProductos.Columns[0].Name = "Clave";
			this.dgwProductos.Columns[0].Width = 60;
			this.dgwProductos.Columns[1].Name = "Descripcion";
			this.dgwProductos.Columns[1].Width = 200;
			this.dgwProductos.Columns[2].Name = "Precio S/Impuesto";
			this.dgwProductos.Columns[2].Width = 100;
			this.dgwProductos.Columns[3].Name = "Impuesto";
			this.dgwProductos.Columns[3].Width = 100;
			this.dgwProductos.Columns[4].Name = "Precio";
			this.dgwProductos.Columns[4].Width = 100;
			this.DoubleBufferedASD(this.dgwProductos, true);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public void MostrarProductosAsignarBuscar()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select a.idproducto , a.descripcion , b.preciosinimpuestos , b.impuesto1 , b.precio from productos A \r\n                    Inner Join productosdetalle B on b.idproducto = a.idproducto where a.descripcion like '%" + this.txtBuscarProducto.Text + "%' order by a.descripcion asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.iniciaGridProductos();
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					double num3 = Conversions.ToDouble(sqlDataReader[4]);
					this.dgwProductos.Rows.Add(new object[]
					{
						text,
						text2,
						num.ToString("N2"),
						num2.ToString("N2"),
						num3.ToString("N2")
					});
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000E7CA File Offset: 0x0000C9CA
		private void txtBuscarProducto_TextChanged_1(object sender, EventArgs e)
		{
			this.MostrarProductosAsignarBuscar();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		private void PictureBox4_Click(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = false;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000E7E4 File Offset: 0x0000C9E4
		private void dgwProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int num = 1;
			int rowIndex = e.RowIndex;
			int num2 = 1;
			double num3 = Conversions.ToDouble(this.txtDescuento.Text);
			try
			{
				string text = Conversions.ToString(this.dgwProductos.Rows[rowIndex].Cells["Clave"].Value);
				string text2 = Conversions.ToString(this.dgwProductos.Rows[rowIndex].Cells["Descripcion"].Value);
				double num4 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Impuesto"].Value);
				double num5 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Precio"].Value);
				double num6 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Precio S/Impuesto"].Value);
				double num7 = (double)num2 * num5;
				double num8 = (double)num2 * num6;
				this.dgvNotas.Rows.Add(new object[]
				{
					this.Foliodet,
					"",
					"1",
					text,
					text2,
					"0.00",
					num4,
					num5.ToString("N2"),
					num7.ToString("N2"),
					num6.ToString("N2"),
					num8.ToString("N2")
				});
			}
			catch (Exception ex)
			{
			}
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["Mov."].Value = num;
						num++;
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
				num = 0;
			}
			try
			{
				foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					double num9 = Conversions.ToDouble(Operators.AddObject(num9, dataGridViewRow2.Cells["Importe"].Value));
					double num10 = Conversions.ToDouble(dataGridViewRow2.Cells["Impuesto"].Value);
					double num11 = Conversions.ToDouble(Operators.AddObject(num11, dataGridViewRow2.Cells["Importe Sin Impuestos"].Value));
					double a = num9 - num9 / 100.0 * num3;
					double num12 = num11 - num11 / 100.0 * num3;
					this.txtTotal.Text = Math.Round(a).ToString("N2");
					this.txtSubtotal.Text = num12.ToString("N2");
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
			bool flag = this.dgvNotas.Rows.Count == 0;
			if (flag)
			{
				this.txtTotal.Text = "0.00";
				this.txtSubtotal.Text = "0.00";
			}
			this.PanelBuscarProducto.Visible = false;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		private void iniciaGridFiormasPago()
		{
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			this.DgvFormasPago.Rows.Clear();
			this.DgvFormasPago.ColumnCount = 4;
			this.DgvFormasPago.Columns[0].Name = "Clave";
			this.DgvFormasPago.Columns[0].Width = 60;
			this.DgvFormasPago.Columns[1].Name = "Descripcion";
			this.DgvFormasPago.Columns[1].Width = 200;
			this.DgvFormasPago.Columns[2].Name = "Importe";
			this.DgvFormasPago.Columns[2].Width = 100;
			this.DgvFormasPago.Columns[3].Name = "Propina";
			this.DgvFormasPago.Columns[3].Width = 100;
			dataGridViewButtonColumn.Width = 90;
			dataGridViewButtonColumn.Name = "Seleccionar...";
			dataGridViewButtonColumn.Visible = false;
			dataGridViewButtonColumn2.Width = 90;
			dataGridViewButtonColumn2.Name = "Eliminar Propina";
			dataGridViewButtonColumn2.Visible = false;
			this.DgvFormasPago.Columns.Add(dataGridViewButtonColumn);
			this.DgvFormasPago.Columns.Add(dataGridViewButtonColumn2);
			this.DoubleBufferedASD(this.DgvFormasPago, true);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000ED38 File Offset: 0x0000CF38
		public void MostrarFormasDePago()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select a.idformadepago ,b.descripcion , a.importe , a.propina  from chequespagos A \r\n                    Inner Join formasdepago B on b.idformadepago = a.idformadepago where folio='" + this.Foliodet + "'";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.iniciaGridFiormasPago();
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double a = Conversions.ToDouble(sqlDataReader[2]);
					double num = Conversions.ToDouble(sqlDataReader[3]);
					this.DgvFormasPago.Rows.Add(new object[]
					{
						text,
						text2,
						Math.Round(a).ToString("N2"),
						num.ToString("N2")
					});
				}
			}
			else
			{
				this.iniciaGridFiormasPago();
			}
			sqlDataReader.Close();
			try
			{
				this.DgvFormasPago.Rows[0].Selected = true;
				int index = this.DgvFormasPago.CurrentRow.Index;
				Tools.NumeroFilaFormasDePago = this.DgvFormasPago.CurrentRow.Index;
				this.lblNumeroFilaFormaPago.Text = Conversions.ToString(index);
			}
			catch (Exception ex)
			{
			}
			this.DgvFormasPago.ClearSelection();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		private void DgvFormasPago_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 4;
			if (flag)
			{
				int index = this.DgvFormasPago.CurrentRow.Index;
				Tools.NumeroFilaFormasDePago = this.DgvFormasPago.CurrentRow.Index;
				this.lblNumeroFilaFormaPago.Text = Conversions.ToString(index);
			}
			bool flag2 = e.RowIndex >= 0 && e.ColumnIndex == 5;
			if (flag2)
			{
				this.DgvFormasPago.Rows[rowIndex].Cells[3].Value = "0.00";
				this.txtPropina.Text = "0.00";
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000EF6C File Offset: 0x0000D16C
		private void Button2_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtBuscarFolio.Text;
			string text2 = this.txtSerie.Text;
			Tools.Consumo = Conversions.ToDouble(this.txtTotal.Text);
			Tools.DescuentoMia_Renta = Conversions.ToDouble(this.txtDescuento.Text);
			Tools.SerieDelTicketLG = this.txtSerie.Text;
			Tools.NumchequeDelticketLG = this.txtBuscarFolio.Text;
			MyProject.Forms.FormListadoFormasDePago.ShowDialog();
			DateTime dateTime = Conversions.ToDate(this.lblhoradelticket.Text);
			string text3 = this.lblestacionName.Text;
			string text4 = this.lblidmesero.Text;
			string text5 = this.lblidturno.Text;
			double num = Conversions.ToDouble(this.txtDescuento.Text);
			bool flag = Tools.ActualizaFormaPagoCuentas == 1;
			if (flag)
			{
				this.MostrarFormasDePago();
				string query = "SELECT Propina FROM cheques WHERE folio='" + this.Foliodet + "'";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag2 = sqlDataReader.Read();
				if (flag2)
				{
					double num2 = Conversions.ToDouble(sqlDataReader[0]);
					bool flag3 = num2 != 0.0;
					if (flag3)
					{
						query = "SELECT TOP 1 Folio From MovtosCaja WHERE idturno='" + this.lblidturno.Text + "'";
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
						bool flag4 = sqlDataReader.Read();
						if (flag4)
						{
							string text6 = Conversions.ToString(sqlDataReader[0]);
							query = string.Concat(new string[]
							{
								"Update movtoscaja Set importe = importe + (Select propina from cheques where numcheque ='",
								Tools.NumchequeDelticketLG.ToString(),
								"' and  seriefolio = '",
								Tools.SerieDelTicketLG,
								"') where folio=  '",
								text6,
								"'"
							});
							sqlQuery.execQuery(query);
						}
					}
				}
				sqlDataReader.Close();
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						string text7 = Conversions.ToString(dataGridViewRow.Cells["Mov."].Value);
						string text8 = Conversions.ToString(dataGridViewRow.Cells["Cantidad"].Value);
						string text9 = Conversions.ToString(dataGridViewRow.Cells["Clave"].Value);
						double num3 = Conversions.ToDouble(dataGridViewRow.Cells["Desc. %"].Value);
						double num4 = Conversions.ToDouble(dataGridViewRow.Cells["Precio"].Value);
						double num5 = Conversions.ToDouble(dataGridViewRow.Cells["Impuesto"].Value);
						double num6 = Conversions.ToDouble(dataGridViewRow.Cells["PrecioSinImpuestos"].Value);
						query = string.Concat(new string[]
						{
							"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                Cantidad,\r\n                                idproducto,\r\n                                Descuento,\r\n                                Precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idEstacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                idmovtobillar,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount)\r\n\r\n\r\n                                Values(\r\n                                '",
							this.Foliodet.ToString(),
							"',\r\n                                '",
							text7,
							"',\r\n                                '',\r\n                                '",
							text8,
							"',\r\n                                '",
							text9.ToString(),
							"',\r\n                                '",
							num3.ToString(),
							"',\r\n                                '",
							num4.ToString("N2"),
							"',\r\n                                '",
							num5.ToString("N2"),
							"',\r\n                                '0.00',\r\n                                '0.00',\r\n                                '",
							num6.ToString("N2"),
							"',\r\n                                '',\r\n                                '",
							dateTime.ToString(Tools.strFormatoFechaLargo),
							"',\r\n                                '0',\r\n                                '0',\r\n                                '',\r\n                                '",
							text3.ToString(),
							"',\r\n                                '',\r\n                                '',\r\n                                '',\r\n                                NULL,\r\n                                   '',\r\n                                '0',\r\n                                '",
							num4.ToString("N2"),
							"',\r\n                                '0',\r\n                                '",
							text4.ToString(),
							"',\r\n                                NULL,\r\n                                '0',\r\n                                '',\r\n                                '',\r\n                                '0',\r\n                                NULL,\r\n                                NULL,\r\n                                NULL,\r\n                                '1',\r\n                                '",
							text5.ToString(),
							"',\r\n                                '1',\r\n                                '0',\r\n                                '-1',\r\n                                '-1',\r\n                                '-1.00000',\r\n                                '-1.00000',\r\n                                NULL,\r\n                                NULL,\r\n                                '0',\r\n                                '0.00',\r\n                                '',\r\n                                '',\r\n                                '0.00')"
						});
						sqlQuery.execQuery(query);
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
				bool flag5 = num == 100.0;
				if (flag5)
				{
					query = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + this.Foliodet + "'";
					sqlQuery.execQuery(query);
					query = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + this.Foliodet + "' ";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							double num10 = num7 * num9 / 100.0 * num;
							query = string.Concat(new string[]
							{
								"UPDATE Cheques set DescuentoImporte = DescuentoImporte + '",
								num10.ToString("N2"),
								"'  , totaldescuentoycortesia = totaldescuentoycortesia + '",
								num10.ToString("N2"),
								"' Where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=1";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows2 = sqlDataReader.HasRows;
					if (hasRows2)
					{
						while (sqlDataReader.Read())
						{
							double num11 = Conversions.ToDouble(sqlDataReader[0]);
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalbebidassindescuentos='",
								num11.ToString("N2"),
								"' , totalsindescuento = totalsindescuento + '",
								num11.ToString("N2"),
								"' , subtotal= subtotal + '",
								num11.ToString("N2"),
								"' where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=2";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows3 = sqlDataReader.HasRows;
					if (hasRows3)
					{
						while (sqlDataReader.Read())
						{
							double num12 = Conversions.ToDouble(sqlDataReader[0]);
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalalimentossindescuentos='",
								num12.ToString("N2"),
								"' , totalsindescuento= totalsindescuento + '",
								num12.ToString("N2"),
								"' , subtotal= subtotal + '",
								num12.ToString("N2"),
								"' where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=3";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows4 = sqlDataReader.HasRows;
					if (hasRows4)
					{
						while (sqlDataReader.Read())
						{
							double num13 = Conversions.ToDouble(sqlDataReader[0]);
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalotrossindescuentos='",
								num13.ToString("N2"),
								"' ,totalsindescuento= totalsindescuento +'",
								num13.ToString("N2"),
								"' , subtotal= subtotal + '",
								num13.ToString("N2"),
								"'  where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
					}
					sqlDataReader.Close();
				}
				bool flag6 = num >= 0.0 & num < 100.0;
				if (flag6)
				{
					query = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + this.Foliodet + "'";
					sqlQuery.execQuery(query);
					query = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + this.Foliodet + "' and descuento > 0 ";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows5 = sqlDataReader.HasRows;
					if (hasRows5)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							query = string.Concat(new string[]
							{
								"Update Cheques set  totaldescuentoycortesia= totaldescuentoycortesia +'",
								(num7 * num9 / 100.0 * num8).ToString("N2"),
								"'  where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=1";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows6 = sqlDataReader.HasRows;
					if (hasRows6)
					{
						while (sqlDataReader.Read())
						{
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalbebidassindescuentos= totalbebidassindescuentos +'",
								Conversions.ToDouble(sqlDataReader[0]).ToString("N2"),
								"' where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=1";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows7 = sqlDataReader.HasRows;
					if (hasRows7)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							double num14 = Conversions.ToDouble((num7 * num9 - num7 * num9 / 100.0 * num8).ToString("n2"));
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalbebidas= totalbebidas +'",
								num14.ToString("N2"),
								"' ,subtotal= subtotal + '",
								num14.ToString("N2"),
								"' , subtotalcondescuento = subtotalcondescuento +  '",
								num14.ToString("N2"),
								"' , TotalSinDescuento=TotalSinDescuento + '",
								num14.ToString("N2"),
								"'    where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=2";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows8 = sqlDataReader.HasRows;
					if (hasRows8)
					{
						while (sqlDataReader.Read())
						{
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalalimentossindescuentos= totalalimentossindescuentos+ '",
								Conversions.ToDouble(sqlDataReader[0]).ToString("N2"),
								"' where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=2";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows9 = sqlDataReader.HasRows;
					if (hasRows9)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							double num15 = Conversions.ToDouble((num7 * num9 - num7 * num9 / 100.0 * num8).ToString("n2"));
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalalimentos= totalalimentos + '",
								num15.ToString("N2"),
								"' , subtotal= subtotal + '",
								num15.ToString("N2"),
								"' , subtotalcondescuento = subtotalcondescuento +  '",
								num15.ToString("N2"),
								"' ,  TotalSinDescuento=TotalSinDescuento + '",
								num15.ToString("N2"),
								"'  where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=3";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows10 = sqlDataReader.HasRows;
					if (hasRows10)
					{
						while (sqlDataReader.Read())
						{
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalotrossindescuentos='",
								Conversions.ToDouble(sqlDataReader[0]).ToString("N2"),
								"' where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
						sqlDataReader.Close();
					}
					query = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=3";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows11 = sqlDataReader.HasRows;
					if (hasRows11)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							double num16 = Conversions.ToDouble((num7 * num9 - num7 * num9 / 100.0 * num8).ToString("n2"));
							query = string.Concat(new string[]
							{
								"Update Cheques set  totalotros= totalotros +'",
								num16.ToString("N2"),
								"' ,  subtotal= subtotal + '",
								num16.ToString("N2"),
								"' , subtotalcondescuento = subtotalcondescuento +  '",
								num16.ToString("N2"),
								"' , TotalSinDescuento=TotalSinDescuento + '",
								num16.ToString("N2"),
								"'   where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
					}
				}
				bool flag7 = num > 0.0 & num < 100.0;
				if (flag7)
				{
					query = "Select Subtotal from Cheques where folio='" + this.Foliodet + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool flag8 = sqlDataReader.Read();
					if (flag8)
					{
						double num17 = Conversions.ToDouble(sqlDataReader[0]);
						num17 = num17 / 100.0 * num;
						double num18 = Conversions.ToDouble(sqlDataReader[0]);
						query = string.Concat(new string[]
						{
							"Update Cheques set  subtotalcondescuento ='",
							(num18 - num18 / 100.0 * num).ToString("N2"),
							"' , DescuentoImporte = DescuentoImporte + '",
							num17.ToString("N2"),
							"' ,totaldescuentos = totaldescuentos + '",
							num17.ToString("N2"),
							"' , totaldescuentoycortesia = totaldescuentoycortesia + '",
							num17.ToString("N2"),
							"'  where Folio = '",
							this.Foliodet,
							"' "
						});
						sqlQuery.execQuery(query);
					}
					sqlDataReader.Close();
					query = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=1";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows12 = sqlDataReader.HasRows;
					if (hasRows12)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							double num19 = num7 * num9 / 100.0 * num8;
							double num14 = num7 * num9 - num7 * num9 / 100.0 * num8;
							query = string.Concat(new string[]
							{
								"Update Cheques set  totaldescuentobebidas= totaldescuentobebidas +'",
								Conversions.ToDouble((num14 - num14 / 100.0 * num).ToString("n2")).ToString("N2"),
								"' where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
					}
					query = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=2";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows13 = sqlDataReader.HasRows;
					if (hasRows13)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							double num19 = num7 * num9 / 100.0 * num8;
							double num15 = num7 * num9 - num7 * num9 / 100.0 * num8;
							query = string.Concat(new string[]
							{
								"Update Cheques set  totaldescuentoalimentos= totaldescuentoalimentos +'",
								Conversions.ToDouble((num15 - num15 / 100.0 * num).ToString("n2")).ToString("N2"),
								"'  where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
					}
					query = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + this.Foliodet + "' and d.clasificacionventa=3";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
					bool hasRows14 = sqlDataReader.HasRows;
					if (hasRows14)
					{
						while (sqlDataReader.Read())
						{
							double num7 = Conversions.ToDouble(sqlDataReader[0]);
							double num8 = Conversions.ToDouble(sqlDataReader[1]);
							double num9 = Conversions.ToDouble(sqlDataReader[2]);
							double num19 = num7 * num9 / 100.0 * num8;
							double num16 = num7 * num9 - num7 * num9 / 100.0 * num8;
							query = string.Concat(new string[]
							{
								"Update Cheques set  totaldescuentootros= totaldescuentootros +'",
								Conversions.ToDouble((num16 - num16 / 100.0 * num).ToString("n2")).ToString("N2"),
								"' where folio='",
								this.Foliodet,
								"'"
							});
							sqlQuery.execQuery(query);
						}
					}
				}
				query = "select ISNULL(sum(preciosinimpuestos*cantidad/100 *impuesto1),0) from cheqdet where foliodet = '" + this.Foliodet + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag9 = sqlDataReader.Read();
				if (flag9)
				{
					double num20 = Conversions.ToDouble(sqlDataReader[0]);
					num20 -= num20 / 100.0 * num;
				}
				query = "select ISNULL(sum(precio*cantidad-(preciosinimpuestos*cantidad/100*impuesto1)),0) from cheqdet where foliodet = '" + this.Foliodet + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag10 = sqlDataReader.Read();
				if (flag10)
				{
					double num21 = Conversions.ToDouble(sqlDataReader[0]);
					num21 -= num21 / 100.0 * num;
				}
				double num22 = Conversions.ToDouble(this.txtTotal.Text);
				query = string.Concat(new string[]
				{
					"Update cheques Set total = '",
					num22.ToString("N2"),
					"'  , totalconpropina = '",
					num22.ToString("N2"),
					"' , TotalConCargo='",
					num22.ToString("N2"),
					"' ,  TotalConPropinaCargo='",
					num22.ToString("N2"),
					"'    where folio = '",
					this.Foliodet,
					"'"
				});
				sqlQuery.execQuery(query);
				string text10 = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
				string text11 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
				List<string> list = new List<string>();
				query = "select distinct (idturno) from Cheques  where folio ='" + this.Foliodet + "' and cierre is not  null";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool hasRows15 = sqlDataReader.HasRows;
				if (hasRows15)
				{
					while (sqlDataReader.Read())
					{
						list.Add(Conversions.ToString(sqlDataReader[0]));
					}
					sqlDataReader.Close();
				}
				try
				{
					foreach (string text12 in list)
					{
						query = "Select ISNULL(sum(importe),0) from movtoscaja Where idturno = '" + text12 + "' And  pagodepropina = 1";
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
						sqlDataReader.Read();
						double num23 = Conversions.ToDouble(sqlDataReader[0]);
						sqlDataReader.Close();
						query = string.Concat(new string[]
						{
							"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
							Tools.id_Empresa,
							"' and  idturno = '",
							text12,
							"'"
						});
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
						sqlDataReader.Read();
						double num24 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader[0], num23));
						double num25 = Conversions.ToDouble(sqlDataReader[1]);
						double num26 = Conversions.ToDouble(sqlDataReader[2]);
						double num27 = Conversions.ToDouble(sqlDataReader[3]);
						double num28 = num24;
						query = string.Concat(new string[]
						{
							"Update turnos Set efectivo='",
							num28.ToString("N2"),
							"',tarjeta='",
							num25.ToString("N2"),
							"',vales='",
							num26.ToString("N2"),
							"', credito='",
							num27.ToString("N2"),
							"' Where idturno = '",
							text12,
							"'"
						});
						sqlQuery.execQuery(query);
						this.MostrarReporteDetalleTickets();
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00010610 File Offset: 0x0000E810
		private void txtDescuento_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtDescuento.Text, "", false) == 0;
			if (flag)
			{
				this.txtDescuento.Text = "0.00";
			}
			bool flag2 = Operators.CompareString(this.txtDescuento.Text, "", false) != 0;
			if (flag2)
			{
				double num = Conversions.ToDouble(this.txtDescuento.Text);
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						double num2 = Conversions.ToDouble(Operators.AddObject(num2, dataGridViewRow.Cells["Importe"].Value));
						double num3 = Conversions.ToDouble(dataGridViewRow.Cells["Impuesto"].Value);
						double num4 = Conversions.ToDouble(Operators.AddObject(num4, dataGridViewRow.Cells["Importe Sin Impuestos"].Value));
						double a = num2 - num2 / 100.0 * num;
						double num5 = num4 - num4 / 100.0 * num;
						this.txtTotal.Text = Math.Round(a).ToString("N2");
						this.txtSubtotal.Text = num5.ToString("N2");
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
				bool flag3 = this.dgvNotas.Rows.Count == 0;
				if (flag3)
				{
					this.txtTotal.Text = "0.00";
					this.txtSubtotal.Text = "0.00";
				}
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000E15C File Offset: 0x0000C35C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.MostrarReporteDetalleTickets();
			this.MostrarFormasDePago();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000107F4 File Offset: 0x0000E9F4
		private void dgvNotas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = Operators.CompareString(this.dgvNotas.Columns[e.ColumnIndex].Name, "Cantidad", false) == 0;
			if (flag)
			{
				bool flag2 = string.IsNullOrEmpty(e.FormattedValue.ToString());
				if (flag2)
				{
					Interaction.MsgBox("La cantidad no puede quedar vacia!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag3 = Operators.CompareString(this.dgvNotas.Columns[e.ColumnIndex].Name, "Desc. %", false) == 0;
			if (flag3)
			{
				bool flag4 = string.IsNullOrEmpty(e.FormattedValue.ToString());
				if (flag4)
				{
					Interaction.MsgBox("El descuento no puede quedar vacio!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag5 = Operators.CompareString(this.dgvNotas.Columns[e.ColumnIndex].Name, "Precio", false) == 0;
			if (flag5)
			{
				bool flag6 = string.IsNullOrEmpty(e.FormattedValue.ToString());
				if (flag6)
				{
					Interaction.MsgBox("El precio no puede quedar vacio!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag7 = e.ColumnIndex == 2;
			if (flag7)
			{
				bool flag8 = !Versioned.IsNumeric(e.FormattedValue.ToString());
				if (flag8)
				{
					MessageBox.Show("Valor invalido columna : Cantidad - Ingresa un valor numerico!");
					this.dgvNotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag9 = e.ColumnIndex == 2;
			if (flag9)
			{
				bool flag10 = Operators.ConditionalCompareObjectLessEqual(e.FormattedValue, 0, false);
				if (flag10)
				{
					Interaction.MsgBox("Valor invalido columna : Cantidad - Ingresa un valor igual o  mayor a 1!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
			}
			bool flag11 = e.ColumnIndex == 5;
			if (flag11)
			{
				bool flag12 = !Versioned.IsNumeric(e.FormattedValue.ToString());
				if (flag12)
				{
					MessageBox.Show("Valor invalido columna : Desc %. - Ingresa un valor numerico!");
					this.dgvNotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag13 = e.ColumnIndex == 5;
			if (flag13)
			{
				bool flag14 = Operators.ConditionalCompareObjectLess(e.FormattedValue, 0, false);
				if (flag14)
				{
					Interaction.MsgBox("Valor invalido columna : Desc %. - Ingresa un valor igual o  mayor a 0!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
					return;
				}
			}
			bool flag15 = e.ColumnIndex == 7;
			if (flag15)
			{
				bool flag16 = !Versioned.IsNumeric(e.FormattedValue.ToString());
				if (flag16)
				{
					MessageBox.Show("Valor invalido columna : Precio - Ingresa un valor numerico!");
					this.dgvNotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
					e.Cancel = true;
					return;
				}
				e.Cancel = false;
			}
			bool flag17 = e.ColumnIndex == 7;
			if (flag17)
			{
				bool flag18 = Operators.ConditionalCompareObjectLess(e.FormattedValue, 0, false);
				if (flag18)
				{
					Interaction.MsgBox("Valor invalido columna : Precio - Ingresa un valor igual o  mayor a 0!", MsgBoxStyle.OkOnly, null);
					e.Cancel = true;
				}
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00010B7C File Offset: 0x0000ED7C
		private void dgvNotas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			double num6 = Conversions.ToDouble(this.txtDescuento.Text);
			try
			{
				bool flag = this.dgvNotas[2, e.RowIndex].Value != null;
				if (flag)
				{
					num = Conversions.ToDouble(this.dgvNotas[2, e.RowIndex].Value);
				}
			}
			catch (Exception ex)
			{
				return;
			}
			try
			{
				bool flag2 = this.dgvNotas[7, e.RowIndex].Value != null;
				if (flag2)
				{
					num2 = Conversions.ToDouble(this.dgvNotas[7, e.RowIndex].Value);
				}
			}
			catch (Exception ex2)
			{
				return;
			}
			try
			{
				bool flag3 = this.dgvNotas[5, e.RowIndex].Value != null;
				if (flag3)
				{
					num3 = Conversions.ToDouble(this.dgvNotas[5, e.RowIndex].Value);
				}
			}
			catch (Exception ex3)
			{
				return;
			}
			try
			{
				bool flag4 = this.dgvNotas[6, e.RowIndex].Value != null;
				if (flag4)
				{
					num4 = Conversions.ToDouble(this.dgvNotas[6, e.RowIndex].Value);
				}
			}
			catch (Exception ex4)
			{
				return;
			}
			try
			{
				bool flag5 = this.dgvNotas[9, e.RowIndex].Value != null;
				if (flag5)
				{
					num5 = Conversions.ToDouble(this.dgvNotas[9, e.RowIndex].Value);
				}
			}
			catch (Exception ex5)
			{
				return;
			}
			double num7 = Conversions.ToDouble(("1." + num4.ToString()) ?? "");
			double num8 = num2 / num7;
			this.dgvNotas[9, e.RowIndex].Value = num8.ToString("N2");
			try
			{
				bool flag6 = this.dgvNotas[9, e.RowIndex].Value != null;
				if (flag6)
				{
					num5 = Conversions.ToDouble(this.dgvNotas[9, e.RowIndex].Value);
				}
			}
			catch (Exception ex6)
			{
				return;
			}
			double a = num * num2 - num * num2 / 100.0 * num3;
			double num9 = num * num5 - num * num5 / 100.0 * num3;
			double num10 = Conversions.ToDouble(Math.Round(a).ToString("N2"));
			double num11 = Conversions.ToDouble(num9.ToString("N2"));
			this.dgvNotas[8, e.RowIndex].Value = num10.ToString("N2");
			this.dgvNotas[10, e.RowIndex].Value = num11.ToString("N2");
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					double num12 = Conversions.ToDouble(Operators.AddObject(num12, dataGridViewRow.Cells["Importe"].Value));
					double num13 = Conversions.ToDouble(dataGridViewRow.Cells["Impuesto"].Value);
					double num14 = Conversions.ToDouble(Operators.AddObject(num14, dataGridViewRow.Cells["Importe Sin Impuestos"].Value));
					double a2 = num12 - num12 / 100.0 * num6;
					double num15 = num14 - num14 / 100.0 * num6;
					this.txtTotal.Text = Math.Round(a2).ToString("N2");
					this.txtSubtotal.Text = num15.ToString("N2");
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
			bool flag7 = this.dgvNotas.Rows.Count == 0;
			if (flag7)
			{
				this.txtTotal.Text = "0.00";
				this.txtSubtotal.Text = "0.00";
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgwProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04000082 RID: 130
		private string Foliodet;
	}
}
