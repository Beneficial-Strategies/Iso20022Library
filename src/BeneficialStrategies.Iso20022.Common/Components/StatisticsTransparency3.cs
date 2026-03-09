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
/// Statistics for a financial instrument generated as part of transparency calculations.
/// </summary>
[IsoId("_L1E_AXvwEeanCNPcMT7sSg")]
[DisplayName("Statistics Transparency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatisticsTransparency3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Average Daily Turnover for the instrument in Euros.
    /// </summary>
    [IsoId("_L-xGgXvwEeanCNPcMT7sSg")]
    [DisplayName("Average Daily Turnover")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgDalyTrnvr")]
    #endif
    [IsoXmlTag("AvrgDalyTrnvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AverageDailyTurnover { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AverageDailyTurnover { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AverageDailyTurnover { get; set; } 
    #endif
    
    /// <summary>
    /// Average value of the transactions for the instrument in Euro.
    /// </summary>
    [IsoId("_L-xGg3vwEeanCNPcMT7sSg")]
    [DisplayName("Average Transaction Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgTxVal")]
    #endif
    [IsoXmlTag("AvrgTxVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AverageTransactionValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AverageTransactionValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AverageTransactionValue { get; set; } 
    #endif
    
    /// <summary>
    /// Large in scale order in respect of a share, depositary receipt, certificate or other similar financial instrument shall be considered large in scale compared with normal market size if, on the basis of the average daily turnover for that financial instrument, the order is equal to or larger than the minimum size of orders set out in the local regulation.
    /// </summary>
    [IsoId("_L-xGhXvwEeanCNPcMT7sSg")]
    [DisplayName("Large In Scale")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LrgInScale")]
    #endif
    [IsoXmlTag("LrgInScale")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? LargeInScale { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? LargeInScale { get; init; } 
    #else
    public System.UInt64? LargeInScale { get; set; } 
    #endif
    
    /// <summary>
    /// Standard market size for shares, depositary receipts, ETFs, certificates and other similar financial instruments for which there is a liquid market shall be determined on the basis of the average value of transactions for each financial instrument and in accordance with the local regulation.
    /// </summary>
    [IsoId("_L-xGh3vwEeanCNPcMT7sSg")]
    [DisplayName("Standard Market Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdMktSz")]
    #endif
    [IsoXmlTag("StdMktSz")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? StandardMarketSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? StandardMarketSize { get; init; } 
    #else
    public System.UInt64? StandardMarketSize { get; set; } 
    #endif
    
    /// <summary>
    /// Average daily number of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_L-xGiXvwEeanCNPcMT7sSg")]
    [DisplayName("Average Daily Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgDalyNbOfTxs")]
    #endif
    [IsoXmlTag("AvrgDalyNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? AverageDailyNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AverageDailyNumberOfTransactions { get; init; } 
    #else
    public System.UInt64? AverageDailyNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_L-xGi3vwEeanCNPcMT7sSg")]
    [DisplayName("Total Number Of Transactions Executed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxsExctd")]
    #endif
    [IsoXmlTag("TtlNbOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalNumberOfTransactionsExecuted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfTransactionsExecuted { get; init; } 
    #else
    public System.UInt64? TotalNumberOfTransactionsExecuted { get; set; } 
    #endif
    
    /// <summary>
    /// Total volume of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_L-xGjXvwEeanCNPcMT7sSg")]
    [DisplayName("Total Volume Of Transactions Executed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVolOfTxsExctd")]
    #endif
    [IsoXmlTag("TtlVolOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalVolumeOfTransactionsExecuted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalVolumeOfTransactionsExecuted { get; init; } 
    #else
    public System.UInt64? TotalVolumeOfTransactionsExecuted { get; set; } 
    #endif
    
    /// <summary>
    /// The total number of trading days for which the data is provided.
    /// </summary>
    [IsoId("_L-xGj3vwEeanCNPcMT7sSg")]
    [DisplayName("Total Number Of Trading Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTradgDays")]
    #endif
    [IsoXmlTag("TtlNbOfTradgDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfTradingDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfTradingDays { get; init; } 
    #else
    public System.UInt64? TotalNumberOfTradingDays { get; set; } 
    #endif
    
    
    #nullable disable
    
}
