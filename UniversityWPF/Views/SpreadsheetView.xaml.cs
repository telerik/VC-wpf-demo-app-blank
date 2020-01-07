using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;

namespace UniversityWPF.Views
{
    /// <summary>
    /// Interaction logic for SpreadsheetView.xaml
    /// </summary>
    public partial class SpreadsheetView : UserControl
    {
        private readonly XlsxFormatProvider _formatProvider;

        public SpreadsheetView()
        {
            InitializeComponent();
            _formatProvider = new XlsxFormatProvider();
        }
    }
}
