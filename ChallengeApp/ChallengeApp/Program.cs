string name = "Karolina";
char sex = 'K';
int age = 32;

if(sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if(name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
} 
else if(sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna.");
}
else
{
    Console.WriteLine("Nie jesteś ani Kobietą poniżej 30 lat ani Ewą, lat 33 ani Niepełnoletnim Mężczyzną!");
}



