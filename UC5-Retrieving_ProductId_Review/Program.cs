// See https://aka.ms/new-console-template for more information
using UC5_Retrieving_ProductId_Review;

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

}
        
    


