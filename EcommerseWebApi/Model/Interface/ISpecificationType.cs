using EcommerseWebApi.Model.Table;

namespace EcommerseWebApi.Model.Interface
{
    public interface ISpecificationType
    {
        CommMessage_Modal Add(SpecificationType p);
        CommMessage_Modal Edit(SpecificationType p);
        CommMessage_Modal Delete(SpecificationType p);
        List<SpecificationType> List(string srch);
    }
}
