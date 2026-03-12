// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instrument identification schemes.
    /// </summary>
    [KnownType(typeof(InstrumentIdentification6Choice.ISIN))]
    [KnownType(typeof(InstrumentIdentification6Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(InstrumentIdentification6Choice.UniqueProductIdentifier))]
    [KnownType(typeof(InstrumentIdentification6Choice.OtherIdentification))]
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.ISIN),nameof(InstrumentIdentification6Choice.ISIN))]
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.AlternativeInstrumentIdentification),nameof(InstrumentIdentification6Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.UniqueProductIdentifier),nameof(InstrumentIdentification6Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.OtherIdentification),nameof(InstrumentIdentification6Choice.OtherIdentification))]
    [IsoId("_xynSQSyGEe2xAdY9t5fB3g")]
    [DisplayName("Instrument Identification 6 Choice")]
    public abstract partial record InstrumentIdentification6Choice_
    {
    }
}
