using AreaCirculoAppMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AreaCirculoAppMVVM.ViewModels
{
    public class CirculoViewModel : INotifyPropertyChanged
    {
        private double Radio;
        private double Area;

        public double GetRadio()
        {
            return GetRadio();
        }

        public void SetRadio(double value)
        {
            if (GetRadio() != value)
            {
                SetRadio(value);
                OnPropertyChanged();
            }
        }

        public double GetArea()
        {
            return GetArea();
        }

        private void SetArea(double value)
        {
            if (GetArea() != value)
            {
                SetArea(value);
                OnPropertyChanged();
            }
        }
        public ICommand CalcularAreaCommand { get; }
        public ICommand LimpiarCommand { get; }

        public CirculoViewModel()
        {
            CalcularAreaCommand = new Command(CalcularArea);
            LimpiarCommand = new Command(Limpiar);
        }

        private void CalcularArea()
        {
            SetArea(CirculoModel.PI * GetRadio() * GetRadio());
        }

        private void Limpiar()
        {
            SetRadio(0);
            SetRadio(0);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
