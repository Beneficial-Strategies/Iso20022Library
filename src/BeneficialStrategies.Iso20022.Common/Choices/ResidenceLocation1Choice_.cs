// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of location of a residence of a party.
    /// </summary>
    [KnownType(typeof(ResidenceLocation1Choice.Country))]
    [KnownType(typeof(ResidenceLocation1Choice.Area))]
    [JsonDerivedType(
        typeof(ResidenceLocation1Choice.Country),
        nameof(ResidenceLocation1Choice.Country)
    )]
    [JsonDerivedType(typeof(ResidenceLocation1Choice.Area), nameof(ResidenceLocation1Choice.Area))]
    [IsoId("_6QsqkpqlEeGSON8vddiWzQ_1947299018")]
    [DisplayName("Residence Location 1 Choice")]
    public abstract record ResidenceLocation1Choice_ { }
}
