using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesProyecto
{
    class Compra
    {

        #region atributos
        private int compra { get; set; }
        private int Elemento { get; set; }
        private int serie { get; set; }
        private int cantidad { get; set; }
        private int valor { get; set; }
        private double total { get; set; }

        #endregion
        #region Metodos
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                if( total == value)
                {
                    return;
                }
                OnPropertyChanged();
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (cantidad == value)
                {
                    return;
                }
                OnPropertyChanged();
            }
        }

        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (valor == value)
                {
                    return;
                }
                OnPropertyChanged();
            }
        }
        #endregion

    }
}
