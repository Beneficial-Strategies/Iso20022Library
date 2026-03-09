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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_WL9J-dp-Ed-ak6NoX_4Aeg_-680211431")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice17( TypeOfPrice15Code reqType,PriceValue6 reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_WL9J-tp-Ed-ak6NoX_4Aeg_-680211401")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice15Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice15Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice15Code Type { get; init; } 
    #else
    public TypeOfPrice15Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_WL9J-9p-Ed-ak6NoX_4Aeg_-680211309")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValue6 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceValue6 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue6 Value { get; init; } 
    #else
    public PriceValue6 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_WL9J_Np-Ed-ak6NoX_4Aeg_-680211164")]
    [DisplayName("Taxable Income Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShr")]
    #endif
    [IsoXmlTag("TaxblIncmPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_WL9J_dp-Ed-ak6NoX_4Aeg_-680210885")]
    [DisplayName("Taxable Income Per Share Calculated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShrClctd")]
    #endif
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #else
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    
    #nullable disable
    
}
