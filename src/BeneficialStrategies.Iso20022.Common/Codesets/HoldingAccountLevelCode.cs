// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of the safekeeping holding account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SvcYkU1pEeSvz4A_x0ui8g")]
[Description(@"Specifies the level of the safekeeping holding account.")]
[Derivations(typeof(HoldingAccountLevel1Code))]
public enum HoldingAccountLevelCode
{
    /// <summary>
    /// Holding account is defined as the safekeeping account (Level 0).
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_H5588E1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the safekeeping account (Level 0).")]
    SafekeepingAccount,
    
    /// <summary>
    /// Holding account is defined as the sub-level 1 account.
    /// Encoded/decoded by serializers as &quot;LVL1&quot;.
    /// </summary>
    [EnumMember(Value = "LVL1")]
    [IsoId("_Mx4_kU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 1 account.")]
    Level1,
    
    /// <summary>
    /// Holding account is defined as the sub-level 2 account.
    /// Encoded/decoded by serializers as &quot;LVL2&quot;.
    /// </summary>
    [EnumMember(Value = "LVL2")]
    [IsoId("_NgcusU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 2 account.")]
    Level2,
    
    /// <summary>
    /// Holding account is defined as the sub-level 3 account.
    /// Encoded/decoded by serializers as &quot;LVL3&quot;.
    /// </summary>
    [EnumMember(Value = "LVL3")]
    [IsoId("_N1bgMU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 3 account.")]
    Level3,
    
    /// <summary>
    /// Holding account is defined as the sub-level 4 account.
    /// Encoded/decoded by serializers as &quot;LVL4&quot;.
    /// </summary>
    [EnumMember(Value = "LVL4")]
    [IsoId("_ONh3IU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 4 account.")]
    Level4,
    
    /// <summary>
    /// Holding account is defined as the sub-level 5 account.
    /// Encoded/decoded by serializers as &quot;LVL5&quot;.
    /// </summary>
    [EnumMember(Value = "LVL5")]
    [IsoId("_OgblAU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 5 account.")]
    Level5,
    
    /// <summary>
    /// Holding account is defined as the sub-level 6 account.
    /// Encoded/decoded by serializers as &quot;LVL6&quot;.
    /// </summary>
    [EnumMember(Value = "LVL6")]
    [IsoId("_O0z5kU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 6 account.")]
    Level6,
    
    /// <summary>
    /// Holding account is defined as the sub-level 7 account.
    /// Encoded/decoded by serializers as &quot;LVL7&quot;.
    /// </summary>
    [EnumMember(Value = "LVL7")]
    [IsoId("_PFUawU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 7 account.")]
    Level7,
    
    /// <summary>
    /// Holding account is defined as the sub-level 8 account.
    /// Encoded/decoded by serializers as &quot;LVL8&quot;.
    /// </summary>
    [EnumMember(Value = "LVL8")]
    [IsoId("_PUpQMU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 8 account.")]
    Level8,
    
    /// <summary>
    /// Holding account is defined as the sub-level 9 account.
    /// Encoded/decoded by serializers as &quot;LVL9&quot;.
    /// </summary>
    [EnumMember(Value = "LVL9")]
    [IsoId("_Pj0UoU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 9 account.")]
    Level9,
    
}
