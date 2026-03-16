// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certification required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BeneficiaryCertificationType6Code")]
[Description(@"Specifies the type of certification required.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
public enum BeneficiaryCertificationType6Code
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as &quot;ACCI&quot;.
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_BeneficiaryCertificationType6Code_AccreditedInvestor")]
    [Description(@"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.")]
    AccreditedInvestor = BeneficiaryCertificationTypeCode.AccreditedInvestor,

    /// <summary>
    /// Documentation required on or prior to the documentation deadline date.
    /// Encoded/decoded by serializers as &quot;DIOR&quot;.
    /// </summary>
    [EnumMember(Value = "DIOR")]
    [IsoId("_BeneficiaryCertificationType6Code_IntermediaryDocumentationRequired")]
    [Description(@"Documentation required on or prior to the documentation deadline date.")]
    IntermediaryDocumentationRequired,

    /// <summary>
    /// The holder of the security has to certify his domicile.
    /// Encoded/decoded by serializers as &quot;DOMI&quot;.
    /// </summary>
    [EnumMember(Value = "DOMI")]
    [IsoId("_BeneficiaryCertificationType6Code_DomicileCountry")]
    [Description(@"The holder of the security has to certify his domicile.")]
    DomicileCountry = BeneficiaryCertificationTypeCode.DomicileCountry,

    /// <summary>
    /// Indicates that the rounding rule in the Fraction Disposition component at the option level can be offered at the beneficial owner level.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_BeneficiaryCertificationType6Code_FractionBreakdown")]
    [Description(@"Indicates that the rounding rule in the Fraction Disposition component at the option level can be offered at the beneficial owner level.")]
    FractionBreakdown = BeneficiaryCertificationTypeCode.FractionBreakdown,

    /// <summary>
    /// The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_BeneficiaryCertificationType6Code_FullBeneficialOwnerBreakdown")]
    [Description(@"The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose.")]
    FullBeneficialOwnerBreakdown = BeneficiaryCertificationTypeCode.FullBeneficialOwnerBreakdown,

    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_BeneficiaryCertificationType6Code_NonCompany")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany = BeneficiaryCertificationTypeCode.NonCompany,

    /// <summary>
    /// The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// Encoded/decoded by serializers as &quot;NDOM&quot;.
    /// </summary>
    [EnumMember(Value = "NDOM")]
    [IsoId("_BeneficiaryCertificationType6Code_NonDomicileCountry")]
    [Description(@"The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.")]
    NonDomicileCountry = BeneficiaryCertificationTypeCode.NonDomicileCountry,

    /// <summary>
    /// The (I)CSD has to provide its participants’ details for disclosure purpose to the issuer/issuer’s agent.
    /// Encoded/decoded by serializers as &quot;PABD&quot;.
    /// </summary>
    [EnumMember(Value = "PABD")]
    [IsoId("_BeneficiaryCertificationType6Code_ICSDParticipantBreakdown")]
    [Description(@"The (I)CSD has to provide its participants’ details for disclosure purpose to the issuer/issuer’s agent.")]
    ICSDParticipantBreakdown = BeneficiaryCertificationTypeCode.ICSDParticipantBreakdown,

    /// <summary>
    /// Indicates if the Beneficial Owner is responsible to fill in the paperwork.
    /// Encoded/decoded by serializers as &quot;PAPW&quot;.
    /// </summary>
    [EnumMember(Value = "PAPW")]
    [IsoId("_BeneficiaryCertificationType6Code_BeneficialOwnerPaperwork")]
    [Description(@"Indicates if the Beneficial Owner is responsible to fill in the paperwork.")]
    BeneficialOwnerPaperwork = BeneficiaryCertificationTypeCode.BeneficialOwnerPaperwork,

    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as &quot;QIBB&quot;.
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_BeneficiaryCertificationType6Code_QIBCertification")]
    [Description(@"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.")]
    QIBCertification = BeneficiaryCertificationTypeCode.QIBCertification,

    /// <summary>
    /// The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer.
    /// Encoded/decoded by serializers as &quot;TRBD&quot;.
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_BeneficiaryCertificationType6Code_TaxRateBreakdown")]
    [Description(@"The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer.")]
    TaxRateBreakdown = BeneficiaryCertificationTypeCode.TaxRateBreakdown,

}
