using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ModuloAdicional
{
	// Token: 0x0200002F RID: 47
	public class RawPrinterHelper
	{
		// Token: 0x06001208 RID: 4616
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "OpenPrinterW", ExactSpelling = true, SetLastError = true)]
		public static extern bool OpenPrinter(string src, ref IntPtr hPrinter, long pd);

		// Token: 0x06001209 RID: 4617
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool ClosePrinter(IntPtr hPrinter);

		// Token: 0x0600120A RID: 4618
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "StartDocPrinterW", ExactSpelling = true, SetLastError = true)]
		public static extern bool StartDocPrinter(IntPtr hPrinter, int level, ref RawPrinterHelper.DOCINFOW pDI);

		// Token: 0x0600120B RID: 4619
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool EndDocPrinter(IntPtr hPrinter);

		// Token: 0x0600120C RID: 4620
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool StartPagePrinter(IntPtr hPrinter);

		// Token: 0x0600120D RID: 4621
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool EndPagePrinter(IntPtr hPrinter);

		// Token: 0x0600120E RID: 4622
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, ref int dwWritten);

		// Token: 0x0600120F RID: 4623 RVA: 0x00115710 File Offset: 0x00113910
		public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
		{
			RawPrinterHelper.DOCINFOW docinfow;
			docinfow.pDocName = "Ticket de Venta";
			docinfow.pDataType = "RAW";
			bool flag = false;
			IntPtr hPrinter;
			bool flag2 = RawPrinterHelper.OpenPrinter(szPrinterName, ref hPrinter, 0L);
			if (flag2)
			{
				bool flag3 = RawPrinterHelper.StartDocPrinter(hPrinter, 1, ref docinfow);
				if (flag3)
				{
					bool flag4 = RawPrinterHelper.StartPagePrinter(hPrinter);
					if (flag4)
					{
						int num;
						flag = RawPrinterHelper.WritePrinter(hPrinter, pBytes, dwCount, ref num);
						RawPrinterHelper.EndPagePrinter(hPrinter);
					}
					RawPrinterHelper.EndDocPrinter(hPrinter);
				}
				RawPrinterHelper.ClosePrinter(hPrinter);
			}
			bool flag5 = !flag;
			if (flag5)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
			}
			return flag;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x001157A8 File Offset: 0x001139A8
		public static bool SendFileToPrinter(string szPrinterName, string szFileName)
		{
			FileStream fileStream = new FileStream(szFileName, FileMode.Open);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			checked
			{
				byte[] source = new byte[(int)fileStream.Length + 1];
				source = binaryReader.ReadBytes((int)fileStream.Length);
				IntPtr intPtr = Marshal.AllocCoTaskMem((int)fileStream.Length);
				Marshal.Copy(source, 0, intPtr, (int)fileStream.Length);
				bool result = RawPrinterHelper.SendBytesToPrinter(szPrinterName, intPtr, (int)fileStream.Length);
				Marshal.FreeCoTaskMem(intPtr);
				return result;
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00115820 File Offset: 0x00113A20
		public static object SendStringToPrinter(string szPrinterName, string szString)
		{
			int length = szString.Length;
			IntPtr intPtr = Marshal.StringToCoTaskMemAnsi(szString);
			RawPrinterHelper.SendBytesToPrinter(szPrinterName, intPtr, length);
			Marshal.FreeCoTaskMem(intPtr);
			object result;
			return result;
		}

		// Token: 0x02000049 RID: 73
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DOCINFOW
		{
			// Token: 0x04000877 RID: 2167
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pDocName;

			// Token: 0x04000878 RID: 2168
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pOutputFile;

			// Token: 0x04000879 RID: 2169
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pDataType;
		}
	}
}
