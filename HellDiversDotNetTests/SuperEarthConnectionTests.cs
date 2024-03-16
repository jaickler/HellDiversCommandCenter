using FluentAssertions;
using HellDiversDotNet.Models;
using HellDiversDotNet.Services;

namespace HellDiversDotNetTests
{
    [TestClass]
    public class SuperEarthConnectionTests
    {
        private SuperEarthConnection superEarthConnection = new();

        [TestInitialize]
        public void Initialize()
        {
            superEarthConnection = new SuperEarthConnection();
        }

        [TestMethod]
        public async Task GetBaseReturnsBaseContent()
        {
            var baseContent = await superEarthConnection.GetBaseContentAsync();

            baseContent.Should().NotBeNull();
            baseContent.Should().BeOfType<BaseContent>(
                because: "the function should return a BaseContent object.");
        }

        [TestMethod]
        public async Task GetEventsReturnsList()
        {
            var events = await superEarthConnection.GetEventsAsync();

            events.Should().NotBeNull();
            events.Should().BeOfType<List<Event>>(
                because: "the function should return a list of events.");
        }

        [TestMethod]
        public async Task GetLatestEventReturnsEvent()
        {
            var latestEvent = await superEarthConnection.GetLatestEventAsync();

            latestEvent.Should().NotBeNull();
            latestEvent.Should().BeOfType<Event>(
                because: "the function should return an event.");
        }

        [TestMethod]
        public async Task GetWarReturnsWar()
        {
            var war = await superEarthConnection.GetWarAsync();

            war.Should().NotBeNull();
            war.Should().BeOfType<War>(
                because: "the function should return a war(For Super Earth).");
        }

        [TestMethod]
        public async Task GetPlanetReturnsPlanet()
        {
            var planet = await superEarthConnection.GetPlanetAsync(0);

            planet.Should().NotBeNull();
            planet.Should().BeOfType<Planet>(
                because: "the function should return a planet.");
        }

        [TestMethod]
        public async Task GetPlanetsReturnsList()
        {
            var planets = await superEarthConnection.GetPlanetsAsync();

            planets.Should().NotBeNull();
            planets.Should().BeOfType<List<Planet>>(
                because: "the function should return a list of planets.");
        }

        [TestMethod]
        public async Task GetPlanetWarStatusReturnPlanetStatus()
        {
            var planetStatus = await superEarthConnection.GetPlanetWarStatusAsync(0);

            planetStatus.Should().NotBeNull();
            planetStatus.Should().BeOfType<PlanetWarStatus>(
                because: "the function should return a planet's status in the war.");
        }

        [TestMethod]
        public async Task GetWarStatusReturnWarStatus()
        {
            var warStatus = await superEarthConnection.GetWarStatusAsync();

            warStatus.Should().NotBeNull();
            warStatus.Should().BeOfType<WarStatus>(
                because: "the function should return a war status.");
        }
    }
}