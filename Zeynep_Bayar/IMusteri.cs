using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal interface IMusteri
    {
        int Id { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        string EPosta { get; set; }
        string Telefon { get; set; }
        bool Engelli { get; set; }
    }
}
