namespace InventoryManagement.Data;

public class AllTakenItems
{
	private readonly List<string[]> _allTakenItems = new();
	public string[][] GetAllTakenItems()
	{
		string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string appDirectory = Path.Combine(desktopPath, "InventoryManagement");
		string file = Path.Combine(appDirectory, "taken_inventory.csv");

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
				_allTakenItems.Add(oneLine);
			}
		}
		return _allTakenItems.ToArray();
	}
}
