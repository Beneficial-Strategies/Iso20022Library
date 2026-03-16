// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_BOdH0ZQKEeiILOjNP8ro1w")]
[DisplayName("Counterparty")]
public record Counterparty27
{
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_BY0kwZQKEeiILOjNP8ro1w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification7Choice_ Identification { get; init; }

    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_BY0kw5QKEeiILOjNP8ro1w")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public required CounterpartyTradeNature4Choice_ Nature { get; init; }

    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_BY0kxZQKEeiILOjNP8ro1w")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity7Code TradingCapacity { get; init; }

    /// <summary>
    /// Identifies whether the reporting counterparty is a buyer or a seller.
    /// </summary>
    [IsoId("_BY0kx5QKEeiILOjNP8ro1w")]
    [DisplayName("Counterparty Side")]
    [IsoXmlTag("CtrPtySd")]
    public required OptionParty1Code CounterpartySide { get; init; }
}
