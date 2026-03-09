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
/// Status of the transactions sent in a previous batch of card payment transactions.
/// </summary>
[IsoId("_E2LswC45EeKIarvwWcPThw")]
[DisplayName("Card Payment Batch Transfer Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentBatchTransferResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentBatchTransferResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentBatchTransferResponse1( TransactionTotals2 reqTransactionTotals )
    {
        TransactionTotals = reqTransactionTotals;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_EyGBgC46EeKIarvwWcPThw")]
    [DisplayName("Transaction Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtls")]
    #endif
    [IsoXmlTag("TxTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionTotals2 TransactionTotals { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionTotals2 TransactionTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals2 TransactionTotals { get; init; } 
    #else
    public TransactionTotals2 TransactionTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the previously sent set of transaction.
    /// </summary>
    [IsoId("_K_Bd0C46EeKIarvwWcPThw")]
    [DisplayName("Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSet")]
    #endif
    [IsoXmlTag("DataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentDataSet5? DataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentDataSet5? DataSet { get; init; } 
    #else
    public CardPaymentDataSet5? DataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
