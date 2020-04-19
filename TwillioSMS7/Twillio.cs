// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Twillio
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        // DANGER! This is insecure. See http://twil.io/secure
        const string accountSid = "accountSid";
        const string authToken = "authToken";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
            from: new Twilio.Types.PhoneNumber("+yourTwillioPhNo"),
            to: new Twilio.Types.PhoneNumber("+verifiedPhoneNUmberOnlyForTestingUseGoogleRichNumber")
        );

        Console.WriteLine(message.Sid);
    }
}