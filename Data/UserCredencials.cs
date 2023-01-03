namespace InventoryManagement.Data;
using System;
using System.IO;
using BCrypt.Net;

public class UserCredencials
{
	// public string[] Usernames = Array.Empty<string>(); // array of all the registered users
    private List<string[]> _userCreds = new();
    public string[][] ReadCredencials()
	{
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string appDirectory = Path.Combine(desktopPath, "InventoryManagement");
        string file = Path.Combine(appDirectory, "login_credencials.csv");
        
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
                _userCreds.Add(oneLine);
            }   
        }
        //UserCreds = _userCreds.ToArray();
        return _userCreds.ToArray();
	}

    // mathod to work on 2d array
    public bool Login (string Username, string Password)
    {
        string[][] creds = ReadCredencials();
        bool cStatus = false;

        // loop runs until Username matches
        foreach(string[] s in creds) {
            if (s[0] == Username)
            {
                // check password
                if (BCrypt.Verify(Password, s[1]))
                {
                    cStatus = true;
                }
                else
                {
                    cStatus = false;
                }
                break;
            }
        }
        // return login status 
        return cStatus;
    }
}
