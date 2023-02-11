//Matemaatika >= 90 või Keemia >= 90;

int math, biology, chemistry;

Console.WriteLine("Sisesta oma matemaatika tulemus: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma bioloogia tulemus: ");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma keemia tulemus: ");
chemistry = Int32.Parse(Console.ReadLine());

if ( (math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90) )
{
    Console.WriteLine("Õnnitled! Oled vastu võetud");
}
else
{
    Console.WriteLine("Kahjuks sinu tulemused ei olnud piisavalt head");
}