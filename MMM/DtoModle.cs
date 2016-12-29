using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMM
{
    public class DtoModle
    {
        public static TOut Mapper<Tin, TOut>(Tin inObj)

        {
            var outObj = Activator.CreateInstance<TOut>();

            var OutType = typeof(TOut);

            var inObjs = typeof(Tin).GetProperties();

            foreach (var obj in inObjs)

            {
                var vIn = obj.GetValue(inObj);

                var pOut = OutType.GetProperty(obj.Name);
                try
                {

                    if (pOut == null) continue;
                    if (vIn == null)
                    {
                        pOut = null;  
                        continue;
                    }
                    var unPout = Nullable.GetUnderlyingType(pOut.PropertyType);
                    var vOut = Convert.ChangeType(vIn, unPout ?? pOut.PropertyType);

                    pOut.SetValue(outObj, vOut);
                }
                catch (Exception ex)
                {
                    pOut = null;
                    continue;
                }

            }

            return outObj;
        }
    }

    public class BookStoreDto
    {
        public string Name { get; set; }

        public DateTime? CreateTime { get; set; }

        public decimal? Amount { get; set; }

        public string ID { get; set; }

        public int? Age { get; set; }

        public string Address { get; set; }
    }

    public class BookStore
    {
        public string Name { get; set; }

        public DateTime? CreateTime { get; set; }

        public decimal? Amount { get; set; }

        public int ID { get; set; }

        public int? Age { get; set; }

        public string BeginAddress { get; set; }
    }
}
