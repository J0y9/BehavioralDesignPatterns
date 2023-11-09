namespace StatePattern;

public class VendingMachine
{
    private IState _state;

    public VendingMachine(IState state)
    {
        _state = state;
    }


    public void SetState(IState state)
    {
        _state = state;
    }

    public void InsertMoney()
    {
        _state.InsertMoney();
        if (_state is Ready)
        {
            SetState(new Selecting());
        }
    }

    public void SelectItem()
    {
        _state.SelectItem();
        if (_state is Selecting)
        {
            SetState(new Dispensing());
        }
    }

    public void DispenseItem()
    {
        _state.DispenseItem();
        if (_state is Dispensing)
        {
            SetState(new Ready());
        }
    }
    
}