/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Verify.V2.Service.Entity;

namespace Twilio.Tests.Rest.Verify.V2.Service.Entity
{

    [TestFixture]
    public class ChallengeTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Challenges",
                ""
            );
            request.AddPostParam("FactorSid", Serialize("YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreatePushResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YF03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"pending\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": null,\"factor_type\": \"push\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}}"
                                     ));

            var response = ChallengeResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateTotpWithoutAuthPayloadResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YF02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"pending\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": null,\"factor_type\": \"totp\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}}"
                                     ));

            var response = ChallengeResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateTotpWithAuthPayloadResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YF02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"approved\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": null,\"factor_type\": \"totp\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}}"
                                     ));

            var response = ChallengeResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Challenges/YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Fetch("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchSidResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"approved\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": {\"os\": \"Android\"},\"factor_type\": \"push\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}}"
                                     ));

            var response = ChallengeResource.Fetch("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Challenges",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Read("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"challenges\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"challenges\"}}"
                                     ));

            var response = ChallengeResource.Read("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"challenges\": [{\"sid\": \"YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YF03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"pending\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": null,\"factor_type\": \"push\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}},{\"sid\": \"YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YF02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"pending\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": null,\"factor_type\": \"totp\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"challenges\"}}"
                                     ));

            var response = ChallengeResource.Read("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Challenges/YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Update("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestVerifyPushResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YF03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"approved\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": {\"os\": \"Android\"},\"factor_type\": \"push\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC03aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}}"
                                     ));

            var response = ChallengeResource.Update("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestVerifyTotpResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YF02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"approved\",\"responded_reason\": \"none\",\"details\": {\"message\": \"Hi! Mr. John Doe, would you like to sign up?\",\"date\": \"2020-07-01T12:13:14Z\",\"fields\": [{\"label\": \"Action\",\"value\": \"Sign up in portal\"}]},\"hidden_details\": {\"ip\": \"172.168.1.234\"},\"metadata\": null,\"factor_type\": \"totp\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"notifications\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Challenges/YC02aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Notifications\"}}"
                                     ));

            var response = ChallengeResource.Update("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}