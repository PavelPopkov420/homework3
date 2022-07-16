int n = Convert.ToInt32(Console.ReadLine());
if (n > 9999 && n < 100000)
{   
    if ((n/10000 == n % 10) && (n/1000) % 10 == (n/10) % 10)
    Console.WriteLine("Число является палиндромом " + Convert.ToString(n));
    else
    Console.WriteLine("Число не является палиндромом " + Convert.ToString(n));
}
else 
    Console.WriteLine("Введите пятизначное число");