// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reconciliation.
/// </summary>
[IsoId("_ynYVIHu5EeSLmfFG0DG7zQ")]
[DisplayName("Acquirer Reconciliation Initiation")]
public partial record AcquirerReconciliationInitiation1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_NQvZYHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment5 Environment { get; init; } 
    
    /// <summary>
    /// Reconciliation transaction.
    /// </summary>
    [IsoId("_9ATbUHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction9 Transaction { get; init; } 
    
    
    #nullable disable
    
}
