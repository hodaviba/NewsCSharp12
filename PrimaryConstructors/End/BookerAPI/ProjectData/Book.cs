namespace BookerAPI.ProjectData
{
    public class Book(string title, string author, int year, int id)
    {
        public Book() : this("Blood and fire", "George Martin", 2010, 4)
        { }

        public int Id => id;
        public string Title => title;
        public string Author => author;
        public int Year => year;
    }
}