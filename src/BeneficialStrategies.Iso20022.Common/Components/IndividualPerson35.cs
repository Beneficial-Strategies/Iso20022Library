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
[IsoId("_LqWk4YoWEeahcZ3Nzs1Qag")]
[DisplayName("Individual Person")]
public record IndividualPerson35
{
    /// <summary>
    /// First name of the person.
    /// </summary>
    [IsoId("_MOXQ4YoWEeahcZ3Nzs1Qag")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Second name of the person.
    /// </summary>
    [IsoId("_MOXQ44oWEeahcZ3Nzs1Qag")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Name by which the party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_MOXQ5YoWEeahcZ3Nzs1Qag")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Gender of the person.
    /// </summary>
    [IsoId("_MOXQ54oWEeahcZ3Nzs1Qag")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public Gender1Code? Gender { get; init; }

    /// <summary>
    /// Date on which the person is born.
    /// </summary>
    [IsoId("_MOXQ6YoWEeahcZ3Nzs1Qag")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }
}
