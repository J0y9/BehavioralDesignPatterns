namespace ChainOfResponsibility;

public class HardwareHandler: ITicketHandler
{
    public ITicketHandler NextTicketHandler { get; set; }
    

    public  void HandelTicket(string request)
    {
        if (request.ToLower() == "hardware")
        {
            Console.WriteLine(nameof(HardwareHandler));
            
        }

        else if(NextTicketHandler != null)
        {
            NextTicketHandler.HandelTicket(request);
        }
    }

}