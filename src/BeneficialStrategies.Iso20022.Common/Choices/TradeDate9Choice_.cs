// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate9Choice.Date))]
    [KnownType(typeof(TradeDate9Choice.DateCode))]
    [JsonDerivedType(typeof(TradeDate9Choice.Date),nameof(TradeDate9Choice.Date))]
    [JsonDerivedType(typeof(TradeDate9Choice.DateCode),nameof(TradeDate9Choice.DateCode))]
    [IsoId("_qImeCc3yEee5nJBZsW8MFQ")]
    [DisplayName("Trade Date 9 Choice")]
    public abstract partial record TradeDate9Choice_
    {
    }
}
