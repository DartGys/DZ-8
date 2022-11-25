interface IApplyDiscount
{
    void ApplyDiscount(String discount);
}

interface IApplyPromocode
{
    void ApplyPromocode(String promocode);
}

interface ISetColor
{
    void SetColor(byte color);
}

interface ISetSize
{
    void SetSize(byte size);
}

interface ISetPrice
{
    void SetPrice(double price);
}

class Book
{
    double BookPrice;
    string BookDiscount;
    
    void Price(ISetPrice price)
    {
        price.SetPrice(BookPrice);
    }

    void Discount(IApplyDiscount discount)
    {
        discount.ApplyDiscount(BookDiscount);
    }
}

class Clothes
{
    byte ClothesSize;
    string ClothePromocode;
 

    void Size(ISetSize size)
    {
        size.SetSize(ClothesSize);
    }

    void Promocode(IApplyPromocode promocode)
    {
        promocode.ApplyPromocode(ClothePromocode);
    }
}
