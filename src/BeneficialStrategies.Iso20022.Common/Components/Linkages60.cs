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
[IsoId("_jJP0yyAZEeu4a6pNulzZ4Q")]
[DisplayName("Linkages")]
public partial record Linkages60
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_jJP0zyAZEeu4a6pNulzZ4Q")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition10Choice_? ProcessingPosition { get; init; } 
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_jJP01yAZEeu4a6pNulzZ4Q")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber6Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_jJP03yAZEeu4a6pNulzZ4Q")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References50Choice_ Reference { get; init; } 
    
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_jJP05yAZEeu4a6pNulzZ4Q")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification136Choice_? ReferenceOwner { get; init; } 
    
    
    #nullable disable
    
}
