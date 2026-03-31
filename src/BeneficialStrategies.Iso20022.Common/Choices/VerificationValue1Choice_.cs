// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Contains the data to be authenticated or verified.
    /// </summary>
    [KnownType(typeof(VerificationValue1Choice.TextValue))]
    [KnownType(typeof(VerificationValue1Choice.BinaryValue))]
    [KnownType(typeof(VerificationValue1Choice.HexadecimalBinaryValue))]
    [KnownType(typeof(VerificationValue1Choice.PINData))]
    [JsonDerivedType(
        typeof(VerificationValue1Choice.TextValue),
        nameof(VerificationValue1Choice.TextValue)
    )]
    [JsonDerivedType(
        typeof(VerificationValue1Choice.BinaryValue),
        nameof(VerificationValue1Choice.BinaryValue)
    )]
    [JsonDerivedType(
        typeof(VerificationValue1Choice.HexadecimalBinaryValue),
        nameof(VerificationValue1Choice.HexadecimalBinaryValue)
    )]
    [JsonDerivedType(
        typeof(VerificationValue1Choice.PINData),
        nameof(VerificationValue1Choice.PINData)
    )]
    [IsoId("_4EhKpZaNEemfCcEf5rVTyg")]
    [DisplayName("Verification Value 1 Choice")]
    public abstract record VerificationValue1Choice_ { }
}
