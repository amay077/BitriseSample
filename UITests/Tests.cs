using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BitriseSample.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            string deviceUDID = Environment.GetEnvironmentVariable("IOS_SIMULATOR_UDID");
            string bundleID = "net.amay077.bitrisesample";

            ConfigureApp
                .iOS
                .InstalledApp(bundleID)
                .DeviceIdentifier(deviceUDID)
                .StartApp();

            //app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            app.WaitForElement(c => c.Marked("Welcome to Xamarin Forms!"));
            app.Screenshot("Welcome screen.");
            app.Tap(c => c.Marked("Push me!"));

            app.WaitForElement(c => c.Marked("PUSHED!!!"));
        }
    }
}

