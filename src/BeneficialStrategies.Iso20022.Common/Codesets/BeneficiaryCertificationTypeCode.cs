// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beD8xtp-Ed-ak6NoX_4Aeg_-2069893638")]
[Description(
    @"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A."
)]
[Derivations(
    typeof(BeneficiaryCertificationType2Code),
    typeof(BeneficiaryCertificationType5Code),
    typeof(BeneficiaryCertificationType4Code),
    typeof(BeneficiaryCertificationType1Code),
    typeof(BeneficiaryCertificationType3Code)
)]
public enum BeneficiaryCertificationTypeCode
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as &quot;ACCI&quot;.
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_beD8x9p-Ed-ak6NoX_4Aeg_-1894425952")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D."
    )]
    AccreditedInvestor,

    /// <summary>
    /// The holder of the security has to certify his domicile.
    /// Encoded/decoded by serializers as &quot;DOMI&quot;.
    /// </summary>
    [EnumMember(Value = "DOMI")]
    [IsoId("_beD8yNp-Ed-ak6NoX_4Aeg_-2071594551")]
    [Description(@"The holder of the security has to certify his domicile.")]
    DomicileCountry,

    /// <summary>
    /// The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// Encoded/decoded by serializers as &quot;NDOM&quot;.
    /// </summary>
    [EnumMember(Value = "NDOM")]
    [IsoId("_beNtwNp-Ed-ak6NoX_4Aeg_743537394")]
    [Description(
        @"The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated."
    )]
    NonDomicileCountry,

    /// <summary>
    /// The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_beNtwdp-Ed-ak6NoX_4Aeg_-738954678")]
    [Description(
        @"The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose."
    )]
    FullBeneficialOwnerBreakdown,

    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as &quot;QIBB&quot;.
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_beNtwtp-Ed-ak6NoX_4Aeg_-1926748597")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A."
    )]
    QIBCertification,

    /// <summary>
    /// The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer.
    /// Encoded/decoded by serializers as &quot;TRBD&quot;.
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_beNtw9p-Ed-ak6NoX_4Aeg_-313211531")]
    [Description(
        @"The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer."
    )]
    TaxRateBreakdown,

    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_beNtxNp-Ed-ak6NoX_4Aeg_218735633")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany,

    /// <summary>
    /// Indicates if the Beneficial Owner is responsible to fill in the paperwork.
    /// Encoded/decoded by serializers as &quot;PAPW&quot;.
    /// </summary>
    [EnumMember(Value = "PAPW")]
    [IsoId("_beNtxdp-Ed-ak6NoX_4Aeg_1877415365")]
    [Description(@"Indicates if the Beneficial Owner is responsible to fill in the paperwork.")]
    BeneficialOwnerPaperwork,

    /// <summary>
    /// The (I)CSD has to provide its participants&apos; details for disclosure purpose to the issuer/issuer’s agent.
    /// Encoded/decoded by serializers as &quot;PABD&quot;.
    /// </summary>
    [EnumMember(Value = "PABD")]
    [IsoId("_beNtxtp-Ed-ak6NoX_4Aeg_-595837006")]
    [Description(
        @"The (I)CSD has to provide its participants' details for disclosure purpose to the issuer/issuer’s agent."
    )]
    ICSDParticipantBreakdown,

    /// <summary>
    /// See narrative field for certification requirements.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_beNtx9p-Ed-ak6NoX_4Aeg_-989729169")]
    [Description(@"See narrative field for certification requirements.")]
    NarrativeDescription,

    /// <summary>
    /// Indicates that the rounding rule in the Fraction Disposition component at the option level can be offered at the beneficial owner level.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_sqY8N_mfEeCXPrLWfSEUvQ")]
    [Description(
        @"Indicates that the rounding rule in the Fraction Disposition component at the option level can be offered at the beneficial owner level."
    )]
    FractionBreakdown,
}
