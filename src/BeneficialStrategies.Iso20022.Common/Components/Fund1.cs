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
/// Information about an investment fund.
/// </summary>
[IsoId("_pEbB0QcxEeSuMrNEGTimoA")]
[DisplayName("Fund")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Fund1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the fund/sub fund.
    /// </summary>
    [IsoId("_pUqPF1-KEeS7xuKaq75oiQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the fund/sub fund with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_pUqPGF-KEeS7xuKaq75oiQ")]
    [DisplayName("Legal Entity Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglNttyIdr")]
    #endif
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegalEntityIdentifier { get; init; } 
    #else
    public System.String? LegalEntityIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the fund/sub fund, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_pUqPFl-KEeS7xuKaq75oiQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification4? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification4? Identification { get; init; } 
    #else
    public OtherIdentification4? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWLwcxEeSuMrNEGTimoA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Date and, if required, the time, at which the price will be applied.
    /// </summary>
    [IsoId("__EBBkmAFEeSkSfzdpzkxXg")]
    [DisplayName("Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtTm")]
    #endif
    [IsoXmlTag("TradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? TradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? TradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? TradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("__EBBk2AFEeSkSfzdpzkxXg")]
    [DisplayName("Previous Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTradDtTm")]
    #endif
    [IsoXmlTag("PrvsTradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWHQcxEeSuMrNEGTimoA")]
    [DisplayName("Estimated Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdTtlNAV")]
    #endif
    [IsoXmlTag("EstmtdTtlNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Previous total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWHwcxEeSuMrNEGTimoA")]
    [DisplayName("Previous Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTtlNAV")]
    #endif
    [IsoXmlTag("PrvsTtlNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWIQcxEeSuMrNEGTimoA")]
    [DisplayName("Estimated Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdTtlUnitsNb")]
    #endif
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Previous total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWIwcxEeSuMrNEGTimoA")]
    [DisplayName("Previous Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTtlUnitsNb")]
    #endif
    [IsoXmlTag("PrvsTtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated consolidated net cash flow expressed as a percentage of the previous total NAV for the fund/sub fund.
    /// </summary>
    [IsoId("_2qUxoQdDEeSyIPzOZ6VzBQ")]
    [DisplayName("Estimated Percentage Of Fund Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdPctgOfFndTtlNAV")]
    #endif
    [IsoXmlTag("EstmtdPctgOfFndTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? EstimatedPercentageOfFundTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EstimatedPercentageOfFundTotalNAV { get; init; } 
    #else
    public System.Decimal? EstimatedPercentageOfFundTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated cash movement into the fund/sub fund.
    /// </summary>
    [IsoId("_wzHsEF-HEeS7xuKaq75oiQ")]
    [DisplayName("Estimated Cash In Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshInFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInOutForecast7? EstimatedCashInForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInOutForecast7? EstimatedCashInForecastDetails { get; init; } 
    #else
    public CashInOutForecast7? EstimatedCashInForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated cash movement out of the fund/sub fund.
    /// </summary>
    [IsoId("_wzHsEV-HEeS7xuKaq75oiQ")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshOutFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInOutForecast7? EstimatedCashOutForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInOutForecast7? EstimatedCashOutForecastDetails { get; init; } 
    #else
    public CashInOutForecast7? EstimatedCashOutForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_wzHsEl-HEeS7xuKaq75oiQ")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdNetCshFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast5? EstimatedNetCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast5? EstimatedNetCashForecastDetails { get; init; } 
    #else
    public NetCashForecast5? EstimatedNetCashForecastDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
