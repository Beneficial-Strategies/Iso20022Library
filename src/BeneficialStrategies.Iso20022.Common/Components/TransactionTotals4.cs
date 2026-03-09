// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals of the reconciliation.
/// </summary>
[IsoId("_BQQtQXu-EeSLmfFG0DG7zQ")]
[DisplayName("Transaction Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionTotals4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionTotals4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionTotals4( TransactionTotals5 reqTotalCredit,TransactionTotals5 reqTotalDebit )
    {
        TotalCredit = reqTotalCredit;
        TotalDebit = reqTotalDebit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total of credit transactions.
    /// </summary>
    [IsoId("_9scLwHu-EeSLmfFG0DG7zQ")]
    [DisplayName("Total Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCdt")]
    #endif
    [IsoXmlTag("TtlCdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionTotals5 TotalCredit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionTotals5 TotalCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals5 TotalCredit { get; init; } 
    #else
    public TransactionTotals5 TotalCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Total of debit transactions.
    /// </summary>
    [IsoId("_pFQP4Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Total Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDbt")]
    #endif
    [IsoXmlTag("TtlDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionTotals5 TotalDebit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionTotals5 TotalDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals5 TotalDebit { get; init; } 
    #else
    public TransactionTotals5 TotalDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Additional count which may be utilised for reconciliation.
    /// </summary>
    [IsoId("_5Y8g0Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Total Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNb")]
    #endif
    [IsoXmlTag("TtlNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionTotals6? TotalNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals6? TotalNumber { get; init; } 
    #else
    public TransactionTotals6? TotalNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
