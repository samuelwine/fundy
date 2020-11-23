using System;

namespace Fundy.Core.Records
{
    public record Address
    {
        private string _line1;
        public string Line1
        {
            get { return _line1; }
            init
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Line 1 cannot be empty");
                _line1 = value;
            }
        }

        public string Line2 { get; init; }
        public string Line3 { get; init; }

        private string _city;
        public string City
        {
            get { return _city; }
            init 
            {
                if(string.IsNullOrWhiteSpace(value)) throw new Exception("City cannot be empty");
                _city = value; 
            }
        }
        
        public string County_Province { get; init; }

        private string _postcode_zip;
        public string Postcode_Zip
        {
            get { return _postcode_zip; }
            init 
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Postcode_Zip cannot be empty");
                _postcode_zip = value; 
            }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            init 
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Country cannot be empty");
                _country = value; 
            }
        }
    }
}