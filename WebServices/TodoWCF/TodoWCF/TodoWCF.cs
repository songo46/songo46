using System;
using Xamarin.Forms;

namespace TodoWCF
{
	public class App : Application
	{
		public static TodoItemManager TodoManager { get; set; }

        public App ()
		{
			TodoManager = new TodoItemManager (new SoapService ());
			MainPage = new NavigationPage (new TodoListPage ());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
