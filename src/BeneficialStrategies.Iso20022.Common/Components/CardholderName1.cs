// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Complete name of the cardholder.
/// </summary>
[IsoId("_zc_F4EaqEeeIjf8aP9KbJA")]
[DisplayName("Cardholder Name")]
public record CardholderName1
{
    /// <summary>
    /// Exact replication of the name of the cardholder as it appears on the card.
    /// </summary>
    [IsoId("_HLa_YEarEeeIjf8aP9KbJA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_P0MMAEarEeeIjf8aP9KbJA")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Middle initials present in the name of a person.
    /// </summary>
    [IsoId("_RxZfkEarEeeIjf8aP9KbJA")]
    [DisplayName("Middle Initials")]
    [IsoXmlTag("MddlInitls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MiddleInitials { get; init; }

    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_aZk2UEarEeeIjf8aP9KbJA")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LastName { get; init; }
}
