namespace Module18.Builder;

internal class ProductBuiler : IBuilder
{
    Product product = new Product();
    public void FirstStage()
    {
        product.Add("Part one");
    }

    public Product GetBuildingResult()
    {
        return product;
    }

    public void SecondStage()
    {
        product.Add("Part two");
    }

    public void ThirdStage()
    {
        product.Add("Part three");
    }
}
