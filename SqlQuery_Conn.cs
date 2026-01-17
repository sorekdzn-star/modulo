using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ModuloAdicional
{
	// Token: 0x02000033 RID: 51
	public class SqlQuery_Conn
	{
		// Token: 0x0600121B RID: 4635 RVA: 0x00115BD4 File Offset: 0x00113DD4
		public object execQuery_conn(string query_conn)
		{
			SqlConnection sqlConnection = new SqlConnection(Conn_Local.strConexionServerLocal_Local_Modulo_DBO);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("execTransaction");
			sqlCommand.CommandTimeout = 30000;
			sqlCommand.Transaction = sqlTransaction;
			object result;
			try
			{
				sqlCommand.CommandText = query_conn;
				sqlCommand.ExecuteNonQuery();
				sqlTransaction.Commit();
				sqlConnection.Close();
				result = 1;
			}
			catch (Exception ex)
			{
				sqlConnection.Close();
				try
				{
					sqlTransaction.Rollback();
				}
				catch (Exception ex2)
				{
				}
				bool flag = ex.Message.Contains("'UNIQUE KEY'");
				if (flag)
				{
					Interaction.MsgBox("Ya existe un Registro con el Mismo Código", MsgBoxStyle.Information, null);
					result = -1;
				}
				else
				{
					bool flag2 = ex.Message.Contains("'vchNombre_UNIQUE'");
					if (flag2)
					{
						Interaction.MsgBox("Ya existe un Registro con el Mismo Nombre", MsgBoxStyle.Information, null);
						result = -2;
					}
					else
					{
						Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00115D14 File Offset: 0x00113F14
		public object execReader_conn(string query_conn)
		{
			SqlConnection sqlConnection = new SqlConnection(Conn_Local.strConexionServerLocal_Local_Modulo_DBO);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandTimeout = 30000;
			object result;
			try
			{
				sqlConnection.Open();
				sqlCommand.CommandText = query_conn;
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				result = sqlDataReader;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				result = 0;
			}
			return result;
		}
	}
}
