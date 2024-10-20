namespace DreamCode.DynamicIcon
{
    internal interface IIconChanger
    {
        void Setup(string[] iconList);
        void ApplyAlternateIcon(string iconName);
    }
}