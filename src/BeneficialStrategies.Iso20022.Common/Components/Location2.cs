// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location information.
/// </summary>
[IsoId("_ZTussRUwEeOCqpkCrPgk4g")]
[DisplayName("Location")]
public record Location2
{
    /// <summary>
    /// Country of jurisdiction.
    /// </summary>
    [IsoId("_ZrbbARUwEeOCqpkCrPgk4g")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Codified representation of the jurisdiction as published in ISO 3166-2.
    /// </summary>
    [IsoId("_ZrbbAxUwEeOCqpkCrPgk4g")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    public CountrySubdivision1Choice_? CountrySubDivision { get; init; }

    /// <summary>
    /// Name of jurisdiction, for example, Frankfurt.
    /// </summary>
    [IsoId("_ZrbbBRUwEeOCqpkCrPgk4g")]
    [DisplayName("Text")]
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Text { get; init; }
}
