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
[IsoId("_0l2JIdBwEeihG9bKfarOOA")]
[DisplayName("Linkages")]
public partial record Linkages53
{
    #nullable enable
    
    /// <summary>
    /// Specifies when the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_03jkM9BwEeihG9bKfarOOA")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition8Choice_? ProcessingPosition { get; init; } 
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_03jkO9BwEeihG9bKfarOOA")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_03jkQ9BwEeihG9bKfarOOA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References65Choice_ Reference { get; init; } 
    
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_03jkS9BwEeihG9bKfarOOA")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification127Choice_? ReferenceOwner { get; init; } 
    
    
    #nullable disable
    
}
