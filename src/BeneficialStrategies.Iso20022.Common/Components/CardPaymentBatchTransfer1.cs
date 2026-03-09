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
/// Card payment transactions from one or several data set of transactions.
/// </summary>
[IsoId("_6mEa4C8UEeKW5usMQLtzqw")]
[DisplayName("Card Payment Batch Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentBatchTransfer1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_ESmxoC8VEeKW5usMQLtzqw")]
    [DisplayName("Transaction Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtls")]
    #endif
    [IsoXmlTag("TxTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionTotals2? TransactionTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals2? TransactionTotals { get; init; } 
    #else
    public TransactionTotals2? TransactionTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Card payment transactions from one data set of transactions.
    /// </summary>
    [IsoId("_XqCgYC8VEeKW5usMQLtzqw")]
    [DisplayName("Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSet")]
    #endif
    [IsoXmlTag("DataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentDataSet4? DataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentDataSet4? DataSet { get; init; } 
    #else
    public CardPaymentDataSet4? DataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
