// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Characteristics of the goods that are certified, in the context of a commercial trade transaction.
    /// </summary>
    [KnownType(typeof(CertifiedCharacteristics2Choice.Origin))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Quality))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Analysis))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Weight))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Quantity))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.HealthIndication))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.PhytosanitaryIndication))]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics2Choice.Origin),
        nameof(CertifiedCharacteristics2Choice.Origin)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics2Choice.Quality),
        nameof(CertifiedCharacteristics2Choice.Quality)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics2Choice.Analysis),
        nameof(CertifiedCharacteristics2Choice.Analysis)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics2Choice.Weight),
        nameof(CertifiedCharacteristics2Choice.Weight)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics2Choice.Quantity),
        nameof(CertifiedCharacteristics2Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics2Choice.HealthIndication),
        nameof(CertifiedCharacteristics2Choice.HealthIndication)
    )]
    [JsonDerivedType(
        typeof(CertifiedCharacteristics2Choice.PhytosanitaryIndication),
        nameof(CertifiedCharacteristics2Choice.PhytosanitaryIndication)
    )]
    [IsoId("_2nTCgTANEeOKib24wnHaFg")]
    [DisplayName("Certified Characteristics 2 Choice")]
    public abstract record CertifiedCharacteristics2Choice_ { }
}
