// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between either a short, long or a proprietary identification format.
    /// </summary>
    [KnownType(typeof(IdentificationFormat1Choice.ShortIdentification))]
    [KnownType(typeof(IdentificationFormat1Choice.LongIdentification))]
    [KnownType(typeof(IdentificationFormat1Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(IdentificationFormat1Choice.ShortIdentification),
        nameof(IdentificationFormat1Choice.ShortIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationFormat1Choice.LongIdentification),
        nameof(IdentificationFormat1Choice.LongIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationFormat1Choice.ProprietaryIdentification),
        nameof(IdentificationFormat1Choice.ProprietaryIdentification)
    )]
    [IsoId("_Q4EOcNp-Ed-ak6NoX_4Aeg_-298747388")]
    [DisplayName("Identification Format 1 Choice")]
    public abstract record IdentificationFormat1Choice_ { }
}
