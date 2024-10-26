using System.Runtime.InteropServices;

namespace DreamCode.DynamicIcon
{
    internal sealed class iOSIconChanger : IIconChanger
    {
        [DllImport("__Internal")]
        private static extern void _DI_Setup(string[] icons, int count);

        [DllImport("__Internal")]
        private static extern void _DI_ApplyAlternateIcon(string iconName);

        public void Setup(string[] icons)
        {
            _DI_Setup(icons, icons.Length);
        }

        public void ApplyAlternateIcon(string iconName)
        {
            _DI_ApplyAlternateIcon(iconName);
        }
    }
}