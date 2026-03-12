// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between TimeFrame elements that define a period as number of days after an activity.
    /// </summary>
    [KnownType(typeof(TimeFrame5Choice.TradePlus))]
    [KnownType(typeof(TimeFrame5Choice.Prepayment))]
    [JsonDerivedType(typeof(TimeFrame5Choice.TradePlus),nameof(TimeFrame5Choice.TradePlus))]
    [JsonDerivedType(typeof(TimeFrame5Choice.Prepayment),nameof(TimeFrame5Choice.Prepayment))]
    [IsoId("_UAew7Np-Ed-ak6NoX_4Aeg_1119548920")]
    [DisplayName("Time Frame 5 Choice")]
    public abstract partial record TimeFrame5Choice_
    {
    }
}
