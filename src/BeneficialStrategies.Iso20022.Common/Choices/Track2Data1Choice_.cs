// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format  conforms to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 35
    /// </summary>
    [KnownType(typeof(Track2Data1Choice.TextValue))]
    [KnownType(typeof(Track2Data1Choice.HexadecimalBinaryValue))]
    [JsonDerivedType(typeof(Track2Data1Choice.TextValue),nameof(Track2Data1Choice.TextValue))]
    [JsonDerivedType(typeof(Track2Data1Choice.HexadecimalBinaryValue),nameof(Track2Data1Choice.HexadecimalBinaryValue))]
    [IsoId("_NkLQYEbbEeeIjf8aP9KbJA")]
    [DisplayName("Track 2 Data 1 Choice")]
    public abstract partial record Track2Data1Choice_
    {
    }
}
