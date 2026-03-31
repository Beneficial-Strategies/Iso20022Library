// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Characteristics of the goods that are certified, in the context of a commercial trade transaction.
    /// </summary>
    [KnownType(typeof(CertifiedCharacteristics1Choice.Origin))]
    [KnownType(typeof(CertifiedCharacteristics1Choice.Quality))]
    [KnownType(typeof(CertifiedCharacteristics1Choice.Analysis))]
    [KnownType(typeof(CertifiedCharacteristics1Choice.Weight))]
    [KnownType(typeof(CertifiedCharacteristics1Choice.Quantity))]
    [KnownType(typeof(CertifiedCharacteristics1Choice.HealthIndication))]
    [KnownType(typeof(CertifiedCharacteristics1Choice.PhytosanitaryIndication))]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics1Choice.Origin),
        nameof(CertifiedCharacteristics1Choice.Origin)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics1Choice.Quality),
        nameof(CertifiedCharacteristics1Choice.Quality)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics1Choice.Analysis),
        nameof(CertifiedCharacteristics1Choice.Analysis)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics1Choice.Weight),
        nameof(CertifiedCharacteristics1Choice.Weight)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics1Choice.Quantity),
        nameof(CertifiedCharacteristics1Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics1Choice.HealthIndication),
        nameof(CertifiedCharacteristics1Choice.HealthIndication)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics1Choice.PhytosanitaryIndication),
        nameof(CertifiedCharacteristics1Choice.PhytosanitaryIndication)
    )]
    [IsoId("_TnJq6Np-Ed-ak6NoX_4Aeg_524312074")]
    [DisplayName("Certified Characteristics 1 Choice")]
    public abstract record CertifiedCharacteristics1Choice_ { }
}
