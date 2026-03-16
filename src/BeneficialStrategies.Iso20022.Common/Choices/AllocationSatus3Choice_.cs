// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allocation status reason.
    /// </summary>
    [KnownType(typeof(AllocationSatus3Choice.Code))]
    [KnownType(typeof(AllocationSatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(AllocationSatus3Choice.Code), nameof(AllocationSatus3Choice.Code))]
    [JsonDerivedType(
        typeof(AllocationSatus3Choice.Proprietary),
        nameof(AllocationSatus3Choice.Proprietary)
    )]
    [IsoId("_Dg5V4TqqEeWyoP0PbocV1Q")]
    [DisplayName("Allocation Satus 3 Choice")]
    public abstract record AllocationSatus3Choice_ { }
}
