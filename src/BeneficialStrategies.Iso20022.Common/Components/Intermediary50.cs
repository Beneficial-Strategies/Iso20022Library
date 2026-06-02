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
[IsoId("b16a7bf5-3bb5-4835-8207-63864a708f74")]
[DisplayName("Intermediary50")]
public record Intermediary50
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("12ed31d9-4b08-4d43-b027-c26641668be9")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification139 Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("bbd54103-6061-4238-ad58-97a7ece6beea")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account35? Account { get; init; }

    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("e13a0649-67f0-4001-ad02-d697dc4b7c7a")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("c5ce2232-7389-424c-bfdc-9ff5e3d1a36e")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole2Choice? Role { get; init; }
}
