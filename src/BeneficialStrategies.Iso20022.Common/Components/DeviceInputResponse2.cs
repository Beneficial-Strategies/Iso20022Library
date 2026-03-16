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
[IsoId("_5FRlMRBsEeqgJK7e3n_EXA")]
[DisplayName("Device Input Response")]
public record DeviceInputResponse2
{
    /// <summary>
    /// Result of display request.
    /// </summary>
    [IsoId("_5P2dgRBsEeqgJK7e3n_EXA")]
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    public OutputResult1? OutputResult { get; init; }

    /// <summary>
    /// Result of input request.
    /// </summary>
    [IsoId("_5P2dgxBsEeqgJK7e3n_EXA")]
    [DisplayName("Input Result")]
    [IsoXmlTag("InptRslt")]
    public required InputResult2 InputResult { get; init; }
}
