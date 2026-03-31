// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents the assignment of a case to a party.
/// </summary>
[IsoId("_HIRcwbTgEeef0oKPLRNatg")]
[DisplayName("Case Assignment")]
public record CaseAssignment4
{
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [IsoId("_HQTXYbTgEeef0oKPLRNatg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    [IsoId("_HQTXY7TgEeef0oKPLRNatg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party35Choice_ Assigner { get; init; }

    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    [IsoId("_HQTXZbTgEeef0oKPLRNatg")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party35Choice_ Assignee { get; init; }

    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    [IsoId("_HQTXZ7TgEeef0oKPLRNatg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
