using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal interface IUcus
    {
        int Id { get; set; }
        string UcusNo { get; set; }
        int KalkisLokasyonu { get; set; }
        int VarisLokasyonu { get; set; }
        DateTime UcusTarihi { get; set; }
    }
}
