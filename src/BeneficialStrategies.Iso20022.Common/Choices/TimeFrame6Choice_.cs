// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Qualitative expression of a time frame.
    /// </summary>
    [KnownType(typeof(TimeFrame6Choice.Code))]
    [KnownType(typeof(TimeFrame6Choice.Proprietary))]
    [JsonDerivedType(typeof(TimeFrame6Choice.Code), nameof(TimeFrame6Choice.Code))]
    [JsonDerivedType(typeof(TimeFrame6Choice.Proprietary), nameof(TimeFrame6Choice.Proprietary))]
    [IsoId("_yjGN0DcbEeidBoT_PugKiA")]
    [DisplayName("Time Frame 6 Choice")]
    public abstract record TimeFrame6Choice_ { }
}
