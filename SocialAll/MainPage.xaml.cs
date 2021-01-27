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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SocialAll
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public WebView WebBrowser { get; private set; }

        public string TelegramWebUrl = "https://web.telegram.org/";
        public string FacebookChatWebUrl = "https://www.messenger.com/";
        public string WhatsAppWebUrl = "https://web.whatsapp.com/";
        public string BipWebUrl = "https://web.bip.com/";
        public string FacebookWebUrl = "https://www.facebook.com/";
        public string TwitterWebUrl = "https://web.bip.com/";
        public string InstagramWebUrl = "https://www.instagram.com/";
        public string RedditWebUrl = "https://www.reddit.com/";
        public string MyWebUrl = "https://foksord.github.io/";


        public MainPage()
        {
            this.InitializeComponent();
            WebBrowser = (WebView)this.FindName("webview");
        } 

        private void loadUrl(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                WebBrowser.Navigate(uri);
            } catch (Exception e)
            {
                WebBrowser.NavigateToString(String.Format("<h1>Address is invalid, try again.  Details --> {0}.</h1>", e.Message));
            }
        }

        private void MySite_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(MyWebUrl);
        }

        private void reddit_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(RedditWebUrl);
        }

        private void instagram_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(InstagramWebUrl);
        }

        private void twitter_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(TwitterWebUrl);
        }

        private void facebook_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(FacebookWebUrl);
        }

        private void bip_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(BipWebUrl);
        }

        private void whatsapp_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(WhatsAppWebUrl);
        }

        private void facebookmessenger_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(FacebookChatWebUrl);
        }

        private void telegram_Click(object sender, RoutedEventArgs e)
        {
            loadUrl(TelegramWebUrl);
        }
    }
}
