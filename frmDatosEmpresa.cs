using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class frmDatosEmpresa : Form
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0001A378 File Offset: 0x00018578
		public frmDatosEmpresa()
		{
			base.Load += this.frmDatosEmpresa_Load;
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0001CBB2 File Offset: 0x0001ADB2
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0001CBBB File Offset: 0x0001ADBB
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0001CBC8 File Offset: 0x0001ADC8
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001CC0B File Offset: 0x0001AE0B
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0001CC15 File Offset: 0x0001AE15
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0001CC1E File Offset: 0x0001AE1E
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0001CC28 File Offset: 0x0001AE28
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001CC31 File Offset: 0x0001AE31
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0001CC3C File Offset: 0x0001AE3C
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0001CC7F File Offset: 0x0001AE7F
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0001CC89 File Offset: 0x0001AE89
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0001CC92 File Offset: 0x0001AE92
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0001CC9C File Offset: 0x0001AE9C
		internal virtual CheckBox CheckBoxLeyenda2
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxLeyenda2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxLeyenda2_CheckedChanged);
				CheckBox checkBoxLeyenda = this._CheckBoxLeyenda2;
				if (checkBoxLeyenda != null)
				{
					checkBoxLeyenda.CheckedChanged -= value2;
				}
				this._CheckBoxLeyenda2 = value;
				checkBoxLeyenda = this._CheckBoxLeyenda2;
				if (checkBoxLeyenda != null)
				{
					checkBoxLeyenda.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0001CCDF File Offset: 0x0001AEDF
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0001CCEC File Offset: 0x0001AEEC
		internal virtual CheckBox CheckBoxLeyenda1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxLeyenda1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxLeyenda1_CheckedChanged);
				CheckBox checkBoxLeyenda = this._CheckBoxLeyenda1;
				if (checkBoxLeyenda != null)
				{
					checkBoxLeyenda.CheckedChanged -= value2;
				}
				this._CheckBoxLeyenda1 = value;
				checkBoxLeyenda = this._CheckBoxLeyenda1;
				if (checkBoxLeyenda != null)
				{
					checkBoxLeyenda.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0001CD2F File Offset: 0x0001AF2F
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0001CD3C File Offset: 0x0001AF3C
		internal virtual CheckBox CheckBoxEstadoSuc
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxEstadoSuc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxEstadoSuc_CheckedChanged);
				CheckBox checkBoxEstadoSuc = this._CheckBoxEstadoSuc;
				if (checkBoxEstadoSuc != null)
				{
					checkBoxEstadoSuc.CheckedChanged -= value2;
				}
				this._CheckBoxEstadoSuc = value;
				checkBoxEstadoSuc = this._CheckBoxEstadoSuc;
				if (checkBoxEstadoSuc != null)
				{
					checkBoxEstadoSuc.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0001CD7F File Offset: 0x0001AF7F
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0001CD8C File Offset: 0x0001AF8C
		internal virtual CheckBox CheckBoxCiudadSuc
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxCiudadSuc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxCiudadSuc_CheckedChanged);
				CheckBox checkBoxCiudadSuc = this._CheckBoxCiudadSuc;
				if (checkBoxCiudadSuc != null)
				{
					checkBoxCiudadSuc.CheckedChanged -= value2;
				}
				this._CheckBoxCiudadSuc = value;
				checkBoxCiudadSuc = this._CheckBoxCiudadSuc;
				if (checkBoxCiudadSuc != null)
				{
					checkBoxCiudadSuc.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0001CDCF File Offset: 0x0001AFCF
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0001CDDC File Offset: 0x0001AFDC
		internal virtual CheckBox CheckBoxCodigoPostalSuc
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxCodigoPostalSuc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxCodigoPostalSuc_CheckedChanged);
				CheckBox checkBoxCodigoPostalSuc = this._CheckBoxCodigoPostalSuc;
				if (checkBoxCodigoPostalSuc != null)
				{
					checkBoxCodigoPostalSuc.CheckedChanged -= value2;
				}
				this._CheckBoxCodigoPostalSuc = value;
				checkBoxCodigoPostalSuc = this._CheckBoxCodigoPostalSuc;
				if (checkBoxCodigoPostalSuc != null)
				{
					checkBoxCodigoPostalSuc.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0001CE1F File Offset: 0x0001B01F
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0001CE2C File Offset: 0x0001B02C
		internal virtual CheckBox CheckBoxDirSucursal
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxDirSucursal;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxDirSucursal_CheckedChanged);
				CheckBox checkBoxDirSucursal = this._CheckBoxDirSucursal;
				if (checkBoxDirSucursal != null)
				{
					checkBoxDirSucursal.CheckedChanged -= value2;
				}
				this._CheckBoxDirSucursal = value;
				checkBoxDirSucursal = this._CheckBoxDirSucursal;
				if (checkBoxDirSucursal != null)
				{
					checkBoxDirSucursal.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001CE6F File Offset: 0x0001B06F
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0001CE7C File Offset: 0x0001B07C
		internal virtual CheckBox CheckBoxTelefono
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxTelefono;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxTelefono_CheckedChanged);
				CheckBox checkBoxTelefono = this._CheckBoxTelefono;
				if (checkBoxTelefono != null)
				{
					checkBoxTelefono.CheckedChanged -= value2;
				}
				this._CheckBoxTelefono = value;
				checkBoxTelefono = this._CheckBoxTelefono;
				if (checkBoxTelefono != null)
				{
					checkBoxTelefono.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001CEBF File Offset: 0x0001B0BF
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0001CECC File Offset: 0x0001B0CC
		internal virtual CheckBox CheckBoxRFC
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxRFC;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxRFC_CheckedChanged);
				CheckBox checkBoxRFC = this._CheckBoxRFC;
				if (checkBoxRFC != null)
				{
					checkBoxRFC.CheckedChanged -= value2;
				}
				this._CheckBoxRFC = value;
				checkBoxRFC = this._CheckBoxRFC;
				if (checkBoxRFC != null)
				{
					checkBoxRFC.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001CF0F File Offset: 0x0001B10F
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0001CF1C File Offset: 0x0001B11C
		internal virtual CheckBox CheckBoxEstado
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxEstado;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxEstado_CheckedChanged);
				CheckBox checkBoxEstado = this._CheckBoxEstado;
				if (checkBoxEstado != null)
				{
					checkBoxEstado.CheckedChanged -= value2;
				}
				this._CheckBoxEstado = value;
				checkBoxEstado = this._CheckBoxEstado;
				if (checkBoxEstado != null)
				{
					checkBoxEstado.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0001CF5F File Offset: 0x0001B15F
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0001CF6C File Offset: 0x0001B16C
		internal virtual CheckBox CheckBoxPais
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxPais;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxPais_CheckedChanged);
				CheckBox checkBoxPais = this._CheckBoxPais;
				if (checkBoxPais != null)
				{
					checkBoxPais.CheckedChanged -= value2;
				}
				this._CheckBoxPais = value;
				checkBoxPais = this._CheckBoxPais;
				if (checkBoxPais != null)
				{
					checkBoxPais.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0001CFAF File Offset: 0x0001B1AF
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0001CFBC File Offset: 0x0001B1BC
		internal virtual CheckBox CheckBoxCP
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxCP;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxCP_CheckedChanged);
				CheckBox checkBoxCP = this._CheckBoxCP;
				if (checkBoxCP != null)
				{
					checkBoxCP.CheckedChanged -= value2;
				}
				this._CheckBoxCP = value;
				checkBoxCP = this._CheckBoxCP;
				if (checkBoxCP != null)
				{
					checkBoxCP.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0001CFFF File Offset: 0x0001B1FF
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0001D00C File Offset: 0x0001B20C
		internal virtual CheckBox CheckBoxCiudad
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxCiudad;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxCiudad_CheckedChanged);
				CheckBox checkBoxCiudad = this._CheckBoxCiudad;
				if (checkBoxCiudad != null)
				{
					checkBoxCiudad.CheckedChanged -= value2;
				}
				this._CheckBoxCiudad = value;
				checkBoxCiudad = this._CheckBoxCiudad;
				if (checkBoxCiudad != null)
				{
					checkBoxCiudad.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0001D04F File Offset: 0x0001B24F
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0001D05C File Offset: 0x0001B25C
		internal virtual CheckBox CheckBoxDirFiscal
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxDirFiscal;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxDirFiscal_CheckedChanged);
				CheckBox checkBoxDirFiscal = this._CheckBoxDirFiscal;
				if (checkBoxDirFiscal != null)
				{
					checkBoxDirFiscal.CheckedChanged -= value2;
				}
				this._CheckBoxDirFiscal = value;
				checkBoxDirFiscal = this._CheckBoxDirFiscal;
				if (checkBoxDirFiscal != null)
				{
					checkBoxDirFiscal.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0001D09F File Offset: 0x0001B29F
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		internal virtual CheckBox CheckBoxRazonSocial
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxRazonSocial;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxRazonSocial_CheckedChanged);
				CheckBox checkBoxRazonSocial = this._CheckBoxRazonSocial;
				if (checkBoxRazonSocial != null)
				{
					checkBoxRazonSocial.CheckedChanged -= value2;
				}
				this._CheckBoxRazonSocial = value;
				checkBoxRazonSocial = this._CheckBoxRazonSocial;
				if (checkBoxRazonSocial != null)
				{
					checkBoxRazonSocial.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0001D0EF File Offset: 0x0001B2EF
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		internal virtual CheckBox CheckBoxNombreComercial
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxNombreComercial;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxNombreComercial_CheckedChanged);
				CheckBox checkBoxNombreComercial = this._CheckBoxNombreComercial;
				if (checkBoxNombreComercial != null)
				{
					checkBoxNombreComercial.CheckedChanged -= value2;
				}
				this._CheckBoxNombreComercial = value;
				checkBoxNombreComercial = this._CheckBoxNombreComercial;
				if (checkBoxNombreComercial != null)
				{
					checkBoxNombreComercial.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0001D13F File Offset: 0x0001B33F
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0001D149 File Offset: 0x0001B349
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0001D152 File Offset: 0x0001B352
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0001D15C File Offset: 0x0001B35C
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0001D19F File Offset: 0x0001B39F
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0001D1A9 File Offset: 0x0001B3A9
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0001D1B2 File Offset: 0x0001B3B2
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0001D1BC File Offset: 0x0001B3BC
		internal virtual CheckBox CheckBoxImpresionTicket
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxImpresionTicket;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxImpresionTicket_CheckedChanged);
				CheckBox checkBoxImpresionTicket = this._CheckBoxImpresionTicket;
				if (checkBoxImpresionTicket != null)
				{
					checkBoxImpresionTicket.CheckedChanged -= value2;
				}
				this._CheckBoxImpresionTicket = value;
				checkBoxImpresionTicket = this._CheckBoxImpresionTicket;
				if (checkBoxImpresionTicket != null)
				{
					checkBoxImpresionTicket.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0001D1FF File Offset: 0x0001B3FF
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0001D209 File Offset: 0x0001B409
		internal virtual TextBox txtLeyenda3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0001D212 File Offset: 0x0001B412
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0001D21C File Offset: 0x0001B41C
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0001D225 File Offset: 0x0001B425
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0001D22F File Offset: 0x0001B42F
		internal virtual TextBox txtLeyenda2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0001D238 File Offset: 0x0001B438
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0001D242 File Offset: 0x0001B442
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001D24B File Offset: 0x0001B44B
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0001D255 File Offset: 0x0001B455
		internal virtual TextBox txtLeyenda1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0001D25E File Offset: 0x0001B45E
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0001D268 File Offset: 0x0001B468
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001D271 File Offset: 0x0001B471
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0001D27B File Offset: 0x0001B47B
		internal virtual TextBox txtSucEstado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001D284 File Offset: 0x0001B484
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x0001D28E File Offset: 0x0001B48E
		internal virtual TextBox txtSucCodigoPostal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001D297 File Offset: 0x0001B497
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0001D2A1 File Offset: 0x0001B4A1
		internal virtual TextBox txtSucCiudaad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0001D2AA File Offset: 0x0001B4AA
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0001D2B4 File Offset: 0x0001B4B4
		internal virtual TextBox txtDirSucursal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001D2BD File Offset: 0x0001B4BD
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0001D2C7 File Offset: 0x0001B4C7
		internal virtual TextBox TxtTelefono { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0001D2DA File Offset: 0x0001B4DA
		internal virtual TextBox txtRFC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001D2E3 File Offset: 0x0001B4E3
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0001D2ED File Offset: 0x0001B4ED
		internal virtual TextBox txtPais { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001D2F6 File Offset: 0x0001B4F6
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x0001D300 File Offset: 0x0001B500
		internal virtual TextBox txtEstado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001D309 File Offset: 0x0001B509
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0001D313 File Offset: 0x0001B513
		internal virtual TextBox txtCiudad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0001D31C File Offset: 0x0001B51C
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0001D326 File Offset: 0x0001B526
		internal virtual TextBox txtCodigoPostal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0001D32F File Offset: 0x0001B52F
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0001D339 File Offset: 0x0001B539
		internal virtual TextBox txtDireccionFiscal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0001D342 File Offset: 0x0001B542
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0001D34C File Offset: 0x0001B54C
		internal virtual TextBox txtRazonSocial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0001D355 File Offset: 0x0001B555
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0001D35F File Offset: 0x0001B55F
		internal virtual TextBox txtNombreComercial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0001D368 File Offset: 0x0001B568
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0001D372 File Offset: 0x0001B572
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0001D37B File Offset: 0x0001B57B
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0001D385 File Offset: 0x0001B585
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001D38E File Offset: 0x0001B58E
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x0001D398 File Offset: 0x0001B598
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001D3A1 File Offset: 0x0001B5A1
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0001D3AB File Offset: 0x0001B5AB
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001D3B4 File Offset: 0x0001B5B4
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0001D3BE File Offset: 0x0001B5BE
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001D3C7 File Offset: 0x0001B5C7
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0001D3D1 File Offset: 0x0001B5D1
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0001D3DA File Offset: 0x0001B5DA
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0001D3E4 File Offset: 0x0001B5E4
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0001D3ED File Offset: 0x0001B5ED
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0001D3F7 File Offset: 0x0001B5F7
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0001D400 File Offset: 0x0001B600
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0001D40A File Offset: 0x0001B60A
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0001D413 File Offset: 0x0001B613
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0001D41D File Offset: 0x0001B61D
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0001D426 File Offset: 0x0001B626
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x0001D430 File Offset: 0x0001B630
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0001D439 File Offset: 0x0001B639
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0001D443 File Offset: 0x0001B643
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0001D44C File Offset: 0x0001B64C
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0001D456 File Offset: 0x0001B656
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0001D45F File Offset: 0x0001B65F
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0001D46C File Offset: 0x0001B66C
		internal virtual CheckBox CheckBoxLeyenda3
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxLeyenda3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxLeyenda3_CheckedChanged);
				CheckBox checkBoxLeyenda = this._CheckBoxLeyenda3;
				if (checkBoxLeyenda != null)
				{
					checkBoxLeyenda.CheckedChanged -= value2;
				}
				this._CheckBoxLeyenda3 = value;
				checkBoxLeyenda = this._CheckBoxLeyenda3;
				if (checkBoxLeyenda != null)
				{
					checkBoxLeyenda.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0001D4AF File Offset: 0x0001B6AF
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0001D4B9 File Offset: 0x0001B6B9
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0001D4C2 File Offset: 0x0001B6C2
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		internal virtual CheckBox CheckBox_ImprimeCompuestos
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox_ImprimeCompuestos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox_ImprimeCompuestos_CheckedChanged);
				CheckBox checkBox_ImprimeCompuestos = this._CheckBox_ImprimeCompuestos;
				if (checkBox_ImprimeCompuestos != null)
				{
					checkBox_ImprimeCompuestos.CheckedChanged -= value2;
				}
				this._CheckBox_ImprimeCompuestos = value;
				checkBox_ImprimeCompuestos = this._CheckBox_ImprimeCompuestos;
				if (checkBox_ImprimeCompuestos != null)
				{
					checkBox_ImprimeCompuestos.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0001D50F File Offset: 0x0001B70F
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0001D51C File Offset: 0x0001B71C
		internal virtual CheckBox CheckBox_AgrupaTickets
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox_AgrupaTickets;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox_AgrupaTickets_CheckedChanged);
				CheckBox checkBox_AgrupaTickets = this._CheckBox_AgrupaTickets;
				if (checkBox_AgrupaTickets != null)
				{
					checkBox_AgrupaTickets.CheckedChanged -= value2;
				}
				this._CheckBox_AgrupaTickets = value;
				checkBox_AgrupaTickets = this._CheckBox_AgrupaTickets;
				if (checkBox_AgrupaTickets != null)
				{
					checkBox_AgrupaTickets.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0001D55F File Offset: 0x0001B75F
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0001D56C File Offset: 0x0001B76C
		internal virtual Button btnPruebaPrint
		{
			[CompilerGenerated]
			get
			{
				return this._btnPruebaPrint;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPruebaPrint_Click);
				Button btnPruebaPrint = this._btnPruebaPrint;
				if (btnPruebaPrint != null)
				{
					btnPruebaPrint.Click -= value2;
				}
				this._btnPruebaPrint = value;
				btnPruebaPrint = this._btnPruebaPrint;
				if (btnPruebaPrint != null)
				{
					btnPruebaPrint.Click += value2;
				}
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001D5AF File Offset: 0x0001B7AF
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001D5BC File Offset: 0x0001B7BC
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = string.Concat(new string[]
			{
				"UPDATE Bb set a = '",
				Tools.Encriptar(this.txtNombreComercial.Text.Trim()),
				"' , b= '",
				Tools.Encriptar(this.txtRazonSocial.Text.Trim()),
				"' , c='",
				Tools.Encriptar(this.txtDireccionFiscal.Text.Trim()),
				"' , d='",
				Tools.Encriptar(this.txtCodigoPostal.Text.Trim()),
				"' , e = '",
				Tools.Encriptar(this.txtCiudad.Text.Trim()),
				"' ,\r\n                    f='",
				Tools.Encriptar(this.txtEstado.Text.Trim()),
				"' , g ='",
				Tools.Encriptar(this.txtPais.Text.Trim()),
				"' , h='",
				Tools.Encriptar(this.txtRFC.Text.Trim()),
				"' , i='",
				Tools.Encriptar(this.TxtTelefono.Text.Trim()),
				"' , j='",
				Tools.Encriptar(this.txtDirSucursal.Text.Trim()),
				"' , k='",
				Tools.Encriptar(this.txtSucCiudaad.Text.Trim()),
				"' , l='",
				Tools.Encriptar(this.txtSucEstado.Text.Trim()),
				"' ,  m='",
				Tools.Encriptar(this.txtSucCodigoPostal.Text.Trim()),
				"' , n='",
				Tools.Encriptar(this.txtLeyenda1.Text.Trim()),
				"' , o='",
				Tools.Encriptar(this.txtLeyenda2.Text.Trim()),
				"' , p='",
				Tools.Encriptar(this.txtLeyenda3.Text.Trim()),
				"'"
			});
			sqlQuery_Conn.execQuery_conn(query_conn);
			query_conn = "Update H set af='" + Tools.Encriptar(this.ComboBox1.Text.Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(query_conn);
			base.Close();
			MyProject.Forms.main.btnEmpresa.BackColor = SystemColors.InactiveCaption;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001D854 File Offset: 0x0001BA54
		public void MostrarDatosAlmacenados()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "Select ISNULL(a,'') , ISNULL(b,'') , ISNULL(c,''), ISNULL(d,''), ISNULL(e,''), ISNULL(f,'') , ISNULL(g,'') , ISNULL(h,''), ISNULL(i,''), ISNULL(j,'') , ISNULL(k,'') ,  ISNULL(m,'') ,ISNULL(n,'') , ISNULL(o,'') , ISNULL(p,'') , ISNULL(l,'') from Bb";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				string text = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				string text2 = Tools.Desencriptar(sqlDataReader[1].ToString().Trim());
				string text3 = Tools.Desencriptar(sqlDataReader[2].ToString().Trim());
				string text4 = Tools.Desencriptar(sqlDataReader[3].ToString().Trim());
				string text5 = Tools.Desencriptar(sqlDataReader[4].ToString().Trim());
				string text6 = Tools.Desencriptar(sqlDataReader[5].ToString().Trim());
				string text7 = Tools.Desencriptar(sqlDataReader[6].ToString().Trim());
				string text8 = Tools.Desencriptar(sqlDataReader[7].ToString().Trim());
				string text9 = Tools.Desencriptar(sqlDataReader[8].ToString().Trim());
				string text10 = Tools.Desencriptar(sqlDataReader[9].ToString().Trim());
				string text11 = Tools.Desencriptar(sqlDataReader[10].ToString().Trim());
				string text12 = Tools.Desencriptar(sqlDataReader[11].ToString().Trim());
				string text13 = Tools.Desencriptar(sqlDataReader[12].ToString().Trim());
				string text14 = Tools.Desencriptar(sqlDataReader[13].ToString().Trim());
				string text15 = Tools.Desencriptar(sqlDataReader[14].ToString().Trim());
				string text16 = Tools.Desencriptar(sqlDataReader[15].ToString().Trim());
				this.txtNombreComercial.Text = text.ToString();
				this.txtRazonSocial.Text = text2.ToString();
				this.txtDireccionFiscal.Text = text3.ToString();
				this.txtCodigoPostal.Text = text4.ToString();
				this.txtCiudad.Text = text5.ToString();
				this.txtEstado.Text = text6.ToString();
				this.txtPais.Text = text7.ToString();
				this.txtRFC.Text = text8.ToString();
				this.TxtTelefono.Text = text9.ToString();
				this.txtDirSucursal.Text = text10.ToString();
				this.txtSucCiudaad.Text = text11.ToString();
				this.txtSucCodigoPostal.Text = text12.ToString();
				this.txtLeyenda1.Text = text13.ToString();
				this.txtLeyenda2.Text = text14.ToString();
				this.txtLeyenda3.Text = text15.ToString();
				this.txtSucEstado.Text = text16.ToString();
			}
			sqlDataReader.Close();
			bool flag2 = Operators.CompareString(this.txtNombreComercial.Text, "", false) == 0;
			if (flag2)
			{
				this.CheckBoxNombreComercial.Checked = false;
				this.txtNombreComercial.Enabled = false;
			}
			else
			{
				this.CheckBoxNombreComercial.Checked = true;
				this.txtNombreComercial.Enabled = true;
			}
			bool flag3 = Operators.CompareString(this.txtRazonSocial.Text, "", false) == 0;
			if (flag3)
			{
				this.CheckBoxRazonSocial.Checked = false;
				this.txtRazonSocial.Enabled = false;
			}
			else
			{
				this.CheckBoxRazonSocial.Checked = true;
				this.txtRazonSocial.Enabled = true;
			}
			bool flag4 = Operators.CompareString(this.txtDireccionFiscal.Text, "", false) == 0;
			if (flag4)
			{
				this.CheckBoxDirFiscal.Checked = false;
				this.txtDireccionFiscal.Enabled = false;
			}
			else
			{
				this.CheckBoxDirFiscal.Checked = true;
				this.txtDireccionFiscal.Enabled = true;
			}
			bool flag5 = Operators.CompareString(this.txtCodigoPostal.Text, "", false) == 0;
			if (flag5)
			{
				this.CheckBoxCP.Checked = false;
				this.txtCodigoPostal.Enabled = false;
			}
			else
			{
				this.CheckBoxCP.Checked = true;
				this.txtCodigoPostal.Enabled = true;
			}
			bool flag6 = Operators.CompareString(this.txtCiudad.Text, "", false) == 0;
			if (flag6)
			{
				this.CheckBoxCiudad.Checked = false;
				this.txtCiudad.Enabled = false;
			}
			else
			{
				this.CheckBoxCiudad.Checked = true;
				this.txtCiudad.Enabled = true;
			}
			bool flag7 = Operators.CompareString(this.txtEstado.Text, "", false) == 0;
			if (flag7)
			{
				this.CheckBoxEstado.Checked = false;
				this.txtEstado.Enabled = false;
			}
			else
			{
				this.CheckBoxEstado.Checked = true;
				this.txtEstado.Enabled = true;
			}
			bool flag8 = Operators.CompareString(this.txtPais.Text, "", false) == 0;
			if (flag8)
			{
				this.CheckBoxPais.Checked = false;
				this.txtPais.Enabled = false;
			}
			else
			{
				this.CheckBoxPais.Checked = true;
				this.txtPais.Enabled = true;
			}
			bool flag9 = Operators.CompareString(this.txtRFC.Text, "", false) == 0;
			if (flag9)
			{
				this.CheckBoxRFC.Checked = false;
				this.txtRFC.Enabled = false;
			}
			else
			{
				this.CheckBoxRFC.Checked = true;
				this.txtRFC.Enabled = true;
			}
			bool flag10 = Operators.CompareString(this.TxtTelefono.Text, "", false) == 0;
			if (flag10)
			{
				this.CheckBoxTelefono.Checked = false;
				this.TxtTelefono.Enabled = false;
			}
			else
			{
				this.CheckBoxTelefono.Checked = true;
				this.TxtTelefono.Enabled = true;
			}
			bool flag11 = Operators.CompareString(this.txtDirSucursal.Text, "", false) == 0;
			if (flag11)
			{
				this.CheckBoxDirSucursal.Checked = false;
				this.txtDirSucursal.Enabled = false;
			}
			else
			{
				this.CheckBoxDirSucursal.Checked = true;
				this.txtDirSucursal.Enabled = true;
			}
			bool flag12 = Operators.CompareString(this.txtSucCiudaad.Text, "", false) == 0;
			if (flag12)
			{
				this.CheckBoxCiudadSuc.Checked = false;
				this.txtSucCiudaad.Enabled = false;
			}
			else
			{
				this.CheckBoxCiudadSuc.Checked = true;
				this.txtSucCiudaad.Enabled = true;
			}
			bool flag13 = Operators.CompareString(this.txtSucCodigoPostal.Text, "", false) == 0;
			if (flag13)
			{
				this.CheckBoxCodigoPostalSuc.Checked = false;
				this.txtSucCodigoPostal.Enabled = false;
			}
			else
			{
				this.CheckBoxCodigoPostalSuc.Checked = true;
				this.txtSucCodigoPostal.Enabled = true;
			}
			bool flag14 = Operators.CompareString(this.txtLeyenda1.Text, "", false) == 0;
			if (flag14)
			{
				this.CheckBoxLeyenda1.Checked = false;
				this.txtLeyenda1.Enabled = false;
			}
			else
			{
				this.CheckBoxLeyenda1.Checked = true;
				this.txtLeyenda1.Enabled = true;
			}
			bool flag15 = Operators.CompareString(this.txtLeyenda2.Text, "", false) == 0;
			if (flag15)
			{
				this.CheckBoxLeyenda2.Checked = false;
				this.txtLeyenda2.Enabled = false;
			}
			else
			{
				this.CheckBoxLeyenda2.Checked = true;
				this.txtLeyenda2.Enabled = true;
			}
			bool flag16 = Operators.CompareString(this.txtLeyenda3.Text, "", false) == 0;
			if (flag16)
			{
				this.CheckBoxLeyenda3.Checked = false;
				this.txtLeyenda3.Enabled = false;
			}
			else
			{
				this.CheckBoxLeyenda3.Checked = true;
				this.txtLeyenda3.Enabled = true;
			}
			bool flag17 = Operators.CompareString(this.txtSucEstado.Text, "", false) == 0;
			if (flag17)
			{
				this.CheckBoxEstadoSuc.Checked = false;
				this.txtSucEstado.Enabled = false;
			}
			else
			{
				this.CheckBoxEstadoSuc.Checked = true;
				this.txtSucEstado.Enabled = true;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001E0C8 File Offset: 0x0001C2C8
		private void frmDatosEmpresa_Load(object sender, EventArgs e)
		{
			this.MostrarDatosAlmacenados();
			this.LlenarComboboxImpresorasTicket();
			this.btnPruebaPrint.Enabled = false;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "SELECT ae from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				int num = Conversions.ToInteger(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
				bool flag2 = (double)num == Conversions.ToDouble("0");
				if (flag2)
				{
					this.CheckBoxImpresionTicket.Checked = false;
				}
				bool flag3 = (double)num == Conversions.ToDouble("1");
				if (flag3)
				{
					this.CheckBoxImpresionTicket.Checked = true;
				}
			}
			query_conn = "SELECT af from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag4 = Operators.CompareString(text, "", false) == 0;
					if (!flag4)
					{
						this.ComboBox1.Text = text.ToString();
						this.btnPruebaPrint.Enabled = true;
					}
				}
			}
			query_conn = "SELECT ag from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows2 = sqlDataReader.HasRows;
			if (hasRows2)
			{
				while (sqlDataReader.Read())
				{
					string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag5 = Operators.CompareString(left, "1", false) == 0;
					if (flag5)
					{
						this.CheckBox_AgrupaTickets.Checked = true;
					}
					else
					{
						this.CheckBox_AgrupaTickets.Checked = false;
					}
				}
			}
			query_conn = "SELECT ah from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows3 = sqlDataReader.HasRows;
			if (hasRows3)
			{
				while (sqlDataReader.Read())
				{
					string left2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag6 = Operators.CompareString(left2, "1", false) == 0;
					if (flag6)
					{
						this.CheckBox_ImprimeCompuestos.Checked = true;
					}
					else
					{
						this.CheckBox_ImprimeCompuestos.Checked = false;
					}
				}
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001E30C File Offset: 0x0001C50C
		public void LlenarComboboxImpresorasTicket()
		{
			this.ComboBox1.Items.Clear();
			this.obtener_impresoras(this.ComboBox1);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001E330 File Offset: 0x0001C530
		private void CheckBoxImpresionTicket_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "0";
			string text2 = "1";
			bool @checked = this.CheckBoxImpresionTicket.Checked;
			if (@checked)
			{
				string query_conn = "UPDATE H set ae='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
			}
			else
			{
				string query_conn = "UPDATE H set ae='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		public void MostrarStatusTicket()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "SELECT TIcketVenta from Parametro";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				int num = Conversions.ToInteger(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
				bool flag2 = (double)num == Conversions.ToDouble("0");
				if (flag2)
				{
					this.CheckBoxImpresionTicket.Checked = false;
				}
				bool flag3 = (double)num == Conversions.ToDouble("1");
				if (flag3)
				{
					this.CheckBoxImpresionTicket.Checked = true;
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001E458 File Offset: 0x0001C658
		private void CheckBoxNombreComercial_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxNombreComercial.Checked;
			if (flag)
			{
				this.txtNombreComercial.Enabled = false;
				this.txtNombreComercial.Clear();
			}
			bool @checked = this.CheckBoxNombreComercial.Checked;
			if (@checked)
			{
				this.txtNombreComercial.Enabled = true;
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001E4B4 File Offset: 0x0001C6B4
		private void CheckBoxRazonSocial_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxRazonSocial.Checked;
			if (flag)
			{
				this.txtRazonSocial.Enabled = false;
				this.txtRazonSocial.Clear();
			}
			bool @checked = this.CheckBoxRazonSocial.Checked;
			if (@checked)
			{
				this.txtRazonSocial.Enabled = true;
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001E510 File Offset: 0x0001C710
		private void CheckBoxDirFiscal_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxDirFiscal.Checked;
			if (flag)
			{
				this.txtDireccionFiscal.Enabled = false;
				this.txtDireccionFiscal.Clear();
			}
			bool @checked = this.CheckBoxDirFiscal.Checked;
			if (@checked)
			{
				this.txtDireccionFiscal.Enabled = true;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001E56C File Offset: 0x0001C76C
		private void CheckBoxCP_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxCP.Checked;
			if (flag)
			{
				this.txtCodigoPostal.Enabled = false;
				this.txtCodigoPostal.Clear();
			}
			bool @checked = this.CheckBoxCP.Checked;
			if (@checked)
			{
				this.txtCodigoPostal.Enabled = true;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
		private void CheckBoxEstado_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxEstado.Checked;
			if (flag)
			{
				this.txtEstado.Enabled = false;
				this.txtEstado.Clear();
			}
			bool @checked = this.CheckBoxEstado.Checked;
			if (@checked)
			{
				this.txtEstado.Enabled = true;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001E624 File Offset: 0x0001C824
		private void CheckBoxRFC_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxRFC.Checked;
			if (flag)
			{
				this.txtRFC.Enabled = false;
				this.txtRFC.Clear();
			}
			bool @checked = this.CheckBoxRFC.Checked;
			if (@checked)
			{
				this.txtRFC.Enabled = true;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001E680 File Offset: 0x0001C880
		private void CheckBoxCiudad_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxCiudad.Checked;
			if (flag)
			{
				this.txtCiudad.Enabled = false;
				this.txtCiudad.Clear();
			}
			bool @checked = this.CheckBoxCiudad.Checked;
			if (@checked)
			{
				this.txtCiudad.Enabled = true;
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001E6DC File Offset: 0x0001C8DC
		private void CheckBoxPais_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxPais.Checked;
			if (flag)
			{
				this.txtPais.Enabled = false;
				this.txtPais.Clear();
			}
			bool @checked = this.CheckBoxPais.Checked;
			if (@checked)
			{
				this.txtPais.Enabled = true;
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001E738 File Offset: 0x0001C938
		private void CheckBoxTelefono_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxTelefono.Checked;
			if (flag)
			{
				this.TxtTelefono.Enabled = false;
				this.TxtTelefono.Clear();
			}
			bool @checked = this.CheckBoxTelefono.Checked;
			if (@checked)
			{
				this.TxtTelefono.Enabled = true;
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001E794 File Offset: 0x0001C994
		private void CheckBoxDirSucursal_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxDirSucursal.Checked;
			if (flag)
			{
				this.txtDirSucursal.Enabled = false;
				this.txtDirSucursal.Clear();
			}
			bool @checked = this.CheckBoxDirSucursal.Checked;
			if (@checked)
			{
				this.txtDirSucursal.Enabled = true;
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
		private void CheckBoxCiudadSuc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxCiudadSuc.Checked;
			if (flag)
			{
				this.txtSucCiudaad.Enabled = false;
				this.txtSucCiudaad.Clear();
			}
			bool @checked = this.CheckBoxCiudadSuc.Checked;
			if (@checked)
			{
				this.txtSucCiudaad.Enabled = true;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001E84C File Offset: 0x0001CA4C
		private void CheckBoxEstadoSuc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxEstadoSuc.Checked;
			if (flag)
			{
				this.txtSucEstado.Enabled = false;
				this.txtSucEstado.Clear();
			}
			bool @checked = this.CheckBoxEstadoSuc.Checked;
			if (@checked)
			{
				this.txtSucEstado.Enabled = true;
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001E8A8 File Offset: 0x0001CAA8
		private void CheckBoxCodigoPostalSuc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxCodigoPostalSuc.Checked;
			if (flag)
			{
				this.txtSucCodigoPostal.Enabled = false;
				this.txtSucCodigoPostal.Clear();
			}
			bool @checked = this.CheckBoxCodigoPostalSuc.Checked;
			if (@checked)
			{
				this.txtSucCodigoPostal.Enabled = true;
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001E904 File Offset: 0x0001CB04
		private void CheckBoxLeyenda1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxLeyenda1.Checked;
			if (flag)
			{
				this.txtLeyenda1.Enabled = false;
				this.txtLeyenda1.Clear();
			}
			bool @checked = this.CheckBoxLeyenda1.Checked;
			if (@checked)
			{
				this.txtLeyenda1.Enabled = true;
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001E960 File Offset: 0x0001CB60
		private void CheckBoxLeyenda2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxLeyenda2.Checked;
			if (flag)
			{
				this.txtLeyenda2.Enabled = false;
				this.txtLeyenda2.Clear();
			}
			bool @checked = this.CheckBoxLeyenda2.Checked;
			if (@checked)
			{
				this.txtLeyenda2.Enabled = true;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001E9BC File Offset: 0x0001CBBC
		private void CheckBoxLeyenda3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.CheckBoxLeyenda3.Checked;
			if (flag)
			{
				this.txtLeyenda3.Enabled = false;
				this.txtLeyenda3.Clear();
			}
			bool @checked = this.CheckBoxLeyenda3.Checked;
			if (@checked)
			{
				this.txtLeyenda3.Enabled = true;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001EA18 File Offset: 0x0001CC18
		public void obtener_impresoras(object sender)
		{
			PrintDocument printDocument = new PrintDocument();
			string printerName = printDocument.PrinterSettings.PrinterName;
			checked
			{
				int num = PrinterSettings.InstalledPrinters.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(sender, null, "Items", new object[0], null, null, null), null, "Add", new object[]
					{
						PrinterSettings.InstalledPrinters[i].ToString()
					}, null, null, null, true);
				}
				object objectValue;
				object loopObj;
				bool flag = ObjectFlowControl.ForLoopControl.ForLoopInitObj(objectValue, 0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Items", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 1), 1, ref loopObj, ref objectValue);
				if (flag)
				{
					do
					{
						object[] array;
						bool[] array2;
						object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Items", new object[0], null, null, null), null, "Item", array = new object[]
						{
							objectValue
						}, null, null, array2 = new bool[]
						{
							true
						});
						if (array2[0])
						{
							objectValue = RuntimeHelpers.GetObjectValue(array[0]);
						}
						bool flag2 = Operators.CompareString(obj.ToString(), printerName, false) == 0;
						if (flag2)
						{
							NewLateBinding.LateSet(sender, null, "SelectedIndex", new object[]
							{
								objectValue
							}, null, null);
						}
					}
					while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(objectValue, loopObj, ref objectValue));
				}
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0001EB7C File Offset: 0x0001CD7C
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnPruebaPrint.Enabled = true;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001EB8C File Offset: 0x0001CD8C
		private void CheckBox_AgrupaTickets_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "0";
			string text2 = "1";
			bool @checked = this.CheckBox_AgrupaTickets.Checked;
			if (@checked)
			{
				string query_conn = "Update H set ag='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
			}
			bool flag = !this.CheckBox_AgrupaTickets.Checked;
			if (flag)
			{
				string query_conn = "Update H set ag='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001EC28 File Offset: 0x0001CE28
		private void CheckBox_ImprimeCompuestos_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "0";
			string text2 = "1";
			bool @checked = this.CheckBox_ImprimeCompuestos.Checked;
			if (@checked)
			{
				string query_conn = "Update H set ah='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
			}
			bool flag = !this.CheckBox_ImprimeCompuestos.Checked;
			if (flag)
			{
				string query_conn = "Update H set ah='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001ECC1 File Offset: 0x0001CEC1
		private void btnPruebaPrint_Click(object sender, EventArgs e)
		{
			this.PrintingOutTicketVenta();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0001ECCC File Offset: 0x0001CECC
		public void PrintingOutTicketVenta()
		{
			PrintDialog printDialog = new PrintDialog();
			string str = "GORDOLOBOSOFT:\r\n";
			str += "PRUEBA DE IMPRESION\r\n";
			str = str + "IMPRESORA:" + this.ComboBox1.Text + "\r\n";
			str += "PRUEBA FINALIZADA EXITOSAMENTE\r\n";
			string text = this.ComboBox1.Text;
			printDialog.PrinterSettings.PrinterName = text.ToString();
			try
			{
				RawPrinterHelper.SendStringToPrinter(printDialog.PrinterSettings.PrinterName, str + this.CortePapel);
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Error de impresion", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04000145 RID: 325
		public string sess_ESC;

		// Token: 0x04000146 RID: 326
		public string sess_EPSON_BOLD_ON;

		// Token: 0x04000147 RID: 327
		public string sess_EPSON_BOLD_OFF;

		// Token: 0x04000148 RID: 328
		public string sess_STAR_BOLD_ON;

		// Token: 0x04000149 RID: 329
		public string sess_STAR_BOLD_OFF;

		// Token: 0x0400014A RID: 330
		public string CortePapel;

		// Token: 0x0400014B RID: 331
		public string DobleAlto;

		// Token: 0x0400014C RID: 332
		public string DobleAlto_OFF;

		// Token: 0x0400014D RID: 333
		public string DobleAncho_ON;

		// Token: 0x0400014E RID: 334
		public string DobleAncho_OFF;

		// Token: 0x0400014F RID: 335
		public string eCentro;

		// Token: 0x04000150 RID: 336
		public string eCentro_OFF;

		// Token: 0x04000151 RID: 337
		public string eRight;

		// Token: 0x04000152 RID: 338
		public const string eLeft = "\u001b@";

		// Token: 0x04000153 RID: 339
		public string sess_PRINT_BOLD_ON;

		// Token: 0x04000154 RID: 340
		public string sess_PRINT_BOLD_OFF;
	}
}
