using System;
using RestSharp;
using RestSharp.Authenticators;

namespace ProcessStreet {
    class ChecklistCreator {

        const string ApiKey = "";
        const string OrganizationId = "";
        const string TemplateId = "";

        public static void Main(string[] args) {

            var client = new RestClient("https://api.process.st/1/checklists");
            client.Authenticator = new HttpBasicAuthenticator(ApiKey, "");

            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new {
                organizationId = OrganizationId,
                templateId = TemplateId,
                name = "Test Checklist"

            });

            Console.WriteLine("Executing request...");
            var response = client.Execute(request);
            Console.WriteLine("Response Http Status: " + response.StatusCode);

        }

    }
}
