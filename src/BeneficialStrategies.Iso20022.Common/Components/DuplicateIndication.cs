// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference to another message indicating that the containing message is a	duplicate of the referenced message.
/// </summary>
[IsoId("_WHybodp-Ed-ak6NoX_4Aeg_-1366284107")]
[DisplayName("Duplicate Indication")]
public partial record DuplicateIndication
{
    #nullable enable
    
    /// <summary>
    /// Reference of the original message, in case this is a duplicate.
    /// </summary>
    [IsoId("_WHybotp-Ed-ak6NoX_4Aeg_-1302561979")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text Reference { get; init; } 
    
    /// <summary>
    /// Information about the duplicate.
    /// </summary>
    [IsoId("_WHybo9p-Ed-ak6NoX_4Aeg_-1235145064")]
    [DisplayName("Justification")]
    [IsoXmlTag("Info")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Justification { get; init; } 
    
    
    #nullable disable
    
}
