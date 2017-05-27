using System;

using App1.Models;
using App1.ViewModels;

using Xamarin.Forms;

namespace App1.Views
{
	public partial class ItemsPage : ContentPage
	{
		ItemsViewModel viewModel;

		public ItemsPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new ItemsViewModel();
		}

		async void AddItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NewItemPage());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (viewModel.Items.Count == 0)
				viewModel.LoadItemsCommand.Execute(null);
		}

        private void ClearAll_Clicked(object sender, EventArgs e)
        {
            viewModel.Items.Clear();
        }

        private void CastSpell_Clicked(object sender, EventArgs e)
        {
            viewModel.CastSpell();
        }
    }
}
