namespace Proyecto_Escuela_v1.Services
{
    public interface ICommonService<T, TI, TU>
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
        Task<T> Add(TI InsertDto);
        Task<T> Update(int id, TU UpdateDto);
        Task<T> Delete(int id);
    }
}
