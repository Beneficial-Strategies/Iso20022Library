// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to represent the assignment of a case to a party.
/// </summary>
[IsoId("_T9Nac9p-Ed-ak6NoX_4Aeg_-1609381277")]
[DisplayName("Case Assignment")]
public partial record CaseAssignment2
{
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [IsoId("_T9NadNp-Ed-ak6NoX_4Aeg_-1609381275")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    [IsoId("_T9Naddp-Ed-ak6NoX_4Aeg_-1250334122")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party7Choice_ Assigner { get; init; } 
    
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    [IsoId("_T9Nadtp-Ed-ak6NoX_4Aeg_-1280811878")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party7Choice_ Assignee { get; init; } 
    
    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    [IsoId("_T9Nad9p-Ed-ak6NoX_4Aeg_-1609381155")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
