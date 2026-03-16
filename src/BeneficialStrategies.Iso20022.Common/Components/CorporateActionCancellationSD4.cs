// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding additional comments.
/// </summary>
[IsoId("_s-PqYb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Cancellation SD")]
public record CorporateActionCancellationSD4
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_tOwyob5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Additional textual information regarding the cancelled event.
    /// </summary>
    [IsoId("_tOwyo75XEeexmbB7KsjCwA")]
    [DisplayName("External Comments")]
    [IsoXmlTag("XtrnlCmnts")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    [StringLength(maximumLength: 8000, MinimumLength = 1)]
    public IsoMax8000Text? ExternalComments { get; init; }
}
