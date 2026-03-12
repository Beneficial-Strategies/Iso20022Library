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
[IsoId("_AgUuTQd3Ee2fOITqoTnSLQ")]
[DisplayName("Linkages")]
public partial record Linkages72
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_Az_REwd3Ee2fOITqoTnSLQ")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber17Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_Az_RGwd3Ee2fOITqoTnSLQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IdentificationReference11Choice_ Reference { get; init; } 
    
    
    #nullable disable
    
}
