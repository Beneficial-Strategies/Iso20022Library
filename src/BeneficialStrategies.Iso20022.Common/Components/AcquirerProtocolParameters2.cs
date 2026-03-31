// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_Kszxs31DEeCF8NjrBemJWQ_-1699240032")]
[DisplayName("Acquirer Protocol Parameters")]
public record AcquirerProtocolParameters2
{
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_KszxtH1DEeCF8NjrBemJWQ_2024624055")]
    [DisplayName("Financial Capture")]
    [IsoXmlTag("FinCaptr")]
    public required FinancialCapture1Code FinancialCapture { get; init; }

    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_KszxtX1DEeCF8NjrBemJWQ_-1127119411")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public ExchangeConfiguration1? BatchTransfer { get; init; }

    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_Kszxtn1DEeCF8NjrBemJWQ_2069303361")]
    [DisplayName("Completion Exchange")]
    [IsoXmlTag("CmpltnXchg")]
    public ExchangeConfiguration1? CompletionExchange { get; init; }
}
