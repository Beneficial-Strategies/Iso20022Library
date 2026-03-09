// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card and check track format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ug3jsNkWEeiojJsa6FYyew")]
[Description(@"Card and check track format.")]
[Derivations(typeof(TrackFormat1Code))]
public enum TrackFormatCode
{
    /// <summary>
    /// ISO card track format - ISO 7813 - ISO 4909.
    /// Encoded/decoded by serializers as &quot;ISOF&quot;.
    /// </summary>
    [EnumMember(Value = "ISOF")]
    [IsoId("_ZVIj8NkWEeiojJsa6FYyew")]
    [Description(@"ISO card track format - ISO 7813 - ISO 4909.")]
    ISOFormat,
    
    /// <summary>
    /// Japanese track format I.
    /// Encoded/decoded by serializers as &quot;JIS1&quot;.
    /// </summary>
    [EnumMember(Value = "JIS1")]
    [IsoId("_c6T64NkWEeiojJsa6FYyew")]
    [Description(@"Japanese track format I.")]
    JISIFormat,
    
    /// <summary>
    /// Japanese track format II.
    /// Encoded/decoded by serializers as &quot;JIS2&quot;.
    /// </summary>
    [EnumMember(Value = "JIS2")]
    [IsoId("_g0ZK0NkWEeiojJsa6FYyew")]
    [Description(@"Japanese track format II.")]
    JISIIFormat,
    
    /// <summary>
    /// American driver license.
    /// Encoded/decoded by serializers as &quot;AAMV&quot;.
    /// </summary>
    [EnumMember(Value = "AAMV")]
    [IsoId("_jnsY4NkWEeiojJsa6FYyew")]
    [Description(@"American driver license.")]
    AAMVAFormat,
    
    /// <summary>
    /// Magnetic Ink Character Recognition, using the CMC-7 font - ISO 1004 Line at the bottom of a check containing the bank account and the check number.
    /// Encoded/decoded by serializers as &quot;CMC7&quot;.
    /// </summary>
    [EnumMember(Value = "CMC7")]
    [IsoId("_mjXf0NkWEeiojJsa6FYyew")]
    [Description(@"Magnetic Ink Character Recognition, using the CMC-7 font - ISO 1004 Line at the bottom of a check containing the bank account and the check number.")]
    CMC7CheckFormat,
    
    /// <summary>
    /// Magnetic Ink Character Recognition, using the E-13B font) Line at the bottom of a check containing the bank account and the check number.
    /// Encoded/decoded by serializers as &quot;E13B&quot;.
    /// </summary>
    [EnumMember(Value = "E13B")]
    [IsoId("_qGWeYNkWEeiojJsa6FYyew")]
    [Description(@"Magnetic Ink Character Recognition, using the E-13B font) Line at the bottom of a check containing the bank account and the check number.")]
    E13BCheckFormat,
    
}
