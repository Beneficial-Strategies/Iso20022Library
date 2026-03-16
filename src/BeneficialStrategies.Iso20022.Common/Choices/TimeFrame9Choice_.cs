// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the time frame.
    /// </summary>
    [KnownType(typeof(TimeFrame9Choice.Code))]
    [KnownType(typeof(TimeFrame9Choice.Proprietary))]
    [JsonDerivedType(typeof(TimeFrame9Choice.Code), nameof(TimeFrame9Choice.Code))]
    [JsonDerivedType(typeof(TimeFrame9Choice.Proprietary), nameof(TimeFrame9Choice.Proprietary))]
    [IsoId("_UgWqwcztEeq1WLK5fVzKiQ")]
    [DisplayName("Time Frame 9 Choice")]
    public abstract record TimeFrame9Choice_ { }
}
