// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instrument identification schemes.
    /// </summary>
    [KnownType(typeof(InstrumentIdentification6Choice.ISIN))]
    [KnownType(typeof(InstrumentIdentification6Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(InstrumentIdentification6Choice.UniqueProductIdentifier))]
    [KnownType(typeof(InstrumentIdentification6Choice.OtherIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.ISIN),nameof(InstrumentIdentification6Choice.ISIN))]
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.AlternativeInstrumentIdentification),nameof(InstrumentIdentification6Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.UniqueProductIdentifier),nameof(InstrumentIdentification6Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(InstrumentIdentification6Choice.OtherIdentification),nameof(InstrumentIdentification6Choice.OtherIdentification))]
    #endif
    [IsoId("_xynSQSyGEe2xAdY9t5fB3g")]
    [DisplayName("Instrument Identification 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstrumentIdentification6Choice_
    #else
    public abstract partial class InstrumentIdentification6Choice_
    #endif
    {
    }
}
