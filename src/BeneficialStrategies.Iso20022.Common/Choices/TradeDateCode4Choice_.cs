// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date code.
    /// </summary>
    [KnownType(typeof(TradeDateCode4Choice.Code))]
    [KnownType(typeof(TradeDateCode4Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeDateCode4Choice.Code),nameof(TradeDateCode4Choice.Code))]
    [JsonDerivedType(typeof(TradeDateCode4Choice.Proprietary),nameof(TradeDateCode4Choice.Proprietary))]
    [IsoId("_5TGUe5NLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Date Code 4 Choice")]
    public abstract partial record TradeDateCode4Choice_
    {
    }
}
