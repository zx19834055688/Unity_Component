using UnityEngine;
using UnityEngine.EventSystems;

namespace Utility.ToolTips
{
    public class ToolTipTrigger : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
    {
        public ToolTipType type;
        public string header;
        [TextArea] public string content;
        
        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            ToolTipSystem.Show(content, type, header);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            ToolTipSystem.Hide();
        }

        public void InitTrigger(string contentText, string headerText)
        {
            content = contentText;
            header = headerText;
        }
    }
}