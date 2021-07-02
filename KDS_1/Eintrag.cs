using System;

namespace KDS_1
{
    public class Eintrag
    {
        public long Eintrag_ID { get; }
        public string Gespraech { get; }
        public DateTime DatumEintrag { get; }
        public long FK_Nutzer_ID { get; }
        public string Nutzername { get; }

        public Eintrag(long eintrag_id, string gespraech, DateTime datumEintrag, long fk_nutzer_id, string nutzername)
        {
            Eintrag_ID = eintrag_id;
            Gespraech = gespraech;
            DatumEintrag = datumEintrag;
            FK_Nutzer_ID = fk_nutzer_id;
            Nutzername = nutzername;
        }

        public override string ToString()
        {
            return $"{DatumEintrag:dd/MM/yyyy HH:mm} - [{Nutzername}]";
        }
    }
}
