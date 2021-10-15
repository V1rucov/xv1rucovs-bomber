using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace xv1Bomb.providers
{
    public class sushiStudioProvider : smsProvider
    {
        public string link { get; set; } = @"https://irkutsk.sushi-studio.ru/api/common/user/access/login/phone/request";
        public string json { get; set; } = @"{""login"":""+7@""}";
    }
}