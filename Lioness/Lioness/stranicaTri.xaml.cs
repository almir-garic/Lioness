using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Lioness.DLA;
using Lioness.Models;
using Windows.UI.Popups;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Lioness
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class stranicaTri : Page
    {

        private LionessdbContext _context;
        private QuoteEditViewModel _viewModel;

        public stranicaTri()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _context = new LionessdbContext();

            QuoteListViewModel model = (QuoteListViewModel)e.Parameter;
            if (model == null)
            {
                model = new QuoteListViewModel();
            }

            if (model.Id != 0)
            {
                _viewModel = _context.Quotes.Select(x => new QuoteEditViewModel
                {
                    Id = x.Id,
                    Quote = x.Quote     
                }).FirstOrDefault(x => x.Id == model.Id);
            }
            else
            {
                _viewModel = new QuoteEditViewModel();
            }

            QuoteText.Text = _viewModel.Quote ?? "";
            

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _context.Dispose();

            base.OnNavigatedFrom(e);
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void SaveAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
