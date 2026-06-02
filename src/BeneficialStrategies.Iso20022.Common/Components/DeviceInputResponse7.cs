// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the input response message.
/// </summary>
[IsoId("_EmWr8c-iEfCjWv7IQMnzMg")]
[DisplayName("Device Input Response7")]
public record DeviceInputResponse7
{
    /// <summary>
    /// Result of display request.
    /// </summary>
    [IsoId("_EnX_pc-iEfCjWv7IQMnzMg")]
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    public OutputResult3? OutputResult { get; init; }

    /// <summary>
    /// Result of input request.
    /// </summary>
    [IsoId("_EnX_q8-iEfCjWv7IQMnzMg")]
    [DisplayName("Input Result")]
    [IsoXmlTag("InptRslt")]
    public required InputResult6 InputResult { get; init; }
}
