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
/// Cash dividend amount per equity after deductions or allowances have been made.
/// </summary>
[IsoId("_UPrqgNp-Ed-ak6NoX_4Aeg_2118430595")]
[DisplayName("Net Dividend Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetDividendRate2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetDividendRate2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetDividendRate2( NetDividendRateType1FormatChoice_ reqRateType,ActiveCurrencyAndAmount reqAmount )
    {
        RateType = reqRateType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of underlying securities to which the rate is related, eg, underlying security for which an interest is paid.
    /// </summary>
    [IsoId("_UPrqgdp-Ed-ak6NoX_4Aeg_-2120201442")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetDividendRateType1FormatChoice_ RateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetDividendRateType1FormatChoice_ RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateType1FormatChoice_ RateType { get; init; } 
    #else
    public NetDividendRateType1FormatChoice_ RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_UPrqgtp-Ed-ak6NoX_4Aeg_-2120201411")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
