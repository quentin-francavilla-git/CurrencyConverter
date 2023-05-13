using CurrencyConverter.ViewModels;
using CurrencyConverter.Services;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using CurrencyConverter.Models;
using System.ComponentModel;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CurrencyConverter.Helpers;

namespace CurrencyConverter;

public partial class CurrencyConverter : Form
{
    private MainViewModel? ViewModel;

    public CurrencyConverter()
    {
        InitializeComponent();
        InitializeViewModel();
        CurrencyConverter_Load(); // On load method for components
        ConvertButton.Click += delegate { ConvertButton_ClickAsync(); };
        refreshButton.Click += delegate { RefreshButton_ClickAsync(); };
    }

    private void InitializeViewModel()
    {
        IExchangeCurrencyService exchangeRateService = new ExchangeCurrencyService();
        ViewModel = new MainViewModel(exchangeRateService); // Injecting ExchangeCurrencyService in ViewModel

        DataBindingsHelper.Bind(ViewModel, sourceAmountTextBox, resultLabel, sourceCurrencycomboBox, targetCurrencycomboBox);
    }

    // Events Handling

    private async void ConvertButton_ClickAsync()
    {
        try
        {
            ConvertButton.Enabled = false; // Disable the button

            await ViewModel.ConvertAmount();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred during the convertion");
        }
        finally
        {
            ConvertButton.Enabled = true; // Enable the button
        }
    }

    private async void RefreshButton_ClickAsync()
    {
        try
        {
            ConvertButton.Enabled = false; // Disable the button

            CurrencyConverter_Load();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred during the convertion");
        }
        finally
        {
            ConvertButton.Enabled = true; // Enable the button
        }
    }

    private async void CurrencyConverter_Load()
    {
        await Task.Run(async () =>
        {
            List<string> currenciesList = await ViewModel.GetCurriencies();

            Invoke((MethodInvoker)(() =>
            {
                // Clear the ComboBox in case it already has items
                sourceCurrencycomboBox.Items.Clear();
                targetCurrencycomboBox.Items.Clear();


                // Add items from the list to the ComboBox
                sourceCurrencycomboBox.Items.Add("Currency 1");
                targetCurrencycomboBox.Items.Add("Currency 2");

                sourceCurrencycomboBox.Items.AddRange(currenciesList.ToArray());
                targetCurrencycomboBox.Items.AddRange(currenciesList.ToArray());

                sourceCurrencycomboBox.SelectedIndex = 0;
                targetCurrencycomboBox.SelectedIndex = 0;
            }));
        });
    }
}
