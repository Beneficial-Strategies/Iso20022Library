// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the civil status.
    /// </summary>
    [KnownType(typeof(CivilStatus1Choice.Code))]
    [KnownType(typeof(CivilStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(CivilStatus1Choice.Code), nameof(CivilStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(CivilStatus1Choice.Proprietary),
        nameof(CivilStatus1Choice.Proprietary)
    )]
    [IsoId("_zKj4MCCgEeWJd9HF2tO7BA")]
    [DisplayName("Civil Status 1 Choice")]
    public abstract record CivilStatus1Choice_ { }
}
