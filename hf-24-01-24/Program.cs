using System.ComponentModel.DataAnnotations;

Random rnd = new Random();
int[] tomb = new int[50];
for (int i = 0; i < tomb.Length; i++)
{
    tomb[i] = rnd.Next(1, 500);
    Console.Write("{0}, ", tomb[i]);
}
Console.WriteLine("\na");
//1
int[] a = new int[50];
for (int i = 0; i < tomb.Length; i++)
{
	if (tomb[i]>100 && tomb[i]%2!=0)
	{
        Console.Write("{0}, ", tomb[i]);
		a.Append(tomb[i]);
	}
}
Console.WriteLine("\nb");
//2
int[] b = new int[50];
for (int i = 0; i < tomb.Length; i++)
{
    if (tomb[i] %3!=0 && tomb[i] % 2 == 0)
    {
        Console.Write("{0}, ", tomb[i]);
        b.Append(tomb[i]);
    }
}
Console.WriteLine("\nc");
//3
int[] c = new int[50];
for (int i = 0; i < tomb.Length; i++)
{
    int result = tomb[i].ToString().Sum(c => c - '0');
    if (tomb[i] <=200 || tomb[i]>=300 && result%5==0)
    {
        Console.Write("{0}, ", tomb[i]);
        c.Append(tomb[i]);
    }
}
Console.WriteLine("\nd");
//4
int[] d = new int[50];
for (int i = 0; i < tomb.Length; i++)
{
    string tombstring = tomb[i].ToString();
    Console.Write(tombstring);
    bool van3 = false;
    for (int j = 0; j < tombstring.Length; j++)
    {
        if (tombstring[j].Equals("3"))
        {
            van3 = true;
        }
    }
    if (tomb[i] > 100 && tomb[i]<300 && van3==true)
    {
        Console.Write("{0}, ", tomb[i]);
        d.Append(tomb[i]);
    }
}
//5
int max = 0;
int[] e = new int[50];
for (int i = 0; i < tomb.Length; i++)
{
    
    if (tomb[i] % 3 != 0 && tomb[i] % 7 == 0 && tomb[i]>max)
    {
        max = tomb[i];
    }
}
Console.WriteLine("e: {0}",max);

//6
int min = 501;
for (int i = 0; i < tomb.Length; i++)
{
    string tombstring = tomb[i].ToString();
    bool van3 = false;
    for (int j = 0; j < tombstring.Length; j++)
    {
        if (tombstring[j]==3)
        {
            van3 = true;
        }
    }
    if (van3==true && tomb[i]<min)
    {
        min = tomb[i];
    }
}
if (min == 501)
{
    Console.WriteLine("f: nincs ilyen");
}
else
{
    Console.WriteLine("f: {0}",min);
}