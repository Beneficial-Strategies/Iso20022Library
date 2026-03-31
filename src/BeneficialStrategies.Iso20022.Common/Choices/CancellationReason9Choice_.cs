// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason9Choice.Code))]
    [KnownType(typeof(CancellationReason9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason9Choice.Code),
        nameof(CancellationReason9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason9Choice.Proprietary),
        nameof(CancellationReason9Choice.Proprietary)
    )]
    [IsoId("_QhPswT9qEeCY7potQsO_IA")]
    [DisplayName("Cancellation Reason 9 Choice")]
    public abstract record CancellationReason9Choice_ { }
}
