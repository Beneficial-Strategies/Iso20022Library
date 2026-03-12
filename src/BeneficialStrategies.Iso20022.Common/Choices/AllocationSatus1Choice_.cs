// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allocation status reason.
    /// </summary>
    [KnownType(typeof(AllocationSatus1Choice.Code))]
    [KnownType(typeof(AllocationSatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(AllocationSatus1Choice.Code),nameof(AllocationSatus1Choice.Code))]
    [JsonDerivedType(typeof(AllocationSatus1Choice.Proprietary),nameof(AllocationSatus1Choice.Proprietary))]
    [IsoId("_UXuzStp-Ed-ak6NoX_4Aeg_-2141684752")]
    [DisplayName("Allocation Satus 1 Choice")]
    public abstract partial record AllocationSatus1Choice_
    {
    }
}
