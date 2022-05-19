using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Gateway.PagerDuty;
using NSubstitute;
using Xunit;

namespace Domain.Services.Tests
{
    public class PagerDutyServicesTests
    {
        private readonly IPagerDutyGateway pagerDutyGateway;

        public PagerDutyServicesTests()
        {
            this.pagerDutyGateway = Substitute.For<IPagerDutyGateway>();
        }

        [Fact]
        public async Task GetAbilitiesAsync_ReturnsAbilities()
        {
            //Arrange
            this.pagerDutyGateway.GetAbilitiesAsync()
                .Returns(new List<string> { "dd", "xx" });

            //Act
            var result = await this.pagerDutyGateway.GetAbilitiesAsync();

            //Assert
            Assert.NotNull(result);
        }
    }
}