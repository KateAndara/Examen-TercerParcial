using Modelos;

namespace Examen.Interfaces;

public interface IUsuarioServicio
{
    Task<Usuario> GetPorCodigo(string codigo);
}
