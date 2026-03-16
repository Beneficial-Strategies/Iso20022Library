// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the cancelled complete reason.
    /// </summary>
    [KnownType(typeof(CancellationCompleteReason1Choice.Code))]
    [KnownType(typeof(CancellationCompleteReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationCompleteReason1Choice.Code),
        nameof(CancellationCompleteReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationCompleteReason1Choice.Proprietary),
        nameof(CancellationCompleteReason1Choice.Proprietary)
    )]
    [IsoId("_doBlwCYwEeW_ZNn8gbfY7Q")]
    [DisplayName("Cancellation Complete Reason 1 Choice")]
    public abstract record CancellationCompleteReason1Choice_ { }
}
