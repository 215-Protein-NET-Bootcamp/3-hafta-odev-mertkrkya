using System.Threading.Tasks;

namespace JWTProject.Core
{
    public interface IUnitofWork
    {
        Task CommitAsync();
        void Commit();
    }
}