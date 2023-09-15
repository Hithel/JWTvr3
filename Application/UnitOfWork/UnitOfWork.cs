using Application.Repository;
using Domain.Interfaces;
using Persistence;
namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly JwtAppContext _context;
    private IRolRepository _roles;
    private IUserRepository _users;
    private IProducto _producto;
    private IMarca _marca;
    private ICategoria _categoria;
    public UnitOfWork(JwtAppContext context)
    {
        _context = context;
    }
    public IRolRepository Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RolRepository(_context);
            }
            return _roles;
        }
    }

    public IUserRepository Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public IProducto Productos
    {
        get
        {
            if (_producto == null)
            {
                _producto = new ProductoRepository(_context);
            }
            return _producto;
        }
    }

    public IMarca Marcas
    {
        get
        {
            if (_marca == null)
            {
                _marca = new MarcaRepository(_context);
            }
            return _marca;
        }
    }

    public ICategoria Categorias
    {
        get
        {
            if (_categoria == null)
            {
                _categoria = new CategoriaRepository(_context);
            }
            return _categoria;
        }
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
