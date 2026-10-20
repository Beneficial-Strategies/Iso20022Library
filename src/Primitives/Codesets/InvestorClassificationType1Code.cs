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
[IsoId("_EHUJMK5pEfCUHaCK5HWOhg")]
[Description(@"Classification of an investor in relation to a corporate action.")]
[DerivedFrom(typeof(InvestorClassificationTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InvestorClassificationType1Code>))]
public enum InvestorClassificationType1Code
{
    /// <summary>
    /// Investors eligible for participation in the event.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_Gl9V4a5pEfCUHaCK5HWOhg")]
    [Description(@"Investors eligible for participation in the event.")]
    Eligible = InvestorClassificationTypeCode.Eligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investors not eligible for participation in the event.
    /// Encoded/decoded by serializers as &quot;NLIG&quot;.
    /// </summary>
    [EnumMember(Value = "NLIG")]
    [IsoId("_Gpa5ka5pEfCUHaCK5HWOhg")]
    [Description(@"Investors not eligible for participation in the event.")]
    NonEligible = InvestorClassificationTypeCode.NonEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investors not eligible for participation in the event under US regulation.
    /// Encoded/decoded by serializers as &quot;NQIB&quot;.
    /// </summary>
    [EnumMember(Value = "NQIB")]
    [IsoId("_Gspzwa5pEfCUHaCK5HWOhg")]
    [Description(@"Investors not eligible for participation in the event under US regulation.")]
    NonQIB = InvestorClassificationTypeCode.NonQIB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investors that may/may not be eligible to participate in the event as described by the issuer.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Gx-Yoa5pEfCUHaCK5HWOhg")]
    [Description(@"Investors that may/may not be eligible to participate in the event as described by the issuer.")]
    Other = InvestorClassificationTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investors eligible for participation in the event as deemed qualified under US regulation.
    /// Encoded/decoded by serializers as &quot;QUIB&quot;.
    /// </summary>
    [EnumMember(Value = "QUIB")]
    [IsoId("_G1Bsoa5pEfCUHaCK5HWOhg")]
    [Description(@"Investors eligible for participation in the event as deemed qualified under US regulation.")]
    QIB = InvestorClassificationTypeCode.QIB, // same ordinal as derivation source for type conversions
}
