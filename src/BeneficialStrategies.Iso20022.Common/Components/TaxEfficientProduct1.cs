// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a tax efficient product.
/// </summary>
[IsoId("_xBhakU4KEeiQHa-q1Uephw")]
[DisplayName("Tax Efficient Product")]
public partial record TaxEfficientProduct1
{
    #nullable enable
    
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_-BnMwE4KEeiQHa-q1Uephw")]
    [DisplayName("Tax Efficient Product Type")]
    [IsoXmlTag("TaxEffcntPdctTp")]
    public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; } 
    
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_xRJK904KEeiQHa-q1Uephw")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear2Choice_? PreviousYears { get; init; } 
    
    /// <summary>
    /// Indicates that the product was issued during the current fiscal year.
    /// </summary>
    [IsoId("_xRJK9U4KEeiQHa-q1Uephw")]
    [DisplayName("Current Year")]
    [IsoXmlTag("CurYr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CurrentYear { get; init; } 
    
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_DlX7IV3AEeiFXdiLi_Nf4A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
