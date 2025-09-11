# OgrenciOtomasyonSistemi
Sistem, Admin, Teacher ve Student olmak üzere üç farklı kullanıcı rolünü destekler. Yöneticiler sistemi yönetebilirken, öğretmenler ders ve öğrenci bilgilerini yönetebilir, öğrenciler ise kendi bilgilerini görüntüleyebilir.

Proje, modern yazılım geliştirme pratikleri göz önünde bulundurularak "Clean Code" prensiplerine uygun bir şekilde geliştirilmiştir. Backend ve Frontend katmanları birbirinden bağımsız olarak çalışacak şekilde tasarlanmıştır.

Kullanılan Teknolojiler
Backend: .NET 9, ASP.NET Core Web API

Veritabanı: PostgreSQL

ORM: Entity Framework Core

Frontend: Blazor

Güvenlik: ASP.NET Core Identity & JWT (JSON Web Tokens)

Versiyon Kontrol: Git & GitHub

Gereksinimler
.NET 9 SDK

PostgreSQL

Git

Visual Studio 2022 veya IDE

Veritabanı Bağlantısı: backend/OgrenciOtomasyonSistemi.api/appsettings.json dosyasını açın. ConnectionStrings bölümündeki Password alanını kendi PostgreSQL şifrenizle değiştirin.

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=OgrenciDb;Username=postgres;Password=YOUR_POSTGRES_PASSWORD"
},

Veritabanını Oluşturma: Terminali backend/OgrenciOtomasyonSistemi.api klasöründe açın ve Entity Framework Core migration komutunu çalıştırarak veritabanını ve tabloları oluşturun:

dotnet ef database update

Uygulamayı Çalıştırma : Projenin ana dizinindeki OgrenciOtomasyonSistemi.sln çözüm dosyasını Visual Studio 2022 ile açın.

Kullanıcı Test Bilgileri
Uygulama ilk kez çalıştığında, DataSeeder tarafından aşağıdaki test kullanıcısı otomatik olarak oluşturulur. Sistemi test etmek için bu bilgileri kullanabilirsiniz.

Rol: Admin

Email: admin@test.com

Parola: Password123!

Diğer roller (Teacher, Student) için kayıt ekranından yeni kullanıcılar oluşturabilirsiniz.

Yapılmaya çalışılan bonus görevler
Bu projede, zorunlu gereksinimlere ek olarak aşağıdaki bonus görevler yapılmaya çalışılmıştır:

UI/UX İyileştirmeleri
Kullanıcı Arama ve Filtreleme
