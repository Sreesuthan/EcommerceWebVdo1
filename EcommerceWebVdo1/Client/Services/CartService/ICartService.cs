using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Client.Services.CartService
{
	public interface ICartService
	{
		event Action OnChange;
		Task AddToCart(CartItem item);
		Task<List<CartItem>> GetCartItems();
		Task DeleteItem(CartItem item);
		Task EmptyCart();
		Task<string> Checkout(); 
	}
}
