using Agenda.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Dominio.DataObject
{
    public class TipoEndereco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Residencia
        {
            get { return Id == (int)EnumTipoEndereco.Residencial; }
        }
        public bool EBuffet
        {
            get { return Id == (int)EnumTipoEndereco.Buffet; }
        }
        public bool EComercio
        {
            get { return Id == (int)EnumTipoEndereco.Comercial; }
        }
        public bool EGalpão
        {
            get { return Id == (int)EnumTipoEndereco.Galpão; }
        }

    }
}
