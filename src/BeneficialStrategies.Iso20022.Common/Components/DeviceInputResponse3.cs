// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input Response message.
/// </summary>
[IsoId("_INRIES8PEeu125Ip9zFcsQ")]
[DisplayName("Device Input Response")]
public record DeviceInputResponse3
{
    /// <summary>
    /// Result of display request.
    /// </summary>
    [IsoId("_IYtjES8PEeu125Ip9zFcsQ")]
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    public OutputResult2? OutputResult { get; init; }

    /// <summary>
    /// Result of input request.
    /// </summary>
    [IsoId("_IYtjEy8PEeu125Ip9zFcsQ")]
    [DisplayName("Input Result")]
    [IsoXmlTag("InptRslt")]
    public required InputResult3 InputResult { get; init; }
}
