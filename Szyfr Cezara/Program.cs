Console.WriteLine("Wisz wiadomość do zakodowania");
string wiadomosc = Console.ReadLine();
char[] wchar = wiadomosc.ToCharArray();
int a;
Console.WriteLine("wpisz klucz");
a = Int32.Parse(Console.ReadLine());

for (int i = 0; i < wchar.Length; i++)
{
     wchar[i] = (char)((char)wchar[i] + a);
        if (wchar[i] > 90)
        {
            wchar[i] = (char)((char)wchar[i] - 26);
        }
}
string wiadomosc2 = new string(wchar);
Console.WriteLine("zaszyfrowana wiadomosc");
Console.WriteLine(wiadomosc2);

