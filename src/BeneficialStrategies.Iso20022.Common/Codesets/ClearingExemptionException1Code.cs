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
[IsoId("_HPsxIIJUEeuDe9SyRl5qeg")]
[Description(@"Specifies the list of codes applicable to the clearing exemptions or exceptions.")]
[DerivedFrom(typeof(ClearingExemptionExceptionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClearingExemptionException1Code>))]
#endif
public enum ClearingExemptionException1Code
{
    /// <summary>
    /// Cooperative exemption.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_S5p20YJUEeuDe9SyRl5qeg")]
    [Description(@"Cooperative exemption.")]
    CooperativeExemption = ClearingExemptionExceptionCode.CooperativeExemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End user exemption.
    /// Encoded/decoded by serializers as &quot;ENDU&quot;.
    /// </summary>
    [EnumMember(Value = "ENDU")]
    [IsoId("_S-7YYYJUEeuDe9SyRl5qeg")]
    [Description(@"End user exemption.")]
    EndUserException = ClearingExemptionExceptionCode.EndUserException, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inter affiliate exemption.
    /// Encoded/decoded by serializers as &quot;AFFL&quot;.
    /// </summary>
    [EnumMember(Value = "AFFL")]
    [IsoId("_TEueYYJUEeuDe9SyRl5qeg")]
    [Description(@"Inter affiliate exemption.")]
    InterAffiliateExemption = ClearingExemptionExceptionCode.InterAffiliateExemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No action letter relief.
    /// Encoded/decoded by serializers as &quot;NOAL&quot;.
    /// </summary>
    [EnumMember(Value = "NOAL")]
    [IsoId("_TMvK4YJUEeuDe9SyRl5qeg")]
    [Description(@"No action letter relief.")]
    NoActionLetterRelief = ClearingExemptionExceptionCode.NoActionLetterRelief, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No reason.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_TR5-wYJUEeuDe9SyRl5qeg")]
    [Description(@"No reason.")]
    NoReason = ClearingExemptionExceptionCode.NoReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_TaAK0YJUEeuDe9SyRl5qeg")]
    [Description(@"Other.")]
    Other = ClearingExemptionExceptionCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Small bank exemption
    /// Encoded/decoded by serializers as &quot;SMBK&quot;.
    /// </summary>
    [EnumMember(Value = "SMBK")]
    [IsoId("_RAOj8YKVEeyorOAHyQphIA")]
    [Description(@"Small bank exemption")]
    SmallBankExemption = ClearingExemptionExceptionCode.SmallBankExemption, // same ordinal as derivation source for type conversions
}
