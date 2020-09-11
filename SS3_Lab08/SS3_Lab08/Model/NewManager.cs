using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3_Lab08.Model
{
    class NewManager
    {
        public static List<NewsItem> GetNewItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Financial1.png" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "Sua carissime segreto", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Financial2.png" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Financial3.png" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Financial4.png" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Financial5.png" });


            items.Add(new NewsItem() { Id = 6, Category = "Food", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Food1.png" });
            items.Add(new NewsItem() { Id = 7, Category = "Food", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Food2.png" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Food3.png" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Food4.png" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", Headline = "Sed magna gubergren", DateLine = "Labore no takimata", Subhead = "Dolores tempor erat lobortis", Image = "Assets/Food5.png" });

            return items;
        }



        public static void GetNews(
                    string category,
                    ObservableCollection<NewsItem> newItems)
        {
            var allItems = GetNewItems();

            var fillteredNewsItems = allItems
                .Where(p => p.Category  == category).ToList();

            newItems.Clear();

            fillteredNewsItems.ForEach(p => newItems.Add(p));
        }
    }
}
