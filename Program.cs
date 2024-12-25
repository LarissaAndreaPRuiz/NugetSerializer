using NugetSerializarAtributos.Models;
using Newtonsoft.Json;

List<Sale> saleList = new List<Sale>();

DateTime actualDate = DateTime.Now;


Sale v1 = new Sale(1, "Office Material", 25.00M, actualDate);
Sale v2 = new Sale(2, "Software License", 80.00M, actualDate);

saleList.Add(v1);
saleList.Add(v2);

string serialized = JsonConvert.SerializeObject(saleList, Formatting.Indented);

File.WriteAllText("Archives/sales.json", serialized);

Console.WriteLine(serialized);












