﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Shopping.WebUI.Tests.Mocks
{
    public class MockHttpContext : HttpContextBase
    {
        private MockResponse response;
        private MockRequest request;
        private HttpCookieCollection cookies;

        public MockHttpContext()
        {
            cookies = new HttpCookieCollection();
            this.response = new MockResponse(cookies);
            this.request = new MockRequest(cookies);
        }

        public override HttpResponseBase Response
        {
            get { return response; }
        }

        public override HttpRequestBase Request
        {
            get { return request; }
        }
    }


    public class MockResponse : HttpResponseBase
    {
        private readonly HttpCookieCollection cookies;

        public MockResponse(HttpCookieCollection cookies)
        {
            this.cookies = cookies;
        }

        public override HttpCookieCollection Cookies
        {
            get { return cookies;  }
        }
    }

    public class MockRequest : HttpRequestBase
    {
        private readonly HttpCookieCollection cookies;

        public MockRequest(HttpCookieCollection cookies)
        {
            this.cookies = cookies;
        }

        public override HttpCookieCollection Cookies
        {
            get { return cookies; }
        }
    }

}
