using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal interface ILokasyon
    {
        int Id { get; set; }
        string Ulke { get; set; }
        string Sehir { get; set; }
        string Havalimani { get; set; }
    }
}
