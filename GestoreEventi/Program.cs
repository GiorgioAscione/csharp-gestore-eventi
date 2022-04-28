using GestoreEventi;

Console.WriteLine("----GESTIONE EVENTI-----");

Evento primoEvento = null;
while (primoEvento == null)
{
    Console.WriteLine("Inserisci il nome dell' evento: ");
    string titolo = Console.ReadLine();
    Console.WriteLine("Inserisci la data dell' evento (gg/mm/aaaa): ");
    string dataString = Console.ReadLine();
    DateTime data = DateTime.Parse(dataString);
    Console.WriteLine("Inserisci il numero di posti totali: ");
    int posti = int.Parse(Console.ReadLine());
    primoEvento = new Evento(titolo, posti, data);
}

Console.WriteLine("Quanti posti vuoi prenotare?");
int numeroPrenotazioni = int.Parse(Console.ReadLine());

Console.WriteLine();

primoEvento.PrenotaPosti(numeroPrenotazioni);

Console.WriteLine("Numero di posti prenotati = " + primoEvento.PostiPrenotati());
Console.WriteLine("Numero di posti disponibili = " + primoEvento.PostiPrenotati());







