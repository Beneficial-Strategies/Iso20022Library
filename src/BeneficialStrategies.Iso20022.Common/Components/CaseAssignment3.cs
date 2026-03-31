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
[IsoId("_sbKvolkyEeGeoaLUQk__nA_1583838951")]
[DisplayName("Case Assignment")]
public record CaseAssignment3
{
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [IsoId("_sbUgoFkyEeGeoaLUQk__nA_-799871475")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    [IsoId("_sbUgoVkyEeGeoaLUQk__nA_-939529464")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party12Choice_ Assigner { get; init; }

    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    [IsoId("_sbdqkFkyEeGeoaLUQk__nA_1652158858")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party12Choice_ Assignee { get; init; }

    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    [IsoId("_sbnbkFkyEeGeoaLUQk__nA_1928127455")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
