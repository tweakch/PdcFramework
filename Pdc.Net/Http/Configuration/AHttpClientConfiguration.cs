﻿using Pdc.Net.Http.Validation;
using System.Net.Http.Headers;

namespace Pdc.Net.Http.Configuration
{
    public abstract class AHttpClientConfiguration : IHttpClientConfiguration
    {
        public static IHttpClientConfiguration DefaultConfiguration => new DefaultHttpClientConfiguration();

        public HttpContentHeaders ValidHeaders { get; set; }
        public IHttpContentValidator ContentValidator => new HttpContentValidator();
    }
}