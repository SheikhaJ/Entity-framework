namespace ECore_class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var blog = new Blog()
            {
                Id = 1,
                blogTitle = "title",
                blogDescription = "description",

            };
            _context.Add(blog);
            _context.SaveChanges();
        }
    }
}