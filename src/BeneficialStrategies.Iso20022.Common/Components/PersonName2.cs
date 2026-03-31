// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a person via its first name and surname.
/// </summary>
[IsoId("_W138xVB2Eem6LsRj385o5w")]
[DisplayName("Person Name")]
public record PersonName2
{
    /// <summary>
    /// First name(s) by which a natural person is known.
    /// </summary>
    [IsoId("_W138x1B2Eem6LsRj385o5w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_W138xlB2Eem6LsRj385o5w")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress26? Address { get; init; }
}
