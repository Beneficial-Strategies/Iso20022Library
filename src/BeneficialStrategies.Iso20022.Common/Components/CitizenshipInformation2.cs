// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an individual person.
/// </summary>
[IsoId("_PECrwa18EeaD5sjjwBUhkQ")]
[DisplayName("Citizenship Information")]
public record CitizenshipInformation2
{
    /// <summary>
    /// Country where a person was born or is legally accepted as belonging to the country.
    /// </summary>
    [IsoId("_PbGg4a18EeaD5sjjwBUhkQ")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public required NationalityCode Nationality { get; init; }

    /// <summary>
    /// Indicates whether the person is a legal minor. This may depend on the nationality, the domicile country or the transaction in which the person is involved.
    /// </summary>
    [IsoId("_PbGg4618EeaD5sjjwBUhkQ")]
    [DisplayName("Minor Indicator")]
    [IsoXmlTag("MnrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MinorIndicator { get; init; }
}
