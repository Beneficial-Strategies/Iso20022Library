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
[IsoId("_Sl4bKdp-Ed-ak6NoX_4Aeg_1978788372")]
[DisplayName("Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tax17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Tax17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Tax17( TaxType12Code reqType,System.String reqExtendedType,string reqCountry )
    {
        Type = reqType;
        ExtendedType = reqExtendedType;
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_Sl4bKtp-Ed-ak6NoX_4Aeg_1978788414")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType12Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxType12Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType12Code Type { get; init; } 
    #else
    public TaxType12Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_Sl4bK9p-Ed-ak6NoX_4Aeg_-1751950721")]
    [DisplayName("Extended Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedTp")]
    #endif
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedType { get; init; } 
    #else
    public System.String ExtendedType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_SmCMINp-Ed-ak6NoX_4Aeg_1978788709")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    [MinLength(0)]
    [MaxLength(7)]
    public ValueList<ActiveOrHistoricCurrencyAnd13DecimalAmount> Amount { get; init; } = new ValueList<ActiveOrHistoricCurrencyAnd13DecimalAmount>(){};
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_SmCMIdp-Ed-ak6NoX_4Aeg_1978788786")]
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
    [IsoId("_SmCMItp-Ed-ak6NoX_4Aeg_1978789094")]
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
    [IsoId("_SmCMI9p-Ed-ak6NoX_4Aeg_256540868")]
    [DisplayName("Tax Calculation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctnDtls")]
    #endif
    [IsoXmlTag("TaxClctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCalculationInformation4? TaxCalculationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCalculationInformation4? TaxCalculationDetails { get; init; } 
    #else
    public TaxCalculationInformation4? TaxCalculationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
