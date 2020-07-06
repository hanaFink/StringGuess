using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<char[]> exprestion = new List <char[]>() ;

                string prime =  "java,jjava,vaj,aavj,j,vjaa,dan,and,ddan";
                string[] parts = prime.Split(',');

                for(int i= 0; i < parts.Length;i++)
                {
                exprestion.Add(parts[i].ToCharArray());
                }
                char x = ',';
                int count =0;
                foreach (char [] c in exprestion)
                {
                for(int i=0;i <prime.Length ;i++)
                {

                

/*
                List<Dictionary<string, int>> list = new List<Dictionary<string, int>>();
                string prime = "java,jjava,vaj,aavj,j,vjaa,dan,and,ddan";
                string[] parts = prime.Split(',');// create words
                for (int i = 0; i < parts.Length; i++)
                {
                    Dictionary<string, int> dic = new Dictionary<string, int>();

                    for (int j = 0; j < parts[i].Length; j++)
                    {


                        if (dic.ContainsKey(parts[i]))
                        {
                            dic[parts[i[1]]]++;
                        }
                        else
                        {
                            dic.Add(parts[i], 1);
                            Console.Write(parts[i] + "-");
                        }

                    }
                    Console.WriteLine();
                    /*list.Add(dic);*/

                    
                }




            }
        }

    }
    }
}
