using Starcounter;

namespace Muhammad
{
    partial class SaleJson : Json
    {
        static SaleJson()
        {
            DefaultTemplate.Address.Bind = null;
            DefaultTemplate.Transaction.Bind = null;

        }
    }
}
