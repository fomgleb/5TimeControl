using System;
using System.IO;

namespace TimeControl
{
    static class Storage
    {
        static readonly public string pathToMainDir = Environment.CurrentDirectory + "\\TimeControlSaves";
        static readonly public string[] allFileNamesForMainForm = new string[12] { "StartTime", "StartDate", "EndTime", "EndDate", "History", "Started", "Ended",
                                                                        "TotalSeconds", "ThisYearSeconds", "ThisMonthSeconds", "ThisWeekSeconds", "TodaySeconds"};
        static readonly public string[] allStringFileNames = new string[5] { "StartDate", "StartTime", "EndDate", "EndTime", "History" };
        static readonly public string[] allBooleanFileNames = new string[2] { "Started", "Ended" };
        static readonly public string[] allIntegerFileNames = new string[13] { "TotalSeconds", "ThisYearSeconds", "ThisMonthSeconds", "ThisWeekSeconds", "TodaySeconds", "LastYearSeconds", "LastMonthSeconds",
                                                                               "LastWeekSeconds", "YesterdaySeconds", "MaxInYearSeconds", "MaxInMonthSeconds", "MaxInWeekSeconds", "MaxInDaySeconds"};
        static readonly public string[] allFileNamesForTimeSpentForm = new string[2] { "Date", "WeekOfYear" };

        static public void Save(string selectedDirectory, string fileName, string contents)
        {
            File.WriteAllText($"{pathToMainDir}\\{selectedDirectory}\\{fileName}.txt", contents);
        }
        
        static public string Load(string selectedDirectory, string fileName)
        {
            return File.ReadAllText($"{pathToMainDir}\\{selectedDirectory}\\{fileName}.txt");
        }

        static public void DeleteDirectory(string selectedDirectory)
        {
            Directory.Delete($"{pathToMainDir}\\{selectedDirectory}", true);
        }

        static public void CreateMainDirectory()
        {
            Directory.CreateDirectory(pathToMainDir);
        }

        static public void CreateDirectory(string directoryName)
        {
            if (!Directory.Exists($"{pathToMainDir}\\{directoryName}"))
                Directory.CreateDirectory($"{pathToMainDir}\\{directoryName}");
            foreach (var fileName in allStringFileNames) // создаем пустые файлы
                if (!File.Exists($"{pathToMainDir}\\{directoryName}\\{fileName}.txt"))
                    File.WriteAllText($"{pathToMainDir}\\{directoryName}\\{fileName}.txt", "");
            foreach (var fileName in allIntegerFileNames)
                if (!File.Exists($"{pathToMainDir}\\{directoryName}\\{fileName}.txt") || File.ReadAllText($"{pathToMainDir}\\{directoryName}\\{fileName}.txt") == "")
                    File.WriteAllText($"{pathToMainDir}\\{directoryName}\\{fileName}.txt", "0");
            foreach (var fileName in allBooleanFileNames)
                if (!File.Exists($"{pathToMainDir}\\{directoryName}\\{fileName}.txt"))
                    File.WriteAllText($"{pathToMainDir}\\{directoryName}\\{fileName}.txt", "False");
            foreach (var fileName in allFileNamesForTimeSpentForm)
                File.WriteAllText($"{pathToMainDir}\\{directoryName}\\{fileName}.txt", "");
        }

        static public void ChangeDirectoryName(string oldDirectoryName, string newDirectoryName)
        {
            if (oldDirectoryName != newDirectoryName)
                Directory.Move($"{pathToMainDir}\\{oldDirectoryName}", $"{pathToMainDir}\\{newDirectoryName}");
        }
    }
}
