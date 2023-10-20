using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entitie;

namespace Core.Entities;
public class Cliente : BaseEntity
{
    public string IdCliente { get; set; }
    public string NombreCliente { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona TipoPersonas { get; set; }
    public int IdMunicipioFK { get; set; }
    public Municipio Municipios { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
}   