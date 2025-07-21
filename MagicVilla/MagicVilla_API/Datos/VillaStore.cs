using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public  static class VillaStore
    {
        public static List<VillaDto> VillaList = new List<VillaDto>
        {
            new VillaDto { Id=10, Nombre="nombre10"},
            new VillaDto { Id=20, Nombre="nombre20"}
        };
    }
}
