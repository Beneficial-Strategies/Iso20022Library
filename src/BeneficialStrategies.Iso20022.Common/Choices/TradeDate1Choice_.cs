// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate1Choice.Date))]
    [KnownType(typeof(TradeDate1Choice.DateCode))]
    [JsonDerivedType(typeof(TradeDate1Choice.Date), nameof(TradeDate1Choice.Date))]
    [JsonDerivedType(typeof(TradeDate1Choice.DateCode), nameof(TradeDate1Choice.DateCode))]
    [IsoId("_Qvaowdp-Ed-ak6NoX_4Aeg_-681720433")]
    [DisplayName("Trade Date 1 Choice")]
    public abstract record TradeDate1Choice_ { }
}
