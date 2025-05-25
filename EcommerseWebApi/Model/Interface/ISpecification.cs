using EcommerseWebApi.Model.Table;

namespace EcommerseWebApi.Model.Interface
{
    public interface ISpecification
    {
        CommMessage_Modal Add(Specification p);
        CommMessage_Modal Edit(Specification p);
        CommMessage_Modal Delete(Specification p);
        List<Specification> List(string srch);

    }
}
