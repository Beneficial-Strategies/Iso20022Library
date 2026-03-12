// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
[IsoId("_7k4w6c32Eee5nJBZsW8MFQ")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason35
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_7k4w6832Eee5nJBZsW8MFQ")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status23Choice_ StatusAndReason { get; init; } 
    
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_7k4w7832Eee5nJBZsW8MFQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction63? Transaction { get; init; } 
    
    
    #nullable disable
    
}
