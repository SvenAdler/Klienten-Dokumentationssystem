namespace KDS_1
{
    public class Nutzer
    {
        public long ID { get; }
        public string Vorname { get; }
        public string Nachname { get; }
        public string Mailadresse { get; }
        public string Arztnummer { get; }

        public Nutzer(long id, string vorname, string nachname, string mailadresse, string arztnummer)
        {
            ID = id;
            Vorname = vorname;
            Nachname = nachname;
            Mailadresse = mailadresse;
            Arztnummer = arztnummer;
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname} - Arztnr.: {Arztnummer}";
        }
    }
}
