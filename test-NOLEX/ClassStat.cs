namespace test_NOLEX
{
    public static class Predefiniti_StampaServer
    {
        public static int StampaServerEnabled { get; set; } = 0;
        public static int UpdateInterval { get; set; } = 5;
    }

    public static class Predefiniti_Archivio
    {
        public static string ArchivioPath { get; set; } = "";
        public static string CatalogName { get; set; } = "";
        public static int MaxStorageDaysCheckInterval { get; set; } = 0;
    }

    public static class Predefiniti_Ricerca
    {
        public static string Ambulatorio { get; set; } = "";
        public static string PartiCorpo { get; set; } = "";
        public static string Esame { get; set; } = "";
        public static string FiltroCI { get; set; } = "";
        public static string FiltroCM { get; set; } = "";
        public static string FiltroDescrizione { get; set; } = "";
    }

}


