using BisectionMaster3k.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace BisectionMaster3k
{





    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    /**
     * Klasa Parser - Cele:
     * #Parsuje tekst
     */
    static class Parser
    {
        






       static public void LeParse(string text,string a)
        {

            for (int i = 0; i < text.Length; i++)// czyta cały tekst literka po literce
            {
                if (text[i] == '^')  // jeżeli jest potęga (poniżej wyjaśnie dlaczego)
                {
                    int pwn = i;
                    //for

                    int power = text[i+1]-'0';
                       
                    //text = text.Remove(i, 1); proszę komentować linie jak coś nie działa i comitujesz zeby inni mogli tez pracowac
                    text = text.Remove(i, 1);

                    for (int g = 1; g < power; g++)
                    {
                        text = text.Insert(i,"*x");
                    }



                }
            }
            for (int i = 0; i < text.Length; i++)// Znowu czyta cały tekst literka po literce
            {
                if (text[i] == 'x') //jeżeli jest x to wymien na string "a" podany wczesniej w fukcji LeParse
                {

                    text = text.Remove(i, 1);
                    text = text.Insert(i, a);



                }

            }


            DataTable dt = new DataTable();
            var test = dt.Compute(text, ""); //Compute Nie może potęgować wieć zamieniłem cały process 



            

            MessageBox.Show(test.ToString());



        }

        static public void LeParse2(string text)
        {
           
               
                    string[] subs = text.Split("x", '\t');
            foreach (var sub in subs)
            {
                MessageBox.Show($"Substring: {sub}");
                
                //Coefficients.add({sub });
            }
            
                 
                  
                   
              




        }



    }
}
