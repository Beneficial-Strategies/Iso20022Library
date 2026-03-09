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
/// Calculation of the net asset value for an investment fund/fund class.
/// </summary>
[IsoId("_Vbrjn9p-Ed-ak6NoX_4Aeg_-213723155")]
[DisplayName("Price Valuation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceValuation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceValuation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceValuation2( System.String reqIdentification,DateAndDateTimeChoice_ reqTradeDateTime,FinancialInstrument5 reqFinancialInstrumentDetails,ValuationTiming1Code reqValuationCycle,System.String reqSuspendedIndicator )
    {
        Identification = reqIdentification;
        TradeDateTime = reqTradeDateTime;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        ValuationCycle = reqValuationCycle;
        SuspendedIndicator = reqSuspendedIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a price valuation within a price report, as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_VbrjoNp-Ed-ak6NoX_4Aeg_-213722734")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_Vb0tgNp-Ed-ak6NoX_4Aeg_-213723153")]
    [DisplayName("Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtTm")]
    #endif
    [IsoXmlTag("ValtnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ValuationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? ValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_Vb0tgdp-Ed-ak6NoX_4Aeg_-213723138")]
    [DisplayName("Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtTm")]
    #endif
    [IsoXmlTag("TradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ TradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class for which the net asset value is calculated.
    /// </summary>
    [IsoId("_Vb0tgtp-Ed-ak6NoX_4Aeg_-1249708823")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument5 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_Vb0tg9p-Ed-ak6NoX_4Aeg_-213723102")]
    [DisplayName("Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNAV")]
    #endif
    [IsoXmlTag("TtlNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_Vb0thNp-Ed-ak6NoX_4Aeg_-213722836")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the next price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_Vb0thdp-Ed-ak6NoX_4Aeg_-213722811")]
    [DisplayName("Next Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtValtnDtTm")]
    #endif
    [IsoXmlTag("NxtValtnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? NextValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? NextValuationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? NextValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the previous price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_Vb0thtp-Ed-ak6NoX_4Aeg_-213722794")]
    [DisplayName("Previous Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsValtnDtTm")]
    #endif
    [IsoXmlTag("PrvsValtnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the valuation is done, based on the schedule stated in the prospectus.
    /// </summary>
    [IsoId("_Vb0th9p-Ed-ak6NoX_4Aeg_-213722776")]
    [DisplayName("Valuation Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnCycl")]
    #endif
    [IsoXmlTag("ValtnCycl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValuationTiming1Code ValuationCycle { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValuationTiming1Code ValuationCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationTiming1Code ValuationCycle { get; init; } 
    #else
    public ValuationTiming1Code ValuationCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("_Vb0tiNp-Ed-ak6NoX_4Aeg_-213722751")]
    [DisplayName("Suspended Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SspdInd")]
    #endif
    [IsoXmlTag("SspdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SuspendedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SuspendedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SuspendedIndicator { get; init; } 
    #else
    public System.String SuspendedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_Vb0tidp-Ed-ak6NoX_4Aeg_-213722690")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice6? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice6? PriceDetails { get; init; } 
    #else
    public UnitPrice6? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the price variations of an investment fund class.
    /// </summary>
    [IsoId("_Vb-egNp-Ed-ak6NoX_4Aeg_1507402268")]
    [DisplayName("Valuation Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnSttstcs")]
    #endif
    [IsoXmlTag("ValtnSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationStatistics2? ValuationStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationStatistics2? ValuationStatistics { get; init; } 
    #else
    public ValuationStatistics2? ValuationStatistics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
