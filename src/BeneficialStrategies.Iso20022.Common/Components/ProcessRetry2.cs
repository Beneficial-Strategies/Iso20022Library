// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Definition of retry process if activation of an action fails.
/// </summary>
[IsoId("_woZ64R3cEeKWfegf-2AeBQ")]
[DisplayName("Process Retry")]
public record ProcessRetry2
{
    /// <summary>
    /// Time period to wait for a retry in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_w0wU0R3cEeKWfegf-2AeBQ")]
    [DisplayName("Delay")]
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText Delay { get; init; }

    /// <summary>
    /// Maximum number of retries.
    /// </summary>
    [IsoId("_w0wU1R3cEeKWfegf-2AeBQ")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; }
}
