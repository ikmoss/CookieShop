namespace CookieShopCore.Domain.Cookies
{
    public interface ICookie
    {
        int CookingTemp { get; }
        string Name { get; }
        bool CanEat { get; }
        bool IsBurnt(int ovenTemp);
        void SetCanEat(bool canEat);
    }
}