using System.Net.Http.Headers;

namespace Module18.Builder;

internal interface IBuilder
{
    void FirstStage();
    void SecondStage();
    void ThirdStage();
    Product GetBuildingResult();
}
