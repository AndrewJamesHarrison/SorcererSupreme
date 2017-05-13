using System;

using App1.Models;

using Xamarin.Forms;
using App1.ViewModels;

namespace App1.Views
{
	public partial class NewItemPage : ContentPage
	{

        public NewItemsViewModel viewModel;

		public NewItemPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new NewItemsViewModel(); ;
		}

		async void Save_Clicked(object sender, EventArgs e)
		{
			MessagingCenter.Send(this, "AddItem", viewModel.SelectedItem);
			await Navigation.PopToRootAsync();
		}
	}
}