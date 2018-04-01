using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace Process_StandardInput_Sample
{
    class StandardInputTest
    {
        static void Main()
        {
            try
            {
                double score = 0;
                Process solution = new Process();

                solution.StartInfo.UseShellExecute = false;
                solution.StartInfo.RedirectStandardInput = true;
                solution.StartInfo.RedirectStandardOutput = true;

                solution.StartInfo.FileName = "Solution.exe";
                solution.StartInfo.CreateNoWindow = true;
                solution.Start();



                System.IO.StreamReader solutionRR = solution.StandardOutput;


                Process authorSolution = new Process();

                authorSolution.StartInfo.UseShellExecute = false;
                authorSolution.StartInfo.RedirectStandardInput = true;
                authorSolution.StartInfo.RedirectStandardOutput = true;

                authorSolution.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution.StartInfo.CreateNoWindow = true;
                authorSolution.Start();



                System.IO.StreamReader authorSolutionRR = authorSolution.StandardOutput;



                string solutionRR2 = solutionRR.ReadToEnd();
           
                string authorSolutionRR2 = authorSolutionRR.ReadToEnd();
                Console.Write("Test #1");
                if (solutionRR2 == authorSolutionRR2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score = 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("YOUR OUTPUT");
                    Console.WriteLine(solutionRR2);
                                   
                    Console.WriteLine();
                }



                solution.WaitForExit();
                solution.Close();
                authorSolution.WaitForExit();
                authorSolution.Close();

                Console.WriteLine();
        
                Console.ForegroundColor = ConsoleColor.White;


        
                Console.ForegroundColor = ConsoleColor.Blue;
                score = Math.Round(score, 0);
                Console.WriteLine("You achieved " + score + "% !");
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Follow the instructions :");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write(" 1.Move your file to ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("'Numbers 1 to 20' ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("folder !");
                Console.WriteLine();
                Console.Write(" 2.Rename your file to");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("'Solution' ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("!");
                Console.WriteLine();
                Console.Write(" 3.Start ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("CheckSolution.exe");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" again !");
                Console.WriteLine();
                Console.ReadLine();


            }
        }


    }
}
