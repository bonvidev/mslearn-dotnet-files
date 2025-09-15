using System.IO;
using System.Collections.Generic;

//Questo codice passa il nome della cartella stores come percorso in cui cercare i file
var salesFiles = FindFiles("stores");

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}


// See https://aka.ms/new-console-template for more information
IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain the full path, so only check the end of it
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}