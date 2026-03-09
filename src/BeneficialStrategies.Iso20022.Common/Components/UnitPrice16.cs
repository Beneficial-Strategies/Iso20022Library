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
[IsoId("_QfxqStp-Ed-ak6NoX_4Aeg_394298835")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice16( UnitPriceType1Choice_ reqUnitPriceType,PriceValue1 reqValue )
    {
        UnitPriceType = reqUnitPriceType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of price.
    /// </summary>
    [IsoId("_Qf60MNp-Ed-ak6NoX_4Aeg_-466354401")]
    [DisplayName("Unit Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPricTp")]
    #endif
    [IsoXmlTag("UnitPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitPriceType1Choice_ UnitPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitPriceType1Choice_ UnitPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPriceType1Choice_ UnitPriceType { get; init; } 
    #else
    public UnitPriceType1Choice_ UnitPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_Qf60Mdp-Ed-ak6NoX_4Aeg_394299267")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValue1 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceValue1 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1 Value { get; init; } 
    #else
    public PriceValue1 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_Qf60Mtp-Ed-ak6NoX_4Aeg_1724434450")]
    [DisplayName("Taxable Income Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShr")]
    #endif
    [IsoXmlTag("TaxblIncmPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Taxable income per share calculated.
    /// </summary>
    [IsoId("_Qf60M9p-Ed-ak6NoX_4Aeg_205901546")]
    [DisplayName("Taxable Income Per Share Calculated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShrClctd")]
    #endif
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxableIncomePerShareCalculatedType1Choice_? TaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxableIncomePerShareCalculatedType1Choice_? TaxableIncomePerShareCalculated { get; init; } 
    #else
    public TaxableIncomePerShareCalculatedType1Choice_? TaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    
    #nullable disable
    
}
