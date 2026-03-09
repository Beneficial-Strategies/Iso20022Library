// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Attestation status value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZlDPEAMkEeujMs2LsB3mMw")]
[Description(@"Attestation status value.")]
[Derivations(typeof(AttestationValue1Code))]
public enum AttestationValueCode
{
    /// <summary>
    /// Attestation claimed.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_tg4EUAMkEeujMs2LsB3mMw")]
    [Description(@"Attestation claimed.")]
    Claimed,
    
    /// <summary>
    /// Attestation not claimed.
    /// Encoded/decoded by serializers as &quot;NCLA&quot;.
    /// </summary>
    [EnumMember(Value = "NCLA")]
    [IsoId("_xlUxMAMkEeujMs2LsB3mMw")]
    [Description(@"Attestation not claimed.")]
    NotClaimed,
    
    /// <summary>
    /// Attestation validated.
    /// Encoded/decoded by serializers as &quot;HONO&quot;.
    /// </summary>
    [EnumMember(Value = "HONO")]
    [IsoId("_4sJp8AMkEeujMs2LsB3mMw")]
    [Description(@"Attestation validated.")]
    Honored,
    
    /// <summary>
    /// Attestation failed validation.
    /// Encoded/decoded by serializers as &quot;NHON&quot;.
    /// </summary>
    [EnumMember(Value = "NHON")]
    [IsoId("_91-DcAMkEeujMs2LsB3mMw")]
    [Description(@"Attestation failed validation.")]
    NotHonored,
    
}
