// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of PIN Service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I-AAkN7AEeiwsev40qZGEQ")]
[Description(@"Type of PIN Service.")]
[Derivations(typeof(PINRequestType1Code))]
public enum PINRequestTypeCode
{
    /// <summary>
    /// The Cardholder enters the PIN and the POI verifies it.
    /// Encoded/decoded by serializers as &quot;PIAV&quot;.
    /// </summary>
    [EnumMember(Value = "PIAV")]
    [IsoId("_L2uhMN7AEeiwsev40qZGEQ")]
    [Description(@"The Cardholder enters the PIN and the POI verifies it.")]
    PINAcquisitionVerification,

    /// <summary>
    /// The Sale System send a previous keyed PIN and the POI verifies it.
    /// Encoded/decoded by serializers as &quot;PIVO&quot;.
    /// </summary>
    [EnumMember(Value = "PIVO")]
    [IsoId("_OC4PsN7AEeiwsev40qZGEQ")]
    [Description(@"The Sale System send a previous keyed PIN and the POI verifies it.")]
    PINVerifyOnly,

    /// <summary>
    /// The cardholder enters the PIN, the POI enciphers the PIN Block and provides it as a result to the Sale System.
    /// Encoded/decoded by serializers as &quot;PIAE&quot;.
    /// </summary>
    [EnumMember(Value = "PIAE")]
    [IsoId("_QmJdsN7AEeiwsev40qZGEQ")]
    [Description(
        @"The cardholder enters the PIN, the POI enciphers the PIN Block and provides it as a result to the Sale System."
    )]
    PINAcquisitionEncryption,
}
