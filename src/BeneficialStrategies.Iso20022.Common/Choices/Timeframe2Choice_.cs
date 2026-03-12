// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between TimeFrame elements that define a period as number of days after an activity.
    /// </summary>
    [KnownType(typeof(Timeframe2Choice.TradePlus))]
    [KnownType(typeof(Timeframe2Choice.RenunciationPlus))]
    [KnownType(typeof(Timeframe2Choice.Prepayment))]
    [JsonDerivedType(typeof(Timeframe2Choice.TradePlus),nameof(Timeframe2Choice.TradePlus))]
    [JsonDerivedType(typeof(Timeframe2Choice.RenunciationPlus),nameof(Timeframe2Choice.RenunciationPlus))]
    [JsonDerivedType(typeof(Timeframe2Choice.Prepayment),nameof(Timeframe2Choice.Prepayment))]
    [IsoId("_UAoh69p-Ed-ak6NoX_4Aeg_-63604421")]
    [DisplayName("Timeframe 2 Choice")]
    public abstract partial record Timeframe2Choice_
    {
    }
}
