using System;
using System.Runtime.InteropServices;

namespace DreamCode.DynamicIcon
{
    internal sealed class iOSIconChanger : IIconChanger
    {
        /*
        private readonly iOSShareListener? _listener =
            ListenerFactory.Create<iOSShareListener>();
        
        [DllImport("__Internal")]
        private static extern void _ES_SendText(string message);
        [DllImport("__Internal")]
        private static extern void _ES_SendBinaryContent(string message, string filePath);

        public void SendText(string message, Action<string>? callback)
        {
            if (_listener == null)
                throw new InvalidOperationException(
                    $"{nameof(iOSShare)}-{nameof(SendText)}-{nameof(_listener)} not created");

            _listener.ShareCompleted = callback;
            _ES_SendText(message);
        }

        public void SendBinaryContent(string filePath, string mimeType, string message, Action<string>? callback)
        {
            if (_listener == null)
                throw new InvalidOperationException(
                    $"{nameof(iOSShare)}-{nameof(SendBinaryContent)}-{nameof(_listener)} not created");

            _listener.ShareCompleted = callback;
            _ES_SendBinaryContent(message, filePath);
        }
        */

        public void Setup(string[] iconList)
        {
            throw new NotImplementedException();
        }

        public void ApplyAlternateIcon(string iconName)
        {
            throw new NotImplementedException();
        }
    }
}