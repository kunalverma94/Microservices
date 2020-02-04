using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1
{
    public interface Idata
    {
       string getdata();
    }
    public class data : Idata
    {
        private int w = 99;
        private string t = "";

        public data(string t)
        {
            this.t = t;
            this.w = new Random().Next();
        }
        public string getdata()
        {
            return t+"  :"+w;
        }
    }
}
