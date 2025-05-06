
using System.Diagnostics;
using System.Threading.Tasks;

void Islem1()
{
    Console.WriteLine("Islem 1");
    Thread.Sleep(5000);
}

void Islem2()
{
    Console.WriteLine("Islem 2");
    Thread.Sleep(8000);
}

void Islem3()
{
    Console.WriteLine("Islem 3");
    Thread.Sleep(7000);
}

// senkron çalışma
//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();
//Islem1();
//Islem2();
//Islem3();
//stopwatch.Stop();
//Console.WriteLine($"Geçen süre: {stopwatch.ElapsedMilliseconds} ms");

async Task Islem1Async()
{
    Console.WriteLine("Islem 1");
    await Task.Delay(5000);
}

async Task Islem2Async()
{
    Console.WriteLine("Islem 2");
    await Task.Delay(8000);
}

async Task Islem3Async()
{
    Console.WriteLine("Islem 3");
    await Task.Delay(7000);
}

// asenkron çalışma
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
Task.WaitAll(Islem1Async(), Islem2Async(), Islem3Async());
//Islem1Async();
//Islem2Async();
//Islem3Async();
stopwatch.Stop();
Console.WriteLine($"Geçen süre: {stopwatch.ElapsedMilliseconds} ms"); // wait yapmadığımızda beklemiyor 5 ms çıkıyor çünkü işlem bitmeden süreyi alıyor
                                                                      // asenkron ile en uzun süreli olan işlem bekleniyor. geçen süre en uzun olan işlemin süresi oluyor