// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to protect the sensitive data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ar5eoJyAEeuo7tDc4CDHXg")]
[Description(@"Method used to protect the sensitive data.")]
[Derivations(typeof(ProtectionMethod1Code))]
public enum ProtectionMethodCode
{
    /// <summary>
    /// Software protection method.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_ihY0MJyAEeuo7tDc4CDHXg")]
    [Description(@"Software protection method.")]
    Software,
    
    /// <summary>
    /// Trusted execution environment method.
    /// Encoded/decoded by serializers as &quot;TEEN&quot;.
    /// </summary>
    [EnumMember(Value = "TEEN")]
    [IsoId("_nIdtAJyAEeuo7tDc4CDHXg")]
    [Description(@"Trusted execution environment method.")]
    TrustedExectutionEnvironment,
    
    /// <summary>
    /// Secure element method.
    /// Encoded/decoded by serializers as &quot;SELM&quot;.
    /// </summary>
    [EnumMember(Value = "SELM")]
    [IsoId("_v09jEJyAEeuo7tDc4CDHXg")]
    [Description(@"Secure element method.")]
    SecureElement,
    
    /// <summary>
    /// Secure enclave method.
    /// Encoded/decoded by serializers as &quot;SNCL&quot;.
    /// </summary>
    [EnumMember(Value = "SNCL")]
    [IsoId("_2HHdoJyAEeuo7tDc4CDHXg")]
    [Description(@"Secure enclave method.")]
    SecureEnclave,
    
    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6kwtoJyAEeuo7tDc4CDHXg")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate,
    
    /// <summary>
    /// Other code assigned by national organisation.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_KZ-S0JyBEeuo7tDc4CDHXg")]
    [Description(@"Other code assigned by national organisation.")]
    OtherNational,
    
    /// <summary>
    /// Trusted Platform Module (TPM).
    /// Encoded/decoded by serializers as &quot;TPMD&quot;.
    /// </summary>
    [EnumMember(Value = "TPMD")]
    [IsoId("_P8l5gKH1EeuiuNcvKhXmNQ")]
    [Description(@"Trusted Platform Module (TPM).")]
    TrustedPlatformModule,
    
    /// <summary>
    /// Virtual trusted execution environment	
    /// Encoded/decoded by serializers as &quot;VTEE&quot;.
    /// </summary>
    [EnumMember(Value = "VTEE")]
    [IsoId("_fMd9AKH1EeuiuNcvKhXmNQ")]
    [Description(@"Virtual trusted execution environment	")]
    VirtualTrustedExecutionEnvironment,
    
}
