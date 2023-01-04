namespace InventoryManagement.Data;

public class AddNewItem
{ 
    public void AddItem(string line)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string appDirectory = Path.Combine(desktopPath, "InventoryManagement");
        string file = Path.Combine(appDirectory, "inventory_details.csv");

        File.AppendAllText(file, line + Environment.NewLine);
    }
}