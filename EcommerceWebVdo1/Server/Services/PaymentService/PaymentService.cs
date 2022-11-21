using Azure;
using EcommerceWebVdo1.Shared;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;

namespace EcommerceWebVdo1.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51M6VuGSEVEH46znALqeCQfXrgUc0MGnhBdKS7ewLLvQCFszM7zlwm325krHsNNPI8QTxEXhohUzhC7K3Fsm76LLZ00sQ5cdMKf";
        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "inr",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name=ci.ProductTitle,
                        Images= new List<string> { ci.Image}
                    },
                },
                Quantity= ci.Quantity,
            }));
            var options = new SessionCreateOptions
            {
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:7158/order-success",
                CancelUrl = "https://localhost:7158/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }
    }
}
