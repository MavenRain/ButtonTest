﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace CSharpTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

		void Button1_Click(object sender, RoutedEventArgs e)
		{
			TextBlock1.Text = "1";
		}

		void Button2_Click(object sender, RoutedEventArgs e)
		{
			TextBlock1.Text = "2";
		}

		void Button3_Click(object sender, RoutedEventArgs e)
		{
			TextBlock1.Text = "3";
		}
	}
}
