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
[IsoId("_C08NITY6EeOYzMAJn8nuYA")]
[DisplayName("Acquirer Protocol Parameters")]
public record AcquirerProtocolParameters5
{
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_DEHRkTY6EeOYzMAJn8nuYA")]
    [DisplayName("Financial Capture")]
    [IsoXmlTag("FinCaptr")]
    public required FinancialCapture1Code FinancialCapture { get; init; }

    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_DEHRkzY6EeOYzMAJn8nuYA")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public ExchangeConfiguration4? BatchTransfer { get; init; }

    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_DEHRlTY6EeOYzMAJn8nuYA")]
    [DisplayName("Completion Exchange")]
    [IsoXmlTag("CmpltnXchg")]
    public ExchangeConfiguration5? CompletionExchange { get; init; }

    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    [IsoId("_DEHRlzY6EeOYzMAJn8nuYA")]
    [DisplayName("Cancellation Exchange")]
    [IsoXmlTag("CxlXchg")]
    public CancellationProcess1Code? CancellationExchange { get; init; }
}
