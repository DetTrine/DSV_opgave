namespace dsv_mini.Bookingsystem
{
    public class Bookingsystem
    {
        public string Organizer { get; private set; } 

        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public string Comment { get; private set; } = string.Empty;


        public Bookingsystem(string organizer, DateTime starttime, DateTime endtime, string comment)
        {
            Organizer = organizer;
            StartTime = starttime;
            EndTime = endtime;
            Comment = comment;
        }
    }
    
}
