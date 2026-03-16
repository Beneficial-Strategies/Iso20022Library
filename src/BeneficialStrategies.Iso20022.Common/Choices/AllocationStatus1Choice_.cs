// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [KnownType(typeof(AllocationStatus1Choice.FullyAllocated))]
    [KnownType(typeof(AllocationStatus1Choice.PartiallyAllocated))]
    [KnownType(typeof(AllocationStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AllocationStatus1Choice.FullyAllocated),
        nameof(AllocationStatus1Choice.FullyAllocated)
    )]
    [JsonDerivedType(
        typeof(AllocationStatus1Choice.PartiallyAllocated),
        nameof(AllocationStatus1Choice.PartiallyAllocated)
    )]
    [JsonDerivedType(
        typeof(AllocationStatus1Choice.Proprietary),
        nameof(AllocationStatus1Choice.Proprietary)
    )]
    [IsoId("_D01G0N_-EeiVRbNQx5-Vhg")]
    [DisplayName("Allocation Status 1 Choice")]
    public abstract record AllocationStatus1Choice_ { }
}
