// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Replacement of an existing content by a different one.
/// </summary>
[IsoId("_UtfA1dp-Ed-ak6NoX_4Aeg_1630860927")]
[DisplayName("Replacement")]
public partial record Replacement1
{
    #nullable enable
    
    /// <summary>
    /// Content of the current element.
    /// </summary>
    [IsoId("_UtfA1tp-Ed-ak6NoX_4Aeg_2072304256")]
    [DisplayName("Current Value")]
    [IsoXmlTag("CurVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text CurrentValue { get; init; } 
    
    /// <summary>
    /// Content of the new element.
    /// </summary>
    [IsoId("_UtfA19p-Ed-ak6NoX_4Aeg_2072304711")]
    [DisplayName("Proposed Value")]
    [IsoXmlTag("PropsdVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text ProposedValue { get; init; } 
    
    
    #nullable disable
    
}
