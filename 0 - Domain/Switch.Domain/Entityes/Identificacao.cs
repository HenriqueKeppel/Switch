using Switch.Domain.Enums;

namespace Switch.Domain.Entityes
{
    public class Identificacao
    {
        public int Id { get; set; }
        public TipoDocumentoEnum TipoDocumento { get; set; }
        public string Numero { get; set; }
        public int UsuarioId { get; set; }
        
        //Propriedade de navegação
        public virtual Usuario Usuario { get; set; }
    }
}
