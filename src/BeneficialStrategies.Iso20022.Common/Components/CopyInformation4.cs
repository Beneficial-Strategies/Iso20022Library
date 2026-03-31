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
[IsoId("_7VUJ8degEeSA_uUacqhl1Q")]
[DisplayName("Copy Information")]
public record CopyInformation4
{
    /// <summary>
    /// Indicates whether the message is a copy.
    /// </summary>
    [IsoId("_7tkR49egEeSA_uUacqhl1Q")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CopyIndicator { get; init; }

    /// <summary>
    /// Original receiver of the message, if this message is a copy.
    /// </summary>
    [IsoId("_7tkR5degEeSA_uUacqhl1Q")]
    [DisplayName("Original Receiver")]
    [IsoXmlTag("OrgnlRcvr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? OriginalReceiver { get; init; }
}
