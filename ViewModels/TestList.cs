using BlazorServer.Data;

namespace BlazorServer.ViewModels
{
    public class TestList
    {
        public List<Test> Testovi { get; set; }

        public TestList(PrimerServis ps)
        {
            Testovi = ps.GetAllTests();
        }
    }
}