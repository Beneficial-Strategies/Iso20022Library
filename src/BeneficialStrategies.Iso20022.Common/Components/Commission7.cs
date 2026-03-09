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
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_VPdsitp-Ed-ak6NoX_4Aeg_-1738143487")]
[DisplayName("Commission")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Commission7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Commission7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Commission7( ActiveCurrencyAnd13DecimalAmount reqAmount,System.Decimal reqRate,CommissionType1 reqType )
    {
        Amount = reqAmount;
        Rate = reqRate;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_VPm2cNp-Ed-ak6NoX_4Aeg_-1738143452")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_VPm2cdp-Ed-ak6NoX_4Aeg_-1738143410")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_VPm2ctp-Ed-ak6NoX_4Aeg_-1738143469")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommissionType1 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommissionType1 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommissionType1 Type { get; init; } 
    #else
    public CommissionType1 Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
