﻿using NUnit.Framework;
using RestSharp;
using System;
using FluentAssertions;
using TechTalk.SpecFlow;
using System.Net;

namespace BlueSkyProject3.StepDefinitions
{
    [Binding]
    public class BasicAPITestSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have access to Github")]
        public void GivenIHaveAccessToGithub()
        {
            client = new RestClient("https://api.github.com/users/h3rck3r");
            client.Timeout = -1;

            client = new RestClient("https://api.github.com/users/h3rck3r");
            client.Timeout = -1;
        }


        [When(@"I search for a User")]
        public void WhenISearchForAUser()
        {
            request = new RestRequest(Method.GET);
            //request.AddHeader("Authorization", "Bearer 1234567");
            //request.AddHeader("Authorization", "Basic  advvhhhbhbjnjnjnk");

            response = client.Execute(request);
        }


        [When(@"I search a userpost")]
        public void WhenISearchAUserpost()
        {
            request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic gguuuhhiohoidoiioouiiiji");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("username", "AbelAndcoleTechnicalTest");
            request.AddParameter("username", "BlueSkyCitadelTestFramework1");

            response = client.Execute(request);

        }

        [Then(@"the result is displayed")]
        public void ThenTheResultIsDisplayed()
        {
            Assert.That(response.Content.Length > 0);
            Assert.That(response.StatusCode.ToString() == "OK");
            Assert.That(response.IsSuccessful.ToString() == "True");

        }
        

        [Then(@"the details contain ""(.*)""")]
        public void ThenTheDetailsContain(string user)
        {
            response.Content.Should().Contain(user);
        }



    }
}
