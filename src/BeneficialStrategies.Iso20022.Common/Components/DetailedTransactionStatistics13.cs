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
/// Information about number of transactions accepted and rejected and the reasons of the rejections.
/// </summary>
[IsoId("_hUsuxcK4EeuFNp8LZAnorg")]
[DisplayName("Detailed Transaction Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedTransactionStatistics13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedTransactionStatistics13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedTransactionStatistics13( System.String reqTotalNumberOfTransactions,System.String reqTotalNumberOfTransactionsAccepted,System.String reqTotalNumberOfTransactionsRejected )
    {
        TotalNumberOfTransactions = reqTotalNumberOfTransactions;
        TotalNumberOfTransactionsAccepted = reqTotalNumberOfTransactionsAccepted;
        TotalNumberOfTransactionsRejected = reqTotalNumberOfTransactionsRejected;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_hV-hIcK4EeuFNp8LZAnorg")]
    [DisplayName("Total Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxs")]
    #endif
    [IsoXmlTag("TtlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfTransactions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfTransactions { get; init; } 
    #else
    public System.String TotalNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions accepted.
    /// </summary>
    [IsoId("_hV-hI8K4EeuFNp8LZAnorg")]
    [DisplayName("Total Number Of Transactions Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxsAccptd")]
    #endif
    [IsoXmlTag("TtlNbOfTxsAccptd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfTransactionsAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfTransactionsAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfTransactionsAccepted { get; init; } 
    #else
    public System.String TotalNumberOfTransactionsAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions rejected.
    /// </summary>
    [IsoId("_hV-hJcK4EeuFNp8LZAnorg")]
    [DisplayName("Total Number Of Transactions Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxsRjctd")]
    #endif
    [IsoXmlTag("TtlNbOfTxsRjctd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfTransactionsRejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfTransactionsRejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfTransactionsRejected { get; init; } 
    #else
    public System.String TotalNumberOfTransactionsRejected { get; set; } 
    #endif
    
    /// <summary>
    /// Details on transactions rejected per error code.
    /// </summary>
    [IsoId("_hV-hJ8K4EeuFNp8LZAnorg")]
    [DisplayName("Transactions Rejections Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsRjctnsRsn")]
    #endif
    [IsoXmlTag("TxsRjctnsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectionReason53? TransactionsRejectionsReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason53? TransactionsRejectionsReason { get; init; } 
    #else
    public RejectionReason53? TransactionsRejectionsReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
