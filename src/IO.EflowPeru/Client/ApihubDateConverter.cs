using Newtonsoft.Json.Converters;

namespace IO.EflowPeruSimulacion.Client
{
    public class ApihubDateConverter : IsoDateTimeConverter
    {
        public ApihubDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}