// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the outstanding derivatives for which no valuation or outdated valuation has been reported.
/// </summary>
[IsoId("_x29aEVyGEe24CqbZJK5XxA")]
[DisplayName("Missing Valuations Transaction Data")]
public record MissingValuationsTransactionData2
{
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_x3tA8VyGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; }

    /// <summary>
    /// Mark-to-market valuation of the contract, or mark-to-model valuation
    /// </summary>
    [IsoId("_x3tA81yGEe24CqbZJK5XxA")]
    [DisplayName("Valuation Amount")]
    [IsoXmlTag("ValtnAmt")]
    public AmountAndDirection106? ValuationAmount { get; init; }

    /// <summary>
    /// Date and time of the valuation.
    /// </summary>
    [IsoId("_x3tA9VyGEe24CqbZJK5XxA")]
    [DisplayName("Valuation Time Stamp")]
    [IsoXmlTag("ValtnTmStmp")]
    public DateAndDateTime2Choice_? ValuationTimeStamp { get; init; }
}
