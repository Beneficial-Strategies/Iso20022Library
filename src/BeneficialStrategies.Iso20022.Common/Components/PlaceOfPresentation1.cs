// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location of a presentation.
/// </summary>
[IsoId("_97RzI3ltEeG7BsjMvd1mEw_-1003914803")]
[DisplayName("Place Of Presentation")]
public record PlaceOfPresentation1
{
    /// <summary>
    /// Place of the presentation.
    /// </summary>
    [IsoId("_97RzJHltEeG7BsjMvd1mEw_-404426889")]
    [DisplayName("Place")]
    [IsoXmlTag("Plc")]
    public required ExternalTypeOfParty1Code Place { get; init; }

    /// <summary>
    /// Country where a presentation is to be made.
    /// </summary>
    [IsoId("_97RzJXltEeG7BsjMvd1mEw_392011712")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }
}
