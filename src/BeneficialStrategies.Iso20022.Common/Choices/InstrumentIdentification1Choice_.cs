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
    [KnownType(typeof(InstrumentIdentification1Choice.ISIN))]
    [KnownType(typeof(InstrumentIdentification1Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(InstrumentIdentification1Choice.UniqueProductIdentifier))]
    [KnownType(typeof(InstrumentIdentification1Choice.OtherIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstrumentIdentification1Choice.ISIN),nameof(InstrumentIdentification1Choice.ISIN))]
    [JsonDerivedType(typeof(InstrumentIdentification1Choice.AlternativeInstrumentIdentification),nameof(InstrumentIdentification1Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(InstrumentIdentification1Choice.UniqueProductIdentifier),nameof(InstrumentIdentification1Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(InstrumentIdentification1Choice.OtherIdentification),nameof(InstrumentIdentification1Choice.OtherIdentification))]
    #endif
    [IsoId("_vWHmMAbSEeqrW7Meu5r3kQ")]
    [DisplayName("Instrument Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstrumentIdentification1Choice_
    #else
    public abstract partial class InstrumentIdentification1Choice_
    #endif
    {
    }
}
