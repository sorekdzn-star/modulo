using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class frmElegirEmpresa : Form
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x0002F23C File Offset: 0x0002D43C
		public frmElegirEmpresa()
		{
			base.Load += this.frmElegirEmpresa_Load;
			this.NumeroDeFilaSeleccionadaParaEliminar = 0;
			this.InitializeComponent();
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000300A9 File Offset: 0x0002E2A9
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x000300B3 File Offset: 0x0002E2B3
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000300BC File Offset: 0x0002E2BC
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x000300C6 File Offset: 0x0002E2C6
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000300CF File Offset: 0x0002E2CF
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x000300D9 File Offset: 0x0002E2D9
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000300E2 File Offset: 0x0002E2E2
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x000300EC File Offset: 0x0002E2EC
		internal virtual Button btnEliminarEmpresa
		{
			[CompilerGenerated]
			get
			{
				return this._btnEliminarEmpresa;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEliminarEmpresa_Click);
				Button btnEliminarEmpresa = this._btnEliminarEmpresa;
				if (btnEliminarEmpresa != null)
				{
					btnEliminarEmpresa.Click -= value2;
				}
				this._btnEliminarEmpresa = value;
				btnEliminarEmpresa = this._btnEliminarEmpresa;
				if (btnEliminarEmpresa != null)
				{
					btnEliminarEmpresa.Click += value2;
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0003012F File Offset: 0x0002E32F
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x0003013C File Offset: 0x0002E33C
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0003017F File Offset: 0x0002E37F
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0003018C File Offset: 0x0002E38C
		internal virtual Button btnNuevaEmpresa
		{
			[CompilerGenerated]
			get
			{
				return this._btnNuevaEmpresa;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button btnNuevaEmpresa = this._btnNuevaEmpresa;
				if (btnNuevaEmpresa != null)
				{
					btnNuevaEmpresa.Click -= value2;
				}
				this._btnNuevaEmpresa = value;
				btnNuevaEmpresa = this._btnNuevaEmpresa;
				if (btnNuevaEmpresa != null)
				{
					btnNuevaEmpresa.Click += value2;
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000301CF File Offset: 0x0002E3CF
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000301D9 File Offset: 0x0002E3D9
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x000301E2 File Offset: 0x0002E3E2
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000301EC File Offset: 0x0002E3EC
		internal virtual DataGridView dgvnotas
		{
			[CompilerGenerated]
			get
			{
				return this._dgvnotas;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvnotas_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvnotas_CellClick);
				DataGridView dgvnotas = this._dgvnotas;
				if (dgvnotas != null)
				{
					dgvnotas.CellContentClick -= value2;
					dgvnotas.CellClick -= value3;
				}
				this._dgvnotas = value;
				dgvnotas = this._dgvnotas;
				if (dgvnotas != null)
				{
					dgvnotas.CellContentClick += value2;
					dgvnotas.CellClick += value3;
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0003024A File Offset: 0x0002E44A
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00030254 File Offset: 0x0002E454
		internal virtual Label lblcadenamodulo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0003025D File Offset: 0x0002E45D
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00030267 File Offset: 0x0002E467
		internal virtual Label lblempresa1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00030270 File Offset: 0x0002E470
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x0003027A File Offset: 0x0002E47A
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00030283 File Offset: 0x0002E483
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x0003028D File Offset: 0x0002E48D
		internal virtual Label lbltotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00030296 File Offset: 0x0002E496
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x000302A0 File Offset: 0x0002E4A0
		internal virtual Label lblnombrearchivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x000302A9 File Offset: 0x0002E4A9
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x000302B4 File Offset: 0x0002E4B4
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x000302F7 File Offset: 0x0002E4F7
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00030301 File Offset: 0x0002E501
		internal virtual Label lblfilaseleccionada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0003030A File Offset: 0x0002E50A
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00030314 File Offset: 0x0002E514
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000458 RID: 1112 RVA: 0x00030320 File Offset: 0x0002E520
		private void frmElegirEmpresa_Load(object sender, EventArgs e)
		{
			this.ListBox1.Items.Clear();
			this.iniciaGridFolio();
			string startupPath = Application.StartupPath;
			this.lbltotal.Text = startupPath;
			try
			{
				ReadOnlyCollection<string> files = MyProject.Computer.FileSystem.GetFiles(startupPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[]
				{
					"*.txt"
				});
				this.lbltotal.Text = "Total Archivos de Texto: " + Conversions.ToString(files.Count);
				try
				{
					foreach (string item in MyProject.Computer.FileSystem.GetFiles(startupPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[]
					{
						"*.txt"
					}))
					{
						this.ListBox1.Items.Add(item);
					}
				}
				finally
				{
					IEnumerator<string> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("No se realizó la operación por: " + ex.Message, MsgBoxStyle.OkOnly, null);
			}
			int num = 1;
			checked
			{
				try
				{
					foreach (object value in this.ListBox1.Items)
					{
						string text = Conversions.ToString(value);
						bool flag = MyProject.Computer.FileSystem.FileExists(text);
						if (flag)
						{
							StreamReader streamReader = MyProject.Computer.FileSystem.OpenTextFileReader(text);
							this.stringReader = streamReader.ReadLine();
							bool flag2 = Microsoft.VisualBasic.FileSystem.FileLen(text) > 0L;
							if (flag2)
							{
								this.lblcadenamodulo.Text = MyProject.Computer.FileSystem.ReadAllText(text);
								this.lblcadenamodulo.Text = Tools.Desencriptar(this.stringReader.ToString().Trim());
								string fileName = Path.GetFileName(text);
								this.RutaFileConn = this.lblcadenamodulo.Text;
								this.lblempresa1.Text = this.RutaFileConn.Substring(0, this.RutaFileConn.IndexOf(";#####;"));
								this.dgvnotas.Rows.Add(new object[]
								{
									num,
									this.lblempresa1.Text,
									text.ToString(),
									fileName.ToString()
								});
								num++;
							}
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
				this.ListBox1.ClearSelected();
				this.dgvnotas.ClearSelection();
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000305F8 File Offset: 0x0002E7F8
		private void iniciaGridFolio()
		{
			this.dgvnotas.Rows.Clear();
			this.dgvnotas.ColumnCount = 4;
			this.dgvnotas.Columns[0].Name = "#";
			this.dgvnotas.Columns[0].Width = 30;
			this.dgvnotas.Columns[0].Visible = true;
			this.dgvnotas.Columns[0].ReadOnly = true;
			this.dgvnotas.Columns[1].Name = "Empresa";
			this.dgvnotas.Columns[1].Width = 170;
			this.dgvnotas.Columns[2].Name = "Ruta";
			this.dgvnotas.Columns[2].Width = 70;
			this.dgvnotas.Columns[2].Visible = false;
			this.dgvnotas.Columns[3].Name = "Archivo";
			this.dgvnotas.Columns[3].Width = 90;
			this.DoubleBufferedASD(this.dgvnotas, true);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00030754 File Offset: 0x0002E954
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00030788 File Offset: 0x0002E988
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvnotas.SelectedRows.Count > 0;
			if (flag)
			{
				int index = this.dgvnotas.CurrentRow.Index;
				Tools.ArchivoEjecutar = Conversions.ToString(this.dgvnotas.Rows[index].Cells["Archivo"].Value);
				MyProject.Forms.main.Show();
				bool flag2 = Tools.Ventanita == 0;
				if (flag2)
				{
					base.Close();
				}
				bool flag3 = Tools.Ventanita == 1;
				if (flag3)
				{
					MyProject.Forms.main.Close();
				}
			}
			else
			{
				MessageBox.Show("Selecciona una empresa para ingresar!");
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00030843 File Offset: 0x0002EA43
		private void Button4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.main.Close();
			Application.Exit();
			base.Close();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00030863 File Offset: 0x0002EA63
		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmServConfig.ShowDialog();
			this.refrescarDatos();
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00030880 File Offset: 0x0002EA80
		public void refrescarDatos()
		{
			this.ListBox1.Items.Clear();
			this.iniciaGridFolio();
			string startupPath = Application.StartupPath;
			this.lbltotal.Text = startupPath;
			try
			{
				ReadOnlyCollection<string> files = MyProject.Computer.FileSystem.GetFiles(startupPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[]
				{
					"*.txt"
				});
				this.lbltotal.Text = "Total Archivos de Texto: " + Conversions.ToString(files.Count);
				try
				{
					foreach (string item in MyProject.Computer.FileSystem.GetFiles(startupPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[]
					{
						"*.txt"
					}))
					{
						this.ListBox1.Items.Add(item);
					}
				}
				finally
				{
					IEnumerator<string> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("No se realizó la operación por: " + ex.Message, MsgBoxStyle.OkOnly, null);
			}
			int num = 1;
			checked
			{
				try
				{
					foreach (object value in this.ListBox1.Items)
					{
						string text = Conversions.ToString(value);
						bool flag = MyProject.Computer.FileSystem.FileExists(text);
						if (flag)
						{
							StreamReader streamReader = MyProject.Computer.FileSystem.OpenTextFileReader(text);
							this.stringReader = streamReader.ReadLine();
							bool flag2 = Microsoft.VisualBasic.FileSystem.FileLen(text) > 0L;
							if (flag2)
							{
								this.lblcadenamodulo.Text = MyProject.Computer.FileSystem.ReadAllText(text);
								this.lblcadenamodulo.Text = Tools.Desencriptar(this.stringReader.ToString().Trim());
								string fileName = Path.GetFileName(text);
								this.RutaFileConn = this.lblcadenamodulo.Text;
								this.lblempresa1.Text = this.RutaFileConn.Substring(0, this.RutaFileConn.IndexOf(";#####;"));
								this.dgvnotas.Rows.Add(new object[]
								{
									num,
									this.lblempresa1.Text,
									text.ToString(),
									fileName.ToString()
								});
								num++;
							}
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
				this.ListBox1.ClearSelected();
				this.dgvnotas.ClearSelection();
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00030B58 File Offset: 0x0002ED58
		private void btnEliminarEmpresa_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvnotas.SelectedRows.Count > 0;
			if (flag)
			{
				int index = this.dgvnotas.CurrentRow.Index;
				string text = Conversions.ToString(this.dgvnotas.Rows[this.NumeroDeFilaSeleccionadaParaEliminar].Cells["Archivo"].Value);
				Interaction.MsgBox(text, MsgBoxStyle.OkOnly, null);
				try
				{
					MyProject.Computer.FileSystem.DeleteFile(text, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
					this.dgvnotas.Rows.Remove(this.dgvnotas.Rows[this.NumeroDeFilaSeleccionadaParaEliminar]);
					this.dgvnotas.ClearSelection();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("No se realizó la operación por: ,el archivo esta en uso , intenta nuevamente!", MsgBoxStyle.OkOnly, null);
					this.dgvnotas.ClearSelection();
				}
			}
			else
			{
				MessageBox.Show("Selecciona una empresa para eliminar!");
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvnotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00030C60 File Offset: 0x0002EE60
		private void dgvnotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvnotas.SelectedRows.Count > 0;
			if (flag)
			{
				this.NumeroDeFilaSeleccionadaParaEliminar = this.dgvnotas.CurrentRow.Index;
				this.lblfilaseleccionada.Text = Conversions.ToString(this.NumeroDeFilaSeleccionadaParaEliminar);
			}
		}

		// Token: 0x040001F2 RID: 498
		private string stringReader;

		// Token: 0x040001F3 RID: 499
		private string RutaFileConn;

		// Token: 0x040001F4 RID: 500
		private int NumeroDeFilaSeleccionadaParaEliminar;
	}
}
