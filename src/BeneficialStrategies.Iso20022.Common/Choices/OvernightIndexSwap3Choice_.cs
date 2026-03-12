// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the overnight index swaps segment transaction details.
    /// </summary>
    [KnownType(typeof(OvernightIndexSwap3Choice.DataSetAction))]
    [KnownType(typeof(OvernightIndexSwap3Choice.Transaction))]
    [JsonDerivedType(typeof(OvernightIndexSwap3Choice.DataSetAction),nameof(OvernightIndexSwap3Choice.DataSetAction))]
    [JsonDerivedType(typeof(OvernightIndexSwap3Choice.Transaction),nameof(OvernightIndexSwap3Choice.Transaction))]
    [IsoId("_ypcOkaicEeWHO_l3hf2rlA")]
    [DisplayName("Overnight Index Swap 3 Choice")]
    public abstract partial record OvernightIndexSwap3Choice_
    {
    }
}
