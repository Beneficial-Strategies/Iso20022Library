// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deletion of the current element.
/// </summary>
[IsoId("_UtVP1tp-Ed-ak6NoX_4Aeg_1632709893")]
[DisplayName("Deletion")]
public partial record Deletion1
{
    #nullable enable
    
    /// <summary>
    /// Content of the deleted element.
    /// </summary>
    [IsoId("_UtVP19p-Ed-ak6NoX_4Aeg_2107399666")]
    [DisplayName("Deleted Value")]
    [IsoXmlTag("DeltdVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text DeletedValue { get; init; } 
    
    
    #nullable disable
    
}
