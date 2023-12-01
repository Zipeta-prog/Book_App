using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_SYSTEM.Models
{
    internal class Orders
    {
        public String id {  get; set; }
        public String userId {  get; set; }
        public String bookId {  get; set; }
    }


    /*
      {
          "id": 1,
          "userId": 1,
          "bookId": 1
        }
     */
}
