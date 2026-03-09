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
[IsoId("_4FQWwSVlEeWV8IT-SD_UOg")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice21( TypeOfPrice31Choice_ reqType,PriceValue1 reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_4iRC5SVlEeWV8IT-SD_UOg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice31Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice31Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice31Choice_ Type { get; init; } 
    #else
    public TypeOfPrice31Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_4iRC6SVlEeWV8IT-SD_UOg")]
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
    [IsoId("_4iRC6yVlEeWV8IT-SD_UOg")]
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
    [IsoId("_4iRC7SVlEeWV8IT-SD_UOg")]
    [DisplayName("Accrued Interest NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstNAV")]
    #endif
    [IsoXmlTag("AcrdIntrstNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_4iRC7yVlEeWV8IT-SD_UOg")]
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
    [IsoId("_4iRC9yVlEeWV8IT-SD_UOg")]
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
    
    
    #nullable disable
    
}
