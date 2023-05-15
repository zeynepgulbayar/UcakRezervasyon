using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal interface IRezervasyon
    {
        int Id { get; set; }
        int MusteriId { get; set; }
        int KoltukNo { get; set; }
        int UcusId { get; set; }
        int Ucret { get; set; }
    }
}
