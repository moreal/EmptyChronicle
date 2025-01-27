using EmptyChronicle.Domain.Model.States;

namespace EmptyChronicle.Application.States;

public class StatesApplication
{
    private readonly IStatesRepository StatesRepository;

    public StatesApplication(IStatesRepository statesRepository)
    {
        StatesRepository = statesRepository;
    }

    public State? GetStateByAddress(string address, string? accountAddress = null)
    {
        return accountAddress is null
            ? StatesRepository.GetStateByAddress(address)
            : StatesRepository.GetStateByAddress(address, accountAddress);
    }
}
