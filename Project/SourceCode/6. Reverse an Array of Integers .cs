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


                System.IO.StreamWriter solutionWR = solution.StandardInput;
                System.IO.StreamReader solutionRR = solution.StandardOutput;


                Process authorSolution = new Process();

                authorSolution.StartInfo.UseShellExecute = false;
                authorSolution.StartInfo.RedirectStandardInput = true;
                authorSolution.StartInfo.RedirectStandardOutput = true;

                authorSolution.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution.StartInfo.CreateNoWindow = true;
                authorSolution.Start();


                System.IO.StreamWriter authorSolutionWR = authorSolution.StandardInput;
                System.IO.StreamReader authorSolutionRR = authorSolution.StandardOutput;




                solutionWR.Write("10 20 30" + "\n");
                authorSolutionWR.Write("10 20 30" + "\n");

                string solutionRR2 = solutionRR.ReadToEnd();

                string authorSolutionRR2 = authorSolutionRR.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #1");
                if (solutionRR2 == authorSolutionRR2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 50;
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
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR2);



                }

                Console.WriteLine();

                solution.WaitForExit();
                solution.Close();
                authorSolution.WaitForExit();
                authorSolution.Close();

                Process solution2 = new Process();

                solution2.StartInfo.UseShellExecute = false;
                solution2.StartInfo.RedirectStandardInput = true;
                solution2.StartInfo.RedirectStandardOutput = true;

                solution2.StartInfo.FileName = "Solution.exe";
                solution2.StartInfo.CreateNoWindow = true;
                solution2.Start();


                System.IO.StreamWriter solutionWR2 = solution2.StandardInput;
                System.IO.StreamReader solutionRR22 = solution2.StandardOutput;


                Process authorSolution2 = new Process();

                authorSolution2.StartInfo.UseShellExecute = false;
                authorSolution2.StartInfo.RedirectStandardInput = true;
                authorSolution2.StartInfo.RedirectStandardOutput = true;

                authorSolution2.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution2.StartInfo.CreateNoWindow = true;
                authorSolution2.Start();


                System.IO.StreamWriter authorSolutionWR2 = authorSolution2.StandardInput;
                System.IO.StreamReader authorSolutionRR22 = authorSolution2.StandardOutput;




                solutionWR2.Write("-1 20 99 5" + "\n");
                authorSolutionWR2.Write("-1 20 99 5" + "\n");

                string solutionRR222 = solutionRR22.ReadToEnd();

                string authorSolutionRR222 = authorSolutionRR22.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #2");
                if (solutionRR222 == authorSolutionRR222)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 50;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR222);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR222);



                }

                Console.WriteLine();

                solution2.WaitForExit();
                solution2.Close();
                authorSolution2.WaitForExit();
                authorSolution2.Close();


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine();
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
                Console.Write("'Reverse an Array of Integers' ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("folder !");
                Console.WriteLine();
                Console.Write(" 2.Rename your file to ");
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
