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
/// Valuation dealing processing characteristics linked to the instrument, ie, not to the market.
/// </summary>
[IsoId("_UBOXydp-Ed-ak6NoX_4Aeg_689275880")]
[DisplayName("Valuation Dealing Processing Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationDealingProcessingCharacteristics2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValuationDealingProcessingCharacteristics2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValuationDealingProcessingCharacteristics2( EventFrequency5Code reqValuationFrequency,System.String reqValuationFrequencyDescription,System.UInt64 reqDecimalisationUnits,System.UInt64 reqDecimalisationPrice,System.String reqDualFundIndicator,PriceMethod1Code reqPriceMethod )
    {
        ValuationFrequency = reqValuationFrequency;
        ValuationFrequencyDescription = reqValuationFrequencyDescription;
        DecimalisationUnits = reqDecimalisationUnits;
        DecimalisationPrice = reqDecimalisationPrice;
        DualFundIndicator = reqDualFundIndicator;
        PriceMethod = reqPriceMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Frequency of the valuation.
    /// </summary>
    [IsoId("_UBOXytp-Ed-ak6NoX_4Aeg_689276311")]
    [DisplayName("Valuation Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnFrqcy")]
    #endif
    [IsoXmlTag("ValtnFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventFrequency5Code ValuationFrequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventFrequency5Code ValuationFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency5Code ValuationFrequency { get; init; } 
    #else
    public EventFrequency5Code ValuationFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Further details regarding the dealing frequency, eg, Tuesday (for weekly dealing) or last business day of the month.
    /// </summary>
    [IsoId("_UBOXy9p-Ed-ak6NoX_4Aeg_689276342")]
    [DisplayName("Valuation Frequency Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnFrqcyDesc")]
    #endif
    [IsoXmlTag("ValtnFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text ValuationFrequencyDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ValuationFrequencyDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ValuationFrequencyDescription { get; init; } 
    #else
    public System.String ValuationFrequencyDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_UBYIwNp-Ed-ak6NoX_4Aeg_690196799")]
    [DisplayName("Decimalisation Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcmlstnUnits")]
    #endif
    [IsoXmlTag("DcmlstnUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber DecimalisationUnits { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 DecimalisationUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 DecimalisationUnits { get; init; } 
    #else
    public System.UInt64 DecimalisationUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_UBYIwdp-Ed-ak6NoX_4Aeg_689276796")]
    [DisplayName("Decimalisation Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcmlstnPric")]
    #endif
    [IsoXmlTag("DcmlstnPric")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber DecimalisationPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 DecimalisationPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 DecimalisationPrice { get; init; } 
    #else
    public System.UInt64 DecimalisationPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_UBYIwtp-Ed-ak6NoX_4Aeg_689276681")]
    [DisplayName("Dual Fund Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DualFndInd")]
    #endif
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator DualFundIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DualFundIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DualFundIndicator { get; init; } 
    #else
    public System.String DualFundIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_UBYIw9p-Ed-ak6NoX_4Aeg_689276712")]
    [DisplayName("Price Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMtd")]
    #endif
    [IsoXmlTag("PricMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceMethod1Code PriceMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceMethod1Code PriceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceMethod1Code PriceMethod { get; init; } 
    #else
    public PriceMethod1Code PriceMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Currencies in which the prices for the investment fund class are published by the fund management company.
    /// </summary>
    [IsoId("_UBYIxNp-Ed-ak6NoX_4Aeg_689276743")]
    [DisplayName("Price Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricCcy")]
    #endif
    [IsoXmlTag("PricCcy")]
    public SimpleValueList<string> PriceCurrency { get; init; } = new SimpleValueList<string>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UBYIxNp-Ed-ak6NoX_4Aeg_689276743
    
    
    #nullable disable
    
}
