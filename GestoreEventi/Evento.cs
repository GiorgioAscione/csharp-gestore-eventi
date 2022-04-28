namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        public int postiPrenotati;
        private DateTime data;
        public int postiTotali;


        public Evento(string titolo, int postiTotali, DateTime data)
        {
            SetTitolo(titolo);
            SetData(data);
            this.data = data;
            this.postiPrenotati = 0;
            if (postiPrenotati > 1)
            {
                throw new Exception("Il numero di posti totali inserito non è corretto");
            }
            this.postiTotali = postiTotali;
        }

        public string GetTitolo()
        {
            return titolo;
        }

        public void SetTitolo(string titolo)
        {
            if (titolo == "" || titolo.Length == null)
            {
                throw new ArgumentException("Il titolo inserito non è corretto");
            }
            this.titolo = titolo;
        }

        public DateTime GetData()
        {
            return data;
        }

        public void SetData(DateTime data)
        {
            if (data < DateTime.Now)
            {
                throw new ArgumentException("La data inserita è antecedente alla data consentita");
            }
            this.data = data;
        }

        public int PostiDisponibili()
        {
            return postiTotali - postiPrenotati;
        }

        public int PostiPrenotati()
        {
            return postiPrenotati;
        }

        public void PrenotaPosto()
        {
            if (postiPrenotati >= postiTotali)
            {
                throw new Exception("I posti disponibili sono esauriti");
            }

            if (data < DateTime.Now)
            {
                throw new Exception("L'evento è già passato");
            }
            postiPrenotati++;
        }

        public void PrenotaPosti(int posti)
        {
            if (postiPrenotati + posti > postiTotali)
            {
                throw new Exception("Non posso prenotare tutti questi posti");
            }
            if (data < DateTime.Now)
            {
                throw new Exception("L'evento è già passato");
            }

            postiPrenotati += posti;
        }


    }
}