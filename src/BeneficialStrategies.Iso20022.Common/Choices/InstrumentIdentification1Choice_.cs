// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instrument identification schemes.
    /// </summary>
    [KnownType(typeof(InstrumentIdentification1Choice.ISIN))]
    [KnownType(typeof(InstrumentIdentification1Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(InstrumentIdentification1Choice.UniqueProductIdentifier))]
    [KnownType(typeof(InstrumentIdentification1Choice.OtherIdentification))]
    [JsonDerivedType(
        typeof(InstrumentIdentification1Choice.ISIN),
        nameof(InstrumentIdentification1Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(InstrumentIdentification1Choice.AlternativeInstrumentIdentification),
        nameof(InstrumentIdentification1Choice.AlternativeInstrumentIdentification)
    )]
    [JsonDerivedType(
        typeof(InstrumentIdentification1Choice.UniqueProductIdentifier),
        nameof(InstrumentIdentification1Choice.UniqueProductIdentifier)
    )]
    [JsonDerivedType(
        typeof(InstrumentIdentification1Choice.OtherIdentification),
        nameof(InstrumentIdentification1Choice.OtherIdentification)
    )]
    [IsoId("_vWHmMAbSEeqrW7Meu5r3kQ")]
    [DisplayName("Instrument Identification 1 Choice")]
    public abstract record InstrumentIdentification1Choice_ { }
}
