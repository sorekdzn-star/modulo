using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000020 RID: 32
	[DesignerGenerated]
	public partial class frmReportes : Form
	{
		// Token: 0x06000F08 RID: 3848 RVA: 0x000F7614 File Offset: 0x000F5814
		public frmReportes()
		{
			base.Load += this.frmReportes_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x000FA111 File Offset: 0x000F8311
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x000FA11B File Offset: 0x000F831B
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x000FA124 File Offset: 0x000F8324
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x000FA130 File Offset: 0x000F8330
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

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x000FA173 File Offset: 0x000F8373
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x000FA180 File Offset: 0x000F8380
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000FA1C3 File Offset: 0x000F83C3
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x000FA1CD File Offset: 0x000F83CD
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000FA1D6 File Offset: 0x000F83D6
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x000FA1E0 File Offset: 0x000F83E0
		internal virtual PictureBox BtnHorario
		{
			[CompilerGenerated]
			get
			{
				return this._BtnHorario;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnHorario_Click);
				PictureBox btnHorario = this._BtnHorario;
				if (btnHorario != null)
				{
					btnHorario.Click -= value2;
				}
				this._BtnHorario = value;
				btnHorario = this._BtnHorario;
				if (btnHorario != null)
				{
					btnHorario.Click += value2;
				}
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x000FA223 File Offset: 0x000F8423
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x000FA22D File Offset: 0x000F842D
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000FA236 File Offset: 0x000F8436
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x000FA240 File Offset: 0x000F8440
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

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x000FA283 File Offset: 0x000F8483
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x000FA28D File Offset: 0x000F848D
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000FA296 File Offset: 0x000F8496
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x000FA2A0 File Offset: 0x000F84A0
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000FA2E3 File Offset: 0x000F84E3
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x000FA2ED File Offset: 0x000F84ED
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000FA2F6 File Offset: 0x000F84F6
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x000FA300 File Offset: 0x000F8500
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000FA309 File Offset: 0x000F8509
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x000FA313 File Offset: 0x000F8513
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000FA31C File Offset: 0x000F851C
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000FA326 File Offset: 0x000F8526
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000FA32F File Offset: 0x000F852F
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x000FA339 File Offset: 0x000F8539
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000FA342 File Offset: 0x000F8542
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x000FA34C File Offset: 0x000F854C
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x000FA355 File Offset: 0x000F8555
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x000FA35F File Offset: 0x000F855F
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000FA368 File Offset: 0x000F8568
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x000FA374 File Offset: 0x000F8574
		internal virtual CheckBox CheckBoxProductosVendidos
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxProductosVendidos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxProductosVendidos_CheckedChanged);
				CheckBox checkBoxProductosVendidos = this._CheckBoxProductosVendidos;
				if (checkBoxProductosVendidos != null)
				{
					checkBoxProductosVendidos.CheckedChanged -= value2;
				}
				this._CheckBoxProductosVendidos = value;
				checkBoxProductosVendidos = this._CheckBoxProductosVendidos;
				if (checkBoxProductosVendidos != null)
				{
					checkBoxProductosVendidos.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000FA3B7 File Offset: 0x000F85B7
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x000FA3C4 File Offset: 0x000F85C4
		internal virtual CheckBox CheckBoxVentasDia
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxVentasDia;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxVentasDia_CheckedChanged);
				CheckBox checkBoxVentasDia = this._CheckBoxVentasDia;
				if (checkBoxVentasDia != null)
				{
					checkBoxVentasDia.CheckedChanged -= value2;
				}
				this._CheckBoxVentasDia = value;
				checkBoxVentasDia = this._CheckBoxVentasDia;
				if (checkBoxVentasDia != null)
				{
					checkBoxVentasDia.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000FA407 File Offset: 0x000F8607
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x000FA414 File Offset: 0x000F8614
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

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000FA457 File Offset: 0x000F8657
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x000FA461 File Offset: 0x000F8661
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000FA46A File Offset: 0x000F866A
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x000FA474 File Offset: 0x000F8674
		internal virtual DataGridView dgvnotas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x000FA47D File Offset: 0x000F867D
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x000FA488 File Offset: 0x000F8688
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000FA4CB File Offset: 0x000F86CB
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x000FA4D5 File Offset: 0x000F86D5
		internal virtual Label lbltotalalimentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000FA4DE File Offset: 0x000F86DE
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x000FA4E8 File Offset: 0x000F86E8
		internal virtual TextBox txttotalalimentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000FA4F1 File Offset: 0x000F86F1
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x000FA4FB File Offset: 0x000F86FB
		internal virtual Label lblTotalOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000FA504 File Offset: 0x000F8704
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x000FA50E File Offset: 0x000F870E
		internal virtual TextBox txtTotalOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000FA517 File Offset: 0x000F8717
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x000FA521 File Offset: 0x000F8721
		internal virtual Label lbltotalcortesias { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000FA52A File Offset: 0x000F872A
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x000FA534 File Offset: 0x000F8734
		internal virtual TextBox txtTotalCortesias { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000FA53D File Offset: 0x000F873D
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000FA547 File Offset: 0x000F8747
		internal virtual Label lbltotaldescuentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000FA550 File Offset: 0x000F8750
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x000FA55A File Offset: 0x000F875A
		internal virtual TextBox txttotaldescuentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000FA563 File Offset: 0x000F8763
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x000FA56D File Offset: 0x000F876D
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000FA576 File Offset: 0x000F8776
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x000FA580 File Offset: 0x000F8780
		internal virtual Label lbltotalbebidas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000FA589 File Offset: 0x000F8789
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x000FA593 File Offset: 0x000F8793
		internal virtual TextBox Txttotalbebidas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000FA59C File Offset: 0x000F879C
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x000FA5A6 File Offset: 0x000F87A6
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000FA5AF File Offset: 0x000F87AF
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x000FA5B9 File Offset: 0x000F87B9
		internal virtual TextBox TxtTotalventabruta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000FA5C2 File Offset: 0x000F87C2
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x000FA5CC File Offset: 0x000F87CC
		internal virtual Label lblTotalIMpuestos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000FA5D5 File Offset: 0x000F87D5
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x000FA5DF File Offset: 0x000F87DF
		internal virtual TextBox txtTotalImpuestos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000FA5E8 File Offset: 0x000F87E8
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x000FA5F2 File Offset: 0x000F87F2
		internal virtual Label lbltotalconimpuesto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000FA5FB File Offset: 0x000F87FB
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x000FA605 File Offset: 0x000F8805
		internal virtual TextBox txttotalconimpuesto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000FA60E File Offset: 0x000F880E
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x000FA618 File Offset: 0x000F8818
		internal virtual Label lblpropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x000FA621 File Offset: 0x000F8821
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x000FA62B File Offset: 0x000F882B
		internal virtual TextBox txtTotalPRopinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000FA634 File Offset: 0x000F8834
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x000FA63E File Offset: 0x000F883E
		internal virtual Label lblpersonas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000FA647 File Offset: 0x000F8847
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000FA651 File Offset: 0x000F8851
		internal virtual TextBox txtPersonas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000FA65A File Offset: 0x000F885A
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x000FA664 File Offset: 0x000F8864
		internal virtual Label lblTotalcuentas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000FA66D File Offset: 0x000F886D
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x000FA677 File Offset: 0x000F8877
		internal virtual TextBox txtTotalcuentas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x000FA680 File Offset: 0x000F8880
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x000FA68A File Offset: 0x000F888A
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x000FA693 File Offset: 0x000F8893
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x000FA69D File Offset: 0x000F889D
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x000FA6A6 File Offset: 0x000F88A6
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x000FA6B0 File Offset: 0x000F88B0
		internal virtual TextBox txtTotalVentaProductos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x000FA6B9 File Offset: 0x000F88B9
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x000FA6C3 File Offset: 0x000F88C3
		internal virtual Label txtTotalCantidadProductos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x000FA6CC File Offset: 0x000F88CC
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x000FA6D6 File Offset: 0x000F88D6
		internal virtual TextBox lblTotalCantidad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000FA6DF File Offset: 0x000F88DF
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x000FA6EC File Offset: 0x000F88EC
		internal virtual PictureBox btnExportar
		{
			[CompilerGenerated]
			get
			{
				return this._btnExportar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnExportar_Click);
				PictureBox btnExportar = this._btnExportar;
				if (btnExportar != null)
				{
					btnExportar.Click -= value2;
				}
				this._btnExportar = value;
				btnExportar = this._btnExportar;
				if (btnExportar != null)
				{
					btnExportar.Click += value2;
				}
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x000FA72F File Offset: 0x000F892F
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x000FA739 File Offset: 0x000F8939
		internal virtual Label lblexportar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x000FA742 File Offset: 0x000F8942
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x000FA74C File Offset: 0x000F894C
		internal virtual ProgressBar progBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x000FA755 File Offset: 0x000F8955
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x000FA75F File Offset: 0x000F895F
		internal virtual Label lblcounter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000FA768 File Offset: 0x000F8968
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x000FA772 File Offset: 0x000F8972
		internal virtual Label lblpromoo0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000FA77B File Offset: 0x000F897B
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x000FA785 File Offset: 0x000F8985
		internal virtual PictureBox Pictureboxindicador1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x000FA78E File Offset: 0x000F898E
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x000FA798 File Offset: 0x000F8998
		internal virtual DataGridView DgvDesencriptar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000F7D RID: 3965 RVA: 0x000FA7A4 File Offset: 0x000F89A4
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			MyProject.Forms.main.btnEliminarProductos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnEliminacionMasiva.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificar1Ticket.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificarTurnos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnReportes.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnPanico.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnBitacora.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnConfiguracion.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnRespaldar.BackColor = SystemColors.ActiveCaption;
			string query_conn = "Delete from Aa";
			sqlQuery_Conn.execQuery_conn(query_conn);
			base.Hide();
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000FA8B8 File Offset: 0x000F8AB8
		private void llenaCombos()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.cmbAnio.Items.Clear();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn("select distinct (b) from G");
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

		// Token: 0x06000F7F RID: 3967 RVA: 0x000FA938 File Offset: 0x000F8B38
		private void frmReportes_Load(object sender, EventArgs e)
		{
			this.llenaCombos();
			this.GroupBox2.Visible = false;
			this.GroupBox3.Visible = false;
			this.Pictureboxindicador1.Visible = false;
			this.lblpromoo0.Visible = false;
			this.DoubleBufferedASD(this.dgvnotas, true);
			this.habilitaControles(false);
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
			this.dgvnotas.Enabled = true;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x000FAA68 File Offset: 0x000F8C68
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
						this.habilitaControles(true);
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
					}
				}
				else
				{
					this.habilitaControles(false);
					sqlDataReader.Close();
				}
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000FAD04 File Offset: 0x000F8F04
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

		// Token: 0x06000F82 RID: 3970 RVA: 0x000FAFE0 File Offset: 0x000F91E0
		private void habilitaControles(bool boolDeasbilita)
		{
			if (boolDeasbilita)
			{
				this.btnVistaPrevia.Text = "Vista Previa";
				this.GroupBox1.Enabled = true;
				this.groupPeriodo.Enabled = true;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
				this.dateFechaIni.Enabled = true;
				this.dateFechaFin.Enabled = true;
				this.btnVistaPrevia.Enabled = true;
				this.BtnHorario.Visible = true;
				this.Label27.Visible = true;
				this.BtnHorario.Enabled = true;
				this.btnExportar.Visible = true;
				this.lblexportar.Visible = true;
			}
			else
			{
				this.btnVistaPrevia.Text = "Espere...";
				this.GroupBox1.Enabled = false;
				this.ComboBox1.Enabled = false;
				this.dateFechaFin.Enabled = false;
				this.dateFechaIni.Enabled = false;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
				this.btnVistaPrevia.Enabled = false;
				this.BtnHorario.Visible = false;
				this.Label27.Visible = false;
				this.BtnHorario.Enabled = false;
				this.btnExportar.Visible = false;
				this.lblexportar.Visible = false;
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000FB158 File Offset: 0x000F9358
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = Conversions.ToString(0);
			string text2 = Conversions.ToString(0);
			string text3 = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text4 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			string text5 = Conversions.ToString(DateAndTime.DateDiff(DateInterval.Day, Conversions.ToDate(this.dateFechaIni.Text), Conversions.ToDate(this.dateFechaFin.Text), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
			bool @checked = this.CheckBoxVentasDia.Checked;
			if (@checked)
			{
				this.iniciaGridFolio();
				this.GroupBox2.Visible = true;
				this.GroupBox3.Visible = false;
				this.Pictureboxindicador1.Visible = false;
				this.lblpromoo0.Visible = false;
				string query_conn = string.Concat(new string[]
				{
					"Select m,a,b,c,d,e,f,g,h,i,j,k,l from K where m between '",
					text3,
					"' and '",
					text4,
					"' order by m asc "
				});
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						DateTime dateTime = Conversions.ToDate(sqlDataReader[0]);
						double num = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[1].ToString().Trim()));
						double num2 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()));
						double num3 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[3].ToString().Trim()));
						double num4 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[4].ToString().Trim()));
						double num5 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[5].ToString().Trim()));
						double num6 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[6].ToString().Trim()));
						double num7 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[7].ToString().Trim()));
						double num8 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[8].ToString().Trim()));
						double num9 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[9].ToString().Trim()));
						double num10 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[10].ToString().Trim()));
						text = Tools.Desencriptar(sqlDataReader[11].ToString().Trim());
						text2 = Tools.Desencriptar(sqlDataReader[12].ToString().Trim());
						this.dgvnotas.Rows.Add(new object[]
						{
							dateTime,
							"$ " + num.ToString("N2"),
							"$ " + num2.ToString("N2"),
							"$ " + num3.ToString("N2"),
							"$ " + num4.ToString("N2"),
							"$ " + num5.ToString("N2"),
							"$ " + num6.ToString("N2"),
							"$ " + num7.ToString("N2"),
							"$ " + num8.ToString("N2"),
							"$ " + num9.ToString("N2"),
							"$ " + num10.ToString("N2"),
							text,
							text2
						});
					}
					sqlDataReader.Close();
					double num11 = 0.0;
					double num12 = 0.0;
					double num13 = 0.0;
					double num14 = 0.0;
					double num15 = 0.0;
					double num16 = 0.0;
					double num17 = 0.0;
					double num18 = 0.0;
					double num19 = 0.0;
					string text6 = Conversions.ToString(0);
					string text7 = Conversions.ToString(0);
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvnotas.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							num11 += Conversions.ToDouble(dataGridViewRow.Cells["Alimentos"].Value);
							num12 += Conversions.ToDouble(dataGridViewRow.Cells["Bebidas"].Value);
							num13 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
							num14 += Conversions.ToDouble(dataGridViewRow.Cells["Cortesias"].Value);
							num15 += Conversions.ToDouble(dataGridViewRow.Cells["Descuentos"].Value);
							num16 += Conversions.ToDouble(dataGridViewRow.Cells["Venta bruta"].Value);
							num17 += Conversions.ToDouble(dataGridViewRow.Cells["Impuestos"].Value);
							num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total C/Impuestos"].Value);
							num19 += Conversions.ToDouble(dataGridViewRow.Cells["Propina"].Value);
							text6 = Conversions.ToString(Conversions.ToDouble(text6) + Conversions.ToDouble(dataGridViewRow.Cells["Personas"].Value));
							text7 = Conversions.ToString(Conversions.ToDouble(text7) + Conversions.ToDouble(dataGridViewRow.Cells["Cuentas"].Value));
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
					this.txttotalalimentos.Text = "$ " + num11.ToString("N2");
					this.Txttotalbebidas.Text = "$ " + num12.ToString("N2");
					this.txtTotalOtros.Text = "$ " + num13.ToString("N2");
					this.txtTotalCortesias.Text = "$ " + num14.ToString("N2");
					this.txttotaldescuentos.Text = "$ " + num15.ToString("N2");
					this.TxtTotalventabruta.Text = "$ " + num16.ToString("N2");
					this.txtTotalImpuestos.Text = "$ " + num17.ToString("N2");
					this.txttotalconimpuesto.Text = "$ " + num18.ToString("N2");
					this.txtTotalPRopinas.Text = "$ " + num19.ToString("N2");
					this.txtPersonas.Text = "# " + text6.ToString();
					this.txtTotalcuentas.Text = "# " + text7.ToString();
				}
				else
				{
					bool flag = !sqlDataReader.HasRows;
					if (flag)
					{
						Interaction.MsgBox("No hay Registros para mostrar intenta con otro periodo!", MsgBoxStyle.OkOnly, null);
					}
				}
			}
			int num20 = 0;
			int num21 = 0;
			bool checked2 = this.CheckBoxProductosVendidos.Checked;
			if (checked2)
			{
				this.iniciaGriProductosVendidos();
				this.GroupBox2.Visible = false;
				this.GroupBox3.Visible = true;
				this.Pictureboxindicador1.Visible = true;
				this.lblpromoo0.Visible = true;
				this.progBar.Visible = true;
				string query_conn = string.Concat(new string[]
				{
					"select count(*) from J  WHERE \r\n                       e between '",
					text3,
					"' and '",
					text4,
					"'"
				});
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool flag2 = sqlDataReader.Read();
				if (flag2)
				{
					num20 = Conversions.ToInteger(sqlDataReader[0]);
				}
				this.progBar.Value = 0;
				this.progBar.Maximum = checked(num20 + 1);
				query_conn = string.Concat(new string[]
				{
					"select a  , b , c, d , e \r\n                        from J  WHERE \r\n                       e between '",
					text3,
					"' and '",
					text4,
					"'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool hasRows2 = sqlDataReader.HasRows;
				if (hasRows2)
				{
					this.iniciaGriProductosVendidos_Desencriptar();
					string text12;
					double num27;
					checked
					{
						while (sqlDataReader.Read())
						{
							string text8 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							string text9 = Tools.Desencriptar(sqlDataReader[1].ToString().Trim());
							double num22 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[2].ToString().Trim()));
							double num23 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[3].ToString().Trim()));
							DateTime dateTime2 = Conversions.ToDate(sqlDataReader[4]);
							try
							{
								query_conn = string.Concat(new string[]
								{
									"INSERT INTO Aa (a,b,c,d,e) Values ('",
									text8.ToString(),
									"', '",
									text9.ToString(),
									"', '",
									num22.ToString(),
									"', '",
									num23.ToString(),
									"', '",
									dateTime2.ToString(Tools.strFormatoFechaLargo1),
									"') "
								});
								sqlQuery_Conn.execQuery_conn(query_conn);
							}
							catch (Exception ex)
							{
							}
							num21++;
							this.progBar.Value = num21 + 1;
						}
						sqlDataReader.Close();
						this.progBar.Visible = false;
						this.progBar.Value = 0;
						query_conn = string.Concat(new string[]
						{
							"select a.a  ,b.descripcion as 'Descripcion', a.c as 'Precio de Venta', sum(d) as 'Cantidad Vendida' , sum(c*d) as 'Total Vendido' \r\n                        from Aa a \r\n                        Inner Join ",
							Tools.Conn_BaseDeDatos_SoftRestaurant,
							".dbo.productos b on b.idproducto = a.a where a.e between '",
							text3,
							"' and '",
							text4,
							"'\r\n                        group by a.a,b.descripcion,a.c order by 'Cantidad Vendida' desc"
						});
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
						bool hasRows3 = sqlDataReader.HasRows;
						if (hasRows3)
						{
							this.iniciaGriProductosVendidos();
							while (sqlDataReader.Read())
							{
								string text10 = Conversions.ToString(sqlDataReader[0]);
								string text11 = Conversions.ToString(sqlDataReader[1]);
								double num24 = Conversions.ToDouble(sqlDataReader[2]);
								int num25 = Conversions.ToInteger(sqlDataReader[3]);
								double num26 = Conversions.ToDouble(sqlDataReader[4]);
								this.dgvnotas.Rows.Add(new object[]
								{
									text10,
									text11,
									"$ " + num24.ToString("N2"),
									num25,
									"$ " + num26.ToString("N2")
								});
							}
						}
						query_conn = "Delete from Aa";
						sqlQuery_Conn.execQuery_conn(query_conn);
						text12 = Conversions.ToString(0);
						num27 = 0.0;
					}
					try
					{
						foreach (object obj2 in ((IEnumerable)this.dgvnotas.Rows))
						{
							DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
							text12 = Conversions.ToString(Conversions.ToDouble(text12) + Conversions.ToDouble(dataGridViewRow2.Cells["Cantidad Vendida"].Value));
							num27 += Conversions.ToDouble(dataGridViewRow2.Cells["Total Vendido"].Value);
							bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Precio de Venta"].Value, 0, false);
							if (flag3)
							{
								dataGridViewRow2.DefaultCellStyle.BackColor = Color.LightBlue;
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
					this.lblTotalCantidad.Text = "# " + text12.ToString();
					this.txtTotalVentaProductos.Text = "$ " + num27.ToString("N2");
				}
				else
				{
					bool flag4 = !sqlDataReader.HasRows;
					if (flag4)
					{
						this.dgvnotas.Rows.Clear();
						this.progBar.Visible = false;
						this.progBar.Value = 0;
						Interaction.MsgBox("No hay Registros para mostrar intenta con otro periodo!", MsgBoxStyle.OkOnly, null);
					}
				}
			}
			this.DgvDesencriptar.Rows.Clear();
			this.dgvnotas.ClearSelection();
			this.ComboBox1.Enabled = false;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000FBF3C File Offset: 0x000FA13C
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000FBF70 File Offset: 0x000FA170
		private void iniciaGridFolio()
		{
			this.dgvnotas.Rows.Clear();
			this.dgvnotas.ColumnCount = 15;
			this.dgvnotas.Columns[0].Name = "Fecha";
			this.dgvnotas.Columns[0].Width = 140;
			this.dgvnotas.Columns[0].Visible = true;
			this.dgvnotas.Columns[0].ReadOnly = true;
			this.dgvnotas.Columns[1].Name = "Alimentos";
			this.dgvnotas.Columns[1].Width = 100;
			this.dgvnotas.Columns[1].ReadOnly = true;
			this.dgvnotas.Columns[2].Name = "Bebidas";
			this.dgvnotas.Columns[2].Width = 100;
			this.dgvnotas.Columns[2].ReadOnly = true;
			this.dgvnotas.Columns[3].Name = "Otros";
			this.dgvnotas.Columns[3].Width = 100;
			this.dgvnotas.Columns[3].ReadOnly = true;
			this.dgvnotas.Columns[4].Name = "Cortesias";
			this.dgvnotas.Columns[4].Width = 100;
			this.dgvnotas.Columns[4].ReadOnly = true;
			this.dgvnotas.Columns[5].Name = "Descuentos";
			this.dgvnotas.Columns[5].Width = 100;
			this.dgvnotas.Columns[5].ReadOnly = true;
			this.dgvnotas.Columns[6].Name = "Venta bruta";
			this.dgvnotas.Columns[6].Width = 100;
			this.dgvnotas.Columns[6].ReadOnly = true;
			this.dgvnotas.Columns[7].Name = "Impuestos";
			this.dgvnotas.Columns[7].Width = 100;
			this.dgvnotas.Columns[7].ReadOnly = true;
			this.dgvnotas.Columns[8].Name = "Total C/Impuestos";
			this.dgvnotas.Columns[8].Width = 100;
			this.dgvnotas.Columns[8].ReadOnly = true;
			this.dgvnotas.Columns[9].Name = "Propina";
			this.dgvnotas.Columns[9].Width = 100;
			this.dgvnotas.Columns[9].ReadOnly = true;
			this.dgvnotas.Columns[10].Name = "Total C/Propina";
			this.dgvnotas.Columns[10].Width = 100;
			this.dgvnotas.Columns[10].ReadOnly = true;
			this.dgvnotas.Columns[11].Name = "Personas";
			this.dgvnotas.Columns[11].Width = 80;
			this.dgvnotas.Columns[11].ReadOnly = true;
			this.dgvnotas.Columns[12].Name = "Cuentas";
			this.dgvnotas.Columns[12].Width = 100;
			this.dgvnotas.Columns[12].ReadOnly = true;
			this.dgvnotas.Columns[13].Name = "Promedio por persona";
			this.dgvnotas.Columns[13].Width = 100;
			this.dgvnotas.Columns[13].ReadOnly = true;
			this.dgvnotas.Columns[13].Visible = false;
			this.dgvnotas.Columns[14].Name = "Promedio por cuenta";
			this.dgvnotas.Columns[14].Width = 100;
			this.dgvnotas.Columns[14].ReadOnly = true;
			this.dgvnotas.Columns[14].Visible = false;
			this.DoubleBufferedASD(this.dgvnotas, true);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000FC490 File Offset: 0x000FA690
		private void iniciaGriProductosVendidos()
		{
			this.dgvnotas.Rows.Clear();
			this.dgvnotas.ColumnCount = 5;
			this.dgvnotas.Columns[0].Name = "idProducto";
			this.dgvnotas.Columns[0].Width = 40;
			this.dgvnotas.Columns[0].Visible = false;
			this.dgvnotas.Columns[0].ReadOnly = true;
			this.dgvnotas.Columns[1].Name = "Descripcion";
			this.dgvnotas.Columns[1].Width = 300;
			this.dgvnotas.Columns[1].ReadOnly = true;
			this.dgvnotas.Columns[2].Name = "Precio de Venta";
			this.dgvnotas.Columns[2].Width = 100;
			this.dgvnotas.Columns[2].ReadOnly = true;
			this.dgvnotas.Columns[3].Name = "Cantidad Vendida";
			this.dgvnotas.Columns[3].Width = 100;
			this.dgvnotas.Columns[3].ReadOnly = true;
			this.dgvnotas.Columns[4].Name = "Total Vendido";
			this.dgvnotas.Columns[4].Width = 100;
			this.dgvnotas.Columns[4].ReadOnly = true;
			bool @checked = this.CheckBoxVentasDia.Checked;
			if (@checked)
			{
				this.CheckBoxProductosVendidos.Checked = false;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000FC678 File Offset: 0x000FA878
		private void iniciaGriProductosVendidos_Desencriptar()
		{
			this.DgvDesencriptar.Rows.Clear();
			this.DgvDesencriptar.ColumnCount = 5;
			this.DgvDesencriptar.Columns[0].Name = "idProducto";
			this.DgvDesencriptar.Columns[0].Width = 40;
			this.DgvDesencriptar.Columns[0].Visible = false;
			this.DgvDesencriptar.Columns[0].ReadOnly = true;
			this.DgvDesencriptar.Columns[1].Name = "Descripcion";
			this.DgvDesencriptar.Columns[1].Width = 300;
			this.DgvDesencriptar.Columns[1].ReadOnly = true;
			this.DgvDesencriptar.Columns[2].Name = "Precio de Venta";
			this.DgvDesencriptar.Columns[2].Width = 100;
			this.DgvDesencriptar.Columns[2].ReadOnly = true;
			this.DgvDesencriptar.Columns[3].Name = "Cantidad Vendida";
			this.DgvDesencriptar.Columns[3].Width = 100;
			this.DgvDesencriptar.Columns[3].ReadOnly = true;
			this.DgvDesencriptar.Columns[4].Name = "Fecha";
			this.DgvDesencriptar.Columns[4].Width = 100;
			this.DgvDesencriptar.Columns[4].ReadOnly = true;
			this.DoubleBufferedASD(this.DgvDesencriptar, true);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000FC850 File Offset: 0x000FAA50
		private void CheckBoxVentasDia_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBoxVentasDia.Checked;
			if (@checked)
			{
				this.CheckBoxProductosVendidos.Checked = false;
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000FC87C File Offset: 0x000FAA7C
		private void CheckBoxProductosVendidos_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBoxProductosVendidos.Checked;
			if (@checked)
			{
				this.CheckBoxVentasDia.Checked = false;
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000FC8A8 File Offset: 0x000FAAA8
		private void BtnHorario_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("Verifica la configuracion del horario turnos , estas modificando el horario predeterminado , dirigete al SoftRestaurant en la pestaña Configuracion General>>Horarios de turno.", MsgBoxStyle.OkOnly, null);
			this.BtnHorario.Enabled = false;
			this.dateHoraIni.Enabled = true;
			this.dateHoraFin.Enabled = true;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000036D5 File Offset: 0x000018D5
		private void groupPeriodo_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000FC8E0 File Offset: 0x000FAAE0
		private void btnExportar_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			object value = Missing.Value;
			bool flag = this.dgvnotas.RowCount == 0;
			checked
			{
				if (flag)
				{
					Interaction.MsgBox("No hay registros para exportar, Intenta con otro periodo!", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					bool @checked = this.CheckBoxVentasDia.Checked;
					if (@checked)
					{
						using (SaveFileDialog saveFileDialog = new SaveFileDialog
						{
							Filter = "Libro de Excel|*.xlsx",
							FileName = "Reporte Ventas-" + this.ComboBox1.Text
						})
						{
							bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
							if (flag2)
							{
								this.progBar.Visible = true;
								Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
								Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(value));
								Worksheet worksheet = (Worksheet)workbook.Sheets["hoja1"];
								string query_conn = string.Concat(new string[]
								{
									"Select count(*) from K where m between '",
									text,
									"' and '",
									text2,
									"'"
								});
								SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
								bool hasRows = sqlDataReader.HasRows;
								if (hasRows)
								{
									sqlDataReader.Read();
									num = Conversions.ToInteger(sqlDataReader[0]);
								}
								sqlDataReader.Close();
								this.progBar.Value = 0;
								this.progBar.Maximum = num + 1;
								int num3 = this.dgvnotas.Columns.Count - 1;
								for (int i = 1; i <= num3; i++)
								{
									worksheet.Cells[1, i + 0] = this.dgvnotas.Columns[i - 1].Name;
								}
								int num4 = this.dgvnotas.Rows.Count - 1;
								for (int j = 0; j <= num4; j++)
								{
									int num5 = this.dgvnotas.ColumnCount - 1;
									for (int k = 0; k <= num5; k++)
									{
										worksheet.Cells[j + 2, k + 1] = RuntimeHelpers.GetObjectValue(this.dgvnotas[k, j].Value);
									}
									num2++;
									this.progBar.Value = num2 + 1;
								}
								try
								{
									worksheet.SaveAs(saveFileDialog.FileName, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
									workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
									application.Quit();
									this.releaseobject(application);
									this.releaseobject(workbook);
									this.releaseobject(worksheet);
									Interaction.MsgBox("Archivo creado correctamente!", MsgBoxStyle.OkOnly, null);
									this.progBar.Visible = true;
									this.progBar.Value = 0;
								}
								catch (Exception ex)
								{
									this.progBar.Value = 0;
									Interaction.MsgBox("El libro de excel no se pudo crear, *MOTIVO : el libro de excel se encuentra abierto* , cierralo e intenta nuevamente o asigna otro nombre al libro de excel para guardarlo!", MsgBoxStyle.OkOnly, null);
								}
							}
						}
					}
					bool checked2 = this.CheckBoxProductosVendidos.Checked;
					if (checked2)
					{
						this.lblcounter.Text = Conversions.ToString(this.dgvnotas.RowCount);
						num = Conversions.ToInteger(this.lblcounter.Text);
						using (SaveFileDialog saveFileDialog2 = new SaveFileDialog
						{
							Filter = "Libro de Excel|*.xlsx",
							FileName = "Reporte Popularidad de Productos-" + this.ComboBox1.Text
						})
						{
							bool flag3 = saveFileDialog2.ShowDialog() == DialogResult.OK;
							if (flag3)
							{
								this.progBar.Visible = true;
								Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
								Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(value));
								Worksheet worksheet = (Worksheet)workbook.Sheets["hoja1"];
								this.progBar.Value = 0;
								this.progBar.Maximum = num + 1;
								int num6 = this.dgvnotas.Columns.Count - 1;
								for (int l = 1; l <= num6; l++)
								{
									worksheet.Cells[1, l + 0] = this.dgvnotas.Columns[l - 1].Name;
								}
								int num7 = this.dgvnotas.Rows.Count - 1;
								for (int j = 0; j <= num7; j++)
								{
									int num8 = this.dgvnotas.ColumnCount - 1;
									for (int k = 0; k <= num8; k++)
									{
										worksheet.Cells[j + 2, k + 1] = RuntimeHelpers.GetObjectValue(this.dgvnotas[k, j].Value);
									}
									num2++;
									this.progBar.Value = num2 + 1;
								}
								try
								{
									worksheet.SaveAs(saveFileDialog2.FileName, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
									workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
									application.Quit();
									this.releaseobject(application);
									this.releaseobject(workbook);
									this.releaseobject(worksheet);
									Interaction.MsgBox("Archivo creado correctamente!", MsgBoxStyle.OkOnly, null);
									this.progBar.Visible = true;
									this.progBar.Value = 0;
								}
								catch (Exception ex2)
								{
									this.progBar.Value = 0;
									Interaction.MsgBox("El libro de excel no se pudo crear, *MOTIVO : el libro de excel se encuentra abierto* , cierralo e intenta nuevamente o asigna otro nombre al libro de excel para guardarlo!", MsgBoxStyle.OkOnly, null);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000FD034 File Offset: 0x000FB234
		private void releaseobject(object obj)
		{
			try
			{
				Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
			}
			finally
			{
				GC.Collect();
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
