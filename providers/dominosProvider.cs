using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace xv1Bomb.providers
{
    public class dominosProvider : smsProvider
    {
        public string link { get; set; } = "https://yfe.dominospizza.ru/api/authentication/sendVerificationSms";
        public string json { get; set; } = @"{""phoneNumber"":""@""}";

    }
}