using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;

namespace Generator
{
    internal static class Program
    {
        private static Task<int> Main(string[] args) =>
            Bootstrapper.Factory
                .CreateWeb(args)
                .RunAsync();
    }
}
