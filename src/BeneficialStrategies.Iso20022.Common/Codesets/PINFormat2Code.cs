// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// PIN (Personal Identification Number) format used before encryption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_B3AosAvFEeKzJ69IWwzB9Q")]
[Description(@"PIN (Personal Identification Number) format used before encryption.")]
[DerivedFrom(typeof(PINFormatCode))]
public enum PINFormat2Code
{
    /// <summary>
    /// PIN diversified with the card account number, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO0&quot;.
    /// </summary>
    [EnumMember(Value = "ISO0")]
    [IsoId("_DKxWoQvFEeKzJ69IWwzB9Q")]
    [Description(
        @"PIN diversified with the card account number, conforming to the standard ISO 9564-2."
    )]
    ISO0 = PINFormatCode.ISO0, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN completed with random padding characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO1&quot;.
    /// </summary>
    [EnumMember(Value = "ISO1")]
    [IsoId("_DSXMYwvFEeKzJ69IWwzB9Q")]
    [Description(
        @"PIN completed with random padding characters, conforming to the standard ISO 9564-2."
    )]
    ISO1 = PINFormatCode.ISO1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN without diversification characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO2&quot;.
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_DX3XcwvFEeKzJ69IWwzB9Q")]
    [Description(@"PIN without diversification characters, conforming to the standard ISO 9564-2.")]
    ISO2 = PINFormatCode.ISO2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO3&quot;.
    /// </summary>
    [EnumMember(Value = "ISO3")]
    [IsoId("_DgDDEQvFEeKzJ69IWwzB9Q")]
    [Description(
        @"PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2."
    )]
    ISO3 = PINFormatCode.ISO3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN format used with AES encryption, conforming to the new ISO SC2 format.
    /// Encoded/decoded by serializers as &quot;ISO4&quot;.
    /// </summary>
    [EnumMember(Value = "ISO4")]
    [IsoId("_DnyCwQvFEeKzJ69IWwzB9Q")]
    [Description(@"PIN format used with AES encryption, conforming to the new ISO SC2 format.")]
    ISO4 = PINFormatCode.ISO4, // same ordinal as derivation source for type conversions
}
