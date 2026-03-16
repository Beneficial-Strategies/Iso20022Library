// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information provided when the message is a copy of a previous message.
/// </summary>
[IsoId("_WIPHktp-Ed-ak6NoX_4Aeg_849600101")]
[DisplayName("Copy Information")]
public record CopyInformation3
{
    /// <summary>
    /// Indicates whether the message is a copy.
    /// </summary>
    [IsoId("_WIPHk9p-Ed-ak6NoX_4Aeg_849600111")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CopyIndicator { get; init; }
}
