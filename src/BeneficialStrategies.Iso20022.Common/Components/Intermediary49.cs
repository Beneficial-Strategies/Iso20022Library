// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intermediary49.
/// </summary>
[IsoId("_2LatsxwMEe6O0NdiBuX__w")]
[DisplayName("Intermediary49")]
public record Intermediary49
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account35? Account { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification139 Identification { get; init; }

    /// <summary>
    /// Order Originator Eligibility.
    /// </summary>
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Role.
    /// </summary>
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole2Choice_? Role { get; init; }

    /// <summary>
    /// Trading Party Capacity.
    /// </summary>
    [DisplayName("Trading Party Capacity")]
    [IsoXmlTag("TradgPtyCpcty")]
    public TradingCapacity8Code? TradingPartyCapacity { get; init; }
}
