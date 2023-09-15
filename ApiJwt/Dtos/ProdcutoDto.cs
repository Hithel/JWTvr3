

namespace ApiJwt.Dtos;
    public class ProdcutoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public MarcaDto Marca { get; set; }
        public CategoriaDto Categoria{ get; set; }
    }
