// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certification required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beD8wdp-Ed-ak6NoX_4Aeg_-1668346228")]
[Description(@"Specifies the type of certification required.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BeneficiaryCertificationType3Code>))]
#endif
public enum BeneficiaryCertificationType3Code
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as &quot;ACCI&quot;.
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_beD8wtp-Ed-ak6NoX_4Aeg_-1668344657")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D."
    )]
    AccreditedInvestor = BeneficiaryCertificationTypeCode.AccreditedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_beD8w9p-Ed-ak6NoX_4Aeg_-1667421525")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany = BeneficiaryCertificationTypeCode.NonCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as &quot;QIBB&quot;.
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_beD8xNp-Ed-ak6NoX_4Aeg_-1667421153")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A."
    )]
    QIBCertification = BeneficiaryCertificationTypeCode.QIBCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See narrative field for certification requirements.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_beD8xdp-Ed-ak6NoX_4Aeg_1359889133")]
    [Description(@"See narrative field for certification requirements.")]
    NarrativeDescription = BeneficiaryCertificationTypeCode.NarrativeDescription, // same ordinal as derivation source for type conversions
}
