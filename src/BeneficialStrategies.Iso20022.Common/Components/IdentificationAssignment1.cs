// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that identify the identification assignment.
/// </summary>
[IsoId("_QpUAxNp-Ed-ak6NoX_4Aeg_1072835479")]
[DisplayName("Identification Assignment")]
public partial record IdentificationAssignment1
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the assigner, and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The assigner has to make sure that MessageIdentification is unique per assignee for a pre-agreed period.
    /// </summary>
    [IsoId("_QpUAxdp-Ed-ak6NoX_4Aeg_-498844044")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the identification assignment was created.
    /// </summary>
    [IsoId("_QpUAxtp-Ed-ak6NoX_4Aeg_-1223862384")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Party that created the identification assignment.
    /// </summary>
    [IsoId("_QpUAx9p-Ed-ak6NoX_4Aeg_1100809451")]
    [DisplayName("Creator")]
    [IsoXmlTag("Cretr")]
    public Party7Choice_? Creator { get; init; } 
    
    /// <summary>
    /// Party that assigns the identification assignment to another party. This is also the sender of the message.
    /// </summary>
    [IsoId("_QpdKsNp-Ed-ak6NoX_4Aeg_-1061732853")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party7Choice_ Assigner { get; init; } 
    
    /// <summary>
    /// Party that the identification assignment is assigned to. This is also the receiver of the message.
    /// </summary>
    [IsoId("_QpdKsdp-Ed-ak6NoX_4Aeg_1821913207")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party7Choice_ Assignee { get; init; } 
    
    
    #nullable disable
    
}
