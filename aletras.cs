using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional
{
	// Token: 0x02000002 RID: 2
	[StandardModule]
	internal sealed class aletras
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static string Letras(string numero)
		{
			string left = "N";
			bool flag = Operators.CompareString(Strings.Mid(numero, 1, 1), "-", false) == 0;
			checked
			{
				string text;
				if (flag)
				{
					numero = Strings.Mid(numero, 2, numero.ToString().Length - 1).ToString();
					text = "MENOS ";
				}
				int length = numero.ToString().Length;
				for (int i = 1; i <= length; i++)
				{
					bool flag2 = Operators.CompareString(Strings.Mid(numero, 1, 1), "0", false) == 0;
					if (!flag2)
					{
						break;
					}
					numero = Strings.Trim(Strings.Mid(numero, 2, numero.ToString().Length).ToString());
					bool flag3 = Conversions.ToDouble(Strings.Trim(Conversions.ToString(numero.ToString().Length))) == 0.0;
					if (flag3)
					{
						text = "";
					}
				}
				int num = Strings.Len(numero);
				string text2;
				string text3;
				for (int j = 1; j <= num; j++)
				{
					bool flag4 = Operators.CompareString(Strings.Mid(numero, j, 1), ".", false) == 0;
					if (flag4)
					{
						left = "S";
					}
					else
					{
						bool flag5 = Operators.CompareString(left, "N", false) == 0;
						if (flag5)
						{
							text2 += Strings.Mid(numero, j, 1);
						}
						else
						{
							text3 += Strings.Mid(numero, j, 1);
						}
					}
				}
				bool flag6 = Strings.Len(text3) == 1;
				if (flag6)
				{
					text3 += "0";
				}
				left = "N";
				bool flag7 = Conversion.Val(numero) <= 999999999.0;
				string result;
				if (flag7)
				{
					int num2 = Strings.Len(text2);
					for (int j = num2; j >= 1; j += -1)
					{
						int num3 = Strings.Len(text2) - (j - 1);
						switch (j)
						{
						case 1:
						case 4:
						case 7:
						{
							string text4 = Strings.Mid(text2, num3, 1);
							uint num4 = <PrivateImplementationDetails>.ComputeStringHash(text4);
							if (num4 <= 856466825U)
							{
								if (num4 <= 822911587U)
								{
									if (num4 != 806133968U)
									{
										if (num4 == 822911587U)
										{
											if (Operators.CompareString(text4, "4", false) == 0)
											{
												bool flag8 = Operators.CompareString(left, "N", false) == 0;
												if (flag8)
												{
													text += "cuatro ";
												}
											}
										}
									}
									else if (Operators.CompareString(text4, "5", false) == 0)
									{
										bool flag9 = Operators.CompareString(left, "N", false) == 0;
										if (flag9)
										{
											text += "cinco ";
										}
									}
								}
								else if (num4 != 839689206U)
								{
									if (num4 == 856466825U)
									{
										if (Operators.CompareString(text4, "6", false) == 0)
										{
											bool flag10 = Operators.CompareString(left, "N", false) == 0;
											if (flag10)
											{
												text += "seis ";
											}
										}
									}
								}
								else if (Operators.CompareString(text4, "7", false) == 0)
								{
									bool flag11 = Operators.CompareString(left, "N", false) == 0;
									if (flag11)
									{
										text += "siete ";
									}
								}
							}
							else if (num4 <= 906799682U)
							{
								if (num4 != 873244444U)
								{
									if (num4 == 906799682U)
									{
										if (Operators.CompareString(text4, "3", false) == 0)
										{
											bool flag12 = Operators.CompareString(left, "N", false) == 0;
											if (flag12)
											{
												text += "tres ";
											}
										}
									}
								}
								else if (Operators.CompareString(text4, "1", false) == 0)
								{
									bool flag13 = Operators.CompareString(left, "N", false) == 0;
									if (flag13)
									{
										bool flag14 = j == 1;
										if (flag14)
										{
											text += "uno ";
										}
										else
										{
											text += "un ";
										}
									}
								}
							}
							else if (num4 != 923577301U)
							{
								if (num4 != 1007465396U)
								{
									if (num4 == 1024243015U)
									{
										if (Operators.CompareString(text4, "8", false) == 0)
										{
											bool flag15 = Operators.CompareString(left, "N", false) == 0;
											if (flag15)
											{
												text += "ocho ";
											}
										}
									}
								}
								else if (Operators.CompareString(text4, "9", false) == 0)
								{
									bool flag16 = Operators.CompareString(left, "N", false) == 0;
									if (flag16)
									{
										text += "nueve ";
									}
								}
							}
							else if (Operators.CompareString(text4, "2", false) == 0)
							{
								bool flag17 = Operators.CompareString(left, "N", false) == 0;
								if (flag17)
								{
									text += "dos ";
								}
							}
							break;
						}
						case 2:
						case 5:
						case 8:
						{
							string text5 = Strings.Mid(text2, num3, 1);
							uint num4 = <PrivateImplementationDetails>.ComputeStringHash(text5);
							if (num4 <= 856466825U)
							{
								if (num4 <= 822911587U)
								{
									if (num4 != 806133968U)
									{
										if (num4 == 822911587U)
										{
											if (Operators.CompareString(text5, "4", false) == 0)
											{
												bool flag18 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
												if (flag18)
												{
													text += "cuarenta ";
													left = "S";
												}
												else
												{
													text += "cuarenta y ";
													left = "N";
												}
											}
										}
									}
									else if (Operators.CompareString(text5, "5", false) == 0)
									{
										bool flag19 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
										if (flag19)
										{
											text += "cincuenta ";
											left = "S";
										}
										else
										{
											text += "cincuenta y ";
											left = "N";
										}
									}
								}
								else if (num4 != 839689206U)
								{
									if (num4 == 856466825U)
									{
										if (Operators.CompareString(text5, "6", false) == 0)
										{
											bool flag20 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
											if (flag20)
											{
												text += "sesenta ";
												left = "S";
											}
											else
											{
												text += "sesenta y ";
												left = "N";
											}
										}
									}
								}
								else if (Operators.CompareString(text5, "7", false) == 0)
								{
									bool flag21 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
									if (flag21)
									{
										text += "setenta ";
										left = "S";
									}
									else
									{
										text += "setenta y ";
										left = "N";
									}
								}
							}
							else if (num4 <= 906799682U)
							{
								if (num4 != 873244444U)
								{
									if (num4 == 906799682U)
									{
										if (Operators.CompareString(text5, "3", false) == 0)
										{
											bool flag22 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
											if (flag22)
											{
												text += "treinta ";
												left = "S";
											}
											else
											{
												text += "treinta y ";
												left = "N";
											}
										}
									}
								}
								else if (Operators.CompareString(text5, "1", false) == 0)
								{
									bool flag23 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
									if (flag23)
									{
										left = "S";
										text += "diez ";
									}
									bool flag24 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "1", false) == 0;
									if (flag24)
									{
										left = "S";
										text += "once ";
									}
									bool flag25 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "2", false) == 0;
									if (flag25)
									{
										left = "S";
										text += "doce ";
									}
									bool flag26 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "3", false) == 0;
									if (flag26)
									{
										left = "S";
										text += "trece ";
									}
									bool flag27 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "4", false) == 0;
									if (flag27)
									{
										left = "S";
										text += "catorce ";
									}
									bool flag28 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "5", false) == 0;
									if (flag28)
									{
										left = "S";
										text += "quince ";
									}
									bool flag29 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "5", false) > 0;
									if (flag29)
									{
										left = "N";
										text += "dieci";
									}
								}
							}
							else if (num4 != 923577301U)
							{
								if (num4 != 1007465396U)
								{
									if (num4 == 1024243015U)
									{
										if (Operators.CompareString(text5, "8", false) == 0)
										{
											bool flag30 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
											if (flag30)
											{
												text += "ochenta ";
												left = "S";
											}
											else
											{
												text += "ochenta y ";
												left = "N";
											}
										}
									}
								}
								else if (Operators.CompareString(text5, "9", false) == 0)
								{
									bool flag31 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
									if (flag31)
									{
										text += "noventa ";
										left = "S";
									}
									else
									{
										text += "noventa y ";
										left = "N";
									}
								}
							}
							else if (Operators.CompareString(text5, "2", false) == 0)
							{
								bool flag32 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0;
								if (flag32)
								{
									text += "veinte ";
									left = "S";
								}
								else
								{
									text += "veinti";
									left = "N";
								}
							}
							break;
						}
						case 3:
						case 6:
						case 9:
						{
							string text6 = Strings.Mid(text2, num3, 1);
							uint num4 = <PrivateImplementationDetails>.ComputeStringHash(text6);
							if (num4 <= 856466825U)
							{
								if (num4 <= 822911587U)
								{
									if (num4 != 806133968U)
									{
										if (num4 == 822911587U)
										{
											if (Operators.CompareString(text6, "4", false) == 0)
											{
												text += "cuatrocientos ";
											}
										}
									}
									else if (Operators.CompareString(text6, "5", false) == 0)
									{
										text += "quinientos ";
									}
								}
								else if (num4 != 839689206U)
								{
									if (num4 == 856466825U)
									{
										if (Operators.CompareString(text6, "6", false) == 0)
										{
											text += "seiscientos ";
										}
									}
								}
								else if (Operators.CompareString(text6, "7", false) == 0)
								{
									text += "setecientos ";
								}
							}
							else if (num4 <= 906799682U)
							{
								if (num4 != 873244444U)
								{
									if (num4 == 906799682U)
									{
										if (Operators.CompareString(text6, "3", false) == 0)
										{
											text += "trescientos ";
										}
									}
								}
								else if (Operators.CompareString(text6, "1", false) == 0)
								{
									bool flag33 = Operators.CompareString(Strings.Mid(text2, num3 + 1, 1), "0", false) == 0 & Operators.CompareString(Strings.Mid(text2, num3 + 2, 1), "0", false) == 0;
									if (flag33)
									{
										text += "cien ";
									}
									else
									{
										text += "ciento ";
									}
								}
							}
							else if (num4 != 923577301U)
							{
								if (num4 != 1007465396U)
								{
									if (num4 == 1024243015U)
									{
										if (Operators.CompareString(text6, "8", false) == 0)
										{
											text += "ochocientos ";
										}
									}
								}
								else if (Operators.CompareString(text6, "9", false) == 0)
								{
									text += "novecientos ";
								}
							}
							else if (Operators.CompareString(text6, "2", false) == 0)
							{
								text += "doscientos ";
							}
							break;
						}
						}
						bool flag34 = j == 4;
						if (flag34)
						{
							bool flag35 = Operators.CompareString(Strings.Mid(text2, 6, 1), "0", false) != 0 | Operators.CompareString(Strings.Mid(text2, 5, 1), "0", false) != 0 | Operators.CompareString(Strings.Mid(text2, 4, 1), "0", false) != 0 | (Operators.CompareString(Strings.Mid(text2, 6, 1), "0", false) == 0 & Operators.CompareString(Strings.Mid(text2, 5, 1), "0", false) == 0 & Operators.CompareString(Strings.Mid(text2, 4, 1), "0", false) == 0 & Strings.Len(text2) <= 6);
							if (flag35)
							{
								text += "mil ";
							}
						}
						bool flag36 = j == 7;
						if (flag36)
						{
							bool flag37 = Strings.Len(text2) == 7 & Operators.CompareString(Strings.Mid(text2, 1, 1), "1", false) == 0;
							if (flag37)
							{
								text += "millón ";
							}
							else
							{
								text += "millones ";
							}
						}
					}
					bool flag38 = Operators.CompareString(text3, "", false) != 0;
					if (flag38)
					{
						result = text.ToString().ToUpper() + "PESOS CON " + text3 + "/100 M.N.";
					}
					else
					{
						result = text.ToString().ToUpper() + "PESOS CON 00/100 M.N.";
					}
				}
				else
				{
					result = "";
				}
				return result;
			}
		}
	}
}
