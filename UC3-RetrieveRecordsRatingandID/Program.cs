﻿// See https://aka.ms/new-console-template for more information

using UC3_RetrieveRecordsRatingandID;

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

}
        
    
