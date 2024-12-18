namespace Script.Utility
{
    public enum CharacterType
    {
        剑士,
        奥术师,
        骑士,
        游侠,
        吟游诗人,
        僧人,
        冒险者,
        杀手,
        巫师,
        炼金术师
    }

    public enum MovementOrder
    {
        有序,
        无序,
        无
    }

    public enum PlayerSelect
    {
        无,
        左侧,
        右侧
    }
    
    public enum BattleState
    {
        幕间,
        投掷骰子决定先后手,
        等待先手玩家使用筹码,
        先手角色进行行动,
        等待后手玩家使用筹码,
        后手角色进行行动,
        战斗结束,
        战斗结算
    }

    public enum State
    {
        无,
        第1幕,
        第2幕,
        第3幕,
        第4幕,
        第5幕,
        游戏结束
    }

    public enum BuffType
    {
        战意,
        恐慌,
        反伤,
        保护,
        巡视,
        箭,
        回避,
        疗愈,
        休养,
        本能,
        中毒,
        易伤,
        劝善,
        激励,
        闪避,
        切换,
        急速,
        庇护,
        荆棘,
        力场红,
        毒药,
        镣铐,
        侵蚀,
        力场绿,
        热浪,
        风雪,
        微风,
        无,
    }

    public enum MovementType
    { 
        无,
        剑攻击,
        箭攻击,
        钝器攻击,
        魔法攻击,
        多段攻击,
        自身加盾,
        自身Buff,
        敌方Buff,
    }
    
    public enum BackGroundType
    {
        
    }
}