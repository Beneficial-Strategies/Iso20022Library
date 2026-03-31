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
[IsoId("_9npJ5zbsEead9bDRE_1DAQ")]
[DisplayName("Intermediary")]
public record Intermediary39
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_-AV9tTbsEead9bDRE_1DAQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification113 Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_-AV9tzbsEead9bDRE_1DAQ")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account22? Account { get; init; }

    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_-AV9uTbsEead9bDRE_1DAQ")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Capacity of the party executing an order.
    /// </summary>
    [IsoId("_-AV9uzbsEead9bDRE_1DAQ")]
    [DisplayName("Trading Party Capacity")]
    [IsoXmlTag("TradgPtyCpcty")]
    public TradingCapacity8Code? TradingPartyCapacity { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_-AV9vTbsEead9bDRE_1DAQ")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole2Choice_? Role { get; init; }
}
