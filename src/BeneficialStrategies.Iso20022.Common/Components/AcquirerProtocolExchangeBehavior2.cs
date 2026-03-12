// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_ci6pUTAREeugIJ3Gvoevmg")]
[DisplayName("Acquirer Protocol Exchange Behavior")]
public partial record AcquirerProtocolExchangeBehavior2
{
    #nullable enable
    
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_cwgZYTAREeugIJ3Gvoevmg")]
    [DisplayName("Financial Capture")]
    [IsoXmlTag("FinCaptr")]
    public required FinancialCapture1Code FinancialCapture { get; init; } 
    
    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_cwgZYzAREeugIJ3Gvoevmg")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public ExchangeConfiguration9? BatchTransfer { get; init; } 
    
    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_cwgZZTAREeugIJ3Gvoevmg")]
    [DisplayName("Completion Exchange")]
    [IsoXmlTag("CmpltnXchg")]
    public ExchangeConfiguration10? CompletionExchange { get; init; } 
    
    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    [IsoId("_cwgZZzAREeugIJ3Gvoevmg")]
    [DisplayName("Cancellation Exchange")]
    [IsoXmlTag("CxlXchg")]
    public CancellationProcess2Code? CancellationExchange { get; init; } 
    
    
    #nullable disable
    
}
