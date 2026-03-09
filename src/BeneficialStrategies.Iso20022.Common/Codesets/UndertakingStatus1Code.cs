// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the undertaking transaction status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IWcDAHymEeGWJuGCfvwOsQ")]
[Description(@"Specifies the undertaking transaction status.")]
[DerivedFrom(typeof(UndertakingStatusCode))]
public enum UndertakingStatus1Code
{
    /// <summary>
    /// Accepted in accordance with technical validation.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_gYwzlnymEeGWJuGCfvwOsQ")]
    [Description(@"Accepted in accordance with technical validation.")]
    AcceptedTechnicalValidation = UndertakingStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending further processing.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_i6nFRnymEeGWJuGCfvwOsQ")]
    [Description(@"Pending further processing.")]
    Pending = UndertakingStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_kDL25nymEeGWJuGCfvwOsQ")]
    [Description(@"Received.")]
    Received = UndertakingStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_kTSIZnymEeGWJuGCfvwOsQ")]
    [Description(@"Rejected.")]
    Rejected = UndertakingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
