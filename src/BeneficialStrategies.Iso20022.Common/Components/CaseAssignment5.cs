// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents the assignment of a case to a party.
/// </summary>
[IsoId("_BzPdIW49EeiU9cctagi5ow")]
[DisplayName("Case Assignment")]
public partial record CaseAssignment5
{
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [IsoId("_B8VHsW49EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    [IsoId("_B8VHs249EeiU9cctagi5ow")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party40Choice_ Assigner { get; init; } 
    
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    [IsoId("_B8VHtW49EeiU9cctagi5ow")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party40Choice_ Assignee { get; init; } 
    
    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    [IsoId("_B8VHt249EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
