using Starcounter;

namespace Muhammad
{
    partial class AgencyJson : Json
    {
        static AgencyJson()
        {
            DefaultTemplate.Companies.ElementType.InstanceType = typeof(CompanyJson);
        }

        void Handle(Input.SaveTrigger action)
        {
            Transaction.Commit();
        }

        void Handle(Input.AddNewCompanyTrigger action)
        {
            new Company()
            {
                Agency = this.Data as Agency,
                Name = "",
                Address = new Address(),
            };
        }

    }
}
