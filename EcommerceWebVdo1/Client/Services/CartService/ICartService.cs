using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Client.Services.CartService
{
	public interface ICartService
	{
		event Action OnChange;
		Task AddToCart(ProductVariant ProductVariant);
		Task<List<CartItem>> GetCartItems();
		Task DeleteItem(CartItem item);
	}
}
