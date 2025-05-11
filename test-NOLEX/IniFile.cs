using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Xml.Linq;
using test_NOLEX;
using static System.Collections.Specialized.BitVector32;

public static class IniFile
{
    public static Boolean LoadIniFile(string filePath)
    {        
        try
        {
            if (!File.Exists(filePath))
            {
                //throw new FileNotFoundException($"Il file .ini non è stato trovato: {filePath}");
                return false;
            }

            string currentSection = null;

            // Usa using per garantire la chiusura del file
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string trimmedLine = line.Trim();

                    // Ignora righe vuote o commenti
                    if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith("#"))
                        continue;

                    // Rileva una sezione
                    if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                    {
                        currentSection = trimmedLine.Trim('[', ']');
                        continue;
                    }

                    // Rileva una chiave-valore
                    if (trimmedLine.Contains("=") && currentSection != null)
                    {
                        var parts = trimmedLine.Split('=', 2);
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        //#Deve essere effettuata una verifica di congruità del tipo per ogni stringa di configurazione.
                        // Se il valore non contiene virgolette verificare che sia un intero
                        if (value.Contains('"')) // è una stringa
                        {
                            value = value.Trim('"');
                            // Applica il valore alla classe statica corrispondente
                            CaricaValoreIni(currentSection, key, value);
                        }
                        else if (int.TryParse(value, out int intValue))
                        {
                            value = intValue.ToString(); // Converte il valore in stringa
                                                         // Applica il valore alla classe statica corrispondente
                            CaricaValoreIni(currentSection, key, value);
                        }
                    }
                }
            }
            
            return true;
        }
        catch (Exception ex)
        {
            
            return false;
        }
    }

    private static void CaricaValoreIni(string section, string key, string value)
    {
        // Usa reflection per trovare la classe statica corrispondente
        var sectionType = Type.GetType($"test_NOLEX.Predefiniti_{section}");
        if (sectionType == null)
            return; // Sezione non riconosciuta, ignorala

        var property = sectionType.GetProperty(key);
        if (property == null || !property.CanWrite)
            return; // Chiave non riconosciuta o non scrivibile, ignorala

        // Converte il valore al tipo della proprietà
        object convertedValue = Convert.ChangeType(value, property.PropertyType);
        property.SetValue(null, convertedValue);
    }

    public static Boolean SaveIniFile(string filePath)
    {
        try {
            // Usa using per garantire la chiusura del file
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("[Predefiniti_StampaServer]");
                writer.WriteLine("StampaServerEnabled = 1");
                writer.WriteLine("PartiCorpo = 3");

                writer.WriteLine("[Predefiniti_Archivio]");
                writer.WriteLine("# Percorso SQL");
                writer.WriteLine("ArchivioPath = \"CLEARCANVAS64PC\\IMAGESERVER2\"");
                writer.WriteLine("CatalogName = \"FastprintProDoca\"");
                writer.WriteLine("#MaxStorageDays = 1000");
                writer.WriteLine("MaxStorageDaysCheckInterval = 10");

                writer.WriteLine($"[Predefiniti_Ricerca]");
                writer.WriteLine($"Ambulatorio = \"{Predefiniti_Ricerca.Ambulatorio}\"");
                writer.WriteLine($"PartiCorpo = \"{Predefiniti_Ricerca.PartiCorpo}\"");
                writer.WriteLine($"Esame = \"{Predefiniti_Ricerca.Esame}\"");
                writer.WriteLine($"FiltroCI = \"{Predefiniti_Ricerca.FiltroCI.Trim()}\"");
                writer.WriteLine($"FiltroCM = \"{Predefiniti_Ricerca.FiltroCM.Trim()}\"");
                writer.WriteLine($"FiltroDescrizione = \"{Predefiniti_Ricerca.FiltroDescrizione.Trim()}\"");

            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }
}
