// See https://aka.ms/new-console-template for more information

using Product_Review_Management;

Console.WriteLine("Prodcut Review Management!!!!!!!!");
Console.WriteLine("Adding a Prodcut Review In list");
Console.WriteLine("Enter Option");
int option = Convert.ToInt32(Console.ReadLine());
//Creating a list for Product Review
List<ProductReview> productReviews = new List<ProductReview>();
switch (option)
{
    case 1:
        ProductReviewManager.AddingProductReview(productReviews);
        break;
    case 2:
        ProductReviewManager.RetrieveTopThreeRating(productReviews);
        break;
    case 3:
        ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
        break;
    case 4:
        ProductReviewManager.CountingProductId(productReviews);
        break;
    case 5:
        ProductReviewManager.RetrieveOnlyProductIdAndReviews(productReviews);
        break;
    case 6:
        ProductReviewManager.SkipTopFiveRecords(productReviews);
        break;
    case 7:
        ProductReviewManager.AddingProductReview(productReviews);
        ProductReviewManager.CreateDataTable(productReviews);
        break;
    case 8:
        //DataTable dt = new DataTable();
        //ProductReviewManager.AverageOfRating(dt);
        //break;
        ProductReviewManager.ReturnsOnlyIsLikeFieldAsTrue();
        ProductReviewManager.AverageOfRating();
        break;
    case 9:
        ProductReviewManager.ReturnsReviewMessageContainsGood();
        break;
}


        
    


