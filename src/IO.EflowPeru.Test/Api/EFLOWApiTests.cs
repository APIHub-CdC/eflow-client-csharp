using NUnit.Framework;
using IO.EflowPeru.Api;
using IO.EflowPeru.Model;

namespace IO.EflowPeru.Test
{
    [TestFixture]
    public class EFLOWApiTests
    {
        private string xApiKey;
        private string username;
        private string password;
        private EFLOWApi api;
        private EFLOWApi instance;
        [SetUp]
        public void Init()
        {
            string basePath = "the_url";
            this.xApiKey = "your_api_key";
            this.username = "your_username";
            this.password = "your_password";
            this.api = new EFLOWApi(basePath);
        }
        [Test]
        public void EflowTest()
        {
            Peticion request = new Peticion();
            request.Folio = "XXXXXXXX";
            request.TipoDocumento = "X";
            request.NumeroDocumento = "XXXXXXXX";
            var response = this.api.Eflow(this.xApiKey, this.username, this.password, request);
            Assert.IsInstanceOf<Respuesta> (response, "response is Respuesta");
        }
        
    }
}
