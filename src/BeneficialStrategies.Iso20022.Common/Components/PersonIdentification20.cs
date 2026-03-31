// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Person Identification20.
/// </summary>
[IsoId("_5xkUATFMEe6e4MbXgPVc4A")]
[DisplayName("Person Identification20")]
public record PersonIdentification20
{
    /// <summary>
    /// Date And Place Of Birth.
    /// </summary>
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; }

    /// <summary>
    /// Email Address.
    /// </summary>
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<GenericPersonIdentification2> Other { get; init; } = [];
}
