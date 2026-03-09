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
/// Provides for reporting quantitative details of equity instruments as part of transparency calculations.
/// </summary>
[IsoId("_pRLggWlAEeaLAKoEUNsD9g")]
[DisplayName("Transparency Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransparencyDataReport13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransparencyDataReport13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransparencyDataReport13( System.String reqIdentification,System.String reqSuspension,NumberAndVolume2 reqTransactionsExecuted,NumberAndVolume2 reqTransactionsExecutedExcludingPreTradeWaiver,NumberAndVolume2 reqTransactionsExecutedExcludingPostTradeLargeInScaleWaiver )
    {
        Identification = reqIdentification;
        Suspension = reqSuspension;
        TransactionsExecuted = reqTransactionsExecuted;
        TransactionsExecutedExcludingPreTradeWaiver = reqTransactionsExecutedExcludingPreTradeWaiver;
        TransactionsExecutedExcludingPostTradeLargeInScaleWaiver = reqTransactionsExecutedExcludingPostTradeLargeInScaleWaiver;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_paFk5WlAEeaLAKoEUNsD9g")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_paFk52lAEeaLAKoEUNsD9g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date to which the quantitative data fields below relate.
    /// </summary>
    [IsoId("_paFk6WlAEeaLAKoEUNsD9g")]
    [DisplayName("Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDt")]
    #endif
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ReportingDate { get; init; } 
    #else
    public System.DateOnly? ReportingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_paFk62lAEeaLAKoEUNsD9g")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingVenue { get; init; } 
    #else
    public System.String? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instrument was suspended for trading on that Trading Venue for the whole day on the given reporting day.
    /// </summary>
    [IsoId("_paFk7WlAEeaLAKoEUNsD9g")]
    [DisplayName("Suspension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sspnsn")]
    #endif
    [IsoXmlTag("Sspnsn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Suspension { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Suspension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Suspension { get; init; } 
    #else
    public System.String Suspension { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions executed on the reporting day.
    /// </summary>
    [IsoId("_paFk72lAEeaLAKoEUNsD9g")]
    [DisplayName("Transactions Executed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsExctd")]
    #endif
    [IsoXmlTag("TxsExctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NumberAndVolume2 TransactionsExecuted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NumberAndVolume2 TransactionsExecuted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndVolume2 TransactionsExecuted { get; init; } 
    #else
    public NumberAndVolume2 TransactionsExecuted { get; set; } 
    #endif
    
    /// <summary>
    /// Details all transactions that have been performed under a pre-trade Waiver.
    /// </summary>
    [IsoId("_paFk8WlAEeaLAKoEUNsD9g")]
    [DisplayName("Transactions Executed Excluding Pre Trade Waiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsExctdExclgPreTradWvr")]
    #endif
    [IsoXmlTag("TxsExctdExclgPreTradWvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NumberAndVolume2 TransactionsExecutedExcludingPreTradeWaiver { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NumberAndVolume2 TransactionsExecutedExcludingPreTradeWaiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndVolume2 TransactionsExecutedExcludingPreTradeWaiver { get; init; } 
    #else
    public NumberAndVolume2 TransactionsExecutedExcludingPreTradeWaiver { get; set; } 
    #endif
    
    /// <summary>
    /// Details all transactions that have been performed under a post-trade large in scale waivers.
    /// </summary>
    [IsoId("_paFk82lAEeaLAKoEUNsD9g")]
    [DisplayName("Transactions Executed Excluding Post Trade Large In Scale Waiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsExctdExclgPstTradLrgInScaleWvr")]
    #endif
    [IsoXmlTag("TxsExctdExclgPstTradLrgInScaleWvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NumberAndVolume2 TransactionsExecutedExcludingPostTradeLargeInScaleWaiver { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NumberAndVolume2 TransactionsExecutedExcludingPostTradeLargeInScaleWaiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndVolume2 TransactionsExecutedExcludingPostTradeLargeInScaleWaiver { get; init; } 
    #else
    public NumberAndVolume2 TransactionsExecutedExcludingPostTradeLargeInScaleWaiver { get; set; } 
    #endif
    
    
    #nullable disable
    
}
