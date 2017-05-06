using System;
using System.Collections;
using Starcounter;

namespace Muhammad
{
    [Database]
    public class Agency
    {
        public string Name;
        public QueryResultRows<Company> Companies => Db.SQL<Company>("SELECT c FROM Muhammad.Company c WHERE c.Agency = ?", this);
    }
    [Database]
    public class Address
    {
        public string Street;
        public string Number;
        public string Zip;
        public string City;
        public string Country;

        public static implicit operator Address(Json v)
        {
            throw new NotImplementedException();
        }
    }
    [Database]
    public class Transaction
    {
        public string Date;
        public double SalesPrice;
        public double Commission;
    }
    [Database]
    public class Company
    {
        public Agency Agency;
        public string Name;
        public Address Address;
        public QueryResultRows<Sale> Sales => Db.SQL<Sale>("SELECT s FROM Muhammad.Sale s WHERE s.Company = ?", this);
    }
    [Database]
    public class Sale
    {
        public Company Company;
        public Address Address;
        public Transaction Transaction;
    }
    class Program
    {
        static void Main()
        {

            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/Muhammad/Address/GetAddress", () =>
            {
                return new AddressJson();
            });

            Handle.GET("/Muhammad", () =>
            {
                return Db.Scope(() =>
                {
                    var agency = Db.SQL<Agency>("SELECT a FROM Agency a").First;
                    var json = new AgencyJson
                    {
                        Data = agency
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });
            });
       }

    }
}