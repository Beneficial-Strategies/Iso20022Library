// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// TimeFrame elements that define a period as number of days after an activity.
    /// </summary>
    [KnownType(typeof(TimeFrame4Choice.TradePlus))]
    [KnownType(typeof(TimeFrame4Choice.RenunciationPlus))]
    [JsonDerivedType(typeof(TimeFrame4Choice.TradePlus), nameof(TimeFrame4Choice.TradePlus))]
    [JsonDerivedType(
        typeof(TimeFrame4Choice.RenunciationPlus),
        nameof(TimeFrame4Choice.RenunciationPlus)
    )]
    [IsoId("_UAew6dp-Ed-ak6NoX_4Aeg_1996622705")]
    [DisplayName("Time Frame 4 Choice")]
    public abstract record TimeFrame4Choice_ { }
}
