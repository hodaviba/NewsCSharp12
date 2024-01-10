

//--------------------- HR ---------------------

var person = new HRPerson(1, "John", Role.Boss);
var daysWorked = 20;
var payemntProcessor = new Processor();

var payment = payemntProcessor.CalculatePayment((person.Role, daysWorked));

Console.WriteLine($"Payment ID {payment.guid}, Total: {payment.calculation}");


//--------------------- SALES ---------------------

var customer = new SalesPerson(1, "John", "Address", CustomerType.Gold);

var products = new List<BaseProduct>()
{
    new Product1() { Price = 10 },
    new Product2() { Price = 20 },
    new Product3() { Price = 30 }
};

var engine = new QuotationEngine();
engine.GenerateQuotation((products, customer.Type, true));