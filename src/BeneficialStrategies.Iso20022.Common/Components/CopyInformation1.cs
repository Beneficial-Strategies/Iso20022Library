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
[IsoId("_RE37Ydp-Ed-ak6NoX_4Aeg_-877911728")]
[DisplayName("Copy Information")]
public record CopyInformation1
{
    /// <summary>
    /// Indicates whether the message is a copy.
    /// </summary>
    [IsoId("_RE37Ytp-Ed-ak6NoX_4Aeg_-452168468")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CopyIndicator { get; init; }

    /// <summary>
    /// Original receiver of the message, if this message is a copy.
    /// </summary>
    [IsoId("_RE37Y9p-Ed-ak6NoX_4Aeg_-504809982")]
    [DisplayName("Original Receiver")]
    [IsoXmlTag("OrgnlRcvr")]
    public required BICIdentification1 OriginalReceiver { get; init; }
}
