using Starcounter;

namespace Muhammad
{
    partial class CompanyJson : Json
    {
        Response AdddressReponse = Self.GET("/Muhammad/Address/GetAddress");
        static CompanyJson()
        {
            DefaultTemplate.Address.Bind = null;
            DefaultTemplate.Sales.ElementType.InstanceType = typeof(SaleJson);
        }
        void Handle(Input.NewSaleTrigger action)
        {
            new Sale()
            {
                Company = this.Data as Company,
                Address = (Address) Address,
                Transaction = (Transaction) Sales.Transaction,
            };
        }
    }
}
