using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO_ödev
{
    class Algoritma
    {
        private double eniyiuygunluk = 0; // Global en iyi uygunluk değeri
        private double[] eniyipozisyon; // Global en iyi pozisyon değerinin x ve y koordinatları

        private static Random rnd = new Random();

        private int parcamiktar; // Parçacık Miktarı
        private int jenerasyon; // Jenerasyon Sayısı
        private double ögren1; // Öğrenme Faktörü
        private double ögren2; // Öğrenme Faktörü
        private Bilesenler[] parca;

        const int boyut = 2; // Problem boyutu (Yani 2 boyutlu bir matris üzerinde çalışılması)
        const double minX = -5.0; // Test fonksiyonunda yer alan min. aralık değeri
        const double maxX = 5.0; // Test fonksiyonunda yer alan max. aralık değeri
        const double w = 0.729;
        public Algoritma(int parcaboyut, int jenerasyon, double ögren1, double ögren2)
        {
            // Winform'dan alınan değerlere göre hesaplanacak değerler işleniyor
            this.eniyipozisyon = new double[boyut];
            this.parcamiktar = parcaboyut;
            this.parca = new Bilesenler[parcaboyut];
            this.jenerasyon = jenerasyon;
            this.ögren1 = ögren1;
            this.ögren2 = ögren2;
        }

        private double FitnessHesap(double[] x) // x: Pozisyon koordinatları matrisi
        {
            // Test fonksiyonuna göre yeni uygunluk değeri hesaplanıyor
            return Fonks.Fonk(x);

        }

        public double[] psoalgoritma()
        {
            int k = 1; // While döngüsü kontrol değişkeni
            double r1, r2; // Yeni değerler için alınmış rasgele değerler
            double[] Yenihız = new double[boyut]; // Yeni hız değerleri için oluşturulmuş matris
            double[] yenipozisyon = new double[boyut]; // Yeni pozisyon değerleri için oluşturulmuş matris
            double yeniuygunluk; // Yeni uygunluk değeri

            double[] jenesonuc = new double[jenerasyon];
            // En iyi fitness değerlerini kapsayan matris (Grafiksel gösterim için oluştulmuştur)


            for (int i = 0; i < parca.Length; ++i)
            {
                double[] randompozisyon = new double[boyut];

                // Rasgele pozisyon koordinaları oluşturuluyor. x ve y koordinatları için döngü 2 kez dönecek
                for (int j = 0; j < randompozisyon.Length; ++j)
                {
                    randompozisyon[j] = (maxX - minX) * rnd.NextDouble() + minX;
                }

                double fitness = FitnessHesap(randompozisyon); // Başlangıç uygunluk değeri hesaplanıyor
                double[] rndhız = new double[boyut];

                // Fonksiyonun aralık değeri sigmoid fonksiyonundan geçirilerek yeni hız değerleri oluşturuluyor
                for (int j = 0; j < rndhız.Length; ++j)
                {
                    double min = minX * 0.1;
                    double max = maxX * 0.1;
                    rndhız[j] = (max - min) * rnd.NextDouble() + min;
                }

                // Oluşturulan rangele değerlerle birlikte parçacıkların oluşumuda tamamlanıyor
                parca[i] = new Bilesenler()
                {
                    Hız = rndhız,
                    Pozisyonn = randompozisyon,
                    Fitnessdeger = fitness,
                    eniyipozisyonn = randompozisyon,
                    eniyifitnesdeger = fitness
                };

                // Uygunluk değeri için minimizasyon işlemi yapılıyor
                if (parca[i].Fitnessdeger < eniyiuygunluk)
                {
                    eniyiuygunluk = parca[i].Fitnessdeger;
                    parca[i].Pozisyonn.CopyTo(eniyipozisyon, 0);
                }
            }

           

            do
            {
                for (int i = 0; i < parcamiktar; i++)
                {
                    // Anlık parçacığın değeri alınarak işlemler onun üzerinden yürütülüyor
                    Bilesenler simdikiparca = parca[i];

                    // Yeni hız değerlerinin belirlenmesi
                    for (int j = 0; j < simdikiparca.Hız.Length; j++)
                    {
                        r1 = rnd.NextDouble();
                        r2 = rnd.NextDouble();

                        // Yeni hız değeri alaket ağırlığı, anlık hız, en iyi pozisyon ve rasgele değerler eşliğinde hesaplanıyor
                        Yenihız[j] = ( w*simdikiparca.Hız[j]) +
                                      (ögren1 * r1 * (simdikiparca.eniyipozisyonn[j] - simdikiparca.Pozisyonn[j])) +
                                      (ögren2 * r2 * (eniyipozisyon[j] - simdikiparca.Pozisyonn[j]));
                    }
                    Yenihız.CopyTo(simdikiparca.Hız, 0); // Yeni hız değerleri eski hız değerlerinin yerine yazılır.

                    // Yeni pozisyon değerlerinin belirlenmesi
                    for (int j = 0; j < simdikiparca.Pozisyonn.Length; ++j)
                    {
                        // Yeni pozisyon için kat edilen yol ile önceki pozisyon toplanır
                        yenipozisyon[j] = simdikiparca.Pozisyonn[j] + Yenihız[j];

                        // Eğer fonksiyonun min değerinden küçük bir pozisyon değeri alındıysa min değeri kaydedilir.
                        if (yenipozisyon[j] < minX)
                            yenipozisyon[j] = minX;
                        // ve fonksiyonun max değerinden büyük bir pozisyon değeri alındıysa max değeri kaydedilir.
                        else if (yenipozisyon[j] > maxX)
                            yenipozisyon[j] = maxX;
                    }
                    yenipozisyon.CopyTo(simdikiparca.Pozisyonn, 0); // Yeni pozisyon değerleri eski pozisyon değerlerinin yerine yazılır.

                    yeniuygunluk = FitnessHesap(yenipozisyon); // Yeni uygunluk değeri test fonksiyonuna göre hesaplanır
                    simdikiparca.Fitnessdeger = yeniuygunluk; // Anlık parçacığın yeni uygunluk değeri yazdırılır.

                    // Uygunluk değeri minimizasyon işleminden geçiriyor.
                    if (yeniuygunluk < simdikiparca.eniyifitnesdeger)
                    {
                        yenipozisyon.CopyTo(simdikiparca.eniyipozisyonn, 0);
                        simdikiparca.eniyifitnesdeger = yeniuygunluk;
                    }

                    // Global en iyi uygunluk değeri için minimizasyon işlemi yapılıyor.
                    if (yeniuygunluk < eniyiuygunluk)
                    {
                        yenipozisyon.CopyTo(eniyipozisyon, 0);
                        eniyiuygunluk = yeniuygunluk;
                    }
                }

                jenesonuc[k - 1] = eniyiuygunluk; // Grafiğe yazdırılacak en iyi uygunluk değeri matrise kaydediliyor

            } while (k++ < jenerasyon); // Jenerasyon sayısı ve hata değeri sıfırlanıncaya kadar döngü devam eder.

            return jenesonuc; // Grafiğe kaydedilecek değerler döndürülüyor
        }
    }
}
