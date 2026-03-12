// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information that can not be captured in the structured fields and/or any other specific block.
/// </summary>
[IsoId("_Q6vvCNp-Ed-ak6NoX_4Aeg_1503007069")]
[DisplayName("Extension")]
public partial record Extension1
{
    #nullable enable
    
    /// <summary>
    /// Name qualifying the information provided in the Text field, and place where this information should be inserted.
    /// </summary>
    [IsoId("_Q65gANp-Ed-ak6NoX_4Aeg_-1802982859")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Text of the extension.
    /// </summary>
    [IsoId("_Q65gAdp-Ed-ak6NoX_4Aeg_-1661684876")]
    [DisplayName("Text")]
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Text { get; init; } 
    
    
    #nullable disable
    
}
