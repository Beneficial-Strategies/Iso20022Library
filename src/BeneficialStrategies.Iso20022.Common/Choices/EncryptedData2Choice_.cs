// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Encrypted Data2Choice.
    /// </summary>
    [KnownType(typeof(EncryptedData2Choice.Binary))]
    [KnownType(typeof(EncryptedData2Choice.HexadecimalBinary))]
    [JsonDerivedType(typeof(EncryptedData2Choice.Binary), nameof(EncryptedData2Choice.Binary))]
    [JsonDerivedType(
        typeof(EncryptedData2Choice.HexadecimalBinary),
        nameof(EncryptedData2Choice.HexadecimalBinary)
    )]
    [IsoId("_FN8A0XdCEe6YlIMyoxWMJA")]
    [DisplayName("Encrypted Data2Choice")]
    public abstract record EncryptedData2Choice_ { }
}
