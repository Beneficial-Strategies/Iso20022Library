// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the list of codes applicable to the clearing exemptions or exceptions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vMoZsIJTEeuDe9SyRl5qeg")]
[Description(@"Specifies the list of codes applicable to the clearing exemptions or exceptions.")]
[Derivations(typeof(ClearingExemptionException1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClearingExemptionExceptionCode>))]
#endif
public enum ClearingExemptionExceptionCode
{
    /// <summary>
    /// End user exemption.
    /// Encoded/decoded by serializers as &quot;ENDU&quot;.
    /// </summary>
    [EnumMember(Value = "ENDU")]
    [IsoId("_xGxLIIJTEeuDe9SyRl5qeg")]
    [Description(@"End user exemption.")]
    EndUserException,

    /// <summary>
    /// Inter affiliate exemption.
    /// Encoded/decoded by serializers as &quot;AFFL&quot;.
    /// </summary>
    [EnumMember(Value = "AFFL")]
    [IsoId("_0FpXEIJTEeuDe9SyRl5qeg")]
    [Description(@"Inter affiliate exemption.")]
    InterAffiliateExemption,

    /// <summary>
    /// Small bank exemption
    /// Encoded/decoded by serializers as &quot;SMBK&quot;.
    /// </summary>
    [EnumMember(Value = "SMBK")]
    [IsoId("_3ErUAIJTEeuDe9SyRl5qeg")]
    [Description(@"Small bank exemption")]
    SmallBankExemption,

    /// <summary>
    /// Cooperative exemption.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_5E6tcIJTEeuDe9SyRl5qeg")]
    [Description(@"Cooperative exemption.")]
    CooperativeExemption,

    /// <summary>
    /// No action letter relief.
    /// Encoded/decoded by serializers as &quot;NOAL&quot;.
    /// </summary>
    [EnumMember(Value = "NOAL")]
    [IsoId("_7TvVcIJTEeuDe9SyRl5qeg")]
    [Description(@"No action letter relief.")]
    NoActionLetterRelief,

    /// <summary>
    /// No reason.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_-yAzIIJTEeuDe9SyRl5qeg")]
    [Description(@"No reason.")]
    NoReason,

    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_A0x8IIJUEeuDe9SyRl5qeg")]
    [Description(@"Other.")]
    Other,
}
