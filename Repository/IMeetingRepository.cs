using dsv_mini.Meetingroom;

namespace dsv_mini.Repository;

public interface IMeetingRepository
{
    public List<Meeting> GetAll();

    public Meeting GetById(int id);

    


    
    
    
    
}