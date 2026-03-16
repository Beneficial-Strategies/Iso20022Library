// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between binary and hexadicimal binary for encrypted data of the transaction.
    /// </summary>
    [KnownType(typeof(EncryptedData1Choice.BinaryData))]
    [KnownType(typeof(EncryptedData1Choice.HexadecimalBinaryValue))]
    [JsonDerivedType(
        typeof(EncryptedData1Choice.BinaryData),
        nameof(EncryptedData1Choice.BinaryData)
    )]
    [JsonDerivedType(
        typeof(EncryptedData1Choice.HexadecimalBinaryValue),
        nameof(EncryptedData1Choice.HexadecimalBinaryValue)
    )]
    [IsoId("_-on80-kLEemeDPHh-U9b6w")]
    [DisplayName("Encrypted Data 1 Choice")]
    public abstract record EncryptedData1Choice_ { }
}
