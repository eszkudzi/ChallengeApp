string name = "Ewa";
char gender = 'k'; //k - kobieta, m - mężczyzna
int age = 30;

if (gender == 'k' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender != 'k' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Inny człowiek");
}
