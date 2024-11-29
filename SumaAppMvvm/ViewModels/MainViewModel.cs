using System.ComponentModel;
using System.Windows.Input;

namespace SumaAppMvvm.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _value1; 
        private string _value2; 
        private string _resultado = ""; 

        public string Value1
        {
            get => _value1;
            set
            {
                _value1 = value;
                OnPropertyChanged(nameof(Value1));
            }
        }

        public string Value2
        {
            get => _value2;
            set
            {
                _value2 = value;
                OnPropertyChanged(nameof(Value2));
            }
        }

        public string Resultado
        {
            get => _resultado;
            set
            {
                _resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        
        public ICommand SumarCommand { get; }
        public ICommand LimpiarCommand { get; }

        
        public MainViewModel()
        {
            
            SumarCommand = new Command(OnSumar);
            LimpiarCommand = new Command(OnLimpiar);
        }

        
        private void OnSumar()
        {
            
            if (string.IsNullOrWhiteSpace(Value1) || string.IsNullOrWhiteSpace(Value2))
            {
                Resultado = "Por favor, ingrese ambos valores.";
                return;
            }

            
            if (double.TryParse(Value1, out double num1) && double.TryParse(Value2, out double num2))
            {
                Resultado = $"El resultado es: {num1 + num2}";
            }
            else
            {
                Resultado = "Valores inválidos. Ingrese números válidos.";
            }
        }

        
        private void OnLimpiar()
        {
            
            Value1 = string.Empty;
            Value2 = string.Empty;
            Resultado = string.Empty;
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
