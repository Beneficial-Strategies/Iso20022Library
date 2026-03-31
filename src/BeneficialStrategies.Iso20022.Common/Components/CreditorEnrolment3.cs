// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes of the creditor used for a creditor enrolment.
/// </summary>
[IsoId("_UZbOJeH7Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment")]
public record CreditorEnrolment3
{
    /// <summary>
    /// Detailed activation data related to the creditor enrolment.
    /// </summary>
    [IsoId("_UalrweH7Eeqbls7Gk4-ckA")]
    [DisplayName("Enrolment")]
    [IsoXmlTag("Enrlmnt")]
    public required CreditorServiceEnrolment1 Enrolment { get; init; }

    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another, such as the brand name.
    /// </summary>
    [IsoId("_Ualrw-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Trading Name")]
    [IsoXmlTag("CdtrTradgNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? CreditorTradingName { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_UalrxeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required RTPPartyIdentification1 Creditor { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_Ualrx-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public RTPPartyIdentification1? UltimateCreditor { get; init; }

    /// <summary>
    /// Classification of a business by the types of goods or services it provides.
    /// </summary>
    [IsoId("_UalryeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.MerchantCategoryCodeIdentifier)]
    public required IsoMerchantCategoryCodeIdentifier MerchantCategoryCode { get; init; }

    /// <summary>
    /// Commercial logo of the creditor.
    /// </summary>
    [IsoId("_Ualry-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Logo")]
    [IsoXmlTag("CdtrLogo")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? CreditorLogo { get; init; }
}
