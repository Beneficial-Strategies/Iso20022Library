// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_VSJNFNp-Ed-ak6NoX_4Aeg_611903999")]
[DisplayName("Tax")]
public partial record Tax8
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_VSJNFdp-Ed-ak6NoX_4Aeg_611904016")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType3 Type { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_VSJNFtp-Ed-ak6NoX_4Aeg_611904034")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_VSJNF9p-Ed-ak6NoX_4Aeg_611904051")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_VSJNGNp-Ed-ak6NoX_4Aeg_611904069")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_VSJNGdp-Ed-ak6NoX_4Aeg_785830829")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation2? TaxCalculationDetails { get; init; } 
    
    
    #nullable disable
    
}
