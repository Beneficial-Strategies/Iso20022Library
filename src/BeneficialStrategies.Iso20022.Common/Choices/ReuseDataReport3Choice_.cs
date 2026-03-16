// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information on reusability of previously submitted data.
    /// </summary>
    [KnownType(typeof(ReuseDataReport3Choice.New))]
    [KnownType(typeof(ReuseDataReport3Choice.Error))]
    [KnownType(typeof(ReuseDataReport3Choice.Correction))]
    [KnownType(typeof(ReuseDataReport3Choice.CollateralReuseUpdate))]
    [JsonDerivedType(typeof(ReuseDataReport3Choice.New), nameof(ReuseDataReport3Choice.New))]
    [JsonDerivedType(typeof(ReuseDataReport3Choice.Error), nameof(ReuseDataReport3Choice.Error))]
    [JsonDerivedType(
        typeof(ReuseDataReport3Choice.Correction),
        nameof(ReuseDataReport3Choice.Correction)
    )]
    [JsonDerivedType(
        typeof(ReuseDataReport3Choice.CollateralReuseUpdate),
        nameof(ReuseDataReport3Choice.CollateralReuseUpdate)
    )]
    [IsoId("_0hwiga4bEemB_csI4yyKLA")]
    [DisplayName("Reuse Data Report 3 Choice")]
    public abstract record ReuseDataReport3Choice_ { }
}
