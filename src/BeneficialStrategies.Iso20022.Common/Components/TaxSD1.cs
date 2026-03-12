// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides extra tax details.
/// </summary>
[IsoId("_1bBq5m99EeKuY41pq1-dog")]
[DisplayName("Tax SD")]
public partial record TaxSD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_1bBrGG99EeKuY41pq1-dog")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Amount of foreign tax credit per security.
    /// </summary>
    [IsoId("_1bBrHW99EeKuY41pq1-dog")]
    [DisplayName("Foreign Tax Credit Amount")]
    [IsoXmlTag("FrgnTaxCdtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ForeignTaxCreditAmount { get; init; } 
    
    /// <summary>
    /// Percent of foreign tax credit per security|.
    /// </summary>
    [IsoId("_1bBrCW99EeKuY41pq1-dog")]
    [DisplayName("Foreign Tax Credit Rate")]
    [IsoXmlTag("FrgnTaxCdtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ForeignTaxCreditRate { get; init; } 
    
    /// <summary>
    /// Amount of the dividend that is being paid out of income earned in a foreign jurisdiction.
    /// </summary>
    [IsoId("_1bBq-m99EeKuY41pq1-dog")]
    [DisplayName("Foreign Source Amount")]
    [IsoXmlTag("FrgnSrcAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ForeignSourceAmount { get; init; } 
    
    /// <summary>
    /// Percentage of the dividend that is being paid out of income earned in a foreign jurisdiction.
    /// </summary>
    [IsoId("_1bBrE299EeKuY41pq1-dog")]
    [DisplayName("Foreign Source Rate")]
    [IsoXmlTag("FrgnSrcRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ForeignSourceRate { get; init; } 
    
    /// <summary>
    /// Form of tax advantage on the dividend.
    /// </summary>
    [IsoId("_1bBq6299EeKuY41pq1-dog")]
    [DisplayName("Tax Advantage Type")]
    [IsoXmlTag("TaxAdvntgTp")]
    public TaxAdvantageType1Code? TaxAdvantageType { get; init; } 
    
    /// <summary>
    /// Amount of the tax advantage on the dividend.
    /// </summary>
    [IsoId("_1bBq9W99EeKuY41pq1-dog")]
    [DisplayName("Tax Advantage Amount")]
    [IsoXmlTag("TaxAdvntgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxAdvantageAmount { get; init; } 
    
    /// <summary>
    /// Percent of the tax advantage on the dividend.
    /// </summary>
    [IsoId("_1bBrBG99EeKuY41pq1-dog")]
    [DisplayName("Tax Advantage Rate")]
    [IsoXmlTag("TaxAdvntgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxAdvantageRate { get; init; } 
    
    /// <summary>
    /// Percentage of the amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_1bBrDm99EeKuY41pq1-dog")]
    [DisplayName("Sundry Or Other Rate")]
    [IsoXmlTag("SndryOrOthrRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? SundryOrOtherRate { get; init; } 
    
    /// <summary>
    /// Percentage of the amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_1bBq8G99EeKuY41pq1-dog")]
    [DisplayName("Tax Deferred Rate")]
    [IsoXmlTag("TaxDfrrdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxDeferredRate { get; init; } 
    
    /// <summary>
    /// Percentage of the amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_1bBq_299EeKuY41pq1-dog")]
    [DisplayName("Tax Free Rate")]
    [IsoXmlTag("TaxFreeRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxFreeRate { get; init; } 
    
    
    #nullable disable
    
}
