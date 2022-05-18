# Proje Nedir
* Öğretmen tarafında soru ve sınav hazırlama, öğrenci değerlendirme
* Öğrenci tarafında süreli sınav veya süresiz rastgele soru çözümüne olanak sağlar.
# Nasıl Kurulur 
* Sınavları, soruları, cevapları ve öğrenci bilgilerini içeren bir veritabanına sahip olmanız gerekir.
* Veritabanınızda [Sinav, Soru, sinavSonuclari, Kisi] isimli tablolar bulunmalı.
* Tablolara erişecek şekilde ADO.NET Entitiy Data Model'i kurmanız gerekir.

# Admin Yardım
* Giriş yaptıktan sonra Soru hazırla kısmından sisteme soru ekleyebilirsiniz, soru eklerken dikkat edilmesi gereken bazı korumalar mevcuttur bunlar;
1) Soru açıklaması veya resminden en az biri olması lazım
2) Doğru şıkkın işaretlenmiş olması lazım
3) Cevap şıklarının hepsinin dolu olması lazım
4) Ünite ve konu numarası girilmeli
* Sınav Hazırla kısmından sistemde bulunan sorulardan seçeceğiniz bir kombinasyonla bir sınav oluşturabilirsiniz, sınav oluştururken dikkat edilmesi gereken bazı korumalar mevcuttur bunlar;
1) Sınavın adı olmadı
2) Sınavın süresi belirlenmeli
* Adminler istediği öğrencinin okul nosunu girerek geçmiş sınavlarını görebilirler.

# Öğrenci Yardım
* İlk giriş ekranında eğer üye değilseniz Kayıt kısmından üye olmanız gerekir, daha sonra giriş yaparak sisteme ulaşabilirsiniz.
* Siteme giriş yaptıktan sonra; 
* İsterseniz süre kısıtlaması olmadan rastgele soru çözebilirsiniz.
* İsterseniz süre ve soru sayısı önceden belirlenmiş olan sınavlara girebilirsiniz.
* Bir süre programı kullandıktan sonra Analiz Raporu kısmından raporunuzu elde edebilirsiniz.
* Raporda; daha önce çözdüğünüz sorular hakkında Ünite ve Konulara bölünmüş şekilde çözdüğünüz soru sayısı ve doğru/yanlış sayılarınızı görebilirsiniz.
* İsterseniz raporunuzun fiziksel çıktısını alabilirsiniz
* Ayrıca geçmiş sınav seçeneğine tıklayarak önceki sınavlarınızın küçük bir yazılı analizine erişebilirsiniz.

# Sınav Sorumlusu Yardım
* Sınav Hazırla kısmından sistemde bulunan sorulardan seçeceğiniz bir kombinasyonla bir sınav oluşturabilirsiniz, sınav oluştururken dikkat edilmesi gereken bazı korumalar mevcuttur bunlar;
1) Sınavın adı olmadı
2) Sınavın süresi belirlenmeli
