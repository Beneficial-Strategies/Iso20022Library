// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date period or blank elements.
    /// </summary>
    [KnownType(typeof(DateOrBlankQuery2Choice.Range))]
    [KnownType(typeof(DateOrBlankQuery2Choice.NotReported))]
    [JsonDerivedType(typeof(DateOrBlankQuery2Choice.Range), nameof(DateOrBlankQuery2Choice.Range))]
    [JsonDerivedType(
        typeof(DateOrBlankQuery2Choice.NotReported),
        nameof(DateOrBlankQuery2Choice.NotReported)
    )]
    [IsoId("_cc1HsdGgEeaQk737TH1Fzw")]
    [DisplayName("Date Or Blank Query 2 Choice")]
    public abstract record DateOrBlankQuery2Choice_ { }
}
