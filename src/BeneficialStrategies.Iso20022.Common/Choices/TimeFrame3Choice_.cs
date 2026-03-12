// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between TimeFrame elements that define a period as number of days before an activity.
    /// </summary>
    [KnownType(typeof(TimeFrame3Choice.TradeMinus))]
    [KnownType(typeof(TimeFrame3Choice.RenunciationMinus))]
    [JsonDerivedType(typeof(TimeFrame3Choice.TradeMinus),nameof(TimeFrame3Choice.TradeMinus))]
    [JsonDerivedType(typeof(TimeFrame3Choice.RenunciationMinus),nameof(TimeFrame3Choice.RenunciationMinus))]
    [IsoId("_UAyS4tp-Ed-ak6NoX_4Aeg_606871558")]
    [DisplayName("Time Frame 3 Choice")]
    public abstract partial record TimeFrame3Choice_
    {
    }
}
