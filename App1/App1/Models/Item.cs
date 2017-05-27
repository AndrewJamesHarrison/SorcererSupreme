namespace App1.Models
{
    public class Item : BaseDataObject
	{
		private string text = string.Empty;
		public string Text
		{
			get { return text; }
			set { SetProperty(ref text, value); }
		}

		private string description = string.Empty;
		public string Description
		{
			get { return description; }
			set { SetProperty(ref description, value); }
		}
        private int rollResult = 0;
        public int RollResult
        {
            get { return rollResult; }
            set { SetProperty(ref rollResult, value); }
        }

        private bool finishedCast = false;
        public bool FinishedCast
        {
            get { return finishedCast; }
            set { SetProperty(ref finishedCast, value); }
        }

        private bool replacement = false;
        public bool Replacement
        {
            get { return replacement; }
            set { SetProperty(ref replacement, value); }
        }

        public Item() { }
        public Item(string Name, string detail)
        {
            Text = Name;
            Description = detail;
        }
	}
}
