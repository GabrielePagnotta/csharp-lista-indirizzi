public class Utente
{
    public Utente(string  nome, string surname,string street, string city, string province, string zIP)
    {
        Nome = nome;
        Surname = surname;
        City = city;
        Province = province;
        ZIP = zIP;
    }

    public string  Nome { get; init; }
    public string Surname { get; init; }

    public string ? Street { get; init; }
    public string City { get; init; }
    public string Province { get; init; }
    public string ZIP { get; init; }
}