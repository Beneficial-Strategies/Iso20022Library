// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to the instrument, that is, not to the market.
/// </summary>
[IsoId("_cx-V4TgCEei6RvewLQWEqw")]
[DisplayName("Forms")]
public partial record Forms1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether a physical application form is required.
    /// </summary>
    [IsoId("_dCMjMTgCEei6RvewLQWEqw")]
    [DisplayName("Application Form")]
    [IsoXmlTag("ApplForm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ApplicationForm { get; init; } 
    
    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("_dCMjMzgCEei6RvewLQWEqw")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public required SignatureType1Code SignatureType { get; init; } 
    
    
    #nullable disable
    
}
