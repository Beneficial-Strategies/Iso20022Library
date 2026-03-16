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
[IsoId("_KsEK031DEeCF8NjrBemJWQ_1638245776")]
[DisplayName("Error Action")]
public record ErrorAction1
{
    /// <summary>
    /// List of error action result codes.
    /// </summary>
    [IsoId("_KsEK1H1DEeCF8NjrBemJWQ_-261559042")]
    [DisplayName("Action Result")]
    [IsoXmlTag("ActnRslt")]
    public SimpleValueList<TerminalManagementActionResult1Code> ActionResult { get; init; } = [];

    // ID for the above is _KsEK1H1DEeCF8NjrBemJWQ_-261559042

    /// <summary>
    /// Action to be processed for the related errors.
    /// </summary>
    [IsoId("_KsEK1X1DEeCF8NjrBemJWQ_-1296611635")]
    [DisplayName("Action To Process")]
    [IsoXmlTag("ActnToPrc")]
    public required TerminalManagementErrorAction1Code ActionToProcess { get; init; }
}
