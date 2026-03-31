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
[IsoId("_x_a7MQz1Ee2YoLD-1vFj0g")]
[DisplayName("Counterparty")]
public record Counterparty45
{
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_yANlYQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification248Choice_ Identification { get; init; }

    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_yANlYwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public CounterpartyTradeNature15Choice_? Nature { get; init; }

    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_yANlZQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity7Code? TradingCapacity { get; init; }

    /// <summary>
    /// Indicates the direction or side of the derivative transaction from the perspective of the reporting counterparty.
    /// Usage:
    /// CounterpartySide should be used for the instruments such as most forwards and forward-like contracts (except for foreign exchange forwards and foreign exchange non-deliverable forwards); most options and option-like contracts including swaptions, caps and floors; credit default swaps; variance, volatility and correlation swaps; contracts for difference and spreadbets.
    /// </summary>
    [IsoId("_yANlZwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Direction Or Side")]
    [IsoXmlTag("DrctnOrSd")]
    public Direction4Choice_? DirectionOrSide { get; init; }

    /// <summary>
    /// Location of the trading desk or trader responsible for the decision of entering into or execution of the transaction.
    /// </summary>
    [IsoId("_50_lYBZuEe27wrM4RUjLog")]
    [DisplayName("Trader Location")]
    [IsoXmlTag("TradrLctn")]
    public CountryCode? TraderLocation { get; init; }

    /// <summary>
    /// Location of the trade party or the branch/office of the trade party to which the transaction is booked.
    /// </summary>
    [IsoId("_-kfaYBZuEe27wrM4RUjLog")]
    [DisplayName("Booking Location")]
    [IsoXmlTag("BookgLctn")]
    public CountryCode? BookingLocation { get; init; }

    /// <summary>
    /// Provides details on the reporting exemption of a counterparty.
    /// </summary>
    [IsoId("_EDG10BaIEe27wrM4RUjLog")]
    [DisplayName("Reporting Exemption")]
    [IsoXmlTag("RptgXmptn")]
    public ReportingExemption1? ReportingExemption { get; init; }
}
