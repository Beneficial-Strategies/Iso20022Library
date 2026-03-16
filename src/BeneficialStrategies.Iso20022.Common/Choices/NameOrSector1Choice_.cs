// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the reported party through the name or the sector.
    /// </summary>
    [KnownType(typeof(NameOrSector1Choice.Name))]
    [KnownType(typeof(NameOrSector1Choice.Sector))]
    [JsonDerivedType(typeof(NameOrSector1Choice.Name), nameof(NameOrSector1Choice.Name))]
    [JsonDerivedType(typeof(NameOrSector1Choice.Sector), nameof(NameOrSector1Choice.Sector))]
    [IsoId("_6MuWYYInEeWA9fc11zJf1Q")]
    [DisplayName("Name Or Sector 1 Choice")]
    public abstract record NameOrSector1Choice_ { }
}
