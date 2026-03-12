// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the tax type.
/// </summary>
[IsoId("_VR2SLNp-Ed-ak6NoX_4Aeg_-826813666")]
[DisplayName("Tax Type")]
public partial record TaxType1
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VR2SLdp-Ed-ak6NoX_4Aeg_-826812770")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TaxType7Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VR2SLtp-Ed-ak6NoX_4Aeg_-826813345")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
