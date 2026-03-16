// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date code.
    /// </summary>
    [KnownType(typeof(TradeDateCode1Choice.Code))]
    [KnownType(typeof(TradeDateCode1Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeDateCode1Choice.Code), nameof(TradeDateCode1Choice.Code))]
    [JsonDerivedType(
        typeof(TradeDateCode1Choice.Proprietary),
        nameof(TradeDateCode1Choice.Proprietary)
    )]
    [IsoId("_QvRe1tp-Ed-ak6NoX_4Aeg_1239659216")]
    [DisplayName("Trade Date Code 1 Choice")]
    public abstract record TradeDateCode1Choice_ { }
}
