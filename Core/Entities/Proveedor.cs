using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Proveedor : BaseEntity
{
    public string NitProveedor { get; set; }
    public string NombreProveedor { get; set; }
    public int MyProperty { get; set; }
}   
