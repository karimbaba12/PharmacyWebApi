using UMS_BLL.Wrapping;

namespace UMS_BLL.Services.GenericServices
{
    public interface IGenericService<Dto> where Dto : class
    {
ApiResponse<IEnumerable<Dto>> GetAll();
/*ApiResponse<Task<IEnumerable<Dto>>> GetAllAsync();*/
ApiResponse<Dto >GetById(int id);
ApiResponse<Dto >Add(Dto faculty);
ApiResponse<Dto >Update(Dto faculty);
ApiResponse<bool >Delete(int id);
ApiResponse<bool> Delete(Dto faculty);
    }
}
