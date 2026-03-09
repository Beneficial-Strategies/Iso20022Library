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
/// Provides extra tax details.
/// </summary>
[IsoId("_1bBq5m99EeKuY41pq1-dog")]
[DisplayName("Tax SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_1bBrGG99EeKuY41pq1-dog")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of foreign tax credit per security.
    /// </summary>
    [IsoId("_1bBrHW99EeKuY41pq1-dog")]
    [DisplayName("Foreign Tax Credit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnTaxCdtAmt")]
    #endif
    [IsoXmlTag("FrgnTaxCdtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ForeignTaxCreditAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ForeignTaxCreditAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ForeignTaxCreditAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percent of foreign tax credit per security|.
    /// </summary>
    [IsoId("_1bBrCW99EeKuY41pq1-dog")]
    [DisplayName("Foreign Tax Credit Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnTaxCdtRate")]
    #endif
    [IsoXmlTag("FrgnTaxCdtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ForeignTaxCreditRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ForeignTaxCreditRate { get; init; } 
    #else
    public System.Decimal? ForeignTaxCreditRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the dividend that is being paid out of income earned in a foreign jurisdiction.
    /// </summary>
    [IsoId("_1bBq-m99EeKuY41pq1-dog")]
    [DisplayName("Foreign Source Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnSrcAmt")]
    #endif
    [IsoXmlTag("FrgnSrcAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ForeignSourceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ForeignSourceAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ForeignSourceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the dividend that is being paid out of income earned in a foreign jurisdiction.
    /// </summary>
    [IsoId("_1bBrE299EeKuY41pq1-dog")]
    [DisplayName("Foreign Source Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnSrcRate")]
    #endif
    [IsoXmlTag("FrgnSrcRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ForeignSourceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ForeignSourceRate { get; init; } 
    #else
    public System.Decimal? ForeignSourceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Form of tax advantage on the dividend.
    /// </summary>
    [IsoId("_1bBq6299EeKuY41pq1-dog")]
    [DisplayName("Tax Advantage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAdvntgTp")]
    #endif
    [IsoXmlTag("TaxAdvntgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxAdvantageType1Code? TaxAdvantageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxAdvantageType1Code? TaxAdvantageType { get; init; } 
    #else
    public TaxAdvantageType1Code? TaxAdvantageType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the tax advantage on the dividend.
    /// </summary>
    [IsoId("_1bBq9W99EeKuY41pq1-dog")]
    [DisplayName("Tax Advantage Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAdvntgAmt")]
    #endif
    [IsoXmlTag("TaxAdvntgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TaxAdvantageAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TaxAdvantageAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TaxAdvantageAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percent of the tax advantage on the dividend.
    /// </summary>
    [IsoId("_1bBrBG99EeKuY41pq1-dog")]
    [DisplayName("Tax Advantage Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAdvntgRate")]
    #endif
    [IsoXmlTag("TaxAdvntgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxAdvantageRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxAdvantageRate { get; init; } 
    #else
    public System.Decimal? TaxAdvantageRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_1bBrDm99EeKuY41pq1-dog")]
    [DisplayName("Sundry Or Other Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndryOrOthrRate")]
    #endif
    [IsoXmlTag("SndryOrOthrRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? SundryOrOtherRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SundryOrOtherRate { get; init; } 
    #else
    public System.Decimal? SundryOrOtherRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_1bBq8G99EeKuY41pq1-dog")]
    [DisplayName("Tax Deferred Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDfrrdRate")]
    #endif
    [IsoXmlTag("TaxDfrrdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxDeferredRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxDeferredRate { get; init; } 
    #else
    public System.Decimal? TaxDeferredRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_1bBq_299EeKuY41pq1-dog")]
    [DisplayName("Tax Free Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxFreeRate")]
    #endif
    [IsoXmlTag("TaxFreeRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxFreeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxFreeRate { get; init; } 
    #else
    public System.Decimal? TaxFreeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
