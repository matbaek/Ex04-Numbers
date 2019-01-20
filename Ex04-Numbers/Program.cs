using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuType = "0";

            int areaHeight;
            int areaWidth;
            int area;

            int checkForEmptynessInts = 1;
            int[] ints = new int[10];
            int arrayPlaceInts = 0;

            int checkForEmptynessKoord = 1;
            string[] koord = new string[10];
            int arrayPlaceKoord = 0;
            int[] koordX = new int[10];
            int[] koordY = new int[10];

            while(true)
            {
                if(menuType == "0")
                {
                    Console.Clear();
                    Console.WriteLine("***************");
                    Console.WriteLine("** BEREGNING **");
                    Console.WriteLine("***************");
                    Console.WriteLine("");
                    Console.WriteLine("Vælg en af følgende beregninger:");
                    Console.WriteLine("");
                    Console.WriteLine("   1. Beregning af rektangels areal");
                    Console.WriteLine("   2. Beregninger for talserie");
                    Console.WriteLine("   3. Beregninger for en polyline");
                    Console.WriteLine("");
                    Console.Write("Skriv menu tal: ");


                    menuType = Console.ReadLine();
                    Console.Clear();
                }
                else if (menuType == "1")
                {
                    Console.Write("Indtast højde: ");
                    string areaHeightInput = Console.ReadLine();
                    if (int.TryParse(areaHeightInput, out areaHeight))
                    { }
                    else
                    {
                        Console.WriteLine("Input er ikke et tal! Prøv forfra");
                        return;
                    }

                    Console.Write("Indtast bredde: ");
                    string areaWidthInput = Console.ReadLine();
                    if (int.TryParse(areaWidthInput, out areaWidth))
                    { }
                    else
                    {
                        Console.WriteLine("Input er ikke et tal! Prøv forfra");
                        return;
                    }

                    area = Numbers.RectangleArea(areaHeight, areaWidth);

                    Console.WriteLine("Arealet er: " + area);

                    Console.ReadLine();
                    menuType = "0";
                }
                else if (menuType == "2")
                {
                    Console.WriteLine("== Indlæs talserie og beregn sum, min, max");
                    Console.WriteLine("Indtast talserie (Max 10 tal, afslut med tom linje");

                    while (checkForEmptynessInts == 1)
                    {
                        if (arrayPlaceInts <= 9)
                        {
                            string numberInput = Console.ReadLine();
                            if (numberInput == "")
                            {
                                checkForEmptynessInts = 0;
                                int rowsToRemove = 10 - arrayPlaceInts;
                                ints = ints.Take(ints.Count() - rowsToRemove).ToArray();
                            }
                            else if (int.TryParse(numberInput, out int arrayNumber))
                            {
                                ints[arrayPlaceInts] = arrayNumber;
                                arrayPlaceInts++;
                            }
                            else
                            {
                                Console.WriteLine("Input er ikke et tal! Prøv forfra");
                                return;
                            }
                        }
                        else
                        {
                            checkForEmptynessInts = 0;
                        }
                    }

                    Console.Write("Talserie indtastet: ");
                    for (int i = 0; i < arrayPlaceInts; i++)
                    {
                        Console.Write("(" + ints[i] + ") ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sum af talserie: " + Numbers.Sum(ints));
                    Console.WriteLine("Minimum af talserie: " + Numbers.Min(ints));
                    Console.WriteLine("Maximum af talserie: " + Numbers.Max(ints));

                    Console.ReadLine();
                    menuType = "0";
                }
                else if (menuType == "3")
                {
                    Console.WriteLine("== Indlæs og udskriv polyline");
                    Console.WriteLine("Indtast koordinat (Max. 10 x,y-koordinater");

                    while (checkForEmptynessKoord == 1)
                    {
                        if (arrayPlaceKoord <= 9)
                        {
                            string stringInput = Console.ReadLine();
                            if (stringInput == "")
                            {
                                checkForEmptynessKoord = 0;
                                Array.Resize(ref koord, arrayPlaceKoord);
                            }
                            else if (stringInput != "")
                            {
                                koord[arrayPlaceKoord] = stringInput;
                                arrayPlaceKoord++;
                            }
                        }
                        else
                        {
                            checkForEmptynessKoord = 0;
                        }
                    }

                    Console.Write("Polyline har " + arrayPlaceKoord + " punkter med koodinaterne: ");
                    for (int i = 0; i < arrayPlaceKoord; i++)
                    {
                        Console.Write("(" + koord[i] + ") ");
                    }
                    Console.WriteLine();

                    Console.Write("Polyline har længden: ");
                    for (int i = 0; i < koord.Length; i++)
                    {
                        string tempString = koord[i];
                        string[] temp = tempString.Split(',');
                        koordX[i] = int.Parse(temp[0]);
                        Array.Resize(ref koordX, koord.Length);

                        koordY[i] = int.Parse(temp[1]);
                        Array.Resize(ref koordY, koord.Length);
                    }
                    Console.Write(Numbers.PolylineLength(koordX, koordY));
                    Console.WriteLine();

                    Console.ReadLine();
                    menuType = "0";
                }
                else
                {
                    Console.WriteLine("Farvel");
                    return;
                }
            }
        }
    }
}
