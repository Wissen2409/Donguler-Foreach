// Döngüler konusunu tekrar hatırlayalım

// For
// Do While
// While
// Foreach

// biz yukarıdaki 3 adet döngüyü gördük. Ancak Foreach döngüsü o ana kadar bildiklerimizle çalışmayacağı için
// Foreach döngüsünü koleksiyonlardan sonraya bıraktık.

// Foreach döngüsü, for ve while döngüsünden farklı olarak, bir döngü değişkenine ihtiyaç duymazlar
// Aynı şekilde bir artırım ifadesine de ihtyiaç duymazlar.
// Yine , for yada while döngüsündeki gibi bir koşula bağlıda dönmezler

//Tanım :

// Örnek bir arraylist içerisinde dönecek bir foreach döngüsü oluşturalım
using System.Collections;

ArrayList list = new ArrayList();
list.Add("İstanbul");
list.Add("Rize");
list.Add("Muğla");
list.Add("İzmir");
list.Add("Ordu");
list.Add("Ağrı");
list.Add("Antalya");
list.Add("Hatay");
list.Add("Maraş");


/*foreach(object item in list){

/*    Console.WriteLine(item);    
}*/


// Yukarıdaki döngüdeki elemanları incelelim

// object : Koleksiyonun içerisindeki eleman tipi hangisi ise, o tip olmaldır.
// item   : Döngü her bir tur döndüğünde, döngü içerisindeki o anki elemandır 
// in : bir keyword'dür, Hangi koleksiyonun içerisinde gezileceğini gösterir
// list : bu kısma, döneceğiniz koleksiyonu yazmalısınız

// Foreach : Başı ve sonu belli olan koleksiyonlarda, koleksiyon sonuna kadar döner
// Şarta ihtiyaç duymaz


// Foreach her zaman belli bir istisna hariç :  her zaman ileri yönlü iterasyon yapar

// Break ve continue gibi atlama deyimleri, bu döngüde de vardır.

// Soru : Foreach döngüsünde, koleksiyon içerisindeki tip ne ise onu yazıyorsak, key- value koleksiyonda ne yazıyoruz.


SortedList sortedList= new SortedList();
sortedList.Add(1, "Ankara");
sortedList.Add(2, "İstanbul");
sortedList.Add(3,"İzmir");

// Foreach ile , key-value koleksiyonunda nasıl dönülür

// var : 6
// object 8

// var ile dönülebilir.


// sortedlist koleksiyonunu var ile gezmek için aşağıdaki yöntemi uygulamak gerekiyor
/*foreach(var item in sortedList){

    var result = (DictionaryEntry)item;
    Console.WriteLine("Key : {0} Value : {1}",result.Key,result.Value);
}


// Var kullanmadan, key value koleksiyonunu gezmek için DictionaryEntry kullanılmalı
foreach(DictionaryEntry item in sortedList){

    Console.WriteLine("Key : {0} Value : {1}",item.Key,item.Value);
}
*/

// Öğrenciden aldığımız not sayısına göre, notları alıp, notların toplamı ve ortalamsını ekrana yazdırınız
/*
Console.WriteLine("Not sayisini giriniz");
int not = int.Parse(Console.ReadLine());
ArrayList liste = new ArrayList(not);


for(int i =0; i < not; i++)
{
    Console.WriteLine("{0}. notu giriniz",i+1);
    liste.Add(int.Parse(Console.ReadLine()));
}

// hesaplama adımlarını foreach kullanarak yapalım

int toplam =0;


// ArrayList'in içerisinde döndük
foreach(object o in liste){

    toplam+=(int)o;
}
Console.WriteLine("Toplam : {0} - Ortalama : {1}",toplam,toplam/liste.Count);
*/


// Not : foreach ile dizi içerisinde de dönebiliriz

/*string[] teknoloji = {"Html","Css","Javascript","C#","Docekr","Kubernetes","Java","Rust","Go","Kotlin","Php","RabbitMQ"};

foreach(string tech in teknoloji){

    Console.WriteLine(tech);

}
*/

// int tipinde bir dizi içerisinde dönelimö
/*int[] plakalar ={35,06,01,48,02,81,34,35};
foreach(int plaka in plakalar){
    Console.WriteLine("Plaka : {0}",plaka);
}*/

// Random tipinde bir dizi yapabilir miyiz ? 

// 3 adet random taşıyan bir random dizisi
/*
Random[] randoms ={new Random(),new Random(),new Random()};
foreach(Random rnd in randoms){

    Console.WriteLine(rnd.Next());
}
*/

/*int[] randoms = {new Random().Next(),new Random().Next(),new Random().Next(),new Random().Next()};
// Cevap : yukarıdaki dizi eleman sayısı kadar random değer üretilecek
foreach(int i in rewerew)
{

    Console.WriteLine(i);
}
*/

// Ödev : 
// Çarpım tablosunu foreach ile yapınız(İç içe foreach)


