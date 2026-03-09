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
/// Detailed information on statistics per combination of counterparties.
/// </summary>
[IsoId("_x82mtVyGEe24CqbZJK5XxA")]
[DisplayName("Detailed Statistics Per Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedStatisticsPerCounterparty18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedStatisticsPerCounterparty18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedStatisticsPerCounterparty18( System.DateOnly reqReferenceDate,System.String reqTotalNumberOfReports,System.String reqTotalNumberOfReportsAccepted,System.String reqTotalNumberOfReportsRejected,System.String reqTotalNumberOfTransactions,StatisticsPerActionType1 reqTotalNumberOfTransactionsAccepted,StatisticsPerActionType1 reqTotalNumberOfTransactionsRejected )
    {
        ReferenceDate = reqReferenceDate;
        TotalNumberOfReports = reqTotalNumberOfReports;
        TotalNumberOfReportsAccepted = reqTotalNumberOfReportsAccepted;
        TotalNumberOfReportsRejected = reqTotalNumberOfReportsRejected;
        TotalNumberOfTransactions = reqTotalNumberOfTransactions;
        TotalNumberOfTransactionsAccepted = reqTotalNumberOfTransactionsAccepted;
        TotalNumberOfTransactionsRejected = reqTotalNumberOfTransactionsRejected;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    [IsoId("_x9xMsVyGEe24CqbZJK5XxA")]
    [DisplayName("Reference Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefDt")]
    #endif
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReferenceDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReferenceDate { get; init; } 
    #else
    public System.DateOnly ReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_x9xMs1yGEe24CqbZJK5XxA")]
    [DisplayName("Total Number Of Reports")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRpts")]
    #endif
    [IsoXmlTag("TtlNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfReports { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfReports { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfReports { get; init; } 
    #else
    public System.String TotalNumberOfReports { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reports accepted.
    /// </summary>
    [IsoId("_x9xMtVyGEe24CqbZJK5XxA")]
    [DisplayName("Total Number Of Reports Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRptsAccptd")]
    #endif
    [IsoXmlTag("TtlNbOfRptsAccptd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfReportsAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfReportsAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfReportsAccepted { get; init; } 
    #else
    public System.String TotalNumberOfReportsAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reports rejected.
    /// </summary>
    [IsoId("_x9xMt1yGEe24CqbZJK5XxA")]
    [DisplayName("Total Number Of Reports Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRptsRjctd")]
    #endif
    [IsoXmlTag("TtlNbOfRptsRjctd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfReportsRejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfReportsRejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfReportsRejected { get; init; } 
    #else
    public System.String TotalNumberOfReportsRejected { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_x9xMuVyGEe24CqbZJK5XxA")]
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
    [IsoId("_x9xMu1yGEe24CqbZJK5XxA")]
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
    [IsoId("_x9xMvVyGEe24CqbZJK5XxA")]
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
    [IsoId("_x9xMv1yGEe24CqbZJK5XxA")]
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
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
    /// </summary>
    [IsoId("_x9xMwVyGEe24CqbZJK5XxA")]
    [DisplayName("Rejection Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnSttstcs")]
    #endif
    [IsoXmlTag("RjctnSttstcs")]
    public ValueList<RejectionStatistics8> RejectionStatistics { get; init; } = new ValueList<RejectionStatistics8>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _x9xMwVyGEe24CqbZJK5XxA
    
    
    #nullable disable
    
}
