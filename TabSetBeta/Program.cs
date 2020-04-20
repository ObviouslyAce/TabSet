using System;
using System.Diagnostics;



namespace TabSetBeta
{
    class Program
    {
        static void Main(string[] args)
        {
            // start of console
            Console.WriteLine("Made by ObviouslyAce#6020");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\ta - school");
            Console.WriteLine("\tb - Socials(Discord and Twitter)");
            Console.WriteLine("\tc - Also Socials(Discord, Twitter, and Instagram)");
            Console.WriteLine("\td - credits");
            Console.WriteLine("\te - latest changes/updates");
            Console.WriteLine("\tpress enter 2 times - exit");
            Console.Write("Choose Option ");


            switch (Console.ReadLine())
            {
                case "a":
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.CreateNoWindow = false;
                        process.StartInfo.RedirectStandardInput = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.UseShellExecute = false;
                        process.Start();
                        process.StandardInput.WriteLine("start http://mysdpbc.org");
                        process.StandardInput.WriteLine("start http://classroom.google.com/u/1");
                        process.StandardInput.WriteLine("start http://google.com");
                    }
                    Console.WriteLine("Completed Tab set 'school' ");
                    break;
                case "b":
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.CreateNoWindow = false;
                        process.StartInfo.RedirectStandardInput = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.UseShellExecute = false;
                        process.Start();
                        process.StandardInput.WriteLine("start https://discordapp.com/channels/@me");
                        process.StandardInput.WriteLine("start http://twitter.com");
                    }
                    Console.WriteLine("Completed TabSet 'Socials'");
                    break;
                case "c":
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.CreateNoWindow = false;
                        process.StartInfo.RedirectStandardInput = true;
                        process.StartInfo.RedirectStandardOutput = false;
                        process.StartInfo.UseShellExecute = false;
                        process.Start();
                        process.StandardInput.WriteLine("start https://discordapp.com/channels/@me");
                        process.StandardInput.WriteLine("start https://twitter.com");
                        process.StandardInput.WriteLine("start https://instagram.com");
                        process.StandardInput.Flush();
                    }
                    Console.WriteLine("Completed TabSet 'Also Socials'");
                    break;
                case "d":
                    Console.WriteLine("Made by ObviouslyAce#6020");
                    Console.WriteLine("Cause I'm obviously an ace at this type of stuff, lol");
                    break;
                case "e":
                    Console.WriteLine("First beta");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Added options:");
                    Console.WriteLine("\t School");
                    Console.WriteLine("\t Socials and Also Socials");
                    Console.WriteLine("\t Credits");
                    Console.WriteLine("\t Latest Changes/Updates");
                    Console.WriteLine("That's all for now!");
                    break;

            }
            Console.Write("Press any key to close the TabSetOpener console app...");
            Console.ReadKey();
        }
    }
}