using System;
using System.Threading;
using System.Windows;

namespace MedicalExams.Classes
{
    /// <summary>
    /// Class necessary to translate all APP
    /// </summary>
    class Languages : Window
    {
        public ResourceDictionary SetLanguageDictionary()
        {
            ResourceDictionary dict = new ResourceDictionary();

            switch(Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "en-GB":
                    dict.Source = new Uri("Resources/Languages/en-GB/en-GB.generalLanguage.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "pt-PT":
                    dict.Source = new Uri("Resources/Languages/pt-PT/pt-PT.generalLanguage.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    dict.Source = new Uri("Resources/Languages/en-GB/en-GB.generalLanguage.xaml", UriKind.RelativeOrAbsolute);
                    break;
            }
            return dict;
        }
    }
}
