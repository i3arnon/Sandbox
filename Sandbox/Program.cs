using System.Threading.Tasks;

namespace Sandbox
{
    public class Program
    {
        public static void Main() => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {

        }
    }
}