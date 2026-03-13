// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed description of the differences.
/// </summary>
[IsoId("_UsvZ8dp-Ed-ak6NoX_4Aeg_-1609439696")]
[DisplayName("Validation Result")]
public partial record ValidationResult4
{
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to the mismatch.
    /// </summary>
    [IsoId("_UsvZ8tp-Ed-ak6NoX_4Aeg_-1609439419")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber SequenceNumber { get; init; } 
    
    /// <summary>
    /// Coded identification of the matching rule that is violated by the contents of each baseline.
    /// </summary>
    [IsoId("_UsvZ89p-Ed-ak6NoX_4Aeg_-1609439460")]
    [DisplayName("Rule Identification")]
    [IsoXmlTag("RuleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RuleIdentification { get; init; } 
    
    /// <summary>
    /// Detailed description of the rule.
    /// </summary>
    [IsoId("_UsvZ9Np-Ed-ak6NoX_4Aeg_-1609439436")]
    [DisplayName("Rule Description")]
    [IsoXmlTag("RuleDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text RuleDescription { get; init; } 
    
    /// <summary>
    /// Description of the element that creates the mismatch.
    /// </summary>
    [IsoId("_UsvZ9dp-Ed-ak6NoX_4Aeg_-1609439383")]
    [DisplayName("Mis Matched Element")]
    [IsoXmlTag("MisMtchdElmt")]
    public ValueList<ElementIdentification1> MisMatchedElement { get; init; } = [];
    // ID for the above is _UsvZ9dp-Ed-ak6NoX_4Aeg_-1609439383
    
    
    #nullable disable
    
}
