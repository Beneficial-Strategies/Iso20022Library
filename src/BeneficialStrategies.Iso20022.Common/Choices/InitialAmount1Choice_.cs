// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an initial amount or number of pre-paid instalments.
    /// </summary>
    [KnownType(typeof(InitialAmount1Choice.InitialNumberOfInstalments))]
    [KnownType(typeof(InitialAmount1Choice.Amount))]
    [JsonDerivedType(
        typeof(InitialAmount1Choice.InitialNumberOfInstalments),
        nameof(InitialAmount1Choice.InitialNumberOfInstalments)
    )]
    [JsonDerivedType(typeof(InitialAmount1Choice.Amount), nameof(InitialAmount1Choice.Amount))]
    [IsoId("_Ru9ewCDaEeWCLu74WLgP4w")]
    [DisplayName("Initial Amount 1 Choice")]
    public abstract record InitialAmount1Choice_ { }
}
