using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El Campo Código es obligatorio")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El Campo Nombre es obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El Campo Rol es obligatorio")]
    public string Rol { get; set; }
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }
}
