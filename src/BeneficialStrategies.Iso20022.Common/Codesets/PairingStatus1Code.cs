// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Pairing status for an individual transaction or report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sPf1AF54Ee2a_-MvhEjKmA")]
[Description(@"Pairing status for an individual transaction or report.")]
[DerivedFrom(typeof(PairingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PairingStatus1Code>))]
#endif
public enum PairingStatus1Code
{
    /// <summary>
    /// Transaction has been paired.
    /// Encoded/decoded by serializers as &quot;PARD&quot;.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_sPf1AV54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has been paired.")]
    Paired = PairingStatusCode.Paired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has not been paired.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_sPf1Al54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has not been paired.")]
    Unpaired = PairingStatusCode.Unpaired, // same ordinal as derivation source for type conversions
}
