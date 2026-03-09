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
/// Valuation dealing processing characteristics linked to the instrument, that is, not to the market.
/// </summary>
[IsoId("_DovC8UlNEeiZP-CimVE7Hg")]
[DisplayName("Valuation Dealing Processing Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationDealingProcessingCharacteristics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Frequency of the valuation.
    /// </summary>
    [IsoId("_D4puQ0lNEeiZP-CimVE7Hg")]
    [DisplayName("Valuation Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnFrqcy")]
    #endif
    [IsoXmlTag("ValtnFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency5Code? ValuationFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency5Code? ValuationFrequency { get; init; } 
    #else
    public EventFrequency5Code? ValuationFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Further details regarding the dealing frequency, for example, Tuesday (for weekly dealing) or last business day of the month.
    /// </summary>
    [IsoId("_D4puRUlNEeiZP-CimVE7Hg")]
    [DisplayName("Valuation Frequency Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnFrqcyDesc")]
    #endif
    [IsoXmlTag("ValtnFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ValuationFrequencyDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValuationFrequencyDescription { get; init; } 
    #else
    public System.String? ValuationFrequencyDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation time of the fund.
    /// </summary>
    [IsoId("_lx4-wF80Eeicg40_9gK9vQ")]
    [DisplayName("Valuation Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnTm")]
    #endif
    [IsoXmlTag("ValtnTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ValuationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ValuationTime { get; init; } 
    #else
    public System.TimeOnly? ValuationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_D4puR0lNEeiZP-CimVE7Hg")]
    [DisplayName("Decimalisation Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcmlstnUnits")]
    #endif
    [IsoXmlTag("DcmlstnUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DecimalisationUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DecimalisationUnits { get; init; } 
    #else
    public System.UInt64? DecimalisationUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Number of decimal places to which the price is rounded.
    /// </summary>
    [IsoId("_D4puSUlNEeiZP-CimVE7Hg")]
    [DisplayName("Decimalisation Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcmlstnPric")]
    #endif
    [IsoXmlTag("DcmlstnPric")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DecimalisationPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DecimalisationPrice { get; init; } 
    #else
    public System.UInt64? DecimalisationPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_D4puS0lNEeiZP-CimVE7Hg")]
    [DisplayName("Dual Fund Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DualFndInd")]
    #endif
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DualFundIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DualFundIndicator { get; init; } 
    #else
    public System.String? DualFundIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_D4puTUlNEeiZP-CimVE7Hg")]
    [DisplayName("Price Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMtd")]
    #endif
    [IsoXmlTag("PricMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceMethod1Code? PriceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceMethod1Code? PriceMethod { get; init; } 
    #else
    public PriceMethod1Code? PriceMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Currencies in which the prices for the investment fund class are published by the fund management company.
    /// </summary>
    [IsoId("_D4puT0lNEeiZP-CimVE7Hg")]
    [DisplayName("Price Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricCcy")]
    #endif
    [IsoXmlTag("PricCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? PriceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PriceCurrency { get; init; } 
    #else
    public string? PriceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the valuation dealing characteristics.
    /// </summary>
    [IsoId("_TaV6cWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
