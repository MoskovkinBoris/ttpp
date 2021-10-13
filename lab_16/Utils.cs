using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
				class Utils
				{
								public static Dictionary<int, string> cols;
								static Utils()
								{
												if(cols == null)
												{
																cols = new Dictionary<int, string>(4);
																cols.Add(0, "ФИО");
																cols.Add(1, "Группа");
																cols.Add(2, "Курс");
																cols.Add(3, "Кол-во задолженностей");
												}
								}

								public static String GetGroupByNumber(int idx)
								{
												if(cols.ContainsKey(idx))
												{
																return cols[idx];
												}
												return String.Empty;
								}
				}
}
