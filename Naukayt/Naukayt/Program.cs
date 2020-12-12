using System;
using System.Collections.Generic;

namespace Nauka_yt
{
    class Program
    {
        // modyfikator_dostępu + static + zwracany_typ + Nazwa_funkcji(argunemty) 
        static void Main(string[] args)
        {
            //typy danych
            //char mark = 'a';
            //string word = "abc";
            //short numbers16bit = 10;
            //int numbers32bit = 10;
            //long numbers64bit = 10;
            //double numbersComma = 3.14;
            //bool logicalExpression = true; // or false

            //var anything = 1;
            //var anything2 = "abc";
            //var takes the data type we assign to the variable

            //-------------------------------------------

            //stałe

            //const double pi = 3.14;
            //const string sdf = "abs";

            //-------------------------------------------------

            //Program to say Hello with your name

            //Console.WriteLine("Write your name.");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //-------------------------------------------------

            //int text1;
            //double text2;
            //char sign;
            //Console.WriteLine("Write first number");
            //text1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Write second number");
            //text2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sum of numbers is : ");
            //Console.WriteLine(text1 + text2);
            // or
            //Console.WriteLine("Sum of numbers is : " + (text1 + text2));

            //---------------------------------------------------

            //bool parse1; 
            //bool parse2;
            //double text1;
            //double text2;
            //Console.WriteLine("Write first number");
            //parse1 = double.TryParse(Console.ReadLine(), out text1);
            //Console.WriteLine("Write second number");
            //parse2 = double.TryParse(Console.ReadLine(), out text2);


            //if (parse1 && parse2)
            //{
            //    Console.WriteLine("Sum of numbers is : " + (text1 + text2));
            //}
            //else
            //{
            //    Console.WriteLine("Write right sings");
            //}

            //------------------------------------------------

            // calculator

            //double number1;
            //double number2;
            //char sign;

            //Console.WriteLine("Hello write your name");
            //string user = Console.ReadLine();
            //Console.WriteLine("Hello " + user);
            //Console.WriteLine();
            //Console.WriteLine("Write first number");
            //number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write sign to operation");
            //sign = char.Parse(Console.ReadLine());
            //Console.WriteLine("Write secound number");
            //number2 = double.Parse(Console.ReadLine());

            //switch(sign)
            //{
            //    case '+':
            //        {
            //            Console.WriteLine("Result : " + (number1 + number2));
            //            break;
            //        }
            //    case '-':
            //        {
            //            Console.WriteLine("Result : " + (number1 - number2));
            //            break;
            //        }
            //    case '/':
            //        {
            //            Console.WriteLine("Result : " + (number1 / number2));
            //            break;
            //        }
            //    case '*':
            //        {
            //            Console.WriteLine("Result : " + (number1 * number2));
            //            break;
            //        }
            //}

            ////or

            //if (sign == '+')
            //{
            //    Console.WriteLine(number1 + number2);
            //}

            //if (sign == '-')
            //{
            //    Console.WriteLine(number1 - number2);
            //}

            //if (sign == '/')
            //{
            //    Console.WriteLine(number1 / number2);
            //}

            //if (sign == '*') ;
            //{
            //    Console.WriteLine(number1 * number2);
            //}

            //--------------------------------------------------

            // Azimuth Counting

            //double X1;
            //double X2;
            //double Y1;
            //double Y2;
            //double increaseX;
            //double increaseY;
            //double tangensQuater;
            //double quaterRads;
            //double quaterGrads;
            //double quaterDegrees;
            //double length;

            //Console.WriteLine("This is program to azimuth Counting");
            //Console.WriteLine();
            //Console.WriteLine("Write coordinate 'X' first point and etre");
            //X1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write coordinate 'Y' first point and etre");
            //Y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write coordinate 'X' secound point and etre");
            //X2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write coordinate 'Y' secound point and etre");
            //Y2 = double.Parse(Console.ReadLine());

            //increaseX = X2 - X1;
            //increaseY = Y2 - Y1;
            //tangensQuater = increaseY / increaseX;
            //quaterRads = Math.Abs(Math.Atan(tangensQuater));            
            //quaterGrads = quaterRads * 63.661977269;           
            //quaterDegrees = quaterRads * 57.29577951308;
            //length = Math.Sqrt(increaseX * increaseX + increaseY * increaseY);
            //length = Math.Round(length, 3);
            //quaterRads = Math.Round(quaterRads, 4);
            //quaterGrads = Math.Round(quaterGrads, 4);
            //quaterDegrees = Math.Round(quaterDegrees, 4);

            //if (increaseX == 0 && increaseY > 0)
            //{
            //    Console.WriteLine("Asimuth in grads : 100");
            //    Console.WriteLine("Asimuth in Rads : 1.570796326795");
            //    Console.WriteLine("Asimuth in Degrees : 90");
            //}

            //if (increaseX == 0 && increaseY < 0)
            //{
            //    Console.WriteLine("Asimuth in grads : 300");
            //    Console.WriteLine("Asimuth in Rads : 4.712388980385");
            //    Console.WriteLine("Asimuth in Degrees : 270");
            //}

            //if (increaseX > 0 && increaseY == 0)
            //{
            //    Console.WriteLine("Asimuth in grads : 0 ");
            //    Console.WriteLine("Asimuth in Rads : 0 ");
            //    Console.WriteLine("Asimuth in Degrees : 0 ");

            //}

            //if (increaseX < 0 && increaseY == 0)
            //{
            //    Console.WriteLine("Asimuth in grads : 200");
            //    Console.WriteLine("Asimuth in Rads : 3.14159265359 ");
            //    Console.WriteLine("Asimuth in Degrees : 180 ");
            //}

            //if (increaseX == 0 && increaseY == 0)
            //{
            //    Console.WriteLine("Asimuth in grads : 0");
            //    Console.WriteLine("Asimuth in Rads : 0 ");
            //    Console.WriteLine("Asimuth in Degrees : 0 ");
            //}

            ////---------------------------------------

            //if (increaseX > 0 && increaseY > 0)
            //{
            //    Console.WriteLine("Asimuth in grads : " + quaterGrads);
            //    Console.WriteLine("Asimuth in Rads : " + quaterRads);
            //    Console.WriteLine("Asimuth in Degrees : " + quaterDegrees);
            //}

            //if (increaseX < 0 && increaseY > 0)
            //{
            //    Console.WriteLine("Asimuth in grads : " + (200 - quaterGrads));
            //    Console.WriteLine("Asimuth in Rads : " + (3.14159265359 - quaterRads));
            //    Console.WriteLine("Asimuth in Degrees : " + (180 - quaterDegrees));
            //}

            //if (increaseX < 0 && increaseY < 0)
            //{
            //    Console.WriteLine("Asimuth in grads : " + (200 + quaterGrads));
            //    Console.WriteLine("Asimuth in Rads : " + (3.14159265359 + quaterRads));
            //    Console.WriteLine("Asimuth in Degrees : " + (180 + quaterDegrees));
            //}

            //if (increaseX > 0 && increaseY < 0)
            //{
            //    Console.WriteLine("Asimuth in grads : " + (400 - quaterGrads));
            //    Console.WriteLine("Asimuth in Rads : " + (6.28318530718 - quaterRads));
            //    Console.WriteLine("Asimuth in Degrees : " + (360 - quaterDegrees));
            //}

            //Console.WriteLine("Length is : " + length);

            //--------------------------------------------------------------

            //LOOPS

            //int a = 0; 

            //while (a<10)
            //{
            //    Console.WriteLine(a);
            //    a++; // or a += 1 ; or a = a + 1

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //int i = 0;

            //do
            //{

            //    Console.WriteLine(i);
            //    i++;

            //} while (i < 10);

            //int i = 0;

            //while (i <= 10)
            //{
            //    if ((i % 2) == 1)
            //    {
            //        i++;
            //        continue;
            //    }

            // Console.WriteLine(i);
            // i++;

            //int i = 0;

            //while (i <= 10)
            //{
            //    if (!( i>= 10))
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //    i++;

            //}

            //int i = 0;
            //int j = 0;

            //while ( i < 10)
            //{
            //    while ( j < 10)
            //    {
            //        Console.WriteLine("" + i + j );
            //        j++;
            //    }
            //    j = 0;
            //    i++;

            //}

            // TABLES

            //int[] gradesArray = new int[10] { 5, 2, 3, 1, 4, 5, 6, 1, 3, 5 };
            //double sum = 0;

            //Array.Sort(gradesArray);
            //for (int i = 0; i < gradesArray.Length; i++)
            //{
            //    Console.WriteLine("Mark " + gradesArray[i]);
            //    sum += gradesArray[i];
            //}

            //foreach (int elem in gradesArray)
            //{
            //    Console.WriteLine("Mark " + gradesArray[elem]);
            //    sum += elem;
            //}
            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Average = " + (sum / gradesArray.Length));

            //TABLES MULTIDIMENSIONAL

            // TWO-DIMENSIONAL

            //int[,] grades2 = new int[2, 3]
            //{
            //    {1, 2, 3 },
            //    {1, 2, 3 }
            //};

            //grades2[1, 2] = 5;

            //for ( int i = 0; i <2; i ++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(grades2[i, j] + ", ");
            //    }
            //    Console.WriteLine();
            //}

            // THREE-DIMENSIONAL

            //int[,,] grades3 = new int[2, 3, 3]
            //{
            //    {
            //        {1, 2, 3 },
            //        {1, 2, 3 },
            //        {1, 2, 3 }
            //    },
            //    {
            //        {1, 2, 3 },
            //        {1, 2, 3 },
            //        {1, 2, 3 }
            //    }
            //};

            // TABLES SHATTERED

            //int[][] grades = new int[][]
            //{
            //    new int[] {1, 2, 3 },
            //    new int[] {1, 2, },
            //    new int[] {1, 2, 4, 2 }
            //};
            //grades[2][1] = 5;

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        Console.Write(grades[i] [j] + ", ");
            //    }
            //    Console.WriteLine();
            //}

            //GOTO  

            //etykieta1:
            //    Console.WriteLine("one");
            //    goto etykieta3;
            //etykieta2:
            //    Console.WriteLine("two");

            //etykieta3:            
            //    Console.WriteLine("three");
            //    goto etykieta1;


            //-------------------------------------------------------------------------

            // EXERCISES

            //1 Napisz program, który z wykorzystaniem instrukcji if oblicza pierwiastki
            // równania kwadratowego ax2 + bx + c = 0, w którym zmienne a, b, c to liczby rzeczywiste
            //wprowadzane z klawiatury. Wszystkie zmienne wywietlamy na ekranie z dokadno -ci do dwóch miejsc po przecinku.

            //do
            //{
            //    double a;
            //    double b;
            //    double c;
            //    double delta;
            //    double x1;
            //    double x2;

            //    Console.WriteLine("This is a program to caunting roots of quadratic equation\n");

            //    Console.WriteLine("Write the number what will be coefficient 'a' ");
            //    a = double.Parse(Console.ReadLine());
            //    if (a == 0)
            //    {
            //        Console.WriteLine("Invalid value 'a'. Press entre and start again");
            //        string s = Console.ReadLine();
            //        Console.Clear();
            //        continue;
            //    }
            //    Console.WriteLine("Write the number what will be coefficient 'b' ");
            //    b = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Write the number what will be coefficient 'c' ");
            //    c = double.Parse(Console.ReadLine());

            //    delta = (b * b) - (4 * a * c);
            //    x1 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a),2);
            //    x2 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a),2);
            //    if (delta > 0)
            //    {
            //        Console.WriteLine("Results: " + x1 + "\t" + x2);
            //    }
            //    else if (delta == 0)
            //    {
            //        Console.WriteLine("Only one result: " + x1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("No solution");
            //    }

            //    Console.WriteLine("Would you like to count somthing more? [y/n]");
            //    string answer = Console.ReadLine();
            //    if (answer == "n")
            //    {
            //        break;
            //    }

            //} while(true);

            //2 Napisz program, który z wykorzystaniem instrukcji switch oblicza pierwiastki równania kwadratowego ax2
            // +bx + c = 0, w którym zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury. Wszystkie 
            // zmienne wywietlamy z dokadnoci do dwóch miejsc po przecinku.

            //do
            //{
            //    double a;
            //    double b;
            //    double c;
            //    double delta;
            //    double x1;
            //    double x2;
            //    double numberOfvalues = 0;

            //    Console.WriteLine("This is a program to caunting roots of quadratic equation\n");

            //    Console.WriteLine("Write the number what will be coefficient 'a' ");
            //    a = double.Parse(Console.ReadLine());
            //    if (a == 0)
            //    {
            //        Console.WriteLine("Invalid value 'a'. Press entre and start again");
            //        string s = Console.ReadLine();
            //        Console.Clear();
            //        continue;
            //    }
            //    Console.WriteLine("Write the number what will be coefficient 'b' ");
            //    b = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Write the number what will be coefficient 'c' ");
            //    c = double.Parse(Console.ReadLine());

            //    delta = (b * b) - (4 * a * c);
            //    x1 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
            //    x2 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);

            //    if (delta < 0) numberOfvalues = 0;
            //    if (delta == 0) numberOfvalues = 1;
            //    if (delta > 0) numberOfvalues = 2;

            //    switch (numberOfvalues)
            //    {
            //        case 0:
            //            {
            //                Console.WriteLine("No solution");
            //                break;
            //            }
            //        case 1:
            //            {
            //                Console.WriteLine("Only one result: " + x1);
            //                break;
            //            }

            //        case 2:
            //            {
            //                Console.WriteLine("Results: " + x1 + "\t" + x2);
            //                break;
            //            }
            //    }


            //    Console.WriteLine("Would you like to count somthing more? [y/n]");
            //    string answer = Console.ReadLine();
            //    if (answer == "n")
            //    {
            //        break;
            //    }

            //} while (true);

            //3 Napisz program, który oblicza warto niewiadomej x z równania ax+b = c. 
            // Wartoci a, b, c nale do zbioru liczb rzeczywistych i s wprowadzane z klawiatury. 
            //Dodatkowo naley zabezpieczy program na wypadek sytuacji, kiedy wprowadzona warto a = 0. 
            //Wszystkie zmienne wywietlamy z dokadnoci do dwóch miejsc po przecinku.

            //double a;
            //double b;
            //double c;
            //double x;
            //Console.WriteLine("This is the program to counting x from equation : ax + b = c");
            //Console.WriteLine("Write a");
            //a = double.Parse(Console.ReadLine());

            //if (a == 0)
            //{
            //    Console.WriteLine("Invalid value 'a'. Press entre.");
            //}
            //else
            //{
            //    Console.WriteLine("Write b");
            //    b = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Write c");
            //    c = double.Parse(Console.ReadLine());

            //    x = Math.Round(((c - b) / a),2);
            //    Console.WriteLine("X: " + x);
            //}

            //4 Napisz program, w którym uytkownik zgaduje cakowit liczb losow
            //z przedziau od 0 do 9 generowan przez komputer.

            //int rNumber;
            //int gNumber;

            //Console.WriteLine("Program random number 0 to 9, guess this number");
            //Random r = new Random();
            //rNumber = r.Next(0,9);
            //gNumber = int.Parse(Console.ReadLine());

            //if (rNumber == gNumber)
            //{
            //    Console.WriteLine("Congratulations, you guessed the number");
            //}
            //else
            //{
            //    Console.WriteLine("It's not the guessing number");
            //}

            //Napisz program, który dla podanej przez użytkownika liczby całkowitej sprawdza, czy
            //jest parzysta oraz czy jest ujemna.

            //int number;

            //Console.WriteLine("Write your number");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 1)
            //{
            //    Console.WriteLine("number " + number + " is odd");
            //}
            //else
            //{
            //    Console.WriteLine("number " + number + " is even");
            //}
            //if (number > 0)
            //{
            //    Console.WriteLine("number " + number + " is positive");
            //}
            //else
            //{
            //    Console.WriteLine("number " + number + " is negative");
            //}

            //Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien
            //wypisać parzyste liczby znajdujące się pomiędzy podanymi wartościami. 

            //int firstNumber;
            //int secoundNumber;

            //Console.WriteLine("Write first number");
            //firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write secound number");
            //secoundNumber = int.Parse(Console.ReadLine());

            //if (firstNumber <= secoundNumber)
            //{
            //    Console.Write("Oven numbers: ");
            //    for (int i = firstNumber; i <= secoundNumber; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i + ", ");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.Write("Oven numbers: ");
            //    for (int i = secoundNumber; i <= firstNumber; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i + ", ");
            //        }
            //    }
            //}

            //Dwaj koledzy Janek i Karol zadłużyli się na 80 zł. Umówili się między sobą, że każdy z
            //nich codziennie będzie odkładał na spłatę zadłużenia 20 % swojego dziennego zarobku, Janek
            //zarabia dziennie 50 zł, a Karol 40 zł.Napisz program, który przy pomocy pętli do ..while
            //sprawdzi po ilu dniach obaj koledzy uzbierają kwotę potrzebną do spłaty swojego długu oraz
            //wypisze wartość uzbieranej kwoty w każdym dniu.

            //int debt = 80;
            //int restTorepayment;
            //int janEarn = 50;
            //int karolEarn = 40;
            //int janRepayment = janEarn / 5;
            //int karolRepayment = karolEarn / 5;
            //int months = 0;
            //do
            //{
            //    debt = debt - (janRepayment + karolRepayment);
            //    months++;
            //} while (debt > 0);
            //Console.WriteLine("Debt will be delate after " + months + " months");

            // Napisz program, który wyświetla na ekranie konsoli „kwadrat” zbudowany ze znaku
            // „*”. Liczbę wierszy(a tym samym kolumn) ma podać użytkownik.

            //int number;

            //Console.WriteLine("Wtite length of side square");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < number; i++)
            //{
            //    Console.Write("*");
            //    for (int j = 0; j < number - 2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}
            //for (int i = 0; i < number; i++)
            //{
            //    Console.Write("*");
            //}

            //Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok
            //przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100(za wyjątkiem lat podzielnych
            //przez 400).

            //int year;
            //bool wicked = false;

            //Console.WriteLine("This is program to check if written year is wicked");
            //Console.WriteLine("Write year");
            //year = int.Parse(Console.ReadLine());



            //if (year % 4 == 0)
            //{
            //    wicked = true;

            //}
            //if (year % 100 == 0)
            //{
            //    wicked = false;

            //}
            //if ( year % 400 == 0)
            //{
            //    wicked = true;
            //}
            //if (wicked == true)
            //{
            //    Console.WriteLine(year + " is wicked year");
            //}
            //else
            //{
            //    Console.WriteLine(year + " is not wicked year");
            //}

            // Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien
            // wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej.

            //int firstNumber;
            //int secoundNumber;

            //Console.WriteLine("This program checks to see if the second number is a factor of the first");
            //Console.WriteLine("Write first number");
            //firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write soceund number");
            //secoundNumber = int.Parse(Console.ReadLine());

            //if (firstNumber % secoundNumber == 0)
            //{
            //    Console.WriteLine("Secound number is a factor of the first");
            //}
            //else
            //{
            //    Console.WriteLine("Secound number is not a factor of the first");
            //}

            // Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość
            // największej z nich.

            //double first;
            //double secound;
            //double third;

            //Console.WriteLine("This is program to check whitch number is the biggest");
            //Console.WriteLine("Write first number");
            //first = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write secound number");
            //secound = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write third number");
            //third = double.Parse(Console.ReadLine());

            //if (first > secound)
            //{
            //    if (first > third)
            //    {
            //        Console.WriteLine("First number is the biggest");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Third number is the biggest");
            //    }

            //}
            //else
            //{
            //    if (secound > third)
            //    {
            //        Console.WriteLine("Secound number is the biggest");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Third number is the biggest");
            //    }
            //}

            // Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch
            // zmiennych typu double oraz znak operacji(+lub – lub* lub /), a następnie wyświetla wynik
            // operacji dla podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5
            // oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.

            //double first;
            //double secound;
            //double result = 0;
            //char sign;
            //int mark;


            //Console.WriteLine("This is calculator");
            //Console.WriteLine("Write first number");
            //first = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write sign to operation");
            //sign = char.Parse(Console.ReadLine());
            //Console.WriteLine("Write secound number");
            //secound = double.Parse(Console.ReadLine());

            //switch (sign)
            //{
            //    case '+':
            //        {
            //            result = first + secound;
            //            break;
            //        }
            //    case '-':
            //        {
            //            result = first - secound;
            //            break;
            //        }
            //    case '/':
            //        {
            //            result = first / secound;
            //            break;
            //        }
            //    case '*':
            //        {
            //            result = first * secound;
            //            break;
            //        }
            //}
            //Console.WriteLine("Result = " + result);

            // Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma
            // prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić
            // stosowny komunikat.

            //double a;
            //double b;
            //double c;
            //double result1;
            //double result2;
            //double delta;

            //Console.WriteLine("This is a program to calculate the roots of the quadratic equation ' ax^2 + bx + c = 0 '");
            //Console.WriteLine("Write 'a'");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write 'b'");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write 'c'");
            //c = double.Parse(Console.ReadLine());

            //delta = (b * b) - (4 * a * c);

            //if (delta > 0)
            //{
            //    result1 = (-b - Math.Sqrt(delta)) / 2 * a;
            //    result2 = (-b + Math.Sqrt(delta)) / 2 * a;
            //    Console.WriteLine("Results : " + result1 + " " + result2);
            //}
            //else if (delta == 0)
            //{
            //    result1 = (-b) / 2 * a;
            //    Console.WriteLine("Result : " + result1);
            //}
            //else
            //{
            //    Console.WriteLine("This function doesn't have results");
            //}



            // Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić
            // użytkownika o podanie wagi w kg oraz wzrostu w metrach. Wzór: BMI = masa / wzrost^2
            // a) Po obliczeniu wskaźnika BMI program powinien wyświetlać stosowną informację w
            // zależności od wartości wskaźnika:
            // < 18,5 – niedowaga,
            // 18,5–24,99 – wartość prawidłowa,
            // ≥ 25,0 – nadwaga.
            // b) Korzystając z Wikipedii rozszerz program, tak aby wyświetlał komentarz według
            // poszerzonej klasyfikacji zakresów wskaźnika BMI.

            //double weight;
            //double height;
            //double BMI;

            //Console.WriteLine("This is program to count your BMI");
            //Console.WriteLine("Write your weight (in kilograms)");
            //weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write your height (in meters)");
            //height = double.Parse(Console.ReadLine());

            //BMI = weight / (height * height);

            //if (BMI < 18.5)
            //{
            //    Console.WriteLine("Underweight");
            //}
            //else if (18.5 < BMI && BMI < 25)
            //{
            //    Console.WriteLine("Correct weigth");
            //}
            //else
            //{
            //    Console.WriteLine("Overweith");
            //}

            // 


            //Console.WriteLine("Wpisz nr dnia tygodnia");
            //int numer = int.Parse(Console.ReadLine());
            //switch (numer)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Poniedziałek");
            //            break;
            //        }


            //    case 2:
            //        {
            //            Console.WriteLine("Wtorek");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("Środa");
            //            break;
            //        }
            //    case 4:
            //        {
            //            Console.WriteLine("Czwartek");
            //            break;
            //        }
            //    case 5:
            //        {
            //            Console.WriteLine("Piątek");
            //            break;
            //        }
            //    case 6:
            //        {
            //            Console.WriteLine("Sobota");
            //            break;
            //        }
            //    case 7:
            //        {
            //            Console.WriteLine("Niedziela");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Nie ma takiego dnia tygodnia");
            //            break;
            //        }
            //}

            // Pobierz od użytkownika wartość. Program ma wyświetlać informacje o
            // wysokości przysługującego stypendium zgodnie z poniższą tabelą:
            // Średnia ocen Kwota stypendium
            // 2,00 - 3,99 - 0,00 zł
            // 4,00 - 4,79 - 350,00 zł
            // 4,80 - 5,00 - 550,00 zł

            //double numbersOfmarks = 0;
            //double sumOfmarks = 0;
            //double average;

            //Console.WriteLine("This is program to stypendium counting");
            //Console.WriteLine("How may marks do you have?");
            //numbersOfmarks = double.Parse(Console.ReadLine());

            //for (int i = 1; i <= numbersOfmarks; i++)
            //{
            //    Console.WriteLine("Write value mark number " + i );
            //    sumOfmarks += double.Parse(Console.ReadLine());
            //}

            //average = sumOfmarks / numbersOfmarks;
            //Console.WriteLine("Average: " + average);

            //if (average >= 2 && average <= 3.99)
            //{
            //    Console.WriteLine("Your stypendium: 0zł ");
            //}
            //else if ( average >= 4 && average <= 4.79)
            //{
            //    Console.WriteLine("Your stypendium: 350zł ");
            //}
            //else
            //{
            //    Console.WriteLine("Your stypendium: 550zł");
            //}

            // Napisz program w czterech wariantach (a, b, c i d), którego efektem działania będzie
            // „figura” utworzona ze znaku gwiazdki(*) przedstawiona na danym rysunku.
            //a
            //*
            //**
            //***
            //****
            //b
            //****
            //***
            //**
            //*
            //c
            //   *
            //  **
            // ***
            //****
            //d
            //****
            //*  *
            //*  *
            //****

            //(Liczbę wyświetlanych wierszy podaje użytkownik).

            //char variant;
            //int numbersOfloop;

            //Console.WriteLine("Choose variant [a,b,c,d]");
            //variant = char.Parse(Console.ReadLine());
            //Console.WriteLine("Write number of lines");
            //numbersOfloop = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (variant == 'a')
            //{
            //    for (int i = 0; i < numbersOfloop; i++ )
            //    {
            //        for (int j = 0; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else if (variant == 'b')
            //{
            //    for (int i = numbersOfloop; i > 0; i--)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else if (variant == 'c')
            //{
            //    for (int i = 0; i < numbersOfloop; i++)
            //    {
            //        for (int j = numbersOfloop - 1; j > i; j--)
            //        {
            //            Console.Write(" ");
            //        }
            //        for ( int k = 0; k < i + 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else if (variant == 'd')
            //{
            //    for (int i = 0; i < numbersOfloop; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //    for (int i = 0; i < numbersOfloop - 1; i++)
            //    {
            //        Console.Write("*");
            //        for (int j = 0; j < numbersOfloop - 2; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.WriteLine("*");
            //    }
            //    for (int i = 0; i < numbersOfloop; i++)
            //    {
            //            Console.Write("*");
            //    }
            //}

            // Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.

            //int number;
            //int result = 1;

            //Console.WriteLine("This is program to cout strong");
            //Console.WriteLine("Write value to couting");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine("Result: " + result);

            // Napisz program obliczający ile kolejnych liczb całkowitych (rozpoczynając od wartości 1) 
            // należy dodać do siebie, aby suma przekroczyła wartość 100.

            //int numberOfnumbers = 0;
            //int sum = 0;

            //for ( int i = 1; sum < 100; i++)
            //{
            //    sum += i;
            //    numberOfnumbers++;
            //}
            //Console.WriteLine(numberOfnumbers);

            // Napisz program pobierający od użytkownika liczby całkowite. Program ma pobierać te
            // liczby do czasu, gdy użytkownik wprowadzi wartość 0(zero).Wynikiem działania programu
            // ma być informacja o sumie wprowadzonych przez użytkownika liczb.

            //double value;
            //double number = 0;
            //double sum = 0;

            //Console.WriteLine("This is program to sum any number of numbers");
            //Console.WriteLine("If you want to finish addition write value '0'\n");

            //do
            //{
            //    number++;
            //    Console.WriteLine("Write value number " + number);
            //    value = double.Parse(Console.ReadLine());
            //    sum += value;
            //} 
            //while (value != 0);

            //Console.WriteLine("Sum: " + sum);

            // Napisz program obliczający sumę szeregu W(n)=1 – 2 + 3 – 4 + ...± n, gdzie n jest
            // dowolną liczbą naturalną, którą program ma wczytać.

            //int n;
            //int sum = 0;

            //Console.WriteLine("This is program to do operation ' W(n)=1 – 2 + 3 – 4 + ...± n '");
            //Console.WriteLine("Enter 'n'");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum -= i;
            //    }
            //    else
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("Sum: " + sum);

            // Liczba N jest doskonała, gdy jest równa sumie swych podzielników mniejszych od niej
            // samej np. 6 = 1 + 2 + 3 = 6 – jest liczbą doskonałą.Napisz program znajdujący liczby doskonałe w
            // przedziale < 1,n >, gdzie n podaje użytkownik.

            //int n = 0;
            //int positoinIntabDivisors = 0;
            //int positionIntabNumbers = 0;
            //int[] perfectNumbers = new int[1000000];            

            //Console.WriteLine("This is program to checking 'perfect numbers' ");
            //Console.WriteLine("Example perfect number is '6' becouse sum of the divisors of this number is 6 -> 6 = 1 + 2 + 3");
            //Console.WriteLine("Write number to check perfect numbers <1,n>");
            //n = int.Parse(Console.ReadLine());            

            //for (int i = 1; i <= n; i ++)
            //{
            //    int sumOfdivisors = 0;
            //    int[] divisors = new int[1000000];

            //    for (int j = 1; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            divisors[positoinIntabDivisors] = j;
            //            positoinIntabDivisors++;
            //            sumOfdivisors += j;
            //        }

            //    }
            //    if (sumOfdivisors == i)
            //    {
            //        perfectNumbers[positionIntabNumbers] = i;
            //        positionIntabNumbers++;
            //    }
            //}

            //Console.Write("Perfect numbers: ");

            //for (int i = 0; i < positionIntabNumbers; i++)
            //{
            //    Console.Write(perfectNumbers[i] + " ");
            //}

            // TABLES EXERCISES

            // Zapytaj użytkownika o ilość elementów całkowitych. Następnie utwórz odpowiednią tablicę i wyczytaj elementy, 
            //które podaje użytkownik. Wypisz elementy tablicy i podaj ich sumę.

            //int numbers = 0;
            //int number = 1;
            //int sum = 0;

            //Console.WriteLine("how many numbers would you like to sum?");
            //numbers = int.Parse(Console.ReadLine());


            //int[] tabOfnumbers = new int[numbers];

            //for (int i = 0; i < numbers; i++)
            //{
            //    Console.WriteLine("Write value number " + number);
            //    number++;
            //    tabOfnumbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Your numbers: ");
            //for (int i = 0; i < numbers; i++)
            //{
            //    Console.Write(tabOfnumbers[i] + ", ");
            //    sum += tabOfnumbers[i];
            //}
            //Console.WriteLine("\nSum: " + sum);

            // Wypełnij tablicę losowymi liczbami całkowitymi. Następnie wypisz ile liczb parzystych 
            // i nieparzystych znajduje się w tej tablicy.

            //int value = 0;
            //int quantity = 0;
            //Random rnd = new Random();

            //int[] tab = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    tab[i] = rnd.Next(0, 9);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (tab[i] % 2 == 0)
            //    {
            //        Console.Write(tab[i] + ", ");
            //        quantity++;
            //    }
            //}
            //Console.WriteLine("\n \nQuantity: " + quantity);

            // Zadeklaruj dwie tablice liczb całkowitych o tym samym rozmiarze oraz zainicjalizuj je liczbami pseudolosowymi. 
            // Napisz program, który zamieni wartości w obydwu tablicach, tzn. tak aby po operacji zamiany w 
            // tablicy pierwszej znajdowały się wartości z tablicy drugiej i na odwrót.

            //int[] tab1 = new int[10];
            //int[] tab2 = new int[10];
            //int[] tab3 = tab1;
            //int[] tab4 = tab2;
            //Random random = new Random();

            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    tab1[i] = random.Next(0, 9);
            //}
            //for (int i = 0; i < tab2.Length; i++)
            //{
            //    tab2[i] = random.Next(0, 9);
            //}


            //Console.WriteLine("tab1: ");

            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    Console.Write(tab1[i] + ", ");
            //}
            //Console.WriteLine("\ntab2: ");

            //for (int i = 0; i < tab2.Length; i++)
            //{
            //    Console.Write(tab2[i] + ", ");
            //}

            //tab1 = tab4;
            //tab2 = tab3;

            //Console.WriteLine("\ntab1 after changes: ");

            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    Console.Write(tab1[i] + ", ");
            //}
            //Console.WriteLine("\ntab2 after changes: ");

            //for (int i = 0; i < tab2.Length; i++)
            //{
            //    Console.Write(tab2[i] + ", ");
            //}

            // 

        }
    }
}
