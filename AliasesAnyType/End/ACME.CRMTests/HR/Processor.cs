namespace ACME.CRMTests.HR.BL;

internal class Processor
{
    public PaymentResult CalculatePayment(ProcessorInput data)
    {
        return data.role switch
        {
            Role.Boss => ((string guid, double calculation))(Guid.NewGuid().ToString(), data.daysWorked * 100),
            Role.Employee => ((string guid, double calculation))(Guid.NewGuid().ToString(), data.daysWorked * 50),
            _ => ((string guid, double calculation))("N/A", 0),
        };
    }
}
