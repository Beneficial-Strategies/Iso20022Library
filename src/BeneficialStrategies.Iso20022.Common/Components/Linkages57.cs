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
[IsoId("_YisEcTneEem7JZMuWtwtsg")]
[DisplayName("Linkages")]
public partial record Linkages57
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_Ys-BgTneEem7JZMuWtwtsg")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition7Choice_? ProcessingPosition { get; init; } 
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_Ys-BiTneEem7JZMuWtwtsg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_Ys-BkTneEem7JZMuWtwtsg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References34Choice_ Reference { get; init; } 
    
    /// <summary>
    /// Party responsible for generating the reference.
    /// </summary>
    [IsoId("_Ys-BmTneEem7JZMuWtwtsg")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification127Choice_? ReferenceOwner { get; init; } 
    
    
    #nullable disable
    
}
