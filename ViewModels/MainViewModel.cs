using CurrencyConverter.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CurrencyConverter.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly IExchangeCurrencyService _exchangeCurrencyService;
    private decimal _sourceAmount;
    private string  _sourceCurrency;
    private string _targetCurrency;

    public decimal SourceAmount
    {
        get { return _sourceAmount; }
        set
        {
            _sourceAmount = value;
            OnPropertyChanged();
        }
    }

    public string SourceCurrency
    {
        get { return _sourceCurrency; }
        set
        {
            _sourceCurrency = value;
            OnPropertyChanged();
        }
    }

    public string TargetCurrency
    {
        get { return _targetCurrency; }
        set
        {
            _targetCurrency = value;
            OnPropertyChanged();
        }
    }

    public decimal Result { get; set; }

    public MainViewModel(IExchangeCurrencyService exchangeCurrencyService)
    {
        _exchangeCurrencyService = exchangeCurrencyService;
    }

    public async Task ConvertAmount()
    {
        Result = await _exchangeCurrencyService.ConvertAmountCommand(SourceAmount, SourceCurrency, TargetCurrency);
        OnPropertyChanged(nameof(Result));
    }

    public async Task<List<string>> GetCurriencies()
    {
        return await _exchangeCurrencyService.GetCurrenciesQuery();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
