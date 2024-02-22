
 bool RandomSimvol(char [] arr)
{
    char[] arr2 = new char[arr.Length];


        for (int j = 0; j < arr.Length; j++)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, arr.Length);
            arr2[j] = arr[randomIndex];
            Console.Write(arr2[j]);
        }
    for (int i = 0; i <1; i++)
    {
        if (arr2[i] == arr2[i + 1] && arr2[i + 1] == arr2[i + 2])
        {
            return true;
        }
    } 

    return false;
}
char[] arr = {'@', '#', '$' };

Console.WriteLine("Balans daxil edin, (her uduzulan oyunda -1, udanda +1)");
int balans=Convert.ToInt32(Console.ReadLine());
while (balans!=0)
{
    Console.WriteLine("carxi cevirmek ucun entere basin");
    Console.ReadKey();
    if (RandomSimvol(arr))
    {
        Console.WriteLine("Tebrikler qazandiniz");
        balans++;
        Console.WriteLine("hazirki balans - "+ balans);
    }
    else
    {
        Console.WriteLine("uduzdunuz.");
        balans--;
        Console.WriteLine("hazirki balans - " + balans);
    }
}
