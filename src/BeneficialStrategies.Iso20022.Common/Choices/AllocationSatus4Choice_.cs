// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allocation status reason.
    /// </summary>
    [KnownType(typeof(AllocationSatus4Choice.Code))]
    [KnownType(typeof(AllocationSatus4Choice.Proprietary))]
    [JsonDerivedType(typeof(AllocationSatus4Choice.Code), nameof(AllocationSatus4Choice.Code))]
    [JsonDerivedType(
        typeof(AllocationSatus4Choice.Proprietary),
        nameof(AllocationSatus4Choice.Proprietary)
    )]
    [IsoId("_8QboZZNLEeWGlc8L7oPDIg")]
    [DisplayName("Allocation Satus 4 Choice")]
    public abstract record AllocationSatus4Choice_ { }
}
