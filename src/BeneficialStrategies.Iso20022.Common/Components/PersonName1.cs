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
[IsoId("_KXORlDtrEemIf7eyjCwinw")]
[DisplayName("Person Name")]
public record PersonName1
{
    /// <summary>
    /// First name(s) by which a natural person is known.
    /// </summary>
    [IsoId("_g-fZYDtrEemIf7eyjCwinw")]
    [DisplayName("First Name")]
    [IsoXmlTag("FrstNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FirstName { get; init; }

    /// <summary>
    /// Name (s) by which a natural person is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_KXORlTtrEemIf7eyjCwinw")]
    [DisplayName("Surname")]
    [IsoXmlTag("Srnm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Surname { get; init; }

    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_ZbY4oE_VEem6LsRj385o5w")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress26? Address { get; init; }
}
