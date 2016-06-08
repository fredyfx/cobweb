using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cobweb.Testing.WebApi.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Cobweb.Testing.WebApi.Tests.Routing.GivenActionRoute {
    [TestFixture]
    public class WithRootUrl : GivenActionRoute {
        private const string CurrentUrl = "~/";

        [Test]
        public void ItShould404() {
            Action act = () => CurrentUrl.AsRequest().GetControllerDescriptor();
            act.ShouldThrow<HttpResponseException>().And.Response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Test]
        public void ItShould404OnDelete() {
            Action act = () => CurrentUrl.WithHttpMethod(HttpMethod.Delete).GetControllerDescriptor();
            act.ShouldThrow<HttpResponseException>().And.Response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Test]
        public void ItShould404OnGet() {
            Action act = () => CurrentUrl.WithHttpMethod(HttpMethod.Get).GetControllerDescriptor();
            act.ShouldThrow<HttpResponseException>().And.Response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Test]
        public void ItShould404OnPost() {
            Action act = () => CurrentUrl.WithHttpMethod(HttpMethod.Post).GetControllerDescriptor();
            act.ShouldThrow<HttpResponseException>().And.Response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Test]
        public void ItShould404OnPut() {
            Action act = () => CurrentUrl.WithHttpMethod(HttpMethod.Put).GetControllerDescriptor();
            act.ShouldThrow<HttpResponseException>().And.Response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}