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
[IsoId("_U4XbKNp-Ed-ak6NoX_4Aeg_-49589526")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice3( TypeOfPrice2Code reqPriceType,PriceValue1 reqValue )
    {
        PriceType = reqPriceType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4XbKdp-Ed-ak6NoX_4Aeg_173901731")]
    [DisplayName("Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTp")]
    #endif
    [IsoXmlTag("PricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice2Code PriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice2Code PriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice2Code PriceType { get; init; } 
    #else
    public TypeOfPrice2Code PriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4XbKtp-Ed-ak6NoX_4Aeg_173902002")]
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
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_U4glENp-Ed-ak6NoX_4Aeg_173902033")]
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
    /// Interest that has accumulated between the most recent payment of interest and the sale of the financial instrument.
    /// </summary>
    [IsoId("_U4glEdp-Ed-ak6NoX_4Aeg_66170835")]
    [DisplayName("Accrued Interest NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstNAV")]
    #endif
    [IsoXmlTag("AcrdIntrstNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? AccruedInterestNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? AccruedInterestNAV { get; init; } 
    #else
    public CurrencyAndAmount? AccruedInterestNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_U4glEtp-Ed-ak6NoX_4Aeg_107730858")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_U4glE9p-Ed-ak6NoX_4Aeg_396874449")]
    [DisplayName("Taxable Income Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShr")]
    #endif
    [IsoXmlTag("TaxblIncmPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TaxableIncomePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TaxableIncomePerShare { get; init; } 
    #else
    public CurrencyAndAmount? TaxableIncomePerShare { get; set; } 
    #endif
    
    
    #nullable disable
    
}
