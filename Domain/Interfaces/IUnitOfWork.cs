namespace Domain.Interfaces;

public interface IUnitOfWork
{
    IRolRepository Roles { get; }
    IUserRepository Users { get; }
    IProducto Productos { get; }
    IMarca Marcas { get; }
    ICategoria Categorias { get; }
    Task<int> SaveAsync();
}
