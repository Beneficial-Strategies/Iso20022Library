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
[IsoId("_FeJ-kR3ZEeKKrOIoqWglDw")]
[DisplayName("Error Action")]
public record ErrorAction2
{
    /// <summary>
    /// List of error action result codes.
    /// </summary>
    [IsoId("_FqWngR3ZEeKKrOIoqWglDw")]
    [DisplayName("Action Result")]
    [IsoXmlTag("ActnRslt")]
    public SimpleValueList<TerminalManagementActionResult1Code> ActionResult { get; init; } = [];

    // ID for the above is _FqWngR3ZEeKKrOIoqWglDw

    /// <summary>
    /// Action to be processed for the related errors.
    /// </summary>
    [IsoId("_FqWnhR3ZEeKKrOIoqWglDw")]
    [DisplayName("Action To Process")]
    [IsoXmlTag("ActnToPrc")]
    public required TerminalManagementErrorAction2Code ActionToProcess { get; init; }
}
