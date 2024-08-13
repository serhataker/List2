using System;
namespace ListWork2
{

    class List2
    {

        static void Main(string[] args)
        {

            List<string> listOf2 = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please Enter the Coffe Name:"); //  We wait  to the user input the 5 Coffe name loop the for
                listOf2.Add(Console.ReadLine());

            }
            listOf2.Sort(); // we sorting the name of inputs coffe name
            Console.WriteLine("This list your input sorting");
            foreach (string item in listOf2) //  we after result the with foreach loop
            {
                Console.WriteLine(item);
            }
        }
    }
}