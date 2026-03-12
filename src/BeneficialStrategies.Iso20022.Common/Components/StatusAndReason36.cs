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
[IsoId("_RaEtAdByEeihG9bKfarOOA")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason36
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_Rq4wMdByEeihG9bKfarOOA")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status29Choice_ StatusAndReason { get; init; } 
    
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_Rq4wNdByEeihG9bKfarOOA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction67? Transaction { get; init; } 
    
    
    #nullable disable
    
}
