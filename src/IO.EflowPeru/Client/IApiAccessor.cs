using System;

namespace IO.EflowPeru.Client
{
    public interface IApiAccessor
    {
        Configuration Configuration {get; set;}
        String GetBasePath();
        ExceptionFactory ExceptionFactory { get; set; }
    }
}
