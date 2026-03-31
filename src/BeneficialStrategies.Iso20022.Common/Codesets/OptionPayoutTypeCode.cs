// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of payout that will result from an in-the-money option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_paSd4abDEeSxuMLA5o46jQ")]
[Description(@"Indicates the type of payout that will result from an in-the-money option.")]
[Derivations(typeof(OptionPayoutType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionPayoutTypeCode>))]
#endif
public enum OptionPayoutTypeCode
{
    /// <summary>
    /// Indicates the type of vanilla option.
    /// Encoded/decoded by serializers as &quot;VANI&quot;.
    /// </summary>
    [EnumMember(Value = "VANI")]
    [IsoId("_dV968KbEEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of vanilla option.")]
    Vanilla,

    /// <summary>
    /// Indicates the type of capped option.
    /// Encoded/decoded by serializers as &quot;CAPP&quot;.
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_dhVdcKbEEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of capped option.")]
    Capped,

    /// <summary>
    /// Indicates the type of binaryoption.
    /// Encoded/decoded by serializers as &quot;BINA&quot;.
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_dlwqcKbEEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of binaryoption.")]
    Binary,
}
