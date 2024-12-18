using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Utility.ToolTips
{
    [ExecuteInEditMode()]
    public class ToolTip : MonoBehaviour
    {
        public TextMeshProUGUI headerField;
        public TextMeshProUGUI contentField;
        public LayoutElement layoutElement;
        [SerializeField]private RectTransform rectTransform;
        public int characterWrapLimit;

        public virtual void SetText(string content, string header = "", string buffValue = "",string coldTime = "")
        {
            if (string.IsNullOrEmpty(header))
            {
                headerField.gameObject.SetActive(false);
            }
            else
            {
                headerField.gameObject.SetActive(true);
                headerField.text = header;
            }
            contentField.text = content;
        }
        
        private void Update()
        {
            if (Application.isEditor)
            {
                
                int headerLength = headerField.text.Length;
                int contentLength = contentField.text.Length;
            
                layoutElement.enabled =
                    (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;
            }

            Vector2 position = Input.mousePosition;

            float pivotX = position.x / Screen.width;
            float pivotY = position.y / Screen.height;

            rectTransform.pivot = new Vector2(pivotX, pivotY);
            
            transform.position = position;
        }
    }
}
