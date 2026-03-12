// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeReport10Choice.New))]
    [KnownType(typeof(TradeReport10Choice.Modification))]
    [KnownType(typeof(TradeReport10Choice.Error))]
    [KnownType(typeof(TradeReport10Choice.EarlyTermination))]
    [KnownType(typeof(TradeReport10Choice.PositionComponent))]
    [KnownType(typeof(TradeReport10Choice.CollateralUpdate))]
    [KnownType(typeof(TradeReport10Choice.Correction))]
    [KnownType(typeof(TradeReport10Choice.ValuationUpdate))]
    [JsonDerivedType(typeof(TradeReport10Choice.New),nameof(TradeReport10Choice.New))]
    [JsonDerivedType(typeof(TradeReport10Choice.Modification),nameof(TradeReport10Choice.Modification))]
    [JsonDerivedType(typeof(TradeReport10Choice.Error),nameof(TradeReport10Choice.Error))]
    [JsonDerivedType(typeof(TradeReport10Choice.EarlyTermination),nameof(TradeReport10Choice.EarlyTermination))]
    [JsonDerivedType(typeof(TradeReport10Choice.PositionComponent),nameof(TradeReport10Choice.PositionComponent))]
    [JsonDerivedType(typeof(TradeReport10Choice.CollateralUpdate),nameof(TradeReport10Choice.CollateralUpdate))]
    [JsonDerivedType(typeof(TradeReport10Choice.Correction),nameof(TradeReport10Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport10Choice.ValuationUpdate),nameof(TradeReport10Choice.ValuationUpdate))]
    [IsoId("_34vr9f_qEemm3skPVSMJQg")]
    [DisplayName("Trade Report 10 Choice")]
    public abstract partial record TradeReport10Choice_
    {
    }
}
