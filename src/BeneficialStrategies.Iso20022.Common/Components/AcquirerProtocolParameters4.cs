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
[IsoId("_tiYEcR3kEeKWfegf-2AeBQ")]
[DisplayName("Acquirer Protocol Parameters")]
public partial record AcquirerProtocolParameters4
{
    #nullable enable
    
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_tuRycR3kEeKWfegf-2AeBQ")]
    [DisplayName("Financial Capture")]
    [IsoXmlTag("FinCaptr")]
    public required FinancialCapture1Code FinancialCapture { get; init; } 
    
    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_tuRydR3kEeKWfegf-2AeBQ")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public ExchangeConfiguration2? BatchTransfer { get; init; } 
    
    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_tuRyeR3kEeKWfegf-2AeBQ")]
    [DisplayName("Completion Exchange")]
    [IsoXmlTag("CmpltnXchg")]
    public ExchangeConfiguration3? CompletionExchange { get; init; } 
    
    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    [IsoId("_dHz9MB3pEeKWfegf-2AeBQ")]
    [DisplayName("Cancellation Exchange")]
    [IsoXmlTag("CxlXchg")]
    public CancellationProcess1Code? CancellationExchange { get; init; } 
    
    
    #nullable disable
    
}
