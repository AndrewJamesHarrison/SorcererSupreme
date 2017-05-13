using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.ViewModels
{
    public class NewItemsViewModel : BaseViewModel
    {
        public List<Item> WordList => new List<Item>
        {
            new Item("Si", "Conditional/Interaction"),
            new Item("Magnitudine", "Size"),
            new Item("Morphosia", "Shape"),
            new Item("Ex Nihil", "Create"),
            new Item("Locatia", "Location"),
            new Item("Emulus", "Imitate"),
            new Item("Somateria", "Physical Object"),
            new Item("Injectiv", "Insert"),
            new Item("Extractus", "Extract"), //Extract - -no longer needed?
            new Item("Crescere", "Increase"),
            new Item("Contra", "Reverse"),
            new Item("Transmutia", "Convert"),
            new Item("Preventia", "Prevent"),
            new Item("Vitalia", "Life"),
            new Item("Vectora", "Kinetic Energy"),
            new Item("Luminus", "Light Energy"),
            new Item("Thermia", "Thermal Energy"),
            new Item("Potentia", "Electrical Energy"),
            new Item("Chronos", "Time"),
            new Item("Arcano", "Magic"),
        };

        public Item SelectedItem { get; set; }
    }
}
