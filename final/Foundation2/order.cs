using System;
class Order
{
    private Product[] _products;
    private Customer _customer;

    public Order(Customer customer, Product[] products)
    {
        _customer = customer;
        _products = products;
    }

    public float GetTotalPrice()
    {
        float subtotal = 0;
        foreach (var product in _products)
        {
            subtotal += product.GetPrice() * product.GetQuantity();
        }
        float shippingCost = _customer.GetAddress().IsInUSA() ? 5f : 35f;
        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        var label = ($"Packing Label:\n");        
        foreach (var product in _products)
        {
            label += ($"{product.GetName()} ({product.GetID()})\n");
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return ($"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().ToString()}");
    }
}