# Hastane Yönetim Sistemi

Bu proje, C# WinForms ve SQL kullanılarak geliştirilen bir hastane yönetim sistemidir. Sistem, doktor, sekreter ve hasta giriş panellerine sahip olup çeşitli fonksiyonları yerine getirebilmektedir.

## Özellikler

### Hasta Paneli
- **Kayıt Olma**: Yeni hastalar sisteme kayıt olabilir.
- **Giriş Yapma**: Kayıtlı hastalar giriş yapabilir.
- **Randevu Alma**: Hastalar mevcut doktorlar ve branşlar arasından randevu alabilir.
- **Randevu Geçmişi**: Hastalar geçmiş randevularını görüntüleyebilir.
- **Aktif Randevular**: Hastalar aktif bulunan randvularını görüntüleyebilir.
- **Bilgi Düzenleme**: Hastalar kişisel bilgilerini güncelleyebilir.
- **Şikayet Bildirme**: Hastalar şikayetlerini doktora iletebilir.

### Doktor Paneli
- **Giriş Yapma**: Doktorlar sisteme giriş yapabilir.
- **Randevu Listesi**: Doktorlar, hastaların randevu listesini görüntüleyebilir.
- **Hasta Şikayetleri**: Hastaların bildirdiği şikayetleri inceleyebilir.
- **Duyuru Takibi**: Sistem yöneticisi veya sekreter tarafından yapılan duyuruları takip edebilir.

### Sekreter Paneli
- **Giriş Yapma**: Sekreterler sisteme giriş yapabilir.
- **Randevu Yönetimi**: Randevu oluşturma, görüntüleme ve güncelleme.
- **Duyuru Oluşturma**: Sistem geneline duyurular oluşturabilir.
- **Doktor ve Branş Yönetimi**: Yeni doktor ve branş ekleme, var olanları güncelleme.
- **Randevu Listesi**: Günlük randevu listesini görüntüleyebilir.

## Kullanılan Teknolojiler
- **C# WinForms**: Kullanıcı arayüzü için.
- **SQL**: Veritabanı işlemleri için.
- **ADO.NET**: C# ile SQL veritabanı arasındaki bağlantı için.
  
## Kurulum
1. Bu projeyi GitHub'dan klonlayın:
   ```bash
   [git clone https://github.com/kullaniciadi/hastane-yonetim-sistemi.git](https://github.com/aliayass/Proje_Hastane.git)

## !!Projeyi çalıştırmak için SqlBaglantisi.cs class'ında bulunan, SqlConnection nesnesinde kendi veri tabanınıza bağlamanız gerekir.

