namespace xv1Bomb.providers
{
    public class deliveryProvider : smsProvider
    {
        public string link { get; set; } = "https://2-berega.ru/api/shop/auth/client/password/temporary/request";
        public string json { get; set; } = @"{""showcase"":""1"",""regionId"":""24841358-2f14-11e3-82a9-005056ae58ca"",""language"":""ru"",""mobilePhone"":""7@""}";
    }
}