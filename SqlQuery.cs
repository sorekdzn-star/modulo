using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ModuloAdicional
{
	// Token: 0x02000032 RID: 50
	public class SqlQuery
	{
		// Token: 0x06001218 RID: 4632 RVA: 0x00115A14 File Offset: 0x00113C14
		public object execQuery(string query)
		{
			SqlConnection sqlConnection = new SqlConnection(Tools.strConexionServerLocal);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("execTransaction");
			sqlCommand.CommandTimeout = 30000;
			sqlCommand.Transaction = sqlTransaction;
			object result;
			try
			{
				sqlCommand.CommandText = query;
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

		// Token: 0x06001219 RID: 4633 RVA: 0x00115B54 File Offset: 0x00113D54
		public object execReader(string query)
		{
			SqlConnection sqlConnection = new SqlConnection(Tools.strConexionServerLocal);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandTimeout = 30000;
			object result;
			try
			{
				sqlConnection.Open();
				sqlCommand.CommandText = query;
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
