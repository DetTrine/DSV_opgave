using dsv_mini.Meetingroom;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsv_mini.Pages;

public class Details : PageModel
{
    public Meeting mt { get; set; }

    private MeetingService _meetingService;

    public Details(MeetingService ms)
    {
        _meetingService = ms;
    }

    public void OnGet(int id)
    {
        mt = _meetingService.GetMeeting(id);
    }
}