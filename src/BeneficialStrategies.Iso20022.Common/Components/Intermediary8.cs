// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_QOCaCtp-Ed-ak6NoX_4Aeg_-1658310950")]
[DisplayName("Intermediary")]
public record Intermediary8
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_QOCaC9p-Ed-ak6NoX_4Aeg_-1658310811")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification2Choice_ Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QOCaDNp-Ed-ak6NoX_4Aeg_-741253972")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account7? Account { get; init; }

    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_QOMLANp-Ed-ak6NoX_4Aeg_-1517429861")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOMLAdp-Ed-ak6NoX_4Aeg_-1658310345")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole2Code? Role { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOMLAtp-Ed-ak6NoX_4Aeg_728193103")]
    [DisplayName("Extended Role")]
    [IsoXmlTag("XtndedRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedRole { get; init; }
}
