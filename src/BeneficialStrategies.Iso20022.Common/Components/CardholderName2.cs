// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Name of the cardholder in the local language.
/// </summary>
[IsoId("_UcqZAcWwEeuhguwJmlgagQ")]
[DisplayName("Cardholder Name")]
public record CardholderName2
{
    /// <summary>
    /// Local language equivalent of the name of the cardholder.
    /// </summary>
    [IsoId("_UhX54cWwEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Local language equivalent of the first name of the cardholder.
    /// </summary>
    [IsoId("_UhX548WwEeuhguwJmlgagQ")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? GivenName { get; init; }

    /// <summary>
    /// Local language equivalent of the middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_UhX55cWwEeuhguwJmlgagQ")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MiddleName { get; init; }

    /// <summary>
    /// Local language equivalent of the last name or surname of the cardholder.
    /// </summary>
    [IsoId("_UhX558WwEeuhguwJmlgagQ")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? LastName { get; init; }
}
