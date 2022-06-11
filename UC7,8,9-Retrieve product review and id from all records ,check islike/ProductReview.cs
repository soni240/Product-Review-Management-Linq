using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_8_9_Retrieve_product_review_and_id_from_all_records__check_islike
{
    public class ProductReview
    {
        public int productId { get; set; }
        public int userId { get; set; }
        public int rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}

