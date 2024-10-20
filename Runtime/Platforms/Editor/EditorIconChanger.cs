using UnityEngine;

namespace DreamCode.DynamicIcon
{
    internal sealed class EditorIconChanger : IIconChanger
    {
        public void Setup(string[] iconList)
        {
            Debug.Log($"{nameof(EditorIconChanger)}-{nameof(Setup)}");
        }

        public void ApplyAlternateIcon(string iconName)
        {
            Debug.Log($"{nameof(EditorIconChanger)}-{nameof(ApplyAlternateIcon)}-{nameof(iconName)}:{iconName}");
        }
    }
}