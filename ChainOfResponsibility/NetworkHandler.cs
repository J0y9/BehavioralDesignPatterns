namespace ChainOfResponsibility;

public class NetworkHandler : ITicketHandler
{
    public ITicketHandler NextTicketHandler { get; set; }

    public void HandelTicket(string request)
    {
        if (request.ToLower() == "network")
        {
            Console.WriteLine(nameof(NetworkHandler));

        }

        else if(NextTicketHandler != null)
        {
            NextTicketHandler.HandelTicket(request);
        }
    }
}