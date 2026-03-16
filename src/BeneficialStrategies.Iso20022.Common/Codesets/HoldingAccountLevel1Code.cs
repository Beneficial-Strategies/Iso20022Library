// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level at which the safekeeping holding account has been defined.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VKUfkE1pEeSvz4A_x0ui8g")]
[Description(@"Specifies the level at which the safekeeping holding account has been defined.")]
[DerivedFrom(typeof(HoldingAccountLevelCode))]
public enum HoldingAccountLevel1Code
{
    /// <summary>
    /// Holding account is defined as the safekeeping account (Level 0).
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_cNACsU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the safekeeping account (Level 0).")]
    SafekeepingAccount = HoldingAccountLevelCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 1 account.
    /// Encoded/decoded by serializers as &quot;LVL1&quot;.
    /// </summary>
    [EnumMember(Value = "LVL1")]
    [IsoId("_cUJMgU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 1 account.")]
    Level1 = HoldingAccountLevelCode.Level1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 2 account.
    /// Encoded/decoded by serializers as &quot;LVL2&quot;.
    /// </summary>
    [EnumMember(Value = "LVL2")]
    [IsoId("_cbIlUU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 2 account.")]
    Level2 = HoldingAccountLevelCode.Level2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 3 account.
    /// Encoded/decoded by serializers as &quot;LVL3&quot;.
    /// </summary>
    [EnumMember(Value = "LVL3")]
    [IsoId("_cdq78U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 3 account.")]
    Level3 = HoldingAccountLevelCode.Level3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 4 account.
    /// Encoded/decoded by serializers as &quot;LVL4&quot;.
    /// </summary>
    [EnumMember(Value = "LVL4")]
    [IsoId("_coYXIU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 4 account.")]
    Level4 = HoldingAccountLevelCode.Level4, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 5 account.
    /// Encoded/decoded by serializers as &quot;LVL5&quot;.
    /// </summary>
    [EnumMember(Value = "LVL5")]
    [IsoId("_cvhg8U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 5 account.")]
    Level5 = HoldingAccountLevelCode.Level5, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 6 account.
    /// Encoded/decoded by serializers as &quot;LVL6&quot;.
    /// </summary>
    [EnumMember(Value = "LVL6")]
    [IsoId("_c1nh4U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 6 account.")]
    Level6 = HoldingAccountLevelCode.Level6, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 7 account.
    /// Encoded/decoded by serializers as &quot;LVL7&quot;.
    /// </summary>
    [EnumMember(Value = "LVL7")]
    [IsoId("_c8T_wU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 7 account.")]
    Level7 = HoldingAccountLevelCode.Level7, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 8 account.
    /// Encoded/decoded by serializers as &quot;LVL8&quot;.
    /// </summary>
    [EnumMember(Value = "LVL8")]
    [IsoId("_dBrA4U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 8 account.")]
    Level8 = HoldingAccountLevelCode.Level8, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding account is defined as the sub-level 9 account.
    /// Encoded/decoded by serializers as &quot;LVL9&quot;.
    /// </summary>
    [EnumMember(Value = "LVL9")]
    [IsoId("_dHU88U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 9 account.")]
    Level9 = HoldingAccountLevelCode.Level9, // same ordinal as derivation source for type conversions
}
