// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Data61Choice.
    /// </summary>
    [KnownType(typeof(TradeData61Choice.DataSetAction))]
    [KnownType(typeof(TradeData61Choice.Report))]
    [JsonDerivedType(typeof(TradeData61Choice.DataSetAction),nameof(TradeData61Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData61Choice.Report),nameof(TradeData61Choice.Report))]
    [IsoId("_TEzQccEkEe66laxnCpxfpw")]
    [DisplayName("Trade Data61Choice")]
    public abstract partial record TradeData61Choice_
    {
    }
}
