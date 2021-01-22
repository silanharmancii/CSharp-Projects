using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    {
        // tüm krediler hesaplama işlemini farklı ele alır
        // imzanın(Calculation) olduğu ama içerisinin farklı olduğu durumlarda interface oluşturulur.
        // interface kullanan sınıf, interface'e ait metodları kullanmak zorundadır.
        // interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        void Calculation(); 
        
    } 

}
