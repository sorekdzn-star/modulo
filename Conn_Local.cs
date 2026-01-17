using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000005 RID: 5
	[StandardModule]
	internal sealed class Conn_Local
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00004160 File Offset: 0x00002360
		public static object ConexionLocal_Modulo_DBO()
		{
			SqlQuery sqlQuery = new SqlQuery();
			bool flag = MyProject.Computer.FileSystem.FileExists(Tools.ArchivoEjecutar);
			if (flag)
			{
				Conn_Local.strConexionServerLocal_Local_Modulo_DBO = checked(Conn_Local.strFile_conn.Substring(Conn_Local.strFile_conn.IndexOf(";#####;") + 7, Conn_Local.strFile_conn.IndexOf(";######;") - Conn_Local.strFile_conn.IndexOf(";#####;") - 6));
				MyProject.Forms.main.lbldatasource.Text = Conn_Local.strConexionServerLocal_Local_Modulo_DBO;
			}
			SqlConnection sqlConnection = new SqlConnection(Conn_Local.strConexionServerLocal_Local_Modulo_DBO);
			object result;
			try
			{
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlConnection.Open();
				sqlCommand.CommandText = "select a from H";
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					sqlDataReader.Read();
					Tools.id_Empresa_conn = sqlDataReader[0].ToString();
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

		// Token: 0x04000010 RID: 16
		public static string strConexionServerLocal_Local_Modulo_DBO;

		// Token: 0x04000011 RID: 17
		public static string strFile_conn;
	}
}
