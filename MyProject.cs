using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional.My
{
	// Token: 0x0200002D RID: 45
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x00115598 File Offset: 0x00113798
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x001155B4 File Offset: 0x001137B4
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x001155D0 File Offset: 0x001137D0
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x001155EC File Offset: 0x001137EC
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00115608 File Offset: 0x00113808
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x040007F5 RID: 2037
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x040007F6 RID: 2038
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x040007F7 RID: 2039
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x040007F8 RID: 2040
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x040007F9 RID: 2041
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000046 RID: 70
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x0600129D RID: 4765 RVA: 0x00119304 File Offset: 0x00117504
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x0600129E RID: 4766 RVA: 0x0011942C File Offset: 0x0011762C
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x0600129F RID: 4767 RVA: 0x00119443 File Offset: 0x00117643
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x060012A0 RID: 4768 RVA: 0x00119450 File Offset: 0x00117650
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x060012A1 RID: 4769 RVA: 0x00119470 File Offset: 0x00117670
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060012A2 RID: 4770 RVA: 0x00119488 File Offset: 0x00117688
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x060012A3 RID: 4771 RVA: 0x001194A4 File Offset: 0x001176A4
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x060012A4 RID: 4772 RVA: 0x001194BC File Offset: 0x001176BC
			// (set) Token: 0x060012CA RID: 4810 RVA: 0x001198BE File Offset: 0x00117ABE
			public Form1 Form1
			{
				[DebuggerHidden]
				get
				{
					this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
					return this.m_Form1;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Form1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form1>(ref this.m_Form1);
					}
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x060012A5 RID: 4773 RVA: 0x001194D7 File Offset: 0x001176D7
			// (set) Token: 0x060012CB RID: 4811 RVA: 0x001198EA File Offset: 0x00117AEA
			public FormListadoFormasDePago FormListadoFormasDePago
			{
				[DebuggerHidden]
				get
				{
					this.m_FormListadoFormasDePago = MyProject.MyForms.Create__Instance__<FormListadoFormasDePago>(this.m_FormListadoFormasDePago);
					return this.m_FormListadoFormasDePago;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FormListadoFormasDePago)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormListadoFormasDePago>(ref this.m_FormListadoFormasDePago);
					}
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x060012A6 RID: 4774 RVA: 0x001194F2 File Offset: 0x001176F2
			// (set) Token: 0x060012CC RID: 4812 RVA: 0x00119916 File Offset: 0x00117B16
			public FormModificarTicket FormModificarTicket
			{
				[DebuggerHidden]
				get
				{
					this.m_FormModificarTicket = MyProject.MyForms.Create__Instance__<FormModificarTicket>(this.m_FormModificarTicket);
					return this.m_FormModificarTicket;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FormModificarTicket)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormModificarTicket>(ref this.m_FormModificarTicket);
					}
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0011950D File Offset: 0x0011770D
			// (set) Token: 0x060012CD RID: 4813 RVA: 0x00119942 File Offset: 0x00117B42
			public FormRespaldoSQL FormRespaldoSQL
			{
				[DebuggerHidden]
				get
				{
					this.m_FormRespaldoSQL = MyProject.MyForms.Create__Instance__<FormRespaldoSQL>(this.m_FormRespaldoSQL);
					return this.m_FormRespaldoSQL;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FormRespaldoSQL)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormRespaldoSQL>(ref this.m_FormRespaldoSQL);
					}
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00119528 File Offset: 0x00117728
			// (set) Token: 0x060012CE RID: 4814 RVA: 0x0011996E File Offset: 0x00117B6E
			public FrmAlertaDePanico FrmAlertaDePanico
			{
				[DebuggerHidden]
				get
				{
					this.m_FrmAlertaDePanico = MyProject.MyForms.Create__Instance__<FrmAlertaDePanico>(this.m_FrmAlertaDePanico);
					return this.m_FrmAlertaDePanico;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FrmAlertaDePanico)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FrmAlertaDePanico>(ref this.m_FrmAlertaDePanico);
					}
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00119543 File Offset: 0x00117743
			// (set) Token: 0x060012CF RID: 4815 RVA: 0x0011999A File Offset: 0x00117B9A
			public frmAutoFactura frmAutoFactura
			{
				[DebuggerHidden]
				get
				{
					this.m_frmAutoFactura = MyProject.MyForms.Create__Instance__<frmAutoFactura>(this.m_frmAutoFactura);
					return this.m_frmAutoFactura;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmAutoFactura)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmAutoFactura>(ref this.m_frmAutoFactura);
					}
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x060012AA RID: 4778 RVA: 0x0011955E File Offset: 0x0011775E
			// (set) Token: 0x060012D0 RID: 4816 RVA: 0x001199C6 File Offset: 0x00117BC6
			public frmAutoUpdate frmAutoUpdate
			{
				[DebuggerHidden]
				get
				{
					this.m_frmAutoUpdate = MyProject.MyForms.Create__Instance__<frmAutoUpdate>(this.m_frmAutoUpdate);
					return this.m_frmAutoUpdate;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmAutoUpdate)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmAutoUpdate>(ref this.m_frmAutoUpdate);
					}
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x060012AB RID: 4779 RVA: 0x00119579 File Offset: 0x00117779
			// (set) Token: 0x060012D1 RID: 4817 RVA: 0x001199F2 File Offset: 0x00117BF2
			public frmAvisoDistintoTodas frmAvisoDistintoTodas
			{
				[DebuggerHidden]
				get
				{
					this.m_frmAvisoDistintoTodas = MyProject.MyForms.Create__Instance__<frmAvisoDistintoTodas>(this.m_frmAvisoDistintoTodas);
					return this.m_frmAvisoDistintoTodas;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmAvisoDistintoTodas)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmAvisoDistintoTodas>(ref this.m_frmAvisoDistintoTodas);
					}
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x060012AC RID: 4780 RVA: 0x00119594 File Offset: 0x00117794
			// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00119A1E File Offset: 0x00117C1E
			public frmAvisoTodas frmAvisoTodas
			{
				[DebuggerHidden]
				get
				{
					this.m_frmAvisoTodas = MyProject.MyForms.Create__Instance__<frmAvisoTodas>(this.m_frmAvisoTodas);
					return this.m_frmAvisoTodas;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmAvisoTodas)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmAvisoTodas>(ref this.m_frmAvisoTodas);
					}
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x060012AD RID: 4781 RVA: 0x001195AF File Offset: 0x001177AF
			// (set) Token: 0x060012D3 RID: 4819 RVA: 0x00119A4A File Offset: 0x00117C4A
			public FrmBitacora FrmBitacora
			{
				[DebuggerHidden]
				get
				{
					this.m_FrmBitacora = MyProject.MyForms.Create__Instance__<FrmBitacora>(this.m_FrmBitacora);
					return this.m_FrmBitacora;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FrmBitacora)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FrmBitacora>(ref this.m_FrmBitacora);
					}
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x060012AE RID: 4782 RVA: 0x001195CA File Offset: 0x001177CA
			// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00119A76 File Offset: 0x00117C76
			public frmDatosEmpresa frmDatosEmpresa
			{
				[DebuggerHidden]
				get
				{
					this.m_frmDatosEmpresa = MyProject.MyForms.Create__Instance__<frmDatosEmpresa>(this.m_frmDatosEmpresa);
					return this.m_frmDatosEmpresa;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmDatosEmpresa)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmDatosEmpresa>(ref this.m_frmDatosEmpresa);
					}
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x060012AF RID: 4783 RVA: 0x001195E5 File Offset: 0x001177E5
			// (set) Token: 0x060012D5 RID: 4821 RVA: 0x00119AA2 File Offset: 0x00117CA2
			public frmDownLicencias frmDownLicencias
			{
				[DebuggerHidden]
				get
				{
					this.m_frmDownLicencias = MyProject.MyForms.Create__Instance__<frmDownLicencias>(this.m_frmDownLicencias);
					return this.m_frmDownLicencias;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmDownLicencias)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmDownLicencias>(ref this.m_frmDownLicencias);
					}
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00119600 File Offset: 0x00117800
			// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00119ACE File Offset: 0x00117CCE
			public frmEditarTicketvb frmEditarTicketvb
			{
				[DebuggerHidden]
				get
				{
					this.m_frmEditarTicketvb = MyProject.MyForms.Create__Instance__<frmEditarTicketvb>(this.m_frmEditarTicketvb);
					return this.m_frmEditarTicketvb;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmEditarTicketvb)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmEditarTicketvb>(ref this.m_frmEditarTicketvb);
					}
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0011961B File Offset: 0x0011781B
			// (set) Token: 0x060012D7 RID: 4823 RVA: 0x00119AFA File Offset: 0x00117CFA
			public frmEditarTurnos frmEditarTurnos
			{
				[DebuggerHidden]
				get
				{
					this.m_frmEditarTurnos = MyProject.MyForms.Create__Instance__<frmEditarTurnos>(this.m_frmEditarTurnos);
					return this.m_frmEditarTurnos;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmEditarTurnos)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmEditarTurnos>(ref this.m_frmEditarTurnos);
					}
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00119636 File Offset: 0x00117836
			// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00119B26 File Offset: 0x00117D26
			public frmElegirEmpresa frmElegirEmpresa
			{
				[DebuggerHidden]
				get
				{
					this.m_frmElegirEmpresa = MyProject.MyForms.Create__Instance__<frmElegirEmpresa>(this.m_frmElegirEmpresa);
					return this.m_frmElegirEmpresa;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmElegirEmpresa)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmElegirEmpresa>(ref this.m_frmElegirEmpresa);
					}
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00119651 File Offset: 0x00117851
			// (set) Token: 0x060012D9 RID: 4825 RVA: 0x00119B52 File Offset: 0x00117D52
			public frmEliminar1Producto frmEliminar1Producto
			{
				[DebuggerHidden]
				get
				{
					this.m_frmEliminar1Producto = MyProject.MyForms.Create__Instance__<frmEliminar1Producto>(this.m_frmEliminar1Producto);
					return this.m_frmEliminar1Producto;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmEliminar1Producto)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmEliminar1Producto>(ref this.m_frmEliminar1Producto);
					}
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0011966C File Offset: 0x0011786C
			// (set) Token: 0x060012DA RID: 4826 RVA: 0x00119B7E File Offset: 0x00117D7E
			public frmEliminarProdFormasdePago frmEliminarProdFormasdePago
			{
				[DebuggerHidden]
				get
				{
					this.m_frmEliminarProdFormasdePago = MyProject.MyForms.Create__Instance__<frmEliminarProdFormasdePago>(this.m_frmEliminarProdFormasdePago);
					return this.m_frmEliminarProdFormasdePago;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmEliminarProdFormasdePago)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmEliminarProdFormasdePago>(ref this.m_frmEliminarProdFormasdePago);
					}
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00119687 File Offset: 0x00117887
			// (set) Token: 0x060012DB RID: 4827 RVA: 0x00119BAA File Offset: 0x00117DAA
			public frmEliminarProducto frmEliminarProducto
			{
				[DebuggerHidden]
				get
				{
					this.m_frmEliminarProducto = MyProject.MyForms.Create__Instance__<frmEliminarProducto>(this.m_frmEliminarProducto);
					return this.m_frmEliminarProducto;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmEliminarProducto)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmEliminarProducto>(ref this.m_frmEliminarProducto);
					}
				}
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x060012B6 RID: 4790 RVA: 0x001196A2 File Offset: 0x001178A2
			// (set) Token: 0x060012DC RID: 4828 RVA: 0x00119BD6 File Offset: 0x00117DD6
			public frmEmail frmEmail
			{
				[DebuggerHidden]
				get
				{
					this.m_frmEmail = MyProject.MyForms.Create__Instance__<frmEmail>(this.m_frmEmail);
					return this.m_frmEmail;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmEmail)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmEmail>(ref this.m_frmEmail);
					}
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x060012B7 RID: 4791 RVA: 0x001196BD File Offset: 0x001178BD
			// (set) Token: 0x060012DD RID: 4829 RVA: 0x00119C02 File Offset: 0x00117E02
			public frmEMPF frmEMPF
			{
				[DebuggerHidden]
				get
				{
					this.m_frmEMPF = MyProject.MyForms.Create__Instance__<frmEMPF>(this.m_frmEMPF);
					return this.m_frmEMPF;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmEMPF)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmEMPF>(ref this.m_frmEMPF);
					}
				}
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x060012B8 RID: 4792 RVA: 0x001196D8 File Offset: 0x001178D8
			// (set) Token: 0x060012DE RID: 4830 RVA: 0x00119C2E File Offset: 0x00117E2E
			public frmImprimir_Tickets frmImprimir_Tickets
			{
				[DebuggerHidden]
				get
				{
					this.m_frmImprimir_Tickets = MyProject.MyForms.Create__Instance__<frmImprimir_Tickets>(this.m_frmImprimir_Tickets);
					return this.m_frmImprimir_Tickets;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmImprimir_Tickets)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmImprimir_Tickets>(ref this.m_frmImprimir_Tickets);
					}
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x060012B9 RID: 4793 RVA: 0x001196F3 File Offset: 0x001178F3
			// (set) Token: 0x060012DF RID: 4831 RVA: 0x00119C5A File Offset: 0x00117E5A
			public frmLicencia frmLicencia
			{
				[DebuggerHidden]
				get
				{
					this.m_frmLicencia = MyProject.MyForms.Create__Instance__<frmLicencia>(this.m_frmLicencia);
					return this.m_frmLicencia;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmLicencia)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmLicencia>(ref this.m_frmLicencia);
					}
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x060012BA RID: 4794 RVA: 0x0011970E File Offset: 0x0011790E
			// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00119C86 File Offset: 0x00117E86
			public frmLicencias frmLicencias
			{
				[DebuggerHidden]
				get
				{
					this.m_frmLicencias = MyProject.MyForms.Create__Instance__<frmLicencias>(this.m_frmLicencias);
					return this.m_frmLicencias;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmLicencias)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmLicencias>(ref this.m_frmLicencias);
					}
				}
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x060012BB RID: 4795 RVA: 0x00119729 File Offset: 0x00117929
			// (set) Token: 0x060012E1 RID: 4833 RVA: 0x00119CB2 File Offset: 0x00117EB2
			public frmLogin frmLogin
			{
				[DebuggerHidden]
				get
				{
					this.m_frmLogin = MyProject.MyForms.Create__Instance__<frmLogin>(this.m_frmLogin);
					return this.m_frmLogin;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmLogin)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmLogin>(ref this.m_frmLogin);
					}
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x060012BC RID: 4796 RVA: 0x00119744 File Offset: 0x00117944
			// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00119CDE File Offset: 0x00117EDE
			public FrmModificarTicket FrmModificarTicket
			{
				[DebuggerHidden]
				get
				{
					this.m_FrmModificarTicket = MyProject.MyForms.Create__Instance__<FrmModificarTicket>(this.m_FrmModificarTicket);
					return this.m_FrmModificarTicket;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FrmModificarTicket)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FrmModificarTicket>(ref this.m_FrmModificarTicket);
					}
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x060012BD RID: 4797 RVA: 0x0011975F File Offset: 0x0011795F
			// (set) Token: 0x060012E3 RID: 4835 RVA: 0x00119D0A File Offset: 0x00117F0A
			public frmParametros frmParametros
			{
				[DebuggerHidden]
				get
				{
					this.m_frmParametros = MyProject.MyForms.Create__Instance__<frmParametros>(this.m_frmParametros);
					return this.m_frmParametros;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmParametros)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmParametros>(ref this.m_frmParametros);
					}
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x060012BE RID: 4798 RVA: 0x0011977A File Offset: 0x0011797A
			// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00119D36 File Offset: 0x00117F36
			public frmProductos frmProductos
			{
				[DebuggerHidden]
				get
				{
					this.m_frmProductos = MyProject.MyForms.Create__Instance__<frmProductos>(this.m_frmProductos);
					return this.m_frmProductos;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmProductos)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmProductos>(ref this.m_frmProductos);
					}
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x060012BF RID: 4799 RVA: 0x00119795 File Offset: 0x00117995
			// (set) Token: 0x060012E5 RID: 4837 RVA: 0x00119D62 File Offset: 0x00117F62
			public FrmRemplazarProductos FrmRemplazarProductos
			{
				[DebuggerHidden]
				get
				{
					this.m_FrmRemplazarProductos = MyProject.MyForms.Create__Instance__<FrmRemplazarProductos>(this.m_FrmRemplazarProductos);
					return this.m_FrmRemplazarProductos;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FrmRemplazarProductos)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FrmRemplazarProductos>(ref this.m_FrmRemplazarProductos);
					}
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x060012C0 RID: 4800 RVA: 0x001197B0 File Offset: 0x001179B0
			// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00119D8E File Offset: 0x00117F8E
			public frmReportes frmReportes
			{
				[DebuggerHidden]
				get
				{
					this.m_frmReportes = MyProject.MyForms.Create__Instance__<frmReportes>(this.m_frmReportes);
					return this.m_frmReportes;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmReportes)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmReportes>(ref this.m_frmReportes);
					}
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x060012C1 RID: 4801 RVA: 0x001197CB File Offset: 0x001179CB
			// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00119DBA File Offset: 0x00117FBA
			public frmServConfig frmServConfig
			{
				[DebuggerHidden]
				get
				{
					this.m_frmServConfig = MyProject.MyForms.Create__Instance__<frmServConfig>(this.m_frmServConfig);
					return this.m_frmServConfig;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmServConfig)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmServConfig>(ref this.m_frmServConfig);
					}
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x060012C2 RID: 4802 RVA: 0x001197E6 File Offset: 0x001179E6
			// (set) Token: 0x060012E8 RID: 4840 RVA: 0x00119DE6 File Offset: 0x00117FE6
			public frmServLocales frmServLocales
			{
				[DebuggerHidden]
				get
				{
					this.m_frmServLocales = MyProject.MyForms.Create__Instance__<frmServLocales>(this.m_frmServLocales);
					return this.m_frmServLocales;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmServLocales)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmServLocales>(ref this.m_frmServLocales);
					}
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00119801 File Offset: 0x00117A01
			// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00119E12 File Offset: 0x00118012
			public frmTablasSQL frmTablasSQL
			{
				[DebuggerHidden]
				get
				{
					this.m_frmTablasSQL = MyProject.MyForms.Create__Instance__<frmTablasSQL>(this.m_frmTablasSQL);
					return this.m_frmTablasSQL;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmTablasSQL)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmTablasSQL>(ref this.m_frmTablasSQL);
					}
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0011981C File Offset: 0x00117A1C
			// (set) Token: 0x060012EA RID: 4842 RVA: 0x00119E3E File Offset: 0x0011803E
			public frmUsuario frmUsuario
			{
				[DebuggerHidden]
				get
				{
					this.m_frmUsuario = MyProject.MyForms.Create__Instance__<frmUsuario>(this.m_frmUsuario);
					return this.m_frmUsuario;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmUsuario)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmUsuario>(ref this.m_frmUsuario);
					}
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00119837 File Offset: 0x00117A37
			// (set) Token: 0x060012EB RID: 4843 RVA: 0x00119E6A File Offset: 0x0011806A
			public FrmUsuariosPerfiles FrmUsuariosPerfiles
			{
				[DebuggerHidden]
				get
				{
					this.m_FrmUsuariosPerfiles = MyProject.MyForms.Create__Instance__<FrmUsuariosPerfiles>(this.m_FrmUsuariosPerfiles);
					return this.m_FrmUsuariosPerfiles;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FrmUsuariosPerfiles)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FrmUsuariosPerfiles>(ref this.m_FrmUsuariosPerfiles);
					}
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00119852 File Offset: 0x00117A52
			// (set) Token: 0x060012EC RID: 4844 RVA: 0x00119E96 File Offset: 0x00118096
			public frmWaitMsg frmWaitMsg
			{
				[DebuggerHidden]
				get
				{
					this.m_frmWaitMsg = MyProject.MyForms.Create__Instance__<frmWaitMsg>(this.m_frmWaitMsg);
					return this.m_frmWaitMsg;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmWaitMsg)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmWaitMsg>(ref this.m_frmWaitMsg);
					}
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0011986D File Offset: 0x00117A6D
			// (set) Token: 0x060012ED RID: 4845 RVA: 0x00119EC2 File Offset: 0x001180C2
			public gIco gIco
			{
				[DebuggerHidden]
				get
				{
					this.m_gIco = MyProject.MyForms.Create__Instance__<gIco>(this.m_gIco);
					return this.m_gIco;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_gIco)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<gIco>(ref this.m_gIco);
					}
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00119888 File Offset: 0x00117A88
			// (set) Token: 0x060012EE RID: 4846 RVA: 0x00119EEE File Offset: 0x001180EE
			public main main
			{
				[DebuggerHidden]
				get
				{
					this.m_main = MyProject.MyForms.Create__Instance__<main>(this.m_main);
					return this.m_main;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_main)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<main>(ref this.m_main);
					}
				}
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x060012C9 RID: 4809 RVA: 0x001198A3 File Offset: 0x00117AA3
			// (set) Token: 0x060012EF RID: 4847 RVA: 0x00119F1A File Offset: 0x0011811A
			public rIco rIco
			{
				[DebuggerHidden]
				get
				{
					this.m_rIco = MyProject.MyForms.Create__Instance__<rIco>(this.m_rIco);
					return this.m_rIco;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_rIco)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<rIco>(ref this.m_rIco);
					}
				}
			}

			// Token: 0x0400084F RID: 2127
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04000850 RID: 2128
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form1 m_Form1;

			// Token: 0x04000851 RID: 2129
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FormListadoFormasDePago m_FormListadoFormasDePago;

			// Token: 0x04000852 RID: 2130
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FormModificarTicket m_FormModificarTicket;

			// Token: 0x04000853 RID: 2131
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FormRespaldoSQL m_FormRespaldoSQL;

			// Token: 0x04000854 RID: 2132
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmAlertaDePanico m_FrmAlertaDePanico;

			// Token: 0x04000855 RID: 2133
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmAutoFactura m_frmAutoFactura;

			// Token: 0x04000856 RID: 2134
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmAutoUpdate m_frmAutoUpdate;

			// Token: 0x04000857 RID: 2135
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmAvisoDistintoTodas m_frmAvisoDistintoTodas;

			// Token: 0x04000858 RID: 2136
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmAvisoTodas m_frmAvisoTodas;

			// Token: 0x04000859 RID: 2137
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmBitacora m_FrmBitacora;

			// Token: 0x0400085A RID: 2138
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmDatosEmpresa m_frmDatosEmpresa;

			// Token: 0x0400085B RID: 2139
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmDownLicencias m_frmDownLicencias;

			// Token: 0x0400085C RID: 2140
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmEditarTicketvb m_frmEditarTicketvb;

			// Token: 0x0400085D RID: 2141
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmEditarTurnos m_frmEditarTurnos;

			// Token: 0x0400085E RID: 2142
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmElegirEmpresa m_frmElegirEmpresa;

			// Token: 0x0400085F RID: 2143
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmEliminar1Producto m_frmEliminar1Producto;

			// Token: 0x04000860 RID: 2144
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmEliminarProdFormasdePago m_frmEliminarProdFormasdePago;

			// Token: 0x04000861 RID: 2145
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmEliminarProducto m_frmEliminarProducto;

			// Token: 0x04000862 RID: 2146
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmEmail m_frmEmail;

			// Token: 0x04000863 RID: 2147
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmEMPF m_frmEMPF;

			// Token: 0x04000864 RID: 2148
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmImprimir_Tickets m_frmImprimir_Tickets;

			// Token: 0x04000865 RID: 2149
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmLicencia m_frmLicencia;

			// Token: 0x04000866 RID: 2150
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmLicencias m_frmLicencias;

			// Token: 0x04000867 RID: 2151
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmLogin m_frmLogin;

			// Token: 0x04000868 RID: 2152
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmModificarTicket m_FrmModificarTicket;

			// Token: 0x04000869 RID: 2153
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmParametros m_frmParametros;

			// Token: 0x0400086A RID: 2154
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmProductos m_frmProductos;

			// Token: 0x0400086B RID: 2155
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmRemplazarProductos m_FrmRemplazarProductos;

			// Token: 0x0400086C RID: 2156
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmReportes m_frmReportes;

			// Token: 0x0400086D RID: 2157
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmServConfig m_frmServConfig;

			// Token: 0x0400086E RID: 2158
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmServLocales m_frmServLocales;

			// Token: 0x0400086F RID: 2159
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmTablasSQL m_frmTablasSQL;

			// Token: 0x04000870 RID: 2160
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmUsuario m_frmUsuario;

			// Token: 0x04000871 RID: 2161
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmUsuariosPerfiles m_FrmUsuariosPerfiles;

			// Token: 0x04000872 RID: 2162
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmWaitMsg m_frmWaitMsg;

			// Token: 0x04000873 RID: 2163
			[EditorBrowsable(EditorBrowsableState.Never)]
			public gIco m_gIco;

			// Token: 0x04000874 RID: 2164
			[EditorBrowsable(EditorBrowsableState.Never)]
			public main m_main;

			// Token: 0x04000875 RID: 2165
			[EditorBrowsable(EditorBrowsableState.Never)]
			public rIco m_rIco;
		}

		// Token: 0x02000047 RID: 71
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x060012F0 RID: 4848 RVA: 0x00119F48 File Offset: 0x00118148
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x060012F1 RID: 4849 RVA: 0x00119F68 File Offset: 0x00118168
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060012F2 RID: 4850 RVA: 0x00119F80 File Offset: 0x00118180
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x060012F3 RID: 4851 RVA: 0x00119F9C File Offset: 0x0011819C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x060012F4 RID: 4852 RVA: 0x00119FB4 File Offset: 0x001181B4
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x060012F5 RID: 4853 RVA: 0x00119FDD File Offset: 0x001181DD
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x060012F6 RID: 4854 RVA: 0x00119443 File Offset: 0x00117643
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000048 RID: 72
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00119FE8 File Offset: 0x001181E8
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x060012F8 RID: 4856 RVA: 0x00119443 File Offset: 0x00117643
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04000876 RID: 2166
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
