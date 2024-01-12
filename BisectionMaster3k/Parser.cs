using BisectionMaster3k.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
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
            // Kacper: Muszę dodać, żeby działało
            Polynomial.Instance.Coefficients.Clear();
            Polynomial.Instance.Powers.Clear();

            double result = 0.0;




            if (polynomial.Contains("x^-"))
            {
                Exceptions.vActPowersNegative();
                return 0;
            }
            if (polynomial.StartsWith("+")) //Taki kod mam że jak dam plusa na początku to cały process idzie kaboom
            {
                polynomial = polynomial.Remove(0, 1);
            }


            List<string> hyphenStrings = new List<string>();
            int One_Poly = 0;
            int test = 0;
            int index;
            if (polynomial.StartsWith('-') && test == 0)
            {
                string polytest = polynomial.Substring(0);
                polynomial = polynomial.Remove(0, 1);
                int ii = polytest.IndexOf('+', 1);
                int ss = polytest.IndexOf('-', 1);
                test = 1;

                if (ii - ss < 0 && ss > 0)
                {
                    string g = polytest.Substring(0, ii);
                    hyphenStrings.Add(g);
                    polynomial = polynomial.Remove(0, ii);
                }
                else if (ss - ii < 0 && ii > 0)
                {
                    string g = polytest.Substring(0, ss);
                    hyphenStrings.Add(g);
                    polynomial = polynomial.Remove(0, ss);
                }
                else
                {
                    hyphenStrings.Add(polynomial);
                    One_Poly++;

                }

            }

            if (One_Poly == 0)
            {
                for (int i = 0; i < polynomial.Length; i++)
                {

                    char s = polynomial[i];



                    if (s == '+')
                    {
                        index = i;
                        string g = polynomial.Substring(0, index);
                        polynomial = polynomial.Remove(0, index);
                   

                        hyphenStrings.Add(g);
                        i = 0;
                    }

                    else if (s == '-')
                    {


                        index = i;
                        string g = polynomial.Substring(0, index);
                        polynomial = polynomial.Remove(0, index);
                      

                        hyphenStrings.Add(g);
                        i = 0;
                    }
                }

            }
            if (polynomial.StartsWith("+")) { polynomial = polynomial.Remove(0, 1); hyphenStrings.Add(polynomial); } else { hyphenStrings.Add(polynomial); }





            foreach (string Looped in hyphenStrings)
            {
                string StringToParse = Looped.Trim(); // Trim do usuwania spacji gdyby użytkownik by dał


                double coefficient = 1.0;
                double power;
                //Wielka magia sortowania co jak i gdzie
                if (!StringToParse.Contains("x"))
                {
                    Exceptions.vActCollectionsCountf();
                    return 0;
                }

                if (StringToParse.EndsWith("x"))
                {
                    Exceptions.vActCollectionsCountf();
                    return 0;
                }
                else if (StringToParse.Contains("-x^"))
                {
                    Exceptions.vActCollectionsCountf();
                    return 0;
                }
                else if (StringToParse.Contains("-x^"))
                {
                    Exceptions.vActCollectionsCountf();
                    return 0;
                }


                else if (StringToParse.Contains("x^"))
                {
                    string[] parts = StringToParse.Split(new string[] { "x^" }, StringSplitOptions.None);

                    if (parts[0].Contains('/'))
                    {
                        int i = parts[0].IndexOf('/');
                        string one = parts[0].Substring(0, i);
                        string two = parts[0].Substring(i + 1);
                        double d_one = double.Parse(one);
                        double d_two = double.Parse(two);
                        double resoult = d_one / d_two;

                        parts[0] = parts[0].Remove(0);
                        parts[0] = parts[0].Insert(0, resoult.ToString());
                    }
                    coefficient = double.Parse(parts[0]);
                    Polynomial.Instance.Coefficients.Add(coefficient);
                    if (parts[1].Contains('/'))
                    {
                        int i = parts[1].IndexOf('/');
                        string one = parts[1].Substring(0, i);
                        string two = parts[1].Substring(i + 1);
                        double d_one = double.Parse(one);
                        double d_two = double.Parse(two);
                        double resoult = d_one / d_two;

                        parts[1] = parts[1].Remove(0);
                        parts[1] = parts[1].Insert(0, resoult.ToString());
                    }
                    power = double.Parse(parts[1]);
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




    }
}
