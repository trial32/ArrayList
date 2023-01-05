
using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add("Ayşe");
arrayList.Add(10);
arrayList.Add(true);
arrayList.Add('a');

//verilere ulaşım
Console.WriteLine(arrayList[0]);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

//AddRange
Console.WriteLine("***************");
List<int> sayilar= new List<int>(){1,6,26,3,95,8};

string[] renkler = {"kırmızı", "yeşil", "sarı"};

arrayList.AddRange(sayilar);
arrayList.AddRange(renkler);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

Console.WriteLine("*********SORT**********");
ArrayList sayiList= new ArrayList();
sayiList.AddRange(sayilar);

sayiList.Sort();

foreach (var item in sayiList)
{
    Console.WriteLine(item);
}

Console.WriteLine("*********REVERSE**********");
sayiList.Reverse();
foreach (var item in sayiList)
{
    Console.WriteLine(item);
}

Console.WriteLine("*********CLEAR**********");
sayiList.Clear();
foreach (var item in sayiList)
{
    Console.WriteLine(item);
}

