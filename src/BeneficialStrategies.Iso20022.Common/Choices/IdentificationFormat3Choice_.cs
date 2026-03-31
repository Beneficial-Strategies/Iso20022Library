// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between either a short, long or a proprietary identification format.
    /// </summary>
    [KnownType(typeof(IdentificationFormat3Choice.ShortIdentification))]
    [KnownType(typeof(IdentificationFormat3Choice.LongIdentification))]
    [KnownType(typeof(IdentificationFormat3Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(IdentificationFormat3Choice.ShortIdentification),
        nameof(IdentificationFormat3Choice.ShortIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationFormat3Choice.LongIdentification),
        nameof(IdentificationFormat3Choice.LongIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationFormat3Choice.ProprietaryIdentification),
        nameof(IdentificationFormat3Choice.ProprietaryIdentification)
    )]
    [IsoId("_qZTHkUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Identification Format 3 Choice")]
    public abstract record IdentificationFormat3Choice_ { }
}
