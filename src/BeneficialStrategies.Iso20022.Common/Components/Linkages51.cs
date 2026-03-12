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
[IsoId("_aWPloeFhEeWIA4E9cYSxxQ")]
[DisplayName("Linkages")]
public partial record Linkages51
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_afK4IeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition7Choice_? ProcessingPosition { get; init; } 
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_afK4KeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_afK4MeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References34Choice_ Reference { get; init; } 
    
    /// <summary>
    /// Party responsible for generating the reference.
    /// </summary>
    [IsoId("_afK4OeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification92Choice_? ReferenceOwner { get; init; } 
    
    
    #nullable disable
    
}
