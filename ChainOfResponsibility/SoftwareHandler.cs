namespace ChainOfResponsibility;

public class SoftwareHandler : ITicketHandler
{
    public ITicketHandler NextTicketHandler { get; set; }

    public void HandelTicket(string request)
    {
        if (request.ToLower() == "software")
        {
            Console.WriteLine(nameof(SoftwareHandler));
            
        }

        else if(NextTicketHandler != null)
        {
            NextTicketHandler.HandelTicket(request);
        }

    }
}