// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the taxable income per share.
/// </summary>
[IsoId("_VSl5B9p-Ed-ak6NoX_4Aeg_-362445404")]
[DisplayName("Taxable Income Per Share Calculated")]
public partial record TaxableIncomePerShareCalculated1
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VSl5CNp-Ed-ak6NoX_4Aeg_-309804629")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TaxableIncomePerShareCalculated1Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VSl5Cdp-Ed-ak6NoX_4Aeg_-308882890")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
