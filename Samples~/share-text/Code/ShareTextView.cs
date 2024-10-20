using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DreamCode.EasyShare.Samples
{
    public sealed class ShareTextView : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _inputField;
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
            var message = "Text you want to share";
            if (!string.IsNullOrEmpty(_inputField.text))
                message = _inputField.text;

            ShareService.SendText(
                message: message,
                sharedByActivity: packageName => { Debug.Log("SendBinaryContent callback:" + packageName); });
        }
    }
}