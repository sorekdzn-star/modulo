using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public partial class frmLicencia : Form
	{
		// Token: 0x06000A48 RID: 2632 RVA: 0x000B420C File Offset: 0x000B240C
		public frmLicencia()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000B5B3A File Offset: 0x000B3D3A
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x000B5B44 File Offset: 0x000B3D44
		internal virtual TextBox txtLicencia
		{
			[CompilerGenerated]
			get
			{
				return this._txtLicencia;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtLicencia_TextChanged);
				TextBox txtLicencia = this._txtLicencia;
				if (txtLicencia != null)
				{
					txtLicencia.TextChanged -= value2;
				}
				this._txtLicencia = value;
				txtLicencia = this._txtLicencia;
				if (txtLicencia != null)
				{
					txtLicencia.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x000B5B87 File Offset: 0x000B3D87
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x000B5B94 File Offset: 0x000B3D94
		internal virtual Button btnCancelar
		{
			[CompilerGenerated]
			get
			{
				return this._btnCancelar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancelar_Click);
				Button btnCancelar = this._btnCancelar;
				if (btnCancelar != null)
				{
					btnCancelar.Click -= value2;
				}
				this._btnCancelar = value;
				btnCancelar = this._btnCancelar;
				if (btnCancelar != null)
				{
					btnCancelar.Click += value2;
				}
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x000B5BD7 File Offset: 0x000B3DD7
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000B5BE4 File Offset: 0x000B3DE4
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

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000B5C27 File Offset: 0x000B3E27
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000B5C31 File Offset: 0x000B3E31
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000B5C3A File Offset: 0x000B3E3A
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x000B5C44 File Offset: 0x000B3E44
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x000B5C87 File Offset: 0x000B3E87
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x000B5C91 File Offset: 0x000B3E91
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x000B5C9A File Offset: 0x000B3E9A
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x000B5CA4 File Offset: 0x000B3EA4
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x000B5CAD File Offset: 0x000B3EAD
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x000B5CB7 File Offset: 0x000B3EB7
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x000B5CC0 File Offset: 0x000B3EC0
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x000B5CCA File Offset: 0x000B3ECA
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x000B5CD3 File Offset: 0x000B3ED3
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x000B5CDD File Offset: 0x000B3EDD
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000B5CE6 File Offset: 0x000B3EE6
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x000B5CF0 File Offset: 0x000B3EF0
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x000B5CF9 File Offset: 0x000B3EF9
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x000B5D03 File Offset: 0x000B3F03
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x000B5D0C File Offset: 0x000B3F0C
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000B5D16 File Offset: 0x000B3F16
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x000B5D1F File Offset: 0x000B3F1F
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x000B5D29 File Offset: 0x000B3F29
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x000B5D32 File Offset: 0x000B3F32
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x000B5D3C File Offset: 0x000B3F3C
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x000B5D45 File Offset: 0x000B3F45
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x000B5D4F File Offset: 0x000B3F4F
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000B5D58 File Offset: 0x000B3F58
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x000B5D62 File Offset: 0x000B3F62
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000B5D6B File Offset: 0x000B3F6B
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x000B5D75 File Offset: 0x000B3F75
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000B5D7E File Offset: 0x000B3F7E
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x000B5D88 File Offset: 0x000B3F88
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x000B5D91 File Offset: 0x000B3F91
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x000B5D9B File Offset: 0x000B3F9B
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x000B5DA4 File Offset: 0x000B3FA4
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x000B5DAE File Offset: 0x000B3FAE
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x000B5DB7 File Offset: 0x000B3FB7
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x000B5DC1 File Offset: 0x000B3FC1
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x000B5DCA File Offset: 0x000B3FCA
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x000B5DD4 File Offset: 0x000B3FD4
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000B5DDD File Offset: 0x000B3FDD
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x000B5DE7 File Offset: 0x000B3FE7
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000B5DF0 File Offset: 0x000B3FF0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x000B5DFA File Offset: 0x000B3FFA
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000B5E03 File Offset: 0x000B4003
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x000B5E0D File Offset: 0x000B400D
		internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x000B5E16 File Offset: 0x000B4016
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x000B5E20 File Offset: 0x000B4020
		internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000B5E29 File Offset: 0x000B4029
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x000B5E33 File Offset: 0x000B4033
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000B5E3C File Offset: 0x000B403C
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x000B5E46 File Offset: 0x000B4046
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000B5E4F File Offset: 0x000B404F
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000B5E59 File Offset: 0x000B4059
		internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x000B5E62 File Offset: 0x000B4062
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000B5E6C File Offset: 0x000B406C
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000B5E75 File Offset: 0x000B4075
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000B5E7F File Offset: 0x000B407F
		internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000A8B RID: 2699 RVA: 0x000B5E88 File Offset: 0x000B4088
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Tools.licencia = "";
			this.txtLicencia.Text = "";
			base.Close();
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000B5EB0 File Offset: 0x000B40B0
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			string[] lines = this.txtLicencia.Lines;
			checked
			{
				foreach (string licencia in lines)
				{
					Tools.licencia = licencia;
					bool flag = Tools.ValidaLicencia();
					if (flag)
					{
						string text = Tools.licenciaDec.Substring(Tools.licenciaDec.LastIndexOf(";##;") + 4, 4);
						string text2 = Tools.licenciaDec.Substring(Tools.licenciaDec.LastIndexOf(";###;") + 5, Tools.licenciaDec.LastIndexOf(";####;") - (Tools.licenciaDec.LastIndexOf(";###;") + 5));
						SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn("select * from G where a = '" + Tools.licencia + "'");
						bool hasRows = sqlDataReader.HasRows;
						if (hasRows)
						{
							sqlQuery_Conn.execQuery_conn(string.Concat(new string[]
							{
								"UPDATE G SET a = '",
								Tools.licencia,
								"' WHERE b='",
								Tools.Encriptar(text.ToString().Trim()),
								"' and c = '",
								Tools.Encriptar(text2.ToString().Trim()),
								"'"
							}));
						}
						else
						{
							sqlQuery_Conn.execQuery_conn(string.Concat(new string[]
							{
								"INSERT INTO G VALUES ('",
								Tools.licencia,
								"','",
								Tools.Encriptar(text.ToString().Trim()),
								"','",
								Tools.Encriptar(text2.ToString().Trim()),
								"')"
							}));
						}
						sqlDataReader.Close();
						MyProject.Forms.frmLicencias.refrescaDatos();
						base.Close();
						this.txtLicencia.Clear();
					}
				}
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtLicencia_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0001D5AF File Offset: 0x0001B7AF
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
