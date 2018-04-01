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

                solution.StartInfo.FileName ="Solution.exe";
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



               
                solutionWR.Write("20"+ "\n");
                authorSolutionWR.Write("20" + "\n");

                string solutionRR2 = solutionRR.ReadToEnd();
      
                string authorSolutionRR2 = authorSolutionRR.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #1");
                if (solutionRR2 == authorSolutionRR2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
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
                    Console.WriteLine();
     
                  
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

                solution2.StartInfo.FileName ="Solution.exe";
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




                solutionWR2.Write("175" + "\n");
                authorSolutionWR2.Write("175" + "\n");

                string solutionRR222 = solutionRR22.ReadToEnd();

                string authorSolutionRR222 = authorSolutionRR22.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #2");
                if (solutionRR222 == authorSolutionRR222)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
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
                    Console.WriteLine();

                }



                solution2.WaitForExit();
                solution2.Close();
                authorSolution2.WaitForExit();
                authorSolution2.Close();

                Console.WriteLine();

                Process solution3 = new Process();

                solution3.StartInfo.UseShellExecute = false;
                solution3.StartInfo.RedirectStandardInput = true;
                solution3.StartInfo.RedirectStandardOutput = true;

                solution3.StartInfo.FileName ="Solution.exe";
                solution3.StartInfo.CreateNoWindow = true;
                solution3.Start();


                System.IO.StreamWriter solutionWR3 = solution3.StandardInput;
                System.IO.StreamReader solutionRR33 = solution3.StandardOutput;


                Process authorSolution3 = new Process();

                authorSolution3.StartInfo.UseShellExecute = false;
                authorSolution3.StartInfo.RedirectStandardInput = true;
                authorSolution3.StartInfo.RedirectStandardOutput = true;

                authorSolution3.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution3.StartInfo.CreateNoWindow = true;
                authorSolution3.Start();


                System.IO.StreamWriter authorSolutionWR3 = authorSolution3.StandardInput;
                System.IO.StreamReader authorSolutionRR33 = authorSolution3.StandardOutput;




                solutionWR3.Write("2703" + "\n");
                authorSolutionWR3.Write("2703" + "\n");

                string solutionRR333 = solutionRR33.ReadToEnd();

                string authorSolutionRR333 = authorSolutionRR33.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #3");
                if (solutionRR333 == authorSolutionRR333)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR333);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR333);
                    Console.WriteLine();

                }



                solution3.WaitForExit();
                solution3.Close();
                authorSolution3.WaitForExit();
                authorSolution3.Close();

                Console.WriteLine();

                Process solution4 = new Process();

                solution4.StartInfo.UseShellExecute = false;
                solution4.StartInfo.RedirectStandardInput = true;
                solution4.StartInfo.RedirectStandardOutput = true;

                solution4.StartInfo.FileName ="Solution.exe";
                solution4.StartInfo.CreateNoWindow = true;
                solution4.Start();


                System.IO.StreamWriter solutionWR4 = solution4.StandardInput;
                System.IO.StreamReader solutionRR44 = solution4.StandardOutput;


                Process authorSolution4 = new Process();

                authorSolution4.StartInfo.UseShellExecute = false;
                authorSolution4.StartInfo.RedirectStandardInput = true;
                authorSolution4.StartInfo.RedirectStandardOutput = true;

                authorSolution4.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution4.StartInfo.CreateNoWindow = true;
                authorSolution4.Start();


                System.IO.StreamWriter authorSolutionWR4 = authorSolution4.StandardInput;
                System.IO.StreamReader authorSolutionRR44 = authorSolution4.StandardOutput;




                solutionWR4.Write("35" + "\n");
                authorSolutionWR4.Write("35" + "\n");

                string solutionRR444 = solutionRR44.ReadToEnd();

                string authorSolutionRR444 = authorSolutionRR44.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #4");
                if (solutionRR444 == authorSolutionRR444)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR444);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR444);
                    Console.WriteLine();

                }



                solution4.WaitForExit();
                solution4.Close();
                authorSolution4.WaitForExit();
                authorSolution4.Close();

                Console.WriteLine();

                Process solution5 = new Process();

                solution5.StartInfo.UseShellExecute = false;
                solution5.StartInfo.RedirectStandardInput = true;
                solution5.StartInfo.RedirectStandardOutput = true;

                solution5.StartInfo.FileName ="Solution.exe";
                solution5.StartInfo.CreateNoWindow = true;
                solution5.Start();


                System.IO.StreamWriter solutionWR5 = solution5.StandardInput;
                System.IO.StreamReader solutionRR55 =  solution5.StandardOutput;


                Process authorSolution5 = new Process();

                authorSolution5.StartInfo.UseShellExecute = false;
                authorSolution5.StartInfo.RedirectStandardInput = true;
                authorSolution5.StartInfo.RedirectStandardOutput = true;

                authorSolution5.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution5.StartInfo.CreateNoWindow = true;
                authorSolution5.Start();


                System.IO.StreamWriter authorSolutionWR5 = authorSolution5.StandardInput;
                System.IO.StreamReader authorSolutionRR55 = authorSolution5.StandardOutput;




                solutionWR5.Write("17" + "\n");
                authorSolutionWR5.Write("17" + "\n");

                string solutionRR555 = solutionRR55.ReadToEnd();

                string authorSolutionRR555 = authorSolutionRR55.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #5");
                if (solutionRR555 == authorSolutionRR555)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR555);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR555);
                    Console.WriteLine();

                }



                solution5.WaitForExit();
                solution5.Close();
                authorSolution5.WaitForExit();
                authorSolution5.Close();

                Console.WriteLine();

                Process solution6 = new Process();

                solution6.StartInfo.UseShellExecute = false;
                solution6.StartInfo.RedirectStandardInput = true;
                solution6.StartInfo.RedirectStandardOutput = true;

                solution6.StartInfo.FileName ="Solution.exe";
                solution6.StartInfo.CreateNoWindow = true;
                solution6.Start();


                System.IO.StreamWriter solutionWR6 = solution6.StandardInput;
                System.IO.StreamReader solutionRR66 = solution6.StandardOutput;


                Process authorSolution6 = new Process();

                authorSolution6.StartInfo.UseShellExecute = false;
                authorSolution6.StartInfo.RedirectStandardInput = true;
                authorSolution6.StartInfo.RedirectStandardOutput = true;

                authorSolution6.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution6.StartInfo.CreateNoWindow = true;
                authorSolution6.Start();


                System.IO.StreamWriter authorSolutionWR6 = authorSolution6.StandardInput;
                System.IO.StreamReader authorSolutionRR66 = authorSolution6.StandardOutput;




                solutionWR6.Write("0" + "\n");
                authorSolutionWR6.Write("0" + "\n");

                string solutionRR666 = solutionRR66.ReadToEnd();

                string authorSolutionRR666 = authorSolutionRR66.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #6");
                if (solutionRR666 == authorSolutionRR666)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR666);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR666);
                    Console.WriteLine();

                }



                solution6.WaitForExit();
                solution6.Close();
                authorSolution6.WaitForExit();
                authorSolution6.Close();

                Console.WriteLine();

                Process solution7 = new Process();

                solution7.StartInfo.UseShellExecute = false;
                solution7.StartInfo.RedirectStandardInput = true;
                solution7.StartInfo.RedirectStandardOutput = true;

                solution7.StartInfo.FileName ="Solution.exe";
                solution7.StartInfo.CreateNoWindow = true;
                solution7.Start();


                System.IO.StreamWriter solutionWR7 = solution7.StandardInput;
                System.IO.StreamReader solutionRR77 = solution7.StandardOutput;


                Process authorSolution7 = new Process();

                authorSolution7.StartInfo.UseShellExecute = false;
                authorSolution7.StartInfo.RedirectStandardInput = true;
                authorSolution7.StartInfo.RedirectStandardOutput = true;

                authorSolution7.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution7.StartInfo.CreateNoWindow = true;
                authorSolution7.Start();


                System.IO.StreamWriter authorSolutionWR7 = authorSolution7.StandardInput;
                System.IO.StreamReader authorSolutionRR77 = authorSolution7.StandardOutput;




                solutionWR7.Write("140" + "\n");
                authorSolutionWR7.Write("140" + "\n");

                string solutionRR777 = solutionRR77.ReadToEnd();

                string authorSolutionRR777 = authorSolutionRR77.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #7");
                if (solutionRR777 == authorSolutionRR777)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR777);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR777);
                    Console.WriteLine();

                    Console.WriteLine();
                }



                solution7.WaitForExit();
                solution7.Close();
                authorSolution7.WaitForExit();
                authorSolution7.Close();

                Console.WriteLine();

                Process solution8 = new Process();

                solution8.StartInfo.UseShellExecute = false;
                solution8.StartInfo.RedirectStandardInput = true;
                solution8.StartInfo.RedirectStandardOutput = true;

                solution8.StartInfo.FileName ="Solution.exe";
                solution8.StartInfo.CreateNoWindow = true;
                solution8.Start();


                System.IO.StreamWriter solutionWR8 = solution8.StandardInput;
                System.IO.StreamReader solutionRR88 = solution8.StandardOutput;


                Process authorSolution8 = new Process();

                authorSolution8.StartInfo.UseShellExecute = false;
                authorSolution8.StartInfo.RedirectStandardInput = true;
                authorSolution8.StartInfo.RedirectStandardOutput = true;

                authorSolution8.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution8.StartInfo.CreateNoWindow = true;
                authorSolution8.Start();


                System.IO.StreamWriter authorSolutionWR8 = authorSolution8.StandardInput;
                System.IO.StreamReader authorSolutionRR88 = authorSolution8.StandardOutput;




                solutionWR8.Write("211" + "\n");
                authorSolutionWR8.Write("211" + "\n");

                string solutionRR888 = solutionRR88.ReadToEnd();

                string authorSolutionRR888 = authorSolutionRR88.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #8");
                if (solutionRR888 == authorSolutionRR888)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR888);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR888);
                    Console.WriteLine();

                    Console.WriteLine();
                }



                solution8.WaitForExit();
                solution8.Close();
                authorSolution8.WaitForExit();
                authorSolution8.Close();

                Console.WriteLine();

                Process solution9 = new Process();

                solution9.StartInfo.UseShellExecute = false;
                solution9.StartInfo.RedirectStandardInput = true;
                solution9.StartInfo.RedirectStandardOutput = true;

                solution9.StartInfo.FileName ="Solution.exe";
                solution9.StartInfo.CreateNoWindow = true;
                solution9.Start();


                System.IO.StreamWriter solutionWR9 = solution9.StandardInput;
                System.IO.StreamReader solutionRR99 = solution9.StandardOutput;


                Process authorSolution9 = new Process();

                authorSolution9.StartInfo.UseShellExecute = false;
                authorSolution9.StartInfo.RedirectStandardInput = true;
                authorSolution9.StartInfo.RedirectStandardOutput = true;

                authorSolution9.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution9.StartInfo.CreateNoWindow = true;
                authorSolution9.Start();


                System.IO.StreamWriter authorSolutionWR9 = authorSolution9.StandardInput;
                System.IO.StreamReader authorSolutionRR99 = authorSolution9.StandardOutput;




                solutionWR9.Write("1500" + "\n");
                authorSolutionWR9.Write("1500" + "\n");

                string solutionRR999 = solutionRR99.ReadToEnd();

                string authorSolutionRR999 = authorSolutionRR99.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #9");
                if (solutionRR999 == authorSolutionRR999)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR999);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR999);
                    Console.WriteLine();

                    Console.WriteLine();
                }



                solution9.WaitForExit();
                solution9.Close();
                authorSolution9.WaitForExit();
                authorSolution9.Close();

                Console.WriteLine();

                Process solution10 = new Process();

                solution10.StartInfo.UseShellExecute = false;
                solution10.StartInfo.RedirectStandardInput = true;
                solution10.StartInfo.RedirectStandardOutput = true;

                solution10.StartInfo.FileName ="Solution.exe";
                solution10.StartInfo.CreateNoWindow = true;
                solution10.Start();


                System.IO.StreamWriter solutionWR10 = solution10.StandardInput;
                System.IO.StreamReader solutionRR10 = solution10.StandardOutput;


                Process authorSolution10 = new Process();

                authorSolution10.StartInfo.UseShellExecute = false;
                authorSolution10.StartInfo.RedirectStandardInput = true;
                authorSolution10.StartInfo.RedirectStandardOutput = true;

                authorSolution10.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution10.StartInfo.CreateNoWindow = true;
                authorSolution10.Start();


                System.IO.StreamWriter authorSolutionWR10 = authorSolution10.StandardInput;
                System.IO.StreamReader authorSolutionRR10 = authorSolution10.StandardOutput;




                solutionWR10.Write("2703" + "\n");
                authorSolutionWR10.Write("2703" + "\n");

                string solutionRR100 = solutionRR10.ReadToEnd();

                string authorSolutionRR100 = authorSolutionRR10.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #10");
                if (solutionRR100 == authorSolutionRR100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR100);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR100);
                    Console.WriteLine();

                    Console.WriteLine();
                }



                solution10.WaitForExit();
                solution10.Close();
                authorSolution10.WaitForExit();
                authorSolution10.Close();

                Console.WriteLine();

                Process solution11 = new Process();

                solution11.StartInfo.UseShellExecute = false;
                solution11.StartInfo.RedirectStandardInput = true;
                solution11.StartInfo.RedirectStandardOutput = true;

                solution11.StartInfo.FileName ="Solution.exe";
                solution11.StartInfo.CreateNoWindow = true;
                solution11.Start();


                System.IO.StreamWriter solutionWR11 = solution11.StandardInput;
                System.IO.StreamReader solutionRR11 = solution11.StandardOutput;


                Process authorSolution11 = new Process();

                authorSolution11.StartInfo.UseShellExecute = false;
                authorSolution11.StartInfo.RedirectStandardInput = true;
                authorSolution11.StartInfo.RedirectStandardOutput = true;

                authorSolution11.StartInfo.FileName = "AuthorSolution.exe";
                authorSolution11.StartInfo.CreateNoWindow = true;
                authorSolution11.Start();


                System.IO.StreamWriter authorSolutionWR11 = authorSolution11.StandardInput;
                System.IO.StreamReader authorSolutionRR11 = authorSolution11.StandardOutput;




                solutionWR11.Write("5555" + "\n");
                authorSolutionWR11.Write("5555" + "\n");

                string solutionRR110 = solutionRR11.ReadToEnd();

                string authorSolutionRR110 = authorSolutionRR11.ReadToEnd();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Test #11");
                if (solutionRR100 == authorSolutionRR100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Correct answer!");
                    score += 9.09;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Incorrect answer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EXPECTED OUTPUT");
                    Console.WriteLine(authorSolutionRR110);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOUR OUTPUT");
                    Console.Write(solutionRR110);
                    Console.WriteLine();

                    Console.WriteLine();
                }



                solution11.WaitForExit();
                solution11.Close();
                authorSolution11.WaitForExit();
                authorSolution11.Close();



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
                Console.Write("'Bonus Score' ");
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
