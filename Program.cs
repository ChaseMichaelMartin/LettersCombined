using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace PostageSaver
{
    public class Program
    {
        static void Main()
        {
            string fileName = "admission-00000980.txt";
            string fileName0 = "scholarship-00000980.txt";

            string sourcePath = @"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Admission\20220125";
            string sourcePath0 = @"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Scholarship\20220125";

            string targetPath = @"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Archive";
            string targetPath0 = @"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Archive";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string sourceFile0 = System.IO.Path.Combine(sourcePath0, fileName0);

            string destFile = System.IO.Path.Combine(targetPath, fileName);
            string destFile0 = System.IO.Path.Combine(targetPath0, fileName0);

            string targetPath1 = @"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Letters";
            string targetPath2 = @"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Letters";

            string sourceFile1 = System.IO.Path.Combine(sourcePath, fileName);
            string sourceFile2 = System.IO.Path.Combine(sourcePath0, fileName0);

            string destFile1 = System.IO.Path.Combine(targetPath, fileName);
            string destFile2 = System.IO.Path.Combine(targetPath0, fileName0);

            System.IO.Directory.CreateDirectory(targetPath);
            System.IO.Directory.CreateDirectory(targetPath0);

            System.IO.File.Copy(sourceFile, destFile, true);
            System.IO.File.Copy(sourceFile0, destFile0, true);


            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("No letters produced!");
            }

            if (System.IO.Directory.Exists(sourcePath0))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath0);

                foreach (string s in files)
                {
                    fileName0 = System.IO.Path.GetFileName(s);
                    destFile0 = System.IO.Path.Combine(targetPath0, fileName0);
                    System.IO.File.Copy(s, destFile0, true);
                }
            }
            else
            {
                Console.WriteLine("No letters produced!");
            }

            System.IO.Directory.CreateDirectory(targetPath1);
            System.IO.Directory.CreateDirectory(targetPath2);


            System.IO.File.Copy(sourceFile1, destFile1, true);
            System.IO.File.Copy(sourceFile2, destFile2, true);


            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile1 = System.IO.Path.Combine(targetPath1, fileName);
                    System.IO.File.Copy(s, destFile1, true);
                }
            }

            if (System.IO.Directory.Exists(sourcePath0))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath0);

                foreach (string s in files)
                {
                    fileName0 = System.IO.Path.GetFileName(s);
                    destFile2 = System.IO.Path.Combine(targetPath2, fileName0);

                    System.IO.File.Copy(s, destFile2, true);
                }
            }

            List<string> listOfPersons = new List<string>();
            List<string> letters = new List<string>();


            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    listOfPersons.Add(s);
                }
            }

            if (System.IO.Directory.Exists(sourcePath0))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath0);

                foreach (string s in files)
                {
                    listOfPersons.Add(s);
                }
            }

            if (System.IO.Directory.Exists(targetPath1))
            {
                string[] files = System.IO.Directory.GetFiles(targetPath1);

                foreach (string s in files)
                {
                    letters.Add(s);
                }
            }

            List<string> students = new List<string>();
            string student1 = "ID-00000980";
            string student2 = "ID-00000987";

            students.Add(student1);
            students.Add(student2);

            List<string> validStudents = new List<string>();


            for (int i = 0; i < students.Count; i++)
            {
                if (students[i] != letters[i])
                {
                    validStudents.Add(students[i]);
                }

            }
            List<string> combos1 = new List<string>();

            if (System.IO.Directory.Exists(targetPath1))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    combos1.Add(s);
                }
            }
            List<string> combos2 = new List<string>();

            if (System.IO.Directory.Exists(targetPath1))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    combos2.Add(s);
                }
            }


            using (StreamWriter sw = File.CreateText(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Output\Report.txt"))
            {
                if (0 <= validStudents.Count())
                {

                    sw.WriteLine("01/25/2022 Report" + "\r\n" + "-------------------" + "\r\n" + "Number of Combined Letters: " + validStudents.Count() + "\r\n");

                    for (int i = 0; i < validStudents.Count(); i++)
                        sw.WriteLine(validStudents[i]);
                }
            }

            string[] inputFile1 = File.ReadAllLines(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Admission\20220125\admission-00000987.txt");
            string[] inputFile2 = File.ReadAllLines(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Scholarship\20220125\scholarship-00000987.txt");
            string[] inputFile3 = File.ReadAllLines(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Admission\20220125\admission-00000980.txt");
            string[] inputFile4 = File.ReadAllLines(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Scholarship\20220125\scholarship-00000980.txt");
            string[] inputFile5 = File.ReadAllLines(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Admission\20220125\admission-00000982.txt");
            string[] inputFile6 = File.ReadAllLines(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Scholarship\20220125\scholarship-00000981.txt");

            using (StreamWriter combine = File.CreateText(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Output\LettersCombined.txt"))
            {

                for (int i = 0; i < inputFile1.Length || i < inputFile2.Length; i++)
                {

                    String fileID = System.IO.File.ReadAllText(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Admission\20220125\admission-00000987.txt");

                    if (inputFile2.Contains(fileID))
                    {
                        combine.WriteLine(inputFile1[i]);
                        combine.WriteLine(inputFile2[i]);
                    }

                }

                for (int i = 0; i < inputFile3.Length || i < inputFile4.Length; i++)
                {

                    String fileID = System.IO.File.ReadAllText(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Admission\20220125\admission-00000980.txt");

                    if (inputFile3.Contains(fileID))
                    {
                        combine.WriteLine(inputFile3[i]);
                        combine.WriteLine(inputFile4[i]);

                    }

                }


                for (int i = 0; i < inputFile5.Length || i < inputFile6.Length; i++)
                {

                    String fileID = System.IO.File.ReadAllText(@"C:\Users\maudy\Downloads\CombinedLetters-main\CombinedLetters-main\Input\Admission\20220125\admission-00000982.txt");

                    if (inputFile6.Contains(fileID))
                    {
                        combine.WriteLine(inputFile5[i]);
                        combine.WriteLine(inputFile6[i]);

                    }

                }
            }
                Console.WriteLine("Process complete, press any key to exit.");

                Console.ReadKey();
        }

    }
}


