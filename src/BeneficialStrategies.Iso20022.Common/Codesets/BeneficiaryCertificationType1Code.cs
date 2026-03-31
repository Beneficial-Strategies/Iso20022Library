// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of beneficiary&apos;s certification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bdxB0tp-Ed-ak6NoX_4Aeg_609609088")]
[Description(@"Specifies the type of beneficiary's certification.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BeneficiaryCertificationType1Code>))]
#endif
public enum BeneficiaryCertificationType1Code
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as &quot;ACCI&quot;.
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_bdxB09p-Ed-ak6NoX_4Aeg_609609119")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D."
    )]
    AccreditedInvestor = BeneficiaryCertificationTypeCode.AccreditedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to certify his domicile.
    /// Encoded/decoded by serializers as &quot;DOMI&quot;.
    /// </summary>
    [EnumMember(Value = "DOMI")]
    [IsoId("_bdxB1Np-Ed-ak6NoX_4Aeg_609609150")]
    [Description(@"The holder of the security has to certify his domicile.")]
    DomicileCountry = BeneficiaryCertificationTypeCode.DomicileCountry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_bdxB1dp-Ed-ak6NoX_4Aeg_609609151")]
    [Description(
        @"The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose."
    )]
    FullBeneficialOwnerBreakdown = BeneficiaryCertificationTypeCode.FullBeneficialOwnerBreakdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as &quot;QIBB&quot;.
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_bdxB1tp-Ed-ak6NoX_4Aeg_609609160")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A."
    )]
    QIBCertification = BeneficiaryCertificationTypeCode.QIBCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer.
    /// Encoded/decoded by serializers as &quot;TRBD&quot;.
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_bdxB19p-Ed-ak6NoX_4Aeg_609609180")]
    [Description(
        @"The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer."
    )]
    TaxRateBreakdown = BeneficiaryCertificationTypeCode.TaxRateBreakdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_bdxB2Np-Ed-ak6NoX_4Aeg_609609181")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany = BeneficiaryCertificationTypeCode.NonCompany, // same ordinal as derivation source for type conversions
}
