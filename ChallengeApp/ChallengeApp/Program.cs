int number = 4594;
string numberIsString = number.ToString();
char[] letters = numberIsString.ToCharArray();
int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

foreach (char c in letters)
{
    if (c == '0') { ++counter[0]; }
    else if (c == '1') { ++counter[1]; }
    else if (c == '2') { ++counter[2]; }
    else if (c == '3') { ++counter[3]; }
    else if (c == '4') { ++counter[4]; }
    else if (c == '5') { ++counter[5]; }
    else if (c == '6') { ++counter[6]; }
    else if (c == '7') { ++counter[7]; }
    else if (c == '8') { ++counter[8]; }
    else if (c == '9') { ++counter[9]; }
}

Console.WriteLine("Wyniki dla liczby:" + number);

for (int i = 0; i < counter.Length; i++)
{
    Console.WriteLine(i + " => " + counter[i]);
}