using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    class NewManager
    {
        public static List<NewItems> GetNewItems()
        {
            var items = new List<NewItems>();

            items.Add(new NewItems() { Id = 1, Category = "Music", Title = "Adversity to him to saw", Image = "Assets/music1.jpeg", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 2, Category = "Music", Title = "Adversity to him to saw", Image = "Assets/music2.jpeg", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 3, Category = "Music", Title = "Adversity to him to saw", Image = "Assets/music3.jpeg", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 4, Category = "Music", Title = "Adversity to him to saw", Image = "Assets/music4.jpeg", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 5, Category = "Music", Title = "Adversity to him to saw", Image = "Assets/music5.jpeg", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 6, Category = "Music", Title = "Adversity to him to saw", Image = "Assets/music6.jpeg", Content = "Land been nor was alone passed though old he yet" });


            items.Add(new NewItems() { Id = 7, Category = "Food", Title = "Adversity to him to saw", Image = "Assets/Food1.png", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 8, Category = "Food", Title = "Adversity to him to saw", Image = "Assets/Food2.png", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 9, Category = "Food", Title = "Adversity to him to saw", Image = "Assets/Food3.png", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 10, Category = "Food", Title = "Adversity to him to saw", Image = "Assets/Food4.png", Content = "Land been nor was alone passed though old he yet" });
            items.Add(new NewItems() { Id = 11, Category = "Food", Title = "Adversity to him to saw", Image = "Assets/Food5.png", Content = "Land been nor was alone passed though old he yet" });


            return items;

        }

        public static void GetItems(
            string category,ObservableCollection<NewItems> newItems)
        {
            var allItems = GetNewItems();

            var fillteredNewsItems = allItems
                .Where(p => p.Category == category).ToList();

            newItems.Clear();

            fillteredNewsItems.ForEach(p => newItems.Add(p));
        }
    }
}
