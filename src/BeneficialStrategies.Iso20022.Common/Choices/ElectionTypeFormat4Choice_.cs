// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of election movement.
    /// </summary>
    [KnownType(typeof(ElectionTypeFormat4Choice.Code))]
    [KnownType(typeof(ElectionTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ElectionTypeFormat4Choice.Code),
        nameof(ElectionTypeFormat4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ElectionTypeFormat4Choice.Proprietary),
        nameof(ElectionTypeFormat4Choice.Proprietary)
    )]
    [IsoId("_c5WhK5KQEeWHWpTQn1FFVg")]
    [DisplayName("Election Type Format 4 Choice")]
    public abstract record ElectionTypeFormat4Choice_ { }
}
