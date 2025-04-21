namespace Maple.Ring.Metadata
{
    /// <summary>
    /// ["Assembly-CSharp.dll".""."SkillType"]
    /// </summary>
    public enum SkillType : System.Int32
    {
        Harmed = 0x00000001,
        Treated = 0x00000002,
        RecoverMP = 0x00000003,
        Buff = 0x00000004,
        Debuff = 0x00000005,
        Upgrade = 0x00000006,
        CostHP = 0x00000007,
        CostMP = 0x00000008,
        RemoveDebuff = 0x00000009
    }
}