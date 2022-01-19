namespace BlazorServer.Data
{
    public class PrimerServis
    {
        private Db Db { init; get; }

        public PrimerServis(Db db)
        {
            Db = db;
        }

        public List<Test> GetAllTests()
            => Db.Tests.ToList();
    }
}