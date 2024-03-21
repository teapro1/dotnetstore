using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareForFinal.BSLayer
{
    public class TemDetail
    {
        public float amount;
        public float price;
        public string pname;
        public float total;

        public TemDetail()
        {

        }

        public TemDetail(float amount, float price, string pname, float total)
        {
            this.amount = amount;
            this.price = price;
            this.pname = pname;
            this.total = total;
        }
        public String[] ToString()
        {
            String[] result = new String[4];
            result[0] = this.pname;
            result[1] = this.amount.ToString();
            result[2] = this.price.ToString();
            result[3] = this.total.ToString();
            return result;
        }
    }
}
