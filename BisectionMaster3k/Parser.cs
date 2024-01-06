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
   * PS:Jak narazie nie zalecam robić skomplikowanych obliczeń na potęgach jak x^(2+2), kod zrobi kaboom
   * PSS: Nie ma nawiasów w walidatorze, Tak ma być?
   * Kacper: Jakich nawiasów w walidatorze? Chodzi o klasę Validator.cs?
   * PSSS: A za tamto nie działanie projektu to przepraszam, pętla for umknęła się gdy robiłem porządki
   * Kacper: #1 czy parser oblicza f(x) ?
   * Kacper: umawialiśmy się, że parser nie oblicza f(x)
   * Kacper: #2 parser powinien wkładać (.Add) współczynniki (obiekty typu double)
   * Kacper: do Polynomial.Instance.Coefficients
   * Kacper: #3 parser powinien wkładać (.Add) potęgi (obiekty typu double)
   * Kacper: do Polynomial.Instance.Powers
   * Kacper: #4 Klasa Polynomial z pliku Polynomial.cs oblicza f(x)
   * Kacper: tam jest definicja " public double f(double x, int expr = 0) "
   * Kacper: #5 proponuję przypisywać nagłówki do metod MessageBox.Show()
   * Kacper: szkoda czasu na domysły
   */
  static class Parser
    {




     
        

        public static double ParsePolynomialToDouble(string polynomial)
        {
            double result = 0.0;

            if (polynomial.Contains("x^-")) 
            {
                Exceptions.vActPowersNegative();
                return 0;
            }
           if (polynomial.StartsWith("+")) //Taki kod mam że jak dam plusa na początku to cały process idzie kaboom
            {
                polynomial = polynomial.Remove(0,1);
            }

           

            string[] Seperated_Things = polynomial.Split('+', '-'); // Wielkie dzielenie do obliczeń

            foreach (string Looped in Seperated_Things) 
            {
                string StringToParse = Looped.Trim(); // Trim do usuwania spacji gdyby użytkownik by dał

               
                    double coefficient = 1.0;
                    double power;                      
                //Wielka magia sortowania co jak i gdzie

                    if (StringToParse.StartsWith("x^"))
                    {
                        string[] parts = StringToParse.Split("x^", StringSplitOptions.None);
                        
                        power = double.Parse(parts[1]); 
                    Polynomial.Instance.Powers.Add(power);
                }

                    else if (StringToParse.StartsWith("x"))
                    {
                        coefficient = 1.0; 
                    Polynomial.Instance.Coefficients.Add(coefficient);
                    power = GetPower(StringToParse.Substring(1));  
                    Polynomial.Instance.Powers.Add(power);
                }
                    else if (StringToParse.StartsWith("-x"))
                    {
                        coefficient = -1.0; 
                    Polynomial.Instance.Coefficients.Add(coefficient);
                    power = GetPower(StringToParse.Substring(2));  
                    Polynomial.Instance.Powers.Add(power);
                }
                
                else if (StringToParse.Contains("x^"))
                    {
                        string[] parts = StringToParse.Split(new string[] { "x^" }, StringSplitOptions.None);
                        coefficient = double.Parse(parts[0]);
                    Polynomial.Instance.Coefficients.Add(coefficient);
                    power = double.Parse(parts[1]);        
                    Polynomial.Instance.Powers.Add(power);
                }
                    else if (StringToParse.EndsWith("x"))
                    {
                        string[] parts = StringToParse.Split('x');
                        coefficient = double.Parse(parts[0]); 
                    Polynomial.Instance.Coefficients.Add(coefficient);
                    power = 1.0;  
                    Polynomial.Instance.Powers.Add(power);
                }
                   

             
                    
                
            }
            return result;
           
        }
        private static double GetPower(string powerValue) // jak potęga 0 lub jeden== jeden jak nie to parsuje do Double
        {
           // if(int.Parse(powerValue.Trim()) < 0)
            //{
              //Exceptions.vActPowersNegative();
            //}

            
            if (string.IsNullOrWhiteSpace(powerValue))
            {
                return 1.0;
            }
            else
            {
                return double.Parse(powerValue.Trim());
            }
        }





    }
}
