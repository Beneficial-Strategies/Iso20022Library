// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the cancellation right.
    /// </summary>
    [KnownType(typeof(CancellationRight1Choice.Code))]
    [KnownType(typeof(CancellationRight1Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationRight1Choice.Code), nameof(CancellationRight1Choice.Code))]
    [JsonDerivedType(
        typeof(CancellationRight1Choice.Proprietary),
        nameof(CancellationRight1Choice.Proprietary)
    )]
    [IsoId("_z8OCgDhOEeaTjZWmPo-9OA")]
    [DisplayName("Cancellation Right 1 Choice")]
    public abstract record CancellationRight1Choice_ { }
}
