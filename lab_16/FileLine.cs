using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
				class FileLine
				{
								public String Name
								{
												get; set;
								}
								public String Group
								{
												get; set;
								}
								public int Course
								{
												get; set;
								}
								public int DebtsCount
								{
												get; set;
								}
								public bool HasDebts
								{
												get
												{
																return DebtsCount == 0;
												}
								}
				}
}
