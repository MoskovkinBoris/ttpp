using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
				class DataProvider : IData
				{
								private List<FileLine> fileData;
								private List<SummaryLine> summaryData;

								public int WithoutDebts = 0;

								private char devider = '*';

								private bool ReadFileData(string datapath)
								{
												fileData = new List<FileLine>();

												try
												{
																StreamReader reader = new StreamReader(datapath, Encoding.UTF8);
																String currentLine = String.Empty;

																while((currentLine = reader.ReadLine()) != null)
																{
																				String[] items = currentLine.Split(devider);

																				FileLine item = new FileLine()
																				{
																								Name = items[0].Trim(),
																								Group = items[1].Trim(),
																								Course = Convert.ToInt32(items[2].Trim()),
																								DebtsCount = Convert.ToInt32(items[3].Trim()),
																				};

																				fileData.Add(item);
																}

																reader.Close();

																MakeSummary();

																return true;
												}
												catch(Exception)
												{
																return false;
												}
								}

								private void MakeSummary()
								{
												Dictionary<int, int> tmp = new Dictionary<int, int>();
												int withoutDebts = 0;

												foreach(FileLine line in fileData)
												{
																if(tmp.ContainsKey(line.Course))
																{
																				if(line.HasDebts)
																				{
																								tmp[line.Course] += line.DebtsCount;
																				}
																				else
																				{
																								withoutDebts++;
																				}
																}
																else
																{
																				tmp[line.Course] = line.DebtsCount;
																}
												}

												foreach(var item in tmp)
												{
																summaryData.Add(new SummaryLine()
																{
																				Course = Convert.ToInt32(Utils.GetGroupByNumber(item.Key)),
																				CourseSum = item.Value,
																});
												}

												WithoutDebts = withoutDebts;
								}

								public static DataProvider GetDataProvider(string path)
								{
												DataProvider provider = new DataProvider();
												if(provider.ReadFileData(path))
																return provider;
												return null;
								}

								public bool IsReady 
								{
												get
												{
																if(fileData == null)
																				return false;
																return true;
												}
								}

								public List<FileLine> GetFileData()
								{
												if(IsReady)
												{
																return fileData;
												}
												return null;
								}

								public List<SummaryLine> GetSummaryData()
								{
												if(IsReady)
												{
																return summaryData;
												}
												return null;
								}

								private DataProvider()
								{
								}
				}
}
