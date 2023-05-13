using Bunifu.UI.WinForms;
using CurrencyConverter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Helpers;

public class DataBindingsHelper
{
    public static void Bind(MainViewModel ViewModel, BunifuTextBox sourceAmountTextBox, Label resultLabel, BunifuDropdown sourceCurrencyComboBox, BunifuDropdown targetCurrencyComboBox)
    {
        // Input
        sourceAmountTextBox.DataBindings.Add(
            "Text",
            ViewModel,
            nameof(ViewModel.SourceAmount),
            true,
            DataSourceUpdateMode.OnPropertyChanged);

        // Result
        resultLabel.DataBindings.Add(
            "Text",
            ViewModel,
            nameof(ViewModel.Result),
            true,
            DataSourceUpdateMode.Never);

        // Currency Boxes
        sourceCurrencyComboBox.DataBindings.Add(
            "SelectedItem",
            ViewModel,
            nameof(ViewModel.SourceCurrency),
            true,
            DataSourceUpdateMode.OnPropertyChanged);

        targetCurrencyComboBox.DataBindings.Add(
            "SelectedItem",
            ViewModel,
            nameof(ViewModel.TargetCurrency),
            true,
            DataSourceUpdateMode.OnPropertyChanged);
    }
}
