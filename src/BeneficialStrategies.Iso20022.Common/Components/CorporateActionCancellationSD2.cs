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
[IsoId("_1g7u9DL3EeKU9IrkkToqcw_1580284349")]
[DisplayName("Corporate Action Cancellation SD")]
public record CorporateActionCancellationSD2
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1g7u9TL3EeKU9IrkkToqcw_987664006")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Additional textual information regarding the cancelled event.
    /// </summary>
    [IsoId("_1g7u9jL3EeKU9IrkkToqcw_-1900812764")]
    [DisplayName("External Comments")]
    [IsoXmlTag("XtrnlCmnts")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    [StringLength(maximumLength: 8000, MinimumLength = 1)]
    public IsoMax8000Text? ExternalComments { get; init; }
}
