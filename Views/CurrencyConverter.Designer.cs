namespace CurrencyConverter;

partial class CurrencyConverter
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConverter));
        Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
        Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
        Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
        Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
        Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
        Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
        resultLabel = new Label();
        sourceCurrencycomboBox = new Bunifu.UI.WinForms.BunifuDropdown();
        ConvertButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
        targetCurrencycomboBox = new Bunifu.UI.WinForms.BunifuDropdown();
        sourceAmountTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
        bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
        titleLabel = new Bunifu.UI.WinForms.BunifuLabel();
        amountLabel = new Bunifu.UI.WinForms.BunifuLabel();
        fromLabel = new Bunifu.UI.WinForms.BunifuLabel();
        toLabel = new Bunifu.UI.WinForms.BunifuLabel();
        refreshButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
        logoImageButton = new Bunifu.UI.WinForms.BunifuImageButton();
        SuspendLayout();
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Font = new Font("Poppins", 13F, FontStyle.Bold, GraphicsUnit.Point);
        resultLabel.Location = new Point(346, 241);
        resultLabel.Margin = new Padding(4, 0, 4, 0);
        resultLabel.Name = "resultLabel";
        resultLabel.RightToLeft = RightToLeft.No;
        resultLabel.Size = new Size(31, 37);
        resultLabel.TabIndex = 2;
        resultLabel.Text = "0";
        // 
        // sourceCurrencycomboBox
        // 
        sourceCurrencycomboBox.BackColor = Color.Transparent;
        sourceCurrencycomboBox.BackgroundColor = Color.White;
        sourceCurrencycomboBox.BorderColor = Color.Silver;
        sourceCurrencycomboBox.BorderRadius = 10;
        sourceCurrencycomboBox.Color = Color.Silver;
        sourceCurrencycomboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
        sourceCurrencycomboBox.DisabledBackColor = Color.FromArgb(240, 240, 240);
        sourceCurrencycomboBox.DisabledBorderColor = Color.FromArgb(204, 204, 204);
        sourceCurrencycomboBox.DisabledColor = Color.FromArgb(240, 240, 240);
        sourceCurrencycomboBox.DisabledForeColor = Color.FromArgb(109, 109, 109);
        sourceCurrencycomboBox.DisabledIndicatorColor = Color.DarkGray;
        sourceCurrencycomboBox.DrawMode = DrawMode.OwnerDrawFixed;
        sourceCurrencycomboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
        sourceCurrencycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        sourceCurrencycomboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
        sourceCurrencycomboBox.FillDropDown = true;
        sourceCurrencycomboBox.FillIndicator = false;
        sourceCurrencycomboBox.FlatStyle = FlatStyle.Flat;
        sourceCurrencycomboBox.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
        sourceCurrencycomboBox.ForeColor = Color.Black;
        sourceCurrencycomboBox.FormattingEnabled = true;
        sourceCurrencycomboBox.Icon = null;
        sourceCurrencycomboBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
        sourceCurrencycomboBox.IndicatorColor = Color.DarkGray;
        sourceCurrencycomboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
        sourceCurrencycomboBox.IndicatorThickness = 2;
        sourceCurrencycomboBox.IsDropdownOpened = false;
        sourceCurrencycomboBox.ItemBackColor = Color.White;
        sourceCurrencycomboBox.ItemBorderColor = Color.White;
        sourceCurrencycomboBox.ItemForeColor = Color.Black;
        sourceCurrencycomboBox.ItemHeight = 26;
        sourceCurrencycomboBox.ItemHighLightColor = Color.DodgerBlue;
        sourceCurrencycomboBox.ItemHighLightForeColor = Color.White;
        sourceCurrencycomboBox.ItemTopMargin = 3;
        sourceCurrencycomboBox.Location = new Point(346, 176);
        sourceCurrencycomboBox.Name = "sourceCurrencycomboBox";
        sourceCurrencycomboBox.Size = new Size(110, 32);
        sourceCurrencycomboBox.TabIndex = 9;
        sourceCurrencycomboBox.Text = null;
        sourceCurrencycomboBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
        sourceCurrencycomboBox.TextLeftMargin = 5;
        // 
        // ConvertButton
        // 
        ConvertButton.AllowAnimations = true;
        ConvertButton.AllowMouseEffects = true;
        ConvertButton.AllowToggling = false;
        ConvertButton.AnimationSpeed = 200;
        ConvertButton.AutoGenerateColors = false;
        ConvertButton.AutoRoundBorders = false;
        ConvertButton.AutoSizeLeftIcon = true;
        ConvertButton.AutoSizeRightIcon = true;
        ConvertButton.BackColor = Color.Transparent;
        ConvertButton.BackColor1 = Color.FromArgb(253, 70, 92);
        ConvertButton.BackgroundImage = (Image)resources.GetObject("ConvertButton.BackgroundImage");
        ConvertButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        ConvertButton.ButtonText = "CONVERT";
        ConvertButton.ButtonTextMarginLeft = 0;
        ConvertButton.ColorContrastOnClick = 45;
        ConvertButton.ColorContrastOnHover = 45;
        borderEdges1.BottomLeft = true;
        borderEdges1.BottomRight = true;
        borderEdges1.TopLeft = true;
        borderEdges1.TopRight = true;
        ConvertButton.CustomizableEdges = borderEdges1;
        ConvertButton.DialogResult = DialogResult.None;
        ConvertButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
        ConvertButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
        ConvertButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
        ConvertButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
        ConvertButton.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
        ConvertButton.ForeColor = Color.White;
        ConvertButton.IconLeftAlign = ContentAlignment.MiddleLeft;
        ConvertButton.IconLeftCursor = Cursors.Default;
        ConvertButton.IconLeftPadding = new Padding(11, 3, 3, 3);
        ConvertButton.IconMarginLeft = 11;
        ConvertButton.IconPadding = 10;
        ConvertButton.IconRightAlign = ContentAlignment.MiddleRight;
        ConvertButton.IconRightCursor = Cursors.Default;
        ConvertButton.IconRightPadding = new Padding(3, 3, 7, 3);
        ConvertButton.IconSize = 25;
        ConvertButton.IdleBorderColor = Color.Transparent;
        ConvertButton.IdleBorderRadius = 40;
        ConvertButton.IdleBorderThickness = 1;
        ConvertButton.IdleFillColor = Color.FromArgb(253, 70, 92);
        ConvertButton.IdleIconLeftImage = null;
        ConvertButton.IdleIconRightImage = null;
        ConvertButton.IndicateFocus = false;
        ConvertButton.Location = new Point(128, 236);
        ConvertButton.Name = "ConvertButton";
        ConvertButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
        ConvertButton.OnDisabledState.BorderRadius = 40;
        ConvertButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        ConvertButton.OnDisabledState.BorderThickness = 1;
        ConvertButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
        ConvertButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
        ConvertButton.OnDisabledState.IconLeftImage = null;
        ConvertButton.OnDisabledState.IconRightImage = null;
        ConvertButton.onHoverState.BorderColor = Color.Transparent;
        ConvertButton.onHoverState.BorderRadius = 40;
        ConvertButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        ConvertButton.onHoverState.BorderThickness = 1;
        ConvertButton.onHoverState.FillColor = Color.FromArgb(255, 101, 120);
        ConvertButton.onHoverState.ForeColor = Color.White;
        ConvertButton.onHoverState.IconLeftImage = null;
        ConvertButton.onHoverState.IconRightImage = null;
        ConvertButton.OnIdleState.BorderColor = Color.Transparent;
        ConvertButton.OnIdleState.BorderRadius = 40;
        ConvertButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        ConvertButton.OnIdleState.BorderThickness = 1;
        ConvertButton.OnIdleState.FillColor = Color.FromArgb(253, 70, 92);
        ConvertButton.OnIdleState.ForeColor = Color.White;
        ConvertButton.OnIdleState.IconLeftImage = null;
        ConvertButton.OnIdleState.IconRightImage = null;
        ConvertButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
        ConvertButton.OnPressedState.BorderRadius = 40;
        ConvertButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        ConvertButton.OnPressedState.BorderThickness = 1;
        ConvertButton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
        ConvertButton.OnPressedState.ForeColor = Color.White;
        ConvertButton.OnPressedState.IconLeftImage = null;
        ConvertButton.OnPressedState.IconRightImage = null;
        ConvertButton.Size = new Size(117, 42);
        ConvertButton.TabIndex = 10;
        ConvertButton.TextAlign = ContentAlignment.MiddleCenter;
        ConvertButton.TextAlignment = HorizontalAlignment.Center;
        ConvertButton.TextMarginLeft = 0;
        ConvertButton.TextPadding = new Padding(0);
        ConvertButton.UseDefaultRadiusAndThickness = true;
        // 
        // targetCurrencycomboBox
        // 
        targetCurrencycomboBox.BackColor = Color.Transparent;
        targetCurrencycomboBox.BackgroundColor = Color.White;
        targetCurrencycomboBox.BorderColor = Color.Silver;
        targetCurrencycomboBox.BorderRadius = 10;
        targetCurrencycomboBox.Color = Color.Silver;
        targetCurrencycomboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
        targetCurrencycomboBox.DisabledBackColor = Color.FromArgb(240, 240, 240);
        targetCurrencycomboBox.DisabledBorderColor = Color.FromArgb(204, 204, 204);
        targetCurrencycomboBox.DisabledColor = Color.FromArgb(240, 240, 240);
        targetCurrencycomboBox.DisabledForeColor = Color.FromArgb(109, 109, 109);
        targetCurrencycomboBox.DisabledIndicatorColor = Color.DarkGray;
        targetCurrencycomboBox.DrawMode = DrawMode.OwnerDrawFixed;
        targetCurrencycomboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
        targetCurrencycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        targetCurrencycomboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
        targetCurrencycomboBox.FillDropDown = true;
        targetCurrencycomboBox.FillIndicator = false;
        targetCurrencycomboBox.FlatStyle = FlatStyle.Flat;
        targetCurrencycomboBox.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
        targetCurrencycomboBox.ForeColor = Color.Black;
        targetCurrencycomboBox.FormattingEnabled = true;
        targetCurrencycomboBox.Icon = null;
        targetCurrencycomboBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
        targetCurrencycomboBox.IndicatorColor = Color.DarkGray;
        targetCurrencycomboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
        targetCurrencycomboBox.IndicatorThickness = 2;
        targetCurrencycomboBox.IsDropdownOpened = false;
        targetCurrencycomboBox.ItemBackColor = Color.White;
        targetCurrencycomboBox.ItemBorderColor = Color.White;
        targetCurrencycomboBox.ItemForeColor = Color.Black;
        targetCurrencycomboBox.ItemHeight = 26;
        targetCurrencycomboBox.ItemHighLightColor = Color.DodgerBlue;
        targetCurrencycomboBox.ItemHighLightForeColor = Color.White;
        targetCurrencycomboBox.ItemTopMargin = 3;
        targetCurrencycomboBox.Location = new Point(486, 176);
        targetCurrencycomboBox.Name = "targetCurrencycomboBox";
        targetCurrencycomboBox.Size = new Size(117, 32);
        targetCurrencycomboBox.TabIndex = 11;
        targetCurrencycomboBox.Text = null;
        targetCurrencycomboBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
        targetCurrencycomboBox.TextLeftMargin = 5;
        // 
        // sourceAmountTextBox
        // 
        sourceAmountTextBox.AcceptsReturn = false;
        sourceAmountTextBox.AcceptsTab = false;
        sourceAmountTextBox.AnimationSpeed = 200;
        sourceAmountTextBox.AutoCompleteMode = AutoCompleteMode.None;
        sourceAmountTextBox.AutoCompleteSource = AutoCompleteSource.None;
        sourceAmountTextBox.AutoSizeHeight = true;
        sourceAmountTextBox.BackColor = Color.Transparent;
        sourceAmountTextBox.BackgroundImage = (Image)resources.GetObject("sourceAmountTextBox.BackgroundImage");
        sourceAmountTextBox.BorderColorActive = Color.DodgerBlue;
        sourceAmountTextBox.BorderColorDisabled = Color.FromArgb(204, 204, 204);
        sourceAmountTextBox.BorderColorHover = Color.FromArgb(105, 181, 255);
        sourceAmountTextBox.BorderColorIdle = Color.Silver;
        sourceAmountTextBox.BorderRadius = 30;
        sourceAmountTextBox.BorderThickness = 1;
        sourceAmountTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
        sourceAmountTextBox.CharacterCasing = CharacterCasing.Normal;
        sourceAmountTextBox.DefaultFont = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
        sourceAmountTextBox.DefaultText = "";
        sourceAmountTextBox.FillColor = Color.White;
        sourceAmountTextBox.ForeColor = Color.Black;
        sourceAmountTextBox.HideSelection = true;
        sourceAmountTextBox.IconLeft = null;
        sourceAmountTextBox.IconLeftCursor = Cursors.IBeam;
        sourceAmountTextBox.IconPadding = 10;
        sourceAmountTextBox.IconRight = null;
        sourceAmountTextBox.IconRightCursor = Cursors.IBeam;
        sourceAmountTextBox.Location = new Point(128, 176);
        sourceAmountTextBox.MaxLength = 32767;
        sourceAmountTextBox.MinimumSize = new Size(1, 1);
        sourceAmountTextBox.Modified = false;
        sourceAmountTextBox.Multiline = false;
        sourceAmountTextBox.Name = "sourceAmountTextBox";
        stateProperties1.BorderColor = Color.DodgerBlue;
        stateProperties1.FillColor = Color.Empty;
        stateProperties1.ForeColor = Color.Empty;
        stateProperties1.PlaceholderForeColor = Color.Empty;
        sourceAmountTextBox.OnActiveState = stateProperties1;
        stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
        stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
        stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
        stateProperties2.PlaceholderForeColor = Color.DarkGray;
        sourceAmountTextBox.OnDisabledState = stateProperties2;
        stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
        stateProperties3.FillColor = Color.Empty;
        stateProperties3.ForeColor = Color.Empty;
        stateProperties3.PlaceholderForeColor = Color.Empty;
        sourceAmountTextBox.OnHoverState = stateProperties3;
        stateProperties4.BorderColor = Color.Silver;
        stateProperties4.FillColor = Color.White;
        stateProperties4.ForeColor = Color.Black;
        stateProperties4.PlaceholderForeColor = Color.Empty;
        sourceAmountTextBox.OnIdleState = stateProperties4;
        sourceAmountTextBox.Padding = new Padding(3);
        sourceAmountTextBox.PasswordChar = '\0';
        sourceAmountTextBox.PlaceholderForeColor = Color.Silver;
        sourceAmountTextBox.PlaceholderText = "";
        sourceAmountTextBox.ReadOnly = false;
        sourceAmountTextBox.ScrollBars = ScrollBars.None;
        sourceAmountTextBox.SelectedText = "";
        sourceAmountTextBox.SelectionLength = 0;
        sourceAmountTextBox.SelectionStart = 0;
        sourceAmountTextBox.ShortcutsEnabled = true;
        sourceAmountTextBox.Size = new Size(171, 42);
        sourceAmountTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
        sourceAmountTextBox.TabIndex = 12;
        sourceAmountTextBox.TextAlign = HorizontalAlignment.Left;
        sourceAmountTextBox.TextMarginBottom = 0;
        sourceAmountTextBox.TextMarginLeft = 3;
        sourceAmountTextBox.TextMarginTop = 1;
        sourceAmountTextBox.TextPlaceholder = "";
        sourceAmountTextBox.UseSystemPasswordChar = false;
        sourceAmountTextBox.WordWrap = true;
        // 
        // bunifuSeparator1
        // 
        bunifuSeparator1.BackColor = Color.Transparent;
        bunifuSeparator1.BackgroundImage = (Image)resources.GetObject("bunifuSeparator1.BackgroundImage");
        bunifuSeparator1.BackgroundImageLayout = ImageLayout.Stretch;
        bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
        bunifuSeparator1.ForeColor = Color.White;
        bunifuSeparator1.LineColor = Color.White;
        bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
        bunifuSeparator1.LineThickness = 1;
        bunifuSeparator1.Location = new Point(128, 109);
        bunifuSeparator1.Margin = new Padding(4, 5, 4, 5);
        bunifuSeparator1.Name = "bunifuSeparator1";
        bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
        bunifuSeparator1.Size = new Size(475, 28);
        bunifuSeparator1.TabIndex = 13;
        // 
        // titleLabel
        // 
        titleLabel.AllowParentOverrides = false;
        titleLabel.AutoEllipsis = false;
        titleLabel.CursorType = Cursors.Default;
        titleLabel.Font = new Font("Poppins", 16F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(188, 63);
        titleLabel.Name = "titleLabel";
        titleLabel.RightToLeft = RightToLeft.No;
        titleLabel.Size = new Size(268, 46);
        titleLabel.TabIndex = 15;
        titleLabel.Text = "Currency Converter";
        titleLabel.TextAlignment = ContentAlignment.TopLeft;
        titleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
        // 
        // amountLabel
        // 
        amountLabel.AllowParentOverrides = false;
        amountLabel.AutoEllipsis = false;
        amountLabel.CursorType = Cursors.Default;
        amountLabel.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
        amountLabel.ForeColor = Color.White;
        amountLabel.Location = new Point(138, 145);
        amountLabel.Name = "amountLabel";
        amountLabel.RightToLeft = RightToLeft.No;
        amountLabel.Size = new Size(58, 25);
        amountLabel.TabIndex = 16;
        amountLabel.Text = "Amount";
        amountLabel.TextAlignment = ContentAlignment.TopLeft;
        amountLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
        // 
        // fromLabel
        // 
        fromLabel.AllowParentOverrides = false;
        fromLabel.AutoEllipsis = false;
        fromLabel.CursorType = Cursors.Default;
        fromLabel.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
        fromLabel.ForeColor = Color.White;
        fromLabel.Location = new Point(346, 145);
        fromLabel.Name = "fromLabel";
        fromLabel.RightToLeft = RightToLeft.No;
        fromLabel.Size = new Size(38, 25);
        fromLabel.TabIndex = 17;
        fromLabel.Text = "Form";
        fromLabel.TextAlignment = ContentAlignment.TopLeft;
        fromLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
        // 
        // toLabel
        // 
        toLabel.AllowParentOverrides = false;
        toLabel.AutoEllipsis = false;
        toLabel.CursorType = Cursors.Default;
        toLabel.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
        toLabel.ForeColor = Color.White;
        toLabel.Location = new Point(486, 145);
        toLabel.Name = "toLabel";
        toLabel.RightToLeft = RightToLeft.No;
        toLabel.Size = new Size(17, 25);
        toLabel.TabIndex = 18;
        toLabel.Text = "To";
        toLabel.TextAlignment = ContentAlignment.TopLeft;
        toLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
        // 
        // refreshButton
        // 
        refreshButton.AllowAnimations = true;
        refreshButton.AllowMouseEffects = true;
        refreshButton.AllowToggling = false;
        refreshButton.AnimationSpeed = 200;
        refreshButton.AutoGenerateColors = false;
        refreshButton.AutoRoundBorders = false;
        refreshButton.AutoSizeLeftIcon = true;
        refreshButton.AutoSizeRightIcon = true;
        refreshButton.BackColor = Color.Transparent;
        refreshButton.BackColor1 = Color.Transparent;
        refreshButton.BackgroundImage = (Image)resources.GetObject("refreshButton.BackgroundImage");
        refreshButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        refreshButton.ButtonText = "";
        refreshButton.ButtonTextMarginLeft = 0;
        refreshButton.ColorContrastOnClick = 45;
        refreshButton.ColorContrastOnHover = 45;
        borderEdges2.BottomLeft = true;
        borderEdges2.BottomRight = true;
        borderEdges2.TopLeft = true;
        borderEdges2.TopRight = true;
        refreshButton.CustomizableEdges = borderEdges2;
        refreshButton.DialogResult = DialogResult.None;
        refreshButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
        refreshButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
        refreshButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
        refreshButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
        refreshButton.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
        refreshButton.ForeColor = Color.White;
        refreshButton.IconLeftAlign = ContentAlignment.MiddleCenter;
        refreshButton.IconLeftCursor = Cursors.Arrow;
        refreshButton.IconLeftPadding = new Padding(0);
        refreshButton.IconMarginLeft = 11;
        refreshButton.IconPadding = 10;
        refreshButton.IconRightAlign = ContentAlignment.MiddleRight;
        refreshButton.IconRightCursor = Cursors.Default;
        refreshButton.IconRightPadding = new Padding(3, 3, 7, 3);
        refreshButton.IconSize = 25;
        refreshButton.IdleBorderColor = Color.Transparent;
        refreshButton.IdleBorderRadius = 40;
        refreshButton.IdleBorderThickness = 1;
        refreshButton.IdleFillColor = Color.Transparent;
        refreshButton.IdleIconLeftImage = (Image)resources.GetObject("refreshButton.IdleIconLeftImage");
        refreshButton.IdleIconRightImage = null;
        refreshButton.IndicateFocus = false;
        refreshButton.Location = new Point(612, 173);
        refreshButton.Margin = new Padding(0);
        refreshButton.Name = "refreshButton";
        refreshButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
        refreshButton.OnDisabledState.BorderRadius = 40;
        refreshButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        refreshButton.OnDisabledState.BorderThickness = 1;
        refreshButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
        refreshButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
        refreshButton.OnDisabledState.IconLeftImage = null;
        refreshButton.OnDisabledState.IconRightImage = null;
        refreshButton.onHoverState.BorderColor = Color.Transparent;
        refreshButton.onHoverState.BorderRadius = 40;
        refreshButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        refreshButton.onHoverState.BorderThickness = 1;
        refreshButton.onHoverState.FillColor = Color.FromArgb(253, 70, 92);
        refreshButton.onHoverState.ForeColor = Color.White;
        refreshButton.onHoverState.IconLeftImage = null;
        refreshButton.onHoverState.IconRightImage = null;
        refreshButton.OnIdleState.BorderColor = Color.Transparent;
        refreshButton.OnIdleState.BorderRadius = 40;
        refreshButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        refreshButton.OnIdleState.BorderThickness = 1;
        refreshButton.OnIdleState.FillColor = Color.Transparent;
        refreshButton.OnIdleState.ForeColor = Color.White;
        refreshButton.OnIdleState.IconLeftImage = (Image)resources.GetObject("refreshButton.OnIdleState.IconLeftImage");
        refreshButton.OnIdleState.IconRightImage = null;
        refreshButton.OnPressedState.BorderColor = Color.Transparent;
        refreshButton.OnPressedState.BorderRadius = 40;
        refreshButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
        refreshButton.OnPressedState.BorderThickness = 1;
        refreshButton.OnPressedState.FillColor = Color.Transparent;
        refreshButton.OnPressedState.ForeColor = Color.White;
        refreshButton.OnPressedState.IconLeftImage = null;
        refreshButton.OnPressedState.IconRightImage = null;
        refreshButton.Size = new Size(42, 42);
        refreshButton.TabIndex = 19;
        refreshButton.TextAlign = ContentAlignment.MiddleCenter;
        refreshButton.TextAlignment = HorizontalAlignment.Center;
        refreshButton.TextMarginLeft = 0;
        refreshButton.TextPadding = new Padding(0);
        refreshButton.UseDefaultRadiusAndThickness = true;
        // 
        // logoImageButton
        // 
        logoImageButton.ActiveImage = null;
        logoImageButton.AllowAnimations = true;
        logoImageButton.AllowBuffering = false;
        logoImageButton.AllowToggling = false;
        logoImageButton.AllowZooming = false;
        logoImageButton.AllowZoomingOnFocus = false;
        logoImageButton.BackColor = Color.Transparent;
        logoImageButton.DialogResult = DialogResult.None;
        logoImageButton.ErrorImage = (Image)resources.GetObject("logoImageButton.ErrorImage");
        logoImageButton.FadeWhenInactive = false;
        logoImageButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
        logoImageButton.Image = (Image)resources.GetObject("logoImageButton.Image");
        logoImageButton.ImageActive = null;
        logoImageButton.ImageLocation = null;
        logoImageButton.ImageMargin = 10;
        logoImageButton.ImageSize = new Size(50, 50);
        logoImageButton.ImageZoomSize = new Size(60, 60);
        logoImageButton.InitialImage = (Image)resources.GetObject("logoImageButton.InitialImage");
        logoImageButton.Location = new Point(128, 49);
        logoImageButton.Name = "logoImageButton";
        logoImageButton.Rotation = 0;
        logoImageButton.ShowActiveImage = true;
        logoImageButton.ShowCursorChanges = true;
        logoImageButton.ShowImageBorders = true;
        logoImageButton.ShowSizeMarkers = false;
        logoImageButton.Size = new Size(60, 60);
        logoImageButton.TabIndex = 20;
        logoImageButton.ToolTipText = "";
        logoImageButton.WaitOnLoad = false;
        logoImageButton.Zoom = 10;
        logoImageButton.ZoomSpeed = 10;
        // 
        // CurrencyConverter
        // 
        AutoScaleDimensions = new SizeF(9F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(21, 26, 44);
        ClientSize = new Size(782, 355);
        Controls.Add(logoImageButton);
        Controls.Add(refreshButton);
        Controls.Add(toLabel);
        Controls.Add(fromLabel);
        Controls.Add(amountLabel);
        Controls.Add(titleLabel);
        Controls.Add(bunifuSeparator1);
        Controls.Add(sourceAmountTextBox);
        Controls.Add(targetCurrencycomboBox);
        Controls.Add(ConvertButton);
        Controls.Add(sourceCurrencycomboBox);
        Controls.Add(resultLabel);
        Font = new Font("Arial", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
        ForeColor = Color.Snow;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "CurrencyConverter";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Currency Converter";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label resultLabel;
    private Bunifu.UI.WinForms.BunifuDropdown sourceCurrencycomboBox;
    private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 ConvertButton;
    private Bunifu.UI.WinForms.BunifuDropdown targetCurrencycomboBox;
    private Bunifu.UI.WinForms.BunifuTextBox sourceAmountTextBox;
    private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
    private Bunifu.UI.WinForms.BunifuLabel titleLabel;
    private Bunifu.UI.WinForms.BunifuLabel amountLabel;
    private Bunifu.UI.WinForms.BunifuLabel fromLabel;
    private Bunifu.UI.WinForms.BunifuLabel toLabel;
    private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 refreshButton;
    private Bunifu.UI.WinForms.BunifuImageButton logoImageButton;
}
