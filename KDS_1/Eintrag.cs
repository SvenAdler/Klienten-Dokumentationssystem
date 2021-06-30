namespace KDS_1
{
    public class Eintrag
    {
        public long Eintrag_ID { get; }
        public string Gespraech { get; }
        public long FK_Nutzer_ID { get; }
        public string Nutzername { get; }
        public long FK_Klient_ID { get; }

        public Eintrag(long eintrag_id, string gespraech, long fk_nutzer_id, string nutzername/*, long fk_klient_id*/)
        {
            Eintrag_ID = eintrag_id;
            Gespraech = gespraech;
            FK_Nutzer_ID = fk_nutzer_id;
            Nutzername = nutzername;
            //FK_Klient_ID = fk_klient_id;
        }

        public override string ToString()
        {
            return $"{Eintrag_ID} {Nutzername}";
        }
    }
}
