// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Response code of a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUAMMAEcEeCQm6a_G2yO_w_-1301117145")]
[Description(@"Response code of a transaction.")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response1Code
{
    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_TUAMMQEcEeCQm6a_G2yO_w_-710959612")]
    [Description(@"Service is declined.")]
    Declined = ResponseCode.Declined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_TUAMMgEcEeCQm6a_G2yO_w_-1594192899")]
    [Description(@"Service has been successfuly provided.")]
    Approved = ResponseCode.Approved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_TUAMMwEcEeCQm6a_G2yO_w_-563960777")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved = ResponseCode.PartialApproved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_TUAMNAEcEeCQm6a_G2yO_w_150956011")]
    [Description(@"Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).")]
    TechnicalError = ResponseCode.TechnicalError, // same ordinal as derivation source for type conversions
    
}
