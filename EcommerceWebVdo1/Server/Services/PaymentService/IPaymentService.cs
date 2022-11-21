using EcommerceWebVdo1.Shared;
using Stripe.Checkout;

namespace EcommerceWebVdo1.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}
