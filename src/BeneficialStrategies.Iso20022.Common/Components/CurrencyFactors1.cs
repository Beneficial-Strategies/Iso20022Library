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
/// Currency specific Factors.
/// </summary>
[IsoId("_SvDFDAEcEeCQm6a_G2yO_w_737045003")]
[DisplayName("Currency Factors")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyFactors1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyFactors1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyFactors1( string reqCurrency,ImpliedCurrencyAndAmount reqShortPositionLimit,ImpliedCurrencyAndAmount reqMinimumPayInAmount,System.Decimal reqVolatilityMargin )
    {
        Currency = reqCurrency;
        ShortPositionLimit = reqShortPositionLimit;
        MinimumPayInAmount = reqMinimumPayInAmount;
        VolatilityMargin = reqVolatilityMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the underlying currency specific amounts and ratios used in the pay-in schedule calculation.
    /// </summary>
    [IsoId("_SvDFDQEcEeCQm6a_G2yO_w_-1485086465")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum allowed short position in the currency during settlement.
    /// </summary>
    [IsoId("_SvDFDgEcEeCQm6a_G2yO_w_243513360")]
    [DisplayName("Short Position Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtPosLmt")]
    #endif
    [IsoXmlTag("ShrtPosLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ShortPositionLimit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ShortPositionLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ShortPositionLimit { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ShortPositionLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount paid in one payment unless the short position is less than the minimum.
    /// </summary>
    [IsoId("_SvDFDwEcEeCQm6a_G2yO_w_151707201")]
    [DisplayName("Minimum Pay In Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinPayInAmt")]
    #endif
    [IsoXmlTag("MinPayInAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount MinimumPayInAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount MinimumPayInAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount MinimumPayInAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount MinimumPayInAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Margin used to decrease long positions and increase short positions during the risk calculation.
    /// </summary>
    [IsoId("_SvM2AAEcEeCQm6a_G2yO_w_-1119940583")]
    [DisplayName("Volatility Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoltlyMrgn")]
    #endif
    [IsoXmlTag("VoltlyMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate VolatilityMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal VolatilityMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal VolatilityMargin { get; init; } 
    #else
    public System.Decimal VolatilityMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate used in the calculation of the pay-in schedule.
    /// </summary>
    [IsoId("_SvM2AQEcEeCQm6a_G2yO_w_948992700")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreedRate2? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate2? Rate { get; init; } 
    #else
    public AgreedRate2? Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
