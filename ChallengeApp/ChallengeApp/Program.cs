int number = 4566;
string numberInString = number.ToString(); 
char[] letters = numberInString.ToArray();
char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int count = 0;

Console.WriteLine("Sprawdzenie ilości poszczególnych cyfr w liczbie " + number + ".");
Console.WriteLine("");

Console.WriteLine("Rozwiązanie zadania z wykorzystaniem 2 pętli 'for':");
for (int i = 0; i < digits.Length; i++)
{
    for (int j = 0; j < letters.Length; j++)
    {
        if (digits[i] == letters[j])
        {
            count++;
        }
    }
    Console.WriteLine(i + " => " + count);
    count = 0;
}

Console.WriteLine("");
Console.WriteLine("Rozwiązanie zadania z wykorzystaniem 2 pętli 'foreach':");
foreach (char digit in digits)
{
    foreach(char letter in letters)
    {
        if (digit == letter)
        {
            count++;
        }
    }
    Console.WriteLine(digit + " => " + count);
    count = 0;
}