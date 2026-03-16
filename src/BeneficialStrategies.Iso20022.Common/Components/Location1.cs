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
[IsoId("_-Gm5aHltEeG7BsjMvd1mEw_1246431564")]
[DisplayName("Location")]
public record Location1
{
    /// <summary>
    /// Country of jurisdiction.
    /// </summary>
    [IsoId("_-GwDUHltEeG7BsjMvd1mEw_-533557511")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Codified representation of the jurisdiction as published in ISO 3166-2.
    /// </summary>
    [IsoId("_-GwDUXltEeG7BsjMvd1mEw_-188715898")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    public CountrySubdivision1Choice_? CountrySubDivision { get; init; }

    /// <summary>
    /// Name of jurisdiction, for example, Frankfurt.
    /// </summary>
    [IsoId("_-GwDUnltEeG7BsjMvd1mEw_-1526701842")]
    [DisplayName("Text")]
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Text { get; init; } = [];
}
