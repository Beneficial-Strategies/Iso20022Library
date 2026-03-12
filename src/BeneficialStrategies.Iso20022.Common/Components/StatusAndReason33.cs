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
[IsoId("_zmvyTZwxEeazcsnODTksnQ")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason33
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_zmvyT5wxEeazcsnODTksnQ")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status23Choice_ StatusAndReason { get; init; } 
    
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_zmvyU5wxEeazcsnODTksnQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction56? Transaction { get; init; } 
    
    
    #nullable disable
    
}
