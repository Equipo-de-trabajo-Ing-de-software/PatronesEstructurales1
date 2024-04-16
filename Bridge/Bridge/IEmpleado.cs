
namespace Bridge
{
   public interface IEmpleado 
    {
        string Nombre { get;  }
        string Posicion { get; }
        int Salario { get; }

        void VerDetalleEmpleado();
    }
}
