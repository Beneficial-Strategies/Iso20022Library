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
[IsoId("_H-S6vf7uEeCvPoRGOxRobQ")]
[DisplayName("Linkages")]
public partial record Linkages16
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_H-S6w_7uEeCvPoRGOxRobQ")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition2Choice_? ProcessingPosition { get; init; } 
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_H-S6zf7uEeCvPoRGOxRobQ")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_H-S61_7uEeCvPoRGOxRobQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References24Choice_ Reference { get; init; } 
    
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_H-S64f7uEeCvPoRGOxRobQ")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification36Choice_? ReferenceOwner { get; init; } 
    
    
    #nullable disable
    
}
