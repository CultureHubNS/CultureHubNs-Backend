using System.Threading.Tasks;


namespace Application.Interfaces
{
    public interface IFacebookAccessor
    {
         Task<FacebookUserInfo> FacebookLogin(string accessToken);
    }
}