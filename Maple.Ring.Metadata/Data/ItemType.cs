namespace Maple.Ring.Metadata
{
    /// <summary>
    /// ["Assembly-CSharp.dll".""."ItemType"]
    /// </summary>
    public enum ItemType : System.Int32
    {
        Material = 0x00000001,
        Supplement = 0x00000002,
        Artifact = 0x00000003,
        SkillBook = 0x00000004,
        Others = 0x00000005,
        Money = 0x00000006,
        AlchemyRecipe = 0x00000007,
        ForgeRecipe = 0x00000008,
        Equipment = 0x00000009,
        Stove = 0x0000000A,
        StoveFire = 0x0000000B
    }
}