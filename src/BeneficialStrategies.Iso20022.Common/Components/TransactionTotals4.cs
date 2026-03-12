// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals of the reconciliation.
/// </summary>
[IsoId("_BQQtQXu-EeSLmfFG0DG7zQ")]
[DisplayName("Transaction Totals")]
public partial record TransactionTotals4
{
    #nullable enable
    
    /// <summary>
    /// Total of credit transactions.
    /// </summary>
    [IsoId("_9scLwHu-EeSLmfFG0DG7zQ")]
    [DisplayName("Total Credit")]
    [IsoXmlTag("TtlCdt")]
    public required TransactionTotals5 TotalCredit { get; init; } 
    
    /// <summary>
    /// Total of debit transactions.
    /// </summary>
    [IsoId("_pFQP4Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Total Debit")]
    [IsoXmlTag("TtlDbt")]
    public required TransactionTotals5 TotalDebit { get; init; } 
    
    /// <summary>
    /// Additional count which may be utilised for reconciliation.
    /// </summary>
    [IsoId("_5Y8g0Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Total Number")]
    [IsoXmlTag("TtlNb")]
    public TransactionTotals6? TotalNumber { get; init; } 
    
    
    #nullable disable
    
}
