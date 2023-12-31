using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Entities;
public class Proveedor : BaseEntity
{
    public string NitProveedor { get; set; }
    public string NombreProveedor { get; set; }
    public int IdTipoPersonaFK { get; set; }
    public TipoPersona TipoPersonas { get; set; }
    public int IdMunicipioFk { get; set; }
    public Municipio Municipios { get; set; }
    public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
}   
