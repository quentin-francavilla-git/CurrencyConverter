using CurrencyConverter.ViewModels;
using CurrencyConverter.Services;
using CurrencyConverter.Helpers;
using CurrencyConverter.Models;
using System.Drawing.Text;

namespace CurrencyConverter;

public partial class CurrencyConverter : Form
{
    private MainViewModel? ViewModel;

    public CurrencyConverter()
    {
        InitializeComponent();
        InitializeViewModel();
        LoadAndUseFont();
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

    private void LoadAndUseFont()
    {
        // Load the embedded font resource
        PrivateFontCollection privateFonts = new PrivateFontCollection();

        string fontPath = "Resources/Fonts/Poppins-Bold.ttf"; // Adjust the path accordingly

        // Load the custom font file
        privateFonts.AddFontFile(fontPath);

        // Create a Font object using the custom font from the PrivateFontCollection
        Font PoppinsBold = new Font(privateFonts.Families[0], 12f, FontStyle.Bold);

        // Set the custom font

        // Labels
        titleLabel.Font = PoppinsBold;
        amountLabel.Font = PoppinsBold;
        toLabel.Font = PoppinsBold;
        fromLabel.Font = PoppinsBold;
        resultLabel.Font = PoppinsBold;

        // Buttons
        ConvertButton.Font = PoppinsBold;

        // Textboxes
        sourceAmountTextBox.Font = PoppinsBold;

        // Dropdown menu
        sourceCurrencycomboBox.Font = PoppinsBold;
        targetCurrencycomboBox.Font = PoppinsBold;
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
