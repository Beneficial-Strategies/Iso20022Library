// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of customer identification requested for a person.
/// </summary>
[IsoId("_zudpQeH5Eeqbls7Gk4-ckA")]
[DisplayName("Person Type")]
public record PersonType2
{
    /// <summary>
    /// Date and place of birth of a person is requested.
    /// Usage: When absent (default value), the identification is not requested.
    /// </summary>
    [IsoId("_zv3-geH5Eeqbls7Gk4-ckA")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? DateAndPlaceOfBirth { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail) is requested.
    /// Usage: When absent (default value), the identification is not requested.
    /// </summary>
    [IsoId("_1-ZrkeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EmailAddress { get; init; }

    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme is requested.
    /// </summary>
    [IsoId("_zv3-g-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<GenericPersonType1> Other { get; init; } = [];
}
