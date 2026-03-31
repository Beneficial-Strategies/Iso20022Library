// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason9Choice.Code))]
    [KnownType(typeof(CancelledReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason9Choice.Code), nameof(CancelledReason9Choice.Code))]
    [JsonDerivedType(
        typeof(CancelledReason9Choice.Proprietary),
        nameof(CancelledReason9Choice.Proprietary)
    )]
    [IsoId("_9HM5U0GWEeWqy4niLuXETA")]
    [DisplayName("Cancelled Reason 9 Choice")]
    public abstract record CancelledReason9Choice_ { }
}
