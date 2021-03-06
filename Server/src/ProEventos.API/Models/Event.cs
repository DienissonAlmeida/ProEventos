namespace ProEventos.API.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public string Local { get; set; }

        public string EventDate { get; set; }

        public string Tema { get; set; }

        public int QuantityPeoples { get; set; }

        public string Lote { get; set; }

        public string UrlImage { get; set; }
    }
}