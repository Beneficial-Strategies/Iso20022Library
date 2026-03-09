// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Attestation status value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HnrOEAMlEeujMs2LsB3mMw")]
[Description(@"Attestation status value.")]
[DerivedFrom(typeof(AttestationValueCode))]
public enum AttestationValue1Code
{
    /// <summary>
    /// Attestation claimed.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_J41_cQMlEeujMs2LsB3mMw")]
    [Description(@"Attestation claimed.")]
    Claimed = AttestationValueCode.Claimed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Attestation validated.
    /// Encoded/decoded by serializers as &quot;HONO&quot;.
    /// </summary>
    [EnumMember(Value = "HONO")]
    [IsoId("_KERMUQMlEeujMs2LsB3mMw")]
    [Description(@"Attestation validated.")]
    Honored = AttestationValueCode.Honored, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Attestation not claimed.
    /// Encoded/decoded by serializers as &quot;NCLA&quot;.
    /// </summary>
    [EnumMember(Value = "NCLA")]
    [IsoId("_KOxzMQMlEeujMs2LsB3mMw")]
    [Description(@"Attestation not claimed.")]
    NotClaimed = AttestationValueCode.NotClaimed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Attestation failed validation.
    /// Encoded/decoded by serializers as &quot;NHON&quot;.
    /// </summary>
    [EnumMember(Value = "NHON")]
    [IsoId("_H6g1EQMmEeujMs2LsB3mMw")]
    [Description(@"Attestation failed validation.")]
    NotHonored = AttestationValueCode.NotHonored, // same ordinal as derivation source for type conversions
    
}
