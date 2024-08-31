# FoodOrderFormApplication
Bu depo, bir Windows Forms uygulaması ve bu uygulamayı destekleyen SQL veritabanı betiklerini içerir. Uygulama, basit bir yemek sipariş sistemi simülasyonu yapmak üzere tasarlanmıştır ve kullanıcıların yemek kategorilerini, spesifik yemekleri, porsiyon boyutlarını ve ekstra malzemeleri seçmesine olanak tanır.

## İçerik
- **Form1.cs:** Uygulamanın iş mantığını içeren C# kodu.
- **Form1.Designer.cs:** Uygulamanın kullanıcı arayüzünü tanımlayan C# kodu.
- **Veritabanı Betiği (SQL):** Uygulamanın çalışması için gerekli olan MySQL veritabanı yapılandırma ve veri ekleme işlemlerini içeren SQL betiği.

## Özellikler
- **ComboBox Etkileşimi:** 
  - İlk ComboBox, kullanıcının bir yemek kategorisi (örneğin, Fast Food, İtalyan Mutfağı) seçmesine olanak tanır.
  - Seçilen kategoriye bağlı olarak, ikinci ComboBox'ta mevcut yemekler dinamik olarak listelenir.
- **Yemek Seçimi:** 
  - Seçilen yemekler TextBox'ta görüntülenir ve sipariş özeti için bir ListBox'a eklenir.
- **Porsiyon Boyutları ve Ekstralar:**
  - Kullanıcılar porsiyon boyutunu (Küçük, Orta, Büyük) seçebilir ve ekstra malzemeler (örneğin, Peynir, Soğan, Sarımsak) ekleyebilir.
  - Uygulama, bir porsiyon boyutu seçilmeden siparişin tamamlanamayacağını garanti eder.
- **Sipariş Özeti:**
  - Uygulama, seçilen yemekleri, porsiyon boyutunu ve ekstraları özetler ve kullanıcıya siparişi Önceki Siparişler ListBox'ına kaydetme imkanı sunar.
  - Sipariş gönderildikten sonra yeni bir seçim için sipariş temizlenir ve sıfırlanır.

## Veritabanı Kurulumu
MySQL veritabanı şu şekilde yapılandırılmalıdır:
1. `YemekSiparisiDB` adında bir veritabanı oluşturun.
2. Sağlanan SQL betiğini kullanarak `YemekKategorileri` ve `Yemekler` tablolarını oluşturun.
3. Çeşitli yemek kategorileri ve yemekleri içeren örnek verilerle tabloları doldurun.

### SQL Betiği
SQL betiği, bu depo içerisinde SQL dosyası olarak sağlanmıştır.

## Nasıl Çalıştırılır

1. Depoyu klonlayın.
2. Sağlanan SQL betiğini kullanarak MySQL veritabanını kurun.
3. Visual Studio'da `Form1.cs` ve `Form1.Designer.cs` dosyalarını içeren çözümü açın.
4. Uygulamayı çalıştırın. Form, yemek kategorilerini, yemekleri, porsiyon boyutlarını ve ekstraları seçme seçenekleriyle yüklenecektir.
