// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the foreign exchange swaps segment transaction details.
    /// </summary>
    [KnownType(typeof(ForeignExchangeSwap3Choice.DataSetAction))]
    [KnownType(typeof(ForeignExchangeSwap3Choice.Transaction))]
    [JsonDerivedType(
        typeof(ForeignExchangeSwap3Choice.DataSetAction),
        nameof(ForeignExchangeSwap3Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(ForeignExchangeSwap3Choice.Transaction),
        nameof(ForeignExchangeSwap3Choice.Transaction)
    )]
    [IsoId("_E2DFYcESEea7jLfvGi1PDw")]
    [DisplayName("Foreign Exchange Swap 3 Choice")]
    public abstract record ForeignExchangeSwap3Choice_ { }
}
