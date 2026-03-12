// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the foreign exchange swaps segment transaction details.
    /// </summary>
    [KnownType(typeof(ForeignExchangeSwap2Choice.DataSetAction))]
    [KnownType(typeof(ForeignExchangeSwap2Choice.Transaction))]
    [JsonDerivedType(typeof(ForeignExchangeSwap2Choice.DataSetAction),nameof(ForeignExchangeSwap2Choice.DataSetAction))]
    [JsonDerivedType(typeof(ForeignExchangeSwap2Choice.Transaction),nameof(ForeignExchangeSwap2Choice.Transaction))]
    [IsoId("_qc3MAZ2WEeW_58xcYxhewg")]
    [DisplayName("Foreign Exchange Swap 2 Choice")]
    public abstract partial record ForeignExchangeSwap2Choice_
    {
    }
}
