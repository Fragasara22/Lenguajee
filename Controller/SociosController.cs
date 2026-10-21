using Model;
using Service;

namespace Controller
{
    public class SociosController
    {
        public SocioService _sociosService = new SocioService();

        public List<Socios> listarSocios()
        {
            return _sociosService.listarSocios();
        }

        public List<Socios> filtrarSocios(string filtro)
        {
            return _sociosService.filtrarSocios(filtro);
        }

        public bool guardarSocio(Socios socio, int _accion, int _id_socio)
        {
            return _sociosService.guardarSocio(socio, _accion, _id_socio);
        }

        public List<Localidad> CargarComboLocalidades()
        {
            return this._sociosService.CargarComboLocalidades();
        }


    }
}
