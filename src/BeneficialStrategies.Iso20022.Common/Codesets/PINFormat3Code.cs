// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// PIN (Personal Identification Number) format used before encryption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WF5aYS_tEeO4w-IWHJMI9g")]
[Description(@"PIN (Personal Identification Number) format used before encryption.")]
[DerivedFrom(typeof(PINFormatCode))]
public enum PINFormat3Code
{
    /// <summary>
    /// PIN diversified with the card account number, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO0&quot;.
    /// </summary>
    [EnumMember(Value = "ISO0")]
    [IsoId("_WUeo8S_tEeO4w-IWHJMI9g")]
    [Description(
        @"PIN diversified with the card account number, conforming to the standard ISO 9564-2."
    )]
    ISO0 = PINFormatCode.ISO0, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN completed with random padding characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO1&quot;.
    /// </summary>
    [EnumMember(Value = "ISO1")]
    [IsoId("_WUeo8y_tEeO4w-IWHJMI9g")]
    [Description(
        @"PIN completed with random padding characters, conforming to the standard ISO 9564-2."
    )]
    ISO1 = PINFormatCode.ISO1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN without diversification characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO2&quot;.
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_WUeo9S_tEeO4w-IWHJMI9g")]
    [Description(@"PIN without diversification characters, conforming to the standard ISO 9564-2.")]
    ISO2 = PINFormatCode.ISO2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO3&quot;.
    /// </summary>
    [EnumMember(Value = "ISO3")]
    [IsoId("_WUeo9y_tEeO4w-IWHJMI9g")]
    [Description(
        @"PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2."
    )]
    ISO3 = PINFormatCode.ISO3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN format used with AES encryption, conforming to the new ISO SC2 format.
    /// Encoded/decoded by serializers as &quot;ISO4&quot;.
    /// </summary>
    [EnumMember(Value = "ISO4")]
    [IsoId("_WUeo-S_tEeO4w-IWHJMI9g")]
    [Description(@"PIN format used with AES encryption, conforming to the new ISO SC2 format.")]
    ISO4 = PINFormatCode.ISO4, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Alternative PIN format used with AES encryption, conforming to the new ISO SC2 format.
    /// Encoded/decoded by serializers as &quot;ISO5&quot;.
    /// </summary>
    [EnumMember(Value = "ISO5")]
    [IsoId("_X1B1sS_tEeO4w-IWHJMI9g")]
    [Description(
        @"Alternative PIN format used with AES encryption, conforming to the new ISO SC2 format."
    )]
    ISO5 = PINFormatCode.ISO5, // same ordinal as derivation source for type conversions
}
