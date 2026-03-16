// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Report34Choice.
    /// </summary>
    [KnownType(typeof(TradeReport34Choice.Correction))]
    [KnownType(typeof(TradeReport34Choice.Error))]
    [KnownType(typeof(TradeReport34Choice.MarginUpdate))]
    [KnownType(typeof(TradeReport34Choice.New))]
    [JsonDerivedType(typeof(TradeReport34Choice.Correction),nameof(TradeReport34Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport34Choice.Error),nameof(TradeReport34Choice.Error))]
    [JsonDerivedType(typeof(TradeReport34Choice.MarginUpdate),nameof(TradeReport34Choice.MarginUpdate))]
    [JsonDerivedType(typeof(TradeReport34Choice.New),nameof(TradeReport34Choice.New))]
    [IsoId("_TGHfEcEkEe66laxnCpxfpw")]
    [DisplayName("Trade Report34Choice")]
    public abstract partial record TradeReport34Choice_
    {
    }
}
