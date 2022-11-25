using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace İzleme_Lİstesi
{
    class showlar
    {
        public string Path { get; set; }
        
         


       

        public string[] dizi = new string[1];
        public string[] showhazırla()
        {

            StreamReader streamread = new StreamReader("C:\\Users\\onur barbaros\\Desktop\\İzleme Lİstesi\\İzleme Lİstesi\\showliste.txt");
            int i = 0;
          
            while (!streamread.EndOfStream)
            {
                Array.Resize(ref dizi, i + 1);
                dizi[i]= streamread.ReadLine() ;
              
                i++;
               
            }
            streamread.Close();
            return dizi;
            

        }
       
        public void showekle(string a)
        {
            
            StreamWriter streamwrite = new StreamWriter("C:\\Users\\onur barbaros\\Desktop\\İzleme Lİstesi\\İzleme Lİstesi\\showliste.txt");
            foreach (var item in dizi)
            {
                streamwrite.WriteLine(item);
            }
            streamwrite.WriteLine(a);
           

            
           streamwrite.Close();
           showhazırla();
        }
       
        public int i = 0;
        public string satır2 = null;
        public string izlenmedurumu(string a)
        {
            StreamReader streamread = new StreamReader("C:\\Users\\onur barbaros\\Desktop\\İzleme Lİstesi\\İzleme Lİstesi\\showliste.txt");
           
            string satır = null;
            
           
            string[] öge;
            while (!streamread.EndOfStream)
            {
                satır = streamread.ReadLine();
               
                öge = satır.Split('_');
                if (öge[3]==a)
                {
                    if (öge[6] == "izlenmedi")
                    {
                        öge[6] = "izlendi";

                        satır = öge[0] + "_" + öge[1] + "_" + öge[2] +"_"+ öge[3]+"_" + öge[4]+"_" + öge[5] + "_" +öge[6];

                        
                       
                        

                    }
                    break;
                }
                else
                {
                    i++;
                }
               
            }

            streamread.Close();
           // showhazırla();
            showyaz(satır);
            return satır;

        }

        public void showyaz(string satır)
        {
            StreamWriter streamwrite = new StreamWriter("C:\\Users\\onur barbaros\\Desktop\\İzleme Lİstesi\\İzleme Lİstesi\\showliste.txt");
            for (int j = 0; j < dizi.Length; j++)
            {
                if (i == j)
                {
                    streamwrite.WriteLine(satır);
                }
                else
                {
                    streamwrite.WriteLine(dizi[j]);
                }
            }
            streamwrite.Close();
        }
    }

}

