using System;
using System.Diagnostics;
using System.Threading.Tasks;

using App1.Helpers;
using App1.Models;
using App1.Views;

using Xamarin.Forms;
using System.Collections.Generic;

namespace App1.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }
        public Item SelectedItem { get; set; }
        public Command LoadItemsCommand { get; set; }
        private Random varRandom;
        private NewItemsViewModel newItemsVM;

		public ItemsViewModel()
		{
			Title = "";
			Items = new ObservableRangeCollection<Item>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            varRandom = new Random();
            newItemsVM = new NewItemsViewModel();
			MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
			{
				var _item = item as Item;
				Items.Add(_item);
				await DataStore.AddItemAsync(_item);
			});
        }

		async Task ExecuteLoadItemsCommand()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			try
			{

			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				MessagingCenter.Send(new MessagingCenterAlert
				{
					Title = "Error",
					Message = "Unable to load items.",
					Cancel = "OK"
				}, "message");
			}
			finally
			{
				IsBusy = false;
			}
		}

        public void CastSpell()
        {
            foreach (Item mword in Items)
            {
                mword.RollResult= varRandom.Next(1, 21);
                mword.FinishedCast = true;
            }
            List<int> replaceWords = new List<int>();
            foreach (Item mword in Items)
            {
                if (mword.RollResult == 1)
                    replaceWords.Add(Items.IndexOf(mword));
            }
            foreach (int index in replaceWords)
            {
                int newWord = varRandom.Next(0, 20);
                Items.RemoveAt(index);
                Items.Insert(index, newItemsVM.WordList[newWord]);
                Items[index].RollResult = varRandom.Next(10, 21);
                Items[index].FinishedCast = true;
                Items[index].Replacement = true;
            }
        }
	}
}