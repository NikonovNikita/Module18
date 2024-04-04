namespace Module18.Builder;

internal class BuildManager
{
    IBuilder builder;

    public BuildManager(IBuilder builder)
    {
        this.builder = builder;
    }

    public void StartBuildingProcess()
    {
        builder.FirstStage();
        builder.SecondStage();
        builder.ThirdStage();
    }

    public Product GetBuildingResult()
    {
        return builder.GetBuildingResult();
    }

}
