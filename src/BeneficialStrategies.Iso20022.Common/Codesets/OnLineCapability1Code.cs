// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// On-line and off-line capabilities of the POI (Point Of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTZvTgEcEeCQm6a_G2yO_w_-1858574023")]
[Description(@"On-line and off-line capabilities of the POI (Point Of Interaction).")]
[DerivedFrom(typeof(OnLineCapabilityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OnLineCapability1Code>))]
#endif
public enum OnLineCapability1Code
{
    /// <summary>
    /// Off-line only capable.
    /// Encoded/decoded by serializers as &quot;OFLN&quot;.
    /// </summary>
    [EnumMember(Value = "OFLN")]
    [IsoId("_TTZvTwEcEeCQm6a_G2yO_w_-1526230168")]
    [Description(@"Off-line only capable.")]
    OffLine = OnLineCapabilityCode.OffLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On-line only capable.
    /// Encoded/decoded by serializers as &quot;ONLN&quot;.
    /// </summary>
    [EnumMember(Value = "ONLN")]
    [IsoId("_TTZvUAEcEeCQm6a_G2yO_w_-1586477855")]
    [Description(@"On-line only capable.")]
    OnLine = OnLineCapabilityCode.OnLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Off-line capable with possible on-line requests to the acquirer.
    /// Encoded/decoded by serializers as &quot;SMON&quot;.
    /// </summary>
    [EnumMember(Value = "SMON")]
    [IsoId("_TTZvUQEcEeCQm6a_G2yO_w_350747318")]
    [Description(@"Off-line capable with possible on-line requests to the acquirer.")]
    SemiOffLine = OnLineCapabilityCode.SemiOffLine, // same ordinal as derivation source for type conversions
}
