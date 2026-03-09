// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity to perform verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lnn88BZNEeiXa46FI4OtcQ")]
[Description(@"Entity to perform verification.")]
[Derivations(typeof(VerificationEntity1Code),typeof(VerificationEntity2Code))]
public enum VerificationEntityCode
{
    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_eMluyBZNEeiXa46FI4OtcQ")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer,
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_eMluyRZNEeiXa46FI4OtcQ")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.")]
    Agent,
    
    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_eMluyxZNEeiXa46FI4OtcQ")]
    [Description(@"Card issuer.")]
    Issuer,
    
    /// <summary>
    /// Acceptor (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_eMluzBZNEeiXa46FI4OtcQ")]
    [Description(@"Acceptor (for example signature verification by the attendant).")]
    Acceptor,
    
    /// <summary>
    /// Other type of authentication entity defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_eMluzRZNEeiXa46FI4OtcQ")]
    [Description(@"Other type of authentication entity defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of authentication entity defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_eMluzhZNEeiXa46FI4OtcQ")]
    [Description(@"Other type of authentication entity defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Secure application in the terminal.
    /// Encoded/decoded by serializers as &quot;TRML&quot;.
    /// </summary>
    [EnumMember(Value = "TRML")]
    [IsoId("_eMluzxZNEeiXa46FI4OtcQ")]
    [Description(@"Secure application in the terminal.")]
    Terminal,
    
    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_RUwOUCbTEeyhZIgCcGlTyA")]
    [Description(@"Application in the smart card.")]
    CardApplication,
    
    /// <summary>
    /// Type of Device to accept payment
    /// Encoded/decoded by serializers as &quot;CDAD&quot;.
    /// </summary>
    [EnumMember(Value = "CDAD")]
    [IsoId("_Wn4U0CbTEeyhZIgCcGlTyA")]
    [Description(@"Type of Device to accept payment")]
    AcceptanceDevice,
    
}
