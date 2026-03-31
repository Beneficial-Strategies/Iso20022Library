// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between either a short, long or a proprietary identification format.
    /// </summary>
    [KnownType(typeof(IdentificationFormat4Choice.ShortIdentification))]
    [KnownType(typeof(IdentificationFormat4Choice.LongIdentification))]
    [KnownType(typeof(IdentificationFormat4Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(IdentificationFormat4Choice.ShortIdentification),
        nameof(IdentificationFormat4Choice.ShortIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationFormat4Choice.LongIdentification),
        nameof(IdentificationFormat4Choice.LongIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationFormat4Choice.ProprietaryIdentification),
        nameof(IdentificationFormat4Choice.ProprietaryIdentification)
    )]
    [IsoId("_c5VTNZKQEeWHWpTQn1FFVg")]
    [DisplayName("Identification Format 4 Choice")]
    public abstract record IdentificationFormat4Choice_ { }
}
