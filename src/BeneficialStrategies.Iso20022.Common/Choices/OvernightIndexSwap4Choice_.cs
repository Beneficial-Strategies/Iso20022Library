// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the overnight index swaps segment transaction details.
    /// </summary>
    [KnownType(typeof(OvernightIndexSwap4Choice.DataSetAction))]
    [KnownType(typeof(OvernightIndexSwap4Choice.Transaction))]
    [JsonDerivedType(
        typeof(OvernightIndexSwap4Choice.DataSetAction),
        nameof(OvernightIndexSwap4Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(OvernightIndexSwap4Choice.Transaction),
        nameof(OvernightIndexSwap4Choice.Transaction)
    )]
    [IsoId("_GsPnd8EREea7jLfvGi1PDw")]
    [DisplayName("Overnight Index Swap 4 Choice")]
    public abstract record OvernightIndexSwap4Choice_ { }
}
