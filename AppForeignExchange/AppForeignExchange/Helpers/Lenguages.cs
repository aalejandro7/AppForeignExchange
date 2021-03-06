﻿namespace AppForeignExchange.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Lenguages
    {
        static Lenguages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }
        public static string AmountValidation
        {
            get { return Resource.AmountValidation; }
        }
        public static string Error
        {
            get { return Resource.Error; }
        }
        public static string Title
        {
            get { return Resource.Title; }
        }
        public static string Convert
        {
            get { return Resource.Convert; }
        }
        public static string Connection
        {
            get { return Resource.Connection; }
        }
        public static string NoConnection
        {
            get { return Resource.NoConnection; }
        }
        public static string LoadedInternet
        {
            get { return Resource.LoadedInternet; }
        }
        public static string LoadedLocal
        {
            get { return Resource.LoadedLocal; }
        }
    }
}
