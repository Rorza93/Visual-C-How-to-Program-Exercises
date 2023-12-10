// Cryptography.cs
// Used to encrypt and decrypt a 4 digit integer
using System;

class Cryptography
{
    public int[] GetEncryption(string userInput)
    {
        int[] input = new int[userInput.Length];
        int temp = 0;

        for (int i = 0; i < userInput.Length; i++)
        {
            input[i] = int.Parse(userInput[(i)].ToString());
        }

        for (int i = 0; i < input.Length; i++)
        {
            input[i] = (input[i] + 7) % 10;
        }
        temp = input[0];
        input[0] = input[2];
        input[2] = temp;

        temp = input[1];
        input[1] = input[3];
        input[3] = temp;
        return input;
    }

    public int[] GetDecryption(string userInput)
    {
        int[] input = new int[userInput.Length];
        int temp = 0;

        for (int i = 0; i < userInput.Length; i++)
        {
            input[i] = int.Parse(userInput[(i)].ToString());
        }

        temp = input[1];
        input[1] = input[3];
        input[3] = temp;

        temp = input[0];
        input[0] = input[2];
        input[2] = temp;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 0 && input[i] <= 6)
                input[i] += 10;
            input[i] = input[i] - 7;
        }
        

        
        return input;
    }
    static void Main()
    {
        Console.Write("Enter the 4 digit integer you would like to encrypt: ");
        string userInput = Console.ReadLine();
        
        Cryptography encrypt = new Cryptography();
        var input = encrypt.GetEncryption(userInput);
        Console.Write("Encrypted value: ");
        foreach (var item in input)
        {
            Console.Write(item);
        }



        Console.Write("\nEnter the 4 digit integer you would like to decrypt: ");
        string userDecrypt = Console.ReadLine();

        var decrypt = encrypt.GetDecryption(userDecrypt);
        Console.Write("Decrypted value: ");
        foreach (var item in decrypt)
        {
            Console.Write(item);
        }
    }
}