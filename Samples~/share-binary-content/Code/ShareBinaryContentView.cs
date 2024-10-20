using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace DreamCode.EasyShare.Samples
{
    public sealed class ShareBinaryContentView : MonoBehaviour
    {
        [SerializeField] private Button _shareBtn;

        private void OnDisable()
        {
            _shareBtn.onClick.RemoveListener(OnShareBtnClicked);
        }

        private void OnEnable()
        {
            _shareBtn.onClick.AddListener(OnShareBtnClicked);
        }

        private void OnShareBtnClicked()
        {
            const string screenshotName = "Screen.png";
            ScreenCapture.CaptureScreenshot(screenshotName);
            var imagePath = Path.Combine(Application.persistentDataPath, screenshotName);

            ShareService.SendBinaryContent(
                filePath: imagePath,
                mimeType: MimeTypeNames.Image,
                message: "Content with image",
                sharedByActivity: packageName => { Debug.Log($"SendBinaryContent:{packageName}"); });
        }
    }
}