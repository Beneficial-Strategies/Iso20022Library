// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading capacity of the party.
    /// </summary>
    [KnownType(typeof(TradeOriginator1Choice.Code))]
    [KnownType(typeof(TradeOriginator1Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeOriginator1Choice.Code),nameof(TradeOriginator1Choice.Code))]
    [JsonDerivedType(typeof(TradeOriginator1Choice.Proprietary),nameof(TradeOriginator1Choice.Proprietary))]
    [IsoId("_QsvINNp-Ed-ak6NoX_4Aeg_-1081021298")]
    [DisplayName("Trade Originator 1 Choice")]
    public abstract partial record TradeOriginator1Choice_
    {
    }
}
