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
        string MESSAGE = Console.ReadLine();
        string res = string.Empty;// buffer string for converting "MESSAGE" in binary code
        string answer = string.Empty;//string for actual answer( "res" encoded in Chuck Norris code)
        byte[] bytes = Encoding.ASCII.GetBytes(MESSAGE);// get bytes of each letter in "MESSAGE" (e.g. C -> 67)
       
        foreach(byte b in bytes) // converting bytes to their binary expression(e.g. 67 -> 1000011)
            {
                if( Convert.ToString(b,2).Length!=7) res = res + "0"+Convert.ToString(b, 2);// if "b" has less then 7 symbols, add one "0" before it
                else res = res + Convert.ToString(b, 2);
                 
            }
       
       // Console.WriteLine(res);
        
        for(int i = 0; i <res.Length; )// "for" used just to initialize "i". We can put "i <res.Length" to first "if", like in second "if"
            { 
              
               if( res[i]=='1')
                {
                    answer +=  "0 ";// adding 1's code
                    while(res[i]=='1')
                        {
                            answer+="0";
                            i++;
                            if(i >= res.Length) break;
                             
                             
                        }
                    answer+=" ";    
                }
                if(i <res.Length && res[i]=='0')
                {
                    answer +=  "00 ";
                    while(res[i]=='0')
                        {
                            answer+="0";
                            i++;
                            if(i >= res.Length) break;
                           
                        }
                    answer+=" ";   
                }
            }
            answer = answer.Substring(0, answer.Length - 1);//string "answer" ends with " ", wich is wrong. So, we delete this last " " here
        Console.WriteLine(answer);
    }
}