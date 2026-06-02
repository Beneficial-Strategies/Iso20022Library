// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Display Response message.
/// </summary>
[IsoId("_Epv-Mc-iEfCjWv7IQMnzMg")]
[DisplayName("Device Display Response3")]
public record DeviceDisplayResponse3
{
    /// <summary>
    /// Give result for display request.
    /// </summary>
    [IsoId("_EqgzNc-iEfCjWv7IQMnzMg")]
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    [MinLength(1)]
    public ValueList<OutputResult3> OutputResult { get; init; } = [];
}
