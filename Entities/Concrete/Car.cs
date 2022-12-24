using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        // Id
        public int CarId { get; set; }
        // Marka Id
        public int BrandId { get; set; }
        // Renk Id
        public int ColorId { get; set; }
        // Model Yılı
        public int ModelYear { get; set; }
        // Günlük Fiyat
        public decimal DailyPrice { get; set; }
        // Açıklama
        public string Description { get; set; }
    }
}
