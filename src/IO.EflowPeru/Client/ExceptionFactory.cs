using System;
using RestSharp;

namespace IO.EflowPeru.Client
{
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
