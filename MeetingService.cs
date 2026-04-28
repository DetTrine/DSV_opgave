using dsv_mini.Meetingroom;
using dsv_mini.Repository;

namespace dsv_mini;

public class MeetingService
{
    private readonly IMeetingRepository _meetingRepository;

    public MeetingService(IMeetingRepository repo)
    {
        _meetingRepository = repo;
        
    }

    public List<Meeting> GetAll()
    {
        return _meetingRepository.GetAll();
    }
    public Meeting GetMeeting(int id)
    {
        return _meetingRepository.GetById(id);
    }
    
}