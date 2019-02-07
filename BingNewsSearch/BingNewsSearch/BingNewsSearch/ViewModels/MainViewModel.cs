using BingNewsSearch.Models;
using BingNewsSearch.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BingNewsSearch.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            service = new NewsService();
            GetNewsCommand = new Command(GetNews);
        }

        private async void GetNews(object obj)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var searchResult = await service.GetNewsAsync(Searchtext);
                Articles = searchResult.Articles;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Netzwerk", "Sie haben keinen Internetzugriff", "😱");
            }
        }

        private readonly NewsService service;
        public Command GetNewsCommand { get; set; }

        private string searchtext;
        public string Searchtext
        {
            get => searchtext;
            set => SetValue(ref searchtext, value);
        }
        private List<Article> articles;
        public List<Article> Articles
        {
            get => articles;
            set => SetValue(ref articles, value);
        }

        private Article selectedArticle;
        public Article SelectedArticle
        {
            get => selectedArticle;
            set
            {
                if (value == null)
                    return;
                TextToSpeech.SpeakAsync(value.Description);
                selectedArticle = value;
            }
        }
    }
}
