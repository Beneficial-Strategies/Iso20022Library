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
[IsoId("_bd6y0Np-Ed-ak6NoX_4Aeg_-1317012923")]
[Description(@"Specifies the type of certification required.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BeneficiaryCertificationType2Code>))]
#endif
public enum BeneficiaryCertificationType2Code
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as &quot;ACCI&quot;.
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_bd6y0dp-Ed-ak6NoX_4Aeg_-941139863")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D."
    )]
    AccreditedInvestor = BeneficiaryCertificationTypeCode.AccreditedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to certify his domicile.
    /// Encoded/decoded by serializers as &quot;DOMI&quot;.
    /// </summary>
    [EnumMember(Value = "DOMI")]
    [IsoId("_bd6y0tp-Ed-ak6NoX_4Aeg_-911589219")]
    [Description(@"The holder of the security has to certify his domicile.")]
    DomicileCountry = BeneficiaryCertificationTypeCode.DomicileCountry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// Encoded/decoded by serializers as &quot;NDOM&quot;.
    /// </summary>
    [EnumMember(Value = "NDOM")]
    [IsoId("_bd6y09p-Ed-ak6NoX_4Aeg_1124028988")]
    [Description(
        @"The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated."
    )]
    NonDomicileCountry = BeneficiaryCertificationTypeCode.NonDomicileCountry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_bd6y1Np-Ed-ak6NoX_4Aeg_-882036050")]
    [Description(
        @"The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose."
    )]
    FullBeneficialOwnerBreakdown = BeneficiaryCertificationTypeCode.FullBeneficialOwnerBreakdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_bd6y1dp-Ed-ak6NoX_4Aeg_-602210666")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany = BeneficiaryCertificationTypeCode.NonCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as &quot;QIBB&quot;.
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_bd6y1tp-Ed-ak6NoX_4Aeg_-568963910")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A."
    )]
    QIBCertification = BeneficiaryCertificationTypeCode.QIBCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer.
    /// Encoded/decoded by serializers as &quot;TRBD&quot;.
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_bd6y19p-Ed-ak6NoX_4Aeg_-509857541")]
    [Description(
        @"The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer."
    )]
    TaxRateBreakdown = BeneficiaryCertificationTypeCode.TaxRateBreakdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates if the Beneficial Owner is responsible to fill in the paperwork.
    /// Encoded/decoded by serializers as &quot;PAPW&quot;.
    /// </summary>
    [EnumMember(Value = "PAPW")]
    [IsoId("_bd6y2Np-Ed-ak6NoX_4Aeg_1696566755")]
    [Description(@"Indicates if the Beneficial Owner is responsible to fill in the paperwork.")]
    BeneficialOwnerPaperwork = BeneficiaryCertificationTypeCode.BeneficialOwnerPaperwork, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The (I)CSD has to provide its participants&apos; details for disclosure purpose to the issuer/issuer’s agent.
    /// Encoded/decoded by serializers as &quot;PABD&quot;.
    /// </summary>
    [EnumMember(Value = "PABD")]
    [IsoId("_bd6y2dp-Ed-ak6NoX_4Aeg_1414201130")]
    [Description(
        @"The (I)CSD has to provide its participants' details for disclosure purpose to the issuer/issuer’s agent."
    )]
    ICSDParticipantBreakdown = BeneficiaryCertificationTypeCode.ICSDParticipantBreakdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See narrative field for certification requirements.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_beD8wNp-Ed-ak6NoX_4Aeg_-1388770382")]
    [Description(@"See narrative field for certification requirements.")]
    NarrativeDescription = BeneficiaryCertificationTypeCode.NarrativeDescription, // same ordinal as derivation source for type conversions
}
