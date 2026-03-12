// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_cwOuIZBgEeakHoV5BVecAQ")]
[DisplayName("Linkages")]
public partial record Linkages52
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_dAFIA5BgEeakHoV5BVecAQ")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber17Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_dAFIC5BgEeakHoV5BVecAQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IdentificationReference8Choice_ Reference { get; init; } 
    
    
    #nullable disable
    
}
