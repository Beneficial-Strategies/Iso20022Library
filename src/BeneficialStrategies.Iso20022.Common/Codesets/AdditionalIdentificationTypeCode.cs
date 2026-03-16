// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the additoinal identification type, for example NAICS, etc...
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AEXIl_JXEeiJn9rM2Znz2w")]
[Description(@"Contains the additoinal identification type, for example NAICS, etc...")]
[Derivations(typeof(AdditionalIdentificationType1Code))]
public enum AdditionalIdentificationTypeCode
{
    /// <summary>
    /// Contains the Austin-Tetra Number assigned to the card acceptor.
    /// Encoded/decoded by serializers as &quot;ATNU&quot;.
    /// </summary>
    [EnumMember(Value = "ATNU")]
    [IsoId("_AEXInfJXEeiJn9rM2Znz2w")]
    [Description(@"Contains the Austin-Tetra Number assigned to the card acceptor.")]
    AustinTetra,

    /// <summary>
    /// Contains the North American Industry Classification System (NAICS) code assigned to the card acceptor.
    /// Encoded/decoded by serializers as &quot;ICSN&quot;.
    /// </summary>
    [EnumMember(Value = "ICSN")]
    [IsoId("_AEXImfJXEeiJn9rM2Znz2w")]
    [Description(
        @"Contains the North American Industry Classification System (NAICS) code assigned to the card acceptor."
    )]
    NAICS,

    /// <summary>
    /// Other Additional Identification defined at a national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_AEXImvJXEeiJn9rM2Znz2w")]
    [Description(@"Other Additional Identification defined at a national level.")]
    OtherNational,

    /// <summary>
    /// Other Additional Identification defined at a private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_AEXInPJXEeiJn9rM2Znz2w")]
    [Description(@"Other Additional Identification defined at a private level.")]
    OtherPrivate,
}
