using IOTLinkAPI.Addons;
using IOTLinkAPI.Platform.Events.MQTT;
using System.Speech.Synthesis;

namespace IOTLinkAddon
{
    public class TTSService : ServiceAddon
    {
        public override void Init(IAddonManager addonManager)
        {
            base.Init(addonManager);

            GetManager().SubscribeTopic(this, "speak", OnSpeakMessage);
        }

        private void OnSpeakMessage(object sender, MQTTMessageEventEventArgs e)
        {
            string message = e.Message.GetPayload();
            if (string.IsNullOrWhiteSpace(message))
            {
                return;
            }

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.Speak(message);
            }
        }
    }
}
