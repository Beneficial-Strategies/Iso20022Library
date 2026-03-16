// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates that the claim for non receipt is effectively a missing cover.
/// </summary>
[IsoId("_T9zQWdp-Ed-ak6NoX_4Aeg_-539916461")]
[DisplayName("Missing Cover")]
public record MissingCover
{
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    [IsoId("_T9zQWtp-Ed-ak6NoX_4Aeg_1790222510")]
    [DisplayName("Missing Cover Indication")]
    [IsoXmlTag("MssngCoverIndctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MissingCoverIndication { get; init; }
}
