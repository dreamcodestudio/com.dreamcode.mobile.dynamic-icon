namespace DreamCode.DynamicIcon
{
    public static class IconChangerService
    {
        private static readonly IIconChanger _iconChanger = IconChangerFactory.Create();

        public static void Setup(string[] iconList) => _iconChanger.Setup(iconList);
        public static void ApplyAlternateIcon(string iconName) => _iconChanger.ApplyAlternateIcon(iconName);
    }
}