// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Use to identify format of a track on a card or other documents like checks.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ux3yUNkWEeiojJsa6FYyew")]
[Description(@"Use to identify format of a track on a card or other documents like checks.")]
[DerivedFrom(typeof(TrackFormatCode))]
public enum TrackFormat1Code
{
    /// <summary>
    /// American driver license.
    /// Encoded/decoded by serializers as &quot;AAMV&quot;.
    /// </summary>
    [EnumMember(Value = "AAMV")]
    [IsoId("_zTyeUdkWEeiojJsa6FYyew")]
    [Description(@"American driver license.")]
    AAMVAFormat = TrackFormatCode.AAMVAFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic Ink Character Recognition, using the CMC-7 font - ISO 1004 Line at the bottom of a check containing the bank account and the check number.
    /// Encoded/decoded by serializers as &quot;CMC7&quot;.
    /// </summary>
    [EnumMember(Value = "CMC7")]
    [IsoId("_zXWvsdkWEeiojJsa6FYyew")]
    [Description(
        @"Magnetic Ink Character Recognition, using the CMC-7 font - ISO 1004 Line at the bottom of a check containing the bank account and the check number."
    )]
    CMC7CheckFormat = TrackFormatCode.CMC7CheckFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic Ink Character Recognition, using the E-13B font) Line at the bottom of a check containing the bank account and the check number.
    /// Encoded/decoded by serializers as &quot;E13B&quot;.
    /// </summary>
    [EnumMember(Value = "E13B")]
    [IsoId("_zap7UdkWEeiojJsa6FYyew")]
    [Description(
        @"Magnetic Ink Character Recognition, using the E-13B font) Line at the bottom of a check containing the bank account and the check number."
    )]
    E13BCheckFormat = TrackFormatCode.E13BCheckFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISO card track format - ISO 7813 - ISO 4909.
    /// Encoded/decoded by serializers as &quot;ISOF&quot;.
    /// </summary>
    [EnumMember(Value = "ISOF")]
    [IsoId("_zfPgYdkWEeiojJsa6FYyew")]
    [Description(@"ISO card track format - ISO 7813 - ISO 4909.")]
    ISOFormat = TrackFormatCode.ISOFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Japanese track format I.
    /// Encoded/decoded by serializers as &quot;JIS1&quot;.
    /// </summary>
    [EnumMember(Value = "JIS1")]
    [IsoId("_zh8PEdkWEeiojJsa6FYyew")]
    [Description(@"Japanese track format I.")]
    JISIFormat = TrackFormatCode.JISIFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Japanese track format II.
    /// Encoded/decoded by serializers as &quot;JIS2&quot;.
    /// </summary>
    [EnumMember(Value = "JIS2")]
    [IsoId("_zlYkodkWEeiojJsa6FYyew")]
    [Description(@"Japanese track format II.")]
    JISIIFormat = TrackFormatCode.JISIIFormat, // same ordinal as derivation source for type conversions
}
