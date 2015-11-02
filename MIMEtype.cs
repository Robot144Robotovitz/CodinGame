using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        Dictionary<string, string> EXTandMT = new Dictionary<string, string>(N);
        string[] answer = new string[Q];
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            EXTandMT.Add(EXT.ToLower(), MT );// add both in dictionary, extension as key, MIME type as value
        }
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            string EXTname = FNAME.Substring(FNAME.LastIndexOf(".")+1);// extension of the file.
            
            if(EXTname.Length <2 || FNAME.LastIndexOf(".")==-1 ) answer[i] = "UNKNOWN";//if extension name is too short()<2 or if there is no dot(".") in file name, write unknown
            else
                { 
                    EXTname = EXTname.ToLower();
                   
                    if (EXTandMT.ContainsKey(EXTname) )//search for extension in dictionary
                        {
                            
                            answer[i]=EXTandMT[EXTname];//if found - add it to answer
                        }
                    else
                        {
                            
                            answer[i] = "UNKNOWN";//if not - add "UNKNOWN" to answer
                        }
                }        
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        foreach(string str in answer)
        Console.WriteLine(str); // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
    }
}
