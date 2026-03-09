// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_soVKwCYDEeym0KcvJF9aDQ")]
[Description(@"Result of a verification.")]
[DerivedFrom(typeof(VerificationCode))]
public enum Verification3Code
{
    /// <summary>
    /// Verification failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_u1PuQSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification failed.")]
    Failed = VerificationCode.Failed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further action required.
    /// Encoded/decoded by serializers as &quot;FUTA&quot;.
    /// </summary>
    [EnumMember(Value = "FUTA")]
    [IsoId("_u50FMSYDEeym0KcvJF9aDQ")]
    [Description(@"Further action required.")]
    FurtherAction = VerificationCode.FurtherAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information required to perform the verification was missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_u-LAwSYDEeym0KcvJF9aDQ")]
    [Description(@"Information required to perform the verification was missing.")]
    Missing = VerificationCode.Missing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not support the verification type
    /// Encoded/decoded by serializers as &quot;NOSP&quot;.
    /// </summary>
    [EnumMember(Value = "NOSP")]
    [IsoId("_vCrtUSYDEeym0KcvJF9aDQ")]
    [Description(@"Not support the verification type")]
    NotSupported = VerificationCode.NotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification has not been performed.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_vGt4wSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification has not been performed.")]
    NotPerformed = VerificationCode.NotPerformed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other result of verification defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_vYRi0SYDEeym0KcvJF9aDQ")]
    [Description(@"Other result of verification defined at national level.")]
    OtherNational = VerificationCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other result of verification defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_vdmuwSYDEeym0KcvJF9aDQ")]
    [Description(@"Other result of verification defined at private level.")]
    OtherPrivate = VerificationCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification was partially successful.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_vhphQSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification was partially successful.")]
    PartialMatch = VerificationCode.PartialMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification was successful.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_vmhaMSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification was successful.")]
    Successful = VerificationCode.Successful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device or entity to perform the verification was unavailable.
    /// Encoded/decoded by serializers as &quot;ERRR&quot;.
    /// </summary>
    [EnumMember(Value = "ERRR")]
    [IsoId("_vqukwSYDEeym0KcvJF9aDQ")]
    [Description(@"Device or entity to perform the verification was unavailable.")]
    TechnicalError = VerificationCode.TechnicalError, // same ordinal as derivation source for type conversions
    
}
