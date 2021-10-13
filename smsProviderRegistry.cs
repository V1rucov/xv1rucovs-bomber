using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace xv1Bomb
{
    public static class smsProviderRegistry
    {
        private static List<smsProvider> _smsProviders = new List<smsProvider>();
        public static List<smsProvider> smsProviders {
            get {
                return _smsProviders;
            }
        }
        public static void Register(smsProvider provider) {
            _smsProviders.Add(provider);
        }
    }
}