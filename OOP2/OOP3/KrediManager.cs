using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Her bir class icin ayni baslik(Hesapla()) kullanmak istiyoruz; ama icerigi farkli olacaksa Interface kullaniriz.
    interface IKrediManager
    {
        void Hesapla();
        void BirseyYap();
    }
}
