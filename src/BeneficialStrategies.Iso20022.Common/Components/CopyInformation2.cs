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
[IsoId("_Q7Vk4tp-Ed-ak6NoX_4Aeg_-1918092012")]
[DisplayName("Copy Information")]
public record CopyInformation2
{
    /// <summary>
    /// Indicates whether the message is a copy.
    /// </summary>
    [IsoId("_Q7Vk49p-Ed-ak6NoX_4Aeg_-1918091969")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CopyIndicator { get; init; }

    /// <summary>
    /// Original receiver of the message, if this message is a copy.
    /// </summary>
    [IsoId("_Q7Vk5Np-Ed-ak6NoX_4Aeg_-1918091935")]
    [DisplayName("Original Receiver")]
    [IsoXmlTag("OrgnlRcvr")]
    public BICIdentification1? OriginalReceiver { get; init; }
}
