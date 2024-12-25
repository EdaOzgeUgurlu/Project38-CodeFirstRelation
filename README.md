# Proje 38 - CodeFirst İlişki Yönetimi 👨‍💻📊

Bu proje, Entity Framework Core kullanarak basit bir kullanıcı ve post veritabanı yönetimini içeren bir uygulamadır. Veritabanı ile iletişim kurmak için **Code First** yaklaşımı kullanılmıştır. Ayrıca, kullanıcı ekleme ve silme işlemleri gibi temel veritabanı işlemleri de yapılmaktadır.

## İçerik 📚
- Kullanıcı yönetimi (Ekleme, Silme)
- Post yönetimi (Başlık ve İçerik ekleme)
- Veritabanı bağlantısı ve yönetimi
- Basit bir menü arayüzü

## Kullanılan Teknolojiler 🛠️
- **C#** 🖥️
- **Entity Framework Core** 💻
- **PostgreSQL** 📊
- **.NET 6/7** 🔥

## Başlangıç 🚀

Projeyi çalıştırmak için aşağıdaki adımları takip edebilirsiniz.

### 1. Gerekli Paketlerin Yüklenmesi 📦

Proje, **Entity Framework Core** ve **Npgsql** paketlerini kullanır. İlk olarak bu paketleri yüklemek için aşağıdaki komutu kullanabilirsiniz:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

### 2. Veritabanı Bağlantısı 🔌

Veritabanı bağlantısı için `PatikaSecondDbContext` sınıfındaki aşağıdaki satırda gerekli bağlantı bilgilerini girmeniz gerekiyor:

```csharp
optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=123456eda;Database=PatikaCodeFirstDb2");
```

### 3. Veritabanı Bağlantısını Kontrol Etme 🧑‍💻

Uygulama başladığında, veritabanı bağlantısı kontrol edilecek ve başarılı olup olmadığına dair bir mesaj gösterilecektir.

### 4. Uygulama Kullanımı 🖱️

Uygulama, kullanıcı ekleme ve silme işlemleri yapmak için basit bir menü arayüzü sunar.

#### Menü:
- **1. Yeni User Ekle**: Yeni bir kullanıcı ekler.
- **2. User Sil**: Var olan bir kullanıcıyı siler.

Her işlem sonrası işlemi başarıyla gerçekleştiren bir mesaj görüntülenir.

## Veritabanı Yapısı 🗂️

Projede iki ana tablo bulunmaktadır:

- **User**: Kullanıcı bilgilerini tutar (Username, Email)
- **Post**: Kullanıcıya ait postları tutar (Başlık, İçerik)

## Veri Örneği 📊

Başlangıç verisi olarak aşağıdaki kullanıcılar ve postlar eklenmiştir:

- **Kullanıcılar**:
    - Ferdi Tayfur (ferdi01adana@gmail.com)
    - Kamuran Akkor (kamurannkoor@gmail.com)
    - Neşet Ertaş (nesedertask@gmail.com)

- **Postlar**:
    - Aşk (Ferdi Tayfur)
    - Özlem (Neşet Ertaş)
    - Umut (Kamuran Akkor)
    - İsyan (Kamuran Akkor)
