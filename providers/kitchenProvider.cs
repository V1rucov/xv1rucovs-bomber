using System;

namespace xv1Bomb.providers
{
    public class kitchenProvider : smsProvider
    {
        public string link { get; set; } = @"https://tomsk.mirsushi.com/s/get-registration-confirm-code.json";
        public string json { get; set; } = @"{ ""register_phone"": ""+7@"",""register_name"":""ohaajsodsajo""}";
    }
}