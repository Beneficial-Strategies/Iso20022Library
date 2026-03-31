// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a time horizon.
    /// </summary>
    [KnownType(typeof(TimeHorizon1Choice.NumberOfYears))]
    [KnownType(typeof(TimeHorizon1Choice.TimeFrame))]
    [JsonDerivedType(
        typeof(TimeHorizon1Choice.NumberOfYears),
        nameof(TimeHorizon1Choice.NumberOfYears)
    )]
    [JsonDerivedType(typeof(TimeHorizon1Choice.TimeFrame), nameof(TimeHorizon1Choice.TimeFrame))]
    [IsoId("_t5CX0DcuEeidBoT_PugKiA")]
    [DisplayName("Time Horizon 1 Choice")]
    public abstract record TimeHorizon1Choice_ { }
}
