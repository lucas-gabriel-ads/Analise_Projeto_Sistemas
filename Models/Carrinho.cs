namespace proj_lucas.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

    }
}