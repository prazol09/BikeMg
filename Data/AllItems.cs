namespace InventoryManagement.Data;

public class AllItems
{
	private readonly List<string[]> _allInventoryItems = new();
	public string[][] GetAllItems()
	{
		string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string appDirectory = Path.Combine(desktopPath, "InventoryManagement");
		string file = Path.Combine(appDirectory, "inventory_details.csv");

		if (File.Exists(file))
		{
			// Store each line in array of string
			string[] lines = File.ReadAllLines(file);

			// loop through above array
			for (int i = 0; i < lines.Length; i++)
			{
				// convert each element into array
				string[] oneLine = lines[i].Split(',');

				// append newly created array into a List of array
				_allInventoryItems.Add(oneLine);
			}
		}
		return _allInventoryItems.ToArray();
	}
}
