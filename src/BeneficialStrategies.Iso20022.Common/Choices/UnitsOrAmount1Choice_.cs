// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or number of units.
    /// </summary>
    [KnownType(typeof(UnitsOrAmount1Choice.Amount))]
    [KnownType(typeof(UnitsOrAmount1Choice.Unit))]
    [JsonDerivedType(typeof(UnitsOrAmount1Choice.Amount), nameof(UnitsOrAmount1Choice.Amount))]
    [JsonDerivedType(typeof(UnitsOrAmount1Choice.Unit), nameof(UnitsOrAmount1Choice.Unit))]
    [IsoId("_Jb_o8xQcEeKebsB9eKJSkA")]
    [DisplayName("Units Or Amount 1 Choice")]
    public abstract record UnitsOrAmount1Choice_ { }
}
