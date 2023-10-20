using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class InvetarioDto
{
    public int Id { get; set; }
    public string CodInv { get; set; }
    public double ValorVtaCop { get; set; }
    public double ValorVtaUsd { get; set; }
    public int IdPrendaFk { get; set; }
}
