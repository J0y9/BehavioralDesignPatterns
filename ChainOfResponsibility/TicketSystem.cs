namespace ChainOfResponsibility;

public class TicketSystem
{
    private ITicketHandler _handler;

    public TicketSystem(ITicketHandler handler)
    {
        _handler = handler;
    }

    public void HandleTicket(string request)
    {
        _handler.HandelTicket(request);
    }
}