// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// PIN (Personal Identification Number) format used to encrypt the PIN block.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTtRTAEcEeCQm6a_G2yO_w_553869371")]
[Description(@"PIN (Personal Identification Number) format used to encrypt the PIN block.")]
[DerivedFrom(typeof(PINFormatCode))]
public enum PINFormat1Code
{
    /// <summary>
    /// PIN diversified with the card account number, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO0&quot;.
    /// </summary>
    [EnumMember(Value = "ISO0")]
    [IsoId("_TTtRTQEcEeCQm6a_G2yO_w_-36231100")]
    [Description(@"PIN diversified with the card account number, conforming to the standard ISO 9564-2.")]
    ISO0 = PINFormatCode.ISO0, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN completed with random padding characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO1&quot;.
    /// </summary>
    [EnumMember(Value = "ISO1")]
    [IsoId("_TTtRTgEcEeCQm6a_G2yO_w_325809407")]
    [Description(@"PIN completed with random padding characters, conforming to the standard ISO 9564-2.")]
    ISO1 = PINFormatCode.ISO1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN without diversification characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO2&quot;.
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_TTtRTwEcEeCQm6a_G2yO_w_-1049115605")]
    [Description(@"PIN without diversification characters, conforming to the standard ISO 9564-2.")]
    ISO2 = PINFormatCode.ISO2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO3&quot;.
    /// </summary>
    [EnumMember(Value = "ISO3")]
    [IsoId("_TTtRUAEcEeCQm6a_G2yO_w_888109568")]
    [Description(@"PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.")]
    ISO3 = PINFormatCode.ISO3, // same ordinal as derivation source for type conversions
    
}
