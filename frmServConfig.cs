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
using MySql.Data.MySqlClient;

namespace ModuloAdicional
{
	// Token: 0x02000021 RID: 33
	[DesignerGenerated]
	public partial class frmServConfig : Form
	{
		// Token: 0x06000F8F RID: 3983 RVA: 0x000FD090 File Offset: 0x000FB290
		public frmServConfig()
		{
			base.Load += this.frmServConfig_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00100323 File Offset: 0x000FE523
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00100330 File Offset: 0x000FE530
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00100373 File Offset: 0x000FE573
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00100380 File Offset: 0x000FE580
		internal virtual TextBox txtNomServ
		{
			[CompilerGenerated]
			get
			{
				return this._txtNomServ;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtNomServ_TextChanged);
				TextBox txtNomServ = this._txtNomServ;
				if (txtNomServ != null)
				{
					txtNomServ.TextChanged -= value2;
				}
				this._txtNomServ = value;
				txtNomServ = this._txtNomServ;
				if (txtNomServ != null)
				{
					txtNomServ.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x001003C3 File Offset: 0x000FE5C3
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x001003D0 File Offset: 0x000FE5D0
		internal virtual Button btnGuardarConexion
		{
			[CompilerGenerated]
			get
			{
				return this._btnGuardarConexion;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnGuardarConexion_Click);
				Button btnGuardarConexion = this._btnGuardarConexion;
				if (btnGuardarConexion != null)
				{
					btnGuardarConexion.Click -= value2;
				}
				this._btnGuardarConexion = value;
				btnGuardarConexion = this._btnGuardarConexion;
				if (btnGuardarConexion != null)
				{
					btnGuardarConexion.Click += value2;
				}
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00100413 File Offset: 0x000FE613
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x00100420 File Offset: 0x000FE620
		internal virtual Button btnProbarConexion
		{
			[CompilerGenerated]
			get
			{
				return this._btnProbarConexion;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnProbarConexion_Click);
				Button btnProbarConexion = this._btnProbarConexion;
				if (btnProbarConexion != null)
				{
					btnProbarConexion.Click -= value2;
				}
				this._btnProbarConexion = value;
				btnProbarConexion = this._btnProbarConexion;
				if (btnProbarConexion != null)
				{
					btnProbarConexion.Click += value2;
				}
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00100463 File Offset: 0x000FE663
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x00100470 File Offset: 0x000FE670
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x001004B3 File Offset: 0x000FE6B3
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x001004C0 File Offset: 0x000FE6C0
		internal virtual TextBox txtBaseDatos
		{
			[CompilerGenerated]
			get
			{
				return this._txtBaseDatos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtBaseDatos_TextChanged);
				TextBox txtBaseDatos = this._txtBaseDatos;
				if (txtBaseDatos != null)
				{
					txtBaseDatos.TextChanged -= value2;
				}
				this._txtBaseDatos = value;
				txtBaseDatos = this._txtBaseDatos;
				if (txtBaseDatos != null)
				{
					txtBaseDatos.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00100503 File Offset: 0x000FE703
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00100510 File Offset: 0x000FE710
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00100553 File Offset: 0x000FE753
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00100560 File Offset: 0x000FE760
		internal virtual TextBox txtContrasena
		{
			[CompilerGenerated]
			get
			{
				return this._txtContrasena;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtContrasena_TextChanged);
				TextBox txtContrasena = this._txtContrasena;
				if (txtContrasena != null)
				{
					txtContrasena.TextChanged -= value2;
				}
				this._txtContrasena = value;
				txtContrasena = this._txtContrasena;
				if (txtContrasena != null)
				{
					txtContrasena.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x001005A3 File Offset: 0x000FE7A3
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x001005B0 File Offset: 0x000FE7B0
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x001005F3 File Offset: 0x000FE7F3
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00100600 File Offset: 0x000FE800
		internal virtual TextBox txtInicioSesion
		{
			[CompilerGenerated]
			get
			{
				return this._txtInicioSesion;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtInicioSesion_TextChanged);
				TextBox txtInicioSesion = this._txtInicioSesion;
				if (txtInicioSesion != null)
				{
					txtInicioSesion.TextChanged -= value2;
				}
				this._txtInicioSesion = value;
				txtInicioSesion = this._txtInicioSesion;
				if (txtInicioSesion != null)
				{
					txtInicioSesion.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00100643 File Offset: 0x000FE843
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00100650 File Offset: 0x000FE850
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

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00100693 File Offset: 0x000FE893
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x001006A0 File Offset: 0x000FE8A0
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

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x001006E3 File Offset: 0x000FE8E3
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x001006F0 File Offset: 0x000FE8F0
		internal virtual TextBox txtCte
		{
			[CompilerGenerated]
			get
			{
				return this._txtCte;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtCte_TextChanged);
				TextBox txtCte = this._txtCte;
				if (txtCte != null)
				{
					txtCte.TextChanged -= value2;
				}
				this._txtCte = value;
				txtCte = this._txtCte;
				if (txtCte != null)
				{
					txtCte.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00100733 File Offset: 0x000FE933
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00100740 File Offset: 0x000FE940
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

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00100783 File Offset: 0x000FE983
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00100790 File Offset: 0x000FE990
		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return this._Label6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label6_Click);
				Label label = this._Label6;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label6 = value;
				label = this._Label6;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x001007D3 File Offset: 0x000FE9D3
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x001007E0 File Offset: 0x000FE9E0
		internal virtual TextBox txtInstancia
		{
			[CompilerGenerated]
			get
			{
				return this._txtInstancia;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtInstancia_TextChanged);
				TextBox txtInstancia = this._txtInstancia;
				if (txtInstancia != null)
				{
					txtInstancia.TextChanged -= value2;
				}
				this._txtInstancia = value;
				txtInstancia = this._txtInstancia;
				if (txtInstancia != null)
				{
					txtInstancia.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00100823 File Offset: 0x000FEA23
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00100830 File Offset: 0x000FEA30
		internal virtual Label Label7
		{
			[CompilerGenerated]
			get
			{
				return this._Label7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label7_Click);
				Label label = this._Label7;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label7 = value;
				label = this._Label7;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00100873 File Offset: 0x000FEA73
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00100880 File Offset: 0x000FEA80
		internal virtual TextBox txtID
		{
			[CompilerGenerated]
			get
			{
				return this._txtID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtID_TextChanged);
				TextBox txtID = this._txtID;
				if (txtID != null)
				{
					txtID.TextChanged -= value2;
				}
				this._txtID = value;
				txtID = this._txtID;
				if (txtID != null)
				{
					txtID.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x001008C3 File Offset: 0x000FEAC3
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x001008D0 File Offset: 0x000FEAD0
		internal virtual Label Label8
		{
			[CompilerGenerated]
			get
			{
				return this._Label8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label8_Click);
				Label label = this._Label8;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label8 = value;
				label = this._Label8;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00100913 File Offset: 0x000FEB13
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00100920 File Offset: 0x000FEB20
		internal virtual Button btnCrearDBO
		{
			[CompilerGenerated]
			get
			{
				return this._btnCrearDBO;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCrearDBO_Click);
				Button btnCrearDBO = this._btnCrearDBO;
				if (btnCrearDBO != null)
				{
					btnCrearDBO.Click -= value2;
				}
				this._btnCrearDBO = value;
				btnCrearDBO = this._btnCrearDBO;
				if (btnCrearDBO != null)
				{
					btnCrearDBO.Click += value2;
				}
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00100963 File Offset: 0x000FEB63
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00100970 File Offset: 0x000FEB70
		internal virtual GroupBox GroupBoxBase_Modulo
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBoxBase_Modulo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GroupBoxBase_Modulo_Enter);
				GroupBox groupBoxBase_Modulo = this._GroupBoxBase_Modulo;
				if (groupBoxBase_Modulo != null)
				{
					groupBoxBase_Modulo.Enter -= value2;
				}
				this._GroupBoxBase_Modulo = value;
				groupBoxBase_Modulo = this._GroupBoxBase_Modulo;
				if (groupBoxBase_Modulo != null)
				{
					groupBoxBase_Modulo.Enter += value2;
				}
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x001009B3 File Offset: 0x000FEBB3
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x001009C0 File Offset: 0x000FEBC0
		internal virtual TextBox txtbaseDatos_Modulo
		{
			[CompilerGenerated]
			get
			{
				return this._txtbaseDatos_Modulo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtbaseDatos_Modulo_TextChanged);
				TextBox txtbaseDatos_Modulo = this._txtbaseDatos_Modulo;
				if (txtbaseDatos_Modulo != null)
				{
					txtbaseDatos_Modulo.TextChanged -= value2;
				}
				this._txtbaseDatos_Modulo = value;
				txtbaseDatos_Modulo = this._txtbaseDatos_Modulo;
				if (txtbaseDatos_Modulo != null)
				{
					txtbaseDatos_Modulo.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00100A03 File Offset: 0x000FEC03
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00100A10 File Offset: 0x000FEC10
		internal virtual GroupBox GroupBox_ConexionSQL
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox_ConexionSQL;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GroupBox2_Enter);
				GroupBox groupBox_ConexionSQL = this._GroupBox_ConexionSQL;
				if (groupBox_ConexionSQL != null)
				{
					groupBox_ConexionSQL.Enter -= value2;
				}
				this._GroupBox_ConexionSQL = value;
				groupBox_ConexionSQL = this._GroupBox_ConexionSQL;
				if (groupBox_ConexionSQL != null)
				{
					groupBox_ConexionSQL.Enter += value2;
				}
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00100A53 File Offset: 0x000FEC53
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00100A60 File Offset: 0x000FEC60
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

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00100AA3 File Offset: 0x000FECA3
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00100AB0 File Offset: 0x000FECB0
		internal virtual BackgroundWorker BackgroundWorker1
		{
			[CompilerGenerated]
			get
			{
				return this._BackgroundWorker1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
				BackgroundWorker backgroundWorker = this._BackgroundWorker1;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork -= value2;
				}
				this._BackgroundWorker1 = value;
				backgroundWorker = this._BackgroundWorker1;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork += value2;
				}
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00100AF3 File Offset: 0x000FECF3
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00100B00 File Offset: 0x000FED00
		internal virtual GroupBox GroupBox_Adicionales
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox_Adicionales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GroupBox_Adicionales_Enter);
				GroupBox groupBox_Adicionales = this._GroupBox_Adicionales;
				if (groupBox_Adicionales != null)
				{
					groupBox_Adicionales.Enter -= value2;
				}
				this._GroupBox_Adicionales = value;
				groupBox_Adicionales = this._GroupBox_Adicionales;
				if (groupBox_Adicionales != null)
				{
					groupBox_Adicionales.Enter += value2;
				}
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00100B43 File Offset: 0x000FED43
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00100B50 File Offset: 0x000FED50
		internal virtual Label Label9
		{
			[CompilerGenerated]
			get
			{
				return this._Label9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label9_Click);
				Label label = this._Label9;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label9 = value;
				label = this._Label9;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00100B93 File Offset: 0x000FED93
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00100BA0 File Offset: 0x000FEDA0
		internal virtual Label Label12
		{
			[CompilerGenerated]
			get
			{
				return this._Label12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label12_Click);
				Label label = this._Label12;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label12 = value;
				label = this._Label12;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00100BE3 File Offset: 0x000FEDE3
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00100BF0 File Offset: 0x000FEDF0
		internal virtual Label Label11
		{
			[CompilerGenerated]
			get
			{
				return this._Label11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label11_Click);
				Label label = this._Label11;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label11 = value;
				label = this._Label11;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00100C33 File Offset: 0x000FEE33
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00100C40 File Offset: 0x000FEE40
		internal virtual Label Label10
		{
			[CompilerGenerated]
			get
			{
				return this._Label10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label10_Click);
				Label label = this._Label10;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label10 = value;
				label = this._Label10;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00100C83 File Offset: 0x000FEE83
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00100C90 File Offset: 0x000FEE90
		internal virtual Label Label15
		{
			[CompilerGenerated]
			get
			{
				return this._Label15;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label15_Click);
				Label label = this._Label15;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label15 = value;
				label = this._Label15;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00100CD3 File Offset: 0x000FEED3
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00100CE0 File Offset: 0x000FEEE0
		internal virtual Label Label14
		{
			[CompilerGenerated]
			get
			{
				return this._Label14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label14_Click);
				Label label = this._Label14;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label14 = value;
				label = this._Label14;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00100D23 File Offset: 0x000FEF23
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00100D30 File Offset: 0x000FEF30
		internal virtual Label Label13
		{
			[CompilerGenerated]
			get
			{
				return this._Label13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label13_Click);
				Label label = this._Label13;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label13 = value;
				label = this._Label13;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00100D73 File Offset: 0x000FEF73
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00100D80 File Offset: 0x000FEF80
		internal virtual Label Label16
		{
			[CompilerGenerated]
			get
			{
				return this._Label16;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label16_Click);
				Label label = this._Label16;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label16 = value;
				label = this._Label16;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00100DC3 File Offset: 0x000FEFC3
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00100DD0 File Offset: 0x000FEFD0
		internal virtual Label lblcodigoEmpresa
		{
			[CompilerGenerated]
			get
			{
				return this._lblcodigoEmpresa;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblcodigoEmpresa_Click);
				Label lblcodigoEmpresa = this._lblcodigoEmpresa;
				if (lblcodigoEmpresa != null)
				{
					lblcodigoEmpresa.Click -= value2;
				}
				this._lblcodigoEmpresa = value;
				lblcodigoEmpresa = this._lblcodigoEmpresa;
				if (lblcodigoEmpresa != null)
				{
					lblcodigoEmpresa.Click += value2;
				}
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00100E13 File Offset: 0x000FF013
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00100E20 File Offset: 0x000FF020
		internal virtual Label lblfechaRegistro
		{
			[CompilerGenerated]
			get
			{
				return this._lblfechaRegistro;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblfechaRegistro_Click);
				Label lblfechaRegistro = this._lblfechaRegistro;
				if (lblfechaRegistro != null)
				{
					lblfechaRegistro.Click -= value2;
				}
				this._lblfechaRegistro = value;
				lblfechaRegistro = this._lblfechaRegistro;
				if (lblfechaRegistro != null)
				{
					lblfechaRegistro.Click += value2;
				}
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00100E63 File Offset: 0x000FF063
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00100E70 File Offset: 0x000FF070
		internal virtual Label lblid_licenciajc
		{
			[CompilerGenerated]
			get
			{
				return this._lblid_licenciajc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblid_licenciajc_Click);
				Label lblid_licenciajc = this._lblid_licenciajc;
				if (lblid_licenciajc != null)
				{
					lblid_licenciajc.Click -= value2;
				}
				this._lblid_licenciajc = value;
				lblid_licenciajc = this._lblid_licenciajc;
				if (lblid_licenciajc != null)
				{
					lblid_licenciajc.Click += value2;
				}
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00100EB3 File Offset: 0x000FF0B3
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00100EC0 File Offset: 0x000FF0C0
		internal virtual PictureBox PictureBoxError
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBoxError;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBoxError_Click);
				PictureBox pictureBoxError = this._PictureBoxError;
				if (pictureBoxError != null)
				{
					pictureBoxError.Click -= value2;
				}
				this._PictureBoxError = value;
				pictureBoxError = this._PictureBoxError;
				if (pictureBoxError != null)
				{
					pictureBoxError.Click += value2;
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00100F03 File Offset: 0x000FF103
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00100F10 File Offset: 0x000FF110
		internal virtual PictureBox PictureBoxCorrecto
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBoxCorrecto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBoxCorrecto_Click);
				PictureBox pictureBoxCorrecto = this._PictureBoxCorrecto;
				if (pictureBoxCorrecto != null)
				{
					pictureBoxCorrecto.Click -= value2;
				}
				this._PictureBoxCorrecto = value;
				pictureBoxCorrecto = this._PictureBoxCorrecto;
				if (pictureBoxCorrecto != null)
				{
					pictureBoxCorrecto.Click += value2;
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00100F53 File Offset: 0x000FF153
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00100F60 File Offset: 0x000FF160
		internal virtual Label lblbombresr
		{
			[CompilerGenerated]
			get
			{
				return this._lblbombresr;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblbombresr_Click);
				Label lblbombresr = this._lblbombresr;
				if (lblbombresr != null)
				{
					lblbombresr.Click -= value2;
				}
				this._lblbombresr = value;
				lblbombresr = this._lblbombresr;
				if (lblbombresr != null)
				{
					lblbombresr.Click += value2;
				}
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00100FA3 File Offset: 0x000FF1A3
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00100FB0 File Offset: 0x000FF1B0
		internal virtual Label lblrfc
		{
			[CompilerGenerated]
			get
			{
				return this._lblrfc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblrfc_Click);
				Label lblrfc = this._lblrfc;
				if (lblrfc != null)
				{
					lblrfc.Click -= value2;
				}
				this._lblrfc = value;
				lblrfc = this._lblrfc;
				if (lblrfc != null)
				{
					lblrfc.Click += value2;
				}
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00100FF3 File Offset: 0x000FF1F3
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00101000 File Offset: 0x000FF200
		internal virtual PictureBox PictureBoxModOK
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBoxModOK;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBoxModOK_Click);
				PictureBox pictureBoxModOK = this._PictureBoxModOK;
				if (pictureBoxModOK != null)
				{
					pictureBoxModOK.Click -= value2;
				}
				this._PictureBoxModOK = value;
				pictureBoxModOK = this._PictureBoxModOK;
				if (pictureBoxModOK != null)
				{
					pictureBoxModOK.Click += value2;
				}
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00101043 File Offset: 0x000FF243
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00101050 File Offset: 0x000FF250
		internal virtual PictureBox PictureBoxModCancelar
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBoxModCancelar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBoxModCancelar_Click);
				PictureBox pictureBoxModCancelar = this._PictureBoxModCancelar;
				if (pictureBoxModCancelar != null)
				{
					pictureBoxModCancelar.Click -= value2;
				}
				this._PictureBoxModCancelar = value;
				pictureBoxModCancelar = this._PictureBoxModCancelar;
				if (pictureBoxModCancelar != null)
				{
					pictureBoxModCancelar.Click += value2;
				}
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00101093 File Offset: 0x000FF293
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x001010A0 File Offset: 0x000FF2A0
		internal virtual Panel PanelDatosLicencia
		{
			[CompilerGenerated]
			get
			{
				return this._PanelDatosLicencia;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PanelDatosLicencia_Paint);
				Panel panelDatosLicencia = this._PanelDatosLicencia;
				if (panelDatosLicencia != null)
				{
					panelDatosLicencia.Paint -= value2;
				}
				this._PanelDatosLicencia = value;
				panelDatosLicencia = this._PanelDatosLicencia;
				if (panelDatosLicencia != null)
				{
					panelDatosLicencia.Paint += value2;
				}
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x001010E3 File Offset: 0x000FF2E3
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x001010F0 File Offset: 0x000FF2F0
		internal virtual Label Label22
		{
			[CompilerGenerated]
			get
			{
				return this._Label22;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label22_Click);
				Label label = this._Label22;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label22 = value;
				label = this._Label22;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00101133 File Offset: 0x000FF333
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00101140 File Offset: 0x000FF340
		internal virtual Label Label21
		{
			[CompilerGenerated]
			get
			{
				return this._Label21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label21_Click);
				Label label = this._Label21;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label21 = value;
				label = this._Label21;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00101183 File Offset: 0x000FF383
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00101190 File Offset: 0x000FF390
		internal virtual Label Label20
		{
			[CompilerGenerated]
			get
			{
				return this._Label20;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label20_Click);
				Label label = this._Label20;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label20 = value;
				label = this._Label20;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x001011D3 File Offset: 0x000FF3D3
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x001011E0 File Offset: 0x000FF3E0
		internal virtual Label Label19
		{
			[CompilerGenerated]
			get
			{
				return this._Label19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label19_Click);
				Label label = this._Label19;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label19 = value;
				label = this._Label19;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00101223 File Offset: 0x000FF423
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00101230 File Offset: 0x000FF430
		internal virtual Label Label18
		{
			[CompilerGenerated]
			get
			{
				return this._Label18;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label18_Click);
				Label label = this._Label18;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label18 = value;
				label = this._Label18;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00101273 File Offset: 0x000FF473
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00101280 File Offset: 0x000FF480
		internal virtual Label Label17
		{
			[CompilerGenerated]
			get
			{
				return this._Label17;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label17_Click);
				Label label = this._Label17;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label17 = value;
				label = this._Label17;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x001012C3 File Offset: 0x000FF4C3
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x001012D0 File Offset: 0x000FF4D0
		internal virtual Panel Panel2
		{
			[CompilerGenerated]
			get
			{
				return this._Panel2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel2_Paint);
				Panel panel = this._Panel2;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel2 = value;
				panel = this._Panel2;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00101313 File Offset: 0x000FF513
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x00101320 File Offset: 0x000FF520
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

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00101363 File Offset: 0x000FF563
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x00101370 File Offset: 0x000FF570
		internal virtual TextBox txtLicenciaID
		{
			[CompilerGenerated]
			get
			{
				return this._txtLicenciaID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtLicenciaID_TextChanged);
				TextBox txtLicenciaID = this._txtLicenciaID;
				if (txtLicenciaID != null)
				{
					txtLicenciaID.TextChanged -= value2;
				}
				this._txtLicenciaID = value;
				txtLicenciaID = this._txtLicenciaID;
				if (txtLicenciaID != null)
				{
					txtLicenciaID.TextChanged += value2;
				}
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x001013B3 File Offset: 0x000FF5B3
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x001013C0 File Offset: 0x000FF5C0
		internal virtual TextBox txtLicenciaCliente
		{
			[CompilerGenerated]
			get
			{
				return this._txtLicenciaCliente;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtLicenciaCliente_TextChanged);
				TextBox txtLicenciaCliente = this._txtLicenciaCliente;
				if (txtLicenciaCliente != null)
				{
					txtLicenciaCliente.TextChanged -= value2;
				}
				this._txtLicenciaCliente = value;
				txtLicenciaCliente = this._txtLicenciaCliente;
				if (txtLicenciaCliente != null)
				{
					txtLicenciaCliente.TextChanged += value2;
				}
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00101403 File Offset: 0x000FF603
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00101410 File Offset: 0x000FF610
		internal virtual TextBox txtLicenciaServidor
		{
			[CompilerGenerated]
			get
			{
				return this._txtLicenciaServidor;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtLicenciaServidor_TextChanged);
				TextBox txtLicenciaServidor = this._txtLicenciaServidor;
				if (txtLicenciaServidor != null)
				{
					txtLicenciaServidor.TextChanged -= value2;
				}
				this._txtLicenciaServidor = value;
				txtLicenciaServidor = this._txtLicenciaServidor;
				if (txtLicenciaServidor != null)
				{
					txtLicenciaServidor.TextChanged += value2;
				}
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00101453 File Offset: 0x000FF653
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x00101460 File Offset: 0x000FF660
		internal virtual TextBox txtCodigoEmpresa
		{
			[CompilerGenerated]
			get
			{
				return this._txtCodigoEmpresa;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtCodigoEmpresa_TextChanged);
				TextBox txtCodigoEmpresa = this._txtCodigoEmpresa;
				if (txtCodigoEmpresa != null)
				{
					txtCodigoEmpresa.TextChanged -= value2;
				}
				this._txtCodigoEmpresa = value;
				txtCodigoEmpresa = this._txtCodigoEmpresa;
				if (txtCodigoEmpresa != null)
				{
					txtCodigoEmpresa.TextChanged += value2;
				}
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x001014A3 File Offset: 0x000FF6A3
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x001014B0 File Offset: 0x000FF6B0
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x001014F3 File Offset: 0x000FF6F3
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x00101500 File Offset: 0x000FF700
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
				CheckBox checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox2 = value;
				checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x00101543 File Offset: 0x000FF743
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x0010154D File Offset: 0x000FF74D
		internal virtual GroupBox GroupBoxEstacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00101556 File Offset: 0x000FF756
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00101560 File Offset: 0x000FF760
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00101569 File Offset: 0x000FF769
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00101573 File Offset: 0x000FF773
		internal virtual ComboBox cboBaseDatos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0010157C File Offset: 0x000FF77C
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00101588 File Offset: 0x000FF788
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x001015CB File Offset: 0x000FF7CB
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x001015D5 File Offset: 0x000FF7D5
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x001015DE File Offset: 0x000FF7DE
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x001015E8 File Offset: 0x000FF7E8
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x001015F1 File Offset: 0x000FF7F1
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x001015FB File Offset: 0x000FF7FB
		internal virtual TextBox txtNombreArchivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00101604 File Offset: 0x000FF804
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x0010160E File Offset: 0x000FF80E
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06001016 RID: 4118 RVA: 0x00101618 File Offset: 0x000FF818
		private void frmServConfig_Load(object sender, EventArgs e)
		{
			this.btnGuardarConexion.Enabled = false;
			this.txtNomServ.Enabled = true;
			this.GroupBoxBase_Modulo.Enabled = false;
			this.GroupBox_Adicionales.Enabled = false;
			DateTime now = DateTime.Now;
			this.PanelDatosLicencia.Visible = false;
			this.lblfechaRegistro.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
			this.PictureBox2.Visible = false;
			this.PictureBox3.Visible = false;
			this.cboBaseDatos.Enabled = false;
			this.CheckBox1.Enabled = false;
			this.CheckBox2.Enabled = false;
			this.GroupBoxBase_Modulo.Enabled = false;
			this.GroupBoxEstacion.Enabled = false;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x001016E0 File Offset: 0x000FF8E0
		private void btnProbarConexion_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			Tools.strConexionServerLocal = string.Concat(new string[]
			{
				"Server = ",
				this.txtNomServ.Text,
				"\\",
				this.txtInstancia.Text,
				";Min Pool Size=0;Max Pool Size=10024;Pooling=true;Database=",
				this.txtBaseDatos.Text,
				";User Id=",
				this.txtInicioSesion.Text,
				";Password=",
				this.txtContrasena.Text,
				";Connect Timeout=10;"
			});
			string strConexionServerLocal = Tools.strConexionServerLocal;
			Tools.strFile = Tools.strConexionServerLocal;
			bool flag = Conversions.ToBoolean(Tools.ConexionLocal());
			if (flag)
			{
				Interaction.MsgBox(("Conexión EXITOSA a la base de datos " + this.txtBaseDatos.Text) ?? "", MsgBoxStyle.OkOnly, "Conexión");
				this.PictureBoxCorrecto.Visible = true;
				this.PictureBoxError.Visible = false;
				this.GroupBoxBase_Modulo.Enabled = true;
				this.GroupBox_Adicionales.Enabled = true;
				this.txtID.Enabled = false;
				this.CheckBox1.Enabled = true;
				this.CheckBox2.Enabled = true;
				string query = "SELECT \r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) as 'Codigo Empresa'";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag2 = sqlDataReader.Read();
				if (flag2)
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					this.lblid_licenciajc.Text = text;
					this.txtID.Text = this.lblid_licenciajc.Text;
				}
				query = "SELECT \r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) as 'Codigo Empresa'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag3 = sqlDataReader.Read();
				if (flag3)
				{
					string text2 = Conversions.ToString(sqlDataReader[0]);
					this.txtNombreArchivo.Text = text2.ToString();
				}
				query = "SELECT \r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) as 'Codigo Empresa'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag4 = sqlDataReader.Read();
				if (flag4)
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					this.lblcodigoEmpresa.Text = text3;
				}
				query = "SELECT nombre from Empresas";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag5 = sqlDataReader.Read();
				if (flag5)
				{
					string text4 = Conversions.ToString(sqlDataReader[0]);
					this.lblbombresr.Text = Tools.Encriptar(text4.ToString().Trim());
				}
				query = "SELECT rfc FROM Empresas";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				bool flag6 = sqlDataReader.Read();
				if (flag6)
				{
					string text5 = Conversions.ToString(sqlDataReader[0]);
					this.lblrfc.Text = Tools.Encriptar(text5.ToString().Trim());
				}
				this.Button1.Enabled = false;
			}
			else
			{
				this.PictureBoxCorrecto.Visible = false;
				this.PictureBoxError.Visible = true;
				this.btnGuardarConexion.Enabled = false;
				Tools.strConexionServerLocal = strConexionServerLocal;
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x001019D7 File Offset: 0x000FFBD7
		private void Button1_Click(object sender, EventArgs e)
		{
			Tools.setServer();
			this.txtNomServ.Text = Tools.strServerLocal;
			this.txtNomServ.Enabled = true;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00101A00 File Offset: 0x000FFC00
		private void btnGuardarConexion_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtNombreArchivo.Text;
			DateTime now = DateTime.Now;
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				Conn_Local.strConexionServerLocal_Local_Modulo_DBO = string.Concat(new string[]
				{
					"Server = ",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Min Pool Size=0;Max Pool Size=10024;Pooling=true;Database=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				});
			}
			bool checked2 = this.CheckBox2.Checked;
			if (checked2)
			{
				Conn_Local.strConexionServerLocal_Local_Modulo_DBO = string.Concat(new string[]
				{
					"Server = ",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Min Pool Size=0;Max Pool Size=10024;Pooling=true;Database=",
					this.cboBaseDatos.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				});
			}
			bool flag = Operators.CompareString(this.txtCte.Text, "", false) == 0 & Operators.CompareString(this.txtID.Text, "", false) == 0;
			if (flag)
			{
				Interaction.MsgBox("Los campos Cliente e ID no pueden quedar vacios!", MsgBoxStyle.OkOnly, null);
			}
			bool flag2 = Operators.CompareString(this.txtCte.Text, "", false) == 0;
			if (flag2)
			{
				Interaction.MsgBox("El campo Cliente no pueden quedar vacio!", MsgBoxStyle.OkOnly, null);
			}
			bool flag3 = Operators.CompareString(this.txtID.Text, "", false) == 0;
			if (flag3)
			{
				Interaction.MsgBox("El campo ID no pueden quedar vacio!", MsgBoxStyle.OkOnly, null);
			}
			bool flag4 = Operators.CompareString(this.txtCte.Text, "", false) != 0 & Operators.CompareString(this.txtID.Text, "", false) != 0;
			checked
			{
				if (flag4)
				{
					string query_conn = "SELECT a from H";
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							query_conn = "SELECT am from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
							bool hasRows2 = sqlDataReader.HasRows;
							if (hasRows2)
							{
								while (sqlDataReader.Read())
								{
									bool flag5 = sqlDataReader[0] == DBNull.Value;
									if (flag5)
									{
										try
										{
											query_conn = "Update H set am = '" + Tools.Encriptar(this.txtCte.Text.Trim()) + "'";
											sqlQuery_Conn.execQuery_conn(query_conn);
										}
										catch (Exception ex)
										{
										}
									}
								}
							}
							Interaction.MsgBox("Estacion configurada exitosamente,el Modulo se cerrara automaticamenete\r\nes necesario ejecutarlo nuevamente!", MsgBoxStyle.OkOnly, null);
							string path = "d_" + text + ".txt";
							string[] array = new string[]
							{
								Tools.Encriptar(this.txtCte.Text + ";#####;" + Conn_Local.strConexionServerLocal_Local_Modulo_DBO + "######;").ToString().Trim(),
								Tools.Encriptar(Tools.strConexionServerLocal).ToString().Trim()
							};
							StreamWriter streamWriter = new StreamWriter(path);
							int num = 0;
							do
							{
								streamWriter.WriteLine(array[num]);
								num++;
							}
							while (num <= 1);
							streamWriter.Close();
							base.Close();
						}
					}
					else
					{
						string text2 = "0";
						string text3 = "1";
						string text4 = "1";
						string text5 = "1";
						string text6 = "0";
						string text7 = "1";
						string text8 = "1";
						string text9 = "0";
						string text10 = "1";
						string text11 = "2023";
						string text12 = "0";
						string text13 = "1";
						string text14 = "1";
						string text15 = "0";
						query_conn = string.Concat(new string[]
						{
							"insert into H (a,g,h,n,i,o,s,t,u,v,w,y,z,aa,ab,ac,ad,ae,af,ag,ah,ai,aj,ak,al,am,an) values ('",
							Tools.Encriptar(text2.ToString().Trim()),
							"','",
							Tools.Encriptar(text3.ToString().Trim()),
							"','",
							Tools.Encriptar(text4.ToString().Trim()),
							"','",
							Tools.Encriptar(text5.ToString().Trim()),
							"','",
							Tools.Encriptar(text6.ToString().Trim()),
							"','",
							Tools.Encriptar(text7.ToString().Trim()),
							"','",
							Tools.Encriptar(this.txtNomServ.Text.Trim()),
							"','",
							Tools.Encriptar(this.txtID.Text.Trim()),
							"','','','','','','",
							Tools.Encriptar(text8.ToString().Trim()),
							"','",
							Tools.Encriptar(text9.ToString().Trim()),
							"','",
							Tools.Encriptar(text10.ToString().Trim()),
							"','",
							Tools.Encriptar(text11.ToString().Trim()),
							"','",
							Tools.Encriptar(text12.ToString().Trim()),
							"','','",
							Tools.Encriptar(text13.ToString().Trim()),
							"','",
							Tools.Encriptar(text14.ToString().Trim()),
							"','",
							Tools.Encriptar(this.lblcodigoEmpresa.Text.Trim()),
							"' , '",
							this.lblbombresr.Text,
							"' , '",
							this.lblrfc.Text,
							"','','",
							Tools.Encriptar(this.txtCte.Text.Trim()),
							"','",
							Tools.Encriptar(text15.ToString().Trim()),
							"')"
						});
						sqlQuery_Conn.execQuery_conn(query_conn);
						query_conn = "INSERT INTO BB (a)\r\n                            values('')";
						sqlQuery_Conn.execQuery_conn(query_conn);
						query_conn = "Insert Into C Values ( '" + Tools.Encriptar(Tools.strConexionServerLocal.ToString().Trim()) + "')";
						sqlQuery_Conn.execQuery_conn(query_conn);
						string path2 = "d_" + text + ".txt";
						string[] array2 = new string[]
						{
							Tools.Encriptar(this.txtCte.Text + ";#####;" + Conn_Local.strConexionServerLocal_Local_Modulo_DBO + "######;").ToString().Trim(),
							Tools.Encriptar(Tools.strConexionServerLocal).ToString().Trim()
						};
						StreamWriter streamWriter2 = new StreamWriter(path2);
						int num2 = 0;
						do
						{
							streamWriter2.WriteLine(array2[num2]);
							num2++;
						}
						while (num2 <= 1);
						streamWriter2.Close();
						this.Panel1.Visible = false;
						this.PanelDatosLicencia.Visible = true;
						this.txtLicenciaServidor.Text = this.txtNomServ.Text;
						this.txtLicenciaCliente.Text = this.txtCte.Text;
						this.txtLicenciaID.Text = this.txtID.Text;
						this.txtCodigoEmpresa.Text = this.lblcodigoEmpresa.Text;
						this.txtLicenciaServidor.Enabled = true;
						this.txtLicenciaCliente.Enabled = true;
						this.txtLicenciaID.Enabled = true;
						this.txtCodigoEmpresa.Enabled = true;
					}
					sqlDataReader.Close();
				}
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00102220 File Offset: 0x00100420
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
			MyProject.Forms.main.BtnServerConfig.BackColor = SystemColors.InactiveCaption;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00102244 File Offset: 0x00100444
		private void btnCrearDBO_Click(object sender, EventArgs e)
		{
			Conn_Local.strConexionServerLocal_Local_Modulo_DBO = string.Concat(new string[]
			{
				"Server = ",
				this.txtNomServ.Text,
				"\\",
				this.txtInstancia.Text,
				";Min Pool Size=0;Max Pool Size=10024;Pooling=True;Database=",
				this.txtbaseDatos_Modulo.Text,
				";User Id=",
				this.txtInicioSesion.Text,
				";Password=",
				this.txtContrasena.Text,
				";Connect Timeout=10;"
			});
			SqlConnection connection = new SqlConnection(string.Concat(new string[]
			{
				"Data Source=",
				this.txtNomServ.Text,
				" \\",
				this.txtInstancia.Text,
				";Initial Catalog=master;User Id=",
				this.txtInicioSesion.Text,
				";Password=",
				this.txtContrasena.Text,
				";Connect Timeout=10;"
			}));
			string cmdText = ("CREATE database " + this.txtbaseDatos_Modulo.Text) ?? "";
			SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
			try
			{
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				Interaction.MsgBox("La base de datos " + this.txtbaseDatos_Modulo.Text + " se creo correctamente!! ", MsgBoxStyle.OkOnly, null);
				this.PictureBoxModCancelar.Visible = false;
				this.PictureBoxModOK.Visible = true;
				sqlCommand.Connection.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("La base de datos " + this.txtbaseDatos_Modulo.Text + " ya existe en el servidor , verifica el nombre o intenta con otro nombre! ", MsgBoxStyle.OkOnly, null);
				this.PictureBoxModCancelar.Visible = true;
				this.PictureBoxModOK.Visible = false;
				return;
			}
			try
			{
				SqlConnection connection2 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					" \\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText2 = "If OBJECT_ID('D', 'U') IS NOT NULL  \r\n                        Select * from D \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('D', 'U') IS NULL \r\n\r\n                       CREATE TABLE [dbo].[D](\r\n\t                    [a] [int] IDENTITY(1,1) NOT NULL,\r\n\t                    [b] [varchar](200) NULL,\r\n\t                    [c] [varchar](200) NULL,\r\n\t                    [d] [varchar](200) NULL,\r\n\t                    [e] [varchar](200) NULL,\r\n\t                    [f] [varchar](200) NULL,\r\n\t                    [g] [varchar](200) NULL)";
				sqlCommand = new SqlCommand(cmdText2, connection2);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox("La tabla D ya existe en la base de datos!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection3 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText3 = "IF OBJECT_ID('H', 'U') IS NOT NULL  \r\n                        Select * from H \r\n\t\t\r\n                        IF OBJECT_ID('H', 'U') IS NULL \r\n\r\n          CREATE TABLE [dbo].[H](\r\n\t[a] [varchar](200) NULL,\r\n\t[b] [varchar](200) NULL,\r\n\t[c] [varchar](200) NULL,\r\n\t[d] [varchar](200) NULL,\r\n\t[e] [varchar](200) NULL,\r\n\t[f] [varchar](200) NULL,\r\n\t[g] [varchar](200) NULL,\r\n\t[h] [varchar](200) NULL,\r\n\t[i] [varchar](200) NULL,\r\n\t[j] [varchar](200) NULL,\r\n\t[k] [varchar](200) NULL,\r\n\t[l] [varchar](200) NULL,\r\n\t[m] [varchar](200) NULL,\r\n\t[n] [varchar](200) NULL,\r\n\t[o] [varchar](200) NULL,\r\n\t[p] [varchar](200) NULL,\r\n\t[q] [varchar](200) NULL,\r\n\t[r] [varchar](200) NULL,\r\n\t[s] [varchar](200) NULL DEFAULT ((0)),\r\n\t[t] [varchar](300) NULL,\r\n\t[u] [varchar](200) NULL,\r\n\t[v] [varchar](200) NULL,\r\n\t[w] [varchar](200) NULL,\r\n\t[x] [varchar](200) NULL,\r\n\t[y] [varchar](200) NULL,\r\n\t[z] [varchar](200) NULL,\r\n\t[aa] [varchar](200) NULL,\r\n\t[ab] [varchar](200) NULL,\r\n\t[ac] [varchar](200) NULL,\r\n\t[ad] [varchar](200) NULL,\r\n\t[ae] [varchar](200) NULL,\r\n\t[af] [varchar](200) NULL,\r\n\t[ag] [varchar](200) NULL,\r\n\t[ah] [varchar](200) NULL,\r\n\t[ai] [varchar](200) NULL,\r\n\t[aj] [varchar](300) NULL,\r\n\t[ak] [varchar](300) NULL,\r\n    [al] [varchar](300) NULL,\r\n    [am] [varchar](300) NULL,\r\n    [an] [varchar](300) NULL)";
				sqlCommand = new SqlCommand(cmdText3, connection3);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex3)
			{
				Interaction.MsgBox("La tabla H ya existe en la base de datos", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection4 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					" \\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText4 = "IF OBJECT_ID('G', 'U') IS NOT NULL  \r\n                        Select * from G   \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('G', 'U') IS NULL \r\n                       CREATE TABLE [dbo].[G](\r\n\t                    [a] [varchar](250) NOT NULL,\r\n\t                    [b] [varchar](50) NOT NULL,\r\n\t                    [c] [varchar](50) NOT NULL)";
				sqlCommand = new SqlCommand(cmdText4, connection4);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex4)
			{
				Interaction.MsgBox("La tabla G no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection5 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText5 = "If OBJECT_ID('I', 'U') IS NOT NULL  \r\n                        Select * From I \r\n\r\n\r\n\r\n                        If OBJECT_ID('I', 'U') IS NULL \r\n\r\n                  CREATE TABLE [dbo].[I](\r\n\t[id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[a] [datetime] NULL,\r\n\t[b] [datetime] NULL,\r\n\t[c] [datetime] NULL,\r\n\t[d] [varchar](50) NULL,\r\n\t[e] [varchar](50) NULL,\r\n\t[f] [varchar](50) NULL,\r\n\t[g] [varchar](50) NULL,\r\n\t[h] [varchar](50) NULL,\r\n\t[i] [varchar](50) NULL,\r\n\t[j] [varchar](50) NULL,\r\n\t[k] [varchar](50) NULL,\r\n\t[l] [varchar](50) NULL,\r\n\t[m] [varchar](50) NULL,\r\n\t[n] [varchar](50) NULL,\r\n\t[o] [varchar](50) NULL,\r\n\t[p] [varchar](50) NULL,\r\n\t[q] [varchar](50) NULL,\r\n\t[r] [varchar](50) NULL,\r\n\t[s] [varchar](50) NULL,\r\n\t[t] [varchar](50) NULL,\r\n\t[u] [varchar](50) NULL,\r\n\t[w] [varchar](100) NULL,\r\n    [x] [varchar](100) NULL)";
				sqlCommand = new SqlCommand(cmdText5, connection5);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex5)
			{
				Interaction.MsgBox("La tabla FP no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection6 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText6 = "IF OBJECT_ID('K', 'U') IS NOT NULL  \r\n                        Select * from K  \r\n\r\n\r\n             IF OBJECT_ID('K', 'U') IS NULL \r\n\r\n           CREATE TABLE [dbo].[K](\r\n\t[a] [varchar](100) NULL,\r\n\t[b] [varchar](100) NULL,\r\n\t[c] [varchar](100) NULL,\r\n\t[d] [varchar](100) NULL,\r\n\t[e] [varchar](100) NULL,\r\n\t[f] [varchar](100) NULL,\r\n\t[g] [varchar](100) NULL,\r\n\t[h] [varchar](100) NULL,\r\n\t[i] [varchar](100) NULL,\r\n\t[j] [varchar](100) NULL,\r\n\t[k] [varchar](50) NULL,\r\n\t[l] [varchar](50) NULL,\r\n\t[m] [datetime] NULL)";
				sqlCommand = new SqlCommand(cmdText6, connection6);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex6)
			{
				Interaction.MsgBox("La tabla VentasModulo no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection7 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText7 = "IF OBJECT_ID('J', 'U') IS NOT NULL  \r\n                        Select * from J  \r\n\r\n                            IF OBJECT_ID('J', 'U') IS NULL \r\n\r\n\r\n\r\n\r\n                           CREATE TABLE [dbo].[J](\r\n\t[a] [varchar](50) NULL,\r\n\t[b] [varchar](250) NULL,\r\n\t[c] [varchar](50) NULL,\r\n\t[d] [varchar](50) NULL,\r\n\t[e] [datetime] NULL)";
				sqlCommand = new SqlCommand(cmdText7, connection7);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex7)
			{
				Interaction.MsgBox("La tabla Pm no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection8 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText8 = "IF OBJECT_ID('AA', 'U') IS NOT NULL  \r\n                        Select * from Aa  \r\n\r\n                            IF OBJECT_ID('AA', 'U') IS NULL \r\n\r\n\r\n                          CREATE TABLE [dbo].[AA](\r\n\t                        [a] [varchar](50) NULL,\r\n\t                        [b] [varchar](250) NULL,\r\n\t                        [c] [money] NULL,\r\n\t                        [d] [numeric](3, 0) NULL,\r\n\t                        [e] [datetime] NULL)";
				sqlCommand = new SqlCommand(cmdText8, connection8);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex8)
			{
				Interaction.MsgBox("La tabla Aa no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection9 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText9 = "IF OBJECT_ID('E', 'U') IS NOT NULL  \r\n                        Select * from E  \r\n\r\n                            IF OBJECT_ID('E', 'U') IS NULL \r\n\r\n\r\n\r\n                         CREATE TABLE [dbo].[E](\r\n\t[a] [int] IDENTITY(1,1) NOT NULL,\r\n\t[b] [varchar](200) NULL,\r\n\t[c] [varchar](200) NULL,\r\n\t[d] [varchar](200) NULL,\r\n\t[e] [varchar](200) NULL,\r\n\t[f] [varchar](200) NULL,\r\n\t[g] [varchar](200) NULL,\r\n\t[h] [varchar](200) NULL,\r\n\t[i] [varchar](200) NULL,\r\n\t[j] [varchar](200) NULL,\r\n\t[k] [varchar](200) NULL,\r\n\t[l] [varchar](200) NULL,\r\n\t[m] [varchar](200) NULL,\r\n\t[n] [varchar](200) NULL,\r\n\t[o] [varchar](200) NULL,\r\n\t[p] [varchar](200) NULL,\r\n\t[q] [varchar](200) NULL,\r\n\t[r] [varchar](200) NULL,\r\n\t[s] [varchar](200) NULL,\r\n\t[t] [varchar](200) NULL,\r\n\t[u] [varchar](200) NULL,\r\n\t[w] [varchar](200) NULL,\r\n\t[x] [varchar](200) NULL)";
				sqlCommand = new SqlCommand(cmdText9, connection9);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex9)
			{
				Interaction.MsgBox("La tabla E no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection10 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText10 = "IF OBJECT_ID('BB', 'U') IS NOT NULL  \r\n                        Select * from Bb   \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('BB', 'U') IS NULL \r\n\r\n                       CREATE TABLE [dbo].[BB](\r\n\t[a] [varchar](100) NULL,\r\n\t[b] [varchar](100) NULL,\r\n\t[c] [varchar](100) NULL,\r\n\t[d] [varchar](100) NULL,\r\n\t[e] [varchar](100) NULL,\r\n\t[f] [varchar](100) NULL,\r\n\t[g] [varchar](100) NULL,\r\n\t[h] [varchar](100) NULL,\r\n\t[i] [varchar](100) NULL,\r\n\t[j] [varchar](100) NULL,\r\n\t[k] [varchar](100) NULL,\r\n\t[l] [varchar](100) NULL,\r\n\t[m] [varchar](100) NULL,\r\n\t[n] [varchar](100) NULL,\r\n\t[o] [varchar](100) NULL,\r\n\t[p] [varchar](100) NULL)";
				sqlCommand = new SqlCommand(cmdText10, connection10);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex10)
			{
				Interaction.MsgBox("La tabla Bb no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection11 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText11 = "If OBJECT_ID('F', 'U') IS NOT NULL  \r\n                        Select * from F   \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('F', 'U') IS NULL \r\n\r\n                        CREATE TABLE [dbo].[F](\r\n\t                    [a] [varchar](50) NULL,\r\n\t                    [b] [varchar](50) NULL,\r\n\t                    [c] [varchar](50) NULL,\r\n\t                    [d] [varchar](50) NULL,\r\n\t                    [e] [money] NULL,\r\n\t                    [f] [varchar](50) NULL,\r\n\t                    [g] [money] NULL,\r\n                        [h] [money] NULL,\r\n                        [i] [money] NULL,\r\n                        [j] [int] NOT NULL DEFAULT ((0)),\r\n                        [k] [int] NOT NULL DEFAULT ((0)))";
				sqlCommand = new SqlCommand(cmdText11, connection11);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex11)
			{
				Interaction.MsgBox("La tabla F no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection12 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText12 = "If OBJECT_ID('C', 'U') IS NOT NULL  \r\n                        Select * from C   \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('C', 'U') IS NULL \r\n\r\n                        CREATE TABLE [dbo].[C](\r\n\t                    [a] [varchar](1000) NULL)";
				sqlCommand = new SqlCommand(cmdText12, connection12);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex12)
			{
				Interaction.MsgBox("La tabla C no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection13 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText13 = "If OBJECT_ID('L', 'U') IS NOT NULL  \r\n                        Select * from L   \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('L', 'U') IS NULL \r\n\r\n                      CREATE TABLE [dbo].[L](\r\n\t                  [a] [varchar](200) NULL,\r\n\t                  [b] [varchar](200) NULL)";
				sqlCommand = new SqlCommand(cmdText13, connection13);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex13)
			{
				Interaction.MsgBox("La tabla L no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection14 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText14 = "If OBJECT_ID('M', 'U') IS NOT NULL  \r\n                        Select * from M  \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('M', 'U') IS NULL \r\n\r\n                      CREATE TABLE [dbo].[M](\r\n\t[a] [varchar](100) NULL,\r\n\t[b] [varchar](100) NULL,\r\n\t[c] [varchar](100) NULL,\r\n\t[d] [varchar](100) NULL,\r\n\t[e] [varchar](100) NULL,\r\n\t[f] [varchar](100) NULL,\r\n\t[g] [varchar](100) NULL,\r\n\t[h] [varchar](100) NULL,\r\n\t[i] [varchar](100) NULL,\r\n\t[j] [varchar](100) NULL,\r\n\t[k] [varchar](100) NULL,\r\n\t[l] [varchar](100) NULL,\r\n\t[m] [varchar](100) NULL,\r\n\t[n] [varchar](100) NULL,\r\n\t[o] [varchar](100) NULL,\r\n\t[p] [varchar](100) NULL,\r\n\t[q] [varchar](100) NULL,\r\n\t[r] [varchar](100) NULL,\r\n\t[s] [varchar](100) NULL,\r\n\t[t] [varchar](100) NULL,\r\n\t[u] [varchar](100) NULL,\r\n\t[v] [varchar](100) NULL,\r\n\t[w] [varchar](100) NULL,\r\n\t[x] [varchar](100) NULL,\r\n\t[y] [varchar](100) NULL,\r\n\t[z] [varchar](100) NULL,\r\n\t[aa] [varchar](100) NULL)";
				sqlCommand = new SqlCommand(cmdText14, connection14);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex14)
			{
				Interaction.MsgBox("La tabla M no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection15 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText15 = "If OBJECT_ID('FF', 'U') IS NOT NULL  \r\n                        Select * from FF   \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('FF', 'U') IS NULL \r\nCREATE TABLE [dbo].[FF](\r\n\t[a] [bigint] NULL,\r\n\t[b] [numeric](5, 0) NULL,\r\n\t[c] [varchar](8) NULL,\r\n\t[d] [numeric](14, 6) NULL,\r\n\t[e] [varchar](15) NULL,\r\n\t[f] [numeric](6, 2) NULL,\r\n\t[g] [money] NULL,\r\n\t[h] [numeric](5, 2) NULL,\r\n\t[i] [numeric](5, 2) NULL,\r\n\t[j] [numeric](5, 2) NULL,\r\n\t[k] [money] NULL,\r\n\t[l] [varchar](20) NULL,\r\n\t[m] [datetime] NULL,\r\n\t[n] [bit] NULL DEFAULT ((0)),\r\n\t[o] [numeric](1, 0) NULL,\r\n\t[p] [varchar](254) NULL,\r\n\t[q] [varchar](40) NULL,\r\n\t[r] [varchar](15) NULL,\r\n\t[s] [varchar](60) NULL,\r\n\t[t] [varchar](5) NULL,\r\n\t[u] [datetime] NULL,\r\n\t[w] [varchar](15) NULL,\r\n\t[x] [bit] NULL  DEFAULT ((0)),\r\n\t[y] [money] NULL,\r\n\t[z] [bit] NULL DEFAULT ((0)),\r\n\t[aa] [varchar](4) NULL,\r\n\t[bb] [varchar](1) NULL,\r\n\t[cc] [numeric](1, 0)   DEFAULT ((0)),\r\n\t[dd] [varchar](5) NULL,\r\n\t[ee] [varchar](16) NULL,\r\n\t[ff] [numeric](1, 0)  DEFAULT ((0)),\r\n\t[gg] [varchar](100) NULL,\r\n\t[hh] [datetime] NULL,\r\n\t[ii] [varchar](4) NULL,\r\n\t[jj] [int] NOT NULL DEFAULT ((1)),\r\n\t[kk] [bigint] NULL,\r\n\t[ll] [bit] NULL,\r\n\t[mm] [bit] NOT NULL DEFAULT ((0)),\r\n\t[nn] [int] NOT NULL DEFAULT ((-1)),\r\n\t[oo] [int] NOT NULL DEFAULT ('-1'),\r\n\t[pp] [numeric](7, 5) NOT NULL DEFAULT ('-1'),\r\n\t[qq] [numeric](7, 5) NOT NULL DEFAULT ('-1'),\r\n\t[rr] [bigint] NOT NULL DEFAULT ((0)),\r\n\t[ss] [int] NULL,\r\n\t[tt] [money] NULL,\r\n\t[uu] [money] NOT NULL DEFAULT ((0)),\r\n\t[ww] [varchar](50) NOT NULL DEFAULT (''),\r\n\t[xx] [varchar](50) NOT NULL DEFAULT (''),\r\n\t[yy] [money] NOT NULL DEFAULT ((0)),\r\n\t[zz] [varchar](250) NULL)";
				sqlCommand = new SqlCommand(cmdText15, connection15);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex15)
			{
				Interaction.MsgBox("La tabla FF no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				SqlConnection connection16 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.txtNomServ.Text,
					"\\",
					this.txtInstancia.Text,
					";Initial Catalog=",
					this.txtbaseDatos_Modulo.Text,
					";User Id=",
					this.txtInicioSesion.Text,
					";Password=",
					this.txtContrasena.Text,
					";Connect Timeout=10;"
				}));
				string cmdText16 = "If OBJECT_ID('N', 'U') IS NOT NULL  \r\n                        Select * from N \r\n\t\t\r\n\r\n\t\r\n                        IF OBJECT_ID('N', 'U') IS NULL \r\nCREATE TABLE [dbo].[N](\r\n\t[a] [varchar](50) NULL,\r\n\t[b] [varchar](50) NULL)";
				sqlCommand = new SqlCommand(cmdText16, connection16);
				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex16)
			{
				Interaction.MsgBox("La tabla FF no se pudo crear en la base de datos,contacta a tu administrador de sistema!", MsgBoxStyle.OkOnly, null);
			}
			this.btnGuardarConexion.Enabled = true;
			this.GroupBox_ConexionSQL.Enabled = false;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000036D5 File Offset: 0x000018D5
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x001031B4 File Offset: 0x001013B4
		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.main.Icon = MyProject.Forms.gIco.Icon;
			Tools.EnableMenu();
			base.Close();
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtNomServ_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtBaseDatos_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtContrasena_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtInicioSesion_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtCte_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PanelDatosLicencia_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtInstancia_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtID_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x000036D5 File Offset: 0x000018D5
		private void GroupBoxBase_Modulo_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBoxModOK_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBoxModCancelar_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtbaseDatos_Modulo_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBoxError_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBoxCorrecto_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label14_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblid_licenciajc_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000036D5 File Offset: 0x000018D5
		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000036D5 File Offset: 0x000018D5
		private void GroupBox_Adicionales_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label16_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblcodigoEmpresa_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblfechaRegistro_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblbombresr_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblrfc_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtLicenciaID_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtLicenciaCliente_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtLicenciaServidor_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtCodigoEmpresa_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label22_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label21_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label19_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label18_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label17_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x001031E4 File Offset: 0x001013E4
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox2.Checked;
			if (@checked)
			{
				this.cboBaseDatos.Enabled = false;
				this.GroupBoxEstacion.Enabled = true;
				this.cboBaseDatos.Items.Clear();
				SqlQuery sqlQuery = new SqlQuery();
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("SELECT name from sys.databases");
				while (sqlDataReader.Read())
				{
					this.cboBaseDatos.Items.Add(sqlDataReader[0].ToString());
				}
				sqlDataReader.Close();
				this.cboBaseDatos.SelectedIndex = 0;
				this.cboBaseDatos.Enabled = true;
				this.GroupBoxBase_Modulo.Visible = false;
				this.GroupBoxEstacion.Visible = true;
				this.CheckBox2.Checked = true;
				this.CheckBox1.Checked = false;
			}
			bool flag = !this.CheckBox2.Checked;
			if (flag)
			{
				this.GroupBoxBase_Modulo.Visible = true;
				this.GroupBoxEstacion.Visible = false;
				this.CheckBox1.Checked = true;
				this.CheckBox2.Checked = false;
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00103314 File Offset: 0x00101514
		private void Button3_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			Conn_Local.strConexionServerLocal_Local_Modulo_DBO = string.Concat(new string[]
			{
				"Server = ",
				this.txtNomServ.Text,
				"\\",
				this.txtInstancia.Text,
				";Min Pool Size=0;Max Pool Size=10024;Pooling=true;Database=",
				this.cboBaseDatos.Text,
				";User Id=",
				this.txtInicioSesion.Text,
				";Password=",
				this.txtContrasena.Text,
				";Connect Timeout=10;"
			});
			string query_conn = "SELECT a from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					this.PictureBox3.Visible = true;
					this.PictureBox2.Visible = false;
					try
					{
						query_conn = "select t,am from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
						bool hasRows2 = sqlDataReader.HasRows;
						if (hasRows2)
						{
							this.txtCte.Enabled = false;
							sqlDataReader.Read();
							string text = Conversions.ToString(sqlDataReader[0]);
							text = Tools.Desencriptar(text.ToString().Trim());
							this.txtID.Text = text;
							string text2 = Conversions.ToString(sqlDataReader[1]);
							text2 = Tools.Desencriptar(text2.ToString().Trim());
							this.txtCte.Text = text2;
							Interaction.MsgBox("Nombre de Empresa y ID Unico Descargados exitosamente!", MsgBoxStyle.OkOnly, null);
							this.btnGuardarConexion.Enabled = true;
							this.PictureBox3.Visible = true;
							this.PictureBox2.Visible = false;
						}
					}
					catch (Exception ex)
					{
						Interaction.MsgBox("El valor Empresa aun no se encuentra registrado en el servidor , actualiza el sistema en el servidor e intenta nuevamente!", MsgBoxStyle.OkOnly, null);
						MyProject.Forms.main.Close();
					}
				}
			}
			else
			{
				Interaction.MsgBox("Conexion a base de datos " + this.cboBaseDatos.Text + ", INCORRECTA , INTENTA NUEVA MENTE!", MsgBoxStyle.OkOnly, null);
				this.PictureBox2.Visible = true;
				this.PictureBox3.Visible = false;
			}
			sqlDataReader.Close();
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00103554 File Offset: 0x00101754
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				this.GroupBoxBase_Modulo.Visible = true;
				this.GroupBoxEstacion.Visible = false;
				this.GroupBoxBase_Modulo.Enabled = true;
				this.GroupBoxEstacion.Enabled = true;
				this.CheckBox2.Checked = false;
			}
			bool flag = !this.CheckBox1.Checked;
			if (flag)
			{
				this.GroupBoxBase_Modulo.Visible = false;
				this.GroupBoxEstacion.Visible = true;
				this.CheckBox2.Checked = true;
				this.CheckBox1.Checked = false;
				this.GroupBoxBase_Modulo.Enabled = true;
				this.GroupBoxEstacion.Enabled = true;
			}
		}

		// Token: 0x04000744 RID: 1860
		private MySqlConnection MySqlConRemoto;

		// Token: 0x04000745 RID: 1861
		private MySqlCommand MySqlCmdRemoto;

		// Token: 0x04000746 RID: 1862
		private MySqlDataReader MySqlDRremoto;
	}
}
