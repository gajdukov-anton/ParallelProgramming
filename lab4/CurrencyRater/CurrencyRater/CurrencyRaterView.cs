using CurrencyRater.Controller;
using CurrencyRater.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyRater
{
    public partial class CurrencyRaterView : Form
    {
        private ICurrencyRaterController _currencyRaterController;

        public CurrencyRaterView( ICurrencyRaterController currencyRaterController )
        {
            InitializeComponent();
            _currencyRaterController = currencyRaterController;
        }

        private void groupBox1_Enter( object sender, EventArgs e )
        {

        }

        private void label3_Click( object sender, EventArgs e )
        {

        }

        private void PerformButton_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty( outputFileTextBox.Text))
            {
                resultFileErrorProvider.SetError( outputFileTextBox, Constants.NEED_ENTER_FILE_NAME );
                return;
            }
            var timePeriods = _currencyRaterController.WriteCurrencyRateToFile( inputFileTextBox.Text, outputFileTextBox.Text );
            avrTimeLabel.Text = $"{Constants.AVERAGE_TIME}: {Math.Round( timePeriods.Average(), 2 )}";
            timeWorkListBox.Items.AddRange( timePeriods.Select( item => item.ToString() ).ToArray() );
        }

        private async void PerformAsyncButton_Click( object sender, EventArgs e )
        {
            if ( string.IsNullOrEmpty( outputFileTextBox.Text ) )
            {
                resultFileErrorProvider.SetError( outputFileTextBox, Constants.NEED_ENTER_FILE_NAME);
                return;
            }
            performAsyncButton.Enabled = false;
            var timePeriods = await _currencyRaterController.WriteCurrencyRateToFileAsync( inputFileTextBox.Text, outputFileTextBox.Text );
            avrTimeAsyncLabel.Text = $"{Constants.AVERAGE_TIME}: {Math.Round( timePeriods.Average(), 2 )}";
            timeWorkAsyncListBox.Items.AddRange( timePeriods.Select( item => item.ToString() ).ToArray() );
            performAsyncButton.Enabled = true;
        }

        private void outputFileTextBox_TextChanged( object sender, EventArgs e )
        {
            resultFileErrorProvider.Clear();
        }
    }
}
