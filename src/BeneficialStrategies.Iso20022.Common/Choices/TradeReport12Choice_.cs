// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Position/transaction reporting under EMIR regulation.
    /// </summary>
    [KnownType(typeof(TradeReport12Choice.Position))]
    [KnownType(typeof(TradeReport12Choice.Transaction))]
    [JsonDerivedType(typeof(TradeReport12Choice.Position),nameof(TradeReport12Choice.Position))]
    [JsonDerivedType(typeof(TradeReport12Choice.Transaction),nameof(TradeReport12Choice.Transaction))]
    [IsoId("_bPhuNxLBEeqctpBfTmLJnw")]
    [DisplayName("Trade Report 12 Choice")]
    public abstract partial record TradeReport12Choice_
    {
    }
}
