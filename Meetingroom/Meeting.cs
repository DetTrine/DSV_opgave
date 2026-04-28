namespace dsv_mini.Meetingroom;

public class Meeting
{
    public string Name { get; set; }

    public int NumberOfSeats { get; set; }
    
    public string Mail { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    public string Room { get; set; }
    
    public string Description { get; set; }
    
    public int Id { get; set; }
    
    private static int MeetingCounter = 0;

    public Meeting(string name, int numberOfSeats, string room, string description)
    {
        Name = name;
        NumberOfSeats = numberOfSeats;
        Room = room;
        Description = description;
        Id =  MeetingCounter++;
    }

    public Meeting(string mail, DateTime startTime, DateTime endTime ,string name , int numberOfSeats, string room, string description) 
    : this ( name, numberOfSeats, room, description)
    {
        Mail = mail;
        StartTime = startTime;
        EndTime = endTime;
    }







}