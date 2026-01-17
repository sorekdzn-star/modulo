using System;
using System.Collections;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000034 RID: 52
	[StandardModule]
	internal sealed class Tools
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x00115DD0 File Offset: 0x00113FD0
		public static void abrir()
		{
			bool flag = Tools.conexion.State == ConnectionState.Closed;
			if (flag)
			{
				Tools.conexion.Open();
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00115DFC File Offset: 0x00113FFC
		public static void cerrar()
		{
			bool flag = Tools.conexion.State == ConnectionState.Open;
			if (flag)
			{
				Tools.conexion.Close();
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00115E28 File Offset: 0x00114028
		public static void setServer()
		{
			string[] array = new string[2];
			SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
			DataTable dataSources = instance.GetDataSources();
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in dataSources.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						bool flag = Operators.CompareString(dataRow[1].ToString(), "NATIONALSOFT", false) == 0;
						if (flag)
						{
							array[num] = dataRow[0].ToString();
							num++;
							break;
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
				Tools.strServerLocal = array[num - 1];
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00115EE4 File Offset: 0x001140E4
		public static string formateaPrecio(string strCantidadPar)
		{
			string text = strCantidadPar;
			int num = text.IndexOf("$");
			bool flag = num > -1;
			checked
			{
				if (flag)
				{
					text = text.Substring(2, text.Length - 2);
				}
				int num2 = text.IndexOf(".");
				int num3 = text.IndexOf(",");
				string str = text;
				bool flag2 = num2 > -1 & num3 == -1;
				if (flag2)
				{
					bool flag3 = text.Length - (num2 + 1) < 2;
					if (flag3)
					{
						str = text.Substring(0, num2) + "." + text.Substring(num2 + 1, 1) + "0";
					}
					bool flag4 = text.Length - (num2 + 1) >= 2;
					if (flag4)
					{
						str = text;
					}
				}
				bool flag5 = num3 > -1 & num2 == -1;
				if (flag5)
				{
					bool flag6 = text.Length - (num3 + 1) < 2;
					if (flag6)
					{
						str = text.Substring(0, num3) + "." + text.Substring(num3 + 1, 1) + "0";
					}
					bool flag7 = text.Length - (num3 + 1) >= 2;
					if (flag7)
					{
						str = text;
					}
				}
				bool flag8 = num2 == -1 & num3 == -1;
				if (flag8)
				{
					str = text + ".00 ";
				}
				return "$ " + str;
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00116030 File Offset: 0x00114230
		public static object ConexionLocal()
		{
			SqlQuery sqlQuery = new SqlQuery();
			Tools.strConexionServerLocal = Tools.strFile;
			SqlConnection sqlConnection = new SqlConnection(Tools.strConexionServerLocal);
			object result;
			try
			{
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlConnection.Open();
				sqlCommand.CommandText = "select idempresa from empresas";
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					sqlDataReader.Read();
					Tools.id_Empresa = sqlDataReader[0].ToString();
				}
				sqlDataReader.Close();
				sqlConnection.Close();
				result = true;
			}
			catch (Exception ex)
			{
				sqlConnection.Close();
				result = false;
			}
			return result;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x001160E8 File Offset: 0x001142E8
		public static void DisableMenu()
		{
			try
			{
				foreach (object obj in MyProject.Forms.main.mainMenu.Items)
				{
					ToolStripItem toolStripItem = (ToolStripItem)obj;
					toolStripItem.Enabled = false;
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

		// Token: 0x06001224 RID: 4644 RVA: 0x00116158 File Offset: 0x00114358
		public static void EnableMenu()
		{
			try
			{
				foreach (object obj in MyProject.Forms.main.mainMenu.Items)
				{
					ToolStripItem toolStripItem = (ToolStripItem)obj;
					toolStripItem.Enabled = true;
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

		// Token: 0x06001225 RID: 4645 RVA: 0x001161C8 File Offset: 0x001143C8
		public static bool ValidaLicencia()
		{
			bool flag = Tools.licencia.Length == 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					Tools.licenciaDec = Tools.Decrypt(Tools.licencia, Tools.strCte + Tools.strServ + Tools.strId);
					result = true;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("Oppps la licencia no es valida, intenta nuevamente!", MsgBoxStyle.OkOnly, null);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00116244 File Offset: 0x00114444
		public static string Gm(string f)
		{
			string result = "";
			bool flag = Operators.CompareString(f, "Enero", false) == 0;
			if (flag)
			{
				result = "1";
			}
			bool flag2 = Operators.CompareString(f, "Febrero", false) == 0;
			if (flag2)
			{
				result = "2";
			}
			bool flag3 = Operators.CompareString(f, "Marzo", false) == 0;
			if (flag3)
			{
				result = "3";
			}
			bool flag4 = Operators.CompareString(f, "Abril", false) == 0;
			if (flag4)
			{
				result = "4";
			}
			bool flag5 = Operators.CompareString(f, "Mayo", false) == 0;
			if (flag5)
			{
				result = "5";
			}
			bool flag6 = Operators.CompareString(f, "Junio", false) == 0;
			if (flag6)
			{
				result = "6";
			}
			bool flag7 = Operators.CompareString(f, "Julio", false) == 0;
			if (flag7)
			{
				result = "7";
			}
			bool flag8 = Operators.CompareString(f, "Agosto", false) == 0;
			if (flag8)
			{
				result = "8";
			}
			bool flag9 = Operators.CompareString(f, "Septiembre", false) == 0;
			if (flag9)
			{
				result = "9";
			}
			bool flag10 = Operators.CompareString(f, "Octubre", false) == 0;
			if (flag10)
			{
				result = "10";
			}
			bool flag11 = Operators.CompareString(f, "Noviembre", false) == 0;
			if (flag11)
			{
				result = "11";
			}
			bool flag12 = Operators.CompareString(f, "Diciembre", false) == 0;
			if (flag12)
			{
				result = "12";
			}
			return result;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x001163A0 File Offset: 0x001145A0
		public static string Gm(int f)
		{
			string result = "";
			bool flag = (double)f == Conversions.ToDouble("1");
			if (flag)
			{
				result = "Enero";
			}
			bool flag2 = (double)f == Conversions.ToDouble("2");
			if (flag2)
			{
				result = "Febrero";
			}
			bool flag3 = (double)f == Conversions.ToDouble("3");
			if (flag3)
			{
				result = "Marzo";
			}
			bool flag4 = (double)f == Conversions.ToDouble("4");
			if (flag4)
			{
				result = "Abril";
			}
			bool flag5 = (double)f == Conversions.ToDouble("5");
			if (flag5)
			{
				result = "Mayo";
			}
			bool flag6 = (double)f == Conversions.ToDouble("6");
			if (flag6)
			{
				result = "Junio";
			}
			bool flag7 = (double)f == Conversions.ToDouble("7");
			if (flag7)
			{
				result = "Julio";
			}
			bool flag8 = (double)f == Conversions.ToDouble("8");
			if (flag8)
			{
				result = "Agosto";
			}
			bool flag9 = (double)f == Conversions.ToDouble("9");
			if (flag9)
			{
				result = "Septiembre";
			}
			bool flag10 = (double)f == Conversions.ToDouble("10");
			if (flag10)
			{
				result = "Octubre";
			}
			bool flag11 = (double)f == Conversions.ToDouble("11");
			if (flag11)
			{
				result = "Noviembre";
			}
			bool flag12 = (double)f == Conversions.ToDouble("12");
			if (flag12)
			{
				result = "Diciembre";
			}
			return result;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x001164F0 File Offset: 0x001146F0
		public static string Encrypt(string plainText, string secretKey)
		{
			string result = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				RijndaelManaged algorithm = Tools.GetAlgorithm(secretKey);
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, algorithm.CreateEncryptor(), CryptoStreamMode.Write))
				{
					byte[] bytes = Encoding.Unicode.GetBytes(plainText);
					cryptoStream.Write(bytes, 0, bytes.Length);
					cryptoStream.FlushFinalBlock();
					result = Convert.ToBase64String(memoryStream.ToArray());
				}
			}
			return result;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00116590 File Offset: 0x00114790
		public static string Decrypt(string encryptedBytes, string secretKey)
		{
			string result = null;
			checked
			{
				using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedBytes)))
				{
					RijndaelManaged algorithm = Tools.GetAlgorithm(secretKey);
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read))
					{
						byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
						int count = cryptoStream.Read(array, 0, (int)memoryStream.Length);
						result = Encoding.Unicode.GetString(array, 0, count);
					}
				}
				return result;
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0011663C File Offset: 0x0011483C
		private static RijndaelManaged GetAlgorithm(string secretKey)
		{
			string s = "gordolobo2077 encripter alv" + Tools.strCte + Tools.strServ + Tools.strId;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(secretKey, Encoding.Unicode.GetBytes(s));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			checked
			{
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				return rijndaelManaged;
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x001166E0 File Offset: 0x001148E0
		public static void Multilinea(ref DataGridView List)
		{
			List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			List.EnableHeadersVisualStyles = false;
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			dataGridViewCellStyle.BackColor = Color.White;
			dataGridViewCellStyle.ForeColor = Color.Black;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
			List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0011676C File Offset: 0x0011496C
		public static string Encriptar(string texto)
		{
			string text;
			try
			{
				bool flag = Operators.CompareString(Strings.Trim(texto), "", false) == 0;
				if (flag)
				{
					text = "";
				}
				else
				{
					Tools.des.Key = Tools.hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(Tools.myKey));
					Tools.des.Mode = CipherMode.ECB;
					ICryptoTransform cryptoTransform = Tools.des.CreateEncryptor();
					byte[] bytes = Encoding.ASCII.GetBytes(texto);
					text = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
				}
				text = text;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Opsss no es posible establecer conexion, Contacta a tu administrador del sistema!", MsgBoxStyle.OkOnly, null);
				MyProject.Forms.main.Close();
			}
			return text;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0011683C File Offset: 0x00114A3C
		public static string Desencriptar(string texto)
		{
			string text;
			try
			{
				bool flag = Operators.CompareString(Strings.Trim(texto), "", false) == 0;
				if (flag)
				{
					text = "";
				}
				else
				{
					Tools.des.Key = Tools.hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(Tools.myKey));
					Tools.des.Mode = CipherMode.ECB;
					ICryptoTransform cryptoTransform = Tools.des.CreateDecryptor();
					byte[] array = Convert.FromBase64String(texto);
					text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
				}
				text = text;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Opsss no es posible establecer conexion, Contacta a tu administrador del sistema!", MsgBoxStyle.OkOnly, null);
				MyProject.Forms.main.Close();
			}
			return text;
		}

		// Token: 0x040007FD RID: 2045
		public static string id_Empresa;

		// Token: 0x040007FE RID: 2046
		public static string id_Empresa_conn;

		// Token: 0x040007FF RID: 2047
		public static int id_NivelUsuario;

		// Token: 0x04000800 RID: 2048
		public static int iAnio;

		// Token: 0x04000801 RID: 2049
		public static int id_Semana;

		// Token: 0x04000802 RID: 2050
		public static string strNombreUsuario;

		// Token: 0x04000803 RID: 2051
		public static bool boolStatusServRemoto;

		// Token: 0x04000804 RID: 2052
		public static bool boolStatusServLocal;

		// Token: 0x04000805 RID: 2053
		public static string strServerLocal;

		// Token: 0x04000806 RID: 2054
		public static string strConexionServerLocal;

		// Token: 0x04000807 RID: 2055
		public static string strCodigoBuscar;

		// Token: 0x04000808 RID: 2056
		public static string strCodigoBuscarEmpresa;

		// Token: 0x04000809 RID: 2057
		public static string strNombreEmpresa;

		// Token: 0x0400080A RID: 2058
		public static string strFechaPagoNomia;

		// Token: 0x0400080B RID: 2059
		public static string Conn_BaseDeDatos_SoftRestaurant;

		// Token: 0x0400080C RID: 2060
		public static string BaseDatos_Modulo;

		// Token: 0x0400080D RID: 2061
		public static string strFormatoFechaLargo = "yyyy-dd-MM HH:mm:ss";

		// Token: 0x0400080E RID: 2062
		public static string strFormatoFechaLargo1 = "yyyyMMdd HH:mm:ss";

		// Token: 0x0400080F RID: 2063
		public static bool boolMsgRes;

		// Token: 0x04000810 RID: 2064
		public static string strFile;

		// Token: 0x04000811 RID: 2065
		public static string licencia;

		// Token: 0x04000812 RID: 2066
		public static string licenciaDec;

		// Token: 0x04000813 RID: 2067
		public static string strCte;

		// Token: 0x04000814 RID: 2068
		public static string strServ;

		// Token: 0x04000815 RID: 2069
		public static string strInstancia;

		// Token: 0x04000816 RID: 2070
		public static string strUsuariosql;

		// Token: 0x04000817 RID: 2071
		public static string strpasswordsql;

		// Token: 0x04000818 RID: 2072
		public static string strId;

		// Token: 0x04000819 RID: 2073
		public static string FoliodetFormaPago;

		// Token: 0x0400081A RID: 2074
		public static string idtipo;

		// Token: 0x0400081B RID: 2075
		public static string idFormadePago1Tomas;

		// Token: 0x0400081C RID: 2076
		public static double Consumo;

		// Token: 0x0400081D RID: 2077
		public static string FolioRedBull;

		// Token: 0x0400081E RID: 2078
		public static int NumeroFilaFormasDePago;

		// Token: 0x0400081F RID: 2079
		public static double PrecioCargaProdAlien;

		// Token: 0x04000820 RID: 2080
		public static string ArchivoEjecutar;

		// Token: 0x04000821 RID: 2081
		public static int ActualizaFormaPagoCuentas;

		// Token: 0x04000822 RID: 2082
		public static string SerieDelTicketLG;

		// Token: 0x04000823 RID: 2083
		public static string NumchequeDelticketLG;

		// Token: 0x04000824 RID: 2084
		public static double DescuentoMia_Renta;

		// Token: 0x04000825 RID: 2085
		public static string FolioParaAgregar_ProductosEliminarProductos;

		// Token: 0x04000826 RID: 2086
		public static bool boolReady;

		// Token: 0x04000827 RID: 2087
		public static SqlConnection conexion;

		// Token: 0x04000828 RID: 2088
		public static int Ventanita = 0;

		// Token: 0x04000829 RID: 2089
		public static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();

		// Token: 0x0400082A RID: 2090
		public static MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

		// Token: 0x0400082B RID: 2091
		public static string myKey = "La Puta MADRE CONH E LCOSIGSFSFGSD";
	}
}
