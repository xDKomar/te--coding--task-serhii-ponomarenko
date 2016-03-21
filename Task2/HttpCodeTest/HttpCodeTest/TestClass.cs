using System.Net;
using NUnit.Framework;

namespace HttpCodeTest
{
    [TestFixture()]
    public class TestClass
    {
        private HttpWebRequest task;
        private HttpWebResponse taskresponse;

        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void OKStatusCodeTest()
        {
            task = (HttpWebRequest)WebRequest.Create("http://zalando-edinc.rhcloud.com/status_codes/200");
            taskresponse = GetResponse(task);
            Assert.AreEqual(HttpStatusCode.OK, taskresponse.StatusCode);
        }

        [Test]
        public void MovedStatusCodeTest()
        {
            task = (HttpWebRequest) WebRequest.Create("http://zalando-edinc.rhcloud.com/status_codes/301");
            taskresponse = GetResponse(task);
            Assert.AreEqual(HttpStatusCode.Moved, taskresponse.StatusCode);
        }

        [Test]
        public void NotFoundStatusCodeTest()
        {

            task = (HttpWebRequest)WebRequest.Create("http://zalando-edinc.rhcloud.com/status_codes/404");
            taskresponse = GetResponse(task);
            Assert.AreEqual(HttpStatusCode.NotFound, taskresponse.StatusCode);
        }

        [Test]
        public void InternalServerErrorStatusCodeTest()
        {
            task = (HttpWebRequest)WebRequest.Create("http://zalando-edinc.rhcloud.com/status_codes/500");
            taskresponse = GetResponse(task);
            Assert.AreEqual(HttpStatusCode.InternalServerError, taskresponse.StatusCode);
        }

        [TearDown]
        public void TearDown()
        {
        }

        private HttpWebResponse GetResponse(HttpWebRequest request)
        {
            try
            {
                return (HttpWebResponse)request.GetResponse();
            }
            catch (WebException we)
            {
                return we.Response as HttpWebResponse;
            }
        }
    }
}
