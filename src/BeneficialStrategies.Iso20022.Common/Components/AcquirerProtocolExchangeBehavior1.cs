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
[IsoId("_UN6X5Au2Eeq4I6UJxZQ2Qw")]
[DisplayName("Acquirer Protocol Exchange Behavior")]
public record AcquirerProtocolExchangeBehavior1
{
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_UN6-8wu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Financial Capture")]
    [IsoXmlTag("FinCaptr")]
    public required FinancialCapture1Code FinancialCapture { get; init; }

    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_UN6-8Qu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public ExchangeConfiguration8? BatchTransfer { get; init; }

    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_UN6-8Au2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Completion Exchange")]
    [IsoXmlTag("CmpltnXchg")]
    public ExchangeConfiguration8? CompletionExchange { get; init; }

    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    [IsoId("_UN6-8gu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Cancellation Exchange")]
    [IsoXmlTag("CxlXchg")]
    public CancellationProcess2Code? CancellationExchange { get; init; }
}
