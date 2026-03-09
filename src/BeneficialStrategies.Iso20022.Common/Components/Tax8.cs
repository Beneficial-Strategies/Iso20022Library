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
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_VSJNFNp-Ed-ak6NoX_4Aeg_611903999")]
[DisplayName("Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tax8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Tax8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Tax8( TaxType3 reqType,string reqCountry )
    {
        Type = reqType;
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_VSJNFdp-Ed-ak6NoX_4Aeg_611904016")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType3 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxType3 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType3 Type { get; init; } 
    #else
    public TaxType3 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_VSJNFtp-Ed-ak6NoX_4Aeg_611904034")]
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
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_VSJNF9p-Ed-ak6NoX_4Aeg_611904051")]
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
    
    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_VSJNGNp-Ed-ak6NoX_4Aeg_611904069")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_VSJNGdp-Ed-ak6NoX_4Aeg_785830829")]
    [DisplayName("Tax Calculation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctnDtls")]
    #endif
    [IsoXmlTag("TaxClctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCalculationInformation2? TaxCalculationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCalculationInformation2? TaxCalculationDetails { get; init; } 
    #else
    public TaxCalculationInformation2? TaxCalculationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
