using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Democard.Entities
{
    public class GpaOrders
    {
        // implements IDisposable interface
        private string _user_token;
        private decimal _amount; // field
        private string _currency_code; // field
        private string _funding_source_token; // field

        public decimal amount   // property
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string currency_code   // property
        {
            get { return _currency_code; }
            set { _currency_code = value; }
        }
        public string funding_source_token   // property
        {
            get { return _funding_source_token; }
            set { _funding_source_token = value; }
        }

        public string user_token   // property
        {
            get { return _user_token; }
            set { _user_token = value; }
        }
  

    }
}
