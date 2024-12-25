using Project38_CodeFirstRelation.Data;

anamenu:
using (var db = new PatikaSecondDbContext())
{
    foreach (User user in db.Users)
    {
        Console.WriteLine($"{user.Username} {user.Email}");
    }
}
Console.WriteLine(@"
1. Yeni User Ekle
2. User Sil
");

Console.Write("Yapacağınız işlemin nosunu giriniz: ");
string tercih = Console.ReadLine();

if (tercih == "1")
{

            using (var db = new PatikaSecondDbContext())
        {
            User user = new User();
            db.Users.Add(user);
            db.SaveChanges();

            Console.WriteLine("Başarıyla eklendi.");
            goto anamenu;
        }
}
else if (tercih == "2")
{
    Console.Write("Silinecek User'ın Nosu: ");
    int id = Convert.ToInt32(Console.ReadLine());

    using (var db = new PatikaSecondDbContext())
    {
        User? user = db.Users.Find(id);

        if (user == null)
        {
            MesajGoster("Belirttiğiniz no ile ilişkili bir user bulunamadı.");
            goto anamenu;
        }

        db.Users.Remove(user);
        db.SaveChanges();

        MesajGoster("Belirttiğiniz user başarıyla silindi.");
        goto anamenu;
    }
}
else
{
    Console.WriteLine("Geçersiz seçim!");
}
void MesajGoster(string mesaj)
{
    Console.Clear();
    Console.WriteLine("### " + mesaj + " ###");
    Console.WriteLine();
}