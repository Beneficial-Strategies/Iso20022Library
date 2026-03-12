// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification assignment.
/// </summary>
[IsoId("_QIQa4W49EeiU9cctagi5ow")]
[DisplayName("Identification Assignment")]
public partial record IdentificationAssignment3
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the assigner, and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The assigner has to make sure that MessageIdentification is unique per assignee for a pre-agreed period.
    /// </summary>
    [IsoId("_QT4cE249EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the identification assignment was created.
    /// </summary>
    [IsoId("_QT4cFW49EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Party that created the identification assignment.
    /// </summary>
    [IsoId("_QT4cF249EeiU9cctagi5ow")]
    [DisplayName("Creator")]
    [IsoXmlTag("Cretr")]
    public Party40Choice_? Creator { get; init; } 
    
    /// <summary>
    /// Identifies the first agent in the identification chain, following the payment initiating party.
    /// </summary>
    [IsoId("_QT4cGW49EeiU9cctagi5ow")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public BranchAndFinancialInstitutionIdentification6? FirstAgent { get; init; } 
    
    /// <summary>
    /// Party that assigns the identification assignment to another party. This is also the sender of the message.
    /// </summary>
    [IsoId("_QT4cG249EeiU9cctagi5ow")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party40Choice_ Assigner { get; init; } 
    
    /// <summary>
    /// Party that the identification assignment is assigned to. This is also the receiver of the message.
    /// </summary>
    [IsoId("_QT4cHW49EeiU9cctagi5ow")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party40Choice_ Assignee { get; init; } 
    
    
    #nullable disable
    
}
