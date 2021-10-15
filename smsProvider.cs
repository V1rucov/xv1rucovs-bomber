using System.Net.Http;

namespace xv1Bomb
{
    public interface smsProvider
    {
        public string link { get; set; }
        public string json { get; set; }
    }
}