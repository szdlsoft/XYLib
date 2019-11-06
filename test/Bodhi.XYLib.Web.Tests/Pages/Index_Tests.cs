using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Bodhi.XYLib.Pages
{
    public class Index_Tests : XYLibWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
