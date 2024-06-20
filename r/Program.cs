using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> history = new List<string>();
            int num;
            do
            {
                Console.WriteLine("-------------------commend screen---------------------");
                Console.WriteLine("(1) mkdir (Location)(Namefolder)");
                Console.WriteLine("(2) mkdir -v (Location)(Namefolder)");
                Console.WriteLine("(3) mkdir -p (Location)(Namefolder),1/2/3");
                Console.WriteLine("(4) mkdir -pv (Location)(Namefolder),1/2/3");
                Console.WriteLine("(5) rmdir1 (Location)(Namefolder)");
                Console.WriteLine("(6) rmdir1 -v (Location)(Namefolder)");
                Console.WriteLine("(7) rmdir -pv  (Location)(Namefolder)");
                Console.WriteLine("(8) rmdir * (Location)(Namefolder)(all)");
                Console.WriteLine("(9) rmdir2  (Location)(Namefolder)(Namefolder)");
                Console.WriteLine("(10) rmdir2 -v (Location)(Namefolder)(Namefolder)");
                Console.WriteLine("(11) rm -r * (Location)(Namefolder)");
                Console.WriteLine("(13) rm (Location)(Namefolder)(Namefile) ");
                Console.WriteLine("(14) rm -v (Location)(Namefolder)(Namefile) ");
                Console.WriteLine("(15) rm -i (Location)(Namefolder)(Namefile) ");
                Console.WriteLine("(16) rm  (Namefolder)/*(Namefile) ");
                Console.WriteLine("(17) cp(filename)");
                Console.WriteLine("(18) cp -i(filename)");
                Console.WriteLine("(19) cp(filename)(filename)");
                Console.WriteLine("(20) cp -r(foldername)");
                Console.WriteLine("(21) cp *(foldername)");
                Console.WriteLine("(22) cp -r *(foldername)");
                Console.WriteLine("(23) mv (file)/move");
                Console.WriteLine("(24) mv -i(file)/move");
                Console.WriteLine("(25) mv (folder)/move");
                Console.WriteLine("(26) mv -i(folder)/move");
                Console.WriteLine("(27) mv *(folder)(file)/move");
                Console.WriteLine("(28) mv (file)/rename");
                Console.WriteLine("(29) mv (folder)/rename");
                Console.WriteLine("(32) cd (folderName)");
                Console.WriteLine("(33) cd ..");
                Console.WriteLine("(34) cd ../..");
                Console.WriteLine("(37) cd");
                Console.WriteLine("(35) pwd");
                Console.WriteLine("(36) clear ");
                Console.WriteLine("(38) date");
                Console.WriteLine("(39) history");
                Console.WriteLine("(40) history (number)");
                Console.WriteLine("(30) ls");
                Console.WriteLine("(41) ls -l");
                Console.WriteLine("(83) ls -lh");
                Console.WriteLine("(42) ls -r");
                Console.WriteLine("(43) ls -S");
                Console.WriteLine("(44) ls -t");
                Console.WriteLine("(45) ls -a");
                Console.WriteLine("(12) touch (FileName)");
                Console.WriteLine("(47) touch (folderName)/(FileName)");
                Console.WriteLine("(48) > (FileName)");
                Console.WriteLine("(49) > (FolderName)/(FileName)");
                Console.WriteLine("(50) (CommandName) > (FileName)");
                Console.WriteLine("(51) (CommandName) > (FolderName)/(FileName)");
                Console.WriteLine("(52) >> (FileName)");
                Console.WriteLine("(53) >> (FolderName)/(FileName)");
                Console.WriteLine("(84) (CommandName) >> (FileName)");
                Console.WriteLine("(85) (CommandName) >> (FolderName)/(FileName)");
                Console.WriteLine("(54)  more (FileName)");
                Console.WriteLine("(55) more (folderName)/(FileName)");
                Console.WriteLine("(56) more *");
                Console.WriteLine("(57) more (folderName)/*");
                Console.WriteLine("(58) more -(Number) (FileName)");
                Console.WriteLine("(59) more -(Number) (folderName)/(FileName)");
                Console.WriteLine("(60) more +(Number) (FileName)");
                Console.WriteLine("(61) more +(Number) (folderName)/(FileName)");
                Console.WriteLine("(62) more -d (FileName)");
                Console.WriteLine("(63) more -d (folderName)/(FileName)");
                Console.WriteLine("(64) head -(Number) (FileName)");
                Console.WriteLine("(65) head -(Number) (folderName)/(FileName)");
                Console.WriteLine("(66) head -n(Number) (FileName)");
                Console.WriteLine("(67) head -n(Number) (folderName)/(FileName)");
                Console.WriteLine("(68) head -n-(Number) (FileName)");
                Console.WriteLine("(69) head -n-(Number) (folderName)/(FileName)");
                Console.WriteLine("(70) tail -(Number) (FileName)");
                Console.WriteLine("(71) tail -(Number) (folderName)/(FileName)");
                Console.WriteLine("(72) tail -n(Number) (FileName)");
                Console.WriteLine("(73) tail -n(Number) (folderName)/(FileName)");
                Console.WriteLine("(74) tail -n+(Number) (FileName)");
                Console.WriteLine("(75) tail -n+(Number) (folderName)/(FileName)");
                Console.WriteLine("(76) cat (FileName) |tr ' '  ' ' ");
                Console.WriteLine("(77) cat (folderName)/(FileName) |tr ' '  ' ' ");
                Console.WriteLine("(78) cat (folderName)/* |tr ' '  ' ' ");
                Console.WriteLine("(79) cat (FileName) |tr 'range'  'range' ");
                Console.WriteLine("(80) cat (folderName)/(FileName) |tr 'range'  'range' ");
                Console.WriteLine("(81) cat (FileName)");
                Console.WriteLine("(82) cat (folderName)/(FileName)");
                Console.WriteLine("(86) Exit");
                Console.Write("Enter number: ");
                bool stoer = false;
                string filePath = null;
            p:
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 50:
                        history.Add("(CommandName) > (FileName)");
                        Console.WriteLine("Enter the file name :");
                        string fileName = Console.ReadLine();

                        string currentPath = Directory.GetCurrentDirectory();
                        filePath = Path.Combine(currentPath, fileName);
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                            File.Create(filePath).Close();
                        }
                        else
                        {
                            File.Create(filePath).Close();
                        }
                        stoer = true;
                        Console.WriteLine("enter the number of command from above to store the output of it in the file");
                        goto p;
                    case 84:
                        history.Add("(CommandName) >> (FileName)");
                        Console.WriteLine("Enter the file name :");
                        string fileNamee = Console.ReadLine();

                        string currentPathh = Directory.GetCurrentDirectory();
                        filePath = Path.Combine(currentPathh, fileNamee);
                        if (!File.Exists(filePath))
                        {
                             File.Create(filePath).Close();
                        }
                        else
                        {
                            stoer = true;
                            Console.WriteLine("enter the number of command from above to store the output of it in the file");
                            goto p;
                        }
                        break;
                    case 1:

                        functions.mkdir("mkdir");
                        history.Add("mkdir");


                        break;
                    case 2:
                        functions.mkdir("mkdir -v");
                        history.Add("mkdir -v");
                        break;
                    case 3:
                        functions.mkdir_p("mkdir");
                        history.Add("mkdir -p");
                        break;
                    case 4:
                        functions.mkdir_p("mkdir -v");
                        history.Add("mkdir -pv");
                        break;
                    case 5:
                        functions.rmdir1("rmdir");
                        history.Add("rmdir1");
                        break;
                    case 6:
                        functions.rmdir1("rmdir -v");
                        history.Add("rmdir1 -v");
                        break;
                    case 7:
                        functions.rmdir_pv("rmdir -v");
                        history.Add("rmdir -pv");
                        break;
                    case 8:
                        functions.rmdir_all();
                        history.Add("mkdir *");
                        break;
                    case 9:
                        functions.rmdir2("mkdir");
                        history.Add("rmdir2");
                        break;
                    case 10:
                        functions.rmdir2("rmdir -v");
                        history.Add("rmdir2 -v");
                        break;
                    case 11:
                        functions.rm_r();
                        history.Add("rm -r *");
                        break;
                    case 12:
                        functions.touch();
                        history.Add("touch (file)");
                        break;
                    case 13:
                        functions.rm_file("rm");
                        history.Add("rm (file)");
                        break;
                    case 14:
                        functions.rm_file("rm -v");
                        history.Add("rm -v (file)");
                        break;
                    case 15:
                        functions.rm_file("rm -i");
                        history.Add("rm -i (file)");
                        break;
                    case 16:
                        functions.rm_all_file();
                        history.Add("rm folder/*");
                        break;
                    case 17:
                        functions.cp_file("cp");
                        history.Add("cp(file)");
                        break;
                    case 18:
                        functions.cp_file("cp -i");
                        history.Add("cp -i(file)");
                        break;
                    case 19:
                        functions.cp();
                        history.Add("cp(file)(file)");
                        break;
                    case 20:
                        functions.cp_folder();
                        history.Add("cp(folder)");
                        break;
                    case 21:
                        functions.cp_all("cp *");
                        history.Add("cp *(file)");
                        break;
                    case 22:
                        functions.cp_all("cp -r *");
                        history.Add("cp -r *(file)/(folder)");
                        break;
                    case 23:
                        functions.mv_file("mv");
                        history.Add("mv(file)");
                        break;
                    case 24:
                        functions.mv_file("mv -i");
                        history.Add("mv -i(file)");
                        break;
                    case 25:
                        functions.mv_folder("mv");
                        history.Add("mv(folder)");
                        break;
                    case 26:
                        functions.mv_folder("mv -i");
                        history.Add("mv -i(folder)");
                        break;
                    case 27:
                        functions.mv_all();
                        history.Add("mv *");
                        break;
                    case 28:
                        functions.mv_file_re();
                        history.Add("mv(file)renam");
                        break;
                    case 29:
                        functions.mv_folder_re();
                        history.Add("mv(folder)renam");
                        break;
                    case 30:
                        string[] entries = functions.ls();
                        if (stoer)
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                foreach (string entry in entries)
                                {
                                    if (File.Exists(entry))
                                    {
                                        string content = "File: " + Path.GetFileName(entry);
                                        writer.WriteLine(content);
                                    }
                                    else if (Directory.Exists(entry))
                                    {
                                        string directoryName = Path.GetFileName(entry);
                                        writer.WriteLine("Folder: " + directoryName);
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (string entry in entries)
                            {
                                if (File.Exists(entry))
                                {
                                    Console.WriteLine("File: " + Path.GetFileName(entry));
                                }
                                else if (Directory.Exists(entry))
                                {
                                    string directoryName = Path.GetFileName(entry);
                                    Console.WriteLine("Folder: " + directoryName);
                                }
                            }
                        }
                        history.Add("ls");

                        break;
                    case 31:
                        functions.more1();
                        history.Add("more (FileName)");
                        break;
                    case 32:
                        if (stoer == false)
                        {
                            Console.WriteLine(functions.cd_folder());
                            history.Add("cd (folderName)");
                        }
                        else
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                writer.WriteLine(functions.cd_folder());

                            }

                        }
                        break;
                    case 33:
                        if (stoer == false)
                        {
                            Console.WriteLine(functions.cd_Backspac1());
                            history.Add("cd ..");
                        }
                        else
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                writer.WriteLine(functions.cd_Backspac1());

                            }
                        }
                        break;
                    case 34:
                        if (stoer == false)
                        {
                            Console.WriteLine(functions.cd_Backspac2());
                            history.Add("cd ../..");
                        }
                        else
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                writer.WriteLine(functions.cd_Backspac2());

                            }
                        }
                        break;
                    case 35:
                        if (stoer == false)
                        {
                            Console.WriteLine("current directort:" + functions.current_path());
                            history.Add("pwd");
                        }
                        else
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                writer.WriteLine(functions.current_path());

                            }

                        }
                        ;
                        break;
                    case 36:
                        if (stoer == false)
                        {
                            functions.clear();
                            history.Add("clear");
                        }
                        break;
                    case 37:
                        if (stoer == false)
                        {
                            Console.WriteLine(functions.cd());
                            history.Add("cd");
                        }
                        else
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                writer.WriteLine(functions.cd());

                            }
                        }

                        break;
                    case 38:
                        if (stoer == false)
                        {
                            Console.WriteLine("Current Date and Time: " + functions.date());
                            history.Add("date");
                        }
                        else
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                writer.WriteLine(Convert.ToString(functions.date()));

                            }
                        }
                        break;
                    case 39:
                        if (stoer == false)
                        {
                            history.Add("history");
                            foreach (string i in history)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else
                        {
                            foreach (string i in history)
                            {
                                using (StreamWriter writer = File.AppendText(filePath))
                                {
                                    writer.WriteLine(i);

                                }
                            }

                        }
                        break;
                    case 40:
                        history.Add("history (number)");
                        Console.WriteLine("enter the number:");
                        int number = int.Parse(Console.ReadLine());
                        if (stoer == false)
                        {
                            if (history.Count >= number)
                            {
                                for (int i = 0; i < number; i++)
                                {
                                    Console.WriteLine(history[i]);
                                }
                            }
                            else
                            {
                                foreach (string i in history)
                                {
                                    Console.WriteLine(i);
                                }
                            }

                        }
                        else
                        {
                            if (history.Count >= number)
                            {
                                for (int i = 0; i < number; i++)
                                {
                                    using (StreamWriter writer = File.AppendText(filePath))
                                    {
                                        writer.WriteLine( history[i]);

                                    }
                                }
                            }
                            else
                            {
                                foreach (string i in history)
                                {
                                    using (StreamWriter writer = File.AppendText(filePath))
                                    {
                                        writer.WriteLine(i);

                                    }
                                }
                            }
                        }
                        break;
                    case 41:
                        ;
                        history.Add("ls -l");
                        List<FileSystemInfo> entriessss = functions.ls_l();
                        if (stoer)
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                foreach (var entry in entriessss)
                                {
                                    bool isFile = entry is FileInfo;
                                    string type = isFile ? "File" : "Folder";
                                    string name = entry.Name;
                                    string fullPath = entry.FullName;
                                    DateTime creationTime = entry.CreationTime;
                                    DateTime lastModified = entry.LastWriteTime;
                                    FileAttributes attributes = entry.Attributes;
                                    string owner = isFile ? GetFileOwner((FileInfo)entry) : GetFolderOwner((DirectoryInfo)entry);
                                    string permissions = isFile ? GetFilePermissions((FileInfo)entry) : GetFolderPermissions((DirectoryInfo)entry);
                                    long sizeInBytes = isFile ? ((FileInfo)entry).Length : GetFolderSize((DirectoryInfo)entry);
                                    string size = FormatSize(sizeInBytes);

                                    writer.WriteLine($"Type: {type}");
                                    writer.WriteLine($"Name: {name}");
                                    writer.WriteLine($"Full Path: {fullPath}");
                                    writer.WriteLine($"Created: {creationTime}");
                                    writer.WriteLine($"Last Modified: {lastModified}");
                                    writer.WriteLine($"Attributes: {attributes}");
                                    writer.WriteLine($"Owner: {owner}");
                                    writer.WriteLine($"Permissions: {permissions}");
                                    writer.WriteLine($"Size: {size}");
                                    writer.WriteLine();
                                }
                            }
                        }
                        else
                        {
                            foreach (var entry in entriessss)
                            {
                                bool isFile = entry is FileInfo;
                                string type = isFile ? "File" : "Folder";
                                string name = entry.Name;
                                string fullPath = entry.FullName;
                                DateTime creationTime = entry.CreationTime;
                                DateTime lastModified = entry.LastWriteTime;
                                FileAttributes attributes = entry.Attributes;
                                string owner = isFile ? GetFileOwner((FileInfo)entry) : GetFolderOwner((DirectoryInfo)entry);
                                string permissions = isFile ? GetFilePermissions((FileInfo)entry) : GetFolderPermissions((DirectoryInfo)entry);
                                long sizeInBytes = isFile ? ((FileInfo)entry).Length : GetFolderSize((DirectoryInfo)entry);
                                string size = FormatSize(sizeInBytes);

                                Console.WriteLine($"Type: {type}");
                                Console.WriteLine($"Name: {name}");
                                Console.WriteLine($"Full Path: {fullPath}");
                                Console.WriteLine($"Created: {creationTime}");
                                Console.WriteLine($"Last Modified: {lastModified}");
                                Console.WriteLine($"Attributes: {attributes}");
                                Console.WriteLine($"Owner: {owner}");
                                Console.WriteLine($"Permissions: {permissions}");
                                Console.WriteLine($"Size: {size}");
                                Console.WriteLine();
                            }
                        }

                        break;
                    case 83:
                        history.Add("ls -lh");
                        List<FileSystemInfo> entriesssss = functions.ls_lh();
                        if (stoer)
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                foreach (var entry in entriesssss)
                                {
                                    bool isFile = entry is FileInfo;
                                    string type = isFile ? "File" : "Folder";
                                    string name = entry.Name;
                                    string fullPath = entry.FullName;
                                    DateTime creationTime = entry.CreationTime;
                                    DateTime lastModified = entry.LastWriteTime;
                                    FileAttributes attributes = entry.Attributes;
                                    string owner = isFile ? GetFileOwner((FileInfo)entry) : GetFolderOwner((DirectoryInfo)entry);
                                    string permissions = isFile ? GetFilePermissions((FileInfo)entry) : GetFolderPermissions((DirectoryInfo)entry);
                                    long sizeInBytes = isFile ? ((FileInfo)entry).Length : 0;
                                    string sizeInKilobytes = FormatSize(sizeInBytes);

                                    writer.WriteLine($"Type: {type}");
                                    writer.WriteLine($"Name: {name}");
                                    writer.WriteLine($"Full Path: {fullPath}");
                                    writer.WriteLine($"Created: {creationTime}");
                                    writer.WriteLine($"Last Modified: {lastModified}");
                                    writer.WriteLine($"Attributes: {attributes}");
                                    writer.WriteLine($"Owner: {owner}");
                                    writer.WriteLine($"Permissions: {permissions}");
                                    writer.WriteLine($"Size: {sizeInKilobytes}");
                                    writer.WriteLine();
                                }
                            }
                        }
                        else
                        {
                            foreach (var entry in entriesssss)
                            {
                                bool isFile = entry is FileInfo;
                                string type = isFile ? "File" : "Folder";
                                string name = entry.Name;
                                string fullPath = entry.FullName;
                                DateTime creationTime = entry.CreationTime;
                                DateTime lastModified = entry.LastWriteTime;
                                FileAttributes attributes = entry.Attributes;
                                string owner = isFile ? GetFileOwner((FileInfo)entry) : GetFolderOwner((DirectoryInfo)entry);
                                string permissions = isFile ? GetFilePermissions((FileInfo)entry) : GetFolderPermissions((DirectoryInfo)entry);
                                long sizeInBytes = isFile ? ((FileInfo)entry).Length : 0;
                                string sizeInKilobytes = FormatSize(sizeInBytes);

                                Console.WriteLine($"Type: {type}");
                                Console.WriteLine($"Name: {name}");
                                Console.WriteLine($"Full Path: {fullPath}");
                                Console.WriteLine($"Created: {creationTime}");
                                Console.WriteLine($"Last Modified: {lastModified}");
                                Console.WriteLine($"Attributes: {attributes}");
                                Console.WriteLine($"Owner: {owner}");
                                Console.WriteLine($"Permissions: {permissions}");
                                Console.WriteLine($"Size: {sizeInKilobytes}");
                                Console.WriteLine();
                            }
                        }

                        break;
                    case 42:
                        string[] entrie = functions.ls_r();
                        if (stoer)
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                foreach (string entry in entrie)
                                {
                                    if (File.Exists(entry))
                                    {
                                        string content = "File: " + Path.GetFileName(entry);
                                        writer.WriteLine(content);
                                    }
                                    else if (Directory.Exists(entry))
                                    {
                                        string directoryName = Path.GetFileName(entry);
                                        writer.WriteLine("Folder: " + directoryName);
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (string entry in entrie)
                            {
                                if (File.Exists(entry))
                                {
                                    Console.WriteLine("File: " + Path.GetFileName(entry));
                                }
                                else if (Directory.Exists(entry))
                                {
                                    string directoryName = Path.GetFileName(entry);
                                    Console.WriteLine("Folder: " + directoryName);
                                }
                            }
                        }
                        history.Add("ls -r");
                        break;
                    case 43:
                        history.Add("ls -S");
                        string[] entriess = functions.ls_S();
                        if (stoer)
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                foreach (string entry in entriess)
                                {
                                    if (File.Exists(entry))
                                    {
                                        string content = "File: " + Path.GetFileName(entry);
                                        writer.WriteLine(content);
                                    }
                                    else if (Directory.Exists(entry))
                                    {
                                        string directoryName = Path.GetFileName(entry);
                                        writer.WriteLine("Folder: " + directoryName);
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (string entry in entriess)
                            {
                                if (File.Exists(entry))
                                {
                                    string file = Path.GetFileName(entry);
                                    Console.WriteLine("File: " + file);
                                }
                                else if (Directory.Exists(entry))
                                {
                                    string directoryName = Path.GetFileName(entry);
                                    Console.WriteLine("Folder: " + directoryName);
                                }
                            }
                        }
                        break;
                    case 44:
                        ;
                        history.Add("ls -t");
                        List<FileSystemInfo> entriesss = functions.ls_t();
                        if (stoer)
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                foreach (var entry in entriesss)
                                {
                                    if (entry is FileInfo file)
                                    {
                                        writer.WriteLine($"File: {file.Name}");
                                    }
                                    else if (entry is DirectoryInfo directory)
                                    {
                                        writer.WriteLine($"Folder: {directory.Name}");
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (var entry in entriesss)
                            {
                                if (entry is FileInfo file)
                                {
                                    Console.WriteLine($"File: {file.Name}");
                                }
                                else if (entry is DirectoryInfo directory)
                                {
                                    Console.WriteLine($"Folder: {directory.Name}");
                                }
                            }
                        }

                        break;
                    case 45:
                        string[] allEntries=functions.ls_a();
                        history.Add("ls -a");
                        if (stoer)
                        {
                            using (StreamWriter writer = File.AppendText(filePath))
                            {
                                foreach (string entry in allEntries)
                                {
                                    string entryName = Path.GetFileName(entry);
                                    writer.WriteLine(entryName);
                                }
                            }
                        }
                        else
                        {
                            foreach (string entry in allEntries)
                            {
                                string entryName = Path.GetFileName(entry);
                                Console.WriteLine(entryName);
                            }
                        }
                        break;
                    case 47:
                        functions.touch2();
                        history.Add("touch (folderName)/(FileName)");
                        break;
                    case 48:
                        functions.CreateReplace();
                        history.Add(">(FileName)");
                        break;
                    case 49:
                        functions.CreateReplace2();
                        history.Add(">(folderName)/(FileName)");
                        break;
                    case 51:
                        history.Add("(CommandName) > (FolderName)(FileName)");
                        Console.WriteLine("enter the name to folder");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("enter the name to file");
                        string name2 = Console.ReadLine();
                        string current_path = functions.current_path();
                        filePath = $@"{current_path}\{name1}\{name2}";
                        if (Directory.Exists($@"{current_path}\{name1}"))
                        {
                            if (!File.Exists(filePath))
                            {
                                File.Create(filePath).Close();
                            }
                            else
                            {
                                File.Delete(filePath);
                                File.Create(filePath).Close();
                            }

                        }
                        else
                        {
                            Console.WriteLine("the folder is not found");
                        }
                        stoer = true;
                        Console.WriteLine("enter the number of command from above to store the output of it in the file");
                        goto p;
                       
                    case 85:
                        history.Add("(CommandName) > (FolderName)(FileName)");
                        Console.WriteLine("enter the name to folder");
                        string name11 = Console.ReadLine();
                        Console.WriteLine("enter the name to file");
                        string name22 = Console.ReadLine();
                        string current_pathh = functions.current_path();
                        filePath = $@"{current_pathh}\{name11}\{name22}";
                        if (Directory.Exists($@"{current_pathh}\{name11}"))
                        {
                            if (!File.Exists(filePath))
                            {
                                File.Create(filePath).Close();
                            }
                            stoer = true;
                            Console.WriteLine("enter the number of command from above to store the output of it in the file");
                            goto p;
                        }
                        else
                        {
                            Console.WriteLine("the folder is not found");
                        }
                        break;
                    case 52:
                        functions.createemptyfile();
                        history.Add(">> (FileName)");
                        break;
                    case 53:
                        functions.createemptyfile2();
                        history.Add(">>(folderName)/(FileName)");
                        break;
                    case 54:
                        functions.more1();
                        history.Add("more (FileName)");
                        break;
                    case 55:
                        functions.more2();
                        history.Add("more (folderName)/(FileName)");
                        break;
                    case 56:
                        functions.more3();
                        history.Add("more *");
                        break;
                    case 57:
                        functions.more4();
                        history.Add("more (folderName)/*");
                        break;
                    case 58:
                        functions.more5();
                        history.Add("more -(Number) (File)");
                        break;
                    case 59:
                        functions.more6();
                        history.Add("more -(Number) (folderName)/(File)");
                        break;
                    case 60:
                        functions.more7();
                        history.Add("more +(Number) (File)");
                        break;
                    case 61:
                        functions.more8();
                        history.Add("more +(Number) (folderName)/(File)");
                        break;
                    case 62:
                        functions.more8();
                        history.Add("more -d (File)");
                        break;
                    case 63:
                        functions.more8();
                        history.Add("more -d (folderName)/(File)");
                        break;
                    case 64:
                        functions.head1();
                        history.Add("head -(Number) (FileName)");
                        break;
                    case 65:
                        functions.head2();
                        history.Add("head -(Number) (folderName)/(FileName)");
                        break;
                    case 66:
                        functions.head1();
                        history.Add("head -n(Number) (FileName)");
                        break;
                    case 67:
                        functions.head2();
                        history.Add("head -n(Number) (FileName)");
                        break;
                    case 68:
                        functions.head3();
                        history.Add("head -n-(Number) (folderName)/(FileName)");
                        break;
                    case 69:
                        functions.head4();
                        history.Add("head -n-(Number) (folderName)/(FileName)");
                        break;
                    case 70:
                        functions.tail1();
                        history.Add("tail -(Number) (FileName)");
                        break;
                    case 71:
                        functions.tail2();
                        history.Add("tail -(Number) (folderName)/(FileName)");
                        break;
                    case 72:
                        functions.tail1();
                        history.Add("tail -n(Number) (FileName)");
                        break;
                    case 73:
                        functions.tail2();
                        history.Add("tail -n(Number) (folderName)/(FileName)");
                        break;
                    case 74:
                        functions.tail3();
                        history.Add("tail -n+(Number) (FileName)");
                        break;
                    case 75:
                        functions.tail4();
                        history.Add("tail -n+(Number) (folderName)/(FileName)");
                        break;
                    case 76:
                        functions.cat1();
                        history.Add("cat (FileName) |tr ' '  ' ' ");
                        break;
                    case 77:
                        functions.cat2();
                        history.Add("cat (folderName)/(FileName) |tr ' '  ' ' ");
                        break;
                    case 78:
                        functions.cat3();
                        history.Add("cat (folderName)/* |tr ' '  ' ' ");
                        break;
                    case 79:
                        functions.cat4();
                        history.Add("cat (FileName) |tr 'range'  'range' ");
                        break;
                    case 80:
                        functions.cat5();
                        history.Add("cat (folderName)/(FileName) |tr 'range'  'range' ");
                        break;
                    case 81:
                        functions.cat6();
                        history.Add("cat (FileName)");
                        break;
                    case 82:
                        functions.cat7();
                        history.Add("cat (folderName)/(FileName) |tr 'range'  'range' ");
                        break;
                    case 86:
                        break;
                }
            } while (num != 60);
            Console.ReadKey();
        }
        static string GetFileOwner(FileInfo fileInfo)
        {
            return fileInfo.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
        }

        static string GetFolderOwner(DirectoryInfo directoryInfo)
        {
            return directoryInfo.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
        }

        static string GetFilePermissions(FileInfo fileInfo)
        {
            return fileInfo.GetAccessControl().GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.Owner | System.Security.AccessControl.AccessControlSections.Group | System.Security.AccessControl.AccessControlSections.Access);
        }

        static string GetFolderPermissions(DirectoryInfo directoryInfo)
        {
            return directoryInfo.GetAccessControl().GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.Owner | System.Security.AccessControl.AccessControlSections.Group | System.Security.AccessControl.AccessControlSections.Access);
        }
        static string FormatSize(long size)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;
            double adjustedSize = size;

            while (adjustedSize >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                adjustedSize /= 1024;
                suffixIndex++;
            }

            return $"{adjustedSize:0.##} {suffixes[suffixIndex]}";
        }
        static long GetFolderSize(DirectoryInfo directoryInfo)
        {
            long size = 0;
            FileInfo[] files = directoryInfo.GetFiles();
            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();

            foreach (FileInfo file in files)
            {
                size += file.Length;
            }

            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                size += GetFolderSize(subDirectory);
            }

            return size;
        }
    }
    class functions
    {
        static public string firstdirection;
        static functions()
        {
            firstdirection = Directory.GetCurrentDirectory();
        }
        static public string f_folder()
        {
            Console.WriteLine("enter the location to folder C , E , D");
            string location = Console.ReadLine();
            Console.WriteLine("enter the name to folder");
            string name = Console.ReadLine();
            string folder = $@"{location}:\{name}";
            return folder;
        }
        static public void folder_all(string folder, string typ)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
                if (typ == "mkdir -v")
                {
                    Console.WriteLine($"the folder is created sucssfuly in {folder}");
                }
            }
            else
            {
                Console.WriteLine("the folder is founded");
            }
        }


        static public void mkdir(string typ)
        {
            string folder = f_folder();
            folder_all(folder, typ);

        }
        static public void mkdir_p(string typ)
        {
            Console.WriteLine("enter the location to folder C , E , D");
            string location = Console.ReadLine();
            Console.WriteLine("enter the number from folder that you want create thime 1/2/3");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("enter the name to folder");
                string name = Console.ReadLine();
                string folder = $@"{location}:\{name}";
                folder_all(folder, typ);
            }
            else if (num == 2)
            {
                Console.WriteLine("enter the name to folder");
                string name1 = Console.ReadLine();
                string folder = $@"{location}:\{name1}";
                folder_all(folder, typ);
                Console.WriteLine("enter the name to folder");
                string name2 = Console.ReadLine();
                string folder1 = $@"{location}:\{name1}\{name2}";
                folder_all(folder1, typ);
            }
            else if (num == 3)
            {
                Console.WriteLine("enter the name to folder");
                string name1 = Console.ReadLine();
                string folder = $@"{location}:\{name1}";
                folder_all(folder, typ);
                Console.WriteLine("enter the name to folder");
                string name2 = Console.ReadLine();
                string folder1 = $@"{location}:\{name1}\{name2}";
                folder_all(folder1, typ);
                Console.WriteLine("enter the name to folder");
                string name3 = Console.ReadLine();
                string folder2 = $@"{location}:\{name1}\{name2}\{name3}";
                folder_all(folder2, typ);
            }
        }
        static public void rmdir1(string typ)
        {
            Console.WriteLine("enter the location to folder C , E , D");
            string location = Console.ReadLine();
            Console.WriteLine("enter the num of folder that you want to remove them");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("enter the name to folder");
                string name = Console.ReadLine();
                string folder = $@"{location}:\{name}";
                rmdir_all(folder, typ);
            }

        }
        static public void rmdir_all(string folder, string typ)
        {
            if (Directory.Exists(folder))
            {
                string[] files = Directory.GetFiles(folder);
                if (files.Length > 0) { Console.WriteLine("you can not delete this folder ,it has files..first delete the files then folder"); }
                else
                {
                    string[] subfolders = Directory.GetDirectories(folder);
                    if (subfolders.Length == 0)
                    {
                        Directory.Delete(folder);
                        if (typ == "rmdir -v") { Console.WriteLine("the folder is deleted sucssfuly"); }
                    }
                    else { Console.WriteLine("you can not delete this folder ,it has folders..first delete the folders then folder"); }
                }
            }
            else
            {
                Console.WriteLine("the folder is not founded to delete it");
            }
        }
        static public void rmdir_pv(string typ)
        {
            Console.WriteLine("enter the location to folder C , E , D");
            string location = Console.ReadLine();
            Console.WriteLine("enter the num of folder that you want to remove them 1/2/3");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i <= 3; i--)
            {
                if (i == 3)
                {
                    Console.WriteLine("enter the name to folder");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("enter the name to folder");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("enter the name to folder");
                    string name3 = Console.ReadLine();
                    string folder = $@"{location}:\{name1}\{name2}\{name3}";
                    rmdir_all(folder, typ);
                }
                if (i == 2)
                {
                    Console.WriteLine("enter the name to folder");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("enter the name to folder");
                    string name2 = Console.ReadLine();
                    string folder = $@"{location}:\{name1}\{name2}";
                    rmdir_all(folder, typ);
                }
                if (i == 1)
                {
                    Console.WriteLine("enter the name to folder");
                    string name1 = Console.ReadLine();
                    string folder = $@"{location}:\{name1}";
                    rmdir_all(folder, typ);
                }
            }
        }
        static public void rmdir_all()
        {
            Console.WriteLine("enter the location to folder C , E , D");
            string location = Console.ReadLine();
            Console.WriteLine("enter the folder ");
            string folder1 = Console.ReadLine();
            string folder = $@"{location}:\{folder1}";
            if (Directory.Exists(folder))
            {
                string[] files = Directory.GetFiles(folder);
                if (files.Length > 0) { Console.WriteLine("you can not delete this folder ,it has files..first delete the files then folder"); }
                else
                {
                    string[] subfolders = Directory.GetDirectories(folder);
                    foreach (string subfolder in subfolders) { Directory.Delete(subfolder); }
                }
            }
            else
            {
                Console.WriteLine("the folder is not founded to delete it");
            }

        }
        static public void rmdir2(string typ)
        {
            Console.WriteLine("enter the location to folder C , E , D");
            string location = Console.ReadLine();
            Console.WriteLine("enter the folder ");
            string folder1 = Console.ReadLine();
            Console.WriteLine("enter the num of folder that you want to remove them");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("enter the name to folder");
                string name = Console.ReadLine();
                string folder = $@"{location}:\{folder1}\{name}";
                rmdir_all(folder, typ);
            }
        }
        static public void rm_r()
        {
            Console.WriteLine("enter the location to folder C , E , D");
            string location = Console.ReadLine();
            Console.WriteLine("enter the folder ");
            string folder1 = Console.ReadLine();
            string folder = $@"{location}:\{folder1}";
            if (Directory.Exists(folder))
            {
                string[] files = Directory.GetFiles(folder);
                foreach (string file in files) { File.Delete(file); }
                string[] subfolders = Directory.GetDirectories(folder);
                foreach (string subfolder in subfolders) { Directory.Delete(subfolder); }
                Directory.Delete(folder);
            }
            else { Console.WriteLine("the folder is not founded to delete it"); }
        }
        static public void rm_file(string typ)
        {
            Console.WriteLine("enter the location to file");
            string location = Console.ReadLine();
            Console.WriteLine("enter the name to folder");
            string folder = Console.ReadLine();
            Console.WriteLine("enter the number of file that you want ro remove them");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("enter the name to file");
                string name = Console.ReadLine();
                string fail = $@"{location}:\{folder}\{name}";
                if (File.Exists(fail))
                {
                    if (typ == "rm -i")
                    {
                        Console.WriteLine($"Do you want to remove {fail}");
                        Console.WriteLine("enter Y/N");
                        string ans = Console.ReadLine();
                        if (ans == "Y") { File.Delete(fail); }
                    }
                    else
                    {
                        File.Delete(fail);
                        if (typ == "rm -v") { Console.WriteLine("the file is deleted sucssfuly"); }
                    }
                }
                else { Console.WriteLine("the file is not founded to delete it"); }
            }
        }
        static public void rm_all_file()
        {
            Console.WriteLine("enter the location to file");
            string location = Console.ReadLine();
            Console.WriteLine("enter the name to folder");
            string folder1 = Console.ReadLine();
            string folder = $@"{location}:\{folder1}";
            if (Directory.Exists(folder))
            {
                string[] files = Directory.GetFiles(folder);
                foreach (string file in files) { File.Delete(file); }
            }
            else { Console.WriteLine("the folder is not founded to delete all its files"); }
        }
        static public void cp_file(string typ)
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to copy to it");
            string name3 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            string location = $@"{current_path}\{name3}";
            if ((Directory.Exists($@"{current_path}\{name1}")) && (Directory.Exists(location)))
            {
                if (File.Exists(fail))
                {
                    File.Copy(fail, location);
                    if (typ == "cp -i") { Console.WriteLine("the file is copied sucssfuly"); }
                }
                else { Console.WriteLine("The file was not found."); }
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void cp()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to copy to it cotent");
            string name3 = Console.ReadLine();
            Console.WriteLine("enter the name of file that you want to copy to it");
            string name4 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail1 = $@"{current_path}\{name1}\{name2}";
            string fail2 = $@"{current_path}\{name3}\{name4}";
            if ((Directory.Exists($@"{current_path}\{name1}")) && (Directory.Exists($@"{current_path}\{name3}")))
            {
                if (File.Exists(fail1) && File.Exists(fail2))
                {
                    string fileContent = File.ReadAllText(fail1);
                    File.WriteAllText(fail2, fileContent);
                }
                else { Console.WriteLine("The file was not found."); }
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void cp_folder()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to copy to it");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string folder = $@"{current_path}\{name1}";
            string location = $@"{current_path}\{name2}";
            string location1 = $@"{current_path}\{name2}\{name1}";
            if ((Directory.Exists(folder)))
            {
                copy_directory(location, location1);
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void copy_directory(string location, string location1)
        {
            if ((Directory.Exists(location)))
            {
                Directory.CreateDirectory(location1);
            }
        }
        static public void cp_all(string typ)
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to copy to it");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string folder = $@"{current_path}\{name1}";
            string location = $@"{current_path}\{name2}";
            if ((Directory.Exists(folder)))
            {
                string[] failes = Directory.GetFiles(folder);
                string[] dirs = Directory.GetDirectories(folder);
                foreach (string fail in failes)
                {
                    string filename = Path.GetFileName(fail);
                    string destfile = Path.Combine(location, filename);
                    File.Copy(fail, destfile);
                }
                if (typ == "cp -r *")
                {
                    foreach (string dir in dirs)
                    {
                        string dirname = Path.GetFileName(dir);
                        string dessubdir = Path.Combine(location, dirname);
                        copy_directory(dir, dessubdir);
                    }
                }
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void mv_file(string typ)
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to move to it");
            string name3 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            string location = $@"{current_path}\{name3}";
            if ((Directory.Exists($@"{current_path}\{name1}")) && (Directory.Exists(location)))
            {
                if (File.Exists(fail))
                {
                    File.Move(fail, location);
                    if (typ == "mv -i") { Console.WriteLine("the file is moved sucssfuly"); }
                }
                else { Console.WriteLine("The file was not found."); }
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void mv_folder(string typ)
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to move to it");
            string name3 = Console.ReadLine();
            string current_path = functions.current_path();
            string folder = $@"{current_path}\{name1}";
            string location = $@"{current_path}\{name3}";
            if ((Directory.Exists(folder)) && (Directory.Exists(location)))
            {
                Directory.Move(folder, location);
                if (typ == "mv -i") { Console.WriteLine("the file is moved sucssfuly"); }
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void mv_all()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to move to it");
            string name3 = Console.ReadLine();
            string current_path = functions.current_path();
            string folder = $@"{current_path}\{name1}";
            string location = $@"{current_path}\{name3}";
            if ((Directory.Exists(folder)) && (Directory.Exists(location)))
            {
                string[] failes = Directory.GetFiles(folder);
                string[] dirs = Directory.GetDirectories(folder);
                foreach (string fail in failes)
                { File.Move(fail, location); }
                foreach (string dir in dirs)
                { Directory.Move(dir, location); }
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void mv_file_re()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            Console.WriteLine("enter the name of file that you want to rename to it");
            string name3 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            string location = $@"{current_path}\{name1}\{name3}";
            if ((Directory.Exists($@"{current_path}\{name1}")))
            {
                if (File.Exists(fail))
                {
                    string distpath = Path.Combine(Path.GetDirectoryName(fail), location);
                    File.Move(fail, distpath);
                }
                else { Console.WriteLine("The file was not found."); }
            }
            else { Console.WriteLine("the folder is not found"); }
        }
        static public void mv_folder_re()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of folder that you want to rename to it");
            string name3 = Console.ReadLine();
            string current_path = functions.current_path();
            string folder = $@"{current_path}\{name1}";
            string location = $@"{current_path}\{name3}";
            if ((Directory.Exists(folder)) && (Directory.Exists(location)))
            {
                string distpath = Path.Combine(Path.GetDirectoryName(folder), location);
                File.Move(folder, distpath);
            }
            else { Console.WriteLine("the folder is not found"); }
        }

        static public void cat5()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter a range of characters (capital or small):");
            string range = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    string fileContent = File.ReadAllText(fail);
                    string modifiedContent = ModifyText(range, fileContent);

                    Console.WriteLine("Modified file content:");
                    Console.WriteLine(modifiedContent);
                }
                else
                {
                    Console.WriteLine("The file was not found.");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void cat4()
        {
            Console.WriteLine("Enter a range of characters (capital or small):");
            string range = Console.ReadLine();

            Console.WriteLine("Enter the name of the file:");
            string fileName = Console.ReadLine();

            string currentPath = functions.current_path();
            string filePath = Path.Combine(currentPath, fileName);

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                string modifiedContent = ModifyText(range, fileContent);

                Console.WriteLine("Modified file content:");
                Console.WriteLine(modifiedContent);
            }
            else
            {
                Console.WriteLine("The file was not found.");
            }
        }
        static string ModifyText(string range, string text)
        {
            string modifiedText = "";

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c) && range.Contains(c.ToString().ToUpper()))
                    {
                        modifiedText += char.ToLower(c);
                    }
                    else if (char.IsLower(c) && range.Contains(c.ToString().ToLower()))
                    {
                        modifiedText += char.ToUpper(c);
                    }
                    else
                    {
                        modifiedText += c;
                    }
                }
                else
                {
                    modifiedText += c;
                }
            }

            return modifiedText;
        }
        static public void cat3()
        {
            Console.WriteLine("Enter the name of the folder:");
            string folderName = Console.ReadLine();

            Console.WriteLine("Enter the character or word to replace:");
            string replaceText = Console.ReadLine();

            Console.WriteLine("Enter the replacement character or word:");
            string replacement = Console.ReadLine();

            string currentPath = functions.current_path();
            string folderPath = $@"{ currentPath }\{ folderName}";

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);

                foreach (string filePath in files)
                {
                    string fileContent = File.ReadAllText(filePath);
                    string replacedContent = fileContent.Replace(replaceText, replacement);

                    Console.WriteLine($"File: {Path.GetFileName(filePath)}");
                    Console.WriteLine("File content with replacements:");
                    Console.WriteLine(replacedContent);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The folder was not found.");
            }
        }
        static public void cat2()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("Enter the character or word to replace:");
                    string replaceText = Console.ReadLine();

                    Console.WriteLine("Enter the replacement character or word:");
                    string replacement = Console.ReadLine();

                    string fileContent = File.ReadAllText(fail);
                    string replacedContent = fileContent.Replace(replaceText, replacement);

                    Console.WriteLine("File content with replacements:");
                    Console.WriteLine(replacedContent);
                }
                else
                {
                    Console.WriteLine("The file was not found.");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void cat7()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    string fileContent = File.ReadAllText(fail);
                    Console.WriteLine("File content:");
                    Console.WriteLine(fileContent);
                }
                else
                {
                    Console.WriteLine("The file was not found.");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void cat6()
        {
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();

            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{fileName}";

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File content:");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
        static public void cat1()
        {

            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{name}";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the character or word to replace:");
                string replaceText = Console.ReadLine();

                Console.WriteLine("Enter the replacement character or word:");
                string replacement = Console.ReadLine();

                string fileContent = File.ReadAllText(filePath);
                string replacedContent = fileContent.Replace(replaceText, replacement);

                Console.WriteLine("File content with replacements:");
                Console.WriteLine(replacedContent);
            }
            else
            {
                Console.WriteLine("The file was not found.");
            }
        }


        static public void createemptyfile()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name}";

            if (File.Exists(fail))
            {

                Console.WriteLine("File is alredy exist.");
            }
            else
            {
                File.Create(fail).Close();
                Console.WriteLine("File is created successfully.");

            }
        }
        static public void CreateReplace()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name}";

            if (File.Exists(fail))
            {
                File.Delete(fail);
                File.Create(fail).Close();
                Console.WriteLine("File is replaced successfully.");
            }
            else
            {
                File.Create(fail).Close();
                Console.WriteLine("File created is successfully.");

            }
        }
        static public void createemptyfile2()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("File is alredy created.");
                }
                else
                {
                    File.Create(fail).Close();
                    Console.WriteLine("File is created successfully.");

                }

            }
            else
            {
                Console.WriteLine("the folder is not found");
            }

        }
        static public void CreateReplace2()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    File.Delete(fail);
                    File.Create(fail).Close();
                    Console.WriteLine("File is replaced successfully.");
                }
                else
                {
                    File.Create(fail).Close();
                    Console.WriteLine("File created is successfully.");

                }

            }
            else
            {
                Console.WriteLine("the folder is not found");
            }

        }
        static public void touch()
        {
            Console.WriteLine("enter the number of files do you want to create:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("enter the name of file");
                string name = Console.ReadLine();
                string current_path = functions.current_path();
                string fail = $@"{current_path}\{name}";
                if (!File.Exists(fail))
                {
                    File.Create(fail).Close();
                    Console.WriteLine("the file is created sucssfuly");
                }
                else
                {
                    File.SetLastWriteTime(fail, DateTime.Now);
                    Console.WriteLine("The file already exists. Access and modification time updated.");
                }
            }

        }
        static public void touch2()
        {
            Console.WriteLine("enter the number of files do you want to create:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("enter the name to folder");
                string name1 = Console.ReadLine();
                Console.WriteLine("enter the name to file");
                string name2 = Console.ReadLine();
                string current_path = functions.current_path();
                string fail = $@"{current_path}\{name1}\{name2}";
                if (Directory.Exists($@"{current_path}\{name1}"))
                {
                    if (!File.Exists(fail))
                    {
                        File.Create(fail).Close();
                        Console.WriteLine("the file is created sucssfuly");
                    }
                    else
                    {
                        File.SetLastWriteTime(fail, DateTime.Now);
                        Console.WriteLine("The file already exists. Access and modification time updated.");
                    }

                }
                else
                {
                    Console.WriteLine("the folder is not found");
                }
            }
        }

        static public List<FileSystemInfo> ls_t()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            List<FileSystemInfo> entries = new List<FileSystemInfo>();

            entries.AddRange(new DirectoryInfo(currentDirectory).GetFiles());
            entries.AddRange(new DirectoryInfo(currentDirectory).GetDirectories());

            entries.Sort((a, b) => b.LastWriteTime.CompareTo(a.LastWriteTime));
            return entries;

            //string currentDirectory = Directory.GetCurrentDirectory();
            //Console.WriteLine("Files:\n");
            //string[] files = Directory.GetFiles(currentDirectory);
            //Array.Sort(files, (a, b) => File.GetLastWriteTime(b).CompareTo(File.GetLastWriteTime(a)));
            //foreach (string file in files)
            //{
            //    string fileName = Path.GetFileName(file);
            //    Console.WriteLine("File: " + fileName);
            //}

            //Console.WriteLine("\nFolders:\n");
            //string[] directories = Directory.GetDirectories(currentDirectory);
            //Array.Sort(directories, (a, b) => Directory.GetLastWriteTime(b).CompareTo(Directory.GetLastWriteTime(a)));
            //foreach (string directory in directories)
            //{
            //    string directoryName = Path.GetFileName(directory);
            //    Console.WriteLine("Folder: " + directoryName);
            //}
        }
        static public string[] ls()
        {
            string folder = current_path();
            string[] entries = Directory.GetFileSystemEntries(folder);

            Array.Sort(entries);
            return entries;


            //Console.WriteLine("files:\n");
            //string[] files = Directory.GetFiles(folder);

            //foreach (string file in files)
            //{

            //    string fileName = Path.GetFileName(file);
            //    Console.WriteLine("File: " + fileName);
            //}
            //Console.WriteLine("\nfolders:\n");
            //string[] Directories = Directory.GetDirectories(folder);
            //return files , Directories
            //foreach (string Directory in Directories)
            //{
            //    string directoryName = Path.GetFileName(Directory);
            //    Console.WriteLine("Folder: " + directoryName);
            //}
        }


        static public string[] ls_S()
        {
            string folder = current_path();
            string[] entries = Directory.GetFileSystemEntries(folder);

            Array.Sort(entries, (entry1, entry2) =>
            {
                if (File.Exists(entry1) && File.Exists(entry2))
                {
                    long fileSize1 = new FileInfo(entry1).Length;
                    long fileSize2 = new FileInfo(entry2).Length;
                    return fileSize2.CompareTo(fileSize1); // ترتيب حسب الحجم من الأكبر إلى الأصغر
                }
                else
                {
                    return 0;
                }
            });
            return entries;

        }
        //    string currentDirectory = Directory.GetCurrentDirectory();
        //    string[] files = Directory.GetFiles(currentDirectory);
        //    string[] directories = Directory.GetDirectories(currentDirectory);

        //    var sortedFiles = files.Select(file => new FileInfo(file))
        //                           .OrderByDescending(fileInfo => fileInfo.Length);

        //    var sortedDirectories = directories.Select(directory => new DirectoryInfo(directory))
        //                                       .OrderByDescending(directoryInfo => GetDirectorySize(directoryInfo));

        //    Console.WriteLine("Files:");
        //    foreach (var fileInfo in sortedFiles)
        //    {
        //        Console.WriteLine($"{fileInfo.Name}");
        //    }

        //    Console.WriteLine("\nFolders:");
        //    foreach (var directoryInfo in sortedDirectories)
        //    {
        //        Console.WriteLine($"{directoryInfo.Name}");
        //    }
        //}

        //static long GetDirectorySize(DirectoryInfo directoryInfo)
        //{
        //    long size = 0;

        //    FileInfo[] files = directoryInfo.GetFiles();
        //    foreach (FileInfo file in files)
        //    {
        //        size += file.Length;
        //    }

        //    DirectoryInfo[] directories = directoryInfo.GetDirectories();
        //    foreach (DirectoryInfo directory in directories)
        //    {
        //        size += GetDirectorySize(directory);
        //    }

        //    return size;

        static public string[] ls_r()
        {
            string folder = current_path();
            string[] entries = Directory.GetFileSystemEntries(folder);

            Array.Sort(entries);
            Array.Reverse(entries);
            return entries;
        }

        static string FormatSize(long size)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;
            double adjustedSize = size;

            while (adjustedSize >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                adjustedSize /= 1024;
                suffixIndex++;
            }

            return $"{adjustedSize:0.##} {suffixes[suffixIndex]}";
        }

        // الدوال الأخرى
        static public void more7()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{name}";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the number of lines to ignore:");
                int linesToIgnore = int.Parse(Console.ReadLine());

                string[] lines = File.ReadAllLines(filePath);
                int totalLines = lines.Length;

                if (linesToIgnore < totalLines)
                {
                    Console.WriteLine("Contents of file:");

                    for (int i = linesToIgnore; i < totalLines; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
                else
                {
                    Console.WriteLine("No lines to display.");
                }
            }
            else
            {
                Console.WriteLine("The file is not found to view its contents.");
            }
        }
        static public void more1()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name}";
            if (File.Exists(fail))
            {
                string filecontent = File.ReadAllText(fail);
                Console.WriteLine("contents of file:\n" + filecontent);

            }
            else
            {
                Console.WriteLine("the file is not founded to viwe contents ");
            }
        }
        static public void more3()
        {
            string currentPath = functions.current_path();
            string[] files = Directory.GetFiles(currentPath);
            foreach (string file in files)
            {
                string fileContent = File.ReadAllText(file);
                Console.WriteLine("File: " + Path.GetFileName(file));
                Console.WriteLine("Contents:\n" + fileContent);
                Console.WriteLine("----------------------------------------");
            }
        }
        static public void head3()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{name}";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the number of lines to exclude from printing:");
                int linesToExclude = int.Parse(Console.ReadLine());

                string[] lines = File.ReadAllLines(filePath);
                int totalLines = lines.Length;

                if (linesToExclude < totalLines)
                {
                    Console.WriteLine("Contents of file:");

                    for (int i = 0; i < totalLines - linesToExclude; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
                else
                {
                    Console.WriteLine("No lines to display.");
                }
            }
            else
            {
                Console.WriteLine("The file is not found to view its contents.");
            }
        }
        static public void head1()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();
            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{name}";
            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the number of Lines do you want to print:");
                int linesToRead = int.Parse(Console.ReadLine());
                int totalLines = File.ReadLines(filePath).Count();
                Console.WriteLine("Contents of file:");
                var lines = File.ReadLines(filePath).Take(linesToRead);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            else
            {
                Console.WriteLine("The file is not found to view its contents.");
            }
        }
        static public void more5()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();
            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{name}";
            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the number of Lines do you want to print:");
                int linesToRead = int.Parse(Console.ReadLine());
                int totalLines = File.ReadLines(filePath).Count();
                Console.WriteLine("Contents of file:");
                var lines = File.ReadLines(filePath).Take(linesToRead);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                if (linesToRead < totalLines)
                {
                    Console.WriteLine("Do you want to print more lines? (yes/no)");
                    string answer = Console.ReadLine();

                    while (answer.ToLower() == "yes")
                    {
                        lines = File.ReadLines(filePath).Skip(linesToRead).Take(1);
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }

                        linesToRead += 1;
                        if (linesToRead >= totalLines)
                        {
                            break;
                        }
                        Console.WriteLine("Do you want to print more lines? (yes/no)");
                        answer = Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("The file is not found to view its contents.");
            }
        }
        static public void more4()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}";
            if (Directory.Exists(fail))
            {
                string[] files = Directory.GetFiles(fail);
                foreach (string file in files)
                {
                    string fileContent = File.ReadAllText(file);
                    Console.WriteLine("File: " + Path.GetFileName(file));
                    Console.WriteLine("Contents:\n" + fileContent);
                    Console.WriteLine("----------------------------------------");
                }

            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void tail1()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{name}";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the number of lines to print from the end:");
                int linesToPrint = int.Parse(Console.ReadLine());

                string[] lines = File.ReadAllLines(filePath);
                int totalLines = lines.Length;

                if (linesToPrint <= totalLines)
                {
                    Console.WriteLine("Contents of file:");

                    for (int i = totalLines - 1; i >= totalLines - linesToPrint; i--)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
                else
                {
                    Console.WriteLine("No lines to display.");
                }
            }
            else
            {
                Console.WriteLine("The file is not found to view its contents.");
            }
        }
        static public void head4()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("Enter the number of lines to exclude from printing:");
                    int linesToExclude = int.Parse(Console.ReadLine());

                    string[] lines = File.ReadAllLines(fail);
                    int totalLines = lines.Length;

                    if (linesToExclude < totalLines)
                    {
                        Console.WriteLine("Contents of file:");

                        for (int i = 0; i < totalLines - linesToExclude; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No lines to display.");
                    }

                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void tail3()
        {
            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine();

            string currentPath = functions.current_path();
            string filePath = $@"{currentPath}\{name}";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the starting line number:");
                int startLine = int.Parse(Console.ReadLine());

                string[] lines = File.ReadAllLines(filePath);
                int totalLines = lines.Length;

                if (startLine >= 1 && startLine <= totalLines)
                {
                    Console.WriteLine("Contents of file:");

                    for (int i = startLine - 1; i < totalLines; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid starting line number.");
                }
            }
            else
            {
                Console.WriteLine("The file is not found to view its contents.");
            }
        }
        static public void tail4()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("Enter the starting line number:");
                    int startLine = int.Parse(Console.ReadLine());

                    string[] lines = File.ReadAllLines(fail);
                    int totalLines = lines.Length;

                    if (startLine >= 1 && startLine <= totalLines)
                    {
                        Console.WriteLine("Contents of file:");

                        for (int i = startLine - 1; i < totalLines; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid starting line number.");
                    }
                }
                else
                {
                    Console.WriteLine("the file is not founded to viwe contents ");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void tail2()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("Enter the number of lines to print from the end:");
                    int linesToPrint = int.Parse(Console.ReadLine());

                    string[] lines = File.ReadAllLines(fail);
                    int totalLines = lines.Length;

                    if (linesToPrint <= totalLines)
                    {
                        Console.WriteLine("Contents of file:");

                        for (int i = totalLines - 1; i >= totalLines - linesToPrint; i--)
                        {
                            Console.WriteLine(lines[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No lines to display.");
                    }

                }
                else
                {
                    Console.WriteLine("the file is not founded to viwe contents ");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void head2()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("Enter the number of Lines do you want to print:");
                    int linesToRead = int.Parse(Console.ReadLine());
                    int totalLines = File.ReadLines(fail).Count();
                    Console.WriteLine("Contents of file:");
                    var lines = File.ReadLines(fail).Take(linesToRead);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("the file is not founded to viwe contents ");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void more6()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("Enter the number of Lines do you want to print:");
                    int linesToRead = int.Parse(Console.ReadLine());
                    int totalLines = File.ReadLines(fail).Count();
                    Console.WriteLine("Contents of file:");
                    var lines = File.ReadLines(fail).Take(linesToRead);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    if (linesToRead < totalLines)
                    {
                        Console.WriteLine("Do you want to print more lines? (yes/no)");
                        string answer = Console.ReadLine();

                        while (answer.ToLower() == "yes")
                        {
                            lines = File.ReadLines(fail).Skip(linesToRead).Take(1);
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }

                            linesToRead += 1;
                            if (linesToRead >= totalLines)
                            {
                                break;
                            }
                            Console.WriteLine("Do you want to print more lines? (yes/no)");
                            answer = Console.ReadLine();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("the file is not founded to viwe contents ");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void more8()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    Console.WriteLine("Enter the number of lines to ignore:");
                    int linesToIgnore = int.Parse(Console.ReadLine());

                    string[] lines = File.ReadAllLines(fail);
                    int totalLines = lines.Length;

                    if (linesToIgnore < totalLines)
                    {
                        Console.WriteLine("Contents of file:");

                        for (int i = linesToIgnore; i < totalLines; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No lines to display.");
                    }
                }
                else
                {
                    Console.WriteLine("the file is not founded to viwe contents ");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }
        static public void more2()
        {
            Console.WriteLine("enter the name of folder");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of file");
            string name2 = Console.ReadLine();
            string current_path = functions.current_path();
            string fail = $@"{current_path}\{name1}\{name2}";
            if (Directory.Exists($@"{current_path}\{name1}"))
            {
                if (File.Exists(fail))
                {
                    string filecontent = File.ReadAllText(fail);
                    Console.WriteLine("contents of file:\n" + filecontent);

                }
                else
                {
                    Console.WriteLine("the file is not founded to viwe contents ");
                }
            }
            else
            {
                Console.WriteLine("the folder is not found");
            }
        }

        static public string current_path()
        {

            string currentdirectory = Directory.GetCurrentDirectory();
            return (currentdirectory);

        }
        static public void clear()
        {
            Console.Clear();
        }
        static public string cd_folder()
        {
            Console.WriteLine("enter the name of folder");
            string nam = Console.ReadLine();
            string[] Directories = Directory.GetDirectories(current_path());
            bool isfound = false;
            foreach (string Directory in Directories)
            {
                string directoryName = Path.GetFileName(Directory);
                if (directoryName == nam)
                {
                    isfound = true;
                    break;
                }
            }
            if (isfound == true)
            {
                string newDirectory = current_path() + $"\\{nam}";
                Directory.SetCurrentDirectory(newDirectory);

                string currentDirectory = Directory.GetCurrentDirectory();
                return ("Current Directory: " + currentDirectory);
            }
            else
            {
                return "the folder not found";
            }
        }
        static public string cd_Backspac1()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string currentPath = Path.GetDirectoryName(currentDirectory);
            if (currentPath != null)
            {
                Directory.SetCurrentDirectory(currentPath);
                return ("Current Directory: " + Directory.GetCurrentDirectory());


            }
            else
            {
                return "you can not go far than this";
            }
        }
        static public string cd_Backspac2()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string currentPath = Path.GetDirectoryName(currentDirectory);
            if (currentPath != null)
            {
                Directory.SetCurrentDirectory(currentPath);
            }
            else
            {
                return "you can not go far than this";
            }
            currentPath = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            if (currentPath != null)
            {
                Directory.SetCurrentDirectory(currentPath);
                return ("Current Directory: " + Directory.GetCurrentDirectory());
            }
            else
            {
                return "you can not go far than this";
            }
        }
        static public string cd()
        {

            Directory.SetCurrentDirectory(firstdirection);
            return ("Current Directory: " + Directory.GetCurrentDirectory());
        }
        static public DateTime date()
        {
            DateTime currentDateTime = DateTime.Now;
            return currentDateTime;
        }
        static public string[] ls_a()
        {
            string folderPath = Directory.GetCurrentDirectory();
                string[] allEntries = Directory.GetFileSystemEntries(folderPath, "*", SearchOption.AllDirectories);
            return allEntries;
              
            
        }
        static public List<FileSystemInfo> ls_l()
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            List<FileSystemInfo> entries = new List<FileSystemInfo>();

            entries.AddRange(new DirectoryInfo(currentDirectory).GetFiles());
            entries.AddRange(new DirectoryInfo(currentDirectory).GetDirectories());
            return entries;

        }


        static public List<FileSystemInfo> ls_lh()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            List<FileSystemInfo> entries = new List<FileSystemInfo>();

            entries.AddRange(new DirectoryInfo(currentDirectory).GetFiles());
            entries.AddRange(new DirectoryInfo(currentDirectory).GetDirectories());
            return entries;


        }



    }



        
    }


