using System;

class PrimeNumber{
	public static void Main(String [] args){
	
	Console.WriteLine("Enter your Number");
	int myNumber = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= myNumber/2; i++)
        {
            if (myNumber % i == 0)
                count++;
        }
        if (count >= 2)
            Console.WriteLine("It is not a Prime Number "+myNumber);
	else if(myNumber==0 || myNumber==1)
	    Console.WriteLine("It is not a Prime Number "+myNumber);
        else
            Console.WriteLine("It is a Prime Number "+ myNumber);
    }
}