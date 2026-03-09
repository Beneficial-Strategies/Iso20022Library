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
[IsoId("_x_mYtVyGEe24CqbZJK5XxA")]
[DisplayName("Detailed Transaction Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedTransactionStatistics29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedTransactionStatistics29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedTransactionStatistics29( System.String reqTotalNumberOfTransactions,StatisticsPerActionType1 reqTotalNumberOfTransactionsAccepted,StatisticsPerActionType1 reqTotalNumberOfTransactionsRejected )
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
    [IsoId("_yAw2UVyGEe24CqbZJK5XxA")]
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
    [IsoId("_yAw2U1yGEe24CqbZJK5XxA")]
    [DisplayName("Total Number Of Transactions Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxsAccptd")]
    #endif
    [IsoXmlTag("TtlNbOfTxsAccptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerActionType1 TotalNumberOfTransactionsAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticsPerActionType1 TotalNumberOfTransactionsAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerActionType1 TotalNumberOfTransactionsAccepted { get; init; } 
    #else
    public StatisticsPerActionType1 TotalNumberOfTransactionsAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions rejected.
    /// </summary>
    [IsoId("_yAw2VVyGEe24CqbZJK5XxA")]
    [DisplayName("Total Number Of Transactions Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxsRjctd")]
    #endif
    [IsoXmlTag("TtlNbOfTxsRjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerActionType1 TotalNumberOfTransactionsRejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticsPerActionType1 TotalNumberOfTransactionsRejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerActionType1 TotalNumberOfTransactionsRejected { get; init; } 
    #else
    public StatisticsPerActionType1 TotalNumberOfTransactionsRejected { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty which were then corrected within ten business days.
    /// </summary>
    [IsoId("_yAw2V1yGEe24CqbZJK5XxA")]
    [DisplayName("Total Corrected Rejections")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCrrctdRjctns")]
    #endif
    [IsoXmlTag("TtlCrrctdRjctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticsPerActionType1? TotalCorrectedRejections { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerActionType1? TotalCorrectedRejections { get; init; } 
    #else
    public StatisticsPerActionType1? TotalCorrectedRejections { get; set; } 
    #endif
    
    /// <summary>
    /// Details on transactions rejected per error code.
    /// </summary>
    [IsoId("_yAw2WVyGEe24CqbZJK5XxA")]
    [DisplayName("Transactions Rejections Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsRjctnsRsn")]
    #endif
    [IsoXmlTag("TxsRjctnsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectionReason71? TransactionsRejectionsReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason71? TransactionsRejectionsReason { get; init; } 
    #else
    public RejectionReason71? TransactionsRejectionsReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
