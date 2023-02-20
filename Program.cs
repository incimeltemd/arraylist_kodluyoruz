//array 
int[] dizi = {1,3,5,7,9,11};


foreach (var sayi in dizi)
    Console.WriteLine(sayi);


//sort - sıralı dizi
Console.WriteLine("**********");
Array.Sort(dizi);

foreach(var sayi in dizi)
    Console.WriteLine(sayi);

//clear, verilen başlangıc indexi ve sonraki n kadar sayıyı 0lar
Console.WriteLine("**********");
Array.Clear(dizi,2,3);
foreach(var sayi in dizi)
    Console.WriteLine(sayi);

//reverse-aynalama
Console.WriteLine("**********");
Array.Reverse(dizi);
foreach (var sayi in dizi)
    Console.WriteLine(sayi);

//indexof
Console.WriteLine("**********");
    Console.WriteLine(Array.IndexOf(dizi,11));

//resize
Console.WriteLine("**********");
Array.Resize<int>(ref dizi,5);
