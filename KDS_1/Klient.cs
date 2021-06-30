using System;

namespace KDS_1
{
    public class Klient
    {
        public long ID { get; }
        public string Vorname { get; }
        public string Nachname { get; }
        public DateTime Geburtsdatum { get; }
        public string Klientennr { get; }
        public long Erstgespraech_ID { get; }

        public Klient(long id, string vorname, string nachname, DateTime geburtsdatum, string klientennr, long erstgespraech_id)
        {
            ID = id;
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Klientennr = klientennr;
            Erstgespraech_ID = erstgespraech_id;
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname} (geb. {Geburtsdatum:dd/MM/yyyy}) - Klientennr.: {Klientennr}";
        }
    }
}
