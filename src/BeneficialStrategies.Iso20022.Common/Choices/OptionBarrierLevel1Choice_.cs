// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Option Barrier Level1Choice.
    /// </summary>
    [KnownType(typeof(OptionBarrierLevel1Choice.Multiple))]
    [KnownType(typeof(OptionBarrierLevel1Choice.Single))]
    [JsonDerivedType(
        typeof(OptionBarrierLevel1Choice.Multiple),
        nameof(OptionBarrierLevel1Choice.Multiple)
    )]
    [JsonDerivedType(
        typeof(OptionBarrierLevel1Choice.Single),
        nameof(OptionBarrierLevel1Choice.Single)
    )]
    [IsoId("_pVNJcNyZEe6BHYBNhkieQQ")]
    [DisplayName("Option Barrier Level1Choice")]
    public abstract record OptionBarrierLevel1Choice_ { }
}
