// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classification of an investor in relation to a corporate action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YPf04K5oEfCUHaCK5HWOhg")]
[Description(@"Classification of an investor in relation to a corporate action.")]
[Derivations(typeof(InvestorClassificationType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InvestorClassificationTypeCode>))]
public enum InvestorClassificationTypeCode
{
    /// <summary>
    /// Investors eligible for participation in the event.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_paBAIK5oEfCUHaCK5HWOhg")]
    [Description(@"Investors eligible for participation in the event.")]
    Eligible,

    /// <summary>
    /// Investors not eligible for participation in the event.
    /// Encoded/decoded by serializers as &quot;NLIG&quot;.
    /// </summary>
    [EnumMember(Value = "NLIG")]
    [IsoId("_tltkgK5oEfCUHaCK5HWOhg")]
    [Description(@"Investors not eligible for participation in the event.")]
    NonEligible,

    /// <summary>
    /// Investors not eligible for participation in the event under US regulation.
    /// Encoded/decoded by serializers as &quot;NQIB&quot;.
    /// </summary>
    [EnumMember(Value = "NQIB")]
    [IsoId("_4wW4AK5oEfCUHaCK5HWOhg")]
    [Description(@"Investors not eligible for participation in the event under US regulation.")]
    NonQIB,

    /// <summary>
    /// Investors that may/may not be eligible to participate in the event as described by the issuer.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-Ik54K5oEfCUHaCK5HWOhg")]
    [Description(@"Investors that may/may not be eligible to participate in the event as described by the issuer.")]
    Other,

    /// <summary>
    /// Investors eligible for participation in the event as deemed qualified under US regulation.
    /// Encoded/decoded by serializers as &quot;QUIB&quot;.
    /// </summary>
    [EnumMember(Value = "QUIB")]
    [IsoId("_ydeksK5oEfCUHaCK5HWOhg")]
    [Description(@"Investors eligible for participation in the event as deemed qualified under US regulation.")]
    QIB,
}
