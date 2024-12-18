using System;
using Script.Utility;

namespace Utility.ToolTips
{
    public class ToolTipSystem : Singleton<ToolTipSystem>
    {
        public ToolTip movementToolTip;

        public static void Show(string content,ToolTipType type,string header = "",string buffValue = "",string coldTime = "")
        {
            switch (type)
            {
                case ToolTipType.动作介绍框:
                    Instance.movementToolTip.SetText(content, header);
                    Instance.movementToolTip.gameObject.SetActive(true);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Hide()
        {
            Instance.movementToolTip.gameObject.SetActive(false);
        }
    }

    public enum ToolTipType
    {
        动作介绍框,
        筹码介绍框,
        Buff介绍框,
    }
}
