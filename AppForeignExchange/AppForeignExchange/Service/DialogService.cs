﻿namespace AppForeignExchange.Service
{
    using Helpers;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public class DialogService
    {

        public async Task ShowMessage(string title, string message)
        {
            await Application.Current.MainPage.DisplayAlert(
                title,
                message,
                Lenguages.Accept);
        }

    }
}