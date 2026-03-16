// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the investigation results.
    /// </summary>
    [KnownType(typeof(InvestigationResult1Choice.Result))]
    [KnownType(typeof(InvestigationResult1Choice.InvestigationStatus))]
    [JsonDerivedType(
        typeof(InvestigationResult1Choice.Result),
        nameof(InvestigationResult1Choice.Result)
    )]
    [JsonDerivedType(
        typeof(InvestigationResult1Choice.InvestigationStatus),
        nameof(InvestigationResult1Choice.InvestigationStatus)
    )]
    [IsoId("_TRkjcGgkEeGHuf0_3c6vdw")]
    [DisplayName("Investigation Result 1 Choice")]
    public abstract record InvestigationResult1Choice_ { }
}
