// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action to perform in case of error on the related action in progress.
/// </summary>
[IsoId("_DdquQdwnEeeKpa-yxjuKzQ")]
[DisplayName("Error Action")]
public record ErrorAction4
{
    /// <summary>
    /// List of error action result codes.
    /// </summary>
    [IsoId("_DnRWMdwnEeeKpa-yxjuKzQ")]
    [DisplayName("Action Result")]
    [IsoXmlTag("ActnRslt")]
    public SimpleValueList<TerminalManagementActionResult4Code> ActionResult { get; init; } = [];

    // ID for the above is _DnRWMdwnEeeKpa-yxjuKzQ

    /// <summary>
    /// Action to be processed for the related errors.
    /// </summary>
    [IsoId("_DnRWM9wnEeeKpa-yxjuKzQ")]
    [DisplayName("Action To Process")]
    [IsoXmlTag("ActnToPrc")]
    public required TerminalManagementErrorAction2Code ActionToProcess { get; init; }
}
