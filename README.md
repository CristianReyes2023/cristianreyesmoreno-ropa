# README

###### EndPoints

The following are the endpoints of the Entities included in the TiendaRopa product.

### PAIS

GET:

```csharp
http://localhost:5055/apiropa/Pais'
[
  {
    "id": 1,
    "nombrePais": "Colombia"
  },
  {
    "id": 2,
    "nombrePais": "Peru"
  },
  {
    "id": 3,
    "nombrePais": "Brasil"
  }
   {
      "id": 5,
      "nombrePais": "Benezuela"
   }
]
```

POST

Auto-incrementing PK data entry

```csharp
{
  "nombrePais": "Brasil"
}
```

GET {id}

Search for elements by Id

```csharp
http://localhost:5055/apiropa/Pais/3
{
  "id": 3,
  "nombrePais": "Brasil"
}
```

PUT

Data update

```csharp
http://localhost:5055/apiropa/Pais/5
{
  "id": 5,
  "nombrePais": "Venezuela"
}
```

Delete

```csharp
curl -X 'DELETE' \
  'http://localhost:5055/apiropa/Pais/6' \
  -H 'accept: */*'
```

#### DEPARTAMENTO

GET:



```csharp
http://localhost:5055/apiropa/Departamento
[
  {
    "id": 1,
    "nombreDepartamento": "Santander",
    "idPaisFk": 1
  },
  {
    "id": 3,
    "nombreDepartamento": "Arauca",
    "idPaisFk": 1
  },
  {
    "id": 4,
    "nombreDepartamento": "Atlantico",
    "idPaisFk": 1
  },
  {
    "id": 5,
    "nombreDepartamento": "Nariño",
    "idPaisFk": 1
  }
]
```

POST

Auto-incrementing PK data entry

```csharp
http://localhost:5055/apiropa/Departamento
{
  "id": 3,
  "nombreDepartamento": "Arauca",
  "idPaisFk": 1
}
```

GET {id}

Search for elements by Id

```csharp
http://localhost:5055/apiropa/Departamento/4
{
  "id": 4,
  "nombreDepartamento": "Atlantico",
  "idPaisFk": 1
}
```

PUT

Data update

```csharp
http://localhost:5055/apiropa/Departamento/4
{
  "id": 4,
  "nombreDepartamento": "Norte de Santander",
  "idPaisFk": 1
}
```

Delete

```csharp
curl -X 'DELETE' \
  'http://localhost:5055/apiropa/Departamento/4' \
  -H 'accept: */*'

http://localhost:5055/apiropa/Departamento/4
```



#### INSUMO

GET:

```csharp
http://localhost:5055/apiropa/Insumo
[
  {
    "id": 1,
    "nombrePais": "Colombia"
  },
  {
    "id": 2,
    "nombrePais": "Peru"
  },
  {
    "id": 3,
    "nombrePais": "Brasil"
  }
   {
      "id": 5,
      "nombrePais": "Benezuela"
   }
]
```

POST

Auto-incrementing PK data entry

```csharp
http://localhost:5055/apiropa/Pais/3
{
  "id": 3,
  "nombreInsumo": "Jeans",
  "valorUnit": 80000,
  "stockMin": 15,
  "stockMax": 60
}
```

GET {id}

Search for elements by Id

```csharp
http://localhost:5055/apiropa/Insumo/2
{
  "id": 2,
  "nombreInsumo": "Blusas",
  "valorUnit": 50000,
  "stockMin": 15,
  "stockMax": 50
}
```

PUT

Data update

```csharp
http://localhost:5055/apiropa/Insumo/3
{
  "id": 3,
  "nombreInsumo": "Sacos",
  "valorUnit": 10000,
  "stockMin": 15,
  "stockMax": 60
}
```

Delete

```csharp
curl -X 'DELETE' \
  'http://localhost:5055/apiropa/Insumo/4' \
  -H 'accept: */*'

 http://localhost:5055/apiropa/Insumo/4
```

#### EMPRESA

GET:

```csharp
http://localhost:5055/apiropa/Empresa
[
  {
    "id": 2,
    "nit": "12453-56",
    "razonSocial": "Venta Tela",
    "representanteLegal": "Juan Reyes",
    "fechaCreacion": "2013-10-20",
    "idMunicipioFk": 1
  },
  {
    "id": 3,
    "nit": "14563-56",
    "razonSocial": "Diseño de modas",
    "representanteLegal": "Jose Moreno",
    "fechaCreacion": "2015-10-20",
    "idMunicipioFk": 1
  },
  {
    "id": 4,
    "nit": "3454554-56",
    "razonSocial": "Comercializadora",
    "representanteLegal": "Pepe Martinez",
    "fechaCreacion": "2005-10-20",
    "idMunicipioFk": 1
  }
]
```

POST

Auto-incrementing PK data entry

```csharp
http://localhost:5055/apiropa/Empresa/3
{
  "nit": "12453-56",
  "razonSocial": "Venta Tela",
  "representanteLegal": "Juan Reyes",
  "fechaCreacion": "2013-10-20",
  "idMunicipioFk": 1
}
```

GET {id}

Search for elements by Id

```csharp
http://localhost:5055/apiropa/Empresa/3
{
  "id": 3,
  "nit": "14563-56",
  "razonSocial": "Marroquineria",
  "representanteLegal": "Jose Moreno",
  "fechaCreacion": "2015-10-20",
  "idMunicipioFk": 1
}
```

PUT

Data update

```csharp
http://localhost:5055/apiropa/Empresa/3
{
  "id": 3,
  "nit": "14563-56",
  "razonSocial": "Diseño de modas",
  "representanteLegal": "Jose Moreno",
  "fechaCreacion": "2015-10-20",
  "idMunicipioFk": 1
}
```

Delete

```csharp
curl -X 'DELETE' \
  'http://localhost:5055/apiropa/Empresa/4' \
  -H 'accept: */*'

http://localhost:5055/apiropa/Empresa/4
```

#### PRENDA

GET:

```csharp
http://localhost:5055/apiropa/Prenda
[
  {
    "id": 1,
    "idPrenda": 45,
    "nombrePrenda": "Blusa con escote",
    "valorUnitCop": 80000,
    "valorUnitUsd": 20,
    "idEstadoFk": 1,
    "idTipoProteccion": 1,
    "idGeneroFk": 1
  },
  {
    "id": 3,
    "idPrenda": 55,
    "nombrePrenda": "Blusa Azul y sin manga",
    "valorUnitCop": 90000,
    "valorUnitUsd": 25,
    "idEstadoFk": 1,
    "idTipoProteccion": 1,
    "idGeneroFk": 1
  },
  {
    "id": 4,
    "idPrenda": 65,
    "nombrePrenda": "Saco Azul de lana",
    "valorUnitCop": 150000,
    "valorUnitUsd": 45,
    "idEstadoFk": 1,
    "idTipoProteccion": 1,
    "idGeneroFk": 1
  }
]
```

POST

Auto-incrementing PK data entry

```csharp
http://localhost:5055/apiropa/Prenda/3
{
  "id": 3,
  "idPrenda": 55,
  "nombrePrenda": "Blusa con mangas",
  "valorUnitCop": 100000,
  "valorUnitUsd": 25,
  "idEstadoFk": 1,
  "idTipoProteccion": 1,
  "idGeneroFk": 1
}
```

GET {id}

Search for elements by Id

```csharp
http://localhost:5055/apiropa/Prenda/3
{
  "id": 3,
  "idPrenda": 55,
  "nombrePrenda": "Blusa con mangas",
  "valorUnitCop": 100000,
  "valorUnitUsd": 25,
  "idEstadoFk": 1,
  "idTipoProteccion": 1,
  "idGeneroFk": 1
}
```

PUT

Data update

```csharp
http://localhost:5055/apiropa/Prenda/3
{
  "id": 3,
  "idPrenda": 55,
  "nombrePrenda": "Blusa Azul y sin manga",
  "valorUnitCop": 90000,
  "valorUnitUsd": 25,
  "idEstadoFk": 1,
  "idTipoProteccion": 1,
  "idGeneroFk": 1
}
```

Delete

```csharp
curl -X 'DELETE' \
  'http://localhost:5055/apiropa/Prenda/4' \
  -H 'accept: */*'

http://localhost:5055/apiropa/Prenda/4
```

#### INVENTARIO

GET:

```csharp
[
  {
    "id": 1,
    "codInv": "35460",
    "valorVtaCop": 2500000,
    "valorVtaUsd": 550,
    "idPrendaFk": 1
  },
  {
    "id": 2,
    "codInv": "546460",
    "valorVtaCop": 3500000,
    "valorVtaUsd": 750,
    "idPrendaFk": 1
  },
  {
    "id": 3,
    "codInv": "435553",
    "valorVtaCop": 10000000,
    "valorVtaUsd": 3350,
    "idPrendaFk": 1
  }
]
```

POST

Auto-incrementing PK data entry

```csharp
http://localhost:5055/apiropa/Inventario/2
{
  "codInv": "546460",
  "valorVtaCop": 3500000,
  "valorVtaUsd": 750,
  "idPrendaFk": 1
}
```

GET {id}

Search for elements by Id

```csharp
http://localhost:5055/apiropa/Inventario/2
{
  "id": 2,
  "codInv": "546460",
  "valorVtaCop": 3500000,
  "valorVtaUsd": 750,
  "idPrendaFk": 1
}
```

PUT

Data update

```csharp
http://localhost:5055/apiropa/Inventario/2

{
  "id": 2,
  "codInv": "546460",
  "valorVtaCop": 5000000,
  "valorVtaUsd": 1200,
  "idPrendaFk": 1
}
```

Delete

```csharp
curl -X 'DELETE' \
  'http://localhost:5055/apiropa/Inventario/3' \
  -H 'accept: */*'

http://localhost:5055/apiropa/Inventario/3
```

