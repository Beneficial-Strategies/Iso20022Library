// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting5Choice.Code))]
    [KnownType(typeof(Reporting5Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting5Choice.Code), nameof(Reporting5Choice.Code))]
    [JsonDerivedType(typeof(Reporting5Choice.Proprietary), nameof(Reporting5Choice.Proprietary))]
    [IsoId("_Ad4rVtokEeC60axPepSq7g_97142713")]
    [DisplayName("Reporting 5 Choice")]
    public abstract record Reporting5Choice_ { }
}
