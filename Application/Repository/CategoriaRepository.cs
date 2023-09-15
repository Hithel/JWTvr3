

using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

public class CategoriaRepository : GenericRepository<Categoria>, ICategoria
{
    private readonly JwtAppContext _context;

    public CategoriaRepository(JwtAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _context.Categorias
            .Include(p => p.Productos)
            .ToListAsync();
        }

        public override async Task<Categoria> GetByIdAsync(int id)
        {
            return await _context.Categorias
            .Include(p => p.Productos)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
}
