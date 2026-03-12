// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the price type.
/// </summary>
[IsoId("_UQlCYtp-Ed-ak6NoX_4Aeg_1864790659")]
[DisplayName("Price Type")]
public partial record PriceType2
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_UQlCY9p-Ed-ak6NoX_4Aeg_1890648274")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TypeOfPrice6Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of charge.
    /// </summary>
    [IsoId("_UQlCZNp-Ed-ak6NoX_4Aeg_1890648275")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
