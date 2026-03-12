// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason20Choice.Code))]
    [KnownType(typeof(CancellationReason20Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason20Choice.Code),nameof(CancellationReason20Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason20Choice.Proprietary),nameof(CancellationReason20Choice.Proprietary))]
    [IsoId("_Wk3goTqrEeWyoP0PbocV1Q")]
    [DisplayName("Cancellation Reason 20 Choice")]
    public abstract partial record CancellationReason20Choice_
    {
    }
}
