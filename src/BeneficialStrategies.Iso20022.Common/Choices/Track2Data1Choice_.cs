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
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format  conforms to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 35
    /// </summary>
    [KnownType(typeof(Track2Data1Choice.TextValue))]
    [KnownType(typeof(Track2Data1Choice.HexadecimalBinaryValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Track2Data1Choice.TextValue),nameof(Track2Data1Choice.TextValue))]
    [JsonDerivedType(typeof(Track2Data1Choice.HexadecimalBinaryValue),nameof(Track2Data1Choice.HexadecimalBinaryValue))]
    #endif
    [IsoId("_NkLQYEbbEeeIjf8aP9KbJA")]
    [DisplayName("Track 2 Data 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Track2Data1Choice_
    #else
    public abstract partial class Track2Data1Choice_
    #endif
    {
    }
}
