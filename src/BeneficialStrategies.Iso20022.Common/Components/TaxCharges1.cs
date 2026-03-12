// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_Rvygrdp-Ed-ak6NoX_4Aeg_438228373")]
[DisplayName("Tax Charges")]
public partial record TaxCharges1
{
    #nullable enable
    
    /// <summary>
    /// Reference used to identify the nature of tax levied, such as Value Added Tax (VAT).
    /// </summary>
    [IsoId("_Rvygrtp-Ed-ak6NoX_4Aeg_836264050")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_Rv8RoNp-Ed-ak6NoX_4Aeg_438228776")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_Rv8Rodp-Ed-ak6NoX_4Aeg_438228733")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CurrencyAndAmount? Amount { get; init; } 
    
    
    #nullable disable
    
}
