using dsv_mini.Meetingroom;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsv_mini.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
    }
    
    public List<Meeting> Meetings { get; set; }

    private readonly ILogger<IndexModel> _logger;
    
    public IndexModel(ILogger<IndexModel> logger,MeetingService service)
    {
        _logger = logger;
        Meetings = service.GetAll();

    }
    

    public void OnPost()
    {
        
    }

}