export interface Cliente {
  id:                      number;
  razonSocial:             string;
  idTipoCliente:           number;
  rfc:                     string;
  idTipoClienteNavigation: IDTipoClienteNavigation;
}

export interface IDTipoClienteNavigation {
  tipoCliente: string;
}
