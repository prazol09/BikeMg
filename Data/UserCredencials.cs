namespace InventoryManagement.Data;
using System;
using System.IO;
public class UserCredencials
{
	public string[] Usernames = Array.Empty<string>(); // array of all the registered users
    private List<string[]> _userCreds = new();
    public string[][] UserCreds = Array.Empty<string[]>();
    public static string Un { get; set; } = "Prazol Basnet";
	public string Pw { get; set; }
	public string Nme { get; set; } = "Simant";
    public string[][] ReadCredencials()
	{
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string appDirectory = Path.Combine(desktopPath, "dotNET\\coursework\\InventoryManagement");
        string file = Path.Combine(appDirectory, "login_credencials.csv");
        // step one: get all user credencials form 
        //string file = @"C:\Users\Prazol\Desktop\login_credencials.csv";
        //string file = @"login_credencials.csv";
        if (File.Exists(file))
        {
            // Store each line in array of string
            string[] lines = File.ReadAllLines(file);

            // loop through above array
            for (int i = 0; i < lines.Length; i++) {
                string[] oneLine = lines[i].Split(',');
                _userCreds.Add(oneLine);
            }   
        }
        return _userCreds.ToArray();
	}

    // mathod to work on 2d array
    public bool UserExists (string Username)
    {
        // return login status 
    }
}
