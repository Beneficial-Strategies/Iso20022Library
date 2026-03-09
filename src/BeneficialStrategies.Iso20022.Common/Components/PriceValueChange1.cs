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
/// Value given to a positive or negative price change.
/// </summary>
[IsoId("_QajzFNp-Ed-ak6NoX_4Aeg_-1357819098")]
[DisplayName("Price Value Change")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceValueChange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount by which the price has changed.
    /// </summary>
    [IsoId("_QajzFdp-Ed-ak6NoX_4Aeg_-1357819072")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a positive or negative amount change.
    /// </summary>
    [IsoId("_QajzFtp-Ed-ak6NoX_4Aeg_-1314414014")]
    [DisplayName("Amount Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtSgn")]
    #endif
    [IsoXmlTag("AmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPlusOrMinusIndicator? AmountSign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmountSign { get; init; } 
    #else
    public System.String? AmountSign { get; set; } 
    #endif
    
    /// <summary>
    /// Rate by which the price has changed.
    /// </summary>
    [IsoId("_QajzF9p-Ed-ak6NoX_4Aeg_-1357819056")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Rate { get; init; } 
    #else
    public System.Decimal? Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
