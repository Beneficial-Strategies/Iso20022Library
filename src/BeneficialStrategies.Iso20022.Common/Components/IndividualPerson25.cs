// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_8aBMx1tgEeSwKe7KuKvXhg")]
[DisplayName("Individual Person")]
public record IndividualPerson25
{
    /// <summary>
    /// Name received at birth, for example, maiden name.
    /// </summary>
    [IsoId("_83LC01tgEeSwKe7KuKvXhg")]
    [DisplayName("Birth Name")]
    [IsoXmlTag("BirthNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BirthName { get; init; }

    /// <summary>
    /// First name of the person.
    /// </summary>
    [IsoId("_83LC1VtgEeSwKe7KuKvXhg")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the person, for example, passport.
    /// </summary>
    [IsoId("_83LC11tgEeSwKe7KuKvXhg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification6? Identification { get; init; }

    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_83LC2VtgEeSwKe7KuKvXhg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LongPostalAddress2Choice_? Address { get; init; }

    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    [IsoId("_83LC21tgEeSwKe7KuKvXhg")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification40Choice_? EmployingParty { get; init; }
}
