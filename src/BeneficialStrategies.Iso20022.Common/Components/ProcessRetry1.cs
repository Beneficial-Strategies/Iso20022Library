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
[IsoId("_K9D0N31DEeCF8NjrBemJWQ_-2058168701")]
[DisplayName("Process Retry")]
public record ProcessRetry1
{
    /// <summary>
    /// Time period to wait for a retry in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_K9M-IH1DEeCF8NjrBemJWQ_444551643")]
    [DisplayName("Delay")]
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText Delay { get; init; }

    /// <summary>
    /// Maximum number of retries.
    /// </summary>
    [IsoId("_K9M-IX1DEeCF8NjrBemJWQ_-1003849246")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; }

    /// <summary>
    /// Time of the last retry.
    /// </summary>
    [IsoId("_K9M-In1DEeCF8NjrBemJWQ_-109160754")]
    [DisplayName("Last Re Try Time")]
    [IsoXmlTag("LastReTryTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? LastReTryTime { get; init; }
}
