using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace UsingKullanimi
{
    internal class Program
    {
        // Using nedir nasıl kullanılır?
        // using deyiminin 2 kullanımı vardır.
        // 1 - Bulunduğunuz namespace haricindeki herhangi bir namespace'e kisayoldan ulaşabilmek için 
        // dosyanın en başında tanımlanan şekli.
        // 2 - Unmanaged(yönetilemeyen) kaynakların kullanımı.

        // Ben burada 2. kullanımını anlatmaya çalışacağım.
        // .Net Framework içerisinde Gabage Collector adı verilen sistem, runtime (çalışma) anında 
        // kullanılmayan atıl durumda olan tüm managed (yönetilen) kaynakları hafızadan temizler. 
        // Fakat Unmanaged kaynaklarda tam kontrole sahip değildir. Kullanılmıyor olsalar bile hafızadan 
        // serbest bırakmaz. Bu sebeple bu kaynakları biz dispose (yoketmek) etmek durumda kalırız. 
        // .Net mimarisinde bu iş için yazılmış IDisposable arayüzü bulunur. 
        // Bu tarzda unmanaged kaynaklara erişen nesneler genelde IDisposable arayüzünü implement etmiştir.

        // Bu tarz Unmanaged kaynaklara erişen nesneleri kullandıktan sonra işimiz bittiğinde IDisposable 
        // arayüzünden gelen Dispose methodu ile hafızadan temizlememiz gerekir.
        // Uzunca yazılan bir kod içerisinde bazen bu işlem unutulabilir. 
        // Böyle durumlarda imdadımıza using statement'i yetişir. 
        // Nesneyi oluştururken using kullandığımızda using'in block parantezi bittiğinde ilgili nesneye 
        // Dispose methodu gönderilir. Yanlış olan, olması gereken ve using ile nasıl olacağı şeklinde 
        // bir örnek vermek gerekirse şu olabilir.
        private static void Main(string[] args)
        {
            // Uygulama örneğimizde using kullanılarak ve kullanılmayarak Unmanaged bir nesnenin RAM kullanımını
            // göreceğiz. Aşağıda tanımladığımız iki method proje exe'si ile aynı klasörde bulunan bir jpeg
            // görselini FileStream ile hafızaya alıp Image ile image nesnesine çevirip Bitmap ile bitmape çevirmektedir.
            // böylece bir görsel 3 kopya şeklinde hafızada tutulmaktadır.
            // Bunu bir döngü içerisinde çevirdiğimizde hafızayı şişiren bir kod elde etmiş bulunuyoruz.
            // using ve kullanılmadığı durumlarda ne olduğunu projeyi çalıştırarak kendiniz görebilirsiniz.
            // Methodlara verdiğimiz integer değişken ile for'un kaç defa döneceğini kendi sisteminize göre verebilirsiniz. 

            UsingKullanarak(5);

            Console.WriteLine("devam etmek için bir tuşa basınız...");
            Console.ReadLine();

            UsingKullanmadan(5);
        }

        private static void UsingKullanarak(int v)
        {
            for (int i = 0; i < v; i++)
            {
                using (FileStream fs = new FileStream(
                    Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "image.jpg")
                    , FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (Image img = Image.FromStream(fs))
                    {
                        using (Bitmap bmp = new Bitmap(img))
                        {
                            Console.WriteLine($"{i+1} : {bmp.Height}x{bmp.Width} Kullanılan RAM : {Process.GetCurrentProcess().WorkingSet64 / (1024 * 1024)}");
                        }
                    }
                }
            }
        }

        private static void UsingKullanmadan(int v)
        {
            for (int i = 0; i < v; i++)
            {
                FileStream fs = new FileStream(
                    Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "image.jpg")
                    , FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Image img = Image.FromStream(fs);
                Bitmap bmp = new Bitmap(img);
                Console.WriteLine($"{i+1} : {bmp.Height}x{bmp.Width} Kullanılan RAM : {Process.GetCurrentProcess().WorkingSet64 / (1024 * 1024)}");
            }
        }
    }
}
