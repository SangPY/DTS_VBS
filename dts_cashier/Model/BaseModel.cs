using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace dts_cashier.Model
{
    public class BaseModel : INotifyPropertyChanged
    {
        //private string currencySymbol;

        //private bool isCardDetected;

        //private bool isCriticalRequestBeingProcessed;

        //private bool isOfflineMode;

        //private bool isProcessing;

        //private bool isWindowOpen;

        //private string priceCurrencySymbol;

        //private string processingText;

        //public BaseModel()
        //{
        //    CurrencySymbol = DataCacheContext.CurrencySymbol;
        //    PriceCurrencySymbol = DataCacheContext.PriceCurrencySymbol;
        //}

        //public bool IsCardDetected
        //{
        //    get => isCardDetected;
        //    set
        //    {
        //        isCardDetected = value;
        //        RaisePropertyChanged(nameof(IsCardDetected));
        //    }
        //}

        //public bool IsProcessing
        //{
        //    get => isProcessing;
        //    set
        //    {
        //        isProcessing = value;
        //        RaisePropertyChanged(nameof(IsProcessing));
        //    }
        //}

        //public bool IsOfflineMode
        //{
        //    get => isOfflineMode;
        //    set
        //    {
        //        isOfflineMode = value;
        //        RaisePropertyChanged(nameof(IsOfflineMode));
        //    }
        //}

        //public string ProcessingText
        //{
        //    get => processingText;
        //    set
        //    {
        //        processingText = value;
        //        RaisePropertyChanged(nameof(ProcessingText));
        //    }
        //}

        //public bool IsWindowOpen
        //{
        //    get => isWindowOpen;
        //    set
        //    {
        //        isWindowOpen = value;
        //        RaisePropertyChanged(nameof(IsWindowOpen));
        //    }
        //}

        //public bool IsCriticalRequestBeingProcessed
        //{
        //    get => isCriticalRequestBeingProcessed;
        //    set
        //    {
        //        isCriticalRequestBeingProcessed = value;
        //        RaisePropertyChanged(nameof(IsCriticalRequestBeingProcessed));
        //    }
        //}

        //public string CurrencySymbol
        //{
        //    get => currencySymbol;
        //    set
        //    {
        //        currencySymbol = value;
        //        RaisePropertyChanged(nameof(CurrencySymbol));
        //    }
        //}

        //public string PriceCurrencySymbol
        //{
        //    get => priceCurrencySymbol;
        //    set
        //    {
        //        priceCurrencySymbol = value;
        //        RaisePropertyChanged(nameof(PriceCurrencySymbol));
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void RaisePropertyChanged(string propertyName)
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null)
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //}

        //public virtual void SendData(string message, object data)
        //{
        //}

        //protected bool ShowConfirmationWindow(string warningMessage, string mode, Window owner = null,
        //    string proceedLabel = null, string proceedButtonBackground = null)
        //{
        //    bool? windowDialogResult = false;

        //    return Application.Current.Dispatcher.Invoke(() =>
        //    {
        //        var genericWindow = new GenericDialogWindow();
        //        try
        //        {
        //            Mediator.Instance.NotifyViewModel(Messages.ConfirmationWindowViewModel, Messages.ConfirmationWindow,
        //                genericWindow);
        //            Mediator.Instance.NotifyViewModel(Messages.ConfirmationWindowViewModel, mode, warningMessage);

        //            if (proceedLabel != null)
        //                Mediator.Instance.NotifyViewModel(Messages.ConfirmationWindowViewModel,
        //                    Messages.ConfirmationLabel, proceedLabel);

        //            if (proceedButtonBackground != null)
        //                Mediator.Instance.NotifyViewModel(Messages.ConfirmationWindowViewModel,
        //                    Messages.ConfirmationBackgroundColor, proceedButtonBackground);

        //            Mediator.Instance.NotifyViewModel(Messages.CashierViewModel, Messages.ShowBlurBackground, true);

        //            if (owner == null)
        //                genericWindow.Owner = Application.Current.MainWindow;
        //            else
        //                genericWindow.Owner = owner;
        //        }
        //        catch (Exception ex)
        //        {
        //            CodedLogger.LogException(ex);
        //        }
        //        finally
        //        {
        //            windowDialogResult = genericWindow.ShowDialog();
        //            Mediator.Instance.NotifyViewModel(Messages.CashierViewModel, Messages.ShowBlurBackground, false);
        //        }

        //        return windowDialogResult.Value;
        //    });
        //}

        //protected bool ShowConfirmationWithHighlightWindow(string firstSentence, string highlightedSentence,
        //    string highlightedSentenceExtensionstring,
        //    string finalSentence, string mode, Window owner = null, string proceedLabel = null,
        //    string proceedButtonBackground = null)
        //{
        //    bool? windowDialogResult = false;

        //    return Application.Current.Dispatcher.Invoke(() =>
        //    {
        //        var genericWindow = new GenericDialogWithHighlightWindow();

        //        try
        //        {
        //            if (owner == null)
        //                genericWindow.Owner = Application.Current.MainWindow;
        //            else
        //                genericWindow.Owner = owner;
        //        }
        //        catch (Exception ex)
        //        {
        //            CodedLogger.LogException(ex);
        //        }

        //        var messages = new List<string>
        //            { firstSentence, highlightedSentence, highlightedSentenceExtensionstring, finalSentence };
        //        Mediator.Instance.NotifyViewModel(Messages.ConfirmationWithHighlightWindowViewModel,
        //            Messages.ConfirmationWindow, genericWindow);
        //        Mediator.Instance.NotifyViewModel(Messages.ConfirmationWithHighlightWindowViewModel, mode, messages);

        //        if (proceedLabel != null)
        //            Mediator.Instance.NotifyViewModel(Messages.ConfirmationWithHighlightWindowViewModel,
        //                Messages.ConfirmationLabel, proceedLabel);

        //        if (proceedButtonBackground != null)
        //            Mediator.Instance.NotifyViewModel(Messages.ConfirmationWithHighlightWindowViewModel,
        //                Messages.ConfirmationBackgroundColor, proceedButtonBackground);

        //        Mediator.Instance.NotifyViewModel(Messages.CashierViewModel, Messages.ShowBlurBackground, true);
        //        windowDialogResult = genericWindow.ShowDialog();
        //        Mediator.Instance.NotifyViewModel(Messages.CashierViewModel, Messages.ShowBlurBackground, false);

        //        return windowDialogResult.Value;
        //    });
        //}

        //protected ErrorDataModel ConvertErrorDataModel(string response)
        //{
        //    var errorModel = JsonConvert.DeserializeObject<ErrorDataModel>(response);
        //    return errorModel;
        //}

        //public int PrintExcessCharacterOnNewLine(PrintPageEventArgs e, string labelName, string displayName,
        //    bool isCenterAlign, int charLimit, int xAxisFirstLine, int xAxisSecondLine, int yAxis, int yMargin,
        //    int yLine, FontStyle fontStyle)
        //{
        //    if (displayName.Length > charLimit && displayName.Substring(charLimit) != "")
        //    {
        //        string cropNameFirstLine;
        //        string cropNameSecondLine;
        //        for (var x = charLimit; x >= 0; x--)
        //            if (displayName.Substring(x, 1) == " ")
        //            {
        //                cropNameFirstLine = displayName.Substring(0, x);
        //                cropNameSecondLine = displayName.Substring(x);
        //                if (isCenterAlign)
        //                {
        //                    e.Graphics.DrawString($"{cropNameFirstLine}", new Font("Arial Narrow", 9F, fontStyle),
        //                        new SolidBrush(Color.Black), 85 - Convert.ToInt32(cropNameFirstLine.Length * 2.273),
        //                        yAxis += yMargin * yLine);
        //                    e.Graphics.DrawString($"{cropNameSecondLine}", new Font("Arial Narrow", 9F, fontStyle),
        //                        new SolidBrush(Color.Black), 85 - Convert.ToInt32(cropNameSecondLine.Length * 2.273),
        //                        yAxis += yMargin);
        //                }
        //                else
        //                {
        //                    e.Graphics.DrawString($"{labelName} {cropNameFirstLine}",
        //                        new Font("Arial Narrow", 9F, fontStyle), new SolidBrush(Color.Black), xAxisFirstLine,
        //                        yAxis += yMargin * yLine);
        //                    e.Graphics.DrawString($"{cropNameSecondLine}", new Font("Arial Narrow", 9F, fontStyle),
        //                        new SolidBrush(Color.Black), xAxisSecondLine, yAxis += yMargin);
        //                }

        //                break;
        //            }
        //    }
        //    else if (displayName.Length <= charLimit)
        //    {
        //        if (isCenterAlign)
        //            e.Graphics.DrawString($"{displayName}", new Font("Arial Narrow", 9F, fontStyle),
        //                new SolidBrush(Color.Black), 85 - Convert.ToInt32(displayName.Length * 2.273),
        //                yAxis += yMargin * yLine);
        //        else
        //            e.Graphics.DrawString($"{PrinterMessageResource.Name} {displayName}",
        //                new Font("Arial Narrow", 9F, fontStyle), new SolidBrush(Color.Black), xAxisFirstLine,
        //                yAxis += yMargin * yLine);
        //    }

        //    return yAxis;
        //}

        //protected void SetIsProcessing(bool value)
        //{
        //    Application.Current.Dispatcher.BeginInvoke((Action)delegate { IsProcessing = value; });
        //}
        public event PropertyChangedEventHandler PropertyChanged;
    }
}