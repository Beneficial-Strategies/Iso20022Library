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
[IsoId("_cxU60Xh3EeStacoNRHtESA")]
[DisplayName("Acquirer Protocol Parameters")]
public partial record AcquirerProtocolParameters8
{
    #nullable enable
    
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_c-plIXh3EeStacoNRHtESA")]
    [DisplayName("Financial Capture")]
    [IsoXmlTag("FinCaptr")]
    public required FinancialCapture1Code FinancialCapture { get; init; } 
    
    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_c-plI3h3EeStacoNRHtESA")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public ExchangeConfiguration6? BatchTransfer { get; init; } 
    
    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_c-plJXh3EeStacoNRHtESA")]
    [DisplayName("Completion Exchange")]
    [IsoXmlTag("CmpltnXchg")]
    public ExchangeConfiguration7? CompletionExchange { get; init; } 
    
    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    [IsoId("_c-plJ3h3EeStacoNRHtESA")]
    [DisplayName("Cancellation Exchange")]
    [IsoXmlTag("CxlXchg")]
    public CancellationProcess1Code? CancellationExchange { get; init; } 
    
    
    #nullable disable
    
}
