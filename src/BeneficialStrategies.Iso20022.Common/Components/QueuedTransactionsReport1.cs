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
/// Payment funds transfer instructions from intraday queue.
/// </summary>
[IsoId("_kEa_wBt4Eeaiht5D4a9WSA")]
[DisplayName("Queued Transactions Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QueuedTransactionsReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QueuedTransactionsReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QueuedTransactionsReport1( System.String reqQueueType,ActiveCurrencyAndAmount reqTotalAmount )
    {
        QueueType = reqQueueType;
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// List of queue names/ identifiers.
    /// </summary>
    [IsoId("_MmxNEBt5Eeaiht5D4a9WSA")]
    [DisplayName("Queue Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QTp")]
    #endif
    [IsoXmlTag("QTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text QueueType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QueueType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QueueType { get; init; } 
    #else
    public System.String QueueType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of transactions in the queue.
    /// </summary>
    [IsoId("_TYJ58Bt8Eeaiht5D4a9WSA")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfTransactions { get; init; } 
    #else
    public System.UInt64? NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of transactions in a given queue.
    /// </summary>
    [IsoId("_draScBt8Eeaiht5D4a9WSA")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction details sorted by counterparty account.
    /// </summary>
    [IsoId("_JMwngBt9Eeaiht5D4a9WSA")]
    [DisplayName("Breakdown By Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkdwnByCtrPty")]
    #endif
    [IsoXmlTag("BrkdwnByCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QueueTransaction1? BreakdownByCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QueueTransaction1? BreakdownByCounterparty { get; init; } 
    #else
    public QueueTransaction1? BreakdownByCounterparty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
