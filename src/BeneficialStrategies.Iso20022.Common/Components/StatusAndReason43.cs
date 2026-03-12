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
[IsoId("_waWF5yAeEeuyDZ-ukt4YRg")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason43
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_waWF6SAeEeuyDZ-ukt4YRg")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status33Choice_ StatusAndReason { get; init; } 
    
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_waWF7SAeEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction117? Transaction { get; init; } 
    
    
    #nullable disable
    
}
