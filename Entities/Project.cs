namespace PortfolioSite.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Decription { get; set; }
        public string? ImageUrl { get; set; }

        public string? ProjectUrl { get; set; }
    }
}
