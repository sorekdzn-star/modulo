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
	// Token: 0x02000022 RID: 34
	[DesignerGenerated]
	public partial class frmTablasSQL : Form
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x00103616 File Offset: 0x00101816
		public frmTablasSQL()
		{
			base.Load += this.frmTablasSQL_Load;
			this.InitializeComponent();
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00103A0B File Offset: 0x00101C0B
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x00103A15 File Offset: 0x00101C15
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00103A1E File Offset: 0x00101C1E
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x00103A28 File Offset: 0x00101C28
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

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00103A6B File Offset: 0x00101C6B
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x00103A75 File Offset: 0x00101C75
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00103A7E File Offset: 0x00101C7E
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x00103A88 File Offset: 0x00101C88
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

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00103ACB File Offset: 0x00101CCB
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x00103AD5 File Offset: 0x00101CD5
		internal virtual Button Button3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600105F RID: 4191 RVA: 0x000036D5 File Offset: 0x000018D5
		private void frmTablasSQL_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00103AE0 File Offset: 0x00101CE0
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "CREATE SCHEMA Numerar ;";
			sqlQuery.execQuery(query);
			query = "CREATE SEQUENCE Numerar.CountBy1 START WITH 1  INCREMENT BY 1 ;";
			sqlQuery.execQuery(query);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00103B10 File Offset: 0x00101D10
		private void Button2_Click(object sender, EventArgs e)
		{
			object obj = "SE ELIMINARÁN LOS PRODUCTOS ALMACENADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				bool flag2 = MyProject.Computer.FileSystem.FileExists("d.txt");
				if (flag2)
				{
					Tools.strConexionServerLocal = checked(Tools.strFile.Substring(Tools.strFile.IndexOf(";###;") + 5, Tools.strFile.IndexOf(";####;") - Tools.strFile.IndexOf(";###;") - 4));
				}
				string cmdText = "Delete from parametro";
				SqlConnection sqlConnection = new SqlConnection(Tools.strConexionServerLocal);
				SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
				try
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
				}
				sqlConnection.Close();
				MyProject.Forms.frmProductos.Show();
			}
			bool flag3 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
			if (flag3)
			{
				MyProject.Forms.frmProductos.Close();
			}
		}
	}
}
