using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public partial class frmLogin : Form
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x000B742D File Offset: 0x000B562D
		public frmLogin()
		{
			base.Load += this.LOGIN_Load;
			this.Counter = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000B9413 File Offset: 0x000B7613
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x000B9420 File Offset: 0x000B7620
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000B9463 File Offset: 0x000B7663
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x000B946D File Offset: 0x000B766D
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000B9476 File Offset: 0x000B7676
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x000B9480 File Offset: 0x000B7680
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x000B9489 File Offset: 0x000B7689
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x000B9493 File Offset: 0x000B7693
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000B949C File Offset: 0x000B769C
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x000B94A8 File Offset: 0x000B76A8
		internal virtual TextBox txtcontraseña
		{
			[CompilerGenerated]
			get
			{
				return this._txtcontraseña;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtcontraseña_TextChanged);
				EventHandler value3 = new EventHandler(this.txtcontraseña_Click);
				EventHandler value4 = new EventHandler(this.txtcontraseña_Leave);
				KeyEventHandler value5 = new KeyEventHandler(this.txtcontraseña_KeyDown);
				TextBox txtcontraseña = this._txtcontraseña;
				if (txtcontraseña != null)
				{
					txtcontraseña.TextChanged -= value2;
					txtcontraseña.Click -= value3;
					txtcontraseña.Leave -= value4;
					txtcontraseña.KeyDown -= value5;
				}
				this._txtcontraseña = value;
				txtcontraseña = this._txtcontraseña;
				if (txtcontraseña != null)
				{
					txtcontraseña.TextChanged += value2;
					txtcontraseña.Click += value3;
					txtcontraseña.Leave += value4;
					txtcontraseña.KeyDown += value5;
				}
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x000B9548 File Offset: 0x000B7748
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x000B9554 File Offset: 0x000B7754
		internal virtual TextBox txtlogin
		{
			[CompilerGenerated]
			get
			{
				return this._txtlogin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtusuario_Click);
				TextBox txtlogin = this._txtlogin;
				if (txtlogin != null)
				{
					txtlogin.Click -= value2;
				}
				this._txtlogin = value;
				txtlogin = this._txtlogin;
				if (txtlogin != null)
				{
					txtlogin.Click += value2;
				}
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000B9597 File Offset: 0x000B7797
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x000B95A1 File Offset: 0x000B77A1
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000B95AA File Offset: 0x000B77AA
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x000B95B4 File Offset: 0x000B77B4
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000B95BD File Offset: 0x000B77BD
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x000B95C7 File Offset: 0x000B77C7
		internal virtual DataGridView datalistado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000B95D0 File Offset: 0x000B77D0
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x000B95DA File Offset: 0x000B77DA
		internal virtual DataGridViewImageColumn Eli { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000B95E3 File Offset: 0x000B77E3
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x000B95F0 File Offset: 0x000B77F0
		internal virtual Button btnCrearUsuario
		{
			[CompilerGenerated]
			get
			{
				return this._btnCrearUsuario;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click_1);
				Button btnCrearUsuario = this._btnCrearUsuario;
				if (btnCrearUsuario != null)
				{
					btnCrearUsuario.Click -= value2;
				}
				this._btnCrearUsuario = value;
				btnCrearUsuario = this._btnCrearUsuario;
				if (btnCrearUsuario != null)
				{
					btnCrearUsuario.Click += value2;
				}
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000B9633 File Offset: 0x000B7833
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x000B963D File Offset: 0x000B783D
		internal virtual Label lblmodificaticket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x000B9646 File Offset: 0x000B7846
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x000B9650 File Offset: 0x000B7850
		internal virtual Label lblEliminaFolios { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000B9659 File Offset: 0x000B7859
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x000B9663 File Offset: 0x000B7863
		internal virtual Label lblidperfil { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000B966C File Offset: 0x000B786C
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x000B9676 File Offset: 0x000B7876
		internal virtual Label lblEliminarproductos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x000B967F File Offset: 0x000B787F
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x000B9689 File Offset: 0x000B7889
		internal virtual Label lblModificaTurnos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x000B9692 File Offset: 0x000B7892
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x000B969C File Offset: 0x000B789C
		internal virtual Label lblReportes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x000B96A5 File Offset: 0x000B78A5
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x000B96AF File Offset: 0x000B78AF
		internal virtual Label lblSOS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000B96B8 File Offset: 0x000B78B8
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x000B96C2 File Offset: 0x000B78C2
		internal virtual Label lblBitacora { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000B96CB File Offset: 0x000B78CB
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x000B96D5 File Offset: 0x000B78D5
		internal virtual Label lblconfiguracion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000B96DE File Offset: 0x000B78DE
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x000B96E8 File Offset: 0x000B78E8
		internal virtual Label lblBasededatos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x000B96F1 File Offset: 0x000B78F1
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000B96FB File Offset: 0x000B78FB
		internal virtual Label lblusuarioperfil { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000B9704 File Offset: 0x000B7904
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000B970E File Offset: 0x000B790E
		internal virtual Label lblparametros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000B9717 File Offset: 0x000B7917
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000B9721 File Offset: 0x000B7921
		internal virtual Label lblconexiondbo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x000B972A File Offset: 0x000B792A
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x000B9734 File Offset: 0x000B7934
		internal virtual Label lblautofactura { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000B973D File Offset: 0x000B793D
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x000B9747 File Offset: 0x000B7947
		internal virtual Label lblasignarproducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000B9750 File Offset: 0x000B7950
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x000B975A File Offset: 0x000B795A
		internal virtual Label lblicencia { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x000B9763 File Offset: 0x000B7963
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x000B976D File Offset: 0x000B796D
		internal virtual Label lblcontador { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x000B9776 File Offset: 0x000B7976
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x000B9780 File Offset: 0x000B7980
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

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x000B97C3 File Offset: 0x000B79C3
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x000B97CD File Offset: 0x000B79CD
		internal virtual Label lblEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x000B97D6 File Offset: 0x000B79D6
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x000B97E0 File Offset: 0x000B79E0
		internal virtual Label lblSustituirProd { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000B97E9 File Offset: 0x000B79E9
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x000B97F3 File Offset: 0x000B79F3
		internal virtual Label lblEliminarReemplaza { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000B97FC File Offset: 0x000B79FC
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x000B9806 File Offset: 0x000B7A06
		internal virtual Label lblImprimeTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000B980F File Offset: 0x000B7A0F
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x000B9819 File Offset: 0x000B7A19
		internal virtual Label lblEmpresa_Tickets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x000B9822 File Offset: 0x000B7A22
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x000B982C File Offset: 0x000B7A2C
		internal virtual PictureBox btnVerPassword
		{
			[CompilerGenerated]
			get
			{
				return this._btnVerPassword;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnVerPassword_Click);
				PictureBox btnVerPassword = this._btnVerPassword;
				if (btnVerPassword != null)
				{
					btnVerPassword.Click -= value2;
				}
				this._btnVerPassword = value;
				btnVerPassword = this._btnVerPassword;
				if (btnVerPassword != null)
				{
					btnVerPassword.Click += value2;
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x000B986F File Offset: 0x000B7A6F
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x000B9879 File Offset: 0x000B7A79
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x000B9882 File Offset: 0x000B7A82
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x000B988C File Offset: 0x000B7A8C
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x000B98CF File Offset: 0x000B7ACF
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x000B98D9 File Offset: 0x000B7AD9
		internal virtual Label lblseconds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000B98E2 File Offset: 0x000B7AE2
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x000B98EC File Offset: 0x000B7AEC
		internal virtual Label lbl5segundos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x000B98F5 File Offset: 0x000B7AF5
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x000B98FF File Offset: 0x000B7AFF
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000B02 RID: 2818 RVA: 0x000B9908 File Offset: 0x000B7B08
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			int num = 0;
			this.lblidperfil.Text = Conversions.ToString(0);
			string query_conn = string.Concat(new string[]
			{
				"SELECT c , d , f , e from D Where c ='",
				Tools.Encriptar(this.txtlogin.Text.Trim()),
				"' and d = '",
				Tools.Encriptar(this.txtcontraseña.Text.Trim()),
				"'"
			});
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			checked
			{
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						this.login = Conversions.ToString(sqlDataReader[0]);
						this.password = Conversions.ToString(sqlDataReader[1]);
						this.perfil = Tools.Desencriptar(sqlDataReader[2].ToString().Trim());
						this.administrador = Tools.Desencriptar(sqlDataReader[3].ToString().Trim());
						this.lblidperfil.Text = this.perfil;
						MyProject.Forms.main.lblNombreUsuario.Text = this.txtlogin.Text;
					}
					sqlDataReader.Close();
					query_conn = "select c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,w,x from E where a ='" + this.lblidperfil.Text + "'";
					sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
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
						string text17 = Tools.Desencriptar(sqlDataReader[16].ToString().Trim());
						string text18 = Tools.Desencriptar(sqlDataReader[17].ToString().Trim());
						string text19 = Tools.Desencriptar(sqlDataReader[18].ToString().Trim());
						string text20 = Tools.Desencriptar(sqlDataReader[19].ToString().Trim());
						this.lblmodificaticket.Text = text;
						this.lblEliminaFolios.Text = text2;
						this.lblEliminarproductos.Text = text3;
						this.lblModificaTurnos.Text = text4;
						this.lblReportes.Text = text5;
						this.lblSOS.Text = text6;
						this.lblBitacora.Text = text7;
						this.lblconfiguracion.Text = text8;
						this.lblBasededatos.Text = text9;
						this.lblusuarioperfil.Text = text10;
						this.lblparametros.Text = text11;
						this.lblconexiondbo.Text = text12;
						this.lblautofactura.Text = text13;
						this.lblasignarproducto.Text = text14;
						this.lblicencia.Text = text15;
						this.lblEmail.Text = text16;
						this.lblSustituirProd.Text = text17;
						this.lblEliminarReemplaza.Text = text18;
						this.lblImprimeTicket.Text = text19;
						this.lblEmpresa_Tickets.Text = text20;
						sqlDataReader.Close();
					}
					bool flag2 = Operators.CompareString(Tools.Encriptar(this.txtlogin.Text.Trim()), this.login, false) == 0 & Operators.CompareString(Tools.Encriptar(this.txtcontraseña.Text.Trim()), this.password, false) == 0;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(this.administrador, "1", false) == 0;
						if (flag3)
						{
							sqlDataReader.Close();
							base.Dispose();
							MyProject.Forms.main.Show();
							MyProject.Forms.main.PanelMenuModulo.Visible = true;
							MyProject.Forms.main.MainMenuStrip.Visible = false;
							this.btnCrearUsuario.Visible = false;
							MyProject.Forms.main.PanelContenedorForms.Visible = true;
							MyProject.Forms.main.Panel1.Visible = true;
							base.Dispose();
							MyProject.Forms.main.Show();
							MyProject.Forms.main.PanelMenuModulo.Visible = true;
							MyProject.Forms.main.MainMenuStrip.Visible = false;
							MyProject.Forms.main.PanelContenedorForms.Visible = true;
							MyProject.Forms.main.Panel1.Visible = true;
						}
						bool flag4 = Operators.CompareString(this.administrador, "0", false) == 0;
						if (flag4)
						{
							bool flag5 = Operators.CompareString(this.lblSustituirProd.Text, "1", false) == 0;
							if (flag5)
							{
								MyProject.Forms.main.btnRemplazarProductos.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnRemplazarProductos.Enabled = false;
							}
							bool flag6 = Operators.CompareString(this.lblEliminarReemplaza.Text, "1", false) == 0;
							if (flag6)
							{
								MyProject.Forms.main.btnEliminaYRemplaza.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnEliminaYRemplaza.Enabled = false;
							}
							bool flag7 = Operators.CompareString(this.lblmodificaticket.Text, "1", false) == 0;
							if (flag7)
							{
								MyProject.Forms.main.BtnModificar1Ticket.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnModificar1Ticket.Enabled = false;
							}
							bool flag8 = Operators.CompareString(this.lblEliminaFolios.Text, "1", false) == 0;
							if (flag8)
							{
								MyProject.Forms.main.btnEliminacionMasiva.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnEliminacionMasiva.Enabled = false;
							}
							bool flag9 = Operators.CompareString(this.lblEliminarproductos.Text, "1", false) == 0;
							if (flag9)
							{
								MyProject.Forms.main.btnEliminarProductos.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnEliminarProductos.Enabled = false;
							}
							bool flag10 = Operators.CompareString(this.lblModificaTurnos.Text, "1", false) == 0;
							if (flag10)
							{
								MyProject.Forms.main.BtnModificarTurnos.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnModificarTurnos.Enabled = false;
							}
							bool flag11 = Operators.CompareString(this.lblReportes.Text, "1", false) == 0;
							if (flag11)
							{
								MyProject.Forms.main.BtnReportes.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnReportes.Enabled = false;
							}
							bool flag12 = Operators.CompareString(this.lblSOS.Text, "1", false) == 0;
							if (flag12)
							{
								MyProject.Forms.main.btnPanico.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnPanico.Enabled = false;
							}
							bool flag13 = Operators.CompareString(this.lblBitacora.Text, "1", false) == 0;
							if (flag13)
							{
								MyProject.Forms.main.BtnBitacora.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnBitacora.Enabled = false;
							}
							bool flag14 = Operators.CompareString(this.lblconfiguracion.Text, "1", false) == 0;
							if (flag14)
							{
								MyProject.Forms.main.btnConfiguracion.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnConfiguracion.Enabled = false;
							}
							bool flag15 = Operators.CompareString(this.lblBasededatos.Text, "1", false) == 0;
							if (flag15)
							{
								MyProject.Forms.main.BtnRespaldar.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnRespaldar.Enabled = false;
							}
							bool flag16 = Operators.CompareString(this.lblusuarioperfil.Text, "1", false) == 0;
							if (flag16)
							{
								MyProject.Forms.main.btnUsuariosyPerfiles.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnUsuariosyPerfiles.Enabled = false;
							}
							bool flag17 = Operators.CompareString(this.lblparametros.Text, "1", false) == 0;
							if (flag17)
							{
								MyProject.Forms.main.Parametros.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.Parametros.Enabled = false;
							}
							bool flag18 = Operators.CompareString(this.lblconexiondbo.Text, "1", false) == 0;
							if (flag18)
							{
								MyProject.Forms.main.BtnServerConfig.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnServerConfig.Enabled = false;
							}
							bool flag19 = Operators.CompareString(this.lblautofactura.Text, "1", false) == 0;
							if (flag19)
							{
								MyProject.Forms.main.BtnAutoFactura.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnAutoFactura.Enabled = false;
							}
							bool flag20 = Operators.CompareString(this.lblasignarproducto.Text, "1", false) == 0;
							if (flag20)
							{
								MyProject.Forms.main.btnTablas.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnTablas.Enabled = false;
							}
							bool flag21 = Operators.CompareString(this.lblicencia.Text, "1", false) == 0;
							if (flag21)
							{
								MyProject.Forms.main.BtnLicencia.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.BtnLicencia.Enabled = false;
							}
							bool flag22 = Operators.CompareString(this.lblEmail.Text, "1", false) == 0;
							if (flag22)
							{
								MyProject.Forms.main.btnEmail.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnEmail.Enabled = false;
							}
							bool flag23 = Operators.CompareString(this.lblImprimeTicket.Text, "1", false) == 0;
							if (flag23)
							{
								MyProject.Forms.main.btnReImprimirTickets.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnReImprimirTickets.Enabled = false;
							}
							bool flag24 = Operators.CompareString(this.lblEmpresa_Tickets.Text, "1", false) == 0;
							if (flag24)
							{
								MyProject.Forms.main.btnEmpresa.Enabled = true;
							}
							else
							{
								MyProject.Forms.main.btnEmpresa.Enabled = false;
							}
						}
						base.Dispose();
						MyProject.Forms.main.Show();
						MyProject.Forms.main.PanelMenuModulo.Visible = true;
						MyProject.Forms.main.MainMenuStrip.Visible = false;
						this.btnCrearUsuario.Visible = false;
						MyProject.Forms.main.PanelContenedorForms.Visible = true;
						MyProject.Forms.main.Panel1.Visible = true;
					}
				}
				else
				{
					bool flag25 = Operators.CompareString(this.txtlogin.Text, this.login, false) != 0 & Operators.CompareString(this.txtcontraseña.Text, this.password, false) != 0;
					if (flag25)
					{
						num++;
						MessageBox.Show("Usuario o Contraseña NO VALIDOS , Favor de intentar Nuevamente ", "Control de Acceso ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						this.lblcontador.Text = Conversions.ToString(num);
					}
				}
				num++;
				sqlDataReader.Close();
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000BA64C File Offset: 0x000B884C
		private void txtusuario_Click(object sender, EventArgs e)
		{
			this.txtlogin.Text = "";
			this.txtlogin.Focus();
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtcontraseña_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000BA66C File Offset: 0x000B886C
		private void txtcontraseña_Click(object sender, EventArgs e)
		{
			this.txtcontraseña.Text = "";
			this.txtcontraseña.Focus();
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000BA68C File Offset: 0x000B888C
		private void LOGIN_Load(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			MyProject.Forms.frmElegirEmpresa.Close();
			this.lblseconds.Text = this.Counter.ToString();
			this.Timer1.Interval = checked((int)Math.Round(TimeSpan.FromSeconds(1.0).TotalMilliseconds));
			try
			{
				string query_conn = "SELECT * FROM D ";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					sqlDataReader.Close();
					this.btnCrearUsuario.Visible = false;
					this.txtlogin.Text = "Usuario";
					this.txtcontraseña.Text = "Contraseña";
				}
				else
				{
					bool flag = !sqlDataReader.HasRows;
					if (flag)
					{
						this.txtlogin.Text = "Usuario Distribiuidor";
						this.txtcontraseña.Text = "Contraseña";
						this.btnCrearUsuario.Visible = true;
					}
				}
				sqlDataReader.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000BA7B4 File Offset: 0x000B89B4
		private void Button2_Click_1(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = "SuperAdmin";
			string text2 = "1";
			string text3 = "0";
			string text4 = "0";
			text = Tools.Encriptar(text.ToString().Trim());
			text2 = Tools.Encriptar(text2.ToString().Trim());
			text3 = Tools.Encriptar(text3.ToString().Trim());
			text4 = Tools.Encriptar(text4.ToString().Trim());
			bool flag = Operators.CompareString(this.txtlogin.Text, "", false) != 0 & Operators.CompareString(this.txtlogin.Text, "Nuevo Usuario", false) != 0 & Operators.CompareString(this.txtcontraseña.Text, "", false) != 0 & Operators.CompareString(this.txtcontraseña.Text, "Nueva Contraseña", false) != 0;
			if (flag)
			{
				try
				{
					string text5 = string.Concat(new string[]
					{
						"insert into D (b,c,d,e,f,g) values ('",
						text.ToString(),
						"','",
						Tools.Encriptar(this.txtlogin.Text.Trim()),
						"','",
						Tools.Encriptar(this.txtcontraseña.Text.Trim()),
						"','",
						text2.ToString(),
						"','",
						text3.ToString(),
						"','",
						text4.ToString(),
						"')"
					});
					sqlQuery_Conn.execQuery_conn(text5);
				}
				catch (Exception ex)
				{
				}
				try
				{
					string text5 = "update gruposiclasificacion set clasificacionventa=2 where descripcion='ALIMENTOS'\r\n                            update gruposiclasificacion set clasificacionventa=1 where descripcion='BEBIDAS'\r\n                            update gruposiclasificacion set clasificacionventa=3 where descripcion='OTROS'";
					sqlQuery.execQuery(text5);
				}
				catch (Exception ex2)
				{
				}
				Interaction.MsgBox("Usuario: Super Administrador creado correctamente, el programa se cerrar automaticamenete.! \r\nEjecutalo nuevamente para continuar con la configuración.", MsgBoxStyle.OkOnly, MessageBoxIcon.Asterisk);
				MyProject.Forms.main.Close();
				base.Close();
			}
			else
			{
				Interaction.MsgBox("El campo Usuario y Contraseña no pueden quedar vacios o sin modificar el texto por default!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x000BA9DC File Offset: 0x000B8BDC
		private void PictureBox2_Click(object sender, EventArgs e)
		{
			base.Hide();
			MyProject.Forms.frmElegirEmpresa.Show();
			MyProject.Forms.main.Close();
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000BAA06 File Offset: 0x000B8C06
		private void btnVerPassword_Click(object sender, EventArgs e)
		{
			this.Timer1.Start();
			this.txtcontraseña.UseSystemPasswordChar = false;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000BAA24 File Offset: 0x000B8C24
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				this.Counter++;
				this.lblseconds.Text = this.Counter.ToString();
				bool flag = Operators.CompareString(this.lblseconds.Text, this.lbl5segundos.Text, false) == 0;
				if (flag)
				{
					this.Timer1.Stop();
					this.txtcontraseña.UseSystemPasswordChar = true;
					this.lblseconds.Text = Conversions.ToString(0);
					this.Counter = 0;
				}
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000BAAAE File Offset: 0x000B8CAE
		private void txtcontraseña_Leave(object sender, EventArgs e)
		{
			this.Button1.Focus();
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000BAAC0 File Offset: 0x000B8CC0
		private void txtcontraseña_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.Button1.PerformClick();
			}
		}

		// Token: 0x04000514 RID: 1300
		private string login;

		// Token: 0x04000515 RID: 1301
		private string password;

		// Token: 0x04000516 RID: 1302
		private string perfil;

		// Token: 0x04000517 RID: 1303
		private string administrador;

		// Token: 0x04000518 RID: 1304
		public int Counter;
	}
}
