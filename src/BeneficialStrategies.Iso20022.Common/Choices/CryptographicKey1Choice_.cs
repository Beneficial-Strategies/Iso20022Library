// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cryptographic Key1Choice.
    /// </summary>
    [KnownType(typeof(CryptographicKey1Choice.ILPV4))]
    [KnownType(typeof(CryptographicKey1Choice.Signature))]
    [JsonDerivedType(typeof(CryptographicKey1Choice.ILPV4),nameof(CryptographicKey1Choice.ILPV4))]
    [JsonDerivedType(typeof(CryptographicKey1Choice.Signature),nameof(CryptographicKey1Choice.Signature))]
    [IsoId("__lk0wD6wEe-QZYT2pcGFZw")]
    [DisplayName("Cryptographic Key1Choice")]
    public abstract partial record CryptographicKey1Choice_
    {
    }
}
